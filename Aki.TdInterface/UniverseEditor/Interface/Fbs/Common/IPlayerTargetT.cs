using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200647D RID: 25725
	public class IPlayerTargetT
	{
		// Token: 0x1700BDCF RID: 48591
		// (get) Token: 0x0602BB68 RID: 179048 RVA: 0x005F29DE File Offset: 0x005F0BDE
		// (set) Token: 0x0602BB69 RID: 179049 RVA: 0x005F29E6 File Offset: 0x005F0BE6
		public ECommonTargetType Type { get; set; }

		// Token: 0x0602BB6A RID: 179050 RVA: 0x005F29EF File Offset: 0x005F0BEF
		public IPlayerTargetT()
		{
			this.Type = ECommonTargetType.Player;
		}
	}
}
