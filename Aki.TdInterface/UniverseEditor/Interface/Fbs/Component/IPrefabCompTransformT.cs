using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D7D RID: 23933
	public class IPrefabCompTransformT
	{
		// Token: 0x1700B027 RID: 45095
		// (get) Token: 0x06027DA3 RID: 163235 RVA: 0x00573B01 File Offset: 0x00571D01
		// (set) Token: 0x06027DA4 RID: 163236 RVA: 0x00573B09 File Offset: 0x00571D09
		public string ReferenceActorKey { get; set; }

		// Token: 0x1700B028 RID: 45096
		// (get) Token: 0x06027DA5 RID: 163237 RVA: 0x00573B12 File Offset: 0x00571D12
		// (set) Token: 0x06027DA6 RID: 163238 RVA: 0x00573B1A File Offset: 0x00571D1A
		public IPrefabCompTransformItemT Location { get; set; }

		// Token: 0x1700B029 RID: 45097
		// (get) Token: 0x06027DA7 RID: 163239 RVA: 0x00573B23 File Offset: 0x00571D23
		// (set) Token: 0x06027DA8 RID: 163240 RVA: 0x00573B2B File Offset: 0x00571D2B
		public IPrefabCompTransformItemT Rotation { get; set; }

		// Token: 0x1700B02A RID: 45098
		// (get) Token: 0x06027DA9 RID: 163241 RVA: 0x00573B34 File Offset: 0x00571D34
		// (set) Token: 0x06027DAA RID: 163242 RVA: 0x00573B3C File Offset: 0x00571D3C
		public IPrefabCompTransformItemT Scale { get; set; }

		// Token: 0x06027DAB RID: 163243 RVA: 0x00573B45 File Offset: 0x00571D45
		public IPrefabCompTransformT()
		{
			this.ReferenceActorKey = null;
			this.Location = null;
			this.Rotation = null;
			this.Scale = null;
		}
	}
}
