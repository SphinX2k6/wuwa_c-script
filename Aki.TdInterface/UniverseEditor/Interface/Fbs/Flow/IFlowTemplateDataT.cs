using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004BA5 RID: 19365
	public class IFlowTemplateDataT
	{
		// Token: 0x17008910 RID: 35088
		// (get) Token: 0x0601D8AE RID: 121006 RVA: 0x00425D62 File Offset: 0x00423F62
		// (set) Token: 0x0601D8AF RID: 121007 RVA: 0x00425D6A File Offset: 0x00423F6A
		public int TemplateId { get; set; }

		// Token: 0x17008911 RID: 35089
		// (get) Token: 0x0601D8B0 RID: 121008 RVA: 0x00425D73 File Offset: 0x00423F73
		// (set) Token: 0x0601D8B1 RID: 121009 RVA: 0x00425D7B File Offset: 0x00423F7B
		public string Name { get; set; }

		// Token: 0x17008912 RID: 35090
		// (get) Token: 0x0601D8B2 RID: 121010 RVA: 0x00425D84 File Offset: 0x00423F84
		// (set) Token: 0x0601D8B3 RID: 121011 RVA: 0x00425D8C File Offset: 0x00423F8C
		public List<IPosAT> ActorDataArray { get; set; }

		// Token: 0x17008913 RID: 35091
		// (get) Token: 0x0601D8B4 RID: 121012 RVA: 0x00425D95 File Offset: 0x00423F95
		// (set) Token: 0x0601D8B5 RID: 121013 RVA: 0x00425D9D File Offset: 0x00423F9D
		public List<ICameraParamT> CameraParamMap { get; set; }

		// Token: 0x0601D8B6 RID: 121014 RVA: 0x00425DA6 File Offset: 0x00423FA6
		public IFlowTemplateDataT()
		{
			this.TemplateId = 0;
			this.Name = null;
			this.ActorDataArray = null;
			this.CameraParamMap = null;
		}
	}
}
