using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A53 RID: 23123
	public class ITemplateEntitySpawnerComponentT
	{
		// Token: 0x1700ADF4 RID: 44532
		// (get) Token: 0x06027536 RID: 161078 RVA: 0x0056937A File Offset: 0x0056757A
		// (set) Token: 0x06027537 RID: 161079 RVA: 0x00569382 File Offset: 0x00567582
		public bool Disabled { get; set; }

		// Token: 0x1700ADF5 RID: 44533
		// (get) Token: 0x06027538 RID: 161080 RVA: 0x0056938B File Offset: 0x0056758B
		// (set) Token: 0x06027539 RID: 161081 RVA: 0x00569393 File Offset: 0x00567593
		public IConditionGroupT SpawnConditions { get; set; }

		// Token: 0x1700ADF6 RID: 44534
		// (get) Token: 0x0602753A RID: 161082 RVA: 0x0056939C File Offset: 0x0056759C
		// (set) Token: 0x0602753B RID: 161083 RVA: 0x005693A4 File Offset: 0x005675A4
		public IConditionGroupT ClearConditions { get; set; }

		// Token: 0x1700ADF7 RID: 44535
		// (get) Token: 0x0602753C RID: 161084 RVA: 0x005693AD File Offset: 0x005675AD
		// (set) Token: 0x0602753D RID: 161085 RVA: 0x005693B5 File Offset: 0x005675B5
		public ITemplateMatrixT SpawnConfig { get; set; }

		// Token: 0x1700ADF8 RID: 44536
		// (get) Token: 0x0602753E RID: 161086 RVA: 0x005693BE File Offset: 0x005675BE
		// (set) Token: 0x0602753F RID: 161087 RVA: 0x005693C6 File Offset: 0x005675C6
		public byte NullMask { get; set; }

		// Token: 0x06027540 RID: 161088 RVA: 0x005693CF File Offset: 0x005675CF
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
