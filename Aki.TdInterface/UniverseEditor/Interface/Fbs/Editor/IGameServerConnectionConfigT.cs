using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x0200487E RID: 18558
	public class IGameServerConnectionConfigT
	{
		// Token: 0x1700865A RID: 34394
		// (get) Token: 0x0601CEA8 RID: 118440 RVA: 0x004162E7 File Offset: 0x004144E7
		// (set) Token: 0x0601CEA9 RID: 118441 RVA: 0x004162EF File Offset: 0x004144EF
		public string LocalGameServerNode { get; set; }

		// Token: 0x1700865B RID: 34395
		// (get) Token: 0x0601CEAA RID: 118442 RVA: 0x004162F8 File Offset: 0x004144F8
		// (set) Token: 0x0601CEAB RID: 118443 RVA: 0x00416300 File Offset: 0x00414500
		public int LocalGameServerApiPort { get; set; }

		// Token: 0x1700865C RID: 34396
		// (get) Token: 0x0601CEAC RID: 118444 RVA: 0x00416309 File Offset: 0x00414509
		// (set) Token: 0x0601CEAD RID: 118445 RVA: 0x00416311 File Offset: 0x00414511
		public int LocalGameServerLoginPort { get; set; }

		// Token: 0x1700865D RID: 34397
		// (get) Token: 0x0601CEAE RID: 118446 RVA: 0x0041631A File Offset: 0x0041451A
		// (set) Token: 0x0601CEAF RID: 118447 RVA: 0x00416322 File Offset: 0x00414522
		public byte NullMask { get; set; }

		// Token: 0x0601CEB0 RID: 118448 RVA: 0x0041632B File Offset: 0x0041452B
		public IGameServerConnectionConfigT()
		{
			this.LocalGameServerNode = null;
			this.LocalGameServerApiPort = 0;
			this.LocalGameServerLoginPort = 0;
			this.NullMask = 0;
		}
	}
}
