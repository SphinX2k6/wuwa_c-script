using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.GenericPrompt
{
	// Token: 0x0200496E RID: 18798
	[NullableContext(2)]
	[Nullable(0)]
	public class PromptParamHub<T> : IPromptParamHub
	{
		// Token: 0x17005F4C RID: 24396
		// (get) Token: 0x0602F244 RID: 193092 RVA: 0x00D24033 File Offset: 0x00D22233
		// (set) Token: 0x0602F245 RID: 193093 RVA: 0x00D2403B File Offset: 0x00D2223B
		public int TypeId { get; set; }

		// Token: 0x17005F4D RID: 24397
		// (get) Token: 0x0602F246 RID: 193094 RVA: 0x00D24044 File Offset: 0x00D22244
		// (set) Token: 0x0602F247 RID: 193095 RVA: 0x00D2404C File Offset: 0x00D2224C
		public TableTextArgNew MainTextObj { get; set; }

		// Token: 0x17005F4E RID: 24398
		// (get) Token: 0x0602F248 RID: 193096 RVA: 0x00D24055 File Offset: 0x00D22255
		// (set) Token: 0x0602F249 RID: 193097 RVA: 0x00D2405D File Offset: 0x00D2225D
		public TableTextArgNew ExtraTextObj { get; set; }

		// Token: 0x17005F4F RID: 24399
		// (get) Token: 0x0602F24A RID: 193098 RVA: 0x00D24066 File Offset: 0x00D22266
		// (set) Token: 0x0602F24B RID: 193099 RVA: 0x00D2406E File Offset: 0x00D2226E
		public int? PromptId { get; set; }

		// Token: 0x17005F50 RID: 24400
		// (get) Token: 0x0602F24C RID: 193100 RVA: 0x00D24077 File Offset: 0x00D22277
		// (set) Token: 0x0602F24D RID: 193101 RVA: 0x00D2407F File Offset: 0x00D2227F
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public IReadOnlyList<object> MainTextParams { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17005F51 RID: 24401
		// (get) Token: 0x0602F24E RID: 193102 RVA: 0x00D24088 File Offset: 0x00D22288
		// (set) Token: 0x0602F24F RID: 193103 RVA: 0x00D24090 File Offset: 0x00D22290
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public IReadOnlyList<object> ExtraTextParams { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17005F52 RID: 24402
		// (get) Token: 0x0602F250 RID: 193104 RVA: 0x00D24099 File Offset: 0x00D22299
		// (set) Token: 0x0602F251 RID: 193105 RVA: 0x00D240A1 File Offset: 0x00D222A1
		public Action CloseCallback { get; set; }

		// Token: 0x17005F53 RID: 24403
		// (get) Token: 0x0602F252 RID: 193106 RVA: 0x00D240AA File Offset: 0x00D222AA
		// (set) Token: 0x0602F253 RID: 193107 RVA: 0x00D240B2 File Offset: 0x00D222B2
		public float? Duration { get; set; }

		// Token: 0x17005F54 RID: 24404
		// (get) Token: 0x0602F254 RID: 193108 RVA: 0x00D240BB File Offset: 0x00D222BB
		// (set) Token: 0x0602F255 RID: 193109 RVA: 0x00D240C3 File Offset: 0x00D222C3
		public string PromptKey { get; set; }

		// Token: 0x17005F55 RID: 24405
		// (get) Token: 0x0602F256 RID: 193110 RVA: 0x00D240CC File Offset: 0x00D222CC
		// (set) Token: 0x0602F257 RID: 193111 RVA: 0x00D240D4 File Offset: 0x00D222D4
		public T ExtraParam { get; set; }

		// Token: 0x17005F56 RID: 24406
		// (get) Token: 0x0602F258 RID: 193112 RVA: 0x00D240DD File Offset: 0x00D222DD
		public object ExtraParamObj
		{
			get
			{
				return this.ExtraParam;
			}
		}
	}
}
