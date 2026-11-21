using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007289 RID: 29321
	public class IMotorSpeedDownConfigT
	{
		// Token: 0x1700D6EE RID: 55022
		// (get) Token: 0x06033184 RID: 209284 RVA: 0x006E5330 File Offset: 0x006E3530
		// (set) Token: 0x06033185 RID: 209285 RVA: 0x006E5338 File Offset: 0x006E3538
		public EMotorParamsChangeType Type { get; set; }

		// Token: 0x1700D6EF RID: 55023
		// (get) Token: 0x06033186 RID: 209286 RVA: 0x006E5341 File Offset: 0x006E3541
		// (set) Token: 0x06033187 RID: 209287 RVA: 0x006E5349 File Offset: 0x006E3549
		public EMotorSpeedDownConfig SpeedDownTagId { get; set; }

		// Token: 0x06033188 RID: 209288 RVA: 0x006E5352 File Offset: 0x006E3552
		public IMotorSpeedDownConfigT()
		{
			this.Type = EMotorParamsChangeType.SpeedUp;
			this.SpeedDownTagId = EMotorSpeedDownConfig.None;
		}
	}
}
