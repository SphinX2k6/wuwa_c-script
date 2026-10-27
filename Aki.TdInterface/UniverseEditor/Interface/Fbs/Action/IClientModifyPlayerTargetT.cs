using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063D1 RID: 25553
	public class IClientModifyPlayerTargetT
	{
		// Token: 0x1700BE61 RID: 48737
		// (get) Token: 0x0602C33F RID: 181055 RVA: 0x006117EA File Offset: 0x0060F9EA
		// (set) Token: 0x0602C340 RID: 181056 RVA: 0x006117F2 File Offset: 0x0060F9F2
		public EClientModifyTargetType Type { get; set; }

		// Token: 0x0602C341 RID: 181057 RVA: 0x006117FB File Offset: 0x0060F9FB
		public IClientModifyPlayerTargetT()
		{
			this.Type = EClientModifyTargetType.Self;
		}
	}
}
