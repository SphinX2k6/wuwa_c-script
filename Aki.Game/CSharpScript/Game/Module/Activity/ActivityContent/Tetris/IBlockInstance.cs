using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02005FD2 RID: 24530
	public interface IBlockInstance
	{
		// Token: 0x17009004 RID: 36868
		// (get) Token: 0x0603E27D RID: 254589
		// (set) Token: 0x0603E27E RID: 254590
		int ConfigId { get; set; }

		// Token: 0x17009005 RID: 36869
		// (get) Token: 0x0603E27F RID: 254591
		// (set) Token: 0x0603E280 RID: 254592
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
		List<ValueTuple<int, int>> Offsets { [return: TupleElementNames(new string[]
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

		// Token: 0x17009006 RID: 36870
		// (get) Token: 0x0603E281 RID: 254593
		// (set) Token: 0x0603E282 RID: 254594
		int ColorId { get; set; }

		// Token: 0x17009007 RID: 36871
		// (get) Token: 0x0603E283 RID: 254595
		// (set) Token: 0x0603E284 RID: 254596
		EGemType GemType { get; set; }

		// Token: 0x17009008 RID: 36872
		// (get) Token: 0x0603E285 RID: 254597
		// (set) Token: 0x0603E286 RID: 254598
		EGemFillType GemFill { get; set; }

		// Token: 0x17009009 RID: 36873
		// (get) Token: 0x0603E287 RID: 254599
		// (set) Token: 0x0603E288 RID: 254600
		int GemOffSet { get; set; }
	}
}
