using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004188 RID: 16776
	public class ITakePhoto2SequenceConditionT
	{
		// Token: 0x170076ED RID: 30445
		// (get) Token: 0x06018AC1 RID: 101057 RVA: 0x0038DBCD File Offset: 0x0038BDCD
		// (set) Token: 0x06018AC2 RID: 101058 RVA: 0x0038DBD5 File Offset: 0x0038BDD5
		public string SequencePath { get; set; }

		// Token: 0x06018AC3 RID: 101059 RVA: 0x0038DBDE File Offset: 0x0038BDDE
		public ITakePhoto2SequenceConditionT()
		{
			this.SequencePath = null;
		}
	}
}
