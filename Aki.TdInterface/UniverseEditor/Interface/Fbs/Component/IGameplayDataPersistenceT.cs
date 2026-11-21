using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005866 RID: 22630
	public class IGameplayDataPersistenceT
	{
		// Token: 0x1700A3F1 RID: 41969
		// (get) Token: 0x06024ADB RID: 150235 RVA: 0x00509EA2 File Offset: 0x005080A2
		// (set) Token: 0x06024ADC RID: 150236 RVA: 0x00509EAA File Offset: 0x005080AA
		public EDataPersistenceGameplayType Type { get; set; }

		// Token: 0x06024ADD RID: 150237 RVA: 0x00509EB3 File Offset: 0x005080B3
		public IGameplayDataPersistenceT()
		{
			this.Type = EDataPersistenceGameplayType.TetrisBoardGame;
		}
	}
}
