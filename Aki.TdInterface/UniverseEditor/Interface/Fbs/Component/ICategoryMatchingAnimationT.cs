using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F5C RID: 20316
	public class ICategoryMatchingAnimationT
	{
		// Token: 0x170092A9 RID: 37545
		// (get) Token: 0x06020371 RID: 131953 RVA: 0x0047B901 File Offset: 0x00479B01
		// (set) Token: 0x06020372 RID: 131954 RVA: 0x0047B909 File Offset: 0x00479B09
		public IVectorInfoT MatchPos { get; set; }

		// Token: 0x170092AA RID: 37546
		// (get) Token: 0x06020373 RID: 131955 RVA: 0x0047B912 File Offset: 0x00479B12
		// (set) Token: 0x06020374 RID: 131956 RVA: 0x0047B91A File Offset: 0x00479B1A
		public IVectorInfoT MatchRot { get; set; }

		// Token: 0x170092AB RID: 37547
		// (get) Token: 0x06020375 RID: 131957 RVA: 0x0047B923 File Offset: 0x00479B23
		// (set) Token: 0x06020376 RID: 131958 RVA: 0x0047B92B File Offset: 0x00479B2B
		public string MatchReferenceKey { get; set; }

		// Token: 0x170092AC RID: 37548
		// (get) Token: 0x06020377 RID: 131959 RVA: 0x0047B934 File Offset: 0x00479B34
		// (set) Token: 0x06020378 RID: 131960 RVA: 0x0047B93C File Offset: 0x00479B3C
		public string MatchSequence { get; set; }

		// Token: 0x170092AD RID: 37549
		// (get) Token: 0x06020379 RID: 131961 RVA: 0x0047B945 File Offset: 0x00479B45
		// (set) Token: 0x0602037A RID: 131962 RVA: 0x0047B94D File Offset: 0x00479B4D
		public IVectorInfoT MatchSequenceOffset { get; set; }

		// Token: 0x0602037B RID: 131963 RVA: 0x0047B956 File Offset: 0x00479B56
		public ICategoryMatchingAnimationT()
		{
			this.MatchPos = null;
			this.MatchRot = null;
			this.MatchReferenceKey = null;
			this.MatchSequence = null;
			this.MatchSequenceOffset = null;
		}
	}
}
