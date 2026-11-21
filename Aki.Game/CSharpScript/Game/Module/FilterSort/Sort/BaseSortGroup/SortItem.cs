using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.FilterSort.Sort.BaseSortGroup
{
	// Token: 0x02004B19 RID: 19225
	[NullableContext(1)]
	[Nullable(0)]
	internal class SortItem : UiPanelBase
	{
		// Token: 0x06030174 RID: 196980 RVA: 0x00D6A30A File Offset: 0x00D6850A
		public SortItem(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x06030175 RID: 196981 RVA: 0x00D6A334 File Offset: 0x00D68534
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.ToggleEvent));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06030176 RID: 196982 RVA: 0x00D6A3FB File Offset: 0x00D685FB
		private void ToggleEvent(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				TSortItemToggleEvent toggleFunction = this.ToggleFunction;
				if (toggleFunction == null)
				{
					return;
				}
				toggleFunction(this.RuleId, this.Name);
			}
		}

		// Token: 0x06030177 RID: 196983 RVA: 0x00D6A41D File Offset: 0x00D6861D
		protected override void OnStart()
		{
			base.GetExtendToggle(1).CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
		}

		// Token: 0x06030178 RID: 196984 RVA: 0x00D6A43C File Offset: 0x00D6863C
		private bool CanExecuteChange()
		{
			return this.CanExecuteChangeInternal == null || this.CanExecuteChangeInternal(this.RuleId);
		}

		// Token: 0x06030179 RID: 196985 RVA: 0x00D6A459 File Offset: 0x00D68659
		protected override void OnBeforeDestroy()
		{
			base.GetExtendToggle(1).CanExecuteChange.Unbind();
		}

		// Token: 0x0603017A RID: 196986 RVA: 0x00D6A46C File Offset: 0x00D6866C
		private void SetName()
		{
			this.Name = SortConfig.Instance.GetSortRuleName(this.RuleId, this.DataType);
			base.GetText(0).SetText(this.Name, true);
		}

		// Token: 0x0603017B RID: 196987 RVA: 0x00D6A4A0 File Offset: 0x00D686A0
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

		// Token: 0x0603017C RID: 196988 RVA: 0x00D6A538 File Offset: 0x00D68738
		public void SetToggleFunction(TSortItemToggleEvent toggleFunction)
		{
			this.ToggleFunction = toggleFunction;
		}

		// Token: 0x0603017D RID: 196989 RVA: 0x00D6A541 File Offset: 0x00D68741
		public void SetCanExecuteChange(TCanExecuteChange callback)
		{
			this.CanExecuteChangeInternal = callback;
		}

		// Token: 0x0603017E RID: 196990 RVA: 0x00D6A54C File Offset: 0x00D6874C
		public void SetToggleStateForce(bool bSelected)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			EToggleState state = bSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			extendToggle.SetToggleStateForce(state, false, false, false);
		}

		// Token: 0x0603017F RID: 196991 RVA: 0x00D6A571 File Offset: 0x00D68771
		public void ShowSortItem(int ruleId, ESortDataType dateType, bool bSelected)
		{
			this.RuleId = ruleId;
			this.DataType = dateType;
			this.SetName();
			this.SetTexture();
			this.SetToggleStateForce(bSelected);
		}

		// Token: 0x040197DF RID: 104415
		private int RuleId;

		// Token: 0x040197E0 RID: 104416
		private ESortDataType DataType = ESortDataType.Role;

		// Token: 0x040197E1 RID: 104417
		private string Name = "";

		// Token: 0x040197E2 RID: 104418
		[Nullable(2)]
		private TSortItemToggleEvent ToggleFunction;

		// Token: 0x040197E3 RID: 104419
		[Nullable(2)]
		private TCanExecuteChange CanExecuteChangeInternal;

		// Token: 0x0200A777 RID: 42871
		[NullableContext(0)]
		private enum ESortItemDefine
		{
			// Token: 0x04033C0A RID: 211978
			Name,
			// Token: 0x04033C0B RID: 211979
			Toggle,
			// Token: 0x04033C0C RID: 211980
			Icon
		}
	}
}
