using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.FilterSort.Sort.AttributeSort
{
	// Token: 0x02004B1D RID: 19229
	[NullableContext(1)]
	[Nullable(0)]
	internal class SortItem : UiPanelBase
	{
		// Token: 0x06030196 RID: 197014 RVA: 0x00D6A8B8 File Offset: 0x00D68AB8
		public SortItem(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x06030197 RID: 197015 RVA: 0x00D6A8E0 File Offset: 0x00D68AE0
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

		// Token: 0x06030198 RID: 197016 RVA: 0x00D6A9C8 File Offset: 0x00D68BC8
		private void ToggleEvent(EToggleState state)
		{
			TSortItemToggleEventWithState toggleFunction = this.ToggleFunction;
			if (toggleFunction == null)
			{
				return;
			}
			toggleFunction(state, this.RuleId, this.Name);
		}

		// Token: 0x06030199 RID: 197017 RVA: 0x00D6A9E7 File Offset: 0x00D68BE7
		protected override void OnStart()
		{
			base.GetExtendToggle(1).CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
		}

		// Token: 0x0603019A RID: 197018 RVA: 0x00D6AA06 File Offset: 0x00D68C06
		private bool CanExecuteChange()
		{
			return base.GetExtendToggle(1).ToggleState == EToggleState.ETT_Checked || this.CanExecuteChangeInternal == null || this.CanExecuteChangeInternal();
		}

		// Token: 0x0603019B RID: 197019 RVA: 0x00D6AA2E File Offset: 0x00D68C2E
		protected override void OnBeforeDestroy()
		{
			base.GetExtendToggle(1).CanExecuteChange.Unbind();
		}

		// Token: 0x0603019C RID: 197020 RVA: 0x00D6AA41 File Offset: 0x00D68C41
		private void SetName()
		{
			this.Name = SortConfig.Instance.GetSortRuleName(this.RuleId, this.DataType);
			base.GetText(0).SetText(this.Name, true);
		}

		// Token: 0x0603019D RID: 197021 RVA: 0x00D6AA74 File Offset: 0x00D68C74
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

		// Token: 0x0603019E RID: 197022 RVA: 0x00D6AB0C File Offset: 0x00D68D0C
		private void SetToggleState(bool bSelected)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			EToggleState state = bSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			extendToggle.SetToggleStateForce(state, false, false, false);
		}

		// Token: 0x0603019F RID: 197023 RVA: 0x00D6AB31 File Offset: 0x00D68D31
		public void SetToggleFunction(TSortItemToggleEventWithState toggleFunction)
		{
			this.ToggleFunction = toggleFunction;
		}

		// Token: 0x060301A0 RID: 197024 RVA: 0x00D6AB3A File Offset: 0x00D68D3A
		public void SetCanExecuteChange(TCanExecuteChangeSimple callback)
		{
			this.CanExecuteChangeInternal = callback;
		}

		// Token: 0x060301A1 RID: 197025 RVA: 0x00D6AB43 File Offset: 0x00D68D43
		public void ShowSortItem(int ruleId, ESortDataType dataType, int sortIndex)
		{
			this.RuleId = ruleId;
			this.DataType = dataType;
			this.SetName();
			this.SetTexture();
			this.SetToggleState(sortIndex > 0);
			this.RefreshIndex(sortIndex);
		}

		// Token: 0x060301A2 RID: 197026 RVA: 0x00D6AB70 File Offset: 0x00D68D70
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

		// Token: 0x040197E9 RID: 104425
		private int RuleId;

		// Token: 0x040197EA RID: 104426
		private string Name = "";

		// Token: 0x040197EB RID: 104427
		private ESortDataType DataType = ESortDataType.Role;

		// Token: 0x040197EC RID: 104428
		[Nullable(2)]
		private TSortItemToggleEventWithState ToggleFunction;

		// Token: 0x040197ED RID: 104429
		[Nullable(2)]
		private TCanExecuteChangeSimple CanExecuteChangeInternal;

		// Token: 0x0200A779 RID: 42873
		[NullableContext(0)]
		private enum ESortItemDefine
		{
			// Token: 0x04033C11 RID: 211985
			Name,
			// Token: 0x04033C12 RID: 211986
			Toggle,
			// Token: 0x04033C13 RID: 211987
			Icon,
			// Token: 0x04033C14 RID: 211988
			LimitNum
		}
	}
}
