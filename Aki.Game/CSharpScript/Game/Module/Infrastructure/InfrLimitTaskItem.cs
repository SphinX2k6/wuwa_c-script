using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x0200590E RID: 22798
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class InfrLimitTaskItem : GridProxyAbstract<InfrastructureLimitTaskData>
	{
		// Token: 0x06039E47 RID: 237127 RVA: 0x00DC0284 File Offset: 0x00DBE484
		protected unsafe override void OnRegisterComponent()
		{
			int num = 11;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIArtText));
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
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(9, new Action(this.OnClickGoto));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(10, new Action(this.OnClickRewardGetConfirm));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06039E48 RID: 237128 RVA: 0x00DC047B File Offset: 0x00DBE67B
		protected override void OnStart()
		{
			this.RewardScroll = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(3), new Func<CommonItemSmallItemGrid>(this.CreateRewardItem), null, false, null);
		}

		// Token: 0x06039E49 RID: 237129 RVA: 0x00DC049E File Offset: 0x00DBE69E
		private CommonItemSmallItemGrid CreateRewardItem()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x06039E4A RID: 237130 RVA: 0x00DC04A8 File Offset: 0x00DBE6A8
		public override void Refresh(InfrastructureLimitTaskData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			InfrActivityTask? infrActivityTaskConfig = InfrastructureConfig.Instance.GetInfrActivityTaskConfig(this.Data.ConfigId);
			List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(this.Data.TaskReward);
			this.RewardScroll.RefreshByData(dropPackagePreviewItemList, delegate
			{
				this.RewardScroll.ScrollToLeft(0);
			}, false);
			ActivityTaskState status = data.Status;
			base.GetArtText(0).SetText(data.Index.ToString());
			base.GetText(5).SetUIActive(status == ActivityTaskState.ActivityTaskRunning);
			base.GetSprite(6).SetUIActive(status == ActivityTaskState.ActivityTaskTaken);
			base.GetSprite(7).SetUIActive(status == ActivityTaskState.ActivityTaskTaken);
			base.GetItem(8).SetUIActive(status == ActivityTaskState.ActivityTaskFinish);
			base.GetButton(9).RootUIComp.Get().SetUIActive(this.Data.JumpId != 0 && status == ActivityTaskState.ActivityTaskRunning);
			base.GetButton(10).RootUIComp.Get().SetUIActive(status == ActivityTaskState.ActivityTaskFinish);
			base.GetText(1).ShowTextNew(infrActivityTaskConfig.Value.TaskDes);
			UUIText text = base.GetText(2);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.Data.Current);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.Data.Target);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x06039E4B RID: 237131 RVA: 0x00DC0614 File Offset: 0x00DBE814
		public void SetOnClickRewardCb(Action cb)
		{
			this.OnClickRewardCb = cb;
		}

		// Token: 0x06039E4C RID: 237132 RVA: 0x00DC061D File Offset: 0x00DBE81D
		private void OnClickGoto()
		{
			if (this.Data.JumpId != 0)
			{
				SkipTaskManager.RunByConfigId(this.Data.JumpId, null);
			}
		}

		// Token: 0x06039E4D RID: 237133 RVA: 0x00DC063D File Offset: 0x00DBE83D
		private void OnClickRewardGetConfirm()
		{
			Action onClickRewardCb = this.OnClickRewardCb;
			if (onClickRewardCb == null)
			{
				return;
			}
			onClickRewardCb();
		}

		// Token: 0x0401E314 RID: 123668
		private InfrastructureLimitTaskData Data;

		// Token: 0x0401E315 RID: 123669
		public Action<int> OnClickToGet = delegate(int taskId)
		{
		};

		// Token: 0x0401E316 RID: 123670
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScroll;

		// Token: 0x0401E317 RID: 123671
		private Action OnClickRewardCb;

		// Token: 0x0200BB7C RID: 47996
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04038976 RID: 231798
			public const int ArtTextNum = 0;

			// Token: 0x04038977 RID: 231799
			public const int TextName = 1;

			// Token: 0x04038978 RID: 231800
			public const int TextProcessNum = 2;

			// Token: 0x04038979 RID: 231801
			public const int HorizontalScrollReward = 3;

			// Token: 0x0403897A RID: 231802
			public const int RewardItem = 4;

			// Token: 0x0403897B RID: 231803
			public const int TextDoing = 5;

			// Token: 0x0403897C RID: 231804
			public const int SpriteDone = 6;

			// Token: 0x0403897D RID: 231805
			public const int SpriteDoneBg = 7;

			// Token: 0x0403897E RID: 231806
			public const int PanelRedPoint = 8;

			// Token: 0x0403897F RID: 231807
			public const int BtnGoto = 9;

			// Token: 0x04038980 RID: 231808
			public const int BtnRewardGetConfirm = 10;
		}
	}
}
