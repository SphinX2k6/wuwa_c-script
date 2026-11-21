using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F18 RID: 28440
	public class IGamepadShakeOptionsT
	{
		// Token: 0x1700D088 RID: 53384
		// (get) Token: 0x06031381 RID: 201601 RVA: 0x006AB71B File Offset: 0x006A991B
		// (set) Token: 0x06031382 RID: 201602 RVA: 0x006AB723 File Offset: 0x006A9923
		public string KuroForceFeedbackEffect { get; set; }

		// Token: 0x1700D089 RID: 53385
		// (get) Token: 0x06031383 RID: 201603 RVA: 0x006AB72C File Offset: 0x006A992C
		// (set) Token: 0x06031384 RID: 201604 RVA: 0x006AB734 File Offset: 0x006A9934
		public TGamepadShakeConfigUnion GamepadShakeConfig { get; set; }

		// Token: 0x06031385 RID: 201605 RVA: 0x006AB73D File Offset: 0x006A993D
		public IGamepadShakeOptionsT()
		{
			this.KuroForceFeedbackEffect = null;
			this.GamepadShakeConfig = null;
		}
	}
}
