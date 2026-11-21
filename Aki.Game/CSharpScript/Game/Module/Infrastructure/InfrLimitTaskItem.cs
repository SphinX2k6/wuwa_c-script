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
	// Token: 0x020048E7 RID: 18663
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class InfrLimitTaskItem : GridProxyAbstract<InfrastructureLimitTaskData>
	{
		// Token: 0x0602ED6A RID: 191850 RVA: 0x00D0F57C File Offset: 0x00D0D77C
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

		// Token: 0x0602ED6B RID: 191851 RVA: 0x00D0F773 File Offset: 0x00D0D973
		protected override void OnStart()
		{
			this.RewardScroll = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(3), new Func<CommonItemSmallItemGrid>(this.CreateRewardItem), null, false, null);
		}

		// Token: 0x0602ED6C RID: 191852 RVA: 0x00D0F796 File Offset: 0x00D0D996
		private CommonItemSmallItemGrid CreateRewardItem()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x0602ED6D RID: 191853 RVA: 0x00D0F7A0 File Offset: 0x00D0D9A0
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

		// Token: 0x0602ED6E RID: 191854 RVA: 0x00D0F90C File Offset: 0x00D0DB0C
		public void SetOnClickRewardCb(Action cb)
		{
			this.OnClickRewardCb = cb;
		}

		// Token: 0x0602ED6F RID: 191855 RVA: 0x00D0F915 File Offset: 0x00D0DB15
		private void OnClickGoto()
		{
			if (this.Data.JumpId != 0)
			{
				SkipTaskManager.RunByConfigId(this.Data.JumpId, null);
			}
		}

		// Token: 0x0602ED70 RID: 191856 RVA: 0x00D0F935 File Offset: 0x00D0DB35
		private void OnClickRewardGetConfirm()
		{
			Action onClickRewardCb = this.OnClickRewardCb;
			if (onClickRewardCb == null)
			{
				return;
			}
			onClickRewardCb();
		}

		// Token: 0x04018DB1 RID: 101809
		private InfrastructureLimitTaskData Data;

		// Token: 0x04018DB2 RID: 101810
		public Action<int> OnClickToGet = delegate(int taskId)
		{
		};

		// Token: 0x04018DB3 RID: 101811
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScroll;

		// Token: 0x04018DB4 RID: 101812
		private Action OnClickRewardCb;

		// Token: 0x0200A58C RID: 42380
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403335E RID: 209758
			public const int ArtTextNum = 0;

			// Token: 0x0403335F RID: 209759
			public const int TextName = 1;

			// Token: 0x04033360 RID: 209760
			public const int TextProcessNum = 2;

			// Token: 0x04033361 RID: 209761
			public const int HorizontalScrollReward = 3;

			// Token: 0x04033362 RID: 209762
			public const int RewardItem = 4;

			// Token: 0x04033363 RID: 209763
			public const int TextDoing = 5;

			// Token: 0x04033364 RID: 209764
			public const int SpriteDone = 6;

			// Token: 0x04033365 RID: 209765
			public const int SpriteDoneBg = 7;

			// Token: 0x04033366 RID: 209766
			public const int PanelRedPoint = 8;

			// Token: 0x04033367 RID: 209767
			public const int BtnGoto = 9;

			// Token: 0x04033368 RID: 209768
			public const int BtnRewardGetConfirm = 10;
		}
	}
}
