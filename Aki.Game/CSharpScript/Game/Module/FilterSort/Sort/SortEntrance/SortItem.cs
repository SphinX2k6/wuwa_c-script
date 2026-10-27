using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.FilterSort.Sort.SortEntrance
{
	// Token: 0x02005B34 RID: 23348
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class SortItem : GridProxyAbstract<ISortData>
	{
		// Token: 0x0603B1CE RID: 242126 RVA: 0x00E18958 File Offset: 0x00E16B58
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

		// Token: 0x0603B1CF RID: 242127 RVA: 0x00E189FE File Offset: 0x00E16BFE
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

		// Token: 0x0603B1D0 RID: 242128 RVA: 0x00E18A25 File Offset: 0x00E16C25
		protected override void OnStart()
		{
			base.GetExtendToggle(1).CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
		}

		// Token: 0x0603B1D1 RID: 242129 RVA: 0x00E18A44 File Offset: 0x00E16C44
		private bool CanExecuteChange()
		{
			return this.CanExecuteChangeInternal == null || this.CanExecuteChangeInternal(this.SortData.RuleId);
		}

		// Token: 0x0603B1D2 RID: 242130 RVA: 0x00E18A66 File Offset: 0x00E16C66
		private void SetName()
		{
			this.Name = SortConfig.Instance.GetSortRuleName(this.SortData.RuleId, this.SortData.DataType);
			base.GetText(0).SetText(this.Name, true);
		}

		// Token: 0x0603B1D3 RID: 242131 RVA: 0x00E18AA4 File Offset: 0x00E16CA4
		private void SetDefaultToggleState(bool bSelected)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			EToggleState state = bSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			extendToggle.SetToggleStateForce(state, false, false, false);
		}

		// Token: 0x0603B1D4 RID: 242132 RVA: 0x00E18AC9 File Offset: 0x00E16CC9
		public void SetToggleFunction(TSortItemToggleEvent toggleFunction)
		{
			this.ToggleFunction = toggleFunction;
		}

		// Token: 0x0603B1D5 RID: 242133 RVA: 0x00E18AD2 File Offset: 0x00E16CD2
		public void SetCanExecuteChange(TCanExecuteChange callback)
		{
			this.CanExecuteChangeInternal = callback;
		}

		// Token: 0x0603B1D6 RID: 242134 RVA: 0x00E18ADC File Offset: 0x00E16CDC
		public void SetToggleStateForce(bool bSelected)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			EToggleState state = bSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			extendToggle.SetToggleStateForce(state, false, false, false);
		}

		// Token: 0x0603B1D7 RID: 242135 RVA: 0x00E18B01 File Offset: 0x00E16D01
		public override void Refresh(ISortData data, bool isSelected, int gridIndex)
		{
			this.SortData = data;
			this.SetName();
			this.SetDefaultToggleState(this.SortData.SelectedRule == this.SortData.RuleId);
		}

		// Token: 0x0603B1D8 RID: 242136 RVA: 0x00E18B2E File Offset: 0x00E16D2E
		public override object GetKey(ISortData data, int displayIndex)
		{
			return data.RuleId;
		}

		// Token: 0x0401ED10 RID: 126224
		[Nullable(2)]
		private ISortData SortData;

		// Token: 0x0401ED11 RID: 126225
		private string Name = "";

		// Token: 0x0401ED12 RID: 126226
		[Nullable(2)]
		private TSortItemToggleEvent ToggleFunction;

		// Token: 0x0401ED13 RID: 126227
		[Nullable(2)]
		private TCanExecuteChange CanExecuteChangeInternal;

		// Token: 0x0200BD6B RID: 48491
		[NullableContext(0)]
		private enum ESortItemDefine
		{
			// Token: 0x04039231 RID: 234033
			Name,
			// Token: 0x04039232 RID: 234034
			Toggle
		}
	}
}
