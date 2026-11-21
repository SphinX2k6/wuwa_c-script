using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E61 RID: 28257
	public class IFixTeleControllerResetPosT
	{
		// Token: 0x1700CF15 RID: 53013
		// (get) Token: 0x06030D01 RID: 199937 RVA: 0x0069FA0E File Offset: 0x0069DC0E
		// (set) Token: 0x06030D02 RID: 199938 RVA: 0x0069FA16 File Offset: 0x0069DC16
		public int PositionEntityId { get; set; }

		// Token: 0x06030D03 RID: 199939 RVA: 0x0069FA1F File Offset: 0x0069DC1F
		public IFixTeleControllerResetPosT()
		{
			this.PositionEntityId = 0;
		}
	}
}
