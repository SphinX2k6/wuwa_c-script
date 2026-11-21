using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B4D RID: 23373
	public class IMotorAutoEjectPositionEntityConfigT
	{
		// Token: 0x1700AA86 RID: 43654
		// (get) Token: 0x06026710 RID: 157456 RVA: 0x00543768 File Offset: 0x00541968
		// (set) Token: 0x06026711 RID: 157457 RVA: 0x00543770 File Offset: 0x00541970
		public EMotorAutoEjectType Type { get; set; }

		// Token: 0x1700AA87 RID: 43655
		// (get) Token: 0x06026712 RID: 157458 RVA: 0x00543779 File Offset: 0x00541979
		// (set) Token: 0x06026713 RID: 157459 RVA: 0x00543781 File Offset: 0x00541981
		public int EntityId { get; set; }

		// Token: 0x06026714 RID: 157460 RVA: 0x0054378A File Offset: 0x0054198A
		public IMotorAutoEjectPositionEntityConfigT()
		{
			this.Type = EMotorAutoEjectType.NextHook;
			this.EntityId = 0;
		}
	}
}
