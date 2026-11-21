using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Flow
{
	// Token: 0x020063CD RID: 25549
	[NullableContext(1)]
	public interface ITalkItem
	{
		// Token: 0x170075B9 RID: 30137
		// (get) Token: 0x0603DF5E RID: 253790
		// (set) Token: 0x0603DF5F RID: 253791
		int Id { get; set; }

		// Token: 0x170075BA RID: 30138
		// (get) Token: 0x0603DF60 RID: 253792
		// (set) Token: 0x0603DF61 RID: 253793
		string Name { get; set; }

		// Token: 0x170075BB RID: 30139
		// (get) Token: 0x0603DF62 RID: 253794
		// (set) Token: 0x0603DF63 RID: 253795
		int WhoId { get; set; }

		// Token: 0x170075BC RID: 30140
		// (get) Token: 0x0603DF64 RID: 253796
		// (set) Token: 0x0603DF65 RID: 253797
		int TextId { get; set; }

		// Token: 0x170075BD RID: 30141
		// (get) Token: 0x0603DF66 RID: 253798
		// (set) Token: 0x0603DF67 RID: 253799
		double? WaitTime { get; set; }

		// Token: 0x170075BE RID: 30142
		// (get) Token: 0x0603DF68 RID: 253800
		// (set) Token: 0x0603DF69 RID: 253801
		[Nullable(new byte[]
		{
			2,
			1
		})]
		IActionInfo[] Actions { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x170075BF RID: 30143
		// (get) Token: 0x0603DF6A RID: 253802
		// (set) Token: 0x0603DF6B RID: 253803
		[Nullable(new byte[]
		{
			2,
			1
		})]
		ITalkOption[] Options { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }
	}
}
