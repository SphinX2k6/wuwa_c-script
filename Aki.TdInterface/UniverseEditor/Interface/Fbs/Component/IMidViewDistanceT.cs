using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AE4 RID: 23268
	public class IMidViewDistanceT
	{
		// Token: 0x1700A9C4 RID: 43460
		// (get) Token: 0x06026368 RID: 156520 RVA: 0x0053C8C6 File Offset: 0x0053AAC6
		// (set) Token: 0x06026369 RID: 156521 RVA: 0x0053C8CE File Offset: 0x0053AACE
		public EViewDistanceType Type { get; set; }

		// Token: 0x0602636A RID: 156522 RVA: 0x0053C8D7 File Offset: 0x0053AAD7
		public IMidViewDistanceT()
		{
			this.Type = EViewDistanceType.Low;
		}
	}
}
