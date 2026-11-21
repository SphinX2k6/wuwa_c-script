using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CEB RID: 23787
	public class IPathDrivenActorSpawnerComponentT
	{
		// Token: 0x1700AEBF RID: 44735
		// (get) Token: 0x060277D6 RID: 161750 RVA: 0x0056767B File Offset: 0x0056587B
		// (set) Token: 0x060277D7 RID: 161751 RVA: 0x00567683 File Offset: 0x00565883
		public bool Disabled { get; set; }

		// Token: 0x1700AEC0 RID: 44736
		// (get) Token: 0x060277D8 RID: 161752 RVA: 0x0056768C File Offset: 0x0056588C
		// (set) Token: 0x060277D9 RID: 161753 RVA: 0x00567694 File Offset: 0x00565894
		public IIntervalSplineSpawnT SpawnRule { get; set; }

		// Token: 0x1700AEC1 RID: 44737
		// (get) Token: 0x060277DA RID: 161754 RVA: 0x0056769D File Offset: 0x0056589D
		// (set) Token: 0x060277DB RID: 161755 RVA: 0x005676A5 File Offset: 0x005658A5
		public TTargetEntityUnion Target { get; set; }

		// Token: 0x1700AEC2 RID: 44738
		// (get) Token: 0x060277DC RID: 161756 RVA: 0x005676AE File Offset: 0x005658AE
		// (set) Token: 0x060277DD RID: 161757 RVA: 0x005676B6 File Offset: 0x005658B6
		public byte NullMask { get; set; }

		// Token: 0x060277DE RID: 161758 RVA: 0x005676BF File Offset: 0x005658BF
		public IPathDrivenActorSpawnerComponentT()
		{
			this.Disabled = false;
			this.SpawnRule = null;
			this.Target = null;
			this.NullMask = 0;
		}
	}
}
