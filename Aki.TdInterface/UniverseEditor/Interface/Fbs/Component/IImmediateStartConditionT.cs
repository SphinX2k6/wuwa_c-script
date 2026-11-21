using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005973 RID: 22899
	public class IImmediateStartConditionT
	{
		// Token: 0x1700A65B RID: 42587
		// (get) Token: 0x06025543 RID: 152899 RVA: 0x0051FAC6 File Offset: 0x0051DCC6
		// (set) Token: 0x06025544 RID: 152900 RVA: 0x0051FACE File Offset: 0x0051DCCE
		public ESpawnMonsterStartCondition Type { get; set; }

		// Token: 0x06025545 RID: 152901 RVA: 0x0051FAD7 File Offset: 0x0051DCD7
		public IImmediateStartConditionT()
		{
			this.Type = ESpawnMonsterStartCondition.Immediate;
		}
	}
}
