using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.HonamiStory;
using UnrealEngine;

// Token: 0x02001ED5 RID: 7893
[NullableContext(2)]
public interface IHonamiStoryMainButtonConfig
{
	// Token: 0x170012EF RID: 4847
	// (get) Token: 0x0600F2A8 RID: 62120
	// (set) Token: 0x0600F2A9 RID: 62121
	EHonamiStoryMainButtonFunctionType Type { get; set; }

	// Token: 0x170012F0 RID: 4848
	// (get) Token: 0x0600F2AA RID: 62122
	// (set) Token: 0x0600F2AB RID: 62123
	EHonamiStoryMainComponent ComponentId { get; set; }

	// Token: 0x170012F1 RID: 4849
	// (get) Token: 0x0600F2AC RID: 62124
	// (set) Token: 0x0600F2AD RID: 62125
	EFunctionType? FunctionId { get; set; }

	// Token: 0x170012F2 RID: 4850
	// (get) Token: 0x0600F2AE RID: 62126
	// (set) Token: 0x0600F2AF RID: 62127
	Func<bool> ShowRedDot { get; set; }

	// Token: 0x170012F3 RID: 4851
	// (get) Token: 0x0600F2B0 RID: 62128
	// (set) Token: 0x0600F2B1 RID: 62129
	Action<UUIText> SetTextCallback { get; set; }

	// Token: 0x170012F4 RID: 4852
	// (get) Token: 0x0600F2B2 RID: 62130
	// (set) Token: 0x0600F2B3 RID: 62131
	Action OnClickCallback { get; set; }

	// Token: 0x170012F5 RID: 4853
	// (get) Token: 0x0600F2B4 RID: 62132
	// (set) Token: 0x0600F2B5 RID: 62133
	Func<bool> ShowCallback { get; set; }

	// Token: 0x170012F6 RID: 4854
	// (get) Token: 0x0600F2B6 RID: 62134
	// (set) Token: 0x0600F2B7 RID: 62135
	string SpecialSequenceName { get; set; }

	// Token: 0x170012F7 RID: 4855
	// (get) Token: 0x0600F2B8 RID: 62136
	// (set) Token: 0x0600F2B9 RID: 62137
	string SpecialParamName { get; set; }
}
