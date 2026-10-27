using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004737 RID: 18231
	public class IFavoriteFlowNodeInfoT
	{
		// Token: 0x170082C4 RID: 33476
		// (get) Token: 0x0601C097 RID: 114839 RVA: 0x003F9146 File Offset: 0x003F7346
		// (set) Token: 0x0601C098 RID: 114840 RVA: 0x003F914E File Offset: 0x003F734E
		public string HighLightPath { get; set; }

		// Token: 0x170082C5 RID: 33477
		// (get) Token: 0x0601C099 RID: 114841 RVA: 0x003F9157 File Offset: 0x003F7357
		// (set) Token: 0x0601C09A RID: 114842 RVA: 0x003F915F File Offset: 0x003F735F
		public IFlowStateIndexT FlowStateIndex { get; set; }

		// Token: 0x170082C6 RID: 33478
		// (get) Token: 0x0601C09B RID: 114843 RVA: 0x003F9168 File Offset: 0x003F7368
		// (set) Token: 0x0601C09C RID: 114844 RVA: 0x003F9170 File Offset: 0x003F7370
		public string Desc { get; set; }

		// Token: 0x0601C09D RID: 114845 RVA: 0x003F9179 File Offset: 0x003F7379
		public IFavoriteFlowNodeInfoT()
		{
			this.HighLightPath = null;
			this.FlowStateIndex = null;
			this.Desc = null;
		}
	}
}
