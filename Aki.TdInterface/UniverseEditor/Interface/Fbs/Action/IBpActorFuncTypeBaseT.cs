using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200621F RID: 25119
	public class IBpActorFuncTypeBaseT
	{
		// Token: 0x1700BB32 RID: 47922
		// (get) Token: 0x0602B4D0 RID: 177360 RVA: 0x005F69AE File Offset: 0x005F4BAE
		// (set) Token: 0x0602B4D1 RID: 177361 RVA: 0x005F69B6 File Offset: 0x005F4BB6
		public EBpActorFuncType Type { get; set; }

		// Token: 0x0602B4D2 RID: 177362 RVA: 0x005F69BF File Offset: 0x005F4BBF
		public IBpActorFuncTypeBaseT()
		{
			this.Type = EBpActorFuncType.CarPaintChange;
		}
	}
}
