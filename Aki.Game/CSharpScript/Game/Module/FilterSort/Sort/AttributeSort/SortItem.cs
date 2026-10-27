using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.FilterSort.Sort.AttributeSort
{
	// Token: 0x02005B3C RID: 23356
	[NullableContext(1)]
	[Nullable(0)]
	internal class SortItem : UiPanelBase
	{
		// Token: 0x0603B224 RID: 242212 RVA: 0x00E19BA0 File Offset: 0x00E17DA0
		public SortItem(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x0603B225 RID: 242213 RVA: 0x00E19BC8 File Offset: 0x00E17DC8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.ToggleEvent));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603B226 RID: 242214 RVA: 0x00E19CB0 File Offset: 0x00E17EB0
		private void ToggleEvent(EToggleState state)
		{
			TSortItemToggleEventWithState toggleFunction = this.ToggleFunction;
			if (toggleFunction == null)
			{
				return;
			}
			toggleFunction(state, this.RuleId, this.Name);
		}

		// Token: 0x0603B227 RID: 242215 RVA: 0x00E19CCF File Offset: 0x00E17ECF
		protected override void OnStart()
		{
			base.GetExtendToggle(1).CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
		}

		// Token: 0x0603B228 RID: 242216 RVA: 0x00E19CEE File Offset: 0x00E17EEE
		private bool CanExecuteChange()
		{
			return base.GetExtendToggle(1).ToggleState == EToggleState.ETT_Checked || this.CanExecuteChangeInternal == null || this.CanExecuteChangeInternal();
		}

		// Token: 0x0603B229 RID: 242217 RVA: 0x00E19D16 File Offset: 0x00E17F16
		protected override void OnBeforeDestroy()
		{
			base.GetExtendToggle(1).CanExecuteChange.Unbind();
		}

		// Token: 0x0603B22A RID: 242218 RVA: 0x00E19D29 File Offset: 0x00E17F29
		private void SetName()
		{
			this.Name = SortConfig.Instance.GetSortRuleName(this.RuleId, this.DataType);
			base.GetText(0).SetText(this.Name, true);
		}

		// Token: 0x0603B22B RID: 242219 RVA: 0x00E19D5C File Offset: 0x00E17F5C
		private void SetTexture()
		{
			int sortRuleAttributeId = SortConfig.Instance.GetSortRuleAttributeId(this.RuleId, this.DataType);
			bool flag = sortRuleAttributeId > 0;
			string text = flag ? PropertyIndexConfig.Instance.GetPropertyIndexIcon(sortRuleAttributeId) : SortConfig.Instance.GetSortRuleIcon(this.RuleId, this.DataType);
			UUITexture texture = base.GetTexture(2);
			if (StringUtils.IsBlank(text))
			{
				texture.SetUIActive(false);
				return;
			}
			texture.SetUIActive(true);
			base.SetTextureByPath(text, texture, null, null);
			UUIItem uuiitem = texture;
			bool bUseChangeColor = flag;
			FColor? fcolor = new FColor?(texture.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		}

		// Token: 0x0603B22C RID: 242220 RVA: 0x00E19DF4 File Offset: 0x00E17FF4
		private void SetToggleState(bool bSelected)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			EToggleState state = bSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			extendToggle.SetToggleStateForce(state, false, false, false);
		}

		// Token: 0x0603B22D RID: 242221 RVA: 0x00E19E19 File Offset: 0x00E18019
		public void SetToggleFunction(TSortItemToggleEventWithState toggleFunction)
		{
			this.ToggleFunction = toggleFunction;
		}

		// Token: 0x0603B22E RID: 242222 RVA: 0x00E19E22 File Offset: 0x00E18022
		public void SetCanExecuteChange(TCanExecuteChangeSimple callback)
		{
			this.CanExecuteChangeInternal = callback;
		}

		// Token: 0x0603B22F RID: 242223 RVA: 0x00E19E2B File Offset: 0x00E1802B
		public void ShowSortItem(int ruleId, ESortDataType dataType, int sortIndex)
		{
			this.RuleId = ruleId;
			this.DataType = dataType;
			this.SetName();
			this.SetTexture();
			this.SetToggleState(sortIndex > 0);
			this.RefreshIndex(sortIndex);
		}

		// Token: 0x0603B230 RID: 242224 RVA: 0x00E19E58 File Offset: 0x00E18058
		public void RefreshIndex(int sortIndex)
		{
			UUIText text = base.GetText(3);
			if (sortIndex == 0)
			{
				text.SetUIActive(false);
				return;
			}
			text.SetUIActive(true);
			text.SetText(sortIndex.ToString(), true);
		}

		// Token: 0x0401ED2D RID: 126253
		private int RuleId;

		// Token: 0x0401ED2E RID: 126254
		private string Name = "";

		// Token: 0x0401ED2F RID: 126255
		private ESortDataType DataType = ESortDataType.Role;

		// Token: 0x0401ED30 RID: 126256
		[Nullable(2)]
		private TSortItemToggleEventWithState ToggleFunction;

		// Token: 0x0401ED31 RID: 126257
		[Nullable(2)]
		private TCanExecuteChangeSimple CanExecuteChangeInternal;

		// Token: 0x0200BD70 RID: 48496
		[NullableContext(0)]
		private enum ESortItemDefine
		{
			// Token: 0x04039245 RID: 234053
			Name,
			// Token: 0x04039246 RID: 234054
			Toggle,
			// Token: 0x04039247 RID: 234055
			Icon,
			// Token: 0x04039248 RID: 234056
			LimitNum
		}
	}
}
