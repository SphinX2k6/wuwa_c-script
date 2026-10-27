using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004C1 RID: 1217
	[NullableContext(1)]
	[Nullable(0)]
	public class ILevelPrefab_SetValue
	{
		// Token: 0x0400124A RID: 4682
		public EModelType Type;

		// Token: 0x0400124B RID: 4683
		public ELevelPrefabBpType BlueprintPath;

		// Token: 0x0400124C RID: 4684
		public string PrefabPath;

		// Token: 0x0400124D RID: 4685
		public int? NameOffsetZ;

		// Token: 0x0400124E RID: 4686
		public List<IPrefabStateConfig> PrefabStateList;

		// Token: 0x0400124F RID: 4687
		public List<IPrefabEffectConfig> EffectStateList;
	}
}
