using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B8E RID: 27534
	public class ICutCameraTimeParamsT
	{
		// Token: 0x1700CA0F RID: 51727
		// (get) Token: 0x0602F62B RID: 194091 RVA: 0x0067725E File Offset: 0x0067545E
		// (set) Token: 0x0602F62C RID: 194092 RVA: 0x00677266 File Offset: 0x00675466
		public float CutStayTime { get; set; }

		// Token: 0x0602F62D RID: 194093 RVA: 0x0067726F File Offset: 0x0067546F
		public ICutCameraTimeParamsT()
		{
			this.CutStayTime = 0f;
		}
	}
}
