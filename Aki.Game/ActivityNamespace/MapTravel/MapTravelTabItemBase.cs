using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace ActivityNamespace.MapTravel
{
	// Token: 0x020044D2 RID: 17618
	[NullableContext(1)]
	[Nullable(0)]
	public class MapTravelTabItemBase : UiPanelBase
	{
		// Token: 0x0602D658 RID: 185944 RVA: 0x00A3E8C1 File Offset: 0x00A3CAC1
		public MapTravelTabItemBase(ActivityMapTravelData activityBaseData)
		{
			this.ActivityBaseData = activityBaseData;
		}

		// Token: 0x0602D659 RID: 185945 RVA: 0x00A3E8D0 File Offset: 0x00A3CAD0
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

		// Token: 0x0602D65A RID: 185946 RVA: 0x00A3E9D9 File Offset: 0x00A3CBD9
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

		// Token: 0x0602D65B RID: 185947 RVA: 0x00A3EA00 File Offset: 0x00A3CC00
		public void SetToggleState(bool bOn, bool bFireEvent)
		{
			EToggleState state = bOn ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleState(state, bFireEvent, false, false);
		}

		// Token: 0x0602D65C RID: 185948 RVA: 0x00A3EA26 File Offset: 0x00A3CC26
		public virtual void RefreshByData(MapTravelAreaData data, int index)
		{
			this.Data = data;
			this.Index = index;
		}

		// Token: 0x0401847A RID: 99450
		protected MapTravelAreaData Data;

		// Token: 0x0401847B RID: 99451
		protected int Index;

		// Token: 0x0401847C RID: 99452
		public Action<MapTravelAreaData, int> SelectedCallBack;

		// Token: 0x0401847D RID: 99453
		protected ActivityMapTravelData ActivityBaseData;

		// Token: 0x0200A718 RID: 42776
		[NullableContext(0)]
		protected class ETabComponents
		{
			// Token: 0x0403276A RID: 206698
			public const int Toggle = 0;

			// Token: 0x0403276B RID: 206699
			public const int Name = 1;

			// Token: 0x0403276C RID: 206700
			public const int SpriteDone = 2;

			// Token: 0x0403276D RID: 206701
			public const int SpriteLock = 3;

			// Token: 0x0403276E RID: 206702
			public const int RedDot = 4;
		}
	}
}
