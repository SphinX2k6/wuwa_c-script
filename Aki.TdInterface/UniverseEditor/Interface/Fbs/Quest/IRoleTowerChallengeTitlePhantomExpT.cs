using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004506 RID: 17670
	public class IRoleTowerChallengeTitlePhantomExpT
	{
		// Token: 0x17007B02 RID: 31490
		// (get) Token: 0x0601992F RID: 104751 RVA: 0x003A539A File Offset: 0x003A359A
		// (set) Token: 0x06019930 RID: 104752 RVA: 0x003A53A2 File Offset: 0x003A35A2
		public ERoleTowerChallengeTitleType Type { get; set; }

		// Token: 0x06019931 RID: 104753 RVA: 0x003A53AB File Offset: 0x003A35AB
		public IRoleTowerChallengeTitlePhantomExpT()
		{
			this.Type = ERoleTowerChallengeTitleType.KillProgress;
		}
	}
}
