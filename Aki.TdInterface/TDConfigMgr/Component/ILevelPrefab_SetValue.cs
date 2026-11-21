using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200051A RID: 1306
	public class ILevelPrefab_SetValue
	{
		// Token: 0x0400136C RID: 4972
		public EModelType Type;

		// Token: 0x0400136D RID: 4973
		public ELevelPrefabBpType BlueprintPath;

		// Token: 0x0400136E RID: 4974
		public string PrefabPath;

		// Token: 0x0400136F RID: 4975
		public int? NameOffsetZ;

		// Token: 0x04001370 RID: 4976
		public List<IPrefabStateConfig> PrefabStateList;

		// Token: 0x04001371 RID: 4977
		public List<IPrefabEffectConfig> EffectStateList;
	}
}
