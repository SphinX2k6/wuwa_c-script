using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000F61 RID: 3937
public class DrinksMenuOrnamentItem : GridProxyAbstract<int>
{
	// Token: 0x060064B8 RID: 25784 RVA: 0x0013F334 File Offset: 0x0013D534
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x060064B9 RID: 25785 RVA: 0x0013F38E File Offset: 0x0013D58E
	protected override void OnStart()
	{
		base.GetExtendToggle(0).OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChange));
	}

	// Token: 0x060064BA RID: 25786 RVA: 0x0013F3AD File Offset: 0x0013D5AD
	public override void OnSelected(bool fireEvent)
	{
		if (this.IsSelectOnCb != null && this.Id != 0)
		{
			this.SetSelected(this.IsSelectOnCb(this.Id), false);
		}
	}

	// Token: 0x060064BB RID: 25787 RVA: 0x0013F3D8 File Offset: 0x0013D5D8
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		this.Id = data;
		DrinksOrnament? ornament = DrinksConfig.Instance.GetOrnament(data);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), ornament.Value.Name, Array.Empty<object>());
		base.SetTextureByPath(ornament.Value.Icon, base.GetTexture(1), null, null);
		if (this.IsSelectOnCb != null)
		{
			this.SetSelected(this.IsSelectOnCb(data), false);
		}
	}

	// Token: 0x060064BC RID: 25788 RVA: 0x0013F45E File Offset: 0x0013D65E
	private void SetSelected(bool bSelectOn, bool bFireEvent = false)
	{
		base.GetExtendToggle(0).SetToggleState(bSelectOn ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, bFireEvent, false, false);
	}

	// Token: 0x060064BD RID: 25789 RVA: 0x0013F477 File Offset: 0x0013D677
	private void OnToggleStateChange(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked && this.OnToggleStateChangeFunction != null)
		{
			this.OnToggleStateChangeFunction(this.Id);
		}
	}

	// Token: 0x04002DB7 RID: 11703
	protected int Id;

	// Token: 0x04002DB8 RID: 11704
	[Nullable(2)]
	public Func<int, bool> IsSelectOnCb;

	// Token: 0x04002DB9 RID: 11705
	[Nullable(2)]
	public Action<int> OnToggleStateChangeFunction;

	// Token: 0x020075AD RID: 30125
	private static class EDefine
	{
		// Token: 0x04026E51 RID: 159313
		public const int Toggle = 0;

		// Token: 0x04026E52 RID: 159314
		public const int Icon = 1;

		// Token: 0x04026E53 RID: 159315
		public const int Name = 2;
	}
}
