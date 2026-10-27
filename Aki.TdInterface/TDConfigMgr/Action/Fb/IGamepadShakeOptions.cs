using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200291E RID: 10526
	[NullableContext(1)]
	[Nullable(0)]
	public class IGamepadShakeOptions
	{
		// Token: 0x0600E99E RID: 59806 RVA: 0x00223DAE File Offset: 0x00221FAE
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

		// Token: 0x17004924 RID: 18724
		// (get) Token: 0x0600E99F RID: 59807 RVA: 0x00223DCD File Offset: 0x00221FCD
		public virtual string KuroForceFeedbackEffect
		{
			get
			{
				return this.Instance.KuroForceFeedbackEffect;
			}
		}

		// Token: 0x17004925 RID: 18725
		// (get) Token: 0x0600E9A0 RID: 59808 RVA: 0x00223DDA File Offset: 0x00221FDA
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

		// Token: 0x040080E8 RID: 33000
		private IGamepadShakeOptions Instance;

		// Token: 0x040080E9 RID: 33001
		private IGamepadShakeConfig _GamepadShakeConfigCache;

		// Token: 0x040080EA RID: 33002
		private bool _GamepadShakeConfigInited;
	}
}
