using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Actor;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062C1 RID: 25281
	public class IChangeActorMaterialDataT
	{
		// Token: 0x1700BCBA RID: 48314
		// (get) Token: 0x0602BB19 RID: 178969 RVA: 0x00603852 File Offset: 0x00601A52
		// (set) Token: 0x0602BB1A RID: 178970 RVA: 0x0060385A File Offset: 0x00601A5A
		public EModifyActorMaterialType Type { get; set; }

		// Token: 0x1700BCBB RID: 48315
		// (get) Token: 0x0602BB1B RID: 178971 RVA: 0x00603863 File Offset: 0x00601A63
		// (set) Token: 0x0602BB1C RID: 178972 RVA: 0x0060386B File Offset: 0x00601A6B
		public string MaterialData { get; set; }

		// Token: 0x1700BCBC RID: 48316
		// (get) Token: 0x0602BB1D RID: 178973 RVA: 0x00603874 File Offset: 0x00601A74
		// (set) Token: 0x0602BB1E RID: 178974 RVA: 0x0060387C File Offset: 0x00601A7C
		public List<IActorRefT> ActorRefs { get; set; }

		// Token: 0x0602BB1F RID: 178975 RVA: 0x00603885 File Offset: 0x00601A85
		public IChangeActorMaterialDataT()
		{
			this.Type = EModifyActorMaterialType.ChangeMaterialData;
			this.MaterialData = null;
			this.ActorRefs = null;
		}
	}
}
