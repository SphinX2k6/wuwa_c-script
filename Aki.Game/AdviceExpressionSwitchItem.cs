using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x02000B8A RID: 2954
[NullableContext(1)]
[Nullable(0)]
public class AdviceExpressionSwitchItem : CommonTabItemBase
{
	// Token: 0x06007AF6 RID: 31478 RVA: 0x00261AC0 File Offset: 0x0025FCC0
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

	// Token: 0x06007AF7 RID: 31479 RVA: 0x00261B27 File Offset: 0x0025FD27
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

	// Token: 0x06007AF8 RID: 31480 RVA: 0x00261B45 File Offset: 0x0025FD45
	private void OnExtendToggleToggle(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked && this.SelectedCallBack != null)
		{
			this.SelectedCallBack(this.ExpressionGroupId);
		}
	}

	// Token: 0x06007AF9 RID: 31481 RVA: 0x00261B66 File Offset: 0x0025FD66
	protected override void OnSetToggleState(EToggleState state, bool bFire)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(state, bFire, false, false);
	}

	// Token: 0x06007AFA RID: 31482 RVA: 0x00261B7E File Offset: 0x0025FD7E
	protected override void OnRefresh(CommonTabItemData data, bool isSelected, int gridIndex)
	{
		CommonTabData data2 = data.Data;
		base.UpdateTabIcon((data2 != null) ? data2.GetIcon() : null);
	}

	// Token: 0x06007AFB RID: 31483 RVA: 0x00261B98 File Offset: 0x0025FD98
	protected override void OnUpdateTabIcon(string iconPath)
	{
	}

	// Token: 0x06007AFC RID: 31484 RVA: 0x00261B9A File Offset: 0x0025FD9A
	protected override UUIExtendToggle GetTabToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x06007AFD RID: 31485 RVA: 0x00261BA4 File Offset: 0x0025FDA4
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

	// Token: 0x04004C20 RID: 19488
	private int ExpressionGroupId;

	// Token: 0x02006E2A RID: 28202
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x04024153 RID: 147795
		public const int SwitchToggle = 0;

		// Token: 0x04024154 RID: 147796
		public const int ExpressionImg = 1;
	}
}
