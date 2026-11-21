using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorParkour
{
	// Token: 0x02005374 RID: 21364
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MotorParkourTaskItem : GridProxyAbstract<MotorParkourTaskData>
	{
		// Token: 0x06035283 RID: 217731 RVA: 0x00ED84D8 File Offset: 0x00ED66D8
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

		// Token: 0x06035284 RID: 217732 RVA: 0x00ED8602 File Offset: 0x00ED6802
		protected override void OnStart()
		{
			this.RewardScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(2), new Func<CommonItemSmallItemGrid>(this.CreatePropItem), null, false, null);
		}

		// Token: 0x06035285 RID: 217733 RVA: 0x00ED8628 File Offset: 0x00ED6828
		public override void Refresh(MotorParkourTaskData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			this.RewardScrollView.RefreshByData(data.RewardList, null, false);
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

		// Token: 0x06035286 RID: 217734 RVA: 0x00ED86D2 File Offset: 0x00ED68D2
		private CommonItemSmallItemGrid CreatePropItem()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x06035287 RID: 217735 RVA: 0x00ED86D9 File Offset: 0x00ED68D9
		private void OnClickGetButton()
		{
			MotorParkourController.Instance.RequestTaskReward(this.Data.LevelId);
		}

		// Token: 0x0401C0D0 RID: 114896
		[Nullable(2)]
		private MotorParkourTaskData Data;

		// Token: 0x0401C0D1 RID: 114897
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

		// Token: 0x0200AFF9 RID: 45049
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04036628 RID: 222760
			public const int TxtName = 0;

			// Token: 0x04036629 RID: 222761
			public const int ProgressText = 1;

			// Token: 0x0403662A RID: 222762
			public const int RewardScroll = 2;

			// Token: 0x0403662B RID: 222763
			public const int GetBtn = 3;

			// Token: 0x0403662C RID: 222764
			public const int DoingText = 4;

			// Token: 0x0403662D RID: 222765
			public const int PanelDone = 5;
		}
	}
}
