using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.FeedbackReward
{
	// Token: 0x02005A8A RID: 23178
	internal class TaskItem : GridProxyAbstract<int>
	{
		// Token: 0x0603AB47 RID: 240455 RVA: 0x00DFBCF0 File Offset: 0x00DF9EF0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickHelpBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603AB48 RID: 240456 RVA: 0x00DFBE3C File Offset: 0x00DFA03C
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			GivebackTask? givebackTaskById = FeedbackRewardConfig.Instance.GetGivebackTaskById(data);
			if (givebackTaskById == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), givebackTaskById.Value.TaskName, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), givebackTaskById.Value.TaskDes, Array.Empty<object>());
			int feedbackTaskCurrentPoint = FeedbackRewardModel.Instance.GetFeedbackTaskCurrentPoint(data);
			base.GetText(4).SetText(feedbackTaskCurrentPoint.ToString(), true);
			base.GetText(5).SetText("/" + givebackTaskById.Value.MaxScore.ToString(), true);
			base.GetSprite(3).SetFillAmount((float)feedbackTaskCurrentPoint / (float)givebackTaskById.Value.MaxScore);
			base.GetItem(6).SetUIActive(feedbackTaskCurrentPoint >= givebackTaskById.Value.MaxScore);
			this.HelpId = givebackTaskById.Value.HelpBtn;
			base.GetButton(0).RootUIComp.Get().SetUIActive(this.HelpId > 0);
		}

		// Token: 0x0603AB49 RID: 240457 RVA: 0x00DFBF6F File Offset: 0x00DFA16F
		private void OnClickHelpBtn()
		{
			if (this.HelpId == 0)
			{
				return;
			}
			HelpController.Instance.OpenHelpById(this.HelpId);
		}

		// Token: 0x0401EA45 RID: 125509
		private int HelpId;

		// Token: 0x0200BCC2 RID: 48322
		private enum ETaskItem
		{
			// Token: 0x04038F17 RID: 233239
			HelpBtn,
			// Token: 0x04038F18 RID: 233240
			TitleText,
			// Token: 0x04038F19 RID: 233241
			DesText,
			// Token: 0x04038F1A RID: 233242
			BarSprite,
			// Token: 0x04038F1B RID: 233243
			CurrentCountText,
			// Token: 0x04038F1C RID: 233244
			TargetText,
			// Token: 0x04038F1D RID: 233245
			FinishItem
		}
	}
}
