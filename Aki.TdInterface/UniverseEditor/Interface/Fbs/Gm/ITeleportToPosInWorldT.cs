using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046C7 RID: 18119
	public class ITeleportToPosInWorldT
	{
		// Token: 0x170080C0 RID: 32960
		// (get) Token: 0x0601B8BF RID: 112831 RVA: 0x003E8967 File Offset: 0x003E6B67
		// (set) Token: 0x0601B8C0 RID: 112832 RVA: 0x003E896F File Offset: 0x003E6B6F
		public EGmCommand Type { get; set; }

		// Token: 0x170080C1 RID: 32961
		// (get) Token: 0x0601B8C1 RID: 112833 RVA: 0x003E8978 File Offset: 0x003E6B78
		// (set) Token: 0x0601B8C2 RID: 112834 RVA: 0x003E8980 File Offset: 0x003E6B80
		public IPosAT Pos { get; set; }

		// Token: 0x170080C2 RID: 32962
		// (get) Token: 0x0601B8C3 RID: 112835 RVA: 0x003E8989 File Offset: 0x003E6B89
		// (set) Token: 0x0601B8C4 RID: 112836 RVA: 0x003E8991 File Offset: 0x003E6B91
		public int DungeonId { get; set; }

		// Token: 0x170080C3 RID: 32963
		// (get) Token: 0x0601B8C5 RID: 112837 RVA: 0x003E899A File Offset: 0x003E6B9A
		// (set) Token: 0x0601B8C6 RID: 112838 RVA: 0x003E89A2 File Offset: 0x003E6BA2
		public byte NullMask { get; set; }

		// Token: 0x0601B8C7 RID: 112839 RVA: 0x003E89AB File Offset: 0x003E6BAB
		public ITeleportToPosInWorldT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.Pos = null;
			this.DungeonId = 0;
			this.NullMask = 0;
		}
	}
}
