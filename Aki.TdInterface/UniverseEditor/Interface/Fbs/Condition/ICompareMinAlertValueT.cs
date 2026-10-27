using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BB7 RID: 19383
	public class ICompareMinAlertValueT
	{
		// Token: 0x17008CBB RID: 36027
		// (get) Token: 0x0601E934 RID: 125236 RVA: 0x00446C66 File Offset: 0x00444E66
		// (set) Token: 0x0601E935 RID: 125237 RVA: 0x00446C6E File Offset: 0x00444E6E
		public EComparedAlertValueType Type { get; set; }

		// Token: 0x0601E936 RID: 125238 RVA: 0x00446C77 File Offset: 0x00444E77
		public ICompareMinAlertValueT()
		{
			this.Type = EComparedAlertValueType.Min;
		}
	}
}
