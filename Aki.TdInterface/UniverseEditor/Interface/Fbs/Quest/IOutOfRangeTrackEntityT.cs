using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043A7 RID: 17319
	public class IOutOfRangeTrackEntityT
	{
		// Token: 0x170076D2 RID: 30418
		// (get) Token: 0x060187E0 RID: 100320 RVA: 0x0037D4A9 File Offset: 0x0037B6A9
		// (set) Token: 0x060187E1 RID: 100321 RVA: 0x0037D4B1 File Offset: 0x0037B6B1
		public int TrackEntityId { get; set; }

		// Token: 0x170076D3 RID: 30419
		// (get) Token: 0x060187E2 RID: 100322 RVA: 0x0037D4BA File Offset: 0x0037B6BA
		// (set) Token: 0x060187E3 RID: 100323 RVA: 0x0037D4C2 File Offset: 0x0037B6C2
		public IVectorInfoT Center { get; set; }

		// Token: 0x170076D4 RID: 30420
		// (get) Token: 0x060187E4 RID: 100324 RVA: 0x0037D4CB File Offset: 0x0037B6CB
		// (set) Token: 0x060187E5 RID: 100325 RVA: 0x0037D4D3 File Offset: 0x0037B6D3
		public int Radius { get; set; }

		// Token: 0x170076D5 RID: 30421
		// (get) Token: 0x060187E6 RID: 100326 RVA: 0x0037D4DC File Offset: 0x0037B6DC
		// (set) Token: 0x060187E7 RID: 100327 RVA: 0x0037D4E4 File Offset: 0x0037B6E4
		public bool OverrideChildNodeTrackTarget { get; set; }

		// Token: 0x170076D6 RID: 30422
		// (get) Token: 0x060187E8 RID: 100328 RVA: 0x0037D4ED File Offset: 0x0037B6ED
		// (set) Token: 0x060187E9 RID: 100329 RVA: 0x0037D4F5 File Offset: 0x0037B6F5
		public byte NullMask { get; set; }

		// Token: 0x060187EA RID: 100330 RVA: 0x0037D4FE File Offset: 0x0037B6FE
		public IOutOfRangeTrackEntityT()
		{
			this.TrackEntityId = 0;
			this.Center = null;
			this.Radius = 0;
			this.OverrideChildNodeTrackTarget = false;
			this.NullMask = 0;
		}
	}
}
