using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006707 RID: 26375
	public class IActorFaceExpressionTypeT
	{
		// Token: 0x1700BFBD RID: 49085
		// (get) Token: 0x0602CAA3 RID: 182947 RVA: 0x0061C836 File Offset: 0x0061AA36
		// (set) Token: 0x0602CAA4 RID: 182948 RVA: 0x0061C83E File Offset: 0x0061AA3E
		public EActorFaceExpressionType Type { get; set; }

		// Token: 0x0602CAA5 RID: 182949 RVA: 0x0061C847 File Offset: 0x0061AA47
		public IActorFaceExpressionTypeT()
		{
			this.Type = EActorFaceExpressionType.Play;
		}
	}
}
