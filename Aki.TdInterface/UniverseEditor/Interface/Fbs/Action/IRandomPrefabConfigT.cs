using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E05 RID: 28165
	public class IRandomPrefabConfigT
	{
		// Token: 0x1700D1F9 RID: 53753
		// (get) Token: 0x06031C33 RID: 203827 RVA: 0x006BCAF0 File Offset: 0x006BACF0
		// (set) Token: 0x06031C34 RID: 203828 RVA: 0x006BCAF8 File Offset: 0x006BACF8
		public ECreatePrefabType Type { get; set; }

		// Token: 0x1700D1FA RID: 53754
		// (get) Token: 0x06031C35 RID: 203829 RVA: 0x006BCB01 File Offset: 0x006BAD01
		// (set) Token: 0x06031C36 RID: 203830 RVA: 0x006BCB09 File Offset: 0x006BAD09
		public int RandomPrefabId { get; set; }

		// Token: 0x06031C37 RID: 203831 RVA: 0x006BCB12 File Offset: 0x006BAD12
		public IRandomPrefabConfigT()
		{
			this.Type = ECreatePrefabType.PrefabId;
			this.RandomPrefabId = 0;
		}
	}
}
