using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004077 RID: 16503
	public class ITriggerShapeT
	{
		// Token: 0x17007062 RID: 28770
		// (get) Token: 0x06016B7F RID: 93055 RVA: 0x0033F12A File Offset: 0x0033D32A
		// (set) Token: 0x06016B80 RID: 93056 RVA: 0x0033F132 File Offset: 0x0033D332
		public ETriggerShape Type { get; set; }

		// Token: 0x06016B81 RID: 93057 RVA: 0x0033F13B File Offset: 0x0033D33B
		public ITriggerShapeT()
		{
			this.Type = ETriggerShape.Box;
		}
	}
}
