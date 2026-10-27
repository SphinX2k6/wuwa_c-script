using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002920 RID: 10528
	[NullableContext(1)]
	[Nullable(0)]
	public class TriggerGamepadShake : ActionParams
	{
		// Token: 0x0600E9A6 RID: 59814 RVA: 0x00223E79 File Offset: 0x00222079
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

		// Token: 0x17004928 RID: 18728
		// (get) Token: 0x0600E9A7 RID: 59815 RVA: 0x00223E98 File Offset: 0x00222098
		public virtual string KuroForceFeedbackEffect
		{
			get
			{
				return this.Instance.KuroForceFeedbackEffect;
			}
		}

		// Token: 0x17004929 RID: 18729
		// (get) Token: 0x0600E9A8 RID: 59816 RVA: 0x00223EA5 File Offset: 0x002220A5
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

		// Token: 0x040080EE RID: 33006
		private ITriggerGamepadShake Instance;

		// Token: 0x040080EF RID: 33007
		private IGamepadShakeConfig _GamepadShakeConfigCache;

		// Token: 0x040080F0 RID: 33008
		private bool _GamepadShakeConfigInited;
	}
}
