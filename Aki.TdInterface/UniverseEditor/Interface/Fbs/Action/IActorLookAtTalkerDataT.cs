using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200674F RID: 26447
	public class IActorLookAtTalkerDataT
	{
		// Token: 0x1700C051 RID: 49233
		// (get) Token: 0x0602CD23 RID: 183587 RVA: 0x006214EA File Offset: 0x0061F6EA
		// (set) Token: 0x0602CD24 RID: 183588 RVA: 0x006214F2 File Offset: 0x0061F6F2
		public EActorLookAtMode Type { get; set; }

		// Token: 0x1700C052 RID: 49234
		// (get) Token: 0x0602CD25 RID: 183589 RVA: 0x006214FB File Offset: 0x0061F6FB
		// (set) Token: 0x0602CD26 RID: 183590 RVA: 0x00621503 File Offset: 0x0061F703
		public bool Lock { get; set; }

		// Token: 0x1700C053 RID: 49235
		// (get) Token: 0x0602CD27 RID: 183591 RVA: 0x0062150C File Offset: 0x0061F70C
		// (set) Token: 0x0602CD28 RID: 183592 RVA: 0x00621514 File Offset: 0x0061F714
		public byte NullMask { get; set; }

		// Token: 0x0602CD29 RID: 183593 RVA: 0x0062151D File Offset: 0x0061F71D
		public IActorLookAtTalkerDataT()
		{
			this.Type = EActorLookAtMode.Talker;
			this.Lock = false;
			this.NullMask = 0;
		}
	}
}
