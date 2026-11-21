using System;
using System.Collections.Generic;
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
	// Token: 0x02005770 RID: 22384
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlLevelView : UiViewBase
	{
		// Token: 0x17006A7D RID: 27261
		// (get) Token: 0x06037389 RID: 226185 RVA: 0x00F6AAFD File Offset: 0x00F68CFD
		private ActivityDangoBrawlData ActivityData
		{
			get
			{
				return ActivityDangoBrawlController.Instance.MyActivityData;
			}
		}

		// Token: 0x17006A7E RID: 27262
		// (get) Token: 0x0603738A RID: 226186 RVA: 0x00F6AB09 File Offset: 0x00F68D09
		private DangoBrawlOutGameData OutGameData
		{
			get
			{
				return this.ActivityData.GetOutGameData();
			}
		}

		// Token: 0x0603738B RID: 226187 RVA: 0x00F6AB16 File Offset: 0x00F68D16
		public DangoBrawlLevelView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603738C RID: 226188 RVA: 0x00F6AB20 File Offset: 0x00F68D20
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

		// Token: 0x0603738D RID: 226189 RVA: 0x00F6ADE4 File Offset: 0x00F68FE4
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlLevelView.<OnBeforeStartAsync>d__22 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlLevelView.<OnBeforeStartAsync>d__22>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603738E RID: 226190 RVA: 0x00F6AE28 File Offset: 0x00F69028
		[return: Nullable(2)]
		private DangoBrawlLevelData ResolveAutoSelectLevel(List<DangoBrawlLevelData> levelDataList)
		{
			if (levelDataList.Count == 0)
			{
				return null;
			}
			DangoBrawlLevelData dangoBrawlLevelData = null;
			for (int i = 0; i < levelDataList.Count; i++)
			{
				DangoBrawlLevelData dangoBrawlLevelData2 = levelDataList[i];
				if (!dangoBrawlLevelData2.IsLocked && !dangoBrawlLevelData2.IsPassed)
				{
					dangoBrawlLevelData = dangoBrawlLevelData2;
					break;
				}
			}
			if (dangoBrawlLevelData != null)
			{
				return dangoBrawlLevelData;
			}
			for (int j = levelDataList.Count - 1; j >= 0; j--)
			{
				if (!levelDataList[j].IsLocked)
				{
					return levelDataList[j];
				}
			}
			return levelDataList[levelDataList.Count - 1];
		}

		// Token: 0x0603738F RID: 226191 RVA: 0x00F6AEAC File Offset: 0x00F690AC
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

		// Token: 0x06037390 RID: 226192 RVA: 0x00F6AEFC File Offset: 0x00F690FC
		protected override void OnBeforeShow()
		{
			this.RefreshArchiveItem();
			ActivityDangoBrawlController.Instance.TryPlayRoleUnlockQueue();
		}

		// Token: 0x06037391 RID: 226193 RVA: 0x00F6AF0E File Offset: 0x00F6910E
		protected override void OnBeforeDestroy()
		{
			ActivityDangoBrawlController.Instance.UnRegisterTermHyperlink(base.GetText(10));
		}

		// Token: 0x06037392 RID: 226194 RVA: 0x00F6AF22 File Offset: 0x00F69122
		private void OnViewStartSequence(string _)
		{
			this.PlayCurrentBgSequenceThenSpine("Start", 0.52f);
		}

		// Token: 0x06037393 RID: 226195 RVA: 0x00F6AF34 File Offset: 0x00F69134
		private void OnViewCloseSequence(string _)
		{
			this.PlayCurrentBgSequence("Close");
		}

		// Token: 0x06037394 RID: 226196 RVA: 0x00F6AF44 File Offset: 0x00F69144
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

		// Token: 0x06037395 RID: 226197 RVA: 0x00F6AFCC File Offset: 0x00F691CC
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

		// Token: 0x06037396 RID: 226198 RVA: 0x00F6B057 File Offset: 0x00F69257
		private DangoBrawlLevelItem InitLevelItem()
		{
			return new DangoBrawlLevelItem
			{
				OnClickToggleBack = new Action<DangoBrawlLevelItem>(this.OnClickLevelItem)
			};
		}

		// Token: 0x06037397 RID: 226199 RVA: 0x00F6B070 File Offset: 0x00F69270
		private CommonItemSmallItemGrid InitFirstRewardItem()
		{
			return new CommonItemSmallItemGrid
			{
				ShowReceivedCallBack = new Func<TItem, bool>(this.OnShowRewardReceivedCallBack)
			};
		}

		// Token: 0x06037398 RID: 226200 RVA: 0x00F6B08C File Offset: 0x00F6928C
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

		// Token: 0x06037399 RID: 226201 RVA: 0x00F6B18C File Offset: 0x00F6938C
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

		// Token: 0x0603739A RID: 226202 RVA: 0x00F6B304 File Offset: 0x00F69504
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

		// Token: 0x0603739B RID: 226203 RVA: 0x00F6B360 File Offset: 0x00F69560
		private void SyncLevelIsNew(List<DangoBrawlLevelData> levelDataList)
		{
			for (int i = 0; i < levelDataList.Count; i++)
			{
				DangoBrawlLevelData dangoBrawlLevelData = levelDataList[i];
				dangoBrawlLevelData.IsNew = this.ActivityData.HasNewLevelRedDot(dangoBrawlLevelData.Id);
				dangoBrawlLevelData.IsLast = (i == levelDataList.Count - 1);
			}
		}

		// Token: 0x0603739C RID: 226204 RVA: 0x00F6B3B0 File Offset: 0x00F695B0
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

		// Token: 0x0603739D RID: 226205 RVA: 0x00F6B400 File Offset: 0x00F69600
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

		// Token: 0x0603739E RID: 226206 RVA: 0x00F6B474 File Offset: 0x00F69674
		private bool OnShowRewardReceivedCallBack(TItem _)
		{
			DangoBrawlLevelData levelData = this.LevelData;
			return levelData != null && levelData.IsPassed;
		}

		// Token: 0x0603739F RID: 226207 RVA: 0x00F6B487 File Offset: 0x00F69687
		private void OnHelpBtnClick()
		{
			HelpController.Instance.OpenHelpById(652);
		}

		// Token: 0x060373A0 RID: 226208 RVA: 0x00F6B498 File Offset: 0x00F69698
		private void OnArchiveBtnClick()
		{
			HelpController.Instance.OpenHelpById(678);
		}

		// Token: 0x060373A1 RID: 226209 RVA: 0x00F6B4AC File Offset: 0x00F696AC
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

		// Token: 0x060373A2 RID: 226210 RVA: 0x00F6B528 File Offset: 0x00F69728
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

		// Token: 0x0401D2E5 RID: 119525
		private const float SPINE_ANIM_DELAY_SWITCH = 0.28f;

		// Token: 0x0401D2E6 RID: 119526
		private const float SPINE_ANIM_DELAY_START = 0.52f;

		// Token: 0x0401D2E7 RID: 119527
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401D2E8 RID: 119528
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<DangoBrawlLevelItem, DangoBrawlLevelData> LevelScroll;

		// Token: 0x0401D2E9 RID: 119529
		[Nullable(2)]
		private DangoBrawlLevelRoleItem UnlockRoleItem;

		// Token: 0x0401D2EA RID: 119530
		[Nullable(2)]
		private DangoBrawlLevelBgItem LevelEasyBgItem;

		// Token: 0x0401D2EB RID: 119531
		[Nullable(2)]
		private DangoBrawlLevelBgItem LevelNormalBgItem;

		// Token: 0x0401D2EC RID: 119532
		[Nullable(2)]
		private DangoBrawlAdventureLevelBgItem LevelAdventureBgItem;

		// Token: 0x0401D2ED RID: 119533
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> FirstRewardScroll;

		// Token: 0x0401D2EE RID: 119534
		[Nullable(2)]
		private FunctionalPanelConditionLock LockTipsItem;

		// Token: 0x0401D2EF RID: 119535
		[Nullable(2)]
		private SimpleGenericLayout HeartLayout;

		// Token: 0x0401D2F0 RID: 119536
		[Nullable(2)]
		private DangoBrawlLevelData LevelData;

		// Token: 0x0401D2F1 RID: 119537
		private int SelectedLevelId;

		// Token: 0x0401D2F2 RID: 119538
		private bool IsNormalMode;

		// Token: 0x0401D2F3 RID: 119539
		private bool IfReturnToMainView;

		// Token: 0x0200B385 RID: 45957
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x040377EE RID: 227310
			CaptionItem,
			// Token: 0x040377EF RID: 227311
			BgItem,
			// Token: 0x040377F0 RID: 227312
			LevelScrollView,
			// Token: 0x040377F1 RID: 227313
			LevelScrollViewMid,
			// Token: 0x040377F2 RID: 227314
			LevelItem,
			// Token: 0x040377F3 RID: 227315
			TxtLevelName,
			// Token: 0x040377F4 RID: 227316
			TxtLevelNameDesc,
			// Token: 0x040377F5 RID: 227317
			TxtCondition,
			// Token: 0x040377F6 RID: 227318
			TxtMaxRetryCount,
			// Token: 0x040377F7 RID: 227319
			EnvirItem,
			// Token: 0x040377F8 RID: 227320
			TxtEnvir,
			// Token: 0x040377F9 RID: 227321
			FirstDropRewardScroll,
			// Token: 0x040377FA RID: 227322
			FirstDropRewardItem,
			// Token: 0x040377FB RID: 227323
			BtnConfirm,
			// Token: 0x040377FC RID: 227324
			BgLockTips,
			// Token: 0x040377FD RID: 227325
			UnlockRoleItem,
			// Token: 0x040377FE RID: 227326
			HeartLayout,
			// Token: 0x040377FF RID: 227327
			HeartItem
		}
	}
}
