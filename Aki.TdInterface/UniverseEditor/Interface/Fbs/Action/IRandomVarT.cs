using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007583 RID: 30083
	public class IRandomVarT
	{
		// Token: 0x1700DD47 RID: 56647
		// (get) Token: 0x06034C5C RID: 216156 RVA: 0x00718B68 File Offset: 0x00716D68
		// (set) Token: 0x06034C5D RID: 216157 RVA: 0x00718B70 File Offset: 0x00716D70
		public TVarRefUnion LeftVar { get; set; }

		// Token: 0x1700DD48 RID: 56648
		// (get) Token: 0x06034C5E RID: 216158 RVA: 0x00718B79 File Offset: 0x00716D79
		// (set) Token: 0x06034C5F RID: 216159 RVA: 0x00718B81 File Offset: 0x00716D81
		public TVarRefUnion RightVar { get; set; }

		// Token: 0x1700DD49 RID: 56649
		// (get) Token: 0x06034C60 RID: 216160 RVA: 0x00718B8A File Offset: 0x00716D8A
		// (set) Token: 0x06034C61 RID: 216161 RVA: 0x00718B92 File Offset: 0x00716D92
		public TVarRefUnion Result { get; set; }

		// Token: 0x06034C62 RID: 216162 RVA: 0x00718B9B File Offset: 0x00716D9B
		public IRandomVarT()
		{
			this.LeftVar = null;
			this.RightVar = null;
			this.Result = null;
		}
	}
}
