using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Container
{
	// Token: 0x02000155 RID: 341
	[NullableContext(1)]
	public interface IEulerStrokeJudge
	{
		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000BC6 RID: 3014
		// (set) Token: 0x06000BC7 RID: 3015
		EEulerStrokeKind Kind { get; set; }

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000BC8 RID: 3016
		// (set) Token: 0x06000BC9 RID: 3017
		bool CanDrawInOneStroke { get; set; }

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000BCA RID: 3018
		// (set) Token: 0x06000BCB RID: 3019
		bool Connected { get; set; }

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000BCC RID: 3020
		// (set) Token: 0x06000BCD RID: 3021
		List<int> OddNodeIds { get; set; }

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000BCE RID: 3022
		// (set) Token: 0x06000BCF RID: 3023
		int? SuggestedStartId { get; set; }
	}
}
