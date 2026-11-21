using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079FF RID: 31231
	public class ISubtitleStyleLevelAT
	{
		// Token: 0x1700E4E7 RID: 58599
		// (get) Token: 0x06037080 RID: 225408 RVA: 0x0075B176 File Offset: 0x00759376
		// (set) Token: 0x06037081 RID: 225409 RVA: 0x0075B17E File Offset: 0x0075937E
		public ESubtitleStyle Type { get; set; }

		// Token: 0x06037082 RID: 225410 RVA: 0x0075B187 File Offset: 0x00759387
		public ISubtitleStyleLevelAT()
		{
			this.Type = ESubtitleStyle.LevelA;
		}
	}
}
