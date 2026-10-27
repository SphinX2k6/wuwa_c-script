using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CAC RID: 27820
	public class IPhoneSystemInteractT
	{
		// Token: 0x1700CF26 RID: 53030
		// (get) Token: 0x06031077 RID: 200823 RVA: 0x006A7A3D File Offset: 0x006A5C3D
		// (set) Token: 0x06031078 RID: 200824 RVA: 0x006A7A45 File Offset: 0x006A5C45
		public TPhoneSystemInteractUnion InteractType { get; set; }

		// Token: 0x06031079 RID: 200825 RVA: 0x006A7A4E File Offset: 0x006A5C4E
		public IPhoneSystemInteractT()
		{
			this.InteractType = null;
		}
	}
}
