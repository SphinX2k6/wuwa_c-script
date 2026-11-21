using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003FFC RID: 16380
	public class IBoxRangeT
	{
		// Token: 0x17006EF6 RID: 28406
		// (get) Token: 0x060166A9 RID: 91817 RVA: 0x00335A5C File Offset: 0x00333C5C
		// (set) Token: 0x060166AA RID: 91818 RVA: 0x00335A64 File Offset: 0x00333C64
		public ERangeType Type { get; set; }

		// Token: 0x17006EF7 RID: 28407
		// (get) Token: 0x060166AB RID: 91819 RVA: 0x00335A6D File Offset: 0x00333C6D
		// (set) Token: 0x060166AC RID: 91820 RVA: 0x00335A75 File Offset: 0x00333C75
		public IVectorInfoT Pos { get; set; }

		// Token: 0x17006EF8 RID: 28408
		// (get) Token: 0x060166AD RID: 91821 RVA: 0x00335A7E File Offset: 0x00333C7E
		// (set) Token: 0x060166AE RID: 91822 RVA: 0x00335A86 File Offset: 0x00333C86
		public IVectorInfoT Size { get; set; }

		// Token: 0x17006EF9 RID: 28409
		// (get) Token: 0x060166AF RID: 91823 RVA: 0x00335A8F File Offset: 0x00333C8F
		// (set) Token: 0x060166B0 RID: 91824 RVA: 0x00335A97 File Offset: 0x00333C97
		public IVectorInfoT Rotator { get; set; }

		// Token: 0x060166B1 RID: 91825 RVA: 0x00335AA0 File Offset: 0x00333CA0
		public IBoxRangeT()
		{
			this.Type = ERangeType.CircleRange;
			this.Pos = null;
			this.Size = null;
			this.Rotator = null;
		}
	}
}
