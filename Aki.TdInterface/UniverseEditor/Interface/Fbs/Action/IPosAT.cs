using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074DE RID: 29918
	public class IPosAT
	{
		// Token: 0x1700DC1E RID: 56350
		// (get) Token: 0x06034722 RID: 214818 RVA: 0x0070FB82 File Offset: 0x0070DD82
		// (set) Token: 0x06034723 RID: 214819 RVA: 0x0070FB8A File Offset: 0x0070DD8A
		public float X { get; set; }

		// Token: 0x1700DC1F RID: 56351
		// (get) Token: 0x06034724 RID: 214820 RVA: 0x0070FB93 File Offset: 0x0070DD93
		// (set) Token: 0x06034725 RID: 214821 RVA: 0x0070FB9B File Offset: 0x0070DD9B
		public float Y { get; set; }

		// Token: 0x1700DC20 RID: 56352
		// (get) Token: 0x06034726 RID: 214822 RVA: 0x0070FBA4 File Offset: 0x0070DDA4
		// (set) Token: 0x06034727 RID: 214823 RVA: 0x0070FBAC File Offset: 0x0070DDAC
		public float Z { get; set; }

		// Token: 0x1700DC21 RID: 56353
		// (get) Token: 0x06034728 RID: 214824 RVA: 0x0070FBB5 File Offset: 0x0070DDB5
		// (set) Token: 0x06034729 RID: 214825 RVA: 0x0070FBBD File Offset: 0x0070DDBD
		public float A { get; set; }

		// Token: 0x1700DC22 RID: 56354
		// (get) Token: 0x0603472A RID: 214826 RVA: 0x0070FBC6 File Offset: 0x0070DDC6
		// (set) Token: 0x0603472B RID: 214827 RVA: 0x0070FBCE File Offset: 0x0070DDCE
		public byte NullMask { get; set; }

		// Token: 0x0603472C RID: 214828 RVA: 0x0070FBD7 File Offset: 0x0070DDD7
		public IPosAT()
		{
			this.X = 0f;
			this.Y = 0f;
			this.Z = 0f;
			this.A = 0f;
			this.NullMask = 0;
		}
	}
}
