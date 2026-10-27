using System;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x02005211 RID: 21009
	public class CardAttributeData : ICardAttributeData
	{
		// Token: 0x17008206 RID: 33286
		// (get) Token: 0x06035BAB RID: 220075 RVA: 0x00CB86D8 File Offset: 0x00CB68D8
		// (set) Token: 0x06035BAC RID: 220076 RVA: 0x00CB86E0 File Offset: 0x00CB68E0
		public int Cost { get; set; }

		// Token: 0x17008207 RID: 33287
		// (get) Token: 0x06035BAD RID: 220077 RVA: 0x00CB86E9 File Offset: 0x00CB68E9
		// (set) Token: 0x06035BAE RID: 220078 RVA: 0x00CB86F1 File Offset: 0x00CB68F1
		public int Attack { get; set; }

		// Token: 0x17008208 RID: 33288
		// (get) Token: 0x06035BAF RID: 220079 RVA: 0x00CB86FA File Offset: 0x00CB68FA
		// (set) Token: 0x06035BB0 RID: 220080 RVA: 0x00CB8702 File Offset: 0x00CB6902
		public int Life { get; set; }
	}
}
