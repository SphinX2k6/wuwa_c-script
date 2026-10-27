using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A8C RID: 27276
	public class IMechStuntClimbFlyT
	{
		// Token: 0x1700CA83 RID: 51843
		// (get) Token: 0x0602FCDA RID: 195802 RVA: 0x0068142A File Offset: 0x0067F62A
		// (set) Token: 0x0602FCDB RID: 195803 RVA: 0x00681432 File Offset: 0x0067F632
		public EMechStuntType Type { get; set; }

		// Token: 0x0602FCDC RID: 195804 RVA: 0x0068143B File Offset: 0x0067F63B
		public IMechStuntClimbFlyT()
		{
			this.Type = EMechStuntType.Dive;
		}
	}
}
