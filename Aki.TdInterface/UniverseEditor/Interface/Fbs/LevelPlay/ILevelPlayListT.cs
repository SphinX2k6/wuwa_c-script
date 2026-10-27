using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.SyncBlock;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004504 RID: 17668
	public class ILevelPlayListT
	{
		// Token: 0x17007D41 RID: 32065
		// (get) Token: 0x0601A8A3 RID: 108707 RVA: 0x003CA56C File Offset: 0x003C876C
		// (set) Token: 0x0601A8A4 RID: 108708 RVA: 0x003CA574 File Offset: 0x003C8774
		public List<ILevelPlayT> LevelPlays { get; set; }

		// Token: 0x17007D42 RID: 32066
		// (get) Token: 0x0601A8A5 RID: 108709 RVA: 0x003CA57D File Offset: 0x003C877D
		// (set) Token: 0x0601A8A6 RID: 108710 RVA: 0x003CA585 File Offset: 0x003C8785
		public int _Selected { get; set; }

		// Token: 0x17007D43 RID: 32067
		// (get) Token: 0x0601A8A7 RID: 108711 RVA: 0x003CA58E File Offset: 0x003C878E
		// (set) Token: 0x0601A8A8 RID: 108712 RVA: 0x003CA596 File Offset: 0x003C8796
		public bool _IsSelectBt { get; set; }

		// Token: 0x17007D44 RID: 32068
		// (get) Token: 0x0601A8A9 RID: 108713 RVA: 0x003CA59F File Offset: 0x003C879F
		// (set) Token: 0x0601A8AA RID: 108714 RVA: 0x003CA5A7 File Offset: 0x003C87A7
		public List<ISyncBlockGroupT> _SyncBlockGroups { get; set; }

		// Token: 0x17007D45 RID: 32069
		// (get) Token: 0x0601A8AB RID: 108715 RVA: 0x003CA5B0 File Offset: 0x003C87B0
		// (set) Token: 0x0601A8AC RID: 108716 RVA: 0x003CA5B8 File Offset: 0x003C87B8
		public byte NullMask { get; set; }

		// Token: 0x0601A8AD RID: 108717 RVA: 0x003CA5C1 File Offset: 0x003C87C1
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
