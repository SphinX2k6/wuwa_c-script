using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;
using UnrealEngine;

namespace CSharpScript.Game.Module.Audio
{
	// Token: 0x02005E94 RID: 24212
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleAudioVolumeInfo : IStaticVariableResetter
	{
		// Token: 0x0603D981 RID: 252289 RVA: 0x00EDEDE2 File Offset: 0x00EDCFE2
		static RoleAudioVolumeInfo()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RoleAudioVolumeInfo.CreateStaticDefaultValue), new Action(RoleAudioVolumeInfo.ResetStaticDefaultValue));
		}

		// Token: 0x17008E93 RID: 36499
		// (get) Token: 0x0603D982 RID: 252290 RVA: 0x00EDEE01 File Offset: 0x00EDD001
		public static List<string> CheckEventList
		{
			get
			{
				return RoleAudioVolumeInfo.CheckEventListInternal;
			}
		}

		// Token: 0x0603D983 RID: 252291 RVA: 0x00EDEE08 File Offset: 0x00EDD008
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

		// Token: 0x0603D984 RID: 252292 RVA: 0x00EDEEEC File Offset: 0x00EDD0EC
		public void Clear()
		{
			EventSystem.Instance.Remove(EEventName.OnUpdateSceneTeam, new Action(this.OnUpdateSceneTeam));
		}

		// Token: 0x0603D985 RID: 252293 RVA: 0x00EDEF0A File Offset: 0x00EDD10A
		public void Update()
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			if (baseCharacter != null && baseCharacter.IsValid())
			{
				this.RoleAudioHandleMap.UpdateVolume();
			}
		}

		// Token: 0x0603D986 RID: 252294 RVA: 0x00EDEF2C File Offset: 0x00EDD12C
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

		// Token: 0x0603D987 RID: 252295 RVA: 0x00EDF060 File Offset: 0x00EDD260
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

		// Token: 0x0603D988 RID: 252296 RVA: 0x00EDF08C File Offset: 0x00EDD28C
		private void OnUpdateSceneTeam()
		{
			this.RoleAudioHandleMap.OnUpdateTeam();
		}

		// Token: 0x0603D989 RID: 252297 RVA: 0x00EDF09C File Offset: 0x00EDD29C
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

		// Token: 0x0603D98A RID: 252298 RVA: 0x00EDF0DF File Offset: 0x00EDD2DF
		public static void CreateStaticDefaultValue()
		{
			RoleAudioVolumeInfo.CheckEventListInternal = new List<string>();
		}

		// Token: 0x0603D98B RID: 252299 RVA: 0x00EDF0EB File Offset: 0x00EDD2EB
		public static void ResetStaticDefaultValue()
		{
			RoleAudioVolumeInfo.MaxDistanceSquared = 0.0;
			RoleAudioVolumeInfo.SplitDistanceSquared = 0.0;
			RoleAudioVolumeInfo.DelayTime = 0;
			RoleAudioVolumeInfo.CorrectionRatio = 0.0;
			RoleAudioVolumeInfo.CheckEventListInternal = null;
		}

		// Token: 0x0402024F RID: 131663
		public static double MaxDistanceSquared;

		// Token: 0x04020250 RID: 131664
		public static double SplitDistanceSquared;

		// Token: 0x04020251 RID: 131665
		public static int DelayTime;

		// Token: 0x04020252 RID: 131666
		public static double CorrectionRatio;

		// Token: 0x04020253 RID: 131667
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static List<string> CheckEventListInternal;

		// Token: 0x04020254 RID: 131668
		private readonly RoleVolumeMapInfo RoleAudioHandleMap = new RoleVolumeMapInfo();
	}
}
