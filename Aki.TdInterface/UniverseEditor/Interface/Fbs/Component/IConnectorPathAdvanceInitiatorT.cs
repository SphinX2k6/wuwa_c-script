using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200556C RID: 21868
	public class IConnectorPathAdvanceInitiatorT
	{
		// Token: 0x17009C69 RID: 40041
		// (get) Token: 0x06022BAB RID: 142251 RVA: 0x004C8A5F File Offset: 0x004C6C5F
		// (set) Token: 0x06022BAC RID: 142252 RVA: 0x004C8A67 File Offset: 0x004C6C67
		public string ActiveState { get; set; }

		// Token: 0x17009C6A RID: 40042
		// (get) Token: 0x06022BAD RID: 142253 RVA: 0x004C8A70 File Offset: 0x004C6C70
		// (set) Token: 0x06022BAE RID: 142254 RVA: 0x004C8A78 File Offset: 0x004C6C78
		public List<int> Paths { get; set; }

		// Token: 0x17009C6B RID: 40043
		// (get) Token: 0x06022BAF RID: 142255 RVA: 0x004C8A81 File Offset: 0x004C6C81
		// (set) Token: 0x06022BB0 RID: 142256 RVA: 0x004C8A89 File Offset: 0x004C6C89
		public int TargetEntity { get; set; }

		// Token: 0x17009C6C RID: 40044
		// (get) Token: 0x06022BB1 RID: 142257 RVA: 0x004C8A92 File Offset: 0x004C6C92
		// (set) Token: 0x06022BB2 RID: 142258 RVA: 0x004C8A9A File Offset: 0x004C6C9A
		public float AdvanceSpeed { get; set; }

		// Token: 0x17009C6D RID: 40045
		// (get) Token: 0x06022BB3 RID: 142259 RVA: 0x004C8AA3 File Offset: 0x004C6CA3
		// (set) Token: 0x06022BB4 RID: 142260 RVA: 0x004C8AAB File Offset: 0x004C6CAB
		public EConnectorPathAdvanceVisualType VisualType { get; set; }

		// Token: 0x17009C6E RID: 40046
		// (get) Token: 0x06022BB5 RID: 142261 RVA: 0x004C8AB4 File Offset: 0x004C6CB4
		// (set) Token: 0x06022BB6 RID: 142262 RVA: 0x004C8ABC File Offset: 0x004C6CBC
		public IConnectorPathAdvanceVasePlantVisualT VisualConfig { get; set; }

		// Token: 0x17009C6F RID: 40047
		// (get) Token: 0x06022BB7 RID: 142263 RVA: 0x004C8AC5 File Offset: 0x004C6CC5
		// (set) Token: 0x06022BB8 RID: 142264 RVA: 0x004C8ACD File Offset: 0x004C6CCD
		public List<IDynamicEntityMatchT> KeepConditions { get; set; }

		// Token: 0x17009C70 RID: 40048
		// (get) Token: 0x06022BB9 RID: 142265 RVA: 0x004C8AD6 File Offset: 0x004C6CD6
		// (set) Token: 0x06022BBA RID: 142266 RVA: 0x004C8ADE File Offset: 0x004C6CDE
		public byte NullMask { get; set; }

		// Token: 0x06022BBB RID: 142267 RVA: 0x004C8AE8 File Offset: 0x004C6CE8
		public IConnectorPathAdvanceInitiatorT()
		{
			this.ActiveState = null;
			this.Paths = null;
			this.TargetEntity = 0;
			this.AdvanceSpeed = 0f;
			this.VisualType = EConnectorPathAdvanceVisualType.VasePlant;
			this.VisualConfig = null;
			this.KeepConditions = null;
			this.NullMask = 0;
		}
	}
}
