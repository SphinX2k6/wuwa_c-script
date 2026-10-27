using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F32 RID: 20274
	public class IBuffProducerComponentT
	{
		// Token: 0x17009224 RID: 37412
		// (get) Token: 0x0602017B RID: 131451 RVA: 0x00477183 File Offset: 0x00475383
		// (set) Token: 0x0602017C RID: 131452 RVA: 0x0047718B File Offset: 0x0047538B
		public bool Disabled { get; set; }

		// Token: 0x17009225 RID: 37413
		// (get) Token: 0x0602017D RID: 131453 RVA: 0x00477194 File Offset: 0x00475394
		// (set) Token: 0x0602017E RID: 131454 RVA: 0x0047719C File Offset: 0x0047539C
		public TAddBuffModeUnion AddBuffMode { get; set; }

		// Token: 0x17009226 RID: 37414
		// (get) Token: 0x0602017F RID: 131455 RVA: 0x004771A5 File Offset: 0x004753A5
		// (set) Token: 0x06020180 RID: 131456 RVA: 0x004771AD File Offset: 0x004753AD
		public long BuffId { get; set; }

		// Token: 0x17009227 RID: 37415
		// (get) Token: 0x06020181 RID: 131457 RVA: 0x004771B6 File Offset: 0x004753B6
		// (set) Token: 0x06020182 RID: 131458 RVA: 0x004771BE File Offset: 0x004753BE
		public byte NullMask { get; set; }

		// Token: 0x06020183 RID: 131459 RVA: 0x004771C7 File Offset: 0x004753C7
		public IBuffProducerComponentT()
		{
			this.Disabled = false;
			this.AddBuffMode = null;
			this.BuffId = 0L;
			this.NullMask = 0;
		}
	}
}
