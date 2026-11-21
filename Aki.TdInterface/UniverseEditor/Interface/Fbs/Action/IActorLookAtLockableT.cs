using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006743 RID: 26435
	public class IActorLookAtLockableT
	{
		// Token: 0x1700C031 RID: 49201
		// (get) Token: 0x0602CCB3 RID: 183475 RVA: 0x00620902 File Offset: 0x0061EB02
		// (set) Token: 0x0602CCB4 RID: 183476 RVA: 0x0062090A File Offset: 0x0061EB0A
		public EActorLookAtMode Type { get; set; }

		// Token: 0x1700C032 RID: 49202
		// (get) Token: 0x0602CCB5 RID: 183477 RVA: 0x00620913 File Offset: 0x0061EB13
		// (set) Token: 0x0602CCB6 RID: 183478 RVA: 0x0062091B File Offset: 0x0061EB1B
		public bool Lock { get; set; }

		// Token: 0x1700C033 RID: 49203
		// (get) Token: 0x0602CCB7 RID: 183479 RVA: 0x00620924 File Offset: 0x0061EB24
		// (set) Token: 0x0602CCB8 RID: 183480 RVA: 0x0062092C File Offset: 0x0061EB2C
		public byte NullMask { get; set; }

		// Token: 0x0602CCB9 RID: 183481 RVA: 0x00620935 File Offset: 0x0061EB35
		public IActorLookAtLockableT()
		{
			this.Type = EActorLookAtMode.Talker;
			this.Lock = false;
			this.NullMask = 0;
		}
	}
}
