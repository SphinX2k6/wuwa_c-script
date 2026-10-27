using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B1F RID: 27423
	public class IMotorParamsChangeConfigT
	{
		// Token: 0x1700CBD5 RID: 52181
		// (get) Token: 0x0603022A RID: 197162 RVA: 0x0068B002 File Offset: 0x00689202
		// (set) Token: 0x0603022B RID: 197163 RVA: 0x0068B00A File Offset: 0x0068920A
		public EMotorParamsChangeType Type { get; set; }

		// Token: 0x0603022C RID: 197164 RVA: 0x0068B013 File Offset: 0x00689213
		public IMotorParamsChangeConfigT()
		{
			this.Type = EMotorParamsChangeType.SpeedUp;
		}
	}
}
