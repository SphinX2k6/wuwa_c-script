using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042B1 RID: 17073
	public class IGameDifficultySystemConfigT
	{
		// Token: 0x170074CC RID: 29900
		// (get) Token: 0x06017EAA RID: 97962 RVA: 0x0036A426 File Offset: 0x00368626
		// (set) Token: 0x06017EAB RID: 97963 RVA: 0x0036A42E File Offset: 0x0036862E
		public EEnableSystemType Type { get; set; }

		// Token: 0x06017EAC RID: 97964 RVA: 0x0036A437 File Offset: 0x00368637
		public IGameDifficultySystemConfigT()
		{
			this.Type = EEnableSystemType.GradingSystem;
		}
	}
}
