using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Actor;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006932 RID: 26930
	public class IChangeActorMaterialDataT
	{
		// Token: 0x1700C644 RID: 50756
		// (get) Token: 0x0602E282 RID: 189058 RVA: 0x0064E85E File Offset: 0x0064CA5E
		// (set) Token: 0x0602E283 RID: 189059 RVA: 0x0064E866 File Offset: 0x0064CA66
		public EModifyActorMaterialType Type { get; set; }

		// Token: 0x1700C645 RID: 50757
		// (get) Token: 0x0602E284 RID: 189060 RVA: 0x0064E86F File Offset: 0x0064CA6F
		// (set) Token: 0x0602E285 RID: 189061 RVA: 0x0064E877 File Offset: 0x0064CA77
		public string MaterialData { get; set; }

		// Token: 0x1700C646 RID: 50758
		// (get) Token: 0x0602E286 RID: 189062 RVA: 0x0064E880 File Offset: 0x0064CA80
		// (set) Token: 0x0602E287 RID: 189063 RVA: 0x0064E888 File Offset: 0x0064CA88
		public List<IActorRefT> ActorRefs { get; set; }

		// Token: 0x0602E288 RID: 189064 RVA: 0x0064E891 File Offset: 0x0064CA91
		public IChangeActorMaterialDataT()
		{
			this.Type = EModifyActorMaterialType.ChangeMaterialData;
			this.MaterialData = null;
			this.ActorRefs = null;
		}
	}
}
