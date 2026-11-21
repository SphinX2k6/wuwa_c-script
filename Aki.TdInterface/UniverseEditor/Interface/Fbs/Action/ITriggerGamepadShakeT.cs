using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C75 RID: 31861
	public class ITriggerGamepadShakeT
	{
		// Token: 0x1700EE8A RID: 61066
		// (get) Token: 0x0603972B RID: 235307 RVA: 0x007C1687 File Offset: 0x007BF887
		// (set) Token: 0x0603972C RID: 235308 RVA: 0x007C168F File Offset: 0x007BF88F
		public string KuroForceFeedbackEffect { get; set; }

		// Token: 0x1700EE8B RID: 61067
		// (get) Token: 0x0603972D RID: 235309 RVA: 0x007C1698 File Offset: 0x007BF898
		// (set) Token: 0x0603972E RID: 235310 RVA: 0x007C16A0 File Offset: 0x007BF8A0
		public TGamepadShakeConfigUnion GamepadShakeConfig { get; set; }

		// Token: 0x0603972F RID: 235311 RVA: 0x007C16A9 File Offset: 0x007BF8A9
		public ITriggerGamepadShakeT()
		{
			this.KuroForceFeedbackEffect = null;
			this.GamepadShakeConfig = null;
		}
	}
}
