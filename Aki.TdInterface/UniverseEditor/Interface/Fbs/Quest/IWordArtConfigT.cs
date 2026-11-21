using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046FB RID: 18171
	public class IWordArtConfigT
	{
		// Token: 0x17007F44 RID: 32580
		// (get) Token: 0x0601ABC3 RID: 109507 RVA: 0x003CC8D3 File Offset: 0x003CAAD3
		// (set) Token: 0x0601ABC4 RID: 109508 RVA: 0x003CC8DB File Offset: 0x003CAADB
		public INumberWordArtEffectiveTargetTypeT EffectiveTarget { get; set; }

		// Token: 0x17007F45 RID: 32581
		// (get) Token: 0x0601ABC5 RID: 109509 RVA: 0x003CC8E4 File Offset: 0x003CAAE4
		// (set) Token: 0x0601ABC6 RID: 109510 RVA: 0x003CC8EC File Offset: 0x003CAAEC
		public IWordArtDefaultResourceTypeT Resource { get; set; }

		// Token: 0x0601ABC7 RID: 109511 RVA: 0x003CC8F5 File Offset: 0x003CAAF5
		public IWordArtConfigT()
		{
			this.EffectiveTarget = null;
			this.Resource = null;
		}
	}
}
