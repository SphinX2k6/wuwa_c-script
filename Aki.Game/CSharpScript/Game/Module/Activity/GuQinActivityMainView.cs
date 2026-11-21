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
	// Token: 0x02004EDF RID: 20191
	[NullableContext(1)]
	[Nullable(0)]
	public class GuQinActivityMainView : UiViewBase
	{
		// Token: 0x06032BF2 RID: 207858 RVA: 0x00E40356 File Offset: 0x00E3E556
		public GuQinActivityMainView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06032BF3 RID: 207859 RVA: 0x00E40378 File Offset: 0x00E3E578
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

		// Token: 0x06032BF4 RID: 207860 RVA: 0x00E40680 File Offset: 0x00E3E880
		protected override UniTask OnBeforeStartAsync()
		{
			GuQinActivityMainView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<GuQinActivityMainView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032BF5 RID: 207861 RVA: 0x00E406C4 File Offset: 0x00E3E8C4
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

		// Token: 0x06032BF6 RID: 207862 RVA: 0x00E40794 File Offset: 0x00E3E994
		private CommonItemSmallItemGrid InitGridItem()
		{
			return new CommonItemSmallItemGrid
			{
				ShowReceivedCallBack = ((TItem _) => this.CurrentTaskData.Rewarded)
			};
		}

		// Token: 0x06032BF7 RID: 207863 RVA: 0x00E407AD File Offset: 0x00E3E9AD
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.ActivityViewRefreshCurrent, new Action<int>(this.OnActivityRefresh));
		}

		// Token: 0x06032BF8 RID: 207864 RVA: 0x00E407CB File Offset: 0x00E3E9CB
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.ActivityViewRefreshCurrent, new Action<int>(this.OnActivityRefresh));
		}

		// Token: 0x06032BF9 RID: 207865 RVA: 0x00E407EC File Offset: 0x00E3E9EC
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

		// Token: 0x06032BFA RID: 207866 RVA: 0x00E40880 File Offset: 0x00E3EA80
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x06032BFB RID: 207867 RVA: 0x00E40889 File Offset: 0x00E3EA89
		private void OnHelpBtnClick()
		{
			HelpController.Instance.OpenHelpById(655);
		}

		// Token: 0x06032BFC RID: 207868 RVA: 0x00E4089C File Offset: 0x00E3EA9C
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

		// Token: 0x06032BFD RID: 207869 RVA: 0x00E408D8 File Offset: 0x00E3EAD8
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

		// Token: 0x06032BFE RID: 207870 RVA: 0x00E40980 File Offset: 0x00E3EB80
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

		// Token: 0x06032BFF RID: 207871 RVA: 0x00E40A30 File Offset: 0x00E3EC30
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

		// Token: 0x06032C00 RID: 207872 RVA: 0x00E40A84 File Offset: 0x00E3EC84
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

		// Token: 0x06032C01 RID: 207873 RVA: 0x00E40C6C File Offset: 0x00E3EE6C
		private void OnReceivedBtnClick()
		{
			GuQinActivityController.Instance.RequestReward(this.CurrentTaskData, new Action(this.OnRewardSuccess));
		}

		// Token: 0x06032C02 RID: 207874 RVA: 0x00E40C8A File Offset: 0x00E3EE8A
		private void OnRewardSuccess()
		{
			this.RefreshUi();
			this.RefreshRedDot();
		}

		// Token: 0x06032C03 RID: 207875 RVA: 0x00E40C98 File Offset: 0x00E3EE98
		private void OnGotoBtnClick()
		{
			int questId = this.CurrentTaskData.GetConfig().QuestId;
			this.Data.RemoveNewQuestRedDot(this.CurrentTaskData.Id);
			this.RefreshRedDot();
			UiManager.Instance.OpenView(EUiViewName.QuestView, questId, null);
		}

		// Token: 0x06032C04 RID: 207876 RVA: 0x00E40CEC File Offset: 0x00E3EEEC
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

		// Token: 0x0401AF3C RID: 110396
		private const int ToggleCount = 4;

		// Token: 0x0401AF3D RID: 110397
		private const int SubToggleCount = 2;

		// Token: 0x0401AF3E RID: 110398
		private GuQinActivityData Data;

		// Token: 0x0401AF3F RID: 110399
		[Nullable(2)]
		private GuQinActivityMainViewToggleItem CurrentSelectToggleItem;

		// Token: 0x0401AF40 RID: 110400
		[Nullable(2)]
		private GuQinActivityMainViewSubToggleItem CurrentSelectSubToggleItem;

		// Token: 0x0401AF41 RID: 110401
		private GuQinActivityTaskData CurrentTaskData;

		// Token: 0x0401AF42 RID: 110402
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401AF43 RID: 110403
		[Nullable(2)]
		private ActivityFunctionalTypeA FunctionalComponent;

		// Token: 0x0401AF44 RID: 110404
		private readonly List<GuQinActivityMainViewToggleItem> ToggleItems = new List<GuQinActivityMainViewToggleItem>();

		// Token: 0x0401AF45 RID: 110405
		private readonly List<GuQinActivityMainViewSubToggleItem> SubToggleItems = new List<GuQinActivityMainViewSubToggleItem>();

		// Token: 0x0401AF46 RID: 110406
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<CommonItemSmallItemGrid, TItem> RewardLayout;

		// Token: 0x0200AC37 RID: 44087
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403547E RID: 218238
			public const int CaptionItem = 0;

			// Token: 0x0403547F RID: 218239
			public const int Toggle1 = 1;

			// Token: 0x04035480 RID: 218240
			public const int Toggle2 = 2;

			// Token: 0x04035481 RID: 218241
			public const int Toggle3 = 3;

			// Token: 0x04035482 RID: 218242
			public const int Toggle4 = 4;

			// Token: 0x04035483 RID: 218243
			public const int PnlBottom = 5;

			// Token: 0x04035484 RID: 218244
			public const int TextNumLeft = 6;

			// Token: 0x04035485 RID: 218245
			public const int TextNumRight = 7;

			// Token: 0x04035486 RID: 218246
			public const int SubToggle1 = 8;

			// Token: 0x04035487 RID: 218247
			public const int SubToggle2 = 9;

			// Token: 0x04035488 RID: 218248
			public const int TextTitle = 10;

			// Token: 0x04035489 RID: 218249
			public const int TextDesc = 11;

			// Token: 0x0403548A RID: 218250
			public const int RewardLayout = 12;

			// Token: 0x0403548B RID: 218251
			public const int RewardLayoutItem = 13;

			// Token: 0x0403548C RID: 218252
			public const int PnlDone = 14;

			// Token: 0x0403548D RID: 218253
			public const int PnlUnDone = 15;

			// Token: 0x0403548E RID: 218254
			public const int BtnReceived = 16;

			// Token: 0x0403548F RID: 218255
			public const int FunctionTypeItem = 17;

			// Token: 0x04035490 RID: 218256
			public const int TexBg = 18;

			// Token: 0x04035491 RID: 218257
			public const int RewardRedDot = 19;
		}
	}
}
