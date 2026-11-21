using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B52 RID: 27474
	public class ICreatePrefabConfigT
	{
		// Token: 0x1700C9BA RID: 51642
		// (get) Token: 0x0602F481 RID: 193665 RVA: 0x006747C2 File Offset: 0x006729C2
		// (set) Token: 0x0602F482 RID: 193666 RVA: 0x006747CA File Offset: 0x006729CA
		public ECreatePrefabType Type { get; set; }

		// Token: 0x0602F483 RID: 193667 RVA: 0x006747D3 File Offset: 0x006729D3
		public ICreatePrefabConfigT()
		{
			this.Type = ECreatePrefabType.PrefabId;
		}
	}
}
