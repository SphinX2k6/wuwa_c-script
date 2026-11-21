using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005467 RID: 21607
	public class IBuildingBlockFoundationT
	{
		// Token: 0x170099AC RID: 39340
		// (get) Token: 0x06021F03 RID: 139011 RVA: 0x004AD736 File Offset: 0x004AB936
		// (set) Token: 0x06021F04 RID: 139012 RVA: 0x004AD73E File Offset: 0x004AB93E
		public EItemFoundation Type { get; set; }

		// Token: 0x06021F05 RID: 139013 RVA: 0x004AD747 File Offset: 0x004AB947
		public IBuildingBlockFoundationT()
		{
			this.Type = EItemFoundation.CategoryMatching;
		}
	}
}
