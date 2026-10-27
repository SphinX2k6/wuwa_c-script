using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054E6 RID: 21734
	public class ILevelPrefabParamsConfigT
	{
		// Token: 0x1700A04E RID: 41038
		// (get) Token: 0x06023DAB RID: 146859 RVA: 0x004F508B File Offset: 0x004F328B
		// (set) Token: 0x06023DAC RID: 146860 RVA: 0x004F5093 File Offset: 0x004F3293
		public string ReferenceActorKey { get; set; }

		// Token: 0x1700A04F RID: 41039
		// (get) Token: 0x06023DAD RID: 146861 RVA: 0x004F509C File Offset: 0x004F329C
		// (set) Token: 0x06023DAE RID: 146862 RVA: 0x004F50A4 File Offset: 0x004F32A4
		public TParamsPresetUnion Params { get; set; }

		// Token: 0x06023DAF RID: 146863 RVA: 0x004F50AD File Offset: 0x004F32AD
		public ILevelPrefabParamsConfigT()
		{
			this.ReferenceActorKey = null;
			this.Params = null;
		}
	}
}
