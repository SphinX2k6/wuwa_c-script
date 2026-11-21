using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E4F RID: 28239
	public class IFixedPosT
	{
		// Token: 0x1700CF02 RID: 52994
		// (get) Token: 0x06030C87 RID: 199815 RVA: 0x0069EE33 File Offset: 0x0069D033
		// (set) Token: 0x06030C88 RID: 199816 RVA: 0x0069EE3B File Offset: 0x0069D03B
		public ETeleportType Type { get; set; }

		// Token: 0x1700CF03 RID: 52995
		// (get) Token: 0x06030C89 RID: 199817 RVA: 0x0069EE44 File Offset: 0x0069D044
		// (set) Token: 0x06030C8A RID: 199818 RVA: 0x0069EE4C File Offset: 0x0069D04C
		public IPosAT TargetPos { get; set; }

		// Token: 0x06030C8B RID: 199819 RVA: 0x0069EE55 File Offset: 0x0069D055
		public IFixedPosT()
		{
			this.Type = ETeleportType.FixedPos;
			this.TargetPos = null;
		}
	}
}
