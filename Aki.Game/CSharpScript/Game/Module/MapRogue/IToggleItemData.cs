using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055CE RID: 21966
	[NullableContext(1)]
	public interface IToggleItemData
	{
		// Token: 0x170086EA RID: 34538
		// (get) Token: 0x06037FB0 RID: 229296
		// (set) Token: 0x06037FB1 RID: 229297
		int Id { get; set; }

		// Token: 0x170086EB RID: 34539
		// (get) Token: 0x06037FB2 RID: 229298
		// (set) Token: 0x06037FB3 RID: 229299
		string Icon { get; set; }

		// Token: 0x170086EC RID: 34540
		// (get) Token: 0x06037FB4 RID: 229300
		// (set) Token: 0x06037FB5 RID: 229301
		string TitleId { get; set; }

		// Token: 0x170086ED RID: 34541
		// (get) Token: 0x06037FB6 RID: 229302
		// (set) Token: 0x06037FB7 RID: 229303
		string DescId { get; set; }

		// Token: 0x170086EE RID: 34542
		// (get) Token: 0x06037FB8 RID: 229304
		// (set) Token: 0x06037FB9 RID: 229305
		[Nullable(new byte[]
		{
			2,
			1
		})]
		string[] DescParams { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x170086EF RID: 34543
		// (get) Token: 0x06037FBA RID: 229306
		// (set) Token: 0x06037FBB RID: 229307
		[Nullable(2)]
		string ProgressId { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x170086F0 RID: 34544
		// (get) Token: 0x06037FBC RID: 229308
		// (set) Token: 0x06037FBD RID: 229309
		[Nullable(new byte[]
		{
			2,
			1
		})]
		string[] ProgressParams { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x170086F1 RID: 34545
		// (get) Token: 0x06037FBE RID: 229310
		// (set) Token: 0x06037FBF RID: 229311
		bool IsDisabled { get; set; }
	}
}
