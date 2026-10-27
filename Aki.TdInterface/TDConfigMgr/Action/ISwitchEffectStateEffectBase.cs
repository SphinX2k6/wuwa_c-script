using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F01 RID: 7937
	[NullableContext(1)]
	[Nullable(0)]
	public class ISwitchEffectStateEffectBase
	{
		// Token: 0x0600A9BC RID: 43452 RVA: 0x0017E87C File Offset: 0x0017CA7C
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

		// Token: 0x0600A9BD RID: 43453 RVA: 0x0017E8B4 File Offset: 0x0017CAB4
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

		// Token: 0x0600A9BE RID: 43454 RVA: 0x0017E8C7 File Offset: 0x0017CAC7
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

		// Token: 0x0600A9BF RID: 43455 RVA: 0x0017E8DA File Offset: 0x0017CADA
		public ISwitchEffectStateEffectBase_SetValue ToSetValue()
		{
			return new ISwitchEffectStateEffectBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170033B4 RID: 13236
		// (get) Token: 0x0600A9C0 RID: 43456 RVA: 0x0017E8ED File Offset: 0x0017CAED
		// (set) Token: 0x0600A9C1 RID: 43457 RVA: 0x0017E918 File Offset: 0x0017CB18
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

		// Token: 0x040064ED RID: 25837
		[Nullable(2)]
		protected ISwitchEffectStateEffectBase FbInstance;

		// Token: 0x040064EE RID: 25838
		[Nullable(2)]
		protected ISwitchEffectStateEffectBase_SetValue PocoInterface;
	}
}
