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
	// Token: 0x02005811 RID: 22545
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CyberPunkTaskScrollItem : GridProxyAbstract<CyberPunkTaskData>
	{
		// Token: 0x06037A29 RID: 227881 RVA: 0x00F8D5B4 File Offset: 0x00F8B7B4
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

		// Token: 0x06037A2A RID: 227882 RVA: 0x00F8D744 File Offset: 0x00F8B944
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

		// Token: 0x06037A2B RID: 227883 RVA: 0x00F8D7AC File Offset: 0x00F8B9AC
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

		// Token: 0x06037A2C RID: 227884 RVA: 0x00F8D863 File Offset: 0x00F8BA63
		public override object GetKey(CyberPunkTaskData data, int displayIndex)
		{
			return data.Id;
		}

		// Token: 0x06037A2D RID: 227885 RVA: 0x00F8D870 File Offset: 0x00F8BA70
		public void ResetScroll()
		{
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(5);
			if (scrollViewWithScrollbar == null)
			{
				return;
			}
			scrollViewWithScrollbar.SetScrollProgress(1f);
		}

		// Token: 0x06037A2E RID: 227886 RVA: 0x00F8D888 File Offset: 0x00F8BA88
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

		// Token: 0x06037A2F RID: 227887 RVA: 0x00F8D8E0 File Offset: 0x00F8BAE0
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

		// Token: 0x06037A30 RID: 227888 RVA: 0x00F8D978 File Offset: 0x00F8BB78
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

		// Token: 0x06037A31 RID: 227889 RVA: 0x00F8DA90 File Offset: 0x00F8BC90
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

		// Token: 0x06037A32 RID: 227890 RVA: 0x00F8DAAC File Offset: 0x00F8BCAC
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

		// Token: 0x06037A33 RID: 227891 RVA: 0x00F8DAEC File Offset: 0x00F8BCEC
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

		// Token: 0x0401D56C RID: 120172
		[Nullable(2)]
		private CyberPunkTaskData TaskData;

		// Token: 0x0401D56D RID: 120173
		private List<string> SkipParam = new List<string>();

		// Token: 0x0401D56E RID: 120174
		private int SkipCondition;

		// Token: 0x0401D56F RID: 120175
		private string HintText = "";

		// Token: 0x0401D570 RID: 120176
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

		// Token: 0x0401D571 RID: 120177
		[Nullable(2)]
		private ButtonItem RewardButton;

		// Token: 0x0200B462 RID: 46178
		[NullableContext(0)]
		private static class EComponentDefine
		{
			// Token: 0x04037CA5 RID: 228517
			public const int GotoBTn = 0;

			// Token: 0x04037CA6 RID: 228518
			public const int TxtDoing = 1;

			// Token: 0x04037CA7 RID: 228519
			public const int FinishState = 2;

			// Token: 0x04037CA8 RID: 228520
			public const int FinishItemState = 3;

			// Token: 0x04037CA9 RID: 228521
			public const int TxtName = 4;

			// Token: 0x04037CAA RID: 228522
			public const int SvItem = 5;

			// Token: 0x04037CAB RID: 228523
			public const int RedPoint = 6;

			// Token: 0x04037CAC RID: 228524
			public const int GetBtn = 7;

			// Token: 0x04037CAD RID: 228525
			public const int TxtNum = 8;
		}
	}
}
