using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052AA RID: 21162
	public class IFollowTrackComponentT
	{
		// Token: 0x17009B31 RID: 39729
		// (get) Token: 0x06022809 RID: 141321 RVA: 0x004C8775 File Offset: 0x004C6975
		// (set) Token: 0x0602280A RID: 141322 RVA: 0x004C877D File Offset: 0x004C697D
		public bool Disabled { get; set; }

		// Token: 0x17009B32 RID: 39730
		// (get) Token: 0x0602280B RID: 141323 RVA: 0x004C8786 File Offset: 0x004C6986
		// (set) Token: 0x0602280C RID: 141324 RVA: 0x004C878E File Offset: 0x004C698E
		public float Range { get; set; }

		// Token: 0x17009B33 RID: 39731
		// (get) Token: 0x0602280D RID: 141325 RVA: 0x004C8797 File Offset: 0x004C6997
		// (set) Token: 0x0602280E RID: 141326 RVA: 0x004C879F File Offset: 0x004C699F
		public int SplineEntityId { get; set; }

		// Token: 0x17009B34 RID: 39732
		// (get) Token: 0x0602280F RID: 141327 RVA: 0x004C87A8 File Offset: 0x004C69A8
		// (set) Token: 0x06022810 RID: 141328 RVA: 0x004C87B0 File Offset: 0x004C69B0
		public TFollowTrackEndOptionUnion EndType { get; set; }

		// Token: 0x17009B35 RID: 39733
		// (get) Token: 0x06022811 RID: 141329 RVA: 0x004C87B9 File Offset: 0x004C69B9
		// (set) Token: 0x06022812 RID: 141330 RVA: 0x004C87C1 File Offset: 0x004C69C1
		public byte NullMask { get; set; }

		// Token: 0x06022813 RID: 141331 RVA: 0x004C87CA File Offset: 0x004C69CA
		public IFollowTrackComponentT()
		{
			this.Disabled = false;
			this.Range = 0f;
			this.SplineEntityId = 0;
			this.EndType = null;
			this.NullMask = 0;
		}
	}
}
