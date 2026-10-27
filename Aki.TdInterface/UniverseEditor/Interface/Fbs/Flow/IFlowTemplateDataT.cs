using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x0200473D RID: 18237
	public class IFlowTemplateDataT
	{
		// Token: 0x170082CF RID: 33487
		// (get) Token: 0x0601C0D9 RID: 114905 RVA: 0x003F9AC6 File Offset: 0x003F7CC6
		// (set) Token: 0x0601C0DA RID: 114906 RVA: 0x003F9ACE File Offset: 0x003F7CCE
		public int TemplateId { get; set; }

		// Token: 0x170082D0 RID: 33488
		// (get) Token: 0x0601C0DB RID: 114907 RVA: 0x003F9AD7 File Offset: 0x003F7CD7
		// (set) Token: 0x0601C0DC RID: 114908 RVA: 0x003F9ADF File Offset: 0x003F7CDF
		public string Name { get; set; }

		// Token: 0x170082D1 RID: 33489
		// (get) Token: 0x0601C0DD RID: 114909 RVA: 0x003F9AE8 File Offset: 0x003F7CE8
		// (set) Token: 0x0601C0DE RID: 114910 RVA: 0x003F9AF0 File Offset: 0x003F7CF0
		public List<IPosAT> ActorDataArray { get; set; }

		// Token: 0x170082D2 RID: 33490
		// (get) Token: 0x0601C0DF RID: 114911 RVA: 0x003F9AF9 File Offset: 0x003F7CF9
		// (set) Token: 0x0601C0E0 RID: 114912 RVA: 0x003F9B01 File Offset: 0x003F7D01
		public List<ICameraParamT> CameraParamMap { get; set; }

		// Token: 0x0601C0E1 RID: 114913 RVA: 0x003F9B0A File Offset: 0x003F7D0A
		public IFlowTemplateDataT()
		{
			this.TemplateId = 0;
			this.Name = null;
			this.ActorDataArray = null;
			this.CameraParamMap = null;
		}
	}
}
