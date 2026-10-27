using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View
{
	// Token: 0x020062CF RID: 25295
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PinballLimitedRewardTaskItem : GridProxyAbstract<PinballTaskData>
	{
		// Token: 0x0603FA77 RID: 260727 RVA: 0x00F663F8 File Offset: 0x00F645F8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnRewardBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603FA78 RID: 260728 RVA: 0x00F66586 File Offset: 0x00F64786
		protected override void OnStart()
		{
			this.RewardScroll = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(3), new Func<CommonItemSmallItemGrid>(this.CreateRewardItem), null, false, null);
		}

		// Token: 0x0603FA79 RID: 260729 RVA: 0x00F665AC File Offset: 0x00F647AC
		public override void Refresh(PinballTaskData data, bool isSelected, int gridIndex)
		{
			this.TaskData = data;
			this.RewardScroll.RefreshByData(data.RewardList, null, false);
			base.GetButton(6).RootUIComp.Get().SetUIActive(data.IsUnclaimed);
			base.GetItem(7).SetUIActive(false);
			base.GetItem(8).SetUIActive(data.IsFinished);
			base.GetText(5).SetUIActive(data.IsDoing);
			UUIText text = base.GetText(1);
			if (!string.IsNullOrEmpty(data.QuestNameTextKey))
			{
				LguiUtil.Instance.SetLocalTextNew(text, data.QuestNameTextKey, Array.Empty<object>());
			}
			else
			{
				text.SetText(data.QuestName, true);
			}
			base.GetText(2).SetUIActive(data.Target != 0);
			UUIText text2 = base.GetText(2);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(data.Current);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(data.Target);
			text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x0603FA7A RID: 260730 RVA: 0x00F666B5 File Offset: 0x00F648B5
		private CommonItemSmallItemGrid CreateRewardItem()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x0603FA7B RID: 260731 RVA: 0x00F666BC File Offset: 0x00F648BC
		private void OnRewardBtnClick()
		{
			UiAsyncTask task = new UiAsyncTask("PinballTaskItem.RequestTaskReward", delegate()
			{
				PinballLimitedRewardTaskItem.<<OnRewardBtnClick>b__7_0>d <<OnRewardBtnClick>b__7_0>d;
				<<OnRewardBtnClick>b__7_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<OnRewardBtnClick>b__7_0>d.<>4__this = this;
				<<OnRewardBtnClick>b__7_0>d.<>1__state = -1;
				<<OnRewardBtnClick>b__7_0>d.<>t__builder.Start<PinballLimitedRewardTaskItem.<<OnRewardBtnClick>b__7_0>d>(ref <<OnRewardBtnClick>b__7_0>d);
				return <<OnRewardBtnClick>b__7_0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task).Forget();
		}

		// Token: 0x0603FA7C RID: 260732 RVA: 0x00F666F0 File Offset: 0x00F648F0
		private UniTask OnRewardBtnClickAsync()
		{
			PinballLimitedRewardTaskItem.<OnRewardBtnClickAsync>d__8 <OnRewardBtnClickAsync>d__;
			<OnRewardBtnClickAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnRewardBtnClickAsync>d__.<>4__this = this;
			<OnRewardBtnClickAsync>d__.<>1__state = -1;
			<OnRewardBtnClickAsync>d__.<>t__builder.Start<PinballLimitedRewardTaskItem.<OnRewardBtnClickAsync>d__8>(ref <OnRewardBtnClickAsync>d__);
			return <OnRewardBtnClickAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0402142E RID: 136238
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScroll;

		// Token: 0x0402142F RID: 136239
		[Nullable(2)]
		private PinballTaskData TaskData;

		// Token: 0x04021430 RID: 136240
		[Nullable(2)]
		public Func<int, UniTask> OnTaskRewardClick;

		// Token: 0x0200C4B0 RID: 50352
		[NullableContext(0)]
		private enum ETaskComponents
		{
			// Token: 0x0403B597 RID: 243095
			BtnStrip,
			// Token: 0x0403B598 RID: 243096
			TxtName,
			// Token: 0x0403B599 RID: 243097
			TxtNum,
			// Token: 0x0403B59A RID: 243098
			ItemLayout,
			// Token: 0x0403B59B RID: 243099
			ItemBaseB,
			// Token: 0x0403B59C RID: 243100
			TxtDoing,
			// Token: 0x0403B59D RID: 243101
			BtnConfirmBaseA,
			// Token: 0x0403B59E RID: 243102
			RedPoint,
			// Token: 0x0403B59F RID: 243103
			PanelDone
		}
	}
}
