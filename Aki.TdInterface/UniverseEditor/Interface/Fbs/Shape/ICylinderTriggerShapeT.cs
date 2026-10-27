using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C11 RID: 15377
	public class ICylinderTriggerShapeT
	{
		// Token: 0x170069B8 RID: 27064
		// (get) Token: 0x06015319 RID: 86809 RVA: 0x00311E93 File Offset: 0x00310093
		// (set) Token: 0x0601531A RID: 86810 RVA: 0x00311E9B File Offset: 0x0031009B
		public ETriggerShape Type { get; set; }

		// Token: 0x170069B9 RID: 27065
		// (get) Token: 0x0601531B RID: 86811 RVA: 0x00311EA4 File Offset: 0x003100A4
		// (set) Token: 0x0601531C RID: 86812 RVA: 0x00311EAC File Offset: 0x003100AC
		public IVectorInfoT Center { get; set; }

		// Token: 0x170069BA RID: 27066
		// (get) Token: 0x0601531D RID: 86813 RVA: 0x00311EB5 File Offset: 0x003100B5
		// (set) Token: 0x0601531E RID: 86814 RVA: 0x00311EBD File Offset: 0x003100BD
		public int Radius { get; set; }

		// Token: 0x170069BB RID: 27067
		// (get) Token: 0x0601531F RID: 86815 RVA: 0x00311EC6 File Offset: 0x003100C6
		// (set) Token: 0x06015320 RID: 86816 RVA: 0x00311ECE File Offset: 0x003100CE
		public int Height { get; set; }

		// Token: 0x06015321 RID: 86817 RVA: 0x00311ED7 File Offset: 0x003100D7
		public ICylinderTriggerShapeT()
		{
			this.Type = ETriggerShape.Box;
			this.Center = null;
			this.Radius = 0;
			this.Height = 0;
		}
	}
}
