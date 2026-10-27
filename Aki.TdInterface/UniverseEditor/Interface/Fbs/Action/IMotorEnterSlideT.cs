using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B1C RID: 27420
	public class IMotorEnterSlideT
	{
		// Token: 0x1700CBCF RID: 52175
		// (get) Token: 0x06030212 RID: 197138 RVA: 0x0068AE0C File Offset: 0x0068900C
		// (set) Token: 0x06030213 RID: 197139 RVA: 0x0068AE14 File Offset: 0x00689014
		public ELeisureInteract Type { get; set; }

		// Token: 0x1700CBD0 RID: 52176
		// (get) Token: 0x06030214 RID: 197140 RVA: 0x0068AE1D File Offset: 0x0068901D
		// (set) Token: 0x06030215 RID: 197141 RVA: 0x0068AE25 File Offset: 0x00689025
		public int EntityId { get; set; }

		// Token: 0x1700CBD1 RID: 52177
		// (get) Token: 0x06030216 RID: 197142 RVA: 0x0068AE2E File Offset: 0x0068902E
		// (set) Token: 0x06030217 RID: 197143 RVA: 0x0068AE36 File Offset: 0x00689036
		public EMotorEnterSlideMode EnterMode { get; set; }

		// Token: 0x1700CBD2 RID: 52178
		// (get) Token: 0x06030218 RID: 197144 RVA: 0x0068AE3F File Offset: 0x0068903F
		// (set) Token: 0x06030219 RID: 197145 RVA: 0x0068AE47 File Offset: 0x00689047
		public byte NullMask { get; set; }

		// Token: 0x0603021A RID: 197146 RVA: 0x0068AE50 File Offset: 0x00689050
		public IMotorEnterSlideT()
		{
			this.Type = ELeisureInteract.CustomSkill;
			this.EntityId = 0;
			this.EnterMode = EMotorEnterSlideMode.Jump;
			this.NullMask = 0;
		}
	}
}
