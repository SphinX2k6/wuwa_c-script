using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018F7 RID: 6391
	public class IActorInitialEffect
	{
		// Token: 0x06008617 RID: 34327 RVA: 0x0013F424 File Offset: 0x0013D624
		private IActorInitialEffect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IActorInitialEffect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IActorInitialEffect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IActorInitialEffect_SetValue());
			}
			return result;
		}

		// Token: 0x06008618 RID: 34328 RVA: 0x0013F45C File Offset: 0x0013D65C
		public static IActorInitialEffect Create([Nullable(2)] IActorInitialEffect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorInitialEffect
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008619 RID: 34329 RVA: 0x0013F46F File Offset: 0x0013D66F
		public static IActorInitialEffect CreateFromSetValue([Nullable(2)] IActorInitialEffect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IActorInitialEffect
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600861A RID: 34330 RVA: 0x0013F482 File Offset: 0x0013D682
		public IActorInitialEffect_SetValue ToSetValue()
		{
			return new IActorInitialEffect_SetValue
			{
				EffectIds = this.EffectIds,
				EffectIdsMaleVariant = this.EffectIdsMaleVariant
			};
		}

		// Token: 0x17002BA5 RID: 11173
		// (get) Token: 0x0600861B RID: 34331 RVA: 0x0013F4A1 File Offset: 0x0013D6A1
		// (set) Token: 0x0600861C RID: 34332 RVA: 0x0013F4C8 File Offset: 0x0013D6C8
		public virtual List<int> EffectIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EffectIds;
				}
				IActorInitialEffect_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EffectIds;
			}
			set
			{
				this.GetOrCreatePoco().EffectIds = value;
			}
		}

		// Token: 0x17002BA6 RID: 11174
		// (get) Token: 0x0600861D RID: 34333 RVA: 0x0013F4D6 File Offset: 0x0013D6D6
		// (set) Token: 0x0600861E RID: 34334 RVA: 0x0013F4FD File Offset: 0x0013D6FD
		[Nullable(2)]
		public virtual List<int> EffectIdsMaleVariant
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EffectIdsMaleVariant;
				}
				IActorInitialEffect_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EffectIdsMaleVariant;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EffectIdsMaleVariant = value;
			}
		}

		// Token: 0x04005514 RID: 21780
		[Nullable(2)]
		protected IActorInitialEffect FbInstance;

		// Token: 0x04005515 RID: 21781
		[Nullable(2)]
		protected IActorInitialEffect_SetValue PocoInterface;
	}
}
