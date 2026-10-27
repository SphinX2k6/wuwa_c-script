using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.GenericPrompt
{
	// Token: 0x02005995 RID: 22933
	[NullableContext(2)]
	[Nullable(0)]
	public class PromptParamHub<T> : IPromptParamHub
	{
		// Token: 0x17008B7F RID: 35711
		// (get) Token: 0x0603A31E RID: 238366 RVA: 0x00DD4BA3 File Offset: 0x00DD2DA3
		// (set) Token: 0x0603A31F RID: 238367 RVA: 0x00DD4BAB File Offset: 0x00DD2DAB
		public int TypeId { get; set; }

		// Token: 0x17008B80 RID: 35712
		// (get) Token: 0x0603A320 RID: 238368 RVA: 0x00DD4BB4 File Offset: 0x00DD2DB4
		// (set) Token: 0x0603A321 RID: 238369 RVA: 0x00DD4BBC File Offset: 0x00DD2DBC
		public TableTextArgNew MainTextObj { get; set; }

		// Token: 0x17008B81 RID: 35713
		// (get) Token: 0x0603A322 RID: 238370 RVA: 0x00DD4BC5 File Offset: 0x00DD2DC5
		// (set) Token: 0x0603A323 RID: 238371 RVA: 0x00DD4BCD File Offset: 0x00DD2DCD
		public TableTextArgNew ExtraTextObj { get; set; }

		// Token: 0x17008B82 RID: 35714
		// (get) Token: 0x0603A324 RID: 238372 RVA: 0x00DD4BD6 File Offset: 0x00DD2DD6
		// (set) Token: 0x0603A325 RID: 238373 RVA: 0x00DD4BDE File Offset: 0x00DD2DDE
		public int? PromptId { get; set; }

		// Token: 0x17008B83 RID: 35715
		// (get) Token: 0x0603A326 RID: 238374 RVA: 0x00DD4BE7 File Offset: 0x00DD2DE7
		// (set) Token: 0x0603A327 RID: 238375 RVA: 0x00DD4BEF File Offset: 0x00DD2DEF
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

		// Token: 0x17008B84 RID: 35716
		// (get) Token: 0x0603A328 RID: 238376 RVA: 0x00DD4BF8 File Offset: 0x00DD2DF8
		// (set) Token: 0x0603A329 RID: 238377 RVA: 0x00DD4C00 File Offset: 0x00DD2E00
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

		// Token: 0x17008B85 RID: 35717
		// (get) Token: 0x0603A32A RID: 238378 RVA: 0x00DD4C09 File Offset: 0x00DD2E09
		// (set) Token: 0x0603A32B RID: 238379 RVA: 0x00DD4C11 File Offset: 0x00DD2E11
		public Action CloseCallback { get; set; }

		// Token: 0x17008B86 RID: 35718
		// (get) Token: 0x0603A32C RID: 238380 RVA: 0x00DD4C1A File Offset: 0x00DD2E1A
		// (set) Token: 0x0603A32D RID: 238381 RVA: 0x00DD4C22 File Offset: 0x00DD2E22
		public float? Duration { get; set; }

		// Token: 0x17008B87 RID: 35719
		// (get) Token: 0x0603A32E RID: 238382 RVA: 0x00DD4C2B File Offset: 0x00DD2E2B
		// (set) Token: 0x0603A32F RID: 238383 RVA: 0x00DD4C33 File Offset: 0x00DD2E33
		public string PromptKey { get; set; }

		// Token: 0x17008B88 RID: 35720
		// (get) Token: 0x0603A330 RID: 238384 RVA: 0x00DD4C3C File Offset: 0x00DD2E3C
		// (set) Token: 0x0603A331 RID: 238385 RVA: 0x00DD4C44 File Offset: 0x00DD2E44
		public T ExtraParam { get; set; }

		// Token: 0x17008B89 RID: 35721
		// (get) Token: 0x0603A332 RID: 238386 RVA: 0x00DD4C4D File Offset: 0x00DD2E4D
		public object ExtraParamObj
		{
			get
			{
				return this.ExtraParam;
			}
		}
	}
}
