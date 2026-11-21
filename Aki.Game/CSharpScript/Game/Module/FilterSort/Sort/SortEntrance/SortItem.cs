using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.FilterSort.Sort.SortEntrance
{
	// Token: 0x02004B15 RID: 19221
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class SortItem : GridProxyAbstract<ISortData>
	{
		// Token: 0x06030140 RID: 196928 RVA: 0x00D69670 File Offset: 0x00D67870
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.ToggleEvent));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06030141 RID: 196929 RVA: 0x00D69716 File Offset: 0x00D67916
		private void ToggleEvent(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				TSortItemToggleEvent toggleFunction = this.ToggleFunction;
				if (toggleFunction == null)
				{
					return;
				}
				toggleFunction(this.SortData.RuleId, this.Name);
			}
		}

		// Token: 0x06030142 RID: 196930 RVA: 0x00D6973D File Offset: 0x00D6793D
		protected override void OnStart()
		{
			base.GetExtendToggle(1).CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
		}

		// Token: 0x06030143 RID: 196931 RVA: 0x00D6975C File Offset: 0x00D6795C
		private bool CanExecuteChange()
		{
			return this.CanExecuteChangeInternal == null || this.CanExecuteChangeInternal(this.SortData.RuleId);
		}

		// Token: 0x06030144 RID: 196932 RVA: 0x00D6977E File Offset: 0x00D6797E
		private void SetName()
		{
			this.Name = SortConfig.Instance.GetSortRuleName(this.SortData.RuleId, this.SortData.DataType);
			base.GetText(0).SetText(this.Name, true);
		}

		// Token: 0x06030145 RID: 196933 RVA: 0x00D697BC File Offset: 0x00D679BC
		private void SetDefaultToggleState(bool bSelected)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			EToggleState state = bSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			extendToggle.SetToggleStateForce(state, false, false, false);
		}

		// Token: 0x06030146 RID: 196934 RVA: 0x00D697E1 File Offset: 0x00D679E1
		public void SetToggleFunction(TSortItemToggleEvent toggleFunction)
		{
			this.ToggleFunction = toggleFunction;
		}

		// Token: 0x06030147 RID: 196935 RVA: 0x00D697EA File Offset: 0x00D679EA
		public void SetCanExecuteChange(TCanExecuteChange callback)
		{
			this.CanExecuteChangeInternal = callback;
		}

		// Token: 0x06030148 RID: 196936 RVA: 0x00D697F4 File Offset: 0x00D679F4
		public void SetToggleStateForce(bool bSelected)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			EToggleState state = bSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			extendToggle.SetToggleStateForce(state, false, false, false);
		}

		// Token: 0x06030149 RID: 196937 RVA: 0x00D69819 File Offset: 0x00D67A19
		public override void Refresh(ISortData data, bool isSelected, int gridIndex)
		{
			this.SortData = data;
			this.SetName();
			this.SetDefaultToggleState(this.SortData.SelectedRule == this.SortData.RuleId);
		}

		// Token: 0x0603014A RID: 196938 RVA: 0x00D69846 File Offset: 0x00D67A46
		public override object GetKey(ISortData data, int displayIndex)
		{
			return data.RuleId;
		}

		// Token: 0x040197CC RID: 104396
		[Nullable(2)]
		private ISortData SortData;

		// Token: 0x040197CD RID: 104397
		private string Name = "";

		// Token: 0x040197CE RID: 104398
		[Nullable(2)]
		private TSortItemToggleEvent ToggleFunction;

		// Token: 0x040197CF RID: 104399
		[Nullable(2)]
		private TCanExecuteChange CanExecuteChangeInternal;

		// Token: 0x0200A774 RID: 42868
		[NullableContext(0)]
		private enum ESortItemDefine
		{
			// Token: 0x04033BFD RID: 211965
			Name,
			// Token: 0x04033BFE RID: 211966
			Toggle
		}
	}
}
