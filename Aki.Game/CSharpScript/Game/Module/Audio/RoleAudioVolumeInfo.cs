using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;
using UnrealEngine;

namespace CSharpScript.Game.Module.Audio
{
	// Token: 0x02004E79 RID: 20089
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleAudioVolumeInfo : IStaticVariableResetter
	{
		// Token: 0x06032911 RID: 207121 RVA: 0x00E30372 File Offset: 0x00E2E572
		static RoleAudioVolumeInfo()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RoleAudioVolumeInfo.CreateStaticDefaultValue), new Action(RoleAudioVolumeInfo.ResetStaticDefaultValue));
		}

		// Token: 0x17006265 RID: 25189
		// (get) Token: 0x06032912 RID: 207122 RVA: 0x00E30391 File Offset: 0x00E2E591
		public static List<string> CheckEventList
		{
			get
			{
				return RoleAudioVolumeInfo.CheckEventListInternal;
			}
		}

		// Token: 0x06032913 RID: 207123 RVA: 0x00E30398 File Offset: 0x00E2E598
		public void Init()
		{
			int valueOrDefault = ConfigCommonParamById.GetIntConfig("BgmMaxDistance").GetValueOrDefault();
			RoleAudioVolumeInfo.MaxDistanceSquared = (double)(valueOrDefault * valueOrDefault);
			int valueOrDefault2 = ConfigCommonParamById.GetIntConfig("BgmSplitDistance").GetValueOrDefault();
			RoleAudioVolumeInfo.SplitDistanceSquared = (double)(valueOrDefault2 * valueOrDefault2);
			RoleAudioVolumeInfo.DelayTime = ConfigCommonParamById.GetIntConfig("BgmDelayTime").GetValueOrDefault();
			RoleAudioVolumeInfo.CorrectionRatio = (double)ConfigCommonParamById.GetFloatConfig("BgmCorrectionRatio").GetValueOrDefault();
			IReadOnlyList<string> stringArrayConfig = ConfigCommonParamById.GetStringArrayConfig("BgmCheckEventList");
			if (stringArrayConfig != null && stringArrayConfig.Count > 0)
			{
				foreach (string item in stringArrayConfig)
				{
					RoleAudioVolumeInfo.CheckEventList.Add(item);
				}
			}
			EventSystem.Instance.Add(EEventName.OnUpdateSceneTeam, new Action(this.OnUpdateSceneTeam));
		}

		// Token: 0x06032914 RID: 207124 RVA: 0x00E3047C File Offset: 0x00E2E67C
		public void Clear()
		{
			EventSystem.Instance.Remove(EEventName.OnUpdateSceneTeam, new Action(this.OnUpdateSceneTeam));
		}

		// Token: 0x06032915 RID: 207125 RVA: 0x00E3049A File Offset: 0x00E2E69A
		public void Update()
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			if (baseCharacter != null && baseCharacter.IsValid())
			{
				this.RoleAudioHandleMap.UpdateVolume();
			}
		}

		// Token: 0x06032916 RID: 207126 RVA: 0x00E304BC File Offset: 0x00E2E6BC
		public int PostEvent(AActor owner, string eventName, FName? socket = null)
		{
			UAkComponent akComponent = GameAudioController.Instance.GetAkComponent(owner, socket);
			if (akComponent == null || !akComponent.IsValid())
			{
				return 0;
			}
			bool flag = false;
			int handle = 0;
			if (RoleAudioVolumeInfo.CheckEventList.Contains(eventName))
			{
				TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
				if (tsBaseCharacter != null)
				{
					int entityId = tsBaseCharacter.EntityId;
					CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
					int? num = (characterActorComponent != null) ? new int?(characterActorComponent.CreatureData.GetPbDataId()) : null;
					int num2 = (num != null) ? RoleAudioVolumeInfo.GetRoleId(num.Value) : 0;
					if (num2 != 0)
					{
						handle = AudioSystem.Instance.PostEvent(eventName, akComponent, new PostEventArgs?(new PostEventArgs
						{
							CallbackMask = new ECallbackMask?(ECallbackMask.EndOfEvent),
							CallbackHandler = delegate(EAkCallbackType callbackType, UAkCallbackInfo callbackInfo)
							{
								this.RoleAudioHandleMap.RemoveEvent(entityId, handle);
							}
						}));
						this.RoleAudioHandleMap.AddEvent(entityId, num2, handle, eventName, tsBaseCharacter);
						flag = true;
					}
				}
			}
			if (!flag)
			{
				handle = AudioSystem.Instance.PostEvent(eventName, akComponent, null);
			}
			return handle;
		}

		// Token: 0x06032917 RID: 207127 RVA: 0x00E305F0 File Offset: 0x00E2E7F0
		public void RemoveEvent(AActor owner, int handle)
		{
			TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
			if (tsBaseCharacter == null)
			{
				return;
			}
			int entityId = tsBaseCharacter.EntityId;
			this.RoleAudioHandleMap.RemoveEvent(entityId, handle);
		}

		// Token: 0x06032918 RID: 207128 RVA: 0x00E3061C File Offset: 0x00E2E81C
		private void OnUpdateSceneTeam()
		{
			this.RoleAudioHandleMap.OnUpdateTeam();
		}

		// Token: 0x06032919 RID: 207129 RVA: 0x00E3062C File Offset: 0x00E2E82C
		public static int GetRoleId(int pbDataId)
		{
			int baseRoleId = RoleConfig.Instance.GetBaseRoleId(pbDataId);
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(baseRoleId);
			if (roleConfig == null || roleConfig.Value.RoleType != 1)
			{
				return 0;
			}
			return baseRoleId;
		}

		// Token: 0x0603291A RID: 207130 RVA: 0x00E3066F File Offset: 0x00E2E86F
		public static void CreateStaticDefaultValue()
		{
			RoleAudioVolumeInfo.CheckEventListInternal = new List<string>();
		}

		// Token: 0x0603291B RID: 207131 RVA: 0x00E3067B File Offset: 0x00E2E87B
		public static void ResetStaticDefaultValue()
		{
			RoleAudioVolumeInfo.MaxDistanceSquared = 0.0;
			RoleAudioVolumeInfo.SplitDistanceSquared = 0.0;
			RoleAudioVolumeInfo.DelayTime = 0;
			RoleAudioVolumeInfo.CorrectionRatio = 0.0;
			RoleAudioVolumeInfo.CheckEventListInternal = null;
		}

		// Token: 0x0401AD16 RID: 109846
		public static double MaxDistanceSquared;

		// Token: 0x0401AD17 RID: 109847
		public static double SplitDistanceSquared;

		// Token: 0x0401AD18 RID: 109848
		public static int DelayTime;

		// Token: 0x0401AD19 RID: 109849
		public static double CorrectionRatio;

		// Token: 0x0401AD1A RID: 109850
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static List<string> CheckEventListInternal;

		// Token: 0x0401AD1B RID: 109851
		private readonly RoleVolumeMapInfo RoleAudioHandleMap = new RoleVolumeMapInfo();
	}
}
