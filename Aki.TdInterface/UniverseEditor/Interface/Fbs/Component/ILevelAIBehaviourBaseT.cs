using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054BF RID: 21695
	public class ILevelAIBehaviourBaseT
	{
		// Token: 0x17009FE0 RID: 40928
		// (get) Token: 0x06023C06 RID: 146438 RVA: 0x004F1746 File Offset: 0x004EF946
		// (set) Token: 0x06023C07 RID: 146439 RVA: 0x004F174E File Offset: 0x004EF94E
		public ELevelAIBehaviourType Type { get; set; }

		// Token: 0x06023C08 RID: 146440 RVA: 0x004F1757 File Offset: 0x004EF957
		public ILevelAIBehaviourBaseT()
		{
			this.Type = ELevelAIBehaviourType.Spline;
		}
	}
}
