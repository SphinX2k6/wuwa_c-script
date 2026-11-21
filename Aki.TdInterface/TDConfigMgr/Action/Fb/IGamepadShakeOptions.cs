using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BFA RID: 11258
	public class IGamepadShakeOptions
	{
		// Token: 0x0600F7F0 RID: 63472 RVA: 0x00241106 File Offset: 0x0023F306
		public static IGamepadShakeOptions Create(IGamepadShakeOptions? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGamepadShakeOptions
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CAA RID: 19626
		// (get) Token: 0x0600F7F1 RID: 63473 RVA: 0x00241125 File Offset: 0x0023F325
		public virtual string KuroForceFeedbackEffect
		{
			get
			{
				return this.Instance.KuroForceFeedbackEffect;
			}
		}

		// Token: 0x17004CAB RID: 19627
		// (get) Token: 0x0600F7F2 RID: 63474 RVA: 0x00241132 File Offset: 0x0023F332
		public virtual IGamepadShakeConfig GamepadShakeConfig
		{
			get
			{
				if (this._GamepadShakeConfigInited)
				{
					return this._GamepadShakeConfigCache;
				}
				this._GamepadShakeConfigInited = true;
				this._GamepadShakeConfigCache = ActionReadHelper.ReadIGamepadShakeOptions_GamepadShakeConfig(this.Instance);
				return this._GamepadShakeConfigCache;
			}
		}

		// Token: 0x040087B6 RID: 34742
		private IGamepadShakeOptions Instance;

		// Token: 0x040087B7 RID: 34743
		private IGamepadShakeConfig _GamepadShakeConfigCache;

		// Token: 0x040087B8 RID: 34744
		private bool _GamepadShakeConfigInited;
	}
}
