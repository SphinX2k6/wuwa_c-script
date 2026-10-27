using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054E3 RID: 21731
	public class ILevelPrefabT
	{
		// Token: 0x1700A044 RID: 41028
		// (get) Token: 0x06023D80 RID: 146816 RVA: 0x004F4A44 File Offset: 0x004F2C44
		// (set) Token: 0x06023D81 RID: 146817 RVA: 0x004F4A4C File Offset: 0x004F2C4C
		public EModelType Type { get; set; }

		// Token: 0x1700A045 RID: 41029
		// (get) Token: 0x06023D82 RID: 146818 RVA: 0x004F4A55 File Offset: 0x004F2C55
		// (set) Token: 0x06023D83 RID: 146819 RVA: 0x004F4A5D File Offset: 0x004F2C5D
		public ELevelPrefabBpType BlueprintPath { get; set; }

		// Token: 0x1700A046 RID: 41030
		// (get) Token: 0x06023D84 RID: 146820 RVA: 0x004F4A66 File Offset: 0x004F2C66
		// (set) Token: 0x06023D85 RID: 146821 RVA: 0x004F4A6E File Offset: 0x004F2C6E
		public string PrefabPath { get; set; }

		// Token: 0x1700A047 RID: 41031
		// (get) Token: 0x06023D86 RID: 146822 RVA: 0x004F4A77 File Offset: 0x004F2C77
		// (set) Token: 0x06023D87 RID: 146823 RVA: 0x004F4A7F File Offset: 0x004F2C7F
		public int NameOffsetZ { get; set; }

		// Token: 0x1700A048 RID: 41032
		// (get) Token: 0x06023D88 RID: 146824 RVA: 0x004F4A88 File Offset: 0x004F2C88
		// (set) Token: 0x06023D89 RID: 146825 RVA: 0x004F4A90 File Offset: 0x004F2C90
		public List<IPrefabStateConfigT> PrefabStateList { get; set; }

		// Token: 0x1700A049 RID: 41033
		// (get) Token: 0x06023D8A RID: 146826 RVA: 0x004F4A99 File Offset: 0x004F2C99
		// (set) Token: 0x06023D8B RID: 146827 RVA: 0x004F4AA1 File Offset: 0x004F2CA1
		public List<IPrefabEffectConfigT> EffectStateList { get; set; }

		// Token: 0x1700A04A RID: 41034
		// (get) Token: 0x06023D8C RID: 146828 RVA: 0x004F4AAA File Offset: 0x004F2CAA
		// (set) Token: 0x06023D8D RID: 146829 RVA: 0x004F4AB2 File Offset: 0x004F2CB2
		public byte NullMask { get; set; }

		// Token: 0x06023D8E RID: 146830 RVA: 0x004F4ABB File Offset: 0x004F2CBB
		public ILevelPrefabT()
		{
			this.Type = EModelType.LevelPrefab;
			this.BlueprintPath = ELevelPrefabBpType.Item;
			this.PrefabPath = null;
			this.NameOffsetZ = 0;
			this.PrefabStateList = null;
			this.EffectStateList = null;
			this.NullMask = 0;
		}
	}
}
