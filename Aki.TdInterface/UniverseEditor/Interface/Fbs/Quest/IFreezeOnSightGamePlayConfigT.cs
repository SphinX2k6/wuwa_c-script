using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042AE RID: 17070
	public class IFreezeOnSightGamePlayConfigT
	{
		// Token: 0x170074C9 RID: 29897
		// (get) Token: 0x06017E98 RID: 97944 RVA: 0x0036A2AE File Offset: 0x003684AE
		// (set) Token: 0x06017E99 RID: 97945 RVA: 0x0036A2B6 File Offset: 0x003684B6
		public ESpecialGamePlayConfigType Type { get; set; }

		// Token: 0x06017E9A RID: 97946 RVA: 0x0036A2BF File Offset: 0x003684BF
		public IFreezeOnSightGamePlayConfigT()
		{
			this.Type = ESpecialGamePlayConfigType.Stalking;
		}
	}
}
