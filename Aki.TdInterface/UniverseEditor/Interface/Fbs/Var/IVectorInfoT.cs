using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F2C RID: 16172
	public class IVectorInfoT
	{
		// Token: 0x17006D81 RID: 28033
		// (get) Token: 0x06015FAB RID: 90027 RVA: 0x003288D4 File Offset: 0x00326AD4
		// (set) Token: 0x06015FAC RID: 90028 RVA: 0x003288DC File Offset: 0x00326ADC
		public float X { get; set; }

		// Token: 0x17006D82 RID: 28034
		// (get) Token: 0x06015FAD RID: 90029 RVA: 0x003288E5 File Offset: 0x00326AE5
		// (set) Token: 0x06015FAE RID: 90030 RVA: 0x003288ED File Offset: 0x00326AED
		public float Y { get; set; }

		// Token: 0x17006D83 RID: 28035
		// (get) Token: 0x06015FAF RID: 90031 RVA: 0x003288F6 File Offset: 0x00326AF6
		// (set) Token: 0x06015FB0 RID: 90032 RVA: 0x003288FE File Offset: 0x00326AFE
		public float Z { get; set; }

		// Token: 0x17006D84 RID: 28036
		// (get) Token: 0x06015FB1 RID: 90033 RVA: 0x00328907 File Offset: 0x00326B07
		// (set) Token: 0x06015FB2 RID: 90034 RVA: 0x0032890F File Offset: 0x00326B0F
		public byte NullMask { get; set; }

		// Token: 0x06015FB3 RID: 90035 RVA: 0x00328918 File Offset: 0x00326B18
		public IVectorInfoT()
		{
			this.X = 0f;
			this.Y = 0f;
			this.Z = 0f;
			this.NullMask = 0;
		}
	}
}
