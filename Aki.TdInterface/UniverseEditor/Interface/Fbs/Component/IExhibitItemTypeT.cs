using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051D5 RID: 20949
	public class IExhibitItemTypeT
	{
		// Token: 0x17009954 RID: 39252
		// (get) Token: 0x06021F92 RID: 139154 RVA: 0x004B67AE File Offset: 0x004B49AE
		// (set) Token: 0x06021F93 RID: 139155 RVA: 0x004B67B6 File Offset: 0x004B49B6
		public EExhibitItemType Type { get; set; }

		// Token: 0x06021F94 RID: 139156 RVA: 0x004B67BF File Offset: 0x004B49BF
		public IExhibitItemTypeT()
		{
			this.Type = EExhibitItemType.Phantom;
		}
	}
}
