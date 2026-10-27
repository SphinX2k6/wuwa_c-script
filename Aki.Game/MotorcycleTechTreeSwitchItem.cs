using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002246 RID: 8774
public class MotorcycleTechTreeSwitchItem : GridProxyAbstract<int>
{
	// Token: 0x060111D7 RID: 70103 RVA: 0x0042D1A8 File Offset: 0x0042B3A8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickItem))
		};
	}

	// Token: 0x060111D8 RID: 70104 RVA: 0x0042D23B File Offset: 0x0042B43B
	protected override void OnStart()
	{
		this.CurTechTreeType = MotorcycleDevelopModel.Instance.GetCurTreeType();
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x060111D9 RID: 70105 RVA: 0x0042D260 File Offset: 0x0042B460
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		MotorTechTree? motorTechTreeConfig = MotorConfig.Instance.GetMotorTechTreeConfig(data);
		if (motorTechTreeConfig == null)
		{
			return;
		}
		this.TechTreeType = data;
		base.SetTextureByPath(motorTechTreeConfig.Value.Icon512, base.GetTexture(1), null, null);
		base.GetItem(2).SetUIActive(data == this.CurTechTreeType);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), motorTechTreeConfig.Value.Name, Array.Empty<object>());
	}

	// Token: 0x060111DA RID: 70106 RVA: 0x0042D2EA File Offset: 0x0042B4EA
	public override void OnSelected(bool fireEvent)
	{
		if (this.TechTreeType <= 0)
		{
			return;
		}
		Action<int, UUIExtendToggle> onClickToggleBack = this.OnClickToggleBack;
		if (onClickToggleBack == null)
		{
			return;
		}
		onClickToggleBack(this.TechTreeType, base.GetExtendToggle(0));
	}

	// Token: 0x060111DB RID: 70107 RVA: 0x0042D313 File Offset: 0x0042B513
	private void OnClickItem(EToggleState toggleState)
	{
		if (this.TechTreeType <= 0)
		{
			return;
		}
		Action<int, UUIExtendToggle> onClickToggleBack = this.OnClickToggleBack;
		if (onClickToggleBack == null)
		{
			return;
		}
		onClickToggleBack(this.TechTreeType, base.GetExtendToggle(0));
	}

	// Token: 0x04008253 RID: 33363
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int, UUIExtendToggle> OnClickToggleBack;

	// Token: 0x04008254 RID: 33364
	private int TechTreeType;

	// Token: 0x04008255 RID: 33365
	private int CurTechTreeType;

	// Token: 0x02008785 RID: 34693
	private class EMotorTechTreeSwitchItemComponent
	{
		// Token: 0x0402C0C9 RID: 180425
		public const int TogItem = 0;

		// Token: 0x0402C0CA RID: 180426
		public const int TexIcon = 1;

		// Token: 0x0402C0CB RID: 180427
		public const int CurSelectItem = 2;

		// Token: 0x0402C0CC RID: 180428
		public const int TxtName = 3;

		// Token: 0x0402C0CD RID: 180429
		public const int TxtName2 = 4;
	}
}
