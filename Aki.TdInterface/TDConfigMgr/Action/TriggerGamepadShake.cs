using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200225A RID: 8794
	[NullableContext(1)]
	[Nullable(0)]
	public class TriggerGamepadShake : ActionParams
	{
		// Token: 0x0600C0F8 RID: 49400 RVA: 0x001BB100 File Offset: 0x001B9300
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

		// Token: 0x0600C0F9 RID: 49401 RVA: 0x001BB138 File Offset: 0x001B9338
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

		// Token: 0x0600C0FA RID: 49402 RVA: 0x001BB14B File Offset: 0x001B934B
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

		// Token: 0x0600C0FB RID: 49403 RVA: 0x001BB15E File Offset: 0x001B935E
		public TriggerGamepadShake_SetValue ToSetValue()
		{
			return new TriggerGamepadShake_SetValue
			{
				KuroForceFeedbackEffect = this.KuroForceFeedbackEffect,
				GamepadShakeConfig = this.GamepadShakeConfig
			};
		}

		// Token: 0x17003A62 RID: 14946
		// (get) Token: 0x0600C0FC RID: 49404 RVA: 0x001BB17D File Offset: 0x001B937D
		// (set) Token: 0x0600C0FD RID: 49405 RVA: 0x001BB1A8 File Offset: 0x001B93A8
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

		// Token: 0x17003A63 RID: 14947
		// (get) Token: 0x0600C0FE RID: 49406 RVA: 0x001BB1B6 File Offset: 0x001B93B6
		// (set) Token: 0x0600C0FF RID: 49407 RVA: 0x001BB1DD File Offset: 0x001B93DD
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

		// Token: 0x04007306 RID: 29446
		[Nullable(2)]
		protected new TriggerGamepadShake FbInstance;

		// Token: 0x04007307 RID: 29447
		[Nullable(2)]
		protected TriggerGamepadShake_SetValue PocoInterface;
	}
}
