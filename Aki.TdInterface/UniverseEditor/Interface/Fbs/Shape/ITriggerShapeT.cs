using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C68 RID: 15464
	public class ITriggerShapeT
	{
		// Token: 0x17006AB1 RID: 27313
		// (get) Token: 0x0601566B RID: 87659 RVA: 0x0031828A File Offset: 0x0031648A
		// (set) Token: 0x0601566C RID: 87660 RVA: 0x00318292 File Offset: 0x00316492
		public ETriggerShape Type { get; set; }

		// Token: 0x0601566D RID: 87661 RVA: 0x0031829B File Offset: 0x0031649B
		public ITriggerShapeT()
		{
			this.Type = ETriggerShape.Box;
		}
	}
}
