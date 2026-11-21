using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A45 RID: 23109
	public class ILevelAIBehaviourBaseT
	{
		// Token: 0x1700A81A RID: 43034
		// (get) Token: 0x06025CBE RID: 154814 RVA: 0x0052E7BA File Offset: 0x0052C9BA
		// (set) Token: 0x06025CBF RID: 154815 RVA: 0x0052E7C2 File Offset: 0x0052C9C2
		public ELevelAIBehaviourType Type { get; set; }

		// Token: 0x06025CC0 RID: 154816 RVA: 0x0052E7CB File Offset: 0x0052C9CB
		public ILevelAIBehaviourBaseT()
		{
			this.Type = ELevelAIBehaviourType.Spline;
		}
	}
}
