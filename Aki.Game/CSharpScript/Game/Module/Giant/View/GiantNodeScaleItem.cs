using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Giant.View
{
	// Token: 0x0200495E RID: 18782
	[NullableContext(1)]
	[Nullable(0)]
	public class GiantNodeScaleItem : UiPanelBase, IGridProxy<IGiantNodeScaleData>
	{
		// Token: 0x17005F1F RID: 24351
		// (get) Token: 0x0602F193 RID: 192915 RVA: 0x00D22943 File Offset: 0x00D20B43
		// (set) Token: 0x0602F194 RID: 192916 RVA: 0x00D2294B File Offset: 0x00D20B4B
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

		// Token: 0x17005F20 RID: 24352
		// (get) Token: 0x0602F195 RID: 192917 RVA: 0x00D22954 File Offset: 0x00D20B54
		// (set) Token: 0x0602F196 RID: 192918 RVA: 0x00D2295C File Offset: 0x00D20B5C
		public int GridIndex { get; set; }

		// Token: 0x17005F21 RID: 24353
		// (get) Token: 0x0602F197 RID: 192919 RVA: 0x00D22965 File Offset: 0x00D20B65
		// (set) Token: 0x0602F198 RID: 192920 RVA: 0x00D2296D File Offset: 0x00D20B6D
		public int DisplayIndex { get; set; }

		// Token: 0x0602F199 RID: 192921 RVA: 0x00D22978 File Offset: 0x00D20B78
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

		// Token: 0x0602F19A RID: 192922 RVA: 0x00D22ACC File Offset: 0x00D20CCC
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

		// Token: 0x0602F19B RID: 192923 RVA: 0x00D22B28 File Offset: 0x00D20D28
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

		// Token: 0x0602F19C RID: 192924 RVA: 0x00D22C80 File Offset: 0x00D20E80
		private void OnClick()
		{
			IGiantNodeScaleData currentData = this.CurrentData;
			if (currentData == null)
			{
				return;
			}
			currentData.OnClick(currentData.NodeIndex, currentData.CanClaim, base.GetRootItem());
		}

		// Token: 0x0602F19D RID: 192925 RVA: 0x00D22CB5 File Offset: 0x00D20EB5
		public void Clear()
		{
		}

		// Token: 0x0602F19E RID: 192926 RVA: 0x00D22CB7 File Offset: 0x00D20EB7
		public void OnSelected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x0602F19F RID: 192927 RVA: 0x00D22CCE File Offset: 0x00D20ECE
		public void OnDeselected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0602F1A0 RID: 192928 RVA: 0x00D22CE5 File Offset: 0x00D20EE5
		public object GetKey(IGiantNodeScaleData data, int gridIndex)
		{
			return gridIndex;
		}

		// Token: 0x04019016 RID: 102422
		[Nullable(2)]
		private IGiantNodeScaleData CurrentData;
	}
}
