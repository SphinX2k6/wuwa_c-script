using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity
{
	// Token: 0x02005EF8 RID: 24312
	[NullableContext(1)]
	[Nullable(0)]
	public class GuQinActivityMainView : UiViewBase
	{
		// Token: 0x0603DC57 RID: 253015 RVA: 0x00EEE692 File Offset: 0x00EEC892
		public GuQinActivityMainView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603DC58 RID: 253016 RVA: 0x00EEE6B4 File Offset: 0x00EEC8B4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 20;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(16, new Action(this.OnReceivedBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603DC59 RID: 253017 RVA: 0x00EEE9BC File Offset: 0x00EECBBC
		protected override UniTask OnBeforeStartAsync()
		{
			GuQinActivityMainView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<GuQinActivityMainView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603DC5A RID: 253018 RVA: 0x00EEEA00 File Offset: 0x00EECC00
		protected override void OnStart()
		{
			int index = 0;
			int num = -1;
			foreach (KeyValuePair<int, GuQinActivityTabData> keyValuePair in this.Data.GetTabDataMap())
			{
				int num2;
				GuQinActivityTabData guQinActivityTabData;
				keyValuePair.Deconstruct(out num2, out guQinActivityTabData);
				int num3 = num2;
				GuQinActivityTabData guQinActivityTabData2 = guQinActivityTabData;
				if (guQinActivityTabData2.GetStatus() != EGuQinActivityTabStatus.Lock)
				{
					index = num3;
				}
				using (List<GuQinActivityTaskData>.Enumerator enumerator2 = guQinActivityTabData2.TaskList.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						if (enumerator2.Current.GetStatus() == EGuQinActivityTaskStatus.Progressing)
						{
							num = num3;
						}
					}
				}
			}
			if (num >= 0)
			{
				index = num;
			}
			this.ToggleItems[index].SetToggleState(EToggleState.ETT_Checked, true);
		}

		// Token: 0x0603DC5B RID: 253019 RVA: 0x00EEEAD0 File Offset: 0x00EECCD0
		private CommonItemSmallItemGrid InitGridItem()
		{
			return new CommonItemSmallItemGrid
			{
				ShowReceivedCallBack = ((TItem _) => this.CurrentTaskData.Rewarded)
			};
		}

		// Token: 0x0603DC5C RID: 253020 RVA: 0x00EEEAE9 File Offset: 0x00EECCE9
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.ActivityViewRefreshCurrent, new Action<int>(this.OnActivityRefresh));
		}

		// Token: 0x0603DC5D RID: 253021 RVA: 0x00EEEB07 File Offset: 0x00EECD07
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.ActivityViewRefreshCurrent, new Action<int>(this.OnActivityRefresh));
		}

		// Token: 0x0603DC5E RID: 253022 RVA: 0x00EEEB28 File Offset: 0x00EECD28
		private void OnActivityRefresh(int activityId)
		{
			if (activityId != this.Data.Id)
			{
				return;
			}
			foreach (GuQinActivityMainViewToggleItem guQinActivityMainViewToggleItem in this.ToggleItems)
			{
				guQinActivityMainViewToggleItem.RefreshDisplay(guQinActivityMainViewToggleItem == this.CurrentSelectToggleItem);
			}
			GuQinActivityMainViewToggleItem currentSelectToggleItem = this.CurrentSelectToggleItem;
			GuQinActivityTabData guQinActivityTabData = (currentSelectToggleItem != null) ? currentSelectToggleItem.Data : null;
			if (guQinActivityTabData != null)
			{
				this.RefreshSubToggles(guQinActivityTabData);
			}
			if (this.CurrentTaskData != null)
			{
				this.RefreshUi();
			}
		}

		// Token: 0x0603DC5F RID: 253023 RVA: 0x00EEEBBC File Offset: 0x00EECDBC
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603DC60 RID: 253024 RVA: 0x00EEEBC5 File Offset: 0x00EECDC5
		private void OnHelpBtnClick()
		{
			HelpController.Instance.OpenHelpById(655);
		}

		// Token: 0x0603DC61 RID: 253025 RVA: 0x00EEEBD8 File Offset: 0x00EECDD8
		private void FocusBackToSelectedToggle()
		{
			if (!Info.Instance.IsInGamepad())
			{
				return;
			}
			GuQinActivityMainViewToggleItem currentSelectToggleItem = this.CurrentSelectToggleItem;
			if (currentSelectToggleItem == null)
			{
				return;
			}
			UiNavigationNewController.Instance.SetNavigationFocusForView(currentSelectToggleItem.GetRootItem(), true, true, false);
		}

		// Token: 0x0603DC62 RID: 253026 RVA: 0x00EEEC14 File Offset: 0x00EECE14
		private void OnToggleSelect(GuQinActivityMainViewToggleItem item, GuQinActivityTabData data)
		{
			GuQinActivityMainViewToggleItem currentSelectToggleItem = this.CurrentSelectToggleItem;
			if (currentSelectToggleItem != null)
			{
				currentSelectToggleItem.SetToggleState(EToggleState.ETT_UnChecked, true);
			}
			this.CurrentSelectToggleItem = item;
			this.CurrentSelectSubToggleItem = null;
			int index = 0;
			for (int i = 0; i < data.TaskList.Count; i++)
			{
				this.SubToggleItems[i].SetToggleState(EToggleState.ETT_UnChecked, true);
				if (data.TaskList[i].GetStatus() > EGuQinActivityTaskStatus.Lock)
				{
					index = i;
				}
			}
			this.RefreshSubToggles(data);
			this.SubToggleItems[index].SetToggleState(EToggleState.ETT_Checked, true);
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.PlayOrReplaySequenceByName("Switch", false, null);
		}

		// Token: 0x0603DC63 RID: 253027 RVA: 0x00EEECBC File Offset: 0x00EECEBC
		private void RefreshSubToggles(GuQinActivityTabData data)
		{
			for (int i = 0; i < data.TaskList.Count; i++)
			{
				this.SubToggleItems[i].Refresh(data.TaskList[i]);
			}
			if (data.TaskList.Count < 2)
			{
				base.GetItem(5).SetUIActive(false);
				return;
			}
			base.GetItem(5).SetUIActive(true);
			int openDay = data.TaskList[0].GetConfig().OpenDay;
			base.GetText(6).SetText(openDay.ToString(), true);
			base.GetText(7).SetText((openDay + 3).ToString(), true);
		}

		// Token: 0x0603DC64 RID: 253028 RVA: 0x00EEED6C File Offset: 0x00EECF6C
		private void OnSubToggleSelect(GuQinActivityMainViewSubToggleItem item, GuQinActivityTaskData data)
		{
			GuQinActivityMainViewSubToggleItem currentSelectSubToggleItem = this.CurrentSelectSubToggleItem;
			if (currentSelectSubToggleItem != null)
			{
				currentSelectSubToggleItem.SetToggleState(EToggleState.ETT_UnChecked, true);
			}
			this.CurrentSelectSubToggleItem = item;
			this.CurrentTaskData = data;
			this.RefreshUi();
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.PlayOrReplaySequenceByName("Switch2", false, null);
		}

		// Token: 0x0603DC65 RID: 253029 RVA: 0x00EEEDC0 File Offset: 0x00EECFC0
		private void RefreshUi()
		{
			GuQinActivityTask config = this.CurrentTaskData.GetConfig();
			Dictionary<int, int> dictionary = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackage(config.RewardId).Value.DropPreview();
			List<TItem> list = new List<TItem>();
			foreach (KeyValuePair<int, int> keyValuePair in dictionary)
			{
				int num;
				int num2;
				keyValuePair.Deconstruct(out num, out num2);
				int itemId = num;
				int count = num2;
				TItem item = new TItem(new InventoryDefine.GetItemData(itemId, 0), count);
				list.Add(item);
			}
			GenericLayout<CommonItemSmallItemGrid, TItem> rewardLayout = this.RewardLayout;
			if (rewardLayout != null)
			{
				rewardLayout.RefreshByData(list, null, false);
			}
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(10), config.Title, Array.Empty<object>());
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(11), config.Desc, Array.Empty<object>());
			base.TrySetTextureByPath(config.BgPath, base.GetTexture(18), null, null);
			EGuQinActivityTaskStatus status = this.CurrentTaskData.GetStatus();
			base.GetItem(14).SetUIActive(this.CurrentTaskData.Rewarded);
			base.GetItem(15).SetUIActive(status == EGuQinActivityTaskStatus.Progressing);
			base.GetButton(16).RootUIComp.Get().SetUIActive(status == EGuQinActivityTaskStatus.Completed && !this.CurrentTaskData.Rewarded);
			ActivityFunctionalTypeA functionalComponent = this.FunctionalComponent;
			if (functionalComponent != null)
			{
				FunctionalPanelConditionActivate panelActivate = functionalComponent.PanelActivate;
				if (panelActivate != null)
				{
					panelActivate.SetUiActive(status == EGuQinActivityTaskStatus.Completed);
				}
			}
			ActivityFunctionalTypeA functionalComponent2 = this.FunctionalComponent;
			if (functionalComponent2 != null)
			{
				ActivityButtonItem functionButton = functionalComponent2.FunctionButton;
				if (functionButton != null)
				{
					functionButton.SetUiActive(status != EGuQinActivityTaskStatus.Completed);
				}
			}
			ActivityFunctionalTypeA functionalComponent3 = this.FunctionalComponent;
			if (functionalComponent3 == null)
			{
				return;
			}
			ActivityButtonItem functionButton2 = functionalComponent3.FunctionButton;
			if (functionButton2 == null)
			{
				return;
			}
			functionButton2.SetRedDotVisible(this.CurrentTaskData.GetIsUnlockRedDot());
		}

		// Token: 0x0603DC66 RID: 253030 RVA: 0x00EEEFA8 File Offset: 0x00EED1A8
		private void OnReceivedBtnClick()
		{
			GuQinActivityController.Instance.RequestReward(this.CurrentTaskData, new Action(this.OnRewardSuccess));
		}

		// Token: 0x0603DC67 RID: 253031 RVA: 0x00EEEFC6 File Offset: 0x00EED1C6
		private void OnRewardSuccess()
		{
			this.RefreshUi();
			this.RefreshRedDot();
		}

		// Token: 0x0603DC68 RID: 253032 RVA: 0x00EEEFD4 File Offset: 0x00EED1D4
		private void OnGotoBtnClick()
		{
			int questId = this.CurrentTaskData.GetConfig().QuestId;
			this.Data.RemoveNewQuestRedDot(this.CurrentTaskData.Id);
			this.RefreshRedDot();
			UiManager.Instance.OpenView(EUiViewName.QuestView, questId, null);
		}

		// Token: 0x0603DC69 RID: 253033 RVA: 0x00EEF028 File Offset: 0x00EED228
		private void RefreshRedDot()
		{
			foreach (GuQinActivityMainViewToggleItem guQinActivityMainViewToggleItem in this.ToggleItems)
			{
				guQinActivityMainViewToggleItem.RefreshRedDot();
			}
			foreach (GuQinActivityMainViewSubToggleItem guQinActivityMainViewSubToggleItem in this.SubToggleItems)
			{
				guQinActivityMainViewSubToggleItem.RefreshRedDot();
			}
			ActivityFunctionalTypeA functionalComponent = this.FunctionalComponent;
			if (functionalComponent == null)
			{
				return;
			}
			ActivityButtonItem functionButton = functionalComponent.FunctionButton;
			if (functionButton == null)
			{
				return;
			}
			functionButton.SetRedDotVisible(this.CurrentTaskData.GetIsUnlockRedDot());
		}

		// Token: 0x0402046A RID: 132202
		private const int ToggleCount = 4;

		// Token: 0x0402046B RID: 132203
		private const int SubToggleCount = 2;

		// Token: 0x0402046C RID: 132204
		private GuQinActivityData Data;

		// Token: 0x0402046D RID: 132205
		[Nullable(2)]
		private GuQinActivityMainViewToggleItem CurrentSelectToggleItem;

		// Token: 0x0402046E RID: 132206
		[Nullable(2)]
		private GuQinActivityMainViewSubToggleItem CurrentSelectSubToggleItem;

		// Token: 0x0402046F RID: 132207
		private GuQinActivityTaskData CurrentTaskData;

		// Token: 0x04020470 RID: 132208
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04020471 RID: 132209
		[Nullable(2)]
		private ActivityFunctionalTypeA FunctionalComponent;

		// Token: 0x04020472 RID: 132210
		private readonly List<GuQinActivityMainViewToggleItem> ToggleItems = new List<GuQinActivityMainViewToggleItem>();

		// Token: 0x04020473 RID: 132211
		private readonly List<GuQinActivityMainViewSubToggleItem> SubToggleItems = new List<GuQinActivityMainViewSubToggleItem>();

		// Token: 0x04020474 RID: 132212
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<CommonItemSmallItemGrid, TItem> RewardLayout;

		// Token: 0x0200C229 RID: 49705
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403AA8A RID: 240266
			public const int CaptionItem = 0;

			// Token: 0x0403AA8B RID: 240267
			public const int Toggle1 = 1;

			// Token: 0x0403AA8C RID: 240268
			public const int Toggle2 = 2;

			// Token: 0x0403AA8D RID: 240269
			public const int Toggle3 = 3;

			// Token: 0x0403AA8E RID: 240270
			public const int Toggle4 = 4;

			// Token: 0x0403AA8F RID: 240271
			public const int PnlBottom = 5;

			// Token: 0x0403AA90 RID: 240272
			public const int TextNumLeft = 6;

			// Token: 0x0403AA91 RID: 240273
			public const int TextNumRight = 7;

			// Token: 0x0403AA92 RID: 240274
			public const int SubToggle1 = 8;

			// Token: 0x0403AA93 RID: 240275
			public const int SubToggle2 = 9;

			// Token: 0x0403AA94 RID: 240276
			public const int TextTitle = 10;

			// Token: 0x0403AA95 RID: 240277
			public const int TextDesc = 11;

			// Token: 0x0403AA96 RID: 240278
			public const int RewardLayout = 12;

			// Token: 0x0403AA97 RID: 240279
			public const int RewardLayoutItem = 13;

			// Token: 0x0403AA98 RID: 240280
			public const int PnlDone = 14;

			// Token: 0x0403AA99 RID: 240281
			public const int PnlUnDone = 15;

			// Token: 0x0403AA9A RID: 240282
			public const int BtnReceived = 16;

			// Token: 0x0403AA9B RID: 240283
			public const int FunctionTypeItem = 17;

			// Token: 0x0403AA9C RID: 240284
			public const int TexBg = 18;

			// Token: 0x0403AA9D RID: 240285
			public const int RewardRedDot = 19;
		}
	}
}
