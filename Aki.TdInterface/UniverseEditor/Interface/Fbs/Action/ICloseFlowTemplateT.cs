using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A96 RID: 27286
	public class ICloseFlowTemplateT
	{
		// Token: 0x1700C865 RID: 51301
		// (get) Token: 0x0602ED37 RID: 191799 RVA: 0x00661A1F File Offset: 0x0065FC1F
		// (set) Token: 0x0602ED38 RID: 191800 RVA: 0x00661A27 File Offset: 0x0065FC27
		public bool IsResetPosition { get; set; }

		// Token: 0x1700C866 RID: 51302
		// (get) Token: 0x0602ED39 RID: 191801 RVA: 0x00661A30 File Offset: 0x0065FC30
		// (set) Token: 0x0602ED3A RID: 191802 RVA: 0x00661A38 File Offset: 0x0065FC38
		public IEndStateT EndState { get; set; }

		// Token: 0x1700C867 RID: 51303
		// (get) Token: 0x0602ED3B RID: 191803 RVA: 0x00661A41 File Offset: 0x0065FC41
		// (set) Token: 0x0602ED3C RID: 191804 RVA: 0x00661A49 File Offset: 0x0065FC49
		public bool ExitFilmAspectRatio { get; set; }

		// Token: 0x1700C868 RID: 51304
		// (get) Token: 0x0602ED3D RID: 191805 RVA: 0x00661A52 File Offset: 0x0065FC52
		// (set) Token: 0x0602ED3E RID: 191806 RVA: 0x00661A5A File Offset: 0x0065FC5A
		public byte NullMask { get; set; }

		// Token: 0x0602ED3F RID: 191807 RVA: 0x00661A63 File Offset: 0x0065FC63
		public ICloseFlowTemplateT()
		{
			this.IsResetPosition = false;
			this.EndState = null;
			this.ExitFilmAspectRatio = false;
			this.NullMask = 0;
		}
	}
}
