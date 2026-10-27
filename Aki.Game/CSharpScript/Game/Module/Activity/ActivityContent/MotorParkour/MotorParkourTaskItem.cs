using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorParkour
{
	// Token: 0x020063F6 RID: 25590
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MotorParkourTaskItem : GridProxyAbstract<MotorParkourTaskData>
	{
		// Token: 0x060405C2 RID: 263618 RVA: 0x00F914F0 File Offset: 0x00F8F6F0
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

		// Token: 0x060405C3 RID: 263619 RVA: 0x00F9161A File Offset: 0x00F8F81A
		protected override void OnStart()
		{
			this.RewardScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(2), new Func<CommonItemSmallItemGrid>(this.CreatePropItem), null, false, null);
		}

		// Token: 0x060405C4 RID: 263620 RVA: 0x00F91640 File Offset: 0x00F8F840
		public override void Refresh(MotorParkourTaskData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			this.RewardScrollView.RefreshByData(data.RewardList.ToList<TItem>(), null, false);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.Desc, Array.Empty<object>());
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

		// Token: 0x060405C5 RID: 263621 RVA: 0x00F916EF File Offset: 0x00F8F8EF
		private CommonItemSmallItemGrid CreatePropItem()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x060405C6 RID: 263622 RVA: 0x00F916F6 File Offset: 0x00F8F8F6
		private void OnClickGetButton()
		{
			MotorParkourController.Instance.RequestTaskReward(this.Data.LevelId);
		}

		// Token: 0x040217A1 RID: 137121
		[Nullable(2)]
		private MotorParkourTaskData Data;

		// Token: 0x040217A2 RID: 137122
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

		// Token: 0x0200C612 RID: 50706
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403BCC9 RID: 244937
			public const int TxtName = 0;

			// Token: 0x0403BCCA RID: 244938
			public const int ProgressText = 1;

			// Token: 0x0403BCCB RID: 244939
			public const int RewardScroll = 2;

			// Token: 0x0403BCCC RID: 244940
			public const int GetBtn = 3;

			// Token: 0x0403BCCD RID: 244941
			public const int DoingText = 4;

			// Token: 0x0403BCCE RID: 244942
			public const int PanelDone = 5;
		}
	}
}
