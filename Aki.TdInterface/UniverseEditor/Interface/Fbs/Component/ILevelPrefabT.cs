using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A69 RID: 23145
	public class ILevelPrefabT
	{
		// Token: 0x1700A87E RID: 43134
		// (get) Token: 0x06025E38 RID: 155192 RVA: 0x00531AB8 File Offset: 0x0052FCB8
		// (set) Token: 0x06025E39 RID: 155193 RVA: 0x00531AC0 File Offset: 0x0052FCC0
		public EModelType Type { get; set; }

		// Token: 0x1700A87F RID: 43135
		// (get) Token: 0x06025E3A RID: 155194 RVA: 0x00531AC9 File Offset: 0x0052FCC9
		// (set) Token: 0x06025E3B RID: 155195 RVA: 0x00531AD1 File Offset: 0x0052FCD1
		public ELevelPrefabBpType BlueprintPath { get; set; }

		// Token: 0x1700A880 RID: 43136
		// (get) Token: 0x06025E3C RID: 155196 RVA: 0x00531ADA File Offset: 0x0052FCDA
		// (set) Token: 0x06025E3D RID: 155197 RVA: 0x00531AE2 File Offset: 0x0052FCE2
		public string PrefabPath { get; set; }

		// Token: 0x1700A881 RID: 43137
		// (get) Token: 0x06025E3E RID: 155198 RVA: 0x00531AEB File Offset: 0x0052FCEB
		// (set) Token: 0x06025E3F RID: 155199 RVA: 0x00531AF3 File Offset: 0x0052FCF3
		public int NameOffsetZ { get; set; }

		// Token: 0x1700A882 RID: 43138
		// (get) Token: 0x06025E40 RID: 155200 RVA: 0x00531AFC File Offset: 0x0052FCFC
		// (set) Token: 0x06025E41 RID: 155201 RVA: 0x00531B04 File Offset: 0x0052FD04
		public List<IPrefabStateConfigT> PrefabStateList { get; set; }

		// Token: 0x1700A883 RID: 43139
		// (get) Token: 0x06025E42 RID: 155202 RVA: 0x00531B0D File Offset: 0x0052FD0D
		// (set) Token: 0x06025E43 RID: 155203 RVA: 0x00531B15 File Offset: 0x0052FD15
		public List<IPrefabEffectConfigT> EffectStateList { get; set; }

		// Token: 0x1700A884 RID: 43140
		// (get) Token: 0x06025E44 RID: 155204 RVA: 0x00531B1E File Offset: 0x0052FD1E
		// (set) Token: 0x06025E45 RID: 155205 RVA: 0x00531B26 File Offset: 0x0052FD26
		public byte NullMask { get; set; }

		// Token: 0x06025E46 RID: 155206 RVA: 0x00531B2F File Offset: 0x0052FD2F
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
