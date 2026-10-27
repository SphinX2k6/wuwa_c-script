using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056DB RID: 22235
	public class IPasserbyNpcSpawnComponentT
	{
		// Token: 0x1700A57B RID: 42363
		// (get) Token: 0x06025258 RID: 152152 RVA: 0x00520BC1 File Offset: 0x0051EDC1
		// (set) Token: 0x06025259 RID: 152153 RVA: 0x00520BC9 File Offset: 0x0051EDC9
		public bool Disabled { get; set; }

		// Token: 0x1700A57C RID: 42364
		// (get) Token: 0x0602525A RID: 152154 RVA: 0x00520BD2 File Offset: 0x0051EDD2
		// (set) Token: 0x0602525B RID: 152155 RVA: 0x00520BDA File Offset: 0x0051EDDA
		public IPasserbyNpcSplineMoveT MoveConfig { get; set; }

		// Token: 0x1700A57D RID: 42365
		// (get) Token: 0x0602525C RID: 152156 RVA: 0x00520BE3 File Offset: 0x0051EDE3
		// (set) Token: 0x0602525D RID: 152157 RVA: 0x00520BEB File Offset: 0x0051EDEB
		public IPasserbyNpcFixIntervalSpawnT SpawnConfig { get; set; }

		// Token: 0x1700A57E RID: 42366
		// (get) Token: 0x0602525E RID: 152158 RVA: 0x00520BF4 File Offset: 0x0051EDF4
		// (set) Token: 0x0602525F RID: 152159 RVA: 0x00520BFC File Offset: 0x0051EDFC
		public IPasserbyNpcTemplateSourceT SourceConfig { get; set; }

		// Token: 0x1700A57F RID: 42367
		// (get) Token: 0x06025260 RID: 152160 RVA: 0x00520C05 File Offset: 0x0051EE05
		// (set) Token: 0x06025261 RID: 152161 RVA: 0x00520C0D File Offset: 0x0051EE0D
		public string NpcMaterialDa { get; set; }

		// Token: 0x1700A580 RID: 42368
		// (get) Token: 0x06025262 RID: 152162 RVA: 0x00520C16 File Offset: 0x0051EE16
		// (set) Token: 0x06025263 RID: 152163 RVA: 0x00520C1E File Offset: 0x0051EE1E
		public IPasserbyNpcDeviceGradeConfigT DeviceGradeConfig { get; set; }

		// Token: 0x1700A581 RID: 42369
		// (get) Token: 0x06025264 RID: 152164 RVA: 0x00520C27 File Offset: 0x0051EE27
		// (set) Token: 0x06025265 RID: 152165 RVA: 0x00520C2F File Offset: 0x0051EE2F
		public IConditionGroupT VisibleConditions { get; set; }

		// Token: 0x1700A582 RID: 42370
		// (get) Token: 0x06025266 RID: 152166 RVA: 0x00520C38 File Offset: 0x0051EE38
		// (set) Token: 0x06025267 RID: 152167 RVA: 0x00520C40 File Offset: 0x0051EE40
		public byte NullMask { get; set; }

		// Token: 0x06025268 RID: 152168 RVA: 0x00520C49 File Offset: 0x0051EE49
		public IPasserbyNpcSpawnComponentT()
		{
			this.Disabled = false;
			this.MoveConfig = null;
			this.SpawnConfig = null;
			this.SourceConfig = null;
			this.NpcMaterialDa = null;
			this.DeviceGradeConfig = null;
			this.VisibleConditions = null;
			this.NullMask = 0;
		}
	}
}
