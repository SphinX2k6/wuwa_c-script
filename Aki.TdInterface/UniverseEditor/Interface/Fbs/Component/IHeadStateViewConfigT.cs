using System;
using Aki.UniverseEditor.Interface.Fbs.Match;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005366 RID: 21350
	public class IHeadStateViewConfigT
	{
		// Token: 0x17009CE6 RID: 40166
		// (get) Token: 0x06022EFE RID: 143102 RVA: 0x004D69D3 File Offset: 0x004D4BD3
		// (set) Token: 0x06022EFF RID: 143103 RVA: 0x004D69DB File Offset: 0x004D4BDB
		public EHeadStateViewType HeadStateViewType { get; set; }

		// Token: 0x17009CE7 RID: 40167
		// (get) Token: 0x06022F00 RID: 143104 RVA: 0x004D69E4 File Offset: 0x004D4BE4
		// (set) Token: 0x06022F01 RID: 143105 RVA: 0x004D69EC File Offset: 0x004D4BEC
		public int ZOffset { get; set; }

		// Token: 0x17009CE8 RID: 40168
		// (get) Token: 0x06022F02 RID: 143106 RVA: 0x004D69F5 File Offset: 0x004D4BF5
		// (set) Token: 0x06022F03 RID: 143107 RVA: 0x004D69FD File Offset: 0x004D4BFD
		public int ForwardOffset { get; set; }

		// Token: 0x17009CE9 RID: 40169
		// (get) Token: 0x06022F04 RID: 143108 RVA: 0x004D6A06 File Offset: 0x004D4C06
		// (set) Token: 0x06022F05 RID: 143109 RVA: 0x004D6A0E File Offset: 0x004D4C0E
		public string HeadStateSocketName { get; set; }

		// Token: 0x06022F06 RID: 143110 RVA: 0x004D6A17 File Offset: 0x004D4C17
		public IHeadStateViewConfigT()
		{
			this.HeadStateViewType = EHeadStateViewType.None;
			this.ZOffset = 0;
			this.ForwardOffset = 0;
			this.HeadStateSocketName = null;
		}
	}
}
