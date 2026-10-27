using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.FilterSort.Sort.BaseSortGroup
{
	// Token: 0x02005B38 RID: 23352
	[NullableContext(1)]
	[Nullable(0)]
	internal class SortItem : UiPanelBase
	{
		// Token: 0x0603B202 RID: 242178 RVA: 0x00E195F2 File Offset: 0x00E177F2
		public SortItem(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x0603B203 RID: 242179 RVA: 0x00E1961C File Offset: 0x00E1781C
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

		// Token: 0x0603B204 RID: 242180 RVA: 0x00E196E3 File Offset: 0x00E178E3
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

		// Token: 0x0603B205 RID: 242181 RVA: 0x00E19705 File Offset: 0x00E17905
		protected override void OnStart()
		{
			base.GetExtendToggle(1).CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
		}

		// Token: 0x0603B206 RID: 242182 RVA: 0x00E19724 File Offset: 0x00E17924
		private bool CanExecuteChange()
		{
			return this.CanExecuteChangeInternal == null || this.CanExecuteChangeInternal(this.RuleId);
		}

		// Token: 0x0603B207 RID: 242183 RVA: 0x00E19741 File Offset: 0x00E17941
		protected override void OnBeforeDestroy()
		{
			base.GetExtendToggle(1).CanExecuteChange.Unbind();
		}

		// Token: 0x0603B208 RID: 242184 RVA: 0x00E19754 File Offset: 0x00E17954
		private void SetName()
		{
			this.Name = SortConfig.Instance.GetSortRuleName(this.RuleId, this.DataType);
			base.GetText(0).SetText(this.Name, true);
		}

		// Token: 0x0603B209 RID: 242185 RVA: 0x00E19788 File Offset: 0x00E17988
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

		// Token: 0x0603B20A RID: 242186 RVA: 0x00E19820 File Offset: 0x00E17A20
		public void SetToggleFunction(TSortItemToggleEvent toggleFunction)
		{
			this.ToggleFunction = toggleFunction;
		}

		// Token: 0x0603B20B RID: 242187 RVA: 0x00E19829 File Offset: 0x00E17A29
		public void SetCanExecuteChange(TCanExecuteChange callback)
		{
			this.CanExecuteChangeInternal = callback;
		}

		// Token: 0x0603B20C RID: 242188 RVA: 0x00E19834 File Offset: 0x00E17A34
		public void SetToggleStateForce(bool bSelected)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			EToggleState state = bSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			extendToggle.SetToggleStateForce(state, false, false, false);
		}

		// Token: 0x0603B20D RID: 242189 RVA: 0x00E19859 File Offset: 0x00E17A59
		public void ShowSortItem(int ruleId, ESortDataType dateType, bool bSelected)
		{
			this.RuleId = ruleId;
			this.DataType = dateType;
			this.SetName();
			this.SetTexture();
			this.SetToggleStateForce(bSelected);
		}

		// Token: 0x0401ED23 RID: 126243
		private int RuleId;

		// Token: 0x0401ED24 RID: 126244
		private ESortDataType DataType = ESortDataType.Role;

		// Token: 0x0401ED25 RID: 126245
		private string Name = "";

		// Token: 0x0401ED26 RID: 126246
		[Nullable(2)]
		private TSortItemToggleEvent ToggleFunction;

		// Token: 0x0401ED27 RID: 126247
		[Nullable(2)]
		private TCanExecuteChange CanExecuteChangeInternal;

		// Token: 0x0200BD6E RID: 48494
		[NullableContext(0)]
		private enum ESortItemDefine
		{
			// Token: 0x0403923E RID: 234046
			Name,
			// Token: 0x0403923F RID: 234047
			Toggle,
			// Token: 0x04039240 RID: 234048
			Icon
		}
	}
}
