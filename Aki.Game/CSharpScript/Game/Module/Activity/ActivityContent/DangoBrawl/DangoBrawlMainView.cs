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
	// Token: 0x02005774 RID: 22388
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlMainView : UiViewBase
	{
		// Token: 0x17006A7F RID: 27263
		// (get) Token: 0x060373C2 RID: 226242 RVA: 0x00F6BDD8 File Offset: 0x00F69FD8
		private ActivityDangoBrawlData ActivityData
		{
			get
			{
				return ActivityDangoBrawlController.Instance.MyActivityData;
			}
		}

		// Token: 0x17006A80 RID: 27264
		// (get) Token: 0x060373C3 RID: 226243 RVA: 0x00F6BDE4 File Offset: 0x00F69FE4
		private DangoBrawlOutGameData OutGameData
		{
			get
			{
				return this.ActivityData.GetOutGameData();
			}
		}

		// Token: 0x060373C4 RID: 226244 RVA: 0x00F6BDF1 File Offset: 0x00F69FF1
		public DangoBrawlMainView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060373C5 RID: 226245 RVA: 0x00F6BDFC File Offset: 0x00F69FFC
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

		// Token: 0x060373C6 RID: 226246 RVA: 0x00F6C058 File Offset: 0x00F6A258
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlMainView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlMainView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060373C7 RID: 226247 RVA: 0x00F6C09B File Offset: 0x00F6A29B
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRedDotRefresh));
		}

		// Token: 0x060373C8 RID: 226248 RVA: 0x00F6C0B9 File Offset: 0x00F6A2B9
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRedDotRefresh));
		}

		// Token: 0x060373C9 RID: 226249 RVA: 0x00F6C0D7 File Offset: 0x00F6A2D7
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

		// Token: 0x060373CA RID: 226250 RVA: 0x00F6C10C File Offset: 0x00F6A30C
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

		// Token: 0x060373CB RID: 226251 RVA: 0x00F6C22C File Offset: 0x00F6A42C
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

		// Token: 0x060373CC RID: 226252 RVA: 0x00F6C2F0 File Offset: 0x00F6A4F0
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

		// Token: 0x060373CD RID: 226253 RVA: 0x00F6C34C File Offset: 0x00F6A54C
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

		// Token: 0x060373CE RID: 226254 RVA: 0x00F6C41C File Offset: 0x00F6A61C
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

		// Token: 0x060373CF RID: 226255 RVA: 0x00F6C514 File Offset: 0x00F6A714
		private void OnRedDotRefresh(int activityId)
		{
			if (this.ActivityData == null || activityId != this.ActivityData.Id)
			{
				return;
			}
			this.RefreshBottomBtn();
			this.RefreshRedDot();
		}

		// Token: 0x060373D0 RID: 226256 RVA: 0x00F6C539 File Offset: 0x00F6A739
		private void OnHelpBtnClick()
		{
			HelpController.Instance.OpenHelpById(652);
		}

		// Token: 0x060373D1 RID: 226257 RVA: 0x00F6C54A File Offset: 0x00F6A74A
		private void OnArchiveBtnClick()
		{
			HelpController.Instance.OpenHelpById(678);
		}

		// Token: 0x060373D2 RID: 226258 RVA: 0x00F6C55B File Offset: 0x00F6A75B
		private void OnShopBtnClick()
		{
			UiManager.Instance.OpenView(EUiViewName.DangoBrawlShopView, null, null);
		}

		// Token: 0x060373D3 RID: 226259 RVA: 0x00F6C56E File Offset: 0x00F6A76E
		private void OnTaskRewardBtnClick()
		{
			UiManager.Instance.OpenView(EUiViewName.DangoBrawlRewardsView, null, null);
		}

		// Token: 0x060373D4 RID: 226260 RVA: 0x00F6C581 File Offset: 0x00F6A781
		private void OnRoleBtnClick()
		{
			UiManager.Instance.OpenView(EUiViewName.DangoBrawlRoleHandBookView, null, null);
		}

		// Token: 0x060373D5 RID: 226261 RVA: 0x00F6C594 File Offset: 0x00F6A794
		private void OnHandBookBtnClick()
		{
			UiManager.Instance.OpenView(EUiViewName.DangoBrawlHandBookView, null, null);
		}

		// Token: 0x060373D6 RID: 226262 RVA: 0x00F6C5A7 File Offset: 0x00F6A7A7
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

		// Token: 0x060373D7 RID: 226263 RVA: 0x00F6C5D0 File Offset: 0x00F6A7D0
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

		// Token: 0x060373D8 RID: 226264 RVA: 0x00F6C624 File Offset: 0x00F6A824
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401D2FB RID: 119547
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401D2FC RID: 119548
		[Nullable(2)]
		private DangoBrawlMainButtonItem ShopButton;

		// Token: 0x0401D2FD RID: 119549
		[Nullable(2)]
		private DangoBrawlMainButtonItem TaskRewardButton;

		// Token: 0x0401D2FE RID: 119550
		[Nullable(2)]
		private DangoBrawlFuncButtonItem HandBookButton;

		// Token: 0x0401D2FF RID: 119551
		[Nullable(2)]
		private DangoBrawlFuncButtonItem RoleButton;

		// Token: 0x0200B38E RID: 45966
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04037823 RID: 227363
			ItemCaption,
			// Token: 0x04037824 RID: 227364
			StoryModeBtn,
			// Token: 0x04037825 RID: 227365
			StoryProgressNum,
			// Token: 0x04037826 RID: 227366
			SprStoryFinish,
			// Token: 0x04037827 RID: 227367
			AdventureModeBtn,
			// Token: 0x04037828 RID: 227368
			AdventureProgressNum,
			// Token: 0x04037829 RID: 227369
			SprAdventureFinish,
			// Token: 0x0403782A RID: 227370
			AdventureUnlockItem,
			// Token: 0x0403782B RID: 227371
			ShopBtn,
			// Token: 0x0403782C RID: 227372
			TaskRewardBtn,
			// Token: 0x0403782D RID: 227373
			HandBookBtn,
			// Token: 0x0403782E RID: 227374
			RoleBtn,
			// Token: 0x0403782F RID: 227375
			AdventureRedItem,
			// Token: 0x04037830 RID: 227376
			NormalRedItem
		}
	}
}
