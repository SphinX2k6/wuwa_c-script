using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005158 RID: 20824
	public class IOnlinePlayerConditionTargetT
	{
		// Token: 0x17009535 RID: 38197
		// (get) Token: 0x06020C25 RID: 134181 RVA: 0x00489826 File Offset: 0x00487A26
		// (set) Token: 0x06020C26 RID: 134182 RVA: 0x0048982E File Offset: 0x00487A2E
		public EOnlinePlayerConditionTarget Type { get; set; }

		// Token: 0x06020C27 RID: 134183 RVA: 0x00489837 File Offset: 0x00487A37
		public IOnlinePlayerConditionTargetT()
		{
			this.Type = EOnlinePlayerConditionTarget.Host;
		}
	}
}
