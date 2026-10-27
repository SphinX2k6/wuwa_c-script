using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054BC RID: 21692
	public class ILetGoDestroyConditionT
	{
		// Token: 0x17009FDD RID: 40925
		// (get) Token: 0x06023BF4 RID: 146420 RVA: 0x004F15CE File Offset: 0x004EF7CE
		// (set) Token: 0x06023BF5 RID: 146421 RVA: 0x004F15D6 File Offset: 0x004EF7D6
		public ETeleControlDestroyCondition Type { get; set; }

		// Token: 0x06023BF6 RID: 146422 RVA: 0x004F15DF File Offset: 0x004EF7DF
		public ILetGoDestroyConditionT()
		{
			this.Type = ETeleControlDestroyCondition.LetGo;
		}
	}
}
