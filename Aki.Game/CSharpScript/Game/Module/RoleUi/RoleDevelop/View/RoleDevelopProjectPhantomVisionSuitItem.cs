using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.WorldMap;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02003D0D RID: 15629
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoleDevelopProjectPhantomVisionSuitItem : GridProxyAbstract<RoleDevelopPhantomVisionSuitItemData>
	{
		// Token: 0x06027FFE RID: 163838 RVA: 0x00B31BDC File Offset: 0x00B2FDDC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 14;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(12, new Action(this.OnMapClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(13, new Action(this.OnMapClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06027FFF RID: 163839 RVA: 0x00B31E3C File Offset: 0x00B3003C
		protected override UniTask OnBeforeStartAsync()
		{
			RoleDevelopProjectPhantomVisionSuitItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevelopProjectPhantomVisionSuitItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06028000 RID: 163840 RVA: 0x00B31E80 File Offset: 0x00B30080
		protected override void OnStart()
		{
			EventSystem.Instance.Add<EInputControllerMainType, EInputControllerMainType>(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
			EventSystem.Instance.Add(EEventName.UpdateNavigationListener, new Action(this.OnNavigationFocusChange));
			EventSystem.Instance.Add(EEventName.ResetNavigationListener, new Action(this.OnNavigationFocusChange));
		}

		// Token: 0x06028001 RID: 163841 RVA: 0x00B31EE4 File Offset: 0x00B300E4
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove<EInputControllerMainType, EInputControllerMainType>(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
			EventSystem.Instance.Remove(EEventName.UpdateNavigationListener, new Action(this.OnNavigationFocusChange));
			EventSystem.Instance.Remove(EEventName.ResetNavigationListener, new Action(this.OnNavigationFocusChange));
		}

		// Token: 0x06028002 RID: 163842 RVA: 0x00B31F45 File Offset: 0x00B30145
		private void OnInputControllerMainTypeChange(EInputControllerMainType last, EInputControllerMainType now)
		{
			if (this.Data == null || !base.IsUiActiveInHierarchy())
			{
				return;
			}
			this.RefreshMapButtonState();
		}

		// Token: 0x06028003 RID: 163843 RVA: 0x00B31F5F File Offset: 0x00B3015F
		private void OnNavigationFocusChange()
		{
			if (this.Data == null || !base.IsUiActiveInHierarchy())
			{
				return;
			}
			this.RefreshMapButtonState();
		}

		// Token: 0x06028004 RID: 163844 RVA: 0x00B31F7C File Offset: 0x00B3017C
		private bool IsNavigationFocusOnSelf()
		{
			AActor rootActor = base.GetRootActor();
			if (rootActor == null || !rootActor.IsValid())
			{
				return false;
			}
			TsUiNavigationBehaviorListener currentNavigationFocusListener = UiNavigationNewController.Instance.GetCurrentNavigationFocusListener();
			AActor aactor = (currentNavigationFocusListener != null) ? currentNavigationFocusListener.GetOwner() : null;
			int num = 0;
			while (aactor != null && num < 16)
			{
				if (aactor == rootActor)
				{
					return true;
				}
				aactor = aactor.GetAttachParentActor();
				num++;
			}
			return false;
		}

		// Token: 0x06028005 RID: 163845 RVA: 0x00B31FD4 File Offset: 0x00B301D4
		private bool RefreshMapButtonState()
		{
			bool flag = this.ShouldShowMapButton();
			UUIButtonComponent button = base.GetButton(12);
			if (button != null)
			{
				UUIItem uuiitem = button.RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(flag && !Info.Instance.IsInGamepad());
				}
			}
			UUIButtonComponent button2 = base.GetButton(13);
			if (button2 != null)
			{
				UUIItem uuiitem2 = button2.RootUIComp.Get();
				if (uuiitem2 != null)
				{
					uuiitem2.SetUIActive(flag && Info.Instance.IsInGamepad() && this.IsNavigationFocusOnSelf());
				}
			}
			return flag;
		}

		// Token: 0x06028006 RID: 163846 RVA: 0x00B32060 File Offset: 0x00B30260
		private UniTask InitButtonItem()
		{
			RoleDevelopProjectPhantomVisionSuitItem.<InitButtonItem>d__14 <InitButtonItem>d__;
			<InitButtonItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitButtonItem>d__.<>4__this = this;
			<InitButtonItem>d__.<>1__state = -1;
			<InitButtonItem>d__.<>t__builder.Start<RoleDevelopProjectPhantomVisionSuitItem.<InitButtonItem>d__14>(ref <InitButtonItem>d__);
			return <InitButtonItem>d__.<>t__builder.Task;
		}

		// Token: 0x06028007 RID: 163847 RVA: 0x00B320A4 File Offset: 0x00B302A4
		private UniTask InitItemBaseCurrentVision()
		{
			RoleDevelopProjectPhantomVisionSuitItem.<InitItemBaseCurrentVision>d__15 <InitItemBaseCurrentVision>d__;
			<InitItemBaseCurrentVision>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitItemBaseCurrentVision>d__.<>4__this = this;
			<InitItemBaseCurrentVision>d__.<>1__state = -1;
			<InitItemBaseCurrentVision>d__.<>t__builder.Start<RoleDevelopProjectPhantomVisionSuitItem.<InitItemBaseCurrentVision>d__15>(ref <InitItemBaseCurrentVision>d__);
			return <InitItemBaseCurrentVision>d__.<>t__builder.Task;
		}

		// Token: 0x06028008 RID: 163848 RVA: 0x00B320E8 File Offset: 0x00B302E8
		public override void Refresh(RoleDevelopPhantomVisionSuitItemData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			bool showMapButton = this.RefreshMapButtonState();
			this.ButtonConfirm.SetLocalTextNew(this.GetConfirmButtonTextId(data, showMapButton), Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.Name, Array.Empty<object>());
			if (data.ItemType == EPhantomSuitItemType.Dungeon)
			{
				base.GetSprite(4).SetUIActive(false);
				base.GetTexture(5).SetUIActive(true);
				base.SetTextureByPath(data.TypeIcon, base.GetTexture(5), null, null);
				this.RefreshNightMareDesc(data.DungeonId);
				this.RefreshDoubleIcon(data.DungeonId);
				base.GetItem(8).SetUIActive(true);
				base.GetItem(9).SetUIActive(false);
			}
			else if (data.ItemType == EPhantomSuitItemType.Phantom)
			{
				base.GetSprite(4).SetUIActive(true);
				base.GetTexture(5).SetUIActive(false);
				UUIText text = base.GetText(6);
				if (text != null)
				{
					text.SetUIActive(false);
				}
				base.GetItem(7).SetUIActive(false);
				base.GetItem(8).SetUIActive(false);
				base.GetItem(9).SetUIActive(true);
				this.ItemBaseCurrentVision.Refresh(new RoleDevelopPhantomVisionSuitListItemData
				{
					MonsterData = data.MonsterDataList[0]
				}, false, 0);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(11), data.Name, Array.Empty<object>());
			}
			List<RoleDevelopPhantomVisionSuitListItemData> list = new List<RoleDevelopPhantomVisionSuitListItemData>();
			if (data.RewardDataList != null)
			{
				foreach (DropRewardItemData rewardData in data.RewardDataList)
				{
					list.Add(new RoleDevelopPhantomVisionSuitListItemData
					{
						RewardData = rewardData
					});
				}
			}
			this.ItemLayout.RefreshByData(list, null, false);
		}

		// Token: 0x06028009 RID: 163849 RVA: 0x00B322C0 File Offset: 0x00B304C0
		private string GetConfirmButtonTextId(RoleDevelopPhantomVisionSuitItemData data, bool showMapButton)
		{
			if (data.ItemType != EPhantomSuitItemType.Dungeon)
			{
				return data.ButtonName;
			}
			if (!showMapButton)
			{
				return data.ButtonName;
			}
			return "NewSoundDetectDirectChallenge";
		}

		// Token: 0x0602800A RID: 163850 RVA: 0x00B322E1 File Offset: 0x00B304E1
		private RoleDevelopProjectPhantomVisionSuitListItem CreateItem()
		{
			return new RoleDevelopProjectPhantomVisionSuitListItem();
		}

		// Token: 0x0602800B RID: 163851 RVA: 0x00B322E8 File Offset: 0x00B304E8
		private void OnClickConfirm(int value)
		{
			if (this.Data == null)
			{
				return;
			}
			if (this.Data.ItemType == EPhantomSuitItemType.Phantom)
			{
				CalabashController.Instance.JumpToCalabashCollectTabView(this.Data.MonsterDataList[0].MonsterId);
			}
			else
			{
				this.JumpToDungeon(this.Data.DungeonId);
			}
			if (this.Data.LogRoleId != null && this.Data.LogMainPage != null && this.Data.LogSubPage != null)
			{
				RoleController.Instance.LogRoleDevelopClick(this.Data.LogRoleId.Value, this.Data.LogMainPage.Value, this.Data.LogSubPage.Value, null);
			}
		}

		// Token: 0x0602800C RID: 163852 RVA: 0x00B323CC File Offset: 0x00B305CC
		private void JumpToDungeon(int dungeonId)
		{
			if (GameModeController.Instance.IsInInstance())
			{
				GenericPromptController.Instance.ShowPromptByCode("DungeonDetection", Array.Empty<object>());
				return;
			}
			SilentAreaDetectionRecord silentData = AdventureGuideModel.Instance.GetSilentAreaDetectData(dungeonId);
			if (silentData == null)
			{
				return;
			}
			bool flag = this.ShouldShowMapButton();
			AdventureGuideModel.Instance.SendAdventureGuideBtnClickLogData(flag ? EAdventureGuideBtnClickType.DirectChallenge : EAdventureGuideBtnClickType.GoTo, silentData.Conf.Id, silentData.Conf.Secondary, this.GetLogComboType(flag));
			if (AdventureGuideModel.Instance.GetIsDetectionPreOpenByRecord(silentData))
			{
				if (OnlineModel.Instance.GetIsTeamModel())
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("CantUseInMultiplayerMode", Array.Empty<object>());
					return;
				}
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PreOpenSpoilConfirmBoxFromRoleDev);
				confirmBoxDataNew.FunctionMap.Add(2, delegate
				{
					AdventureGuideController.Instance.HandlePreOpenDetection(silentData.Conf.Id, ESoundAreaDataType.SilentArea, silentData.Conf.PreOpenId);
				});
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			else
			{
				if (AdventureGuideModel.Instance.TryAdventureJumpBySilent(silentData))
				{
					return;
				}
				if (silentData.Conf.JumpType == 2)
				{
					AdventureGuideModel.Instance.SetFromManualDetect(true);
					AdventureGuideController.Instance.RequestForDetection(DetectionType.SilentArea, silentData.Conf.LevelPlayList(), dungeonId);
					ScrollingTipsController.Instance.ShowTipsByTextId("TeleportMarkNotUnlock", Array.Empty<object>());
					return;
				}
				if (!AdventureGuideController.Instance.IsMarkUnlock(silentData.Conf.MarkId))
				{
					return;
				}
				AdventureGuideModel.Instance.SetFromManualDetect(true);
				AdventureGuideController.Instance.RequestForDetection(DetectionType.SilentArea, silentData.Conf.LevelPlayList(), dungeonId);
				return;
			}
		}

		// Token: 0x0602800D RID: 163853 RVA: 0x00B32574 File Offset: 0x00B30774
		private void RefreshDoubleIcon(int dungeonId)
		{
			SilentAreaDetectionRecord silentAreaDetectData = AdventureGuideModel.Instance.GetSilentAreaDetectData(dungeonId);
			bool uiactive = silentAreaDetectData != null && RoleDevelopUtil.IsDungeonShowDouble((EDungeonType)silentAreaDetectData.Conf.Secondary);
			base.GetItem(7).SetUIActive(uiactive);
		}

		// Token: 0x0602800E RID: 163854 RVA: 0x00B325B4 File Offset: 0x00B307B4
		private void RefreshNightMareDesc(int dungeonId)
		{
			UUIText text = base.GetText(6);
			SilentAreaDetectionRecord silentAreaDetectData = AdventureGuideModel.Instance.GetSilentAreaDetectData(dungeonId);
			if (silentAreaDetectData == null || (silentAreaDetectData.Conf.Secondary != 63 && silentAreaDetectData.Conf.Secondary != 64))
			{
				if (text != null)
				{
					text.SetUIActive(false);
				}
				return;
			}
			AdventureGuideModel instance = AdventureGuideModel.Instance;
			ValueTuple<long, int> valueTuple;
			if (instance.GetIsDetectionPreOpenByRecord(silentAreaDetectData))
			{
				valueTuple = instance.GetNightMarePreOpenTarget(instance.GetPreOpenDetectionConf(silentAreaDetectData.Conf.Id, ESoundAreaDataType.SilentArea, silentAreaDetectData.Conf.PreOpenId).Value.InstanceID);
			}
			else
			{
				int[] array = silentAreaDetectData.Conf.LevelPlayList();
				ValueTuple<int, int> nightMareTarget = instance.GetNightMareTarget(new int?(silentAreaDetectData.Conf.MapId), (array != null && array.Length != 0) ? new int?(array[0]) : null);
				valueTuple = new ValueTuple<long, int>((long)nightMareTarget.Item1, nightMareTarget.Item2);
			}
			if (valueTuple.Item2 < 0)
			{
				if (text != null)
				{
					text.SetUIActive(false);
					return;
				}
			}
			else
			{
				if (text != null)
				{
					text.SetUIActive(true);
				}
				LguiUtil.Instance.SetLocalTextNew(text, "NightMareLeftTimes", new <>z__ReadOnlyArray<object>(new object[]
				{
					valueTuple.Item1,
					valueTuple.Item2
				}));
			}
		}

		// Token: 0x0602800F RID: 163855 RVA: 0x00B32710 File Offset: 0x00B30910
		private bool ShouldShowMapButton()
		{
			if (this.Data == null)
			{
				return false;
			}
			SilentAreaDetectionRecord silentAreaDetectData = AdventureGuideModel.Instance.GetSilentAreaDetectData(this.Data.DungeonId);
			if (silentAreaDetectData == null)
			{
				return false;
			}
			bool isDetectionPreOpenByRecord = AdventureGuideModel.Instance.GetIsDetectionPreOpenByRecord(silentAreaDetectData);
			if (!isDetectionPreOpenByRecord && silentAreaDetectData.IsLock)
			{
				return false;
			}
			EDetectionJumpType jumpType = (EDetectionJumpType)silentAreaDetectData.Conf.JumpType;
			if (jumpType == EDetectionJumpType.MapMark)
			{
				return false;
			}
			if (jumpType == EDetectionJumpType.DirectEntrance)
			{
				return true;
			}
			int markId = silentAreaDetectData.Conf.MarkId;
			return (markId != 0 && MapModel.Instance.MapMarkIsCanTeleport(markId)) || isDetectionPreOpenByRecord;
		}

		// Token: 0x06028010 RID: 163856 RVA: 0x00B32799 File Offset: 0x00B30999
		private EAdventureGuideBtnComboType GetLogComboType(bool showMapButton)
		{
			if (!showMapButton)
			{
				return EAdventureGuideBtnComboType.OnlyGoTo;
			}
			return EAdventureGuideBtnComboType.ChallengeAndMapJump;
		}

		// Token: 0x06028011 RID: 163857 RVA: 0x00B327A4 File Offset: 0x00B309A4
		private void OnMapClick()
		{
			if (this.Data == null)
			{
				return;
			}
			if (GameModeController.Instance.IsInInstance())
			{
				GenericPromptController.Instance.ShowPromptByCode("DungeonDetection", Array.Empty<object>());
				return;
			}
			SilentAreaDetectionRecord silentAreaDetectData = AdventureGuideModel.Instance.GetSilentAreaDetectData(this.Data.DungeonId);
			if (silentAreaDetectData == null)
			{
				return;
			}
			AdventureGuideModel.Instance.SendAdventureGuideBtnClickLogData(EAdventureGuideBtnClickType.MapJump, silentAreaDetectData.Conf.Id, silentAreaDetectData.Conf.Secondary, this.GetLogComboType(this.ShouldShowMapButton()));
			int markId = silentAreaDetectData.Conf.MarkId;
			if (markId == 0)
			{
				Log.Instance.Error(ELogModule.AdventureGuide, ELogAuthor.LY, "点击地图跳转按钮但未找到对应地图标记", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			MapConfig instance = MapConfig.Instance;
			MapMark? mapMark = (instance != null) ? instance.GetConfigMark(markId) : null;
			if (mapMark == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module = ELogModule.AdventureGuide;
				ELogAuthor author = ELogAuthor.LY;
				string message = "地图标记配置不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("MarkId:", markId);
				instance2.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			WorldMapViewOpenParams data = new WorldMapViewOpenParams
			{
				MarkId = new int?(mapMark.Value.MarkId),
				MarkType = (EMarkType)mapMark.Value.ObjectType,
				OpenFogId = new int?(0)
			};
			WorldMapController.Instance.OpenView(EOpenMapType.Other, false, data, null);
		}

		// Token: 0x04015C79 RID: 89209
		private const int FocusSearchMaxDepth = 16;

		// Token: 0x04015C7A RID: 89210
		[Nullable(2)]
		private RoleDevelopPhantomVisionSuitItemData Data;

		// Token: 0x04015C7B RID: 89211
		private ButtonItem ButtonConfirm;

		// Token: 0x04015C7C RID: 89212
		private GenericLayout<RoleDevelopProjectPhantomVisionSuitListItem, RoleDevelopPhantomVisionSuitListItemData> ItemLayout;

		// Token: 0x04015C7D RID: 89213
		[Nullable(2)]
		private RoleDevelopProjectPhantomVisionSuitListItem ItemBaseCurrentVision;

		// Token: 0x020098DD RID: 39133
		[NullableContext(0)]
		private enum EComponentType
		{
			// Token: 0x0402FAC0 RID: 195264
			TxtName,
			// Token: 0x0402FAC1 RID: 195265
			PanelDetailLayout,
			// Token: 0x0402FAC2 RID: 195266
			ItemBase,
			// Token: 0x0402FAC3 RID: 195267
			BtnConfirm,
			// Token: 0x0402FAC4 RID: 195268
			IconSprite,
			// Token: 0x0402FAC5 RID: 195269
			IconTexture,
			// Token: 0x0402FAC6 RID: 195270
			TxtDesc,
			// Token: 0x0402FAC7 RID: 195271
			ItemDouble,
			// Token: 0x0402FAC8 RID: 195272
			PnlNormal,
			// Token: 0x0402FAC9 RID: 195273
			PnlCurrentVision,
			// Token: 0x0402FACA RID: 195274
			ItemBaseCurrentVision,
			// Token: 0x0402FACB RID: 195275
			TextNameCurrentVision,
			// Token: 0x0402FACC RID: 195276
			BtnFunctionA2,
			// Token: 0x0402FACD RID: 195277
			BtnCommon
		}
	}
}
