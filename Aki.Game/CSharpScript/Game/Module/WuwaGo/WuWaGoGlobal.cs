using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using AkiClient.Game.Aki.Data.Gameplay.WuWaGo;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x02004719 RID: 18201
	[NullableContext(2)]
	[Nullable(0)]
	public class WuWaGoGlobal : IStaticVariableResetter
	{
		// Token: 0x0602F8E7 RID: 194791 RVA: 0x00B03C0A File Offset: 0x00B01E0A
		static WuWaGoGlobal()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(WuWaGoGlobal.CreateStaticDefaultValue), new Action(WuWaGoGlobal.ResetStaticDefaultValue));
		}

		// Token: 0x0602F8E8 RID: 194792 RVA: 0x00B03C29 File Offset: 0x00B01E29
		public static void CreateStaticDefaultValue()
		{
			WuWaGoGlobal._roleAttackAnimMap = new Dictionary<EWuWaGoRoleType, List<UAnimMontage>>();
			WuWaGoGlobal._roleDeathAnimMap = new Dictionary<EWuWaGoRoleType, List<UAnimMontage>>();
			WuWaGoGlobal._roleBeHitAnimMap = new Dictionary<EWuWaGoRoleType, List<UAnimMontage>>();
			WuWaGoGlobal._roleClimbAnimMap = new Dictionary<EWuWaGoRoleType, Dictionary<EWuWaGoClimbMontage, UAnimMontage>>();
			WuWaGoGlobal._preloadedAudioEvents = new HashSet<string>();
		}

		// Token: 0x0602F8E9 RID: 194793 RVA: 0x00B03C60 File Offset: 0x00B01E60
		public static void ResetStaticDefaultValue()
		{
			WuWaGoGlobal.ReleaseAudioEvents();
			WuWaGoGlobal._settingDataAsset = null;
			WuWaGoGlobal._roleAttackAnimMap = null;
			WuWaGoGlobal._roleDeathAnimMap = null;
			WuWaGoGlobal._roleBeHitAnimMap = null;
			WuWaGoGlobal._roleClimbAnimMap = null;
			WuWaGoGlobal._mainControlPullRodOpenMontage = null;
			WuWaGoGlobal._mainControlPullRodCloseMontage = null;
			WuWaGoGlobal._spikeFallMontage = null;
			WuWaGoGlobal._alertMontage = null;
			WuWaGoGlobal._idleMontage = null;
			WuWaGoGlobal._preloadedAudioEvents = null;
		}

		// Token: 0x170076EF RID: 30447
		// (get) Token: 0x0602F8EA RID: 194794 RVA: 0x00B03CB4 File Offset: 0x00B01EB4
		public static BP_WuWaGo_C Setting
		{
			get
			{
				if (WuWaGoGlobal._settingDataAsset == null)
				{
					Log.Instance.Error(ELogModule.WuWaGo, ELogAuthor.YSQ, "SettingDataAsset is null", default(ReadOnlySpan<ValueTuple<string, object>>));
					return null;
				}
				return WuWaGoGlobal._settingDataAsset;
			}
		}

		// Token: 0x0602F8EB RID: 194795 RVA: 0x00B03CF0 File Offset: 0x00B01EF0
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public static UniTask<BP_WuWaGo_C> LoadSettingData()
		{
			WuWaGoGlobal.<LoadSettingData>d__17 <LoadSettingData>d__;
			<LoadSettingData>d__.<>t__builder = AsyncUniTaskMethodBuilder<BP_WuWaGo_C>.Create();
			<LoadSettingData>d__.<>1__state = -1;
			<LoadSettingData>d__.<>t__builder.Start<WuWaGoGlobal.<LoadSettingData>d__17>(ref <LoadSettingData>d__);
			return <LoadSettingData>d__.<>t__builder.Task;
		}

		// Token: 0x0602F8EC RID: 194796 RVA: 0x00B03D2C File Offset: 0x00B01F2C
		public static void ClearSettingData()
		{
			WuWaGoGlobal.ReleaseAudioEvents();
			WuWaGoGlobal._settingDataAsset = null;
			Dictionary<EWuWaGoRoleType, List<UAnimMontage>> roleAttackAnimMap = WuWaGoGlobal._roleAttackAnimMap;
			if (roleAttackAnimMap != null)
			{
				roleAttackAnimMap.Clear();
			}
			Dictionary<EWuWaGoRoleType, List<UAnimMontage>> roleDeathAnimMap = WuWaGoGlobal._roleDeathAnimMap;
			if (roleDeathAnimMap != null)
			{
				roleDeathAnimMap.Clear();
			}
			Dictionary<EWuWaGoRoleType, List<UAnimMontage>> roleBeHitAnimMap = WuWaGoGlobal._roleBeHitAnimMap;
			if (roleBeHitAnimMap != null)
			{
				roleBeHitAnimMap.Clear();
			}
			Dictionary<EWuWaGoRoleType, Dictionary<EWuWaGoClimbMontage, UAnimMontage>> roleClimbAnimMap = WuWaGoGlobal._roleClimbAnimMap;
			if (roleClimbAnimMap != null)
			{
				roleClimbAnimMap.Clear();
			}
			WuWaGoGlobal._mainControlPullRodOpenMontage = null;
			WuWaGoGlobal._mainControlPullRodCloseMontage = null;
			WuWaGoGlobal._spikeFallMontage = null;
			WuWaGoGlobal._alertMontage = null;
			WuWaGoGlobal._idleMontage = null;
		}

		// Token: 0x0602F8ED RID: 194797 RVA: 0x00B03DA4 File Offset: 0x00B01FA4
		public static string GetRoleClassPath(EWuWaGoRoleType type)
		{
			string result = null;
			switch (type)
			{
			case EWuWaGoRoleType.AircraftSoldiers:
			{
				BP_WuWaGo_C setting = WuWaGoGlobal.Setting;
				result = ((setting != null) ? setting.MainControlClass.ToAssetPathName() : null);
				break;
			}
			case EWuWaGoRoleType.HeatFusionEnemy:
			{
				BP_WuWaGo_C setting2 = WuWaGoGlobal.Setting;
				result = ((setting2 != null) ? setting2.StaticMonsterClass.ToAssetPathName() : null);
				break;
			}
			case EWuWaGoRoleType.DiffractionEnemy:
			{
				BP_WuWaGo_C setting3 = WuWaGoGlobal.Setting;
				result = ((setting3 != null) ? setting3.MoveMonsterClass.ToAssetPathName() : null);
				break;
			}
			}
			return result;
		}

		// Token: 0x0602F8EE RID: 194798 RVA: 0x00B03E14 File Offset: 0x00B02014
		public static string GetRoleAnimClassPath(EWuWaGoRoleType type)
		{
			string result = null;
			switch (type)
			{
			case EWuWaGoRoleType.AircraftSoldiers:
			{
				BP_WuWaGo_C setting = WuWaGoGlobal.Setting;
				result = ((setting != null) ? setting.MainControlAnimationBlueprint.ToAssetPathName() : null);
				break;
			}
			case EWuWaGoRoleType.DiffractionEnemy:
			{
				BP_WuWaGo_C setting2 = WuWaGoGlobal.Setting;
				result = ((setting2 != null) ? setting2.MoveMonsterAnimationBlueprint.ToAssetPathName() : null);
				break;
			}
			}
			return result;
		}

		// Token: 0x0602F8EF RID: 194799 RVA: 0x00B03E68 File Offset: 0x00B02068
		public static string GetMonsterAttackRangeEffect(EWuWaGoRoleType type)
		{
			string result = null;
			switch (type)
			{
			case EWuWaGoRoleType.HeatFusionEnemy:
			{
				BP_WuWaGo_C setting = WuWaGoGlobal.Setting;
				result = ((setting != null) ? setting.StaticMonsterAttackRangeEffect.ToAssetPathName() : null);
				break;
			}
			case EWuWaGoRoleType.DiffractionEnemy:
			{
				BP_WuWaGo_C setting2 = WuWaGoGlobal.Setting;
				result = ((setting2 != null) ? setting2.MoveMonsterAttackRangeEffect.ToAssetPathName() : null);
				break;
			}
			}
			return result;
		}

		// Token: 0x0602F8F0 RID: 194800 RVA: 0x00B03EBC File Offset: 0x00B020BC
		public static string GetAppliqueMaterialPath(EWuWaGoGridLinkType linkType)
		{
			if (WuWaGoGlobal.Setting == null)
			{
				return null;
			}
			string result = null;
			switch (linkType)
			{
			case EWuWaGoGridLinkType.SingleLinkGrid:
				result = WuWaGoGlobal.Setting.SingleLinkGridMaterial.ToAssetPathName();
				break;
			case EWuWaGoGridLinkType.RightAngleLinkGrid:
				result = WuWaGoGlobal.Setting.RightAngleLinkGridMaterial.ToAssetPathName();
				break;
			case EWuWaGoGridLinkType.ThreeLinkGrid:
				result = WuWaGoGlobal.Setting.ThreeLinkGridMaterial.ToAssetPathName();
				break;
			case EWuWaGoGridLinkType.StraightLinkGrid:
				result = WuWaGoGlobal.Setting.StraightLinkGridMaterial.ToAssetPathName();
				break;
			case EWuWaGoGridLinkType.AllLinkGrid:
				result = WuWaGoGlobal.Setting.AllLinkGridMaterial.ToAssetPathName();
				break;
			}
			return result;
		}

		// Token: 0x0602F8F1 RID: 194801 RVA: 0x00B03F4B File Offset: 0x00B0214B
		[NullableContext(1)]
		public static List<UAnimMontage> GetRoleAttackAnimations(EWuWaGoRoleType type)
		{
			Dictionary<EWuWaGoRoleType, List<UAnimMontage>> roleAttackAnimMap = WuWaGoGlobal._roleAttackAnimMap;
			return ((roleAttackAnimMap != null) ? roleAttackAnimMap.GetValueOrDefault(type) : null) ?? new List<UAnimMontage>();
		}

		// Token: 0x0602F8F2 RID: 194802 RVA: 0x00B03F68 File Offset: 0x00B02168
		[NullableContext(1)]
		public static List<UAnimMontage> GetRoleDeathAnimations(EWuWaGoRoleType type)
		{
			Dictionary<EWuWaGoRoleType, List<UAnimMontage>> roleDeathAnimMap = WuWaGoGlobal._roleDeathAnimMap;
			return ((roleDeathAnimMap != null) ? roleDeathAnimMap.GetValueOrDefault(type) : null) ?? new List<UAnimMontage>();
		}

		// Token: 0x0602F8F3 RID: 194803 RVA: 0x00B03F85 File Offset: 0x00B02185
		[NullableContext(1)]
		public static List<UAnimMontage> GetRoleBeHitAnimations(EWuWaGoRoleType type)
		{
			Dictionary<EWuWaGoRoleType, List<UAnimMontage>> roleBeHitAnimMap = WuWaGoGlobal._roleBeHitAnimMap;
			return ((roleBeHitAnimMap != null) ? roleBeHitAnimMap.GetValueOrDefault(type) : null) ?? new List<UAnimMontage>();
		}

		// Token: 0x0602F8F4 RID: 194804 RVA: 0x00B03FA2 File Offset: 0x00B021A2
		public static UAnimMontage GetRoleClimbMontage(EWuWaGoRoleType type, EWuWaGoClimbMontage action)
		{
			Dictionary<EWuWaGoRoleType, Dictionary<EWuWaGoClimbMontage, UAnimMontage>> roleClimbAnimMap = WuWaGoGlobal._roleClimbAnimMap;
			if (roleClimbAnimMap == null)
			{
				return null;
			}
			Dictionary<EWuWaGoClimbMontage, UAnimMontage> valueOrDefault = roleClimbAnimMap.GetValueOrDefault(type);
			if (valueOrDefault == null)
			{
				return null;
			}
			return valueOrDefault.GetValueOrDefault(action);
		}

		// Token: 0x0602F8F5 RID: 194805 RVA: 0x00B03FC1 File Offset: 0x00B021C1
		public static UAnimMontage GetMainControlPullRodMontageByState(EGameplayEntityState currentState)
		{
			if (currentState == EGameplayEntityState.Normal)
			{
				return WuWaGoGlobal._mainControlPullRodOpenMontage;
			}
			if (currentState != EGameplayEntityState.Activated)
			{
				return null;
			}
			return WuWaGoGlobal._mainControlPullRodCloseMontage;
		}

		// Token: 0x0602F8F6 RID: 194806 RVA: 0x00B03FDA File Offset: 0x00B021DA
		public static UAnimMontage GetSpikeFallMontage()
		{
			return WuWaGoGlobal._spikeFallMontage;
		}

		// Token: 0x0602F8F7 RID: 194807 RVA: 0x00B03FE1 File Offset: 0x00B021E1
		public static UAnimMontage GetAlertMontage()
		{
			return WuWaGoGlobal._alertMontage;
		}

		// Token: 0x0602F8F8 RID: 194808 RVA: 0x00B03FE8 File Offset: 0x00B021E8
		public static UAnimMontage GetIdleMontage()
		{
			return WuWaGoGlobal._idleMontage;
		}

		// Token: 0x0602F8F9 RID: 194809 RVA: 0x00B03FF0 File Offset: 0x00B021F0
		public static string GetAudioEvent(EWuWaGoAudioEventIndex index)
		{
			BP_WuWaGo_C setting = WuWaGoGlobal.Setting;
			TArray<string> tarray = (setting != null) ? setting.AudioEvents : null;
			if (tarray == null || index < EWuWaGoAudioEventIndex.MovableFloorMove || index >= (EWuWaGoAudioEventIndex)tarray.Num())
			{
				return null;
			}
			return WuWaGoGlobal.ParseAudioEventName(tarray.Get((int)index));
		}

		// Token: 0x0602F8FA RID: 194810 RVA: 0x00B04030 File Offset: 0x00B02230
		private static UniTask PreloadRoleAnimations()
		{
			WuWaGoGlobal.<PreloadRoleAnimations>d__32 <PreloadRoleAnimations>d__;
			<PreloadRoleAnimations>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PreloadRoleAnimations>d__.<>1__state = -1;
			<PreloadRoleAnimations>d__.<>t__builder.Start<WuWaGoGlobal.<PreloadRoleAnimations>d__32>(ref <PreloadRoleAnimations>d__);
			return <PreloadRoleAnimations>d__.<>t__builder.Task;
		}

		// Token: 0x0602F8FB RID: 194811 RVA: 0x00B0406C File Offset: 0x00B0226C
		private static void PreloadAudioEvents(BP_WuWaGo_C setting)
		{
			TArray<string> tarray = (setting != null) ? setting.AudioEvents : null;
			if (tarray == null)
			{
				return;
			}
			for (int i = 0; i < tarray.Num(); i++)
			{
				string text = WuWaGoGlobal.ParseAudioEventName(tarray.Get(i));
				if (text != null)
				{
					HashSet<string> preloadedAudioEvents = WuWaGoGlobal._preloadedAudioEvents;
					if (preloadedAudioEvents == null || !preloadedAudioEvents.Contains(text))
					{
						AudioSystem.Instance.PreloadAudioEvent(text);
						HashSet<string> preloadedAudioEvents2 = WuWaGoGlobal._preloadedAudioEvents;
						if (preloadedAudioEvents2 != null)
						{
							preloadedAudioEvents2.Add(text);
						}
					}
				}
			}
		}

		// Token: 0x0602F8FC RID: 194812 RVA: 0x00B040DC File Offset: 0x00B022DC
		private static void ReleaseAudioEvents()
		{
			if (WuWaGoGlobal._preloadedAudioEvents == null)
			{
				return;
			}
			foreach (string @event in WuWaGoGlobal._preloadedAudioEvents)
			{
				AudioSystem.Instance.ReleaseAudioEvent(@event);
			}
			WuWaGoGlobal._preloadedAudioEvents.Clear();
		}

		// Token: 0x0602F8FD RID: 194813 RVA: 0x00B04144 File Offset: 0x00B02344
		private static string ParseAudioEventName(string source)
		{
			if (source == null || StringUtils.IsBlank(source))
			{
				return null;
			}
			string text = AudioSystem.Instance.parseAudioEventPath(source);
			if (!(text == "none"))
			{
				return text;
			}
			return null;
		}

		// Token: 0x0602F8FE RID: 194814 RVA: 0x00B0417C File Offset: 0x00B0237C
		[NullableContext(1)]
		private static UniTask PreloadMainControlPullRodMontages(BP_WuWaGo_C setting)
		{
			WuWaGoGlobal.<PreloadMainControlPullRodMontages>d__36 <PreloadMainControlPullRodMontages>d__;
			<PreloadMainControlPullRodMontages>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PreloadMainControlPullRodMontages>d__.setting = setting;
			<PreloadMainControlPullRodMontages>d__.<>1__state = -1;
			<PreloadMainControlPullRodMontages>d__.<>t__builder.Start<WuWaGoGlobal.<PreloadMainControlPullRodMontages>d__36>(ref <PreloadMainControlPullRodMontages>d__);
			return <PreloadMainControlPullRodMontages>d__.<>t__builder.Task;
		}

		// Token: 0x0602F8FF RID: 194815 RVA: 0x00B041C0 File Offset: 0x00B023C0
		[NullableContext(1)]
		private static UniTask PreloadSpikeFallMontage(BP_WuWaGo_C setting)
		{
			WuWaGoGlobal.<PreloadSpikeFallMontage>d__37 <PreloadSpikeFallMontage>d__;
			<PreloadSpikeFallMontage>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PreloadSpikeFallMontage>d__.setting = setting;
			<PreloadSpikeFallMontage>d__.<>1__state = -1;
			<PreloadSpikeFallMontage>d__.<>t__builder.Start<WuWaGoGlobal.<PreloadSpikeFallMontage>d__37>(ref <PreloadSpikeFallMontage>d__);
			return <PreloadSpikeFallMontage>d__.<>t__builder.Task;
		}

		// Token: 0x0602F900 RID: 194816 RVA: 0x00B04204 File Offset: 0x00B02404
		[NullableContext(1)]
		private static UniTask PreloadAlertMontage(BP_WuWaGo_C setting)
		{
			WuWaGoGlobal.<PreloadAlertMontage>d__38 <PreloadAlertMontage>d__;
			<PreloadAlertMontage>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PreloadAlertMontage>d__.setting = setting;
			<PreloadAlertMontage>d__.<>1__state = -1;
			<PreloadAlertMontage>d__.<>t__builder.Start<WuWaGoGlobal.<PreloadAlertMontage>d__38>(ref <PreloadAlertMontage>d__);
			return <PreloadAlertMontage>d__.<>t__builder.Task;
		}

		// Token: 0x0602F901 RID: 194817 RVA: 0x00B04248 File Offset: 0x00B02448
		[NullableContext(1)]
		private static UniTask PreloadIdleMontage(BP_WuWaGo_C setting)
		{
			WuWaGoGlobal.<PreloadIdleMontage>d__39 <PreloadIdleMontage>d__;
			<PreloadIdleMontage>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PreloadIdleMontage>d__.setting = setting;
			<PreloadIdleMontage>d__.<>1__state = -1;
			<PreloadIdleMontage>d__.<>t__builder.Start<WuWaGoGlobal.<PreloadIdleMontage>d__39>(ref <PreloadIdleMontage>d__);
			return <PreloadIdleMontage>d__.<>t__builder.Task;
		}

		// Token: 0x0602F902 RID: 194818 RVA: 0x00B0428C File Offset: 0x00B0248C
		[NullableContext(1)]
		private static UniTask PreloadOneRoleAnim(EWuWaGoRoleType type, SWuWaGoRoleAnim anim)
		{
			WuWaGoGlobal.<PreloadOneRoleAnim>d__40 <PreloadOneRoleAnim>d__;
			<PreloadOneRoleAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PreloadOneRoleAnim>d__.type = type;
			<PreloadOneRoleAnim>d__.anim = anim;
			<PreloadOneRoleAnim>d__.<>1__state = -1;
			<PreloadOneRoleAnim>d__.<>t__builder.Start<WuWaGoGlobal.<PreloadOneRoleAnim>d__40>(ref <PreloadOneRoleAnim>d__);
			return <PreloadOneRoleAnim>d__.<>t__builder.Task;
		}

		// Token: 0x0602F903 RID: 194819 RVA: 0x00B042D8 File Offset: 0x00B024D8
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		private static UniTask<List<UAnimMontage>> LoadMontageArray([Nullable(new byte[]
		{
			2,
			1,
			1
		})] TArray<TSoftObjectPtr<UAnimMontage>> softPtr)
		{
			WuWaGoGlobal.<LoadMontageArray>d__41 <LoadMontageArray>d__;
			<LoadMontageArray>d__.<>t__builder = AsyncUniTaskMethodBuilder<List<UAnimMontage>>.Create();
			<LoadMontageArray>d__.softPtr = softPtr;
			<LoadMontageArray>d__.<>1__state = -1;
			<LoadMontageArray>d__.<>t__builder.Start<WuWaGoGlobal.<LoadMontageArray>d__41>(ref <LoadMontageArray>d__);
			return <LoadMontageArray>d__.<>t__builder.Task;
		}

		// Token: 0x0602F904 RID: 194820 RVA: 0x00B0431C File Offset: 0x00B0251C
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		private static UniTask<Dictionary<EWuWaGoClimbMontage, UAnimMontage>> LoadMontageMap([Nullable(new byte[]
		{
			2,
			0,
			1,
			1
		})] TMap<TEnumAsByte<EWuWaGoClimbMontage>, TSoftObjectPtr<UAnimMontage>> softMap)
		{
			WuWaGoGlobal.<LoadMontageMap>d__42 <LoadMontageMap>d__;
			<LoadMontageMap>d__.<>t__builder = AsyncUniTaskMethodBuilder<Dictionary<EWuWaGoClimbMontage, UAnimMontage>>.Create();
			<LoadMontageMap>d__.softMap = softMap;
			<LoadMontageMap>d__.<>1__state = -1;
			<LoadMontageMap>d__.<>t__builder.Start<WuWaGoGlobal.<LoadMontageMap>d__42>(ref <LoadMontageMap>d__);
			return <LoadMontageMap>d__.<>t__builder.Task;
		}

		// Token: 0x0602F905 RID: 194821 RVA: 0x00B04360 File Offset: 0x00B02560
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private static UniTask<UAnimMontage> LoadMontage(string path = null)
		{
			WuWaGoGlobal.<LoadMontage>d__43 <LoadMontage>d__;
			<LoadMontage>d__.<>t__builder = AsyncUniTaskMethodBuilder<UAnimMontage>.Create();
			<LoadMontage>d__.path = path;
			<LoadMontage>d__.<>1__state = -1;
			<LoadMontage>d__.<>t__builder.Start<WuWaGoGlobal.<LoadMontage>d__43>(ref <LoadMontage>d__);
			return <LoadMontage>d__.<>t__builder.Task;
		}

		// Token: 0x04019B01 RID: 105217
		[Nullable(1)]
		private const string SETTING_DA_PATH = "/Game/Aki/Data/Gameplay/WuWaGo/DA_WuWaGo.DA_WuWaGo";

		// Token: 0x04019B02 RID: 105218
		private static BP_WuWaGo_C _settingDataAsset;

		// Token: 0x04019B03 RID: 105219
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private static Dictionary<EWuWaGoRoleType, List<UAnimMontage>> _roleAttackAnimMap;

		// Token: 0x04019B04 RID: 105220
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private static Dictionary<EWuWaGoRoleType, List<UAnimMontage>> _roleDeathAnimMap;

		// Token: 0x04019B05 RID: 105221
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private static Dictionary<EWuWaGoRoleType, List<UAnimMontage>> _roleBeHitAnimMap;

		// Token: 0x04019B06 RID: 105222
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private static Dictionary<EWuWaGoRoleType, Dictionary<EWuWaGoClimbMontage, UAnimMontage>> _roleClimbAnimMap;

		// Token: 0x04019B07 RID: 105223
		private static UAnimMontage _mainControlPullRodOpenMontage;

		// Token: 0x04019B08 RID: 105224
		private static UAnimMontage _mainControlPullRodCloseMontage;

		// Token: 0x04019B09 RID: 105225
		private static UAnimMontage _spikeFallMontage;

		// Token: 0x04019B0A RID: 105226
		private static UAnimMontage _alertMontage;

		// Token: 0x04019B0B RID: 105227
		private static UAnimMontage _idleMontage;

		// Token: 0x04019B0C RID: 105228
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static HashSet<string> _preloadedAudioEvents;
	}
}
