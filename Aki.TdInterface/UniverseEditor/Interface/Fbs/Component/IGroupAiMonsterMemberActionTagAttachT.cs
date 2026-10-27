using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005345 RID: 21317
	public class IGroupAiMonsterMemberActionTagAttachT
	{
		// Token: 0x17009C97 RID: 40087
		// (get) Token: 0x06022DD0 RID: 142800 RVA: 0x004D46C9 File Offset: 0x004D28C9
		// (set) Token: 0x06022DD1 RID: 142801 RVA: 0x004D46D1 File Offset: 0x004D28D1
		public string ActionTag { get; set; }

		// Token: 0x17009C98 RID: 40088
		// (get) Token: 0x06022DD2 RID: 142802 RVA: 0x004D46DA File Offset: 0x004D28DA
		// (set) Token: 0x06022DD3 RID: 142803 RVA: 0x004D46E2 File Offset: 0x004D28E2
		public int AttachEntityId { get; set; }

		// Token: 0x17009C99 RID: 40089
		// (get) Token: 0x06022DD4 RID: 142804 RVA: 0x004D46EB File Offset: 0x004D28EB
		// (set) Token: 0x06022DD5 RID: 142805 RVA: 0x004D46F3 File Offset: 0x004D28F3
		public byte NullMask { get; set; }

		// Token: 0x06022DD6 RID: 142806 RVA: 0x004D46FC File Offset: 0x004D28FC
		public IGroupAiMonsterMemberActionTagAttachT()
		{
			this.ActionTag = null;
			this.AttachEntityId = 0;
			this.NullMask = 0;
		}
	}
}
