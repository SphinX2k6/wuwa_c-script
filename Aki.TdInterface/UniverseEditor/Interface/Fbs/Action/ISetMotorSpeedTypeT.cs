using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007026 RID: 28710
	public class ISetMotorSpeedTypeT
	{
		// Token: 0x1700D539 RID: 54585
		// (get) Token: 0x06032CA7 RID: 208039 RVA: 0x006DA16A File Offset: 0x006D836A
		// (set) Token: 0x06032CA8 RID: 208040 RVA: 0x006DA172 File Offset: 0x006D8372
		public EMotorSpeedType Type { get; set; }

		// Token: 0x06032CA9 RID: 208041 RVA: 0x006DA17B File Offset: 0x006D837B
		public ISetMotorSpeedTypeT()
		{
			this.Type = EMotorSpeedType.TargetSpeed;
		}
	}
}
