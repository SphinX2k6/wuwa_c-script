using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068E9 RID: 26857
	public class IHideGroupTypeT
	{
		// Token: 0x1700C74A RID: 51018
		// (get) Token: 0x0602EDAB RID: 191915 RVA: 0x0066475E File Offset: 0x0066295E
		// (set) Token: 0x0602EDAC RID: 191916 RVA: 0x00664766 File Offset: 0x00662966
		public EHideType Type { get; set; }

		// Token: 0x0602EDAD RID: 191917 RVA: 0x0066476F File Offset: 0x0066296F
		public IHideGroupTypeT()
		{
			this.Type = EHideType.WorldMonsterAndMonsterTreasure;
		}
	}
}
