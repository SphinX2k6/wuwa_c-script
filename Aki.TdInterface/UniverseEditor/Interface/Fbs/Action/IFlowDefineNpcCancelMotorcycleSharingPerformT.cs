using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E79 RID: 28281
	public class IFlowDefineNpcCancelMotorcycleSharingPerformT
	{
		// Token: 0x1700CF4A RID: 53066
		// (get) Token: 0x06030DDB RID: 200155 RVA: 0x006A1127 File Offset: 0x0069F327
		// (set) Token: 0x06030DDC RID: 200156 RVA: 0x006A112F File Offset: 0x0069F32F
		public ENpcGroupPerformType Type { get; set; }

		// Token: 0x1700CF4B RID: 53067
		// (get) Token: 0x06030DDD RID: 200157 RVA: 0x006A1138 File Offset: 0x0069F338
		// (set) Token: 0x06030DDE RID: 200158 RVA: 0x006A1140 File Offset: 0x0069F340
		public string Key { get; set; }

		// Token: 0x06030DDF RID: 200159 RVA: 0x006A1149 File Offset: 0x0069F349
		public IFlowDefineNpcCancelMotorcycleSharingPerformT()
		{
			this.Type = ENpcGroupPerformType.HandInHand;
			this.Key = null;
		}
	}
}
