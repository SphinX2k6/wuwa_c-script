using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BFC RID: 11260
	public class TriggerGamepadShake : ActionParams
	{
		// Token: 0x0600F7F8 RID: 63480 RVA: 0x002411D1 File Offset: 0x0023F3D1
		public static TriggerGamepadShake Create(ITriggerGamepadShake? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TriggerGamepadShake
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CAE RID: 19630
		// (get) Token: 0x0600F7F9 RID: 63481 RVA: 0x002411F0 File Offset: 0x0023F3F0
		public virtual string KuroForceFeedbackEffect
		{
			get
			{
				return this.Instance.KuroForceFeedbackEffect;
			}
		}

		// Token: 0x17004CAF RID: 19631
		// (get) Token: 0x0600F7FA RID: 63482 RVA: 0x002411FD File Offset: 0x0023F3FD
		public virtual IGamepadShakeConfig GamepadShakeConfig
		{
			get
			{
				if (this._GamepadShakeConfigInited)
				{
					return this._GamepadShakeConfigCache;
				}
				this._GamepadShakeConfigInited = true;
				this._GamepadShakeConfigCache = ActionReadHelper.ReadTriggerGamepadShake_GamepadShakeConfig(this.Instance);
				return this._GamepadShakeConfigCache;
			}
		}

		// Token: 0x040087BC RID: 34748
		private ITriggerGamepadShake Instance;

		// Token: 0x040087BD RID: 34749
		private IGamepadShakeConfig _GamepadShakeConfigCache;

		// Token: 0x040087BE RID: 34750
		private bool _GamepadShakeConfigInited;
	}
}
