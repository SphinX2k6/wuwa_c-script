using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200228A RID: 8842
public class WeeklyRogueArtifactGrid : GridProxyAbstract<int>
{
	// Token: 0x06015DCC RID: 89548 RVA: 0x00656D60 File Offset: 0x00654F60
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick))
		};
	}

	// Token: 0x06015DCD RID: 89549 RVA: 0x00656DE0 File Offset: 0x00654FE0
	private void OnToggleClick(EToggleState state)
	{
		bool arg = base.GetExtendToggle(0).GetToggleState() == EToggleState.ETT_Checked;
		Action<int, bool> onSelectedChange = this.OnSelectedChange;
		if (onSelectedChange == null)
		{
			return;
		}
		onSelectedChange(this.TokenId, arg);
	}

	// Token: 0x06015DCE RID: 89550 RVA: 0x00656E14 File Offset: 0x00655014
	public override void Refresh(int tokenId, bool isSelected, int gridIndex)
	{
		this.TokenId = tokenId;
		if (tokenId == 0)
		{
			return;
		}
		RogueWeeklyBuffPool? rogueWeeklyBuffPool = WeeklyRogueConfig.Instance.GetRogueWeeklyBuffPool(tokenId);
		if (rogueWeeklyBuffPool == null)
		{
			return;
		}
		base.SetTextureShowUntilLoaded(rogueWeeklyBuffPool.Value.BuffIcon, base.GetTexture(1), null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), rogueWeeklyBuffPool.Value.BuffName, Array.Empty<object>());
	}

	// Token: 0x06015DCF RID: 89551 RVA: 0x00656E84 File Offset: 0x00655084
	public override void OnSelected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, fireEvent, false, false);
	}

	// Token: 0x06015DD0 RID: 89552 RVA: 0x00656E97 File Offset: 0x00655097
	public override void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, fireEvent, false, false);
	}

	// Token: 0x06015DD1 RID: 89553 RVA: 0x00656EAA File Offset: 0x006550AA
	[NullableContext(1)]
	public override object GetKey(int data, int displayIndex)
	{
		return this.TokenId;
	}

	// Token: 0x0400B80E RID: 47118
	[Nullable(2)]
	public Action<int, bool> OnSelectedChange;

	// Token: 0x0400B80F RID: 47119
	protected int TokenId;

	// Token: 0x020084E5 RID: 34021
	private enum EComponents
	{
		// Token: 0x0402AD76 RID: 175478
		ToggleSelf,
		// Token: 0x0402AD77 RID: 175479
		TexIcon,
		// Token: 0x0402AD78 RID: 175480
		TxtName
	}
}
