using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004993 RID: 18835
	public class IMultiplayerRefreshT
	{
		// Token: 0x170083DB RID: 33755
		// (get) Token: 0x0601C1E0 RID: 115168 RVA: 0x003F9288 File Offset: 0x003F7488
		// (set) Token: 0x0601C1E1 RID: 115169 RVA: 0x003F9290 File Offset: 0x003F7490
		public int CompletedRefreshTime { get; set; }

		// Token: 0x170083DC RID: 33756
		// (get) Token: 0x0601C1E2 RID: 115170 RVA: 0x003F9299 File Offset: 0x003F7499
		// (set) Token: 0x0601C1E3 RID: 115171 RVA: 0x003F92A1 File Offset: 0x003F74A1
		public int AllPlayerAwardedRefreshTime { get; set; }

		// Token: 0x170083DD RID: 33757
		// (get) Token: 0x0601C1E4 RID: 115172 RVA: 0x003F92AA File Offset: 0x003F74AA
		// (set) Token: 0x0601C1E5 RID: 115173 RVA: 0x003F92B2 File Offset: 0x003F74B2
		public int AnyPlayerAwardedRefreshTime { get; set; }

		// Token: 0x170083DE RID: 33758
		// (get) Token: 0x0601C1E6 RID: 115174 RVA: 0x003F92BB File Offset: 0x003F74BB
		// (set) Token: 0x0601C1E7 RID: 115175 RVA: 0x003F92C3 File Offset: 0x003F74C3
		public byte NullMask { get; set; }

		// Token: 0x0601C1E8 RID: 115176 RVA: 0x003F92CC File Offset: 0x003F74CC
		public IMultiplayerRefreshT()
		{
			this.CompletedRefreshTime = 0;
			this.AllPlayerAwardedRefreshTime = 0;
			this.AnyPlayerAwardedRefreshTime = 0;
			this.NullMask = 0;
		}
	}
}
