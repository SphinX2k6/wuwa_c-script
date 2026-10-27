using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DC5 RID: 15813
	public class IDangoAbyssInformationBoardT
	{
		// Token: 0x17006D2A RID: 27946
		// (get) Token: 0x06016117 RID: 90391 RVA: 0x00330E3A File Offset: 0x0032F03A
		// (set) Token: 0x06016118 RID: 90392 RVA: 0x00330E42 File Offset: 0x0032F042
		public EInformationBoardType Type { get; set; }

		// Token: 0x06016119 RID: 90393 RVA: 0x00330E4B File Offset: 0x0032F04B
		public IDangoAbyssInformationBoardT()
		{
			this.Type = EInformationBoardType.DangoAbyss;
		}
	}
}
