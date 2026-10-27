using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007482 RID: 29826
	public class ITriggerGamepadShakeT
	{
		// Token: 0x1700E26D RID: 57965
		// (get) Token: 0x06036342 RID: 222018 RVA: 0x0075E95B File Offset: 0x0075CB5B
		// (set) Token: 0x06036343 RID: 222019 RVA: 0x0075E963 File Offset: 0x0075CB63
		public string KuroForceFeedbackEffect { get; set; }

		// Token: 0x1700E26E RID: 57966
		// (get) Token: 0x06036344 RID: 222020 RVA: 0x0075E96C File Offset: 0x0075CB6C
		// (set) Token: 0x06036345 RID: 222021 RVA: 0x0075E974 File Offset: 0x0075CB74
		public TGamepadShakeConfigUnion GamepadShakeConfig { get; set; }

		// Token: 0x06036346 RID: 222022 RVA: 0x0075E97D File Offset: 0x0075CB7D
		public ITriggerGamepadShakeT()
		{
			this.KuroForceFeedbackEffect = null;
			this.GamepadShakeConfig = null;
		}
	}
}
