using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B6A RID: 27498
	public class ICustomScreenBackgroundImageT
	{
		// Token: 0x1700C9D8 RID: 51672
		// (get) Token: 0x0602F52B RID: 193835 RVA: 0x0067573B File Offset: 0x0067393B
		// (set) Token: 0x0602F52C RID: 193836 RVA: 0x00675743 File Offset: 0x00673943
		public ECustomScreenType Type { get; set; }

		// Token: 0x1700C9D9 RID: 51673
		// (get) Token: 0x0602F52D RID: 193837 RVA: 0x0067574C File Offset: 0x0067394C
		// (set) Token: 0x0602F52E RID: 193838 RVA: 0x00675754 File Offset: 0x00673954
		public string BackgroundImagePath { get; set; }

		// Token: 0x0602F52F RID: 193839 RVA: 0x0067575D File Offset: 0x0067395D
		public ICustomScreenBackgroundImageT()
		{
			this.Type = ECustomScreenType.Spine;
			this.BackgroundImagePath = null;
		}
	}
}
