using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FF9 RID: 28665
	public class ISetGlobalTimeScaleTypeT
	{
		// Token: 0x1700D4F1 RID: 54513
		// (get) Token: 0x06032B4C RID: 207692 RVA: 0x006D781A File Offset: 0x006D5A1A
		// (set) Token: 0x06032B4D RID: 207693 RVA: 0x006D7822 File Offset: 0x006D5A22
		public ESetTimeScaleType Type { get; set; }

		// Token: 0x06032B4E RID: 207694 RVA: 0x006D782B File Offset: 0x006D5A2B
		public ISetGlobalTimeScaleTypeT()
		{
			this.Type = ESetTimeScaleType.Open;
		}
	}
}
