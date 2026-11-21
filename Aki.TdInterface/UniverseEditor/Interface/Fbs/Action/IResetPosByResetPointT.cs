using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007628 RID: 30248
	public class IResetPosByResetPointT
	{
		// Token: 0x1700DE3B RID: 56891
		// (get) Token: 0x0603513F RID: 217407 RVA: 0x0072104A File Offset: 0x0071F24A
		// (set) Token: 0x06035140 RID: 217408 RVA: 0x00721052 File Offset: 0x0071F252
		public EResetPosType Type { get; set; }

		// Token: 0x06035141 RID: 217409 RVA: 0x0072105B File Offset: 0x0071F25B
		public IResetPosByResetPointT()
		{
			this.Type = EResetPosType.PosEntity;
		}
	}
}
