using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A6C RID: 23148
	public class ILevelPrefabParamsConfigT
	{
		// Token: 0x1700A888 RID: 43144
		// (get) Token: 0x06025E65 RID: 155237 RVA: 0x005321AF File Offset: 0x005303AF
		// (set) Token: 0x06025E66 RID: 155238 RVA: 0x005321B7 File Offset: 0x005303B7
		public string ReferenceActorKey { get; set; }

		// Token: 0x1700A889 RID: 43145
		// (get) Token: 0x06025E67 RID: 155239 RVA: 0x005321C0 File Offset: 0x005303C0
		// (set) Token: 0x06025E68 RID: 155240 RVA: 0x005321C8 File Offset: 0x005303C8
		public TParamsPresetUnion Params { get; set; }

		// Token: 0x06025E69 RID: 155241 RVA: 0x005321D1 File Offset: 0x005303D1
		public ILevelPrefabParamsConfigT()
		{
			this.ReferenceActorKey = null;
			this.Params = null;
		}
	}
}
