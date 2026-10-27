using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Giant.View
{
	// Token: 0x02005985 RID: 22917
	[NullableContext(1)]
	[Nullable(0)]
	public class GiantNodeScaleItem : UiPanelBase, IGridProxy<IGiantNodeScaleData>
	{
		// Token: 0x17008B52 RID: 35666
		// (get) Token: 0x0603A26D RID: 238189 RVA: 0x00DD34B3 File Offset: 0x00DD16B3
		// (set) Token: 0x0603A26E RID: 238190 RVA: 0x00DD34BB File Offset: 0x00DD16BB
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		public IScrollViewDelegate<IGridProxy<IGiantNodeScaleData>, IGiantNodeScaleData> ScrollViewDelegate { [return: Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})] set; }

		// Token: 0x17008B53 RID: 35667
		// (get) Token: 0x0603A26F RID: 238191 RVA: 0x00DD34C4 File Offset: 0x00DD16C4
		// (set) Token: 0x0603A270 RID: 238192 RVA: 0x00DD34CC File Offset: 0x00DD16CC
		public int GridIndex { get; set; }

		// Token: 0x17008B54 RID: 35668
		// (get) Token: 0x0603A271 RID: 238193 RVA: 0x00DD34D5 File Offset: 0x00DD16D5
		// (set) Token: 0x0603A272 RID: 238194 RVA: 0x00DD34DD File Offset: 0x00DD16DD
		public int DisplayIndex { get; set; }

		// Token: 0x0603A273 RID: 238195 RVA: 0x00DD34E8 File Offset: 0x00DD16E8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603A274 RID: 238196 RVA: 0x00DD363C File Offset: 0x00DD183C
		protected override void OnStart()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.CanExecuteChange.Bind(() => false);
			extendToggle.OnPointUpCallBack.Bind(delegate(EToggleState state)
			{
				this.OnClick();
			});
		}

		// Token: 0x0603A275 RID: 238197 RVA: 0x00DD3698 File Offset: 0x00DD1898
		public void Refresh(IGiantNodeScaleData data, bool isSelected, int gridIndex)
		{
			this.CurrentData = data;
			EGiantNodeScaleState state = data.State;
			bool isGot = data.IsGot;
			bool uiactive = !isGot && state == EGiantNodeScaleState.Current && data.CanClaim;
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(!isGot && (state == EGiantNodeScaleState.Expired || (state == EGiantNodeScaleState.Current && !data.CanClaim)));
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 != null)
			{
				item2.SetUIActive(uiactive);
			}
			bool flag = !isGot && state == EGiantNodeScaleState.Lock;
			UUIItem item3 = base.GetItem(3);
			if (item3 != null)
			{
				item3.SetUIActive(flag);
			}
			UUIItem item4 = base.GetItem(4);
			if (item4 != null)
			{
				item4.SetUIActive(isGot);
			}
			UUISprite sprite = base.GetSprite(5);
			if (sprite != null)
			{
				sprite.SetUIActive(data.ShowCurrentMark);
			}
			string newText = data.Value.ToString();
			UUIText text = base.GetText(6);
			if (text != null)
			{
				text.SetUIActive(!flag);
			}
			UUIText text2 = base.GetText(6);
			if (text2 != null)
			{
				text2.SetText(newText, true);
			}
			UUIText text3 = base.GetText(7);
			if (text3 != null)
			{
				text3.SetUIActive(flag);
			}
			UUIText text4 = base.GetText(7);
			if (text4 != null)
			{
				text4.SetText(newText, true);
			}
			UUIItem item5 = base.GetItem(8);
			if (item5 != null)
			{
				item5.SetUIActive(data.CanClaim);
			}
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0603A276 RID: 238198 RVA: 0x00DD37F0 File Offset: 0x00DD19F0
		private void OnClick()
		{
			IGiantNodeScaleData currentData = this.CurrentData;
			if (currentData == null)
			{
				return;
			}
			currentData.OnClick(currentData.NodeIndex, currentData.CanClaim, base.GetRootItem());
		}

		// Token: 0x0603A277 RID: 238199 RVA: 0x00DD3825 File Offset: 0x00DD1A25
		public void Clear()
		{
		}

		// Token: 0x0603A278 RID: 238200 RVA: 0x00DD3827 File Offset: 0x00DD1A27
		public void OnSelected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x0603A279 RID: 238201 RVA: 0x00DD383E File Offset: 0x00DD1A3E
		public void OnDeselected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0603A27A RID: 238202 RVA: 0x00DD3855 File Offset: 0x00DD1A55
		public object GetKey(IGiantNodeScaleData data, int gridIndex)
		{
			return gridIndex;
		}

		// Token: 0x0401E578 RID: 124280
		[Nullable(2)]
		private IGiantNodeScaleData CurrentData;
	}
}
