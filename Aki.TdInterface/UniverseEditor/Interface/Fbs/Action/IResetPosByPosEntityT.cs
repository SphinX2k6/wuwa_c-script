using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007625 RID: 30245
	public class IResetPosByPosEntityT
	{
		// Token: 0x1700DE37 RID: 56887
		// (get) Token: 0x0603512B RID: 217387 RVA: 0x00720EAC File Offset: 0x0071F0AC
		// (set) Token: 0x0603512C RID: 217388 RVA: 0x00720EB4 File Offset: 0x0071F0B4
		public EResetPosType Type { get; set; }

		// Token: 0x1700DE38 RID: 56888
		// (get) Token: 0x0603512D RID: 217389 RVA: 0x00720EBD File Offset: 0x0071F0BD
		// (set) Token: 0x0603512E RID: 217390 RVA: 0x00720EC5 File Offset: 0x0071F0C5
		public int Entity { get; set; }

		// Token: 0x0603512F RID: 217391 RVA: 0x00720ECE File Offset: 0x0071F0CE
		public IResetPosByPosEntityT()
		{
			this.Type = EResetPosType.PosEntity;
			this.Entity = 0;
		}
	}
}
