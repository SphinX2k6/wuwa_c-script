using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200213A RID: 8506
	public class ISwitchEffectStateEffectBase
	{
		// Token: 0x0600B48E RID: 46222 RVA: 0x00194874 File Offset: 0x00192A74
		private ISwitchEffectStateEffectBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISwitchEffectStateEffectBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISwitchEffectStateEffectBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISwitchEffectStateEffectBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600B48F RID: 46223 RVA: 0x001948AC File Offset: 0x00192AAC
		public static ISwitchEffectStateEffectBase Create([Nullable(2)] ISwitchEffectStateEffectBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISwitchEffectStateEffectBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B490 RID: 46224 RVA: 0x001948BF File Offset: 0x00192ABF
		public static ISwitchEffectStateEffectBase CreateFromSetValue([Nullable(2)] ISwitchEffectStateEffectBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISwitchEffectStateEffectBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B491 RID: 46225 RVA: 0x001948D2 File Offset: 0x00192AD2
		public ISwitchEffectStateEffectBase_SetValue ToSetValue()
		{
			return new ISwitchEffectStateEffectBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700367F RID: 13951
		// (get) Token: 0x0600B492 RID: 46226 RVA: 0x001948E5 File Offset: 0x00192AE5
		// (set) Token: 0x0600B493 RID: 46227 RVA: 0x00194910 File Offset: 0x00192B10
		public virtual ESwitchEffectStateEffectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESwitchEffectStateEffectType.ScreenEffect;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006ADC RID: 27356
		[Nullable(2)]
		protected ISwitchEffectStateEffectBase FbInstance;

		// Token: 0x04006ADD RID: 27357
		[Nullable(2)]
		protected ISwitchEffectStateEffectBase_SetValue PocoInterface;
	}
}
