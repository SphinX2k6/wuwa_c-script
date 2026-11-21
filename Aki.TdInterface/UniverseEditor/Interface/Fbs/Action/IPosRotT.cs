using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074E7 RID: 29927
	public class IPosRotT
	{
		// Token: 0x1700DC3C RID: 56380
		// (get) Token: 0x06034782 RID: 214914 RVA: 0x007106C2 File Offset: 0x0070E8C2
		// (set) Token: 0x06034783 RID: 214915 RVA: 0x007106CA File Offset: 0x0070E8CA
		public IVectorInfoT Pos { get; set; }

		// Token: 0x1700DC3D RID: 56381
		// (get) Token: 0x06034784 RID: 214916 RVA: 0x007106D3 File Offset: 0x0070E8D3
		// (set) Token: 0x06034785 RID: 214917 RVA: 0x007106DB File Offset: 0x0070E8DB
		public IVectorInfoT Rot { get; set; }

		// Token: 0x06034786 RID: 214918 RVA: 0x007106E4 File Offset: 0x0070E8E4
		public IPosRotT()
		{
			this.Pos = null;
			this.Rot = null;
		}
	}
}
