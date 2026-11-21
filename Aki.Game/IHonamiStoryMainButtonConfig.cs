using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.HonamiStory;
using UnrealEngine;

// Token: 0x02001397 RID: 5015
[NullableContext(2)]
public interface IHonamiStoryMainButtonConfig
{
	// Token: 0x17001319 RID: 4889
	// (get) Token: 0x0600C6C7 RID: 50887
	// (set) Token: 0x0600C6C8 RID: 50888
	EHonamiStoryMainButtonFunctionType Type { get; set; }

	// Token: 0x1700131A RID: 4890
	// (get) Token: 0x0600C6C9 RID: 50889
	// (set) Token: 0x0600C6CA RID: 50890
	EHonamiStoryMainComponent ComponentId { get; set; }

	// Token: 0x1700131B RID: 4891
	// (get) Token: 0x0600C6CB RID: 50891
	// (set) Token: 0x0600C6CC RID: 50892
	EFunctionType? FunctionId { get; set; }

	// Token: 0x1700131C RID: 4892
	// (get) Token: 0x0600C6CD RID: 50893
	// (set) Token: 0x0600C6CE RID: 50894
	Func<bool> ShowRedDot { get; set; }

	// Token: 0x1700131D RID: 4893
	// (get) Token: 0x0600C6CF RID: 50895
	// (set) Token: 0x0600C6D0 RID: 50896
	Action<UUIText> SetTextCallback { get; set; }

	// Token: 0x1700131E RID: 4894
	// (get) Token: 0x0600C6D1 RID: 50897
	// (set) Token: 0x0600C6D2 RID: 50898
	Action OnClickCallback { get; set; }

	// Token: 0x1700131F RID: 4895
	// (get) Token: 0x0600C6D3 RID: 50899
	// (set) Token: 0x0600C6D4 RID: 50900
	Func<bool> ShowCallback { get; set; }

	// Token: 0x17001320 RID: 4896
	// (get) Token: 0x0600C6D5 RID: 50901
	// (set) Token: 0x0600C6D6 RID: 50902
	string SpecialSequenceName { get; set; }

	// Token: 0x17001321 RID: 4897
	// (get) Token: 0x0600C6D7 RID: 50903
	// (set) Token: 0x0600C6D8 RID: 50904
	string SpecialParamName { get; set; }
}
