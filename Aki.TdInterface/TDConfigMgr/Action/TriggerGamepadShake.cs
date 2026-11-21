using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024C7 RID: 9415
	public class TriggerGamepadShake : ActionParams
	{
		// Token: 0x0600CCBE RID: 52414 RVA: 0x001D2884 File Offset: 0x001D0A84
		private TriggerGamepadShake_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("TriggerGamepadShake 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			TriggerGamepadShake_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new TriggerGamepadShake_SetValue());
			}
			return result;
		}

		// Token: 0x0600CCBF RID: 52415 RVA: 0x001D28BC File Offset: 0x001D0ABC
		public static TriggerGamepadShake Create([Nullable(2)] TriggerGamepadShake instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TriggerGamepadShake
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CCC0 RID: 52416 RVA: 0x001D28CF File Offset: 0x001D0ACF
		public static TriggerGamepadShake CreateFromSetValue([Nullable(2)] TriggerGamepadShake_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new TriggerGamepadShake
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CCC1 RID: 52417 RVA: 0x001D28E2 File Offset: 0x001D0AE2
		public TriggerGamepadShake_SetValue ToSetValue()
		{
			return new TriggerGamepadShake_SetValue
			{
				KuroForceFeedbackEffect = this.KuroForceFeedbackEffect,
				GamepadShakeConfig = this.GamepadShakeConfig
			};
		}

		// Token: 0x17003D59 RID: 15705
		// (get) Token: 0x0600CCC2 RID: 52418 RVA: 0x001D2901 File Offset: 0x001D0B01
		// (set) Token: 0x0600CCC3 RID: 52419 RVA: 0x001D292C File Offset: 0x001D0B2C
		public virtual string KuroForceFeedbackEffect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.KuroForceFeedbackEffect;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.KuroForceFeedbackEffect;
			}
			set
			{
				this.GetOrCreatePoco().KuroForceFeedbackEffect = value;
			}
		}

		// Token: 0x17003D5A RID: 15706
		// (get) Token: 0x0600CCC4 RID: 52420 RVA: 0x001D293A File Offset: 0x001D0B3A
		// (set) Token: 0x0600CCC5 RID: 52421 RVA: 0x001D2961 File Offset: 0x001D0B61
		public virtual IGamepadShakeConfig GamepadShakeConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GamepadShakeConfig;
				}
				TriggerGamepadShake_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.GamepadShakeConfig;
			}
			set
			{
				this.GetOrCreatePoco().GamepadShakeConfig = value;
			}
		}

		// Token: 0x04007953 RID: 31059
		[Nullable(2)]
		protected new TriggerGamepadShake FbInstance;

		// Token: 0x04007954 RID: 31060
		[Nullable(2)]
		protected TriggerGamepadShake_SetValue PocoInterface;
	}
}
