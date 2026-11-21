using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A54 RID: 27220
	public class IClientModifySelfTargetT
	{
		// Token: 0x1700C7FE RID: 51198
		// (get) Token: 0x0602EB27 RID: 191271 RVA: 0x0065D7EE File Offset: 0x0065B9EE
		// (set) Token: 0x0602EB28 RID: 191272 RVA: 0x0065D7F6 File Offset: 0x0065B9F6
		public EClientModifyTargetType Type { get; set; }

		// Token: 0x0602EB29 RID: 191273 RVA: 0x0065D7FF File Offset: 0x0065B9FF
		public IClientModifySelfTargetT()
		{
			this.Type = EClientModifyTargetType.Self;
		}
	}
}
