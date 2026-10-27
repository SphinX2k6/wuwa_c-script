using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A55 RID: 19029
	public class ICheckHonamiStoryChestOpenTimeT
	{
		// Token: 0x170089C1 RID: 35265
		// (get) Token: 0x0601DCD6 RID: 122070 RVA: 0x0043063C File Offset: 0x0042E83C
		// (set) Token: 0x0601DCD7 RID: 122071 RVA: 0x00430644 File Offset: 0x0042E844
		public ECondition Type { get; set; }

		// Token: 0x170089C2 RID: 35266
		// (get) Token: 0x0601DCD8 RID: 122072 RVA: 0x0043064D File Offset: 0x0042E84D
		// (set) Token: 0x0601DCD9 RID: 122073 RVA: 0x00430655 File Offset: 0x0042E855
		public EHonamiStoryChestType ChestType { get; set; }

		// Token: 0x170089C3 RID: 35267
		// (get) Token: 0x0601DCDA RID: 122074 RVA: 0x0043065E File Offset: 0x0042E85E
		// (set) Token: 0x0601DCDB RID: 122075 RVA: 0x00430666 File Offset: 0x0042E866
		public ECompare Compare { get; set; }

		// Token: 0x170089C4 RID: 35268
		// (get) Token: 0x0601DCDC RID: 122076 RVA: 0x0043066F File Offset: 0x0042E86F
		// (set) Token: 0x0601DCDD RID: 122077 RVA: 0x00430677 File Offset: 0x0042E877
		public int Time { get; set; }

		// Token: 0x0601DCDE RID: 122078 RVA: 0x00430680 File Offset: 0x0042E880
		public ICheckHonamiStoryChestOpenTimeT()
		{
			this.Type = ECondition.CompareVar;
			this.ChestType = EHonamiStoryChestType.CommonChest;
			this.Compare = ECompare.Eq;
			this.Time = 0;
		}
	}
}
