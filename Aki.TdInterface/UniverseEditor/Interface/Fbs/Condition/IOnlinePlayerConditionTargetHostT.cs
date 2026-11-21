using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200515B RID: 20827
	public class IOnlinePlayerConditionTargetHostT
	{
		// Token: 0x17009538 RID: 38200
		// (get) Token: 0x06020C37 RID: 134199 RVA: 0x0048999E File Offset: 0x00487B9E
		// (set) Token: 0x06020C38 RID: 134200 RVA: 0x004899A6 File Offset: 0x00487BA6
		public EOnlinePlayerConditionTarget Type { get; set; }

		// Token: 0x06020C39 RID: 134201 RVA: 0x004899AF File Offset: 0x00487BAF
		public IOnlinePlayerConditionTargetHostT()
		{
			this.Type = EOnlinePlayerConditionTarget.Host;
		}
	}
}
