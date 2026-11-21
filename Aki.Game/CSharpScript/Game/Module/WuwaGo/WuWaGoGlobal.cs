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
	// Token: 0x02003649 RID: 13897
	[NullableContext(2)]
	[Nullable(0)]
	public class WuWaGoGlobal : IStaticVariableResetter
	{
		// Token: 0x060240AD RID: 147629 RVA: 0x00A338DA File Offset: 0x00A31ADA
		static WuWaGoGlobal()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(WuWaGoGlobal.CreateStaticDefaultValue), new Action(WuWaGoGlobal.ResetStaticDefaultValue));
		}

		// Token: 0x060240AE RID: 147630 RVA: 0x00A338F9 File Offset: 0x00A31AF9
		public static void CreateStaticDefaultValue()
		{
			WuWaGoGlobal._roleAttackAnimMap = new Dictionary<EWuWaGoRoleType, List<UAnimMontage>>();
			WuWaGoGlobal._roleDeathAnimMap = new Dictionary<EWuWaGoRoleType, List<UAnimMontage>>();
			WuWaGoGlobal._roleBeHitAnimMap = new Dictionary<EWuWaGoRoleType, List<UAnimMontage>>();
			WuWaGoGlobal._roleClimbAnimMap = new Dictionary<EWuWaGoRoleType, Dictionary<EWuWaGoClimbMontage, UAnimMontage>>();
			WuWaGoGlobal._preloadedAudioEvents = new HashSet<string>();
		}

		// Token: 0x060240AF RID: 147631 RVA: 0x00A33930 File Offset: 0x00A31B30
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

		// Token: 0x170049AB RID: 18859
		// (get) Token: 0x060240B0 RID: 147632 RVA: 0x00A33984 File Offset: 0x00A31B84
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

		// Token: 0x060240B1 RID: 147633 RVA: 0x00A339C0 File Offset: 0x00A31BC0
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

		// Token: 0x060240B2 RID: 147634 RVA: 0x00A339FC File Offset: 0x00A31BFC
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

		// Token: 0x060240B3 RID: 147635 RVA: 0x00A33A74 File Offset: 0x00A31C74
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

		// Token: 0x060240B4 RID: 147636 RVA: 0x00A33AE4 File Offset: 0x00A31CE4
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

		// Token: 0x060240B5 RID: 147637 RVA: 0x00A33B38 File Offset: 0x00A31D38
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

		// Token: 0x060240B6 RID: 147638 RVA: 0x00A33B8C File Offset: 0x00A31D8C
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

		// Token: 0x060240B7 RID: 147639 RVA: 0x00A33C1B File Offset: 0x00A31E1B
		[NullableContext(1)]
		public static List<UAnimMontage> GetRoleAttackAnimations(EWuWaGoRoleType type)
		{
			Dictionary<EWuWaGoRoleType, List<UAnimMontage>> roleAttackAnimMap = WuWaGoGlobal._roleAttackAnimMap;
			return ((roleAttackAnimMap != null) ? roleAttackAnimMap.GetValueOrDefault(type) : null) ?? new List<UAnimMontage>();
		}

		// Token: 0x060240B8 RID: 147640 RVA: 0x00A33C38 File Offset: 0x00A31E38
		[NullableContext(1)]
		public static List<UAnimMontage> GetRoleDeathAnimations(EWuWaGoRoleType type)
		{
			Dictionary<EWuWaGoRoleType, List<UAnimMontage>> roleDeathAnimMap = WuWaGoGlobal._roleDeathAnimMap;
			return ((roleDeathAnimMap != null) ? roleDeathAnimMap.GetValueOrDefault(type) : null) ?? new List<UAnimMontage>();
		}

		// Token: 0x060240B9 RID: 147641 RVA: 0x00A33C55 File Offset: 0x00A31E55
		[NullableContext(1)]
		public static List<UAnimMontage> GetRoleBeHitAnimations(EWuWaGoRoleType type)
		{
			Dictionary<EWuWaGoRoleType, List<UAnimMontage>> roleBeHitAnimMap = WuWaGoGlobal._roleBeHitAnimMap;
			return ((roleBeHitAnimMap != null) ? roleBeHitAnimMap.GetValueOrDefault(type) : null) ?? new List<UAnimMontage>();
		}

		// Token: 0x060240BA RID: 147642 RVA: 0x00A33C72 File Offset: 0x00A31E72
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

		// Token: 0x060240BB RID: 147643 RVA: 0x00A33C91 File Offset: 0x00A31E91
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

		// Token: 0x060240BC RID: 147644 RVA: 0x00A33CAA File Offset: 0x00A31EAA
		public static UAnimMontage GetSpikeFallMontage()
		{
			return WuWaGoGlobal._spikeFallMontage;
		}

		// Token: 0x060240BD RID: 147645 RVA: 0x00A33CB1 File Offset: 0x00A31EB1
		public static UAnimMontage GetAlertMontage()
		{
			return WuWaGoGlobal._alertMontage;
		}

		// Token: 0x060240BE RID: 147646 RVA: 0x00A33CB8 File Offset: 0x00A31EB8
		public static UAnimMontage GetIdleMontage()
		{
			return WuWaGoGlobal._idleMontage;
		}

		// Token: 0x060240BF RID: 147647 RVA: 0x00A33CC0 File Offset: 0x00A31EC0
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

		// Token: 0x060240C0 RID: 147648 RVA: 0x00A33D00 File Offset: 0x00A31F00
		private static UniTask PreloadRoleAnimations()
		{
			WuWaGoGlobal.<PreloadRoleAnimations>d__32 <PreloadRoleAnimations>d__;
			<PreloadRoleAnimations>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PreloadRoleAnimations>d__.<>1__state = -1;
			<PreloadRoleAnimations>d__.<>t__builder.Start<WuWaGoGlobal.<PreloadRoleAnimations>d__32>(ref <PreloadRoleAnimations>d__);
			return <PreloadRoleAnimations>d__.<>t__builder.Task;
		}

		// Token: 0x060240C1 RID: 147649 RVA: 0x00A33D3C File Offset: 0x00A31F3C
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

		// Token: 0x060240C2 RID: 147650 RVA: 0x00A33DAC File Offset: 0x00A31FAC
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

		// Token: 0x060240C3 RID: 147651 RVA: 0x00A33E14 File Offset: 0x00A32014
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

		// Token: 0x060240C4 RID: 147652 RVA: 0x00A33E4C File Offset: 0x00A3204C
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

		// Token: 0x060240C5 RID: 147653 RVA: 0x00A33E90 File Offset: 0x00A32090
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

		// Token: 0x060240C6 RID: 147654 RVA: 0x00A33ED4 File Offset: 0x00A320D4
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

		// Token: 0x060240C7 RID: 147655 RVA: 0x00A33F18 File Offset: 0x00A32118
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

		// Token: 0x060240C8 RID: 147656 RVA: 0x00A33F5C File Offset: 0x00A3215C
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

		// Token: 0x060240C9 RID: 147657 RVA: 0x00A33FA8 File Offset: 0x00A321A8
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

		// Token: 0x060240CA RID: 147658 RVA: 0x00A33FEC File Offset: 0x00A321EC
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

		// Token: 0x060240CB RID: 147659 RVA: 0x00A34030 File Offset: 0x00A32230
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

		// Token: 0x040141B0 RID: 82352
		[Nullable(1)]
		private const string SETTING_DA_PATH = "/Game/Aki/Data/Gameplay/WuWaGo/DA_WuWaGo.DA_WuWaGo";

		// Token: 0x040141B1 RID: 82353
		private static BP_WuWaGo_C _settingDataAsset;

		// Token: 0x040141B2 RID: 82354
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private static Dictionary<EWuWaGoRoleType, List<UAnimMontage>> _roleAttackAnimMap;

		// Token: 0x040141B3 RID: 82355
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private static Dictionary<EWuWaGoRoleType, List<UAnimMontage>> _roleDeathAnimMap;

		// Token: 0x040141B4 RID: 82356
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private static Dictionary<EWuWaGoRoleType, List<UAnimMontage>> _roleBeHitAnimMap;

		// Token: 0x040141B5 RID: 82357
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private static Dictionary<EWuWaGoRoleType, Dictionary<EWuWaGoClimbMontage, UAnimMontage>> _roleClimbAnimMap;

		// Token: 0x040141B6 RID: 82358
		private static UAnimMontage _mainControlPullRodOpenMontage;

		// Token: 0x040141B7 RID: 82359
		private static UAnimMontage _mainControlPullRodCloseMontage;

		// Token: 0x040141B8 RID: 82360
		private static UAnimMontage _spikeFallMontage;

		// Token: 0x040141B9 RID: 82361
		private static UAnimMontage _alertMontage;

		// Token: 0x040141BA RID: 82362
		private static UAnimMontage _idleMontage;

		// Token: 0x040141BB RID: 82363
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static HashSet<string> _preloadedAudioEvents;
	}
}
