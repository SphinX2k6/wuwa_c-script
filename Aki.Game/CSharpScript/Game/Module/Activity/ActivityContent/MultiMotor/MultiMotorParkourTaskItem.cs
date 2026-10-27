using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MultiMotor
{
	// Token: 0x0200639C RID: 25500
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MultiMotorParkourTaskItem : GridProxyAbstract<MultiMotorTaskData>
	{
		// Token: 0x06040228 RID: 262696 RVA: 0x00F86B0C File Offset: 0x00F84D0C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickGetButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06040229 RID: 262697 RVA: 0x00F86C36 File Offset: 0x00F84E36
		protected override void OnStart()
		{
			this.RewardScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(2), new Func<CommonItemSmallItemGrid>(this.CreatePropItem), null, false, null);
		}

		// Token: 0x0604022A RID: 262698 RVA: 0x00F86C5C File Offset: 0x00F84E5C
		public override void Refresh(MultiMotorTaskData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			this.RewardScrollView.RefreshByData(data.RewardList.ToList<TItem>(), null, false);
			base.GetText(0).SetText(data.DescString, true);
			UUIText text = base.GetText(1);
			if (text != null)
			{
				text.SetUIActive(false);
			}
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(data.IsReceived);
			}
			UUIButtonComponent button = base.GetButton(3);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(data.IsFinished);
			}
			UUIText text2 = base.GetText(4);
			if (text2 == null)
			{
				return;
			}
			text2.SetUIActive(data.IsRunning);
		}

		// Token: 0x0604022B RID: 262699 RVA: 0x00F86D02 File Offset: 0x00F84F02
		private CommonItemSmallItemGrid CreatePropItem()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x0604022C RID: 262700 RVA: 0x00F86D09 File Offset: 0x00F84F09
		private void OnClickGetButton()
		{
			MultiMotorController.Instance.MotorOnlineRewardRequest(this.Data.LevelId);
		}

		// Token: 0x040216AA RID: 136874
		[Nullable(2)]
		private MultiMotorTaskData Data;

		// Token: 0x040216AB RID: 136875
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

		// Token: 0x0200C5B5 RID: 50613
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403BB13 RID: 244499
			public const int TxtName = 0;

			// Token: 0x0403BB14 RID: 244500
			public const int ProgressText = 1;

			// Token: 0x0403BB15 RID: 244501
			public const int RewardScroll = 2;

			// Token: 0x0403BB16 RID: 244502
			public const int GetBtn = 3;

			// Token: 0x0403BB17 RID: 244503
			public const int DoingText = 4;

			// Token: 0x0403BB18 RID: 244504
			public const int PanelDone = 5;
		}
	}
}
