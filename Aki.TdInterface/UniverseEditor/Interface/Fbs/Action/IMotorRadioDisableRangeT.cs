using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007268 RID: 29288
	public class IMotorRadioDisableRangeT
	{
		// Token: 0x1700D6C1 RID: 54977
		// (get) Token: 0x0603309A RID: 209050 RVA: 0x006E395E File Offset: 0x006E1B5E
		// (set) Token: 0x0603309B RID: 209051 RVA: 0x006E3966 File Offset: 0x006E1B66
		public EMotorRadioDisableRangeType Type { get; set; }

		// Token: 0x0603309C RID: 209052 RVA: 0x006E396F File Offset: 0x006E1B6F
		public IMotorRadioDisableRangeT()
		{
			this.Type = EMotorRadioDisableRangeType.ByAreaId;
		}
	}
}
