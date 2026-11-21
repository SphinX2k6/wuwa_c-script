using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E8B RID: 28299
	public class IFlowDefineNpcMotorcycleSharingPerformT
	{
		// Token: 0x1700CF61 RID: 53089
		// (get) Token: 0x06030E62 RID: 200290 RVA: 0x006A1F53 File Offset: 0x006A0153
		// (set) Token: 0x06030E63 RID: 200291 RVA: 0x006A1F5B File Offset: 0x006A015B
		public ENpcGroupPerformType Type { get; set; }

		// Token: 0x1700CF62 RID: 53090
		// (get) Token: 0x06030E64 RID: 200292 RVA: 0x006A1F64 File Offset: 0x006A0164
		// (set) Token: 0x06030E65 RID: 200293 RVA: 0x006A1F6C File Offset: 0x006A016C
		public string Key { get; set; }

		// Token: 0x06030E66 RID: 200294 RVA: 0x006A1F75 File Offset: 0x006A0175
		public IFlowDefineNpcMotorcycleSharingPerformT()
		{
			this.Type = ENpcGroupPerformType.HandInHand;
			this.Key = null;
		}
	}
}
