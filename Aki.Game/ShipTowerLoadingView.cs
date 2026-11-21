using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001F2F RID: 7983
public class ShipTowerLoadingView : LoadingViewBase
{
	// Token: 0x06013C3B RID: 80955 RVA: 0x005C455D File Offset: 0x005C275D
	[NullableContext(1)]
	public ShipTowerLoadingView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06013C3C RID: 80956 RVA: 0x005C4566 File Offset: 0x005C2766
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x06013C3D RID: 80957 RVA: 0x005C4589 File Offset: 0x005C2789
	protected override void UpdateProgressRate(float rate)
	{
	}

	// Token: 0x06013C3E RID: 80958 RVA: 0x005C458B File Offset: 0x005C278B
	protected override void UpdateProgressValue(float value)
	{
		this.SetTextProgressValue(0, value, "%");
	}

	// Token: 0x02008211 RID: 33297
	private static class EChildType
	{
		// Token: 0x0402A01F RID: 172063
		public const int TxtProgress = 0;
	}
}
