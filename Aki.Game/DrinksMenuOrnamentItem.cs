using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000416 RID: 1046
public class DrinksMenuOrnamentItem : GridProxyAbstract<int>
{
	// Token: 0x06003850 RID: 14416 RVA: 0x00147BD0 File Offset: 0x00145DD0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x06003851 RID: 14417 RVA: 0x00147C2A File Offset: 0x00145E2A
	protected override void OnStart()
	{
		base.GetExtendToggle(0).OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChange));
	}

	// Token: 0x06003852 RID: 14418 RVA: 0x00147C49 File Offset: 0x00145E49
	public override void OnSelected(bool fireEvent)
	{
		if (this.IsSelectOnCb != null && this.Id != 0)
		{
			this.SetSelected(this.IsSelectOnCb(this.Id), false);
		}
	}

	// Token: 0x06003853 RID: 14419 RVA: 0x00147C74 File Offset: 0x00145E74
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

	// Token: 0x06003854 RID: 14420 RVA: 0x00147CFA File Offset: 0x00145EFA
	private void SetSelected(bool bSelectOn, bool bFireEvent = false)
	{
		base.GetExtendToggle(0).SetToggleState(bSelectOn ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, bFireEvent, false, false);
	}

	// Token: 0x06003855 RID: 14421 RVA: 0x00147D13 File Offset: 0x00145F13
	private void OnToggleStateChange(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked && this.OnToggleStateChangeFunction != null)
		{
			this.OnToggleStateChangeFunction(this.Id);
		}
	}

	// Token: 0x04002E50 RID: 11856
	protected int Id;

	// Token: 0x04002E51 RID: 11857
	[Nullable(2)]
	public Func<int, bool> IsSelectOnCb;

	// Token: 0x04002E52 RID: 11858
	[Nullable(2)]
	public Action<int> OnToggleStateChangeFunction;

	// Token: 0x02006741 RID: 26433
	private static class EDefine
	{
		// Token: 0x0402219C RID: 139676
		public const int Toggle = 0;

		// Token: 0x0402219D RID: 139677
		public const int Icon = 1;

		// Token: 0x0402219E RID: 139678
		public const int Name = 2;
	}
}
