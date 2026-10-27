using System;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004900 RID: 18688
	public class ILoopTeleportClientLogicItemBaseT
	{
		// Token: 0x17008787 RID: 34695
		// (get) Token: 0x0601D374 RID: 119668 RVA: 0x0041F49A File Offset: 0x0041D69A
		// (set) Token: 0x0601D375 RID: 119669 RVA: 0x0041F4A2 File Offset: 0x0041D6A2
		public ELoopTeleportClientLogicType Type { get; set; }

		// Token: 0x0601D376 RID: 119670 RVA: 0x0041F4AB File Offset: 0x0041D6AB
		public ILoopTeleportClientLogicItemBaseT()
		{
			this.Type = ELoopTeleportClientLogicType.PlayEffect;
		}
	}
}
