using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000654 RID: 1620
public class BeginnerCarnivalSpineItem : UiPanelBase
{
	// Token: 0x06004B13 RID: 19219 RVA: 0x001981B3 File Offset: 0x001963B3
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(USpineSkeletonAnimationComponent))
		};
	}

	// Token: 0x06004B14 RID: 19220 RVA: 0x001981D6 File Offset: 0x001963D6
	[NullableContext(1)]
	public void SetAnimation(int trackIndex, string animationName, bool loop)
	{
		base.GetSpine(0).SetAnimation(trackIndex, animationName, loop);
	}
}
