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
	// Token: 0x0200524D RID: 21069
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PinballLimitedRewardTaskItem : GridProxyAbstract<PinballTaskData>
	{
		// Token: 0x06034738 RID: 214840 RVA: 0x00EAD354 File Offset: 0x00EAB554
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

		// Token: 0x06034739 RID: 214841 RVA: 0x00EAD4E2 File Offset: 0x00EAB6E2
		protected override void OnStart()
		{
			this.RewardScroll = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(3), new Func<CommonItemSmallItemGrid>(this.CreateRewardItem), null, false, null);
		}

		// Token: 0x0603473A RID: 214842 RVA: 0x00EAD508 File Offset: 0x00EAB708
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

		// Token: 0x0603473B RID: 214843 RVA: 0x00EAD611 File Offset: 0x00EAB811
		private CommonItemSmallItemGrid CreateRewardItem()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x0603473C RID: 214844 RVA: 0x00EAD618 File Offset: 0x00EAB818
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

		// Token: 0x0603473D RID: 214845 RVA: 0x00EAD64C File Offset: 0x00EAB84C
		private UniTask OnRewardBtnClickAsync()
		{
			PinballLimitedRewardTaskItem.<OnRewardBtnClickAsync>d__8 <OnRewardBtnClickAsync>d__;
			<OnRewardBtnClickAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnRewardBtnClickAsync>d__.<>4__this = this;
			<OnRewardBtnClickAsync>d__.<>1__state = -1;
			<OnRewardBtnClickAsync>d__.<>t__builder.Start<PinballLimitedRewardTaskItem.<OnRewardBtnClickAsync>d__8>(ref <OnRewardBtnClickAsync>d__);
			return <OnRewardBtnClickAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0401BD5D RID: 114013
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScroll;

		// Token: 0x0401BD5E RID: 114014
		[Nullable(2)]
		private PinballTaskData TaskData;

		// Token: 0x0401BD5F RID: 114015
		[Nullable(2)]
		public Func<int, UniTask> OnTaskRewardClick;

		// Token: 0x0200AE97 RID: 44695
		[NullableContext(0)]
		private enum ETaskComponents
		{
			// Token: 0x04035EF9 RID: 220921
			BtnStrip,
			// Token: 0x04035EFA RID: 220922
			TxtName,
			// Token: 0x04035EFB RID: 220923
			TxtNum,
			// Token: 0x04035EFC RID: 220924
			ItemLayout,
			// Token: 0x04035EFD RID: 220925
			ItemBaseB,
			// Token: 0x04035EFE RID: 220926
			TxtDoing,
			// Token: 0x04035EFF RID: 220927
			BtnConfirmBaseA,
			// Token: 0x04035F00 RID: 220928
			RedPoint,
			// Token: 0x04035F01 RID: 220929
			PanelDone
		}
	}
}
