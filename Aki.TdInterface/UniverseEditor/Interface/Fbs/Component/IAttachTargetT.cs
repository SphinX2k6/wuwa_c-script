using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EBA RID: 20154
	public class IAttachTargetT
	{
		// Token: 0x17009096 RID: 37014
		// (get) Token: 0x0601FBD6 RID: 130006 RVA: 0x0046B14A File Offset: 0x0046934A
		// (set) Token: 0x0601FBD7 RID: 130007 RVA: 0x0046B152 File Offset: 0x00469352
		public EAttachType Type { get; set; }

		// Token: 0x0601FBD8 RID: 130008 RVA: 0x0046B15B File Offset: 0x0046935B
		public IAttachTargetT()
		{
			this.Type = EAttachType.Actor;
		}
	}
}
