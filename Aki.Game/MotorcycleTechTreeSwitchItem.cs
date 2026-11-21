using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200172A RID: 5930
public class MotorcycleTechTreeSwitchItem : GridProxyAbstract<int>
{
	// Token: 0x0600E66D RID: 58989 RVA: 0x00439D4C File Offset: 0x00437F4C
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

	// Token: 0x0600E66E RID: 58990 RVA: 0x00439DDF File Offset: 0x00437FDF
	protected override void OnStart()
	{
		this.CurTechTreeType = MotorcycleDevelopModel.Instance.GetCurTreeType();
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600E66F RID: 58991 RVA: 0x00439E04 File Offset: 0x00438004
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

	// Token: 0x0600E670 RID: 58992 RVA: 0x00439E8E File Offset: 0x0043808E
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

	// Token: 0x0600E671 RID: 58993 RVA: 0x00439EB7 File Offset: 0x004380B7
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

	// Token: 0x04008391 RID: 33681
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int, UUIExtendToggle> OnClickToggleBack;

	// Token: 0x04008392 RID: 33682
	private int TechTreeType;

	// Token: 0x04008393 RID: 33683
	private int CurTechTreeType;

	// Token: 0x0200790E RID: 30990
	private class EMotorTechTreeSwitchItemComponent
	{
		// Token: 0x040273E1 RID: 160737
		public const int TogItem = 0;

		// Token: 0x040273E2 RID: 160738
		public const int TexIcon = 1;

		// Token: 0x040273E3 RID: 160739
		public const int CurSelectItem = 2;

		// Token: 0x040273E4 RID: 160740
		public const int TxtName = 3;

		// Token: 0x040273E5 RID: 160741
		public const int TxtName2 = 4;
	}
}
