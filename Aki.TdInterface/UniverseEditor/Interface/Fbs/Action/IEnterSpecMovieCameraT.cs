using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D4D RID: 27981
	public class IEnterSpecMovieCameraT
	{
		// Token: 0x1700CD3F RID: 52543
		// (get) Token: 0x06030446 RID: 197702 RVA: 0x0068F827 File Offset: 0x0068DA27
		// (set) Token: 0x06030447 RID: 197703 RVA: 0x0068F82F File Offset: 0x0068DA2F
		public EMovieCameraType Type { get; set; }

		// Token: 0x1700CD40 RID: 52544
		// (get) Token: 0x06030448 RID: 197704 RVA: 0x0068F838 File Offset: 0x0068DA38
		// (set) Token: 0x06030449 RID: 197705 RVA: 0x0068F840 File Offset: 0x0068DA40
		public string RowName { get; set; }

		// Token: 0x0603044A RID: 197706 RVA: 0x0068F849 File Offset: 0x0068DA49
		public IEnterSpecMovieCameraT()
		{
			this.Type = EMovieCameraType.Common;
			this.RowName = null;
		}
	}
}
