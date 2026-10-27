using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Main
{
	// Token: 0x0200632E RID: 25390
	[NullableContext(2)]
	public interface IPinballMainButtonConfig
	{
		// Token: 0x170092FA RID: 37626
		// (get) Token: 0x0603FDFC RID: 261628
		// (set) Token: 0x0603FDFD RID: 261629
		EPinballMainButtonFunctionType Type { get; set; }

		// Token: 0x170092FB RID: 37627
		// (get) Token: 0x0603FDFE RID: 261630
		// (set) Token: 0x0603FDFF RID: 261631
		int UiRegisterId { get; set; }

		// Token: 0x170092FC RID: 37628
		// (get) Token: 0x0603FE00 RID: 261632
		// (set) Token: 0x0603FE01 RID: 261633
		int? FunctionId { get; set; }

		// Token: 0x170092FD RID: 37629
		// (get) Token: 0x0603FE02 RID: 261634
		// (set) Token: 0x0603FE03 RID: 261635
		ERedDotName? RedDotName { get; set; }

		// Token: 0x170092FE RID: 37630
		// (get) Token: 0x0603FE04 RID: 261636
		// (set) Token: 0x0603FE05 RID: 261637
		Func<bool> ShowRedDot { get; set; }

		// Token: 0x170092FF RID: 37631
		// (get) Token: 0x0603FE06 RID: 261638
		// (set) Token: 0x0603FE07 RID: 261639
		Action<UUIText> SetTextCallback { get; set; }

		// Token: 0x17009300 RID: 37632
		// (get) Token: 0x0603FE08 RID: 261640
		// (set) Token: 0x0603FE09 RID: 261641
		Action OnClickCallback { get; set; }

		// Token: 0x17009301 RID: 37633
		// (get) Token: 0x0603FE0A RID: 261642
		// (set) Token: 0x0603FE0B RID: 261643
		Func<bool> ShowCallback { get; set; }
	}
}
