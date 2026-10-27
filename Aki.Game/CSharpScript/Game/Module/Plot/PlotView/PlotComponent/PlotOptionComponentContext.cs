using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.PlotView.PlotComponent
{
	// Token: 0x02005082 RID: 20610
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotOptionComponentContext
	{
		// Token: 0x1700806E RID: 32878
		// (get) Token: 0x06034CDD RID: 216285 RVA: 0x00C7DB9C File Offset: 0x00C7BD9C
		// (set) Token: 0x06034CDE RID: 216286 RVA: 0x00C7DBA4 File Offset: 0x00C7BDA4
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Action<ITalkOption[]> OptionsRefreshDelegate { [return: Nullable(new byte[]
		{
			2,
			1,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1,
			1
		})] set; }

		// Token: 0x1700806F RID: 32879
		// (get) Token: 0x06034CDF RID: 216287 RVA: 0x00C7DBAD File Offset: 0x00C7BDAD
		// (set) Token: 0x06034CE0 RID: 216288 RVA: 0x00C7DBB5 File Offset: 0x00C7BDB5
		public Action OptionsShowDelegate { get; set; }

		// Token: 0x17008070 RID: 32880
		// (get) Token: 0x06034CE1 RID: 216289 RVA: 0x00C7DBBE File Offset: 0x00C7BDBE
		// (set) Token: 0x06034CE2 RID: 216290 RVA: 0x00C7DBC6 File Offset: 0x00C7BDC6
		public Action OptionsHideDelegate { get; set; }
	}
}
