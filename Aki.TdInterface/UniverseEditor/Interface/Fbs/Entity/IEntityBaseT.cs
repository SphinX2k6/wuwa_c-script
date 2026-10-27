using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004794 RID: 18324
	public class IEntityBaseT
	{
		// Token: 0x17008377 RID: 33655
		// (get) Token: 0x0601C3C7 RID: 115655 RVA: 0x003FF87A File Offset: 0x003FDA7A
		// (set) Token: 0x0601C3C8 RID: 115656 RVA: 0x003FF882 File Offset: 0x003FDA82
		public string ObjType { get; set; }

		// Token: 0x17008378 RID: 33656
		// (get) Token: 0x0601C3C9 RID: 115657 RVA: 0x003FF88B File Offset: 0x003FDA8B
		// (set) Token: 0x0601C3CA RID: 115658 RVA: 0x003FF893 File Offset: 0x003FDA93
		public List<string> Children { get; set; }

		// Token: 0x17008379 RID: 33657
		// (get) Token: 0x0601C3CB RID: 115659 RVA: 0x003FF89C File Offset: 0x003FDA9C
		// (set) Token: 0x0601C3CC RID: 115660 RVA: 0x003FF8A4 File Offset: 0x003FDAA4
		public List<string> Reference { get; set; }

		// Token: 0x1700837A RID: 33658
		// (get) Token: 0x0601C3CD RID: 115661 RVA: 0x003FF8AD File Offset: 0x003FDAAD
		// (set) Token: 0x0601C3CE RID: 115662 RVA: 0x003FF8B5 File Offset: 0x003FDAB5
		public List<string> WeakReference { get; set; }

		// Token: 0x1700837B RID: 33659
		// (get) Token: 0x0601C3CF RID: 115663 RVA: 0x003FF8BE File Offset: 0x003FDABE
		// (set) Token: 0x0601C3D0 RID: 115664 RVA: 0x003FF8C6 File Offset: 0x003FDAC6
		public string Name { get; set; }

		// Token: 0x1700837C RID: 33660
		// (get) Token: 0x0601C3D1 RID: 115665 RVA: 0x003FF8CF File Offset: 0x003FDACF
		// (set) Token: 0x0601C3D2 RID: 115666 RVA: 0x003FF8D7 File Offset: 0x003FDAD7
		public string BlueprintType { get; set; }

		// Token: 0x1700837D RID: 33661
		// (get) Token: 0x0601C3D3 RID: 115667 RVA: 0x003FF8E0 File Offset: 0x003FDAE0
		// (set) Token: 0x0601C3D4 RID: 115668 RVA: 0x003FF8E8 File Offset: 0x003FDAE8
		public TComponentsDataT ComponentsData { get; set; }

		// Token: 0x1700837E RID: 33662
		// (get) Token: 0x0601C3D5 RID: 115669 RVA: 0x003FF8F1 File Offset: 0x003FDAF1
		// (set) Token: 0x0601C3D6 RID: 115670 RVA: 0x003FF8F9 File Offset: 0x003FDAF9
		public byte NullMask { get; set; }

		// Token: 0x0601C3D7 RID: 115671 RVA: 0x003FF902 File Offset: 0x003FDB02
		public IEntityBaseT()
		{
			this.ObjType = null;
			this.Children = null;
			this.Reference = null;
			this.WeakReference = null;
			this.Name = null;
			this.BlueprintType = null;
			this.ComponentsData = null;
			this.NullMask = 0;
		}
	}
}
