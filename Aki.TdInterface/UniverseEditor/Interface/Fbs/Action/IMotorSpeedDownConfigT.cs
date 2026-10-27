using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B43 RID: 27459
	public class IMotorSpeedDownConfigT
	{
		// Token: 0x1700CC09 RID: 52233
		// (get) Token: 0x0603032D RID: 197421 RVA: 0x0068CD74 File Offset: 0x0068AF74
		// (set) Token: 0x0603032E RID: 197422 RVA: 0x0068CD7C File Offset: 0x0068AF7C
		public EMotorParamsChangeType Type { get; set; }

		// Token: 0x1700CC0A RID: 52234
		// (get) Token: 0x0603032F RID: 197423 RVA: 0x0068CD85 File Offset: 0x0068AF85
		// (set) Token: 0x06030330 RID: 197424 RVA: 0x0068CD8D File Offset: 0x0068AF8D
		public EMotorSpeedDownConfig SpeedDownTagId { get; set; }

		// Token: 0x06030331 RID: 197425 RVA: 0x0068CD96 File Offset: 0x0068AF96
		public IMotorSpeedDownConfigT()
		{
			this.Type = EMotorParamsChangeType.SpeedUp;
			this.SpeedDownTagId = EMotorSpeedDownConfig.None;
		}
	}
}
