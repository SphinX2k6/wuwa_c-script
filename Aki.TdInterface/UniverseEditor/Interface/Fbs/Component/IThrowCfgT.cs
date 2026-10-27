using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A5F RID: 23135
	public class IThrowCfgT
	{
		// Token: 0x1700AE16 RID: 44566
		// (get) Token: 0x060275CF RID: 161231 RVA: 0x0056ABAD File Offset: 0x00568DAD
		// (set) Token: 0x060275D0 RID: 161232 RVA: 0x0056ABB5 File Offset: 0x00568DB5
		public TThrowMotionUnion MotionConfig { get; set; }

		// Token: 0x060275D1 RID: 161233 RVA: 0x0056ABBE File Offset: 0x00568DBE
		public IThrowCfgT()
		{
			this.MotionConfig = null;
		}
	}
}
