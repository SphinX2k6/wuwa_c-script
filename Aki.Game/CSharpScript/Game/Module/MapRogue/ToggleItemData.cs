using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020045A5 RID: 17829
	[NullableContext(1)]
	[Nullable(0)]
	public class ToggleItemData : IToggleItemData
	{
		// Token: 0x17005AB9 RID: 23225
		// (get) Token: 0x0602CEBE RID: 183998 RVA: 0x00C90CCA File Offset: 0x00C8EECA
		// (set) Token: 0x0602CEBF RID: 183999 RVA: 0x00C90CD2 File Offset: 0x00C8EED2
		public int Id { get; set; }

		// Token: 0x17005ABA RID: 23226
		// (get) Token: 0x0602CEC0 RID: 184000 RVA: 0x00C90CDB File Offset: 0x00C8EEDB
		// (set) Token: 0x0602CEC1 RID: 184001 RVA: 0x00C90CE3 File Offset: 0x00C8EEE3
		public string Icon { get; set; }

		// Token: 0x17005ABB RID: 23227
		// (get) Token: 0x0602CEC2 RID: 184002 RVA: 0x00C90CEC File Offset: 0x00C8EEEC
		// (set) Token: 0x0602CEC3 RID: 184003 RVA: 0x00C90CF4 File Offset: 0x00C8EEF4
		public string TitleId { get; set; }

		// Token: 0x17005ABC RID: 23228
		// (get) Token: 0x0602CEC4 RID: 184004 RVA: 0x00C90CFD File Offset: 0x00C8EEFD
		// (set) Token: 0x0602CEC5 RID: 184005 RVA: 0x00C90D05 File Offset: 0x00C8EF05
		public string DescId { get; set; }

		// Token: 0x17005ABD RID: 23229
		// (get) Token: 0x0602CEC6 RID: 184006 RVA: 0x00C90D0E File Offset: 0x00C8EF0E
		// (set) Token: 0x0602CEC7 RID: 184007 RVA: 0x00C90D16 File Offset: 0x00C8EF16
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public string[] DescParams { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17005ABE RID: 23230
		// (get) Token: 0x0602CEC8 RID: 184008 RVA: 0x00C90D1F File Offset: 0x00C8EF1F
		// (set) Token: 0x0602CEC9 RID: 184009 RVA: 0x00C90D27 File Offset: 0x00C8EF27
		[Nullable(2)]
		public string ProgressId { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17005ABF RID: 23231
		// (get) Token: 0x0602CECA RID: 184010 RVA: 0x00C90D30 File Offset: 0x00C8EF30
		// (set) Token: 0x0602CECB RID: 184011 RVA: 0x00C90D38 File Offset: 0x00C8EF38
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public string[] ProgressParams { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17005AC0 RID: 23232
		// (get) Token: 0x0602CECC RID: 184012 RVA: 0x00C90D41 File Offset: 0x00C8EF41
		// (set) Token: 0x0602CECD RID: 184013 RVA: 0x00C90D49 File Offset: 0x00C8EF49
		public bool IsDisabled { get; set; }
	}
}
