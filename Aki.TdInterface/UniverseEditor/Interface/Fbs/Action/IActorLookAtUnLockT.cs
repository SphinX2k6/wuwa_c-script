using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006752 RID: 26450
	public class IActorLookAtUnLockT
	{
		// Token: 0x1700C056 RID: 49238
		// (get) Token: 0x0602CD39 RID: 183609 RVA: 0x006216BA File Offset: 0x0061F8BA
		// (set) Token: 0x0602CD3A RID: 183610 RVA: 0x006216C2 File Offset: 0x0061F8C2
		public EActorLookAtMode Type { get; set; }

		// Token: 0x0602CD3B RID: 183611 RVA: 0x006216CB File Offset: 0x0061F8CB
		public IActorLookAtUnLockT()
		{
			this.Type = EActorLookAtMode.Talker;
		}
	}
}
