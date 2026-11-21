using System;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x020036B2 RID: 14002
	public class Area : IArea
	{
		// Token: 0x17004A3F RID: 19007
		// (get) Token: 0x060245E6 RID: 148966 RVA: 0x00A499B9 File Offset: 0x00A47BB9
		// (set) Token: 0x060245E7 RID: 148967 RVA: 0x00A499C1 File Offset: 0x00A47BC1
		public double MinX { get; set; }

		// Token: 0x17004A40 RID: 19008
		// (get) Token: 0x060245E8 RID: 148968 RVA: 0x00A499CA File Offset: 0x00A47BCA
		// (set) Token: 0x060245E9 RID: 148969 RVA: 0x00A499D2 File Offset: 0x00A47BD2
		public double MaxX { get; set; }

		// Token: 0x17004A41 RID: 19009
		// (get) Token: 0x060245EA RID: 148970 RVA: 0x00A499DB File Offset: 0x00A47BDB
		// (set) Token: 0x060245EB RID: 148971 RVA: 0x00A499E3 File Offset: 0x00A47BE3
		public double MinY { get; set; }

		// Token: 0x17004A42 RID: 19010
		// (get) Token: 0x060245EC RID: 148972 RVA: 0x00A499EC File Offset: 0x00A47BEC
		// (set) Token: 0x060245ED RID: 148973 RVA: 0x00A499F4 File Offset: 0x00A47BF4
		public double MaxY { get; set; }
	}
}
