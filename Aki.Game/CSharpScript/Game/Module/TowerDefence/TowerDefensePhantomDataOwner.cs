using System;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B3E RID: 19262
	public class TowerDefensePhantomDataOwner : ITowerDefensePhantomDataOwner
	{
		// Token: 0x17007BBC RID: 31676
		// (get) Token: 0x06031E3A RID: 204346 RVA: 0x00B929A0 File Offset: 0x00B90BA0
		// (set) Token: 0x06031E3B RID: 204347 RVA: 0x00B929A8 File Offset: 0x00B90BA8
		public long PlayerId { get; set; }

		// Token: 0x17007BBD RID: 31677
		// (get) Token: 0x06031E3C RID: 204348 RVA: 0x00B929B1 File Offset: 0x00B90BB1
		// (set) Token: 0x06031E3D RID: 204349 RVA: 0x00B929B9 File Offset: 0x00B90BB9
		public bool IsSelf { get; set; }

		// Token: 0x17007BBE RID: 31678
		// (get) Token: 0x06031E3E RID: 204350 RVA: 0x00B929C2 File Offset: 0x00B90BC2
		// (set) Token: 0x06031E3F RID: 204351 RVA: 0x00B929CA File Offset: 0x00B90BCA
		public int RoleCfgId { get; set; }

		// Token: 0x17007BBF RID: 31679
		// (get) Token: 0x06031E40 RID: 204352 RVA: 0x00B929D3 File Offset: 0x00B90BD3
		// (set) Token: 0x06031E41 RID: 204353 RVA: 0x00B929DB File Offset: 0x00B90BDB
		public int RoleSkinId { get; set; }

		// Token: 0x17007BC0 RID: 31680
		// (get) Token: 0x06031E42 RID: 204354 RVA: 0x00B929E4 File Offset: 0x00B90BE4
		// (set) Token: 0x06031E43 RID: 204355 RVA: 0x00B929EC File Offset: 0x00B90BEC
		public int PhantomId { get; set; }
	}
}
