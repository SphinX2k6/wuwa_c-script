using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B46 RID: 27462
	public class IMotorSpeedUpConfigT
	{
		// Token: 0x1700CC0E RID: 52238
		// (get) Token: 0x06030343 RID: 197443 RVA: 0x0068CF74 File Offset: 0x0068B174
		// (set) Token: 0x06030344 RID: 197444 RVA: 0x0068CF7C File Offset: 0x0068B17C
		public EMotorParamsChangeType Type { get; set; }

		// Token: 0x1700CC0F RID: 52239
		// (get) Token: 0x06030345 RID: 197445 RVA: 0x0068CF85 File Offset: 0x0068B185
		// (set) Token: 0x06030346 RID: 197446 RVA: 0x0068CF8D File Offset: 0x0068B18D
		public EMotorSpeedUpConfigTag SpeedUpTagId { get; set; }

		// Token: 0x06030347 RID: 197447 RVA: 0x0068CF96 File Offset: 0x0068B196
		public IMotorSpeedUpConfigT()
		{
			this.Type = EMotorParamsChangeType.SpeedUp;
			this.SpeedUpTagId = EMotorSpeedUpConfigTag.None;
		}
	}
}
