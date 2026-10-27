using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A7B RID: 19067
	[NullableContext(2)]
	public interface ITrapDefenseMarkInfo
	{
		// Token: 0x17007AD6 RID: 31446
		// (get) Token: 0x06031699 RID: 202393
		// (set) Token: 0x0603169A RID: 202394
		int MarkId { get; set; }

		// Token: 0x17007AD7 RID: 31447
		// (get) Token: 0x0603169B RID: 202395
		// (set) Token: 0x0603169C RID: 202396
		TrapDefenseDefine.ETrapDefenseMarkType MarkType { get; set; }

		// Token: 0x17007AD8 RID: 31448
		// (get) Token: 0x0603169D RID: 202397
		// (set) Token: 0x0603169E RID: 202398
		object ExtraParam { get; set; }
	}
}
