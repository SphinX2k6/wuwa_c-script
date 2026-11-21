using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200691D RID: 26909
	public class ICaptionParamT
	{
		// Token: 0x1700C617 RID: 50711
		// (get) Token: 0x0602E1BE RID: 188862 RVA: 0x0064CE7C File Offset: 0x0064B07C
		// (set) Token: 0x0602E1BF RID: 188863 RVA: 0x0064CE84 File Offset: 0x0064B084
		public float StartTime { get; set; }

		// Token: 0x1700C618 RID: 50712
		// (get) Token: 0x0602E1C0 RID: 188864 RVA: 0x0064CE8D File Offset: 0x0064B08D
		// (set) Token: 0x0602E1C1 RID: 188865 RVA: 0x0064CE95 File Offset: 0x0064B095
		public float TotalTime { get; set; }

		// Token: 0x1700C619 RID: 50713
		// (get) Token: 0x0602E1C2 RID: 188866 RVA: 0x0064CE9E File Offset: 0x0064B09E
		// (set) Token: 0x0602E1C3 RID: 188867 RVA: 0x0064CEA6 File Offset: 0x0064B0A6
		public float IntervalTime { get; set; }

		// Token: 0x1700C61A RID: 50714
		// (get) Token: 0x0602E1C4 RID: 188868 RVA: 0x0064CEAF File Offset: 0x0064B0AF
		// (set) Token: 0x0602E1C5 RID: 188869 RVA: 0x0064CEB7 File Offset: 0x0064B0B7
		public byte NullMask { get; set; }

		// Token: 0x0602E1C6 RID: 188870 RVA: 0x0064CEC0 File Offset: 0x0064B0C0
		public ICaptionParamT()
		{
			this.StartTime = 0f;
			this.TotalTime = 0f;
			this.IntervalTime = 0f;
			this.NullMask = 0;
		}
	}
}
