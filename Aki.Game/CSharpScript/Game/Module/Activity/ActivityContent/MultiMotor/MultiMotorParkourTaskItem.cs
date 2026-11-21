using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MultiMotor
{
	// Token: 0x0200531A RID: 21274
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MultiMotorParkourTaskItem : GridProxyAbstract<MultiMotorTaskData>
	{
		// Token: 0x06034EE9 RID: 216809 RVA: 0x00ECDA48 File Offset: 0x00ECBC48
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

		// Token: 0x06034EEA RID: 216810 RVA: 0x00ECDB72 File Offset: 0x00ECBD72
		protected override void OnStart()
		{
			this.RewardScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(2), new Func<CommonItemSmallItemGrid>(this.CreatePropItem), null, false, null);
		}

		// Token: 0x06034EEB RID: 216811 RVA: 0x00ECDB98 File Offset: 0x00ECBD98
		public override void Refresh(MultiMotorTaskData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			this.RewardScrollView.RefreshByData(data.RewardList, null, false);
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

		// Token: 0x06034EEC RID: 216812 RVA: 0x00ECDC39 File Offset: 0x00ECBE39
		private CommonItemSmallItemGrid CreatePropItem()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x06034EED RID: 216813 RVA: 0x00ECDC40 File Offset: 0x00ECBE40
		private void OnClickGetButton()
		{
			MultiMotorController.Instance.MotorOnlineRewardRequest(this.Data.LevelId);
		}

		// Token: 0x0401BFD9 RID: 114649
		[Nullable(2)]
		private MultiMotorTaskData Data;

		// Token: 0x0401BFDA RID: 114650
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

		// Token: 0x0200AF9C RID: 44956
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04036472 RID: 222322
			public const int TxtName = 0;

			// Token: 0x04036473 RID: 222323
			public const int ProgressText = 1;

			// Token: 0x04036474 RID: 222324
			public const int RewardScroll = 2;

			// Token: 0x04036475 RID: 222325
			public const int GetBtn = 3;

			// Token: 0x04036476 RID: 222326
			public const int DoingText = 4;

			// Token: 0x04036477 RID: 222327
			public const int PanelDone = 5;
		}
	}
}
