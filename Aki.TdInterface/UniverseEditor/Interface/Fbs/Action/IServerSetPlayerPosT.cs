using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F8E RID: 28558
	public class IServerSetPlayerPosT
	{
		// Token: 0x1700D41C RID: 54300
		// (get) Token: 0x0603277E RID: 206718 RVA: 0x006CFFB5 File Offset: 0x006CE1B5
		// (set) Token: 0x0603277F RID: 206719 RVA: 0x006CFFBD File Offset: 0x006CE1BD
		public IPosAT Pos { get; set; }

		// Token: 0x06032780 RID: 206720 RVA: 0x006CFFC6 File Offset: 0x006CE1C6
		public IServerSetPlayerPosT()
		{
			this.Pos = null;
		}
	}
}
