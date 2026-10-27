using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007128 RID: 28968
	public class ISkillBlackboardVectorT
	{
		// Token: 0x1700D754 RID: 55124
		// (get) Token: 0x060335CF RID: 210383 RVA: 0x006EC657 File Offset: 0x006EA857
		// (set) Token: 0x060335D0 RID: 210384 RVA: 0x006EC65F File Offset: 0x006EA85F
		public string Key { get; set; }

		// Token: 0x1700D755 RID: 55125
		// (get) Token: 0x060335D1 RID: 210385 RVA: 0x006EC668 File Offset: 0x006EA868
		// (set) Token: 0x060335D2 RID: 210386 RVA: 0x006EC670 File Offset: 0x006EA870
		public IVectorInfoT Value { get; set; }

		// Token: 0x060335D3 RID: 210387 RVA: 0x006EC679 File Offset: 0x006EA879
		public ISkillBlackboardVectorT()
		{
			this.Key = null;
			this.Value = null;
		}
	}
}
