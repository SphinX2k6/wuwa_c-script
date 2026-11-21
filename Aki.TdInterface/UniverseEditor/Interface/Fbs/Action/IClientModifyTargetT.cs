using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A57 RID: 27223
	public class IClientModifyTargetT
	{
		// Token: 0x1700C801 RID: 51201
		// (get) Token: 0x0602EB39 RID: 191289 RVA: 0x0065D966 File Offset: 0x0065BB66
		// (set) Token: 0x0602EB3A RID: 191290 RVA: 0x0065D96E File Offset: 0x0065BB6E
		public EClientModifyTargetType Type { get; set; }

		// Token: 0x0602EB3B RID: 191291 RVA: 0x0065D977 File Offset: 0x0065BB77
		public IClientModifyTargetT()
		{
			this.Type = EClientModifyTargetType.Self;
		}
	}
}
