using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002161 RID: 8545
	public class ITalkEffectStop : ITalkEffectActionType
	{
		// Token: 0x0600B55E RID: 46430 RVA: 0x00195FA0 File Offset: 0x001941A0
		private ITalkEffectStop_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkEffectStop 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkEffectStop_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkEffectStop_SetValue());
			}
			return result;
		}

		// Token: 0x0600B55F RID: 46431 RVA: 0x00195FD8 File Offset: 0x001941D8
		public static ITalkEffectStop Create([Nullable(2)] ITalkEffectStop instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkEffectStop
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B560 RID: 46432 RVA: 0x00195FEB File Offset: 0x001941EB
		public static ITalkEffectStop CreateFromSetValue([Nullable(2)] ITalkEffectStop_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkEffectStop
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B561 RID: 46433 RVA: 0x00195FFE File Offset: 0x001941FE
		public new ITalkEffectStop_SetValue ToSetValue()
		{
			return new ITalkEffectStop_SetValue
			{
				Type = this.Type,
				EffectKeys = this.EffectKeys,
				DelayTime = this.DelayTime,
				ImmediatelyDestroy = this.ImmediatelyDestroy
			};
		}

		// Token: 0x170036AD RID: 13997
		// (get) Token: 0x0600B562 RID: 46434 RVA: 0x00196035 File Offset: 0x00194235
		// (set) Token: 0x0600B563 RID: 46435 RVA: 0x00196060 File Offset: 0x00194260
		public override ETalkEffectActionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETalkEffectActionType.Play;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170036AE RID: 13998
		// (get) Token: 0x0600B564 RID: 46436 RVA: 0x0019606E File Offset: 0x0019426E
		// (set) Token: 0x0600B565 RID: 46437 RVA: 0x00196095 File Offset: 0x00194295
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<string> EffectKeys
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EffectKeys;
				}
				ITalkEffectStop_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EffectKeys;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().EffectKeys = value;
			}
		}

		// Token: 0x170036AF RID: 13999
		// (get) Token: 0x0600B566 RID: 46438 RVA: 0x001960A4 File Offset: 0x001942A4
		// (set) Token: 0x0600B567 RID: 46439 RVA: 0x001960DE File Offset: 0x001942DE
		public virtual float? DelayTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayTime;
				}
				ITalkEffectStop_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DelayTime;
			}
			set
			{
				this.GetOrCreatePoco().DelayTime = value;
			}
		}

		// Token: 0x170036B0 RID: 14000
		// (get) Token: 0x0600B568 RID: 46440 RVA: 0x001960EC File Offset: 0x001942EC
		// (set) Token: 0x0600B569 RID: 46441 RVA: 0x00196126 File Offset: 0x00194326
		public virtual bool? ImmediatelyDestroy
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ImmediatelyDestroy;
				}
				ITalkEffectStop_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ImmediatelyDestroy;
			}
			set
			{
				this.GetOrCreatePoco().ImmediatelyDestroy = value;
			}
		}

		// Token: 0x04006B39 RID: 27449
		[Nullable(2)]
		protected new ITalkEffectStop FbInstance;

		// Token: 0x04006B3A RID: 27450
		[Nullable(2)]
		protected new ITalkEffectStop_SetValue PocoInterface;
	}
}
