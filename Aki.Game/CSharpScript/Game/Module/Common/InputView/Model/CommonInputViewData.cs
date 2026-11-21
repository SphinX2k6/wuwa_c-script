using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Common.InputView.Model
{
	// Token: 0x02004B60 RID: 19296
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonInputViewData : ICommonInputViewData
	{
		// Token: 0x17006098 RID: 24728
		// (get) Token: 0x0603039C RID: 197532 RVA: 0x00D70D73 File Offset: 0x00D6EF73
		// (set) Token: 0x0603039D RID: 197533 RVA: 0x00D70D7B File Offset: 0x00D6EF7B
		public TableTextArgNew TitleTextArgs { get; set; }

		// Token: 0x17006099 RID: 24729
		// (get) Token: 0x0603039E RID: 197534 RVA: 0x00D70D84 File Offset: 0x00D6EF84
		// (set) Token: 0x0603039F RID: 197535 RVA: 0x00D70D8C File Offset: 0x00D6EF8C
		[Nullable(new byte[]
		{
			1,
			1,
			0
		})]
		public Func<string, UniTask<ErrorCode>> ConfirmFunc { [return: Nullable(new byte[]
		{
			1,
			1,
			0
		})] get; [param: Nullable(new byte[]
		{
			1,
			1,
			0
		})] set; }

		// Token: 0x1700609A RID: 24730
		// (get) Token: 0x060303A0 RID: 197536 RVA: 0x00D70D95 File Offset: 0x00D6EF95
		// (set) Token: 0x060303A1 RID: 197537 RVA: 0x00D70D9D File Offset: 0x00D6EF9D
		public string InputText { get; set; }

		// Token: 0x1700609B RID: 24731
		// (get) Token: 0x060303A2 RID: 197538 RVA: 0x00D70DA6 File Offset: 0x00D6EFA6
		// (set) Token: 0x060303A3 RID: 197539 RVA: 0x00D70DAE File Offset: 0x00D6EFAE
		public string DefaultText { get; set; }

		// Token: 0x1700609C RID: 24732
		// (get) Token: 0x060303A4 RID: 197540 RVA: 0x00D70DB7 File Offset: 0x00D6EFB7
		// (set) Token: 0x060303A5 RID: 197541 RVA: 0x00D70DBF File Offset: 0x00D6EFBF
		public bool IsCheckNone { get; set; }

		// Token: 0x1700609D RID: 24733
		// (get) Token: 0x060303A6 RID: 197542 RVA: 0x00D70DC8 File Offset: 0x00D6EFC8
		// (set) Token: 0x060303A7 RID: 197543 RVA: 0x00D70DD0 File Offset: 0x00D6EFD0
		public bool NeedFunctionButton { get; set; }

		// Token: 0x1700609E RID: 24734
		// (get) Token: 0x060303A8 RID: 197544 RVA: 0x00D70DD9 File Offset: 0x00D6EFD9
		// (set) Token: 0x060303A9 RID: 197545 RVA: 0x00D70DE1 File Offset: 0x00D6EFE1
		public string BottomTipsText { get; set; }

		// Token: 0x1700609F RID: 24735
		// (get) Token: 0x060303AA RID: 197546 RVA: 0x00D70DEA File Offset: 0x00D6EFEA
		// (set) Token: 0x060303AB RID: 197547 RVA: 0x00D70DF2 File Offset: 0x00D6EFF2
		[Nullable(2)]
		public string BottomTipsColor { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x170060A0 RID: 24736
		// (get) Token: 0x060303AC RID: 197548 RVA: 0x00D70DFB File Offset: 0x00D6EFFB
		// (set) Token: 0x060303AD RID: 197549 RVA: 0x00D70E03 File Offset: 0x00D6F003
		public bool? NeedCheckBlank { get; set; }
	}
}
