using System;
using Aki.UniverseEditor.Interface.Fbs.Shape;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200725F RID: 29279
	public class IMotorRadioDisableByAbsoluteRangeT
	{
		// Token: 0x1700D6B2 RID: 54962
		// (get) Token: 0x06033048 RID: 208968 RVA: 0x006E310D File Offset: 0x006E130D
		// (set) Token: 0x06033049 RID: 208969 RVA: 0x006E3115 File Offset: 0x006E1315
		public EMotorRadioDisableRangeType Type { get; set; }

		// Token: 0x1700D6B3 RID: 54963
		// (get) Token: 0x0603304A RID: 208970 RVA: 0x006E311E File Offset: 0x006E131E
		// (set) Token: 0x0603304B RID: 208971 RVA: 0x006E3126 File Offset: 0x006E1326
		public TRangeUnion Range { get; set; }

		// Token: 0x1700D6B4 RID: 54964
		// (get) Token: 0x0603304C RID: 208972 RVA: 0x006E312F File Offset: 0x006E132F
		// (set) Token: 0x0603304D RID: 208973 RVA: 0x006E3137 File Offset: 0x006E1337
		public int ExtraRange { get; set; }

		// Token: 0x0603304E RID: 208974 RVA: 0x006E3140 File Offset: 0x006E1340
		public IMotorRadioDisableByAbsoluteRangeT()
		{
			this.Type = EMotorRadioDisableRangeType.ByAreaId;
			this.Range = null;
			this.ExtraRange = 0;
		}
	}
}
