using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006877 RID: 26743
	public class IGamepadShakeOptionsT
	{
		// Token: 0x1700C6A2 RID: 50850
		// (get) Token: 0x0602EA47 RID: 191047 RVA: 0x0065C69B File Offset: 0x0065A89B
		// (set) Token: 0x0602EA48 RID: 191048 RVA: 0x0065C6A3 File Offset: 0x0065A8A3
		public string KuroForceFeedbackEffect { get; set; }

		// Token: 0x1700C6A3 RID: 50851
		// (get) Token: 0x0602EA49 RID: 191049 RVA: 0x0065C6AC File Offset: 0x0065A8AC
		// (set) Token: 0x0602EA4A RID: 191050 RVA: 0x0065C6B4 File Offset: 0x0065A8B4
		public TGamepadShakeConfigUnion GamepadShakeConfig { get; set; }

		// Token: 0x0602EA4B RID: 191051 RVA: 0x0065C6BD File Offset: 0x0065A8BD
		public IGamepadShakeOptionsT()
		{
			this.KuroForceFeedbackEffect = null;
			this.GamepadShakeConfig = null;
		}
	}
}
