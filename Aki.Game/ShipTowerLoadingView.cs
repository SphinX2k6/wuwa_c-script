using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020029B4 RID: 10676
public class ShipTowerLoadingView : LoadingViewBase
{
	// Token: 0x06016235 RID: 90677 RVA: 0x005995D1 File Offset: 0x005977D1
	[NullableContext(1)]
	public ShipTowerLoadingView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06016236 RID: 90678 RVA: 0x005995DA File Offset: 0x005977DA
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x06016237 RID: 90679 RVA: 0x005995FD File Offset: 0x005977FD
	protected override void UpdateProgressRate(float rate)
	{
	}

	// Token: 0x06016238 RID: 90680 RVA: 0x005995FF File Offset: 0x005977FF
	protected override void UpdateProgressValue(float value)
	{
		this.SetTextProgressValue(0, value, "%");
	}

	// Token: 0x02008FC9 RID: 36809
	private static class EChildType
	{
		// Token: 0x0402E922 RID: 190754
		public const int TxtProgress = 0;
	}
}
