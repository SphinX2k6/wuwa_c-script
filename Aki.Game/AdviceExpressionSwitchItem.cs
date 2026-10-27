using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x020016D2 RID: 5842
[NullableContext(1)]
[Nullable(0)]
public class AdviceExpressionSwitchItem : CommonTabItemBase
{
	// Token: 0x0600A716 RID: 42774 RVA: 0x002576B4 File Offset: 0x002558B4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnExtendToggleToggle))
		};
	}

	// Token: 0x0600A717 RID: 42775 RVA: 0x0025771B File Offset: 0x0025591B
	protected override void OnStart()
	{
		base.OnStart();
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600A718 RID: 42776 RVA: 0x00257739 File Offset: 0x00255939
	private void OnExtendToggleToggle(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked && this.SelectedCallBack != null)
		{
			this.SelectedCallBack(this.ExpressionGroupId);
		}
	}

	// Token: 0x0600A719 RID: 42777 RVA: 0x0025775A File Offset: 0x0025595A
	protected override void OnSetToggleState(EToggleState state, bool bFire)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(state, bFire, false, false);
	}

	// Token: 0x0600A71A RID: 42778 RVA: 0x00257772 File Offset: 0x00255972
	protected override void OnRefresh(CommonTabItemData data, bool isSelected, int gridIndex)
	{
		CommonTabData data2 = data.Data;
		base.UpdateTabIcon((data2 != null) ? data2.GetIcon() : null);
	}

	// Token: 0x0600A71B RID: 42779 RVA: 0x0025778C File Offset: 0x0025598C
	protected override void OnUpdateTabIcon(string iconPath)
	{
	}

	// Token: 0x0600A71C RID: 42780 RVA: 0x0025778E File Offset: 0x0025598E
	protected override UUIExtendToggle GetTabToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x0600A71D RID: 42781 RVA: 0x00257798 File Offset: 0x00255998
	public void UpdateView(int groupId)
	{
		this.ExpressionGroupId = groupId;
		ChatExpressionGroup? expressionGroupConfig = ChatConfig.Instance.GetExpressionGroupConfig(groupId);
		if (expressionGroupConfig != null)
		{
			string groupTexturePath = expressionGroupConfig.Value.GroupTexturePath;
			base.SetTextureByPath(groupTexturePath, base.GetTexture(1), null, null);
		}
	}

	// Token: 0x04004B79 RID: 19321
	private int ExpressionGroupId;

	// Token: 0x02007CA5 RID: 31909
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x04028E2A RID: 167466
		public const int SwitchToggle = 0;

		// Token: 0x04028E2B RID: 167467
		public const int ExpressionImg = 1;
	}
}
