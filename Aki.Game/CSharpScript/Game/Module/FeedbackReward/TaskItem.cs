using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.FeedbackReward
{
	// Token: 0x02004A66 RID: 19046
	internal class TaskItem : GridProxyAbstract<int>
	{
		// Token: 0x0602FA90 RID: 195216 RVA: 0x00D4C284 File Offset: 0x00D4A484
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

		// Token: 0x0602FA91 RID: 195217 RVA: 0x00D4C3D0 File Offset: 0x00D4A5D0
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

		// Token: 0x0602FA92 RID: 195218 RVA: 0x00D4C503 File Offset: 0x00D4A703
		private void OnClickHelpBtn()
		{
			if (this.HelpId == 0)
			{
				return;
			}
			HelpController.Instance.OpenHelpById(this.HelpId);
		}

		// Token: 0x040194EC RID: 103660
		private int HelpId;

		// Token: 0x0200A6CB RID: 42699
		private enum ETaskItem
		{
			// Token: 0x040338E2 RID: 211170
			HelpBtn,
			// Token: 0x040338E3 RID: 211171
			TitleText,
			// Token: 0x040338E4 RID: 211172
			DesText,
			// Token: 0x040338E5 RID: 211173
			BarSprite,
			// Token: 0x040338E6 RID: 211174
			CurrentCountText,
			// Token: 0x040338E7 RID: 211175
			TargetText,
			// Token: 0x040338E8 RID: 211176
			FinishItem
		}
	}
}
