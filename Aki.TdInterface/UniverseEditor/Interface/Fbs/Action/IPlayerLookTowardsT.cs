using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D00 RID: 27904
	public class IPlayerLookTowardsT
	{
		// Token: 0x1700CFCF RID: 53199
		// (get) Token: 0x06031350 RID: 201552 RVA: 0x006ACE91 File Offset: 0x006AB091
		// (set) Token: 0x06031351 RID: 201553 RVA: 0x006ACE99 File Offset: 0x006AB099
		public TCharacterLookAtDataUnion Target { get; set; }

		// Token: 0x06031352 RID: 201554 RVA: 0x006ACEA2 File Offset: 0x006AB0A2
		public IPlayerLookTowardsT()
		{
			this.Target = null;
		}
	}
}
