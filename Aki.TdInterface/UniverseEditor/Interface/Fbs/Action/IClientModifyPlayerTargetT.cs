using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A51 RID: 27217
	public class IClientModifyPlayerTargetT
	{
		// Token: 0x1700C7FB RID: 51195
		// (get) Token: 0x0602EB15 RID: 191253 RVA: 0x0065D676 File Offset: 0x0065B876
		// (set) Token: 0x0602EB16 RID: 191254 RVA: 0x0065D67E File Offset: 0x0065B87E
		public EClientModifyTargetType Type { get; set; }

		// Token: 0x0602EB17 RID: 191255 RVA: 0x0065D687 File Offset: 0x0065B887
		public IClientModifyPlayerTargetT()
		{
			this.Type = EClientModifyTargetType.Self;
		}
	}
}
