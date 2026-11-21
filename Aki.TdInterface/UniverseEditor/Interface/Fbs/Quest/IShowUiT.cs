using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200455D RID: 17757
	public class IShowUiT
	{
		// Token: 0x17007C0F RID: 31759
		// (get) Token: 0x06019D2A RID: 105770 RVA: 0x003AF356 File Offset: 0x003AD556
		// (set) Token: 0x06019D2B RID: 105771 RVA: 0x003AF35E File Offset: 0x003AD55E
		public EShowUiType Type { get; set; }

		// Token: 0x06019D2C RID: 105772 RVA: 0x003AF367 File Offset: 0x003AD567
		public IShowUiT()
		{
			this.Type = EShowUiType.All;
		}
	}
}
