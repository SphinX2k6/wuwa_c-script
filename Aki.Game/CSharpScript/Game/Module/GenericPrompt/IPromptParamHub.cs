using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.GenericPrompt
{
	// Token: 0x0200496D RID: 18797
	[NullableContext(2)]
	public interface IPromptParamHub
	{
		// Token: 0x17005F42 RID: 24386
		// (get) Token: 0x0602F231 RID: 193073
		// (set) Token: 0x0602F232 RID: 193074
		int TypeId { get; set; }

		// Token: 0x17005F43 RID: 24387
		// (get) Token: 0x0602F233 RID: 193075
		// (set) Token: 0x0602F234 RID: 193076
		TableTextArgNew MainTextObj { get; set; }

		// Token: 0x17005F44 RID: 24388
		// (get) Token: 0x0602F235 RID: 193077
		// (set) Token: 0x0602F236 RID: 193078
		TableTextArgNew ExtraTextObj { get; set; }

		// Token: 0x17005F45 RID: 24389
		// (get) Token: 0x0602F237 RID: 193079
		// (set) Token: 0x0602F238 RID: 193080
		int? PromptId { get; set; }

		// Token: 0x17005F46 RID: 24390
		// (get) Token: 0x0602F239 RID: 193081
		// (set) Token: 0x0602F23A RID: 193082
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

		// Token: 0x17005F47 RID: 24391
		// (get) Token: 0x0602F23B RID: 193083
		// (set) Token: 0x0602F23C RID: 193084
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

		// Token: 0x17005F48 RID: 24392
		// (get) Token: 0x0602F23D RID: 193085
		// (set) Token: 0x0602F23E RID: 193086
		Action CloseCallback { get; set; }

		// Token: 0x17005F49 RID: 24393
		// (get) Token: 0x0602F23F RID: 193087
		// (set) Token: 0x0602F240 RID: 193088
		float? Duration { get; set; }

		// Token: 0x17005F4A RID: 24394
		// (get) Token: 0x0602F241 RID: 193089
		// (set) Token: 0x0602F242 RID: 193090
		string PromptKey { get; set; }

		// Token: 0x17005F4B RID: 24395
		// (get) Token: 0x0602F243 RID: 193091
		object ExtraParamObj { get; }
	}
}
