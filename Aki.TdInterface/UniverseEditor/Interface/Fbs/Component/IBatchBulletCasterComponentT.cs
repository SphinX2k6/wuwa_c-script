using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EF9 RID: 20217
	public class IBatchBulletCasterComponentT
	{
		// Token: 0x17009177 RID: 37239
		// (get) Token: 0x0601FEF6 RID: 130806 RVA: 0x00471E7E File Offset: 0x0047007E
		// (set) Token: 0x0601FEF7 RID: 130807 RVA: 0x00471E86 File Offset: 0x00470086
		public bool Disabled { get; set; }

		// Token: 0x17009178 RID: 37240
		// (get) Token: 0x0601FEF8 RID: 130808 RVA: 0x00471E8F File Offset: 0x0047008F
		// (set) Token: 0x0601FEF9 RID: 130809 RVA: 0x00471E97 File Offset: 0x00470097
		public string WarningEffect { get; set; }

		// Token: 0x17009179 RID: 37241
		// (get) Token: 0x0601FEFA RID: 130810 RVA: 0x00471EA0 File Offset: 0x004700A0
		// (set) Token: 0x0601FEFB RID: 130811 RVA: 0x00471EA8 File Offset: 0x004700A8
		public EBatchBulletMovementType MovementType { get; set; }

		// Token: 0x1700917A RID: 37242
		// (get) Token: 0x0601FEFC RID: 130812 RVA: 0x00471EB1 File Offset: 0x004700B1
		// (set) Token: 0x0601FEFD RID: 130813 RVA: 0x00471EB9 File Offset: 0x004700B9
		public List<IPosRotT> BulletList { get; set; }

		// Token: 0x1700917B RID: 37243
		// (get) Token: 0x0601FEFE RID: 130814 RVA: 0x00471EC2 File Offset: 0x004700C2
		// (set) Token: 0x0601FEFF RID: 130815 RVA: 0x00471ECA File Offset: 0x004700CA
		public List<IBatchBulletItemT> BatchList { get; set; }

		// Token: 0x1700917C RID: 37244
		// (get) Token: 0x0601FF00 RID: 130816 RVA: 0x00471ED3 File Offset: 0x004700D3
		// (set) Token: 0x0601FF01 RID: 130817 RVA: 0x00471EDB File Offset: 0x004700DB
		public byte NullMask { get; set; }

		// Token: 0x0601FF02 RID: 130818 RVA: 0x00471EE4 File Offset: 0x004700E4
		public IBatchBulletCasterComponentT()
		{
			this.Disabled = false;
			this.WarningEffect = null;
			this.MovementType = EBatchBulletMovementType.Sprint;
			this.BulletList = null;
			this.BatchList = null;
			this.NullMask = 0;
		}
	}
}
