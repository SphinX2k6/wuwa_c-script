using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006060 RID: 24672
	public class ITemplateEntitySpawnerComponentT
	{
		// Token: 0x1700B72C RID: 46892
		// (get) Token: 0x06029AAE RID: 170670 RVA: 0x005B0386 File Offset: 0x005AE586
		// (set) Token: 0x06029AAF RID: 170671 RVA: 0x005B038E File Offset: 0x005AE58E
		public bool Disabled { get; set; }

		// Token: 0x1700B72D RID: 46893
		// (get) Token: 0x06029AB0 RID: 170672 RVA: 0x005B0397 File Offset: 0x005AE597
		// (set) Token: 0x06029AB1 RID: 170673 RVA: 0x005B039F File Offset: 0x005AE59F
		public IConditionGroupT SpawnConditions { get; set; }

		// Token: 0x1700B72E RID: 46894
		// (get) Token: 0x06029AB2 RID: 170674 RVA: 0x005B03A8 File Offset: 0x005AE5A8
		// (set) Token: 0x06029AB3 RID: 170675 RVA: 0x005B03B0 File Offset: 0x005AE5B0
		public IConditionGroupT ClearConditions { get; set; }

		// Token: 0x1700B72F RID: 46895
		// (get) Token: 0x06029AB4 RID: 170676 RVA: 0x005B03B9 File Offset: 0x005AE5B9
		// (set) Token: 0x06029AB5 RID: 170677 RVA: 0x005B03C1 File Offset: 0x005AE5C1
		public ITemplateMatrixT SpawnConfig { get; set; }

		// Token: 0x1700B730 RID: 46896
		// (get) Token: 0x06029AB6 RID: 170678 RVA: 0x005B03CA File Offset: 0x005AE5CA
		// (set) Token: 0x06029AB7 RID: 170679 RVA: 0x005B03D2 File Offset: 0x005AE5D2
		public byte NullMask { get; set; }

		// Token: 0x06029AB8 RID: 170680 RVA: 0x005B03DB File Offset: 0x005AE5DB
		public ITemplateEntitySpawnerComponentT()
		{
			this.Disabled = false;
			this.SpawnConditions = null;
			this.ClearConditions = null;
			this.SpawnConfig = null;
			this.NullMask = 0;
		}
	}
}
