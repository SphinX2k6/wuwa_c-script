using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200728C RID: 29324
	public class IMotorSpeedUpConfigT
	{
		// Token: 0x1700D6F3 RID: 55027
		// (get) Token: 0x0603319A RID: 209306 RVA: 0x006E5530 File Offset: 0x006E3730
		// (set) Token: 0x0603319B RID: 209307 RVA: 0x006E5538 File Offset: 0x006E3738
		public EMotorParamsChangeType Type { get; set; }

		// Token: 0x1700D6F4 RID: 55028
		// (get) Token: 0x0603319C RID: 209308 RVA: 0x006E5541 File Offset: 0x006E3741
		// (set) Token: 0x0603319D RID: 209309 RVA: 0x006E5549 File Offset: 0x006E3749
		public EMotorSpeedUpConfigTag SpeedUpTagId { get; set; }

		// Token: 0x0603319E RID: 209310 RVA: 0x006E5552 File Offset: 0x006E3752
		public IMotorSpeedUpConfigT()
		{
			this.Type = EMotorParamsChangeType.SpeedUp;
			this.SpeedUpTagId = EMotorSpeedUpConfigTag.None;
		}
	}
}
