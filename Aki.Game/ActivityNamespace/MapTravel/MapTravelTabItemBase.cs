using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace ActivityNamespace.MapTravel
{
	// Token: 0x02002F5F RID: 12127
	[NullableContext(1)]
	[Nullable(0)]
	public class MapTravelTabItemBase : UiPanelBase
	{
		// Token: 0x0601CB96 RID: 117654 RVA: 0x008C4521 File Offset: 0x008C2721
		public MapTravelTabItemBase(ActivityMapTravelData activityBaseData)
		{
			this.ActivityBaseData = activityBaseData;
		}

		// Token: 0x0601CB97 RID: 117655 RVA: 0x008C4530 File Offset: 0x008C2730
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleSelectOn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0601CB98 RID: 117656 RVA: 0x008C4639 File Offset: 0x008C2839
		private void OnToggleSelectOn(EToggleState _)
		{
			if (this.Data != null)
			{
				Action<MapTravelAreaData, int> selectedCallBack = this.SelectedCallBack;
				if (selectedCallBack == null)
				{
					return;
				}
				selectedCallBack(this.Data, this.Index);
			}
		}

		// Token: 0x0601CB99 RID: 117657 RVA: 0x008C4660 File Offset: 0x008C2860
		public void SetToggleState(bool bOn, bool bFireEvent)
		{
			EToggleState state = bOn ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleState(state, bFireEvent, false, false);
		}

		// Token: 0x0601CB9A RID: 117658 RVA: 0x008C4686 File Offset: 0x008C2886
		public virtual void RefreshByData(MapTravelAreaData data, int index)
		{
			this.Data = data;
			this.Index = index;
		}

		// Token: 0x0400F222 RID: 61986
		protected MapTravelAreaData Data;

		// Token: 0x0400F223 RID: 61987
		protected int Index;

		// Token: 0x0400F224 RID: 61988
		public Action<MapTravelAreaData, int> SelectedCallBack;

		// Token: 0x0400F225 RID: 61989
		protected ActivityMapTravelData ActivityBaseData;

		// Token: 0x02008BEE RID: 35822
		[NullableContext(0)]
		protected class ETabComponents
		{
			// Token: 0x0402C538 RID: 181560
			public const int Toggle = 0;

			// Token: 0x0402C539 RID: 181561
			public const int Name = 1;

			// Token: 0x0402C53A RID: 181562
			public const int SpriteDone = 2;

			// Token: 0x0402C53B RID: 181563
			public const int SpriteLock = 3;

			// Token: 0x0402C53C RID: 181564
			public const int RedDot = 4;
		}
	}
}
