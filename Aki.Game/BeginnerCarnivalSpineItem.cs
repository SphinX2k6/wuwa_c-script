using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020011A0 RID: 4512
public class BeginnerCarnivalSpineItem : UiPanelBase
{
	// Token: 0x0600777C RID: 30588 RVA: 0x0018F5CF File Offset: 0x0018D7CF
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(USpineSkeletonAnimationComponent))
		};
	}

	// Token: 0x0600777D RID: 30589 RVA: 0x0018F5F2 File Offset: 0x0018D7F2
	[NullableContext(1)]
	public void SetAnimation(int trackIndex, string animationName, bool loop)
	{
		base.GetSpine(0).SetAnimation(trackIndex, animationName, loop);
	}
}
