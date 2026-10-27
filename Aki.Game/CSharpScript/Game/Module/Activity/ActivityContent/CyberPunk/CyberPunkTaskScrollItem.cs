using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk
{
	// Token: 0x020068C1 RID: 26817
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CyberPunkTaskScrollItem : GridProxyAbstract<CyberPunkTaskData>
	{
		// Token: 0x06042ED1 RID: 274129 RVA: 0x0104BF8C File Offset: 0x0104A18C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickGotoBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06042ED2 RID: 274130 RVA: 0x0104C11C File Offset: 0x0104A31C
		protected override void OnStart()
		{
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(5);
			if (scrollViewWithScrollbar != null)
			{
				this.RewardScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(scrollViewWithScrollbar, new Func<CommonItemSmallItemGrid>(this.CreatePropItem), null, false, null);
			}
			this.RewardButton = new ButtonItem(base.GetButton(7).RootUIComp);
			this.RewardButton.SetFunction(new Action<int>(this.OnClickGetBtn));
		}

		// Token: 0x06042ED3 RID: 274131 RVA: 0x0104C184 File Offset: 0x0104A384
		public override void Refresh(CyberPunkTaskData data, bool isSelected, int gridIndex)
		{
			this.TaskData = data;
			EdgeRunnerReward? edgeRunnerRewardConfigById = CyberPunkConfig.Instance.GetEdgeRunnerRewardConfigById(data.Id);
			if (edgeRunnerRewardConfigById == null)
			{
				return;
			}
			this.SkipParam = new List<string>(edgeRunnerRewardConfigById.Value.SkipParamIter());
			this.SkipCondition = edgeRunnerRewardConfigById.Value.SkipCondition;
			this.HintText = (edgeRunnerRewardConfigById.Value.HintText ?? "");
			GenericScrollViewNew<CommonItemSmallItemGrid, TItem> rewardScrollView = this.RewardScrollView;
			if (rewardScrollView != null)
			{
				rewardScrollView.RefreshByData(data.RewardList, null, false);
			}
			this.RefreshText(data);
			this.RefreshState(data.Status, edgeRunnerRewardConfigById.Value.SkipType);
		}

		// Token: 0x06042ED4 RID: 274132 RVA: 0x0104C23B File Offset: 0x0104A43B
		public override object GetKey(CyberPunkTaskData data, int displayIndex)
		{
			return data.Id;
		}

		// Token: 0x06042ED5 RID: 274133 RVA: 0x0104C248 File Offset: 0x0104A448
		public void ResetScroll()
		{
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(5);
			if (scrollViewWithScrollbar == null)
			{
				return;
			}
			scrollViewWithScrollbar.SetScrollProgress(1f);
		}

		// Token: 0x06042ED6 RID: 274134 RVA: 0x0104C260 File Offset: 0x0104A460
		private void RefreshText(CyberPunkTaskData data)
		{
			UUIText text = base.GetText(4);
			if (text != null)
			{
				text.SetText(ConfigMultiTextLang.GetLocalTextNew(data.QuestName, null) ?? "", true);
			}
			string progressText = data.GetProgressText();
			UUIText text2 = base.GetText(8);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(this.GetProgressRichText(progressText), true);
		}

		// Token: 0x06042ED7 RID: 274135 RVA: 0x0104C2B8 File Offset: 0x0104A4B8
		private string GetProgressRichText(string progressText)
		{
			string[] array = progressText.Split('/', StringSplitOptions.None);
			if (array.Length != 2)
			{
				return progressText;
			}
			string text = array[0];
			string text2 = array[1];
			int num = int.Parse(text);
			int num2 = int.Parse(text2);
			string value = (num == num2) ? EProgressTextColorHelper.ToColorString(EProgressTextColor.InProgress) : EProgressTextColorHelper.ToColorString(EProgressTextColor.Zero);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 3);
			defaultInterpolatedStringHandler.AppendLiteral("<color=#");
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral(">");
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral("</color>/");
			defaultInterpolatedStringHandler.AppendFormatted(text2);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06042ED8 RID: 274136 RVA: 0x0104C350 File Offset: 0x0104A550
		private void RefreshState(ConditionTaskState taskStatus, int skipType)
		{
			bool flag = taskStatus == ConditionTaskState.ConditionTaskFinish;
			bool uiactive = taskStatus == ConditionTaskState.ConditionTaskTaken;
			bool flag2 = taskStatus == ConditionTaskState.ConditionTaskRunning;
			bool flag3 = skipType > 0;
			bool flag4 = this.SkipParam.Count > 0;
			UUISprite sprite = base.GetSprite(2);
			if (sprite != null)
			{
				sprite.SetUIActive(uiactive);
			}
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(uiactive);
			}
			UUIButtonComponent button = base.GetButton(0);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(flag2 && flag3 && flag4);
			}
			UUIText text = base.GetText(1);
			if (text != null)
			{
				text.SetUIActive(flag2 && (!flag3 || !flag4));
			}
			UUIButtonComponent button2 = base.GetButton(7);
			TWeakObjectPtr<UUIItem>? tweakObjectPtr = (button2 != null) ? new TWeakObjectPtr<UUIItem>?(button2.RootUIComp) : null;
			if (tweakObjectPtr != null)
			{
				tweakObjectPtr.GetValueOrDefault().Get().SetUIActive(flag);
			}
			ButtonItem rewardButton = this.RewardButton;
			if (rewardButton != null)
			{
				rewardButton.SetEnableClick(flag);
			}
			ButtonItem rewardButton2 = this.RewardButton;
			if (rewardButton2 != null)
			{
				rewardButton2.SetRedDotVisible(false);
			}
			UUIItem item2 = base.GetItem(6);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(flag);
		}

		// Token: 0x06042ED9 RID: 274137 RVA: 0x0104C468 File Offset: 0x0104A668
		private CommonItemSmallItemGrid CreatePropItem()
		{
			return new CommonItemSmallItemGrid
			{
				ShowReceivedCallBack = delegate(TItem _)
				{
					CyberPunkTaskData taskData = this.TaskData;
					return taskData != null && taskData.Status == ConditionTaskState.ConditionTaskTaken;
				}
			};
		}

		// Token: 0x06042EDA RID: 274138 RVA: 0x0104C484 File Offset: 0x0104A684
		private void OnClickGetBtn(int _)
		{
			CyberPunkData currentActivityData = CyberPunkController.Instance.GetCurrentActivityData();
			if (currentActivityData == null)
			{
				return;
			}
			List<int> claimableTaskIds = currentActivityData.GetClaimableTaskIds();
			if (claimableTaskIds.Count == 0)
			{
				return;
			}
			CyberPunkController.Instance.RequestTaskReward(claimableTaskIds.ToArray(), null);
		}

		// Token: 0x06042EDB RID: 274139 RVA: 0x0104C4C4 File Offset: 0x0104A6C4
		private void OnClickGotoBtn()
		{
			if (this.SkipCondition > 0)
			{
				CyberPunkData currentActivityData = CyberPunkController.Instance.GetCurrentActivityData();
				if (currentActivityData == null || !currentActivityData.IsFunctionUnlocked(this.SkipCondition))
				{
					if (!string.IsNullOrEmpty(this.HintText))
					{
						ScrollingTipsController.Instance.ShowTipsByTextId(this.HintText, Array.Empty<object>());
					}
					return;
				}
			}
			if (this.SkipParam.Count == 0)
			{
				return;
			}
			int num;
			if (!int.TryParse(this.SkipParam[0], out num) || num <= 0)
			{
				return;
			}
			SkipInterfaceConfig instance = SkipInterfaceConfig.Instance;
			AccessPath? accessPath = (instance != null) ? instance.GetAccessPathConfig(num) : null;
			if (accessPath == null)
			{
				return;
			}
			SkipTaskManager.RunByConfigId(accessPath.Value.Id, accessPath.Value.Val1);
		}

		// Token: 0x04022D10 RID: 142608
		[Nullable(2)]
		private CyberPunkTaskData TaskData;

		// Token: 0x04022D11 RID: 142609
		private List<string> SkipParam = new List<string>();

		// Token: 0x04022D12 RID: 142610
		private int SkipCondition;

		// Token: 0x04022D13 RID: 142611
		private string HintText = "";

		// Token: 0x04022D14 RID: 142612
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

		// Token: 0x04022D15 RID: 142613
		[Nullable(2)]
		private ButtonItem RewardButton;

		// Token: 0x0200CA9A RID: 51866
		[NullableContext(0)]
		private static class EComponentDefine
		{
			// Token: 0x0403D3CB RID: 250827
			public const int GotoBTn = 0;

			// Token: 0x0403D3CC RID: 250828
			public const int TxtDoing = 1;

			// Token: 0x0403D3CD RID: 250829
			public const int FinishState = 2;

			// Token: 0x0403D3CE RID: 250830
			public const int FinishItemState = 3;

			// Token: 0x0403D3CF RID: 250831
			public const int TxtName = 4;

			// Token: 0x0403D3D0 RID: 250832
			public const int SvItem = 5;

			// Token: 0x0403D3D1 RID: 250833
			public const int RedPoint = 6;

			// Token: 0x0403D3D2 RID: 250834
			public const int GetBtn = 7;

			// Token: 0x0403D3D3 RID: 250835
			public const int TxtNum = 8;
		}
	}
}
