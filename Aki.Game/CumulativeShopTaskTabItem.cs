using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020006BD RID: 1725
public class CumulativeShopTaskTabItem : GridProxyAbstract<int>
{
	// Token: 0x06004F2E RID: 20270 RVA: 0x001AA094 File Offset: 0x001A8294
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnExtendToggleToggle))
		};
	}

	// Token: 0x06004F2F RID: 20271 RVA: 0x001AA127 File Offset: 0x001A8327
	private void OnExtendToggleToggle(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.OnClickBack(this.TabIndex, base.GetExtendToggle(1));
		}
	}

	// Token: 0x06004F30 RID: 20272 RVA: 0x001AA148 File Offset: 0x001A8348
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		this.TabIndex = data;
		ConsumptiveTaskTab? cumulativeShopTaskTabConfig = CumulativeShopConfig.Instance.GetCumulativeShopTaskTabConfig(this.TabIndex);
		this.SetSpriteByPath(cumulativeShopTaskTabConfig.Value.SpriteIcon, base.GetSprite(0), false, null, delegate(bool _)
		{
			(base.GetSprite(0).GetOwner().GetComponentByClass(UUIExtendToggleSpriteTransition.StaticClass()) as UUIExtendToggleSpriteTransition).SetAllStateSprite(base.GetSprite(0).GetSprite());
		});
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), cumulativeShopTaskTabConfig.Value.Title, Array.Empty<object>());
		RedDotController.Instance.BindRedDot(ERedDotName.CumulativeShopTaskTabRedDot, base.GetItem(2), null, this.TabIndex);
	}

	// Token: 0x06004F31 RID: 20273 RVA: 0x001AA1E1 File Offset: 0x001A83E1
	protected override void OnBeforeDestroy()
	{
		RedDotController.Instance.UnBindGivenUi(ERedDotName.CumulativeShopTaskTabRedDot, base.GetItem(2), 0);
	}

	// Token: 0x06004F32 RID: 20274 RVA: 0x001AA1FA File Offset: 0x001A83FA
	public override void OnSelected(bool fireEvent)
	{
		base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_Checked, true, false, false);
	}

	// Token: 0x0400393C RID: 14652
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int, UUIExtendToggle> OnClickBack;

	// Token: 0x0400393D RID: 14653
	public int TabIndex;
}
