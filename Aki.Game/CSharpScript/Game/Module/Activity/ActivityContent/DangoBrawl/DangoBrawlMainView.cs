using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02006824 RID: 26660
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlMainView : UiViewBase
	{
		// Token: 0x1700973E RID: 38718
		// (get) Token: 0x0604286E RID: 272494 RVA: 0x0102A89C File Offset: 0x01028A9C
		private ActivityDangoBrawlData ActivityData
		{
			get
			{
				return ActivityDangoBrawlController.Instance.MyActivityData;
			}
		}

		// Token: 0x1700973F RID: 38719
		// (get) Token: 0x0604286F RID: 272495 RVA: 0x0102A8A8 File Offset: 0x01028AA8
		private DangoBrawlOutGameData OutGameData
		{
			get
			{
				return this.ActivityData.GetOutGameData();
			}
		}

		// Token: 0x06042870 RID: 272496 RVA: 0x0102A8B5 File Offset: 0x01028AB5
		public DangoBrawlMainView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06042871 RID: 272497 RVA: 0x0102A8C0 File Offset: 0x01028AC0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 14;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnStoryModeBtnClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnAdventureModeBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06042872 RID: 272498 RVA: 0x0102AB1C File Offset: 0x01028D1C
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlMainView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlMainView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06042873 RID: 272499 RVA: 0x0102AB5F File Offset: 0x01028D5F
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRedDotRefresh));
		}

		// Token: 0x06042874 RID: 272500 RVA: 0x0102AB7D File Offset: 0x01028D7D
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRedDotRefresh));
		}

		// Token: 0x06042875 RID: 272501 RVA: 0x0102AB9B File Offset: 0x01028D9B
		protected override void OnBeforeShow()
		{
			if (this.ActivityData.HasFirstOpenPageRedDot())
			{
				this.ActivityData.SetFirstOpenPageRedDot(false);
			}
			this.RefreshModeBtn();
			this.RefreshBottomBtn();
			this.RefreshArchiveItem();
			this.RefreshRedDot();
		}

		// Token: 0x06042876 RID: 272502 RVA: 0x0102ABD0 File Offset: 0x01028DD0
		private void RefreshModeBtn()
		{
			if (this.ActivityData == null)
			{
				return;
			}
			ValueTuple<int, int> levelProgress = this.OutGameData.GetLevelProgress(true);
			bool flag = levelProgress.Item1 >= levelProgress.Item2;
			UUIText text = base.GetText(2);
			if (text != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(levelProgress.Item1);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(levelProgress.Item2);
				text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			ValueTuple<int, int> levelProgress2 = this.OutGameData.GetLevelProgress(false);
			UUIButtonComponent button = base.GetButton(4);
			if (button != null)
			{
				button.SetSelfInteractive(flag);
			}
			UUIItem item = base.GetItem(7);
			if (item != null)
			{
				item.SetUIActive(!flag);
			}
			UUIText text2 = base.GetText(5);
			if (text2 != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(levelProgress2.Item1);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(levelProgress2.Item2);
				text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			if (!flag)
			{
				UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
				if (uiViewSequence == null)
				{
					return;
				}
				uiViewSequence.PlaySequence("Lock", false, null);
			}
		}

		// Token: 0x06042877 RID: 272503 RVA: 0x0102ACF0 File Offset: 0x01028EF0
		private void RefreshBottomBtn()
		{
			if (this.ActivityData == null)
			{
				return;
			}
			ValueTuple<int, int> taskProgress = this.OutGameData.GetTaskProgress(null);
			DangoBrawlMainButtonItem shopButton = this.ShopButton;
			if (shopButton != null)
			{
				shopButton.SetProgressText("DangoBrawlGeneral_Shop", new object[]
				{
					this.OutGameData.GetShopCoinCost()
				});
			}
			DangoBrawlMainButtonItem taskRewardButton = this.TaskRewardButton;
			if (taskRewardButton != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(taskProgress.Item1);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(taskProgress.Item2);
				taskRewardButton.SetProgressText(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			DangoBrawlFuncButtonItem handBookButton = this.HandBookButton;
			if (handBookButton != null)
			{
				handBookButton.SetButtonState();
			}
			DangoBrawlFuncButtonItem roleButton = this.RoleButton;
			if (roleButton == null)
			{
				return;
			}
			roleButton.SetButtonState();
		}

		// Token: 0x06042878 RID: 272504 RVA: 0x0102ADB4 File Offset: 0x01028FB4
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

		// Token: 0x06042879 RID: 272505 RVA: 0x0102AE10 File Offset: 0x01029010
		private void RefreshRedDot()
		{
			DangoBrawlMainButtonItem shopButton = this.ShopButton;
			if (shopButton != null)
			{
				shopButton.SetRedDotVisible(this.ActivityData.HasShopRedDot());
			}
			DangoBrawlMainButtonItem taskRewardButton = this.TaskRewardButton;
			if (taskRewardButton != null)
			{
				taskRewardButton.SetRedDotVisible(this.ActivityData.HasLimitRewardRedDot());
			}
			DangoBrawlFuncButtonItem handBookButton = this.HandBookButton;
			if (handBookButton != null)
			{
				handBookButton.SetRedDotVisible(this.ActivityData.HasNewItemRedDot(null));
			}
			DangoBrawlFuncButtonItem roleButton = this.RoleButton;
			if (roleButton != null)
			{
				roleButton.SetRedDotVisible(this.ActivityData.HasNewRoleRedDot());
			}
			UUIItem item = base.GetItem(12);
			if (item != null)
			{
				item.SetUIActive(this.ActivityData.HasNewLevelRedDot(new bool?(false)));
			}
			UUIItem item2 = base.GetItem(13);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(this.ActivityData.HasNewLevelRedDot(new bool?(true)));
		}

		// Token: 0x0604287A RID: 272506 RVA: 0x0102AEE0 File Offset: 0x010290E0
		private void CheckReadSave(Action enterLevelFunc)
		{
			DangoBrawlSaveData saveData = this.OutGameData.GetSaveData();
			if (saveData != null && saveData.LevelId > 0)
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.DangoBrawlEnterSaveConfirm);
				confirmBoxDataNew.IsEscViewTriggerCallBack = false;
				confirmBoxDataNew.FunctionMap[1] = delegate()
				{
					this.OutGameData.SetIsEnterSave(false);
					enterLevelFunc();
				};
				confirmBoxDataNew.FunctionMap[2] = delegate()
				{
					this.OutGameData.SetIsEnterSave(true);
					ActivityDangoBrawlController.Instance.RequestEnterInstanceDungeon(saveData.LevelId, true, saveData.RoleId).Forget<bool>();
				};
				ValueTuple<string, int> levelModeInfo = this.OutGameData.GetLevelModeInfo(saveData.LevelId);
				string item = levelModeInfo.Item1;
				int item2 = levelModeInfo.Item2;
				confirmBoxDataNew.SetTextArgs(new string[]
				{
					item,
					item2.ToString(),
					saveData.RoundNum.ToString()
				});
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			enterLevelFunc();
		}

		// Token: 0x0604287B RID: 272507 RVA: 0x0102AFD8 File Offset: 0x010291D8
		private void OnRedDotRefresh(int activityId)
		{
			if (this.ActivityData == null || activityId != this.ActivityData.Id)
			{
				return;
			}
			this.RefreshBottomBtn();
			this.RefreshRedDot();
		}

		// Token: 0x0604287C RID: 272508 RVA: 0x0102AFFD File Offset: 0x010291FD
		private void OnHelpBtnClick()
		{
			HelpController.Instance.OpenHelpById(652);
		}

		// Token: 0x0604287D RID: 272509 RVA: 0x0102B00E File Offset: 0x0102920E
		private void OnArchiveBtnClick()
		{
			HelpController.Instance.OpenHelpById(678);
		}

		// Token: 0x0604287E RID: 272510 RVA: 0x0102B01F File Offset: 0x0102921F
		private void OnShopBtnClick()
		{
			UiManager.Instance.OpenView(EUiViewName.DangoBrawlShopView, null, null);
		}

		// Token: 0x0604287F RID: 272511 RVA: 0x0102B032 File Offset: 0x01029232
		private void OnTaskRewardBtnClick()
		{
			UiManager.Instance.OpenView(EUiViewName.DangoBrawlRewardsView, null, null);
		}

		// Token: 0x06042880 RID: 272512 RVA: 0x0102B045 File Offset: 0x01029245
		private void OnRoleBtnClick()
		{
			UiManager.Instance.OpenView(EUiViewName.DangoBrawlRoleHandBookView, null, null);
		}

		// Token: 0x06042881 RID: 272513 RVA: 0x0102B058 File Offset: 0x01029258
		private void OnHandBookBtnClick()
		{
			UiManager.Instance.OpenView(EUiViewName.DangoBrawlHandBookView, null, null);
		}

		// Token: 0x06042882 RID: 272514 RVA: 0x0102B06B File Offset: 0x0102926B
		private void OnStoryModeBtnClick()
		{
			this.CheckReadSave(delegate
			{
				UiManager.Instance.OpenView(EUiViewName.DangoBrawlLevelView, new DangoBrawlLevelViewOpenData
				{
					IsNormalMode = new bool?(true)
				}, null);
			});
		}

		// Token: 0x06042883 RID: 272515 RVA: 0x0102B094 File Offset: 0x01029294
		private void OnAdventureModeBtnClick()
		{
			if (!this.OutGameData.IsAllNormalLevelPassed())
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("DangoBrawlGeneral_1001", Array.Empty<object>());
				return;
			}
			this.CheckReadSave(delegate
			{
				UiManager.Instance.OpenView(EUiViewName.DangoBrawlLevelView, new DangoBrawlLevelViewOpenData
				{
					IsNormalMode = new bool?(false)
				}, null);
			});
		}

		// Token: 0x06042884 RID: 272516 RVA: 0x0102B0E8 File Offset: 0x010292E8
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x04022A9E RID: 141982
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04022A9F RID: 141983
		[Nullable(2)]
		private DangoBrawlMainButtonItem ShopButton;

		// Token: 0x04022AA0 RID: 141984
		[Nullable(2)]
		private DangoBrawlMainButtonItem TaskRewardButton;

		// Token: 0x04022AA1 RID: 141985
		[Nullable(2)]
		private DangoBrawlFuncButtonItem HandBookButton;

		// Token: 0x04022AA2 RID: 141986
		[Nullable(2)]
		private DangoBrawlFuncButtonItem RoleButton;

		// Token: 0x0200C9C2 RID: 51650
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x0403CF39 RID: 249657
			ItemCaption,
			// Token: 0x0403CF3A RID: 249658
			StoryModeBtn,
			// Token: 0x0403CF3B RID: 249659
			StoryProgressNum,
			// Token: 0x0403CF3C RID: 249660
			SprStoryFinish,
			// Token: 0x0403CF3D RID: 249661
			AdventureModeBtn,
			// Token: 0x0403CF3E RID: 249662
			AdventureProgressNum,
			// Token: 0x0403CF3F RID: 249663
			SprAdventureFinish,
			// Token: 0x0403CF40 RID: 249664
			AdventureUnlockItem,
			// Token: 0x0403CF41 RID: 249665
			ShopBtn,
			// Token: 0x0403CF42 RID: 249666
			TaskRewardBtn,
			// Token: 0x0403CF43 RID: 249667
			HandBookBtn,
			// Token: 0x0403CF44 RID: 249668
			RoleBtn,
			// Token: 0x0403CF45 RID: 249669
			AdventureRedItem,
			// Token: 0x0403CF46 RID: 249670
			NormalRedItem
		}
	}
}
