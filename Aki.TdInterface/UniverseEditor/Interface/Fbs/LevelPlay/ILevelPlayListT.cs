using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.SyncBlock;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200496C RID: 18796
	public class ILevelPlayListT
	{
		// Token: 0x17008382 RID: 33666
		// (get) Token: 0x0601C078 RID: 114808 RVA: 0x003F6808 File Offset: 0x003F4A08
		// (set) Token: 0x0601C079 RID: 114809 RVA: 0x003F6810 File Offset: 0x003F4A10
		public List<ILevelPlayT> LevelPlays { get; set; }

		// Token: 0x17008383 RID: 33667
		// (get) Token: 0x0601C07A RID: 114810 RVA: 0x003F6819 File Offset: 0x003F4A19
		// (set) Token: 0x0601C07B RID: 114811 RVA: 0x003F6821 File Offset: 0x003F4A21
		public int _Selected { get; set; }

		// Token: 0x17008384 RID: 33668
		// (get) Token: 0x0601C07C RID: 114812 RVA: 0x003F682A File Offset: 0x003F4A2A
		// (set) Token: 0x0601C07D RID: 114813 RVA: 0x003F6832 File Offset: 0x003F4A32
		public bool _IsSelectBt { get; set; }

		// Token: 0x17008385 RID: 33669
		// (get) Token: 0x0601C07E RID: 114814 RVA: 0x003F683B File Offset: 0x003F4A3B
		// (set) Token: 0x0601C07F RID: 114815 RVA: 0x003F6843 File Offset: 0x003F4A43
		public List<ISyncBlockGroupT> _SyncBlockGroups { get; set; }

		// Token: 0x17008386 RID: 33670
		// (get) Token: 0x0601C080 RID: 114816 RVA: 0x003F684C File Offset: 0x003F4A4C
		// (set) Token: 0x0601C081 RID: 114817 RVA: 0x003F6854 File Offset: 0x003F4A54
		public byte NullMask { get; set; }

		// Token: 0x0601C082 RID: 114818 RVA: 0x003F685D File Offset: 0x003F4A5D
		public ILevelPlayListT()
		{
			this.LevelPlays = null;
			this._Selected = 0;
			this._IsSelectBt = false;
			this._SyncBlockGroups = null;
			this.NullMask = 0;
		}
	}
}
