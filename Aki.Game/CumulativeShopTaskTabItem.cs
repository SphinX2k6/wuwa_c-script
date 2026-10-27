using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001209 RID: 4617
public class CumulativeShopTaskTabItem : GridProxyAbstract<int>
{
	// Token: 0x06007B98 RID: 31640 RVA: 0x001A13DC File Offset: 0x0019F5DC
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

	// Token: 0x06007B99 RID: 31641 RVA: 0x001A146F File Offset: 0x0019F66F
	private void OnExtendToggleToggle(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.OnClickBack(this.TabIndex, base.GetExtendToggle(1));
		}
	}

	// Token: 0x06007B9A RID: 31642 RVA: 0x001A1490 File Offset: 0x0019F690
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

	// Token: 0x06007B9B RID: 31643 RVA: 0x001A1529 File Offset: 0x0019F729
	protected override void OnBeforeDestroy()
	{
		RedDotController.Instance.UnBindGivenUi(ERedDotName.CumulativeShopTaskTabRedDot, base.GetItem(2), 0);
	}

	// Token: 0x06007B9C RID: 31644 RVA: 0x001A1542 File Offset: 0x0019F742
	public override void OnSelected(bool fireEvent)
	{
		base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_Checked, true, false, false);
	}

	// Token: 0x040038A3 RID: 14499
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int, UUIExtendToggle> OnClickBack;

	// Token: 0x040038A4 RID: 14500
	public int TabIndex;
}
