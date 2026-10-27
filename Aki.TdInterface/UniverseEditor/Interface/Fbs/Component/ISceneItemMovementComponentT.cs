using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058CB RID: 22731
	public class ISceneItemMovementComponentT
	{
		// Token: 0x1700AA37 RID: 43575
		// (get) Token: 0x060265D4 RID: 157140 RVA: 0x00549857 File Offset: 0x00547A57
		// (set) Token: 0x060265D5 RID: 157141 RVA: 0x0054985F File Offset: 0x00547A5F
		public bool Disabled { get; set; }

		// Token: 0x1700AA38 RID: 43576
		// (get) Token: 0x060265D6 RID: 157142 RVA: 0x00549868 File Offset: 0x00547A68
		// (set) Token: 0x060265D7 RID: 157143 RVA: 0x00549870 File Offset: 0x00547A70
		public ISplineMoveT Patrol { get; set; }

		// Token: 0x1700AA39 RID: 43577
		// (get) Token: 0x060265D8 RID: 157144 RVA: 0x00549879 File Offset: 0x00547A79
		// (set) Token: 0x060265D9 RID: 157145 RVA: 0x00549881 File Offset: 0x00547A81
		public IMovementPlatformConfigT PlatformConfig { get; set; }

		// Token: 0x1700AA3A RID: 43578
		// (get) Token: 0x060265DA RID: 157146 RVA: 0x0054988A File Offset: 0x00547A8A
		// (set) Token: 0x060265DB RID: 157147 RVA: 0x00549892 File Offset: 0x00547A92
		public byte NullMask { get; set; }

		// Token: 0x060265DC RID: 157148 RVA: 0x0054989B File Offset: 0x00547A9B
		public ISceneItemMovementComponentT()
		{
			this.Disabled = false;
			this.Patrol = null;
			this.PlatformConfig = null;
			this.NullMask = 0;
		}
	}
}
