using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004080 RID: 16512
	public class IRecallConditionByTemplateT
	{
		// Token: 0x17007489 RID: 29833
		// (get) Token: 0x06018051 RID: 98385 RVA: 0x00377276 File Offset: 0x00375476
		// (set) Token: 0x06018052 RID: 98386 RVA: 0x0037727E File Offset: 0x0037547E
		public ERecallConditionType Type { get; set; }

		// Token: 0x1700748A RID: 29834
		// (get) Token: 0x06018053 RID: 98387 RVA: 0x00377287 File Offset: 0x00375487
		// (set) Token: 0x06018054 RID: 98388 RVA: 0x0037728F File Offset: 0x0037548F
		public ERecallOperation Operation { get; set; }

		// Token: 0x1700748B RID: 29835
		// (get) Token: 0x06018055 RID: 98389 RVA: 0x00377298 File Offset: 0x00375498
		// (set) Token: 0x06018056 RID: 98390 RVA: 0x003772A0 File Offset: 0x003754A0
		public List<string> Templates { get; set; }

		// Token: 0x1700748C RID: 29836
		// (get) Token: 0x06018057 RID: 98391 RVA: 0x003772A9 File Offset: 0x003754A9
		// (set) Token: 0x06018058 RID: 98392 RVA: 0x003772B1 File Offset: 0x003754B1
		public List<int> AreaIds { get; set; }

		// Token: 0x06018059 RID: 98393 RVA: 0x003772BA File Offset: 0x003754BA
		public IRecallConditionByTemplateT()
		{
			this.Type = ERecallConditionType.ByEntityType;
			this.Operation = ERecallOperation.Include;
			this.Templates = null;
			this.AreaIds = null;
		}
	}
}
