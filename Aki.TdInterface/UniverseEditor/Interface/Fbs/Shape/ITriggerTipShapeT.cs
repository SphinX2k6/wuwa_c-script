using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x0200407D RID: 16509
	public class ITriggerTipShapeT
	{
		// Token: 0x17007067 RID: 28775
		// (get) Token: 0x06016BB1 RID: 93105 RVA: 0x0033F63A File Offset: 0x0033D83A
		// (set) Token: 0x06016BB2 RID: 93106 RVA: 0x0033F642 File Offset: 0x0033D842
		public ETriggerTipShape Type { get; set; }

		// Token: 0x06016BB3 RID: 93107 RVA: 0x0033F64B File Offset: 0x0033D84B
		public ITriggerTipShapeT()
		{
			this.Type = ETriggerTipShape.Box;
		}
	}
}
