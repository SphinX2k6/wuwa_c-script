using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007256 RID: 29270
	public class IMotorParamsChangeConfigT
	{
		// Token: 0x1700D6A4 RID: 54948
		// (get) Token: 0x06032FFE RID: 208894 RVA: 0x006E26BA File Offset: 0x006E08BA
		// (set) Token: 0x06032FFF RID: 208895 RVA: 0x006E26C2 File Offset: 0x006E08C2
		public EMotorParamsChangeType Type { get; set; }

		// Token: 0x06033000 RID: 208896 RVA: 0x006E26CB File Offset: 0x006E08CB
		public IMotorParamsChangeConfigT()
		{
			this.Type = EMotorParamsChangeType.SpeedUp;
		}
	}
}
