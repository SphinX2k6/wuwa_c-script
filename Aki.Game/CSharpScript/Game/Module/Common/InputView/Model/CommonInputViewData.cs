using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Common.InputView.Model
{
	// Token: 0x02005B80 RID: 23424
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonInputViewData : ICommonInputViewData
	{
		// Token: 0x17008CC6 RID: 36038
		// (get) Token: 0x0603B44F RID: 242767 RVA: 0x00E207FF File Offset: 0x00E1E9FF
		// (set) Token: 0x0603B450 RID: 242768 RVA: 0x00E20807 File Offset: 0x00E1EA07
		public TableTextArgNew TitleTextArgs { get; set; }

		// Token: 0x17008CC7 RID: 36039
		// (get) Token: 0x0603B451 RID: 242769 RVA: 0x00E20810 File Offset: 0x00E1EA10
		// (set) Token: 0x0603B452 RID: 242770 RVA: 0x00E20818 File Offset: 0x00E1EA18
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

		// Token: 0x17008CC8 RID: 36040
		// (get) Token: 0x0603B453 RID: 242771 RVA: 0x00E20821 File Offset: 0x00E1EA21
		// (set) Token: 0x0603B454 RID: 242772 RVA: 0x00E20829 File Offset: 0x00E1EA29
		public string InputText { get; set; }

		// Token: 0x17008CC9 RID: 36041
		// (get) Token: 0x0603B455 RID: 242773 RVA: 0x00E20832 File Offset: 0x00E1EA32
		// (set) Token: 0x0603B456 RID: 242774 RVA: 0x00E2083A File Offset: 0x00E1EA3A
		public string DefaultText { get; set; }

		// Token: 0x17008CCA RID: 36042
		// (get) Token: 0x0603B457 RID: 242775 RVA: 0x00E20843 File Offset: 0x00E1EA43
		// (set) Token: 0x0603B458 RID: 242776 RVA: 0x00E2084B File Offset: 0x00E1EA4B
		public bool IsCheckNone { get; set; }

		// Token: 0x17008CCB RID: 36043
		// (get) Token: 0x0603B459 RID: 242777 RVA: 0x00E20854 File Offset: 0x00E1EA54
		// (set) Token: 0x0603B45A RID: 242778 RVA: 0x00E2085C File Offset: 0x00E1EA5C
		public bool NeedFunctionButton { get; set; }

		// Token: 0x17008CCC RID: 36044
		// (get) Token: 0x0603B45B RID: 242779 RVA: 0x00E20865 File Offset: 0x00E1EA65
		// (set) Token: 0x0603B45C RID: 242780 RVA: 0x00E2086D File Offset: 0x00E1EA6D
		public string BottomTipsText { get; set; }

		// Token: 0x17008CCD RID: 36045
		// (get) Token: 0x0603B45D RID: 242781 RVA: 0x00E20876 File Offset: 0x00E1EA76
		// (set) Token: 0x0603B45E RID: 242782 RVA: 0x00E2087E File Offset: 0x00E1EA7E
		[Nullable(2)]
		public string BottomTipsColor { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17008CCE RID: 36046
		// (get) Token: 0x0603B45F RID: 242783 RVA: 0x00E20887 File Offset: 0x00E1EA87
		// (set) Token: 0x0603B460 RID: 242784 RVA: 0x00E2088F File Offset: 0x00E1EA8F
		public bool? NeedCheckBlank { get; set; }
	}
}
