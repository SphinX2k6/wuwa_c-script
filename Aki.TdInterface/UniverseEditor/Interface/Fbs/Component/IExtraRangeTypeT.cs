using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005217 RID: 21015
	public class IExtraRangeTypeT
	{
		// Token: 0x170099EF RID: 39407
		// (get) Token: 0x06022278 RID: 139896 RVA: 0x004BD1D6 File Offset: 0x004BB3D6
		// (set) Token: 0x06022279 RID: 139897 RVA: 0x004BD1DE File Offset: 0x004BB3DE
		public EExtraRangeType Type { get; set; }

		// Token: 0x0602227A RID: 139898 RVA: 0x004BD1E7 File Offset: 0x004BB3E7
		public IExtraRangeTypeT()
		{
			this.Type = EExtraRangeType.SunSpiritBlock;
		}
	}
}
