using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02006820 RID: 26656
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlLevelView : UiViewBase
	{
		// Token: 0x1700973C RID: 38716
		// (get) Token: 0x06042834 RID: 272436 RVA: 0x010295B9 File Offset: 0x010277B9
		private ActivityDangoBrawlData ActivityData
		{
			get
			{
				return ActivityDangoBrawlController.Instance.MyActivityData;
			}
		}

		// Token: 0x1700973D RID: 38717
		// (get) Token: 0x06042835 RID: 272437 RVA: 0x010295C5 File Offset: 0x010277C5
		private DangoBrawlOutGameData OutGameData
		{
			get
			{
				return this.ActivityData.GetOutGameData();
			}
		}

		// Token: 0x06042836 RID: 272438 RVA: 0x010295D2 File Offset: 0x010277D2
		public DangoBrawlLevelView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06042837 RID: 272439 RVA: 0x010295DC File Offset: 0x010277DC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 18;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(13, new Action(this.OnConfirmBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06042838 RID: 272440 RVA: 0x010298A0 File Offset: 0x01027AA0
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlLevelView.<OnBeforeStartAsync>d__22 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlLevelView.<OnBeforeStartAsync>d__22>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06042839 RID: 272441 RVA: 0x010298E4 File Offset: 0x01027AE4
		[return: Nullable(2)]
		private DangoBrawlLevelData ResolveAutoSelectLevel(List<DangoBrawlLevelData> levelDataList)
		{
			if (levelDataList.Count == 0)
			{
				return null;
			}
			DangoBrawlLevelData dangoBrawlLevelData = levelDataList.FirstOrDefault((DangoBrawlLevelData data) => !data.IsLocked && !data.IsPassed);
			if (dangoBrawlLevelData != null)
			{
				return dangoBrawlLevelData;
			}
			return levelDataList.LastOrDefault((DangoBrawlLevelData data) => !data.IsLocked) ?? levelDataList[levelDataList.Count - 1];
		}

		// Token: 0x0604283A RID: 272442 RVA: 0x01029960 File Offset: 0x01027B60
		protected override void OnStart()
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence != null)
			{
				uiViewSequence.AddSequenceStartEvent("Start", new Action<string>(this.OnViewStartSequence));
			}
			UiBehaviorLevelSequence uiViewSequence2 = this.UiViewSequence;
			if (uiViewSequence2 == null)
			{
				return;
			}
			uiViewSequence2.AddSequenceStartEvent("Close", new Action<string>(this.OnViewCloseSequence));
		}

		// Token: 0x0604283B RID: 272443 RVA: 0x010299B0 File Offset: 0x01027BB0
		protected override void OnBeforeShow()
		{
			this.RefreshArchiveItem();
			ActivityDangoBrawlController.Instance.TryPlayRoleUnlockQueue();
		}

		// Token: 0x0604283C RID: 272444 RVA: 0x010299C2 File Offset: 0x01027BC2
		protected override void OnBeforeDestroy()
		{
			ActivityDangoBrawlController.Instance.UnRegisterTermHyperlink(base.GetText(10));
		}

		// Token: 0x0604283D RID: 272445 RVA: 0x010299D6 File Offset: 0x01027BD6
		private void OnViewStartSequence(string _)
		{
			this.PlayCurrentBgSequenceThenSpine("Start", 0.52f);
		}

		// Token: 0x0604283E RID: 272446 RVA: 0x010299E8 File Offset: 0x01027BE8
		private void OnViewCloseSequence(string _)
		{
			this.PlayCurrentBgSequence("Close");
		}

		// Token: 0x0604283F RID: 272447 RVA: 0x010299F8 File Offset: 0x01027BF8
		private void PlayCurrentBgSequence(string sequenceName)
		{
			DangoBrawlLevelData levelData = this.LevelData;
			EDangoBrawlLevelBgStyle? edangoBrawlLevelBgStyle = (levelData != null) ? new EDangoBrawlLevelBgStyle?(levelData.BgStyle) : null;
			if (edangoBrawlLevelBgStyle != null)
			{
				switch (edangoBrawlLevelBgStyle.GetValueOrDefault())
				{
				case EDangoBrawlLevelBgStyle.Easy:
				{
					DangoBrawlLevelBgItem levelEasyBgItem = this.LevelEasyBgItem;
					if (levelEasyBgItem == null)
					{
						return;
					}
					levelEasyBgItem.PlaySequence(sequenceName);
					return;
				}
				case EDangoBrawlLevelBgStyle.Normal:
				{
					DangoBrawlLevelBgItem levelNormalBgItem = this.LevelNormalBgItem;
					if (levelNormalBgItem == null)
					{
						return;
					}
					levelNormalBgItem.PlaySequence(sequenceName);
					return;
				}
				case EDangoBrawlLevelBgStyle.Adventure:
				{
					DangoBrawlAdventureLevelBgItem levelAdventureBgItem = this.LevelAdventureBgItem;
					if (levelAdventureBgItem == null)
					{
						return;
					}
					levelAdventureBgItem.PlaySequence(sequenceName);
					break;
				}
				default:
					return;
				}
			}
		}

		// Token: 0x06042840 RID: 272448 RVA: 0x01029A80 File Offset: 0x01027C80
		private void PlayCurrentBgSequenceThenSpine(string sequenceName, float delayTime)
		{
			DangoBrawlLevelData levelData = this.LevelData;
			EDangoBrawlLevelBgStyle? edangoBrawlLevelBgStyle = (levelData != null) ? new EDangoBrawlLevelBgStyle?(levelData.BgStyle) : null;
			if (edangoBrawlLevelBgStyle != null)
			{
				switch (edangoBrawlLevelBgStyle.GetValueOrDefault())
				{
				case EDangoBrawlLevelBgStyle.Easy:
				{
					DangoBrawlLevelBgItem levelEasyBgItem = this.LevelEasyBgItem;
					if (levelEasyBgItem == null)
					{
						return;
					}
					levelEasyBgItem.PlaySequenceThenSpine(sequenceName, delayTime);
					return;
				}
				case EDangoBrawlLevelBgStyle.Normal:
				{
					DangoBrawlLevelBgItem levelNormalBgItem = this.LevelNormalBgItem;
					if (levelNormalBgItem == null)
					{
						return;
					}
					levelNormalBgItem.PlaySequenceThenSpine(sequenceName, delayTime);
					return;
				}
				case EDangoBrawlLevelBgStyle.Adventure:
				{
					DangoBrawlAdventureLevelBgItem levelAdventureBgItem = this.LevelAdventureBgItem;
					if (levelAdventureBgItem == null)
					{
						return;
					}
					levelAdventureBgItem.PlaySequenceThenSpine(sequenceName, delayTime);
					break;
				}
				default:
					return;
				}
			}
		}

		// Token: 0x06042841 RID: 272449 RVA: 0x01029B0B File Offset: 0x01027D0B
		private DangoBrawlLevelItem InitLevelItem()
		{
			return new DangoBrawlLevelItem
			{
				OnClickToggleBack = new Action<DangoBrawlLevelItem>(this.OnClickLevelItem)
			};
		}

		// Token: 0x06042842 RID: 272450 RVA: 0x01029B24 File Offset: 0x01027D24
		private CommonItemSmallItemGrid InitFirstRewardItem()
		{
			return new CommonItemSmallItemGrid
			{
				ShowReceivedCallBack = new Func<TItem, bool>(this.OnShowRewardReceivedCallBack)
			};
		}

		// Token: 0x06042843 RID: 272451 RVA: 0x01029B40 File Offset: 0x01027D40
		private void RefreshLevelOther(DangoBrawlLevelData data)
		{
			EDangoBrawlLevelBgStyle bgStyle = data.BgStyle;
			DangoBrawlLevelBgItem levelEasyBgItem = this.LevelEasyBgItem;
			if (levelEasyBgItem != null)
			{
				levelEasyBgItem.SetUiActive(bgStyle == EDangoBrawlLevelBgStyle.Easy);
			}
			DangoBrawlLevelBgItem levelNormalBgItem = this.LevelNormalBgItem;
			if (levelNormalBgItem != null)
			{
				levelNormalBgItem.SetUiActive(bgStyle == EDangoBrawlLevelBgStyle.Normal);
			}
			DangoBrawlAdventureLevelBgItem levelAdventureBgItem = this.LevelAdventureBgItem;
			if (levelAdventureBgItem != null)
			{
				levelAdventureBgItem.SetUiActive(bgStyle == EDangoBrawlLevelBgStyle.Adventure);
			}
			switch (bgStyle)
			{
			case EDangoBrawlLevelBgStyle.Easy:
			{
				DangoBrawlLevelBgItem levelEasyBgItem2 = this.LevelEasyBgItem;
				if (levelEasyBgItem2 != null)
				{
					levelEasyBgItem2.Refresh(data);
				}
				break;
			}
			case EDangoBrawlLevelBgStyle.Normal:
			{
				DangoBrawlLevelBgItem levelNormalBgItem2 = this.LevelNormalBgItem;
				if (levelNormalBgItem2 != null)
				{
					levelNormalBgItem2.Refresh(data);
				}
				break;
			}
			case EDangoBrawlLevelBgStyle.Adventure:
			{
				DangoBrawlAdventureLevelBgItem levelAdventureBgItem2 = this.LevelAdventureBgItem;
				if (levelAdventureBgItem2 != null)
				{
					levelAdventureBgItem2.Refresh(data);
				}
				break;
			}
			}
			DangoBrawlLevelRoleItem unlockRoleItem = this.UnlockRoleItem;
			if (unlockRoleItem != null)
			{
				unlockRoleItem.SetUiActive(data.FirstUnlockRoleId > 0);
			}
			if (data.FirstUnlockRoleId > 0)
			{
				DangoBrawlLevelRoleItem unlockRoleItem2 = this.UnlockRoleItem;
				if (unlockRoleItem2 == null)
				{
					return;
				}
				unlockRoleItem2.Refresh(new DangoBrawlRoleData
				{
					RoleId = data.FirstUnlockRoleId,
					IsUnlocked = this.OutGameData.IsRoleUnlocked(data.FirstUnlockRoleId)
				});
			}
		}

		// Token: 0x06042844 RID: 272452 RVA: 0x01029C40 File Offset: 0x01027E40
		private void RefreshLevelInfoView(DangoBrawlLevelData data)
		{
			this.LevelData = data;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), data.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), data.Desc, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), data.PassConditionDesc, Array.Empty<object>());
			UUIText text = base.GetText(8);
			if (text != null)
			{
				text.SetText(data.MaxRetryCount.ToString(), true);
			}
			SimpleGenericLayout heartLayout = this.HeartLayout;
			if (heartLayout != null)
			{
				heartLayout.RebuildLayout(data.MaxRetryCount);
			}
			bool flag = data.BgStyle == EDangoBrawlLevelBgStyle.Adventure;
			UUIItem item = base.GetItem(9);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			if (flag)
			{
				ActivityDangoBrawlController.Instance.RegisterTermHyperlink(base.GetText(10));
				LguiUtil.Instance.SetLocalTextNew(base.GetText(10), data.EnvironmentDesc, Array.Empty<object>());
			}
			List<TItem> dropPackagePreviewItemList = RewardConfig.Instance.GetDropPackagePreviewItemList(data.FirstClearDropId);
			GenericScrollViewNew<CommonItemSmallItemGrid, TItem> firstRewardScroll = this.FirstRewardScroll;
			if (firstRewardScroll != null)
			{
				firstRewardScroll.RefreshByData(dropPackagePreviewItemList, null, false);
			}
			UUIButtonComponent button = base.GetButton(13);
			if (button != null)
			{
				UUIItem uuiitem = button.RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(!data.IsLocked);
				}
			}
			FunctionalPanelConditionLock lockTipsItem = this.LockTipsItem;
			if (lockTipsItem != null)
			{
				lockTipsItem.SetUiActive(data.IsLocked);
			}
			FunctionalPanelConditionLock lockTipsItem2 = this.LockTipsItem;
			if (lockTipsItem2 == null)
			{
				return;
			}
			lockTipsItem2.SetTextByTextId(data.UnlockConditionDesc, Array.Empty<string>());
		}

		// Token: 0x06042845 RID: 272453 RVA: 0x01029DB8 File Offset: 0x01027FB8
		private void RefreshArchiveItem()
		{
			bool flag = this.OutGameData.HasSaveData();
			PopupCaptionItem captionItem = this.CaptionItem;
			if (captionItem != null)
			{
				captionItem.SetCaptionStateActive(true);
			}
			PopupCaptionItem captionItem2 = this.CaptionItem;
			if (captionItem2 != null)
			{
				captionItem2.SetCaptionStateTip(flag ? "Kurotato_Has_Archive" : "Kurotato_Can_Archive");
			}
			PopupCaptionItem captionItem3 = this.CaptionItem;
			if (captionItem3 == null)
			{
				return;
			}
			captionItem3.SetCaptionChangeColor(flag);
		}

		// Token: 0x06042846 RID: 272454 RVA: 0x01029E14 File Offset: 0x01028014
		private void SyncLevelIsNew(List<DangoBrawlLevelData> levelDataList)
		{
			for (int i = 0; i < levelDataList.Count; i++)
			{
				DangoBrawlLevelData dangoBrawlLevelData = levelDataList[i];
				dangoBrawlLevelData.IsNew = this.ActivityData.HasNewLevelRedDot(dangoBrawlLevelData.Id);
				dangoBrawlLevelData.IsLast = (i == levelDataList.Count - 1);
			}
		}

		// Token: 0x06042847 RID: 272455 RVA: 0x01029E64 File Offset: 0x01028064
		private void MarkLevelItemRead(DangoBrawlLevelItem item)
		{
			DangoBrawlLevelData levelData = item.LevelData;
			if (levelData == null || !levelData.IsNew)
			{
				return;
			}
			this.ActivityData.MarkNewLevelRead(new int?(levelData.Id), null);
			levelData.IsNew = false;
			item.SetRedDotVisible(false);
		}

		// Token: 0x06042848 RID: 272456 RVA: 0x01029EB4 File Offset: 0x010280B4
		private void OnClickLevelItem(DangoBrawlLevelItem item)
		{
			DangoBrawlLevelData levelData = item.LevelData;
			if (levelData == null)
			{
				return;
			}
			GenericScrollViewNew<DangoBrawlLevelItem, DangoBrawlLevelData> levelScroll = this.LevelScroll;
			if (levelScroll != null)
			{
				levelScroll.SelectGridProxy(item.GridIndex, false);
			}
			this.RefreshLevelInfoView(levelData);
			this.RefreshLevelOther(levelData);
			this.PlayCurrentBgSequenceThenSpine("Switch", 0.28f);
			this.MarkLevelItemRead(item);
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.PlaySequence("Switch", true, null);
		}

		// Token: 0x06042849 RID: 272457 RVA: 0x01029F28 File Offset: 0x01028128
		private bool OnShowRewardReceivedCallBack(TItem _)
		{
			DangoBrawlLevelData levelData = this.LevelData;
			return levelData != null && levelData.IsPassed;
		}

		// Token: 0x0604284A RID: 272458 RVA: 0x01029F3B File Offset: 0x0102813B
		private void OnHelpBtnClick()
		{
			HelpController.Instance.OpenHelpById(652);
		}

		// Token: 0x0604284B RID: 272459 RVA: 0x01029F4C File Offset: 0x0102814C
		private void OnArchiveBtnClick()
		{
			HelpController.Instance.OpenHelpById(678);
		}

		// Token: 0x0604284C RID: 272460 RVA: 0x01029F60 File Offset: 0x01028160
		private void OnConfirmBtnClick()
		{
			if (this.LevelData == null)
			{
				return;
			}
			if (this.LevelData.DefaultRoleId > 0)
			{
				bool isEnterSave = this.OutGameData.GetIsEnterSave();
				int id = this.LevelData.Id;
				ActivityDangoBrawlController.Instance.RequestEnterInstanceDungeon(id, isEnterSave, 0).Forget<bool>();
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.DangoBrawlRoleView, new DangoBrawlRoleViewOpenData
			{
				LevelId = new int?(this.LevelData.Id)
			}, null);
		}

		// Token: 0x0604284D RID: 272461 RVA: 0x01029FDC File Offset: 0x010281DC
		private void OnCloseBtnClick()
		{
			if (this.IfReturnToMainView)
			{
				TOpenViewCallBack finishCallback = delegate(bool _, int _)
				{
					base.CloseMe(null);
				};
				UiManager.Instance.OpenView(EUiViewName.DangoBrawlMainView, null, finishCallback);
				return;
			}
			base.CloseMe(null);
		}

		// Token: 0x04022A88 RID: 141960
		private const float SPINE_ANIM_DELAY_SWITCH = 0.28f;

		// Token: 0x04022A89 RID: 141961
		private const float SPINE_ANIM_DELAY_START = 0.52f;

		// Token: 0x04022A8A RID: 141962
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04022A8B RID: 141963
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<DangoBrawlLevelItem, DangoBrawlLevelData> LevelScroll;

		// Token: 0x04022A8C RID: 141964
		[Nullable(2)]
		private DangoBrawlLevelRoleItem UnlockRoleItem;

		// Token: 0x04022A8D RID: 141965
		[Nullable(2)]
		private DangoBrawlLevelBgItem LevelEasyBgItem;

		// Token: 0x04022A8E RID: 141966
		[Nullable(2)]
		private DangoBrawlLevelBgItem LevelNormalBgItem;

		// Token: 0x04022A8F RID: 141967
		[Nullable(2)]
		private DangoBrawlAdventureLevelBgItem LevelAdventureBgItem;

		// Token: 0x04022A90 RID: 141968
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> FirstRewardScroll;

		// Token: 0x04022A91 RID: 141969
		[Nullable(2)]
		private FunctionalPanelConditionLock LockTipsItem;

		// Token: 0x04022A92 RID: 141970
		[Nullable(2)]
		private SimpleGenericLayout HeartLayout;

		// Token: 0x04022A93 RID: 141971
		[Nullable(2)]
		private DangoBrawlLevelData LevelData;

		// Token: 0x04022A94 RID: 141972
		private int SelectedLevelId;

		// Token: 0x04022A95 RID: 141973
		private bool IsNormalMode;

		// Token: 0x04022A96 RID: 141974
		private bool IfReturnToMainView;

		// Token: 0x0200C9B8 RID: 51640
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403CF01 RID: 249601
			CaptionItem,
			// Token: 0x0403CF02 RID: 249602
			BgItem,
			// Token: 0x0403CF03 RID: 249603
			LevelScrollView,
			// Token: 0x0403CF04 RID: 249604
			LevelScrollViewMid,
			// Token: 0x0403CF05 RID: 249605
			LevelItem,
			// Token: 0x0403CF06 RID: 249606
			TxtLevelName,
			// Token: 0x0403CF07 RID: 249607
			TxtLevelNameDesc,
			// Token: 0x0403CF08 RID: 249608
			TxtCondition,
			// Token: 0x0403CF09 RID: 249609
			TxtMaxRetryCount,
			// Token: 0x0403CF0A RID: 249610
			EnvirItem,
			// Token: 0x0403CF0B RID: 249611
			TxtEnvir,
			// Token: 0x0403CF0C RID: 249612
			FirstDropRewardScroll,
			// Token: 0x0403CF0D RID: 249613
			FirstDropRewardItem,
			// Token: 0x0403CF0E RID: 249614
			BtnConfirm,
			// Token: 0x0403CF0F RID: 249615
			BgLockTips,
			// Token: 0x0403CF10 RID: 249616
			UnlockRoleItem,
			// Token: 0x0403CF11 RID: 249617
			HeartLayout,
			// Token: 0x0403CF12 RID: 249618
			HeartItem
		}
	}
}
