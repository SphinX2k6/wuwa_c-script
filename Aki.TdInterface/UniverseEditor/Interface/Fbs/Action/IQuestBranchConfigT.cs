using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007577 RID: 30071
	public class IQuestBranchConfigT
	{
		// Token: 0x1700DD24 RID: 56612
		// (get) Token: 0x06034BD1 RID: 216017 RVA: 0x00717788 File Offset: 0x00715988
		// (set) Token: 0x06034BD2 RID: 216018 RVA: 0x00717790 File Offset: 0x00715990
		public bool EnableAnimation { get; set; }

		// Token: 0x1700DD25 RID: 56613
		// (get) Token: 0x06034BD3 RID: 216019 RVA: 0x00717799 File Offset: 0x00715999
		// (set) Token: 0x06034BD4 RID: 216020 RVA: 0x007177A1 File Offset: 0x007159A1
		public byte NullMask { get; set; }

		// Token: 0x06034BD5 RID: 216021 RVA: 0x007177AA File Offset: 0x007159AA
		public IQuestBranchConfigT()
		{
			this.EnableAnimation = false;
			this.NullMask = 0;
		}
	}
}
