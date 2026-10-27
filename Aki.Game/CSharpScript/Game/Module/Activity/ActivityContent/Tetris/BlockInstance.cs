using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02005FD3 RID: 24531
	public class BlockInstance : IBlockInstance
	{
		// Token: 0x1700900A RID: 36874
		// (get) Token: 0x0603E289 RID: 254601 RVA: 0x00F02B0A File Offset: 0x00F00D0A
		// (set) Token: 0x0603E28A RID: 254602 RVA: 0x00F02B12 File Offset: 0x00F00D12
		public int ConfigId { get; set; }

		// Token: 0x1700900B RID: 36875
		// (get) Token: 0x0603E28B RID: 254603 RVA: 0x00F02B1B File Offset: 0x00F00D1B
		// (set) Token: 0x0603E28C RID: 254604 RVA: 0x00F02B23 File Offset: 0x00F00D23
		[TupleElementNames(new string[]
		{
			"Row",
			"Column"
		})]
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public List<ValueTuple<int, int>> Offsets { [return: TupleElementNames(new string[]
		{
			"Row",
			"Column"
		})] [return: Nullable(new byte[]
		{
			1,
			0
		})] get; [param: TupleElementNames(new string[]
		{
			"Row",
			"Column"
		})] [param: Nullable(new byte[]
		{
			1,
			0
		})] set; }

		// Token: 0x1700900C RID: 36876
		// (get) Token: 0x0603E28D RID: 254605 RVA: 0x00F02B2C File Offset: 0x00F00D2C
		// (set) Token: 0x0603E28E RID: 254606 RVA: 0x00F02B34 File Offset: 0x00F00D34
		public int ColorId { get; set; }

		// Token: 0x1700900D RID: 36877
		// (get) Token: 0x0603E28F RID: 254607 RVA: 0x00F02B3D File Offset: 0x00F00D3D
		// (set) Token: 0x0603E290 RID: 254608 RVA: 0x00F02B45 File Offset: 0x00F00D45
		public EGemType GemType { get; set; }

		// Token: 0x1700900E RID: 36878
		// (get) Token: 0x0603E291 RID: 254609 RVA: 0x00F02B4E File Offset: 0x00F00D4E
		// (set) Token: 0x0603E292 RID: 254610 RVA: 0x00F02B56 File Offset: 0x00F00D56
		public EGemFillType GemFill { get; set; }

		// Token: 0x1700900F RID: 36879
		// (get) Token: 0x0603E293 RID: 254611 RVA: 0x00F02B5F File Offset: 0x00F00D5F
		// (set) Token: 0x0603E294 RID: 254612 RVA: 0x00F02B67 File Offset: 0x00F00D67
		public int GemOffSet { get; set; }
	}
}
