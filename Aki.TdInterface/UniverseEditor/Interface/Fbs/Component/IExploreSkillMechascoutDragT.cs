using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200575E RID: 22366
	public class IExploreSkillMechascoutDragT
	{
		// Token: 0x1700A1AB RID: 41387
		// (get) Token: 0x060240EE RID: 147694 RVA: 0x004F5B9C File Offset: 0x004F3D9C
		// (set) Token: 0x060240EF RID: 147695 RVA: 0x004F5BA4 File Offset: 0x004F3DA4
		public EExploreSkillInteractType Type { get; set; }

		// Token: 0x1700A1AC RID: 41388
		// (get) Token: 0x060240F0 RID: 147696 RVA: 0x004F5BAD File Offset: 0x004F3DAD
		// (set) Token: 0x060240F1 RID: 147697 RVA: 0x004F5BB5 File Offset: 0x004F3DB5
		public TMechascoutDragTypeUnion DragType { get; set; }

		// Token: 0x1700A1AD RID: 41389
		// (get) Token: 0x060240F2 RID: 147698 RVA: 0x004F5BBE File Offset: 0x004F3DBE
		// (set) Token: 0x060240F3 RID: 147699 RVA: 0x004F5BC6 File Offset: 0x004F3DC6
		public List<int> TriggerPointList { get; set; }

		// Token: 0x1700A1AE RID: 41390
		// (get) Token: 0x060240F4 RID: 147700 RVA: 0x004F5BCF File Offset: 0x004F3DCF
		// (set) Token: 0x060240F5 RID: 147701 RVA: 0x004F5BD7 File Offset: 0x004F3DD7
		public List<IActionInfoT> FinishedActions { get; set; }

		// Token: 0x1700A1AF RID: 41391
		// (get) Token: 0x060240F6 RID: 147702 RVA: 0x004F5BE0 File Offset: 0x004F3DE0
		// (set) Token: 0x060240F7 RID: 147703 RVA: 0x004F5BE8 File Offset: 0x004F3DE8
		public byte NullMask { get; set; }

		// Token: 0x060240F8 RID: 147704 RVA: 0x004F5BF1 File Offset: 0x004F3DF1
		public IExploreSkillMechascoutDragT()
		{
			this.Type = EExploreSkillInteractType.PullGiant;
			this.DragType = null;
			this.TriggerPointList = null;
			this.FinishedActions = null;
			this.NullMask = 0;
		}
	}
}
