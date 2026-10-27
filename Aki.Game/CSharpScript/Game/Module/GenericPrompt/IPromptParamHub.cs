using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.GenericPrompt
{
	// Token: 0x02005994 RID: 22932
	[NullableContext(2)]
	public interface IPromptParamHub
	{
		// Token: 0x17008B75 RID: 35701
		// (get) Token: 0x0603A30B RID: 238347
		// (set) Token: 0x0603A30C RID: 238348
		int TypeId { get; set; }

		// Token: 0x17008B76 RID: 35702
		// (get) Token: 0x0603A30D RID: 238349
		// (set) Token: 0x0603A30E RID: 238350
		TableTextArgNew MainTextObj { get; set; }

		// Token: 0x17008B77 RID: 35703
		// (get) Token: 0x0603A30F RID: 238351
		// (set) Token: 0x0603A310 RID: 238352
		TableTextArgNew ExtraTextObj { get; set; }

		// Token: 0x17008B78 RID: 35704
		// (get) Token: 0x0603A311 RID: 238353
		// (set) Token: 0x0603A312 RID: 238354
		int? PromptId { get; set; }

		// Token: 0x17008B79 RID: 35705
		// (get) Token: 0x0603A313 RID: 238355
		// (set) Token: 0x0603A314 RID: 238356
		[Nullable(new byte[]
		{
			2,
			1
		})]
		IReadOnlyList<object> MainTextParams { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17008B7A RID: 35706
		// (get) Token: 0x0603A315 RID: 238357
		// (set) Token: 0x0603A316 RID: 238358
		[Nullable(new byte[]
		{
			2,
			1
		})]
		IReadOnlyList<object> ExtraTextParams { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17008B7B RID: 35707
		// (get) Token: 0x0603A317 RID: 238359
		// (set) Token: 0x0603A318 RID: 238360
		Action CloseCallback { get; set; }

		// Token: 0x17008B7C RID: 35708
		// (get) Token: 0x0603A319 RID: 238361
		// (set) Token: 0x0603A31A RID: 238362
		float? Duration { get; set; }

		// Token: 0x17008B7D RID: 35709
		// (get) Token: 0x0603A31B RID: 238363
		// (set) Token: 0x0603A31C RID: 238364
		string PromptKey { get; set; }

		// Token: 0x17008B7E RID: 35710
		// (get) Token: 0x0603A31D RID: 238365
		object ExtraParamObj { get; }
	}
}
