using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001776 RID: 6006
	[NullableContext(1)]
	[Nullable(0)]
	public class IActorInitialEffect
	{
		// Token: 0x06007F27 RID: 32551 RVA: 0x001301C4 File Offset: 0x0012E3C4
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

		// Token: 0x06007F28 RID: 32552 RVA: 0x001301FC File Offset: 0x0012E3FC
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

		// Token: 0x06007F29 RID: 32553 RVA: 0x0013020F File Offset: 0x0012E40F
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

		// Token: 0x06007F2A RID: 32554 RVA: 0x00130222 File Offset: 0x0012E422
		public IActorInitialEffect_SetValue ToSetValue()
		{
			return new IActorInitialEffect_SetValue
			{
				EffectIds = this.EffectIds,
				EffectIdsMaleVariant = this.EffectIdsMaleVariant
			};
		}

		// Token: 0x170029B7 RID: 10679
		// (get) Token: 0x06007F2B RID: 32555 RVA: 0x00130241 File Offset: 0x0012E441
		// (set) Token: 0x06007F2C RID: 32556 RVA: 0x00130268 File Offset: 0x0012E468
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

		// Token: 0x170029B8 RID: 10680
		// (get) Token: 0x06007F2D RID: 32557 RVA: 0x00130276 File Offset: 0x0012E476
		// (set) Token: 0x06007F2E RID: 32558 RVA: 0x0013029D File Offset: 0x0012E49D
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

		// Token: 0x040050DE RID: 20702
		[Nullable(2)]
		protected IActorInitialEffect FbInstance;

		// Token: 0x040050DF RID: 20703
		[Nullable(2)]
		protected IActorInitialEffect_SetValue PocoInterface;
	}
}
