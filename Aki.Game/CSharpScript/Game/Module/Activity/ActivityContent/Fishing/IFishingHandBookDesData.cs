using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02006601 RID: 26113
	[NullableContext(1)]
	public interface IFishingHandBookDesData
	{
		// Token: 0x170095E6 RID: 38374
		// (get) Token: 0x06041724 RID: 268068
		// (set) Token: 0x06041725 RID: 268069
		string DesText { get; set; }

		// Token: 0x170095E7 RID: 38375
		// (get) Token: 0x06041726 RID: 268070
		// (set) Token: 0x06041727 RID: 268071
		string DataText { get; set; }

		// Token: 0x170095E8 RID: 38376
		// (get) Token: 0x06041728 RID: 268072
		// (set) Token: 0x06041729 RID: 268073
		bool? IsGolden { get; set; }

		// Token: 0x170095E9 RID: 38377
		// (get) Token: 0x0604172A RID: 268074
		// (set) Token: 0x0604172B RID: 268075
		bool? IsSliver { get; set; }
	}
}
