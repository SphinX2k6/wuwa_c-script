using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200042E RID: 1070
	[NullableContext(1)]
	[Nullable(0)]
	public class IHitTimeScaleRatio
	{
		// Token: 0x0600158F RID: 5519 RVA: 0x000436DC File Offset: 0x000418DC
		private IHitTimeScaleRatio_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHitTimeScaleRatio 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHitTimeScaleRatio_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHitTimeScaleRatio_SetValue());
			}
			return result;
		}

		// Token: 0x06001590 RID: 5520 RVA: 0x00043714 File Offset: 0x00041914
		public static IHitTimeScaleRatio Create([Nullable(2)] IHitTimeScaleRatio instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHitTimeScaleRatio
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001591 RID: 5521 RVA: 0x00043727 File Offset: 0x00041927
		public static IHitTimeScaleRatio CreateFromSetValue([Nullable(2)] IHitTimeScaleRatio_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHitTimeScaleRatio
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001592 RID: 5522 RVA: 0x0004373A File Offset: 0x0004193A
		public IHitTimeScaleRatio_SetValue ToSetValue()
		{
			return new IHitTimeScaleRatio_SetValue
			{
				TimeRatio = this.TimeRatio,
				MaxExtraTime = this.MaxExtraTime,
				ValueRatio = this.ValueRatio
			};
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06001593 RID: 5523 RVA: 0x00043765 File Offset: 0x00041965
		// (set) Token: 0x06001594 RID: 5524 RVA: 0x00043794 File Offset: 0x00041994
		public virtual float TimeRatio
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TimeRatio;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.TimeRatio;
			}
			set
			{
				this.GetOrCreatePoco().TimeRatio = value;
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06001595 RID: 5525 RVA: 0x000437A4 File Offset: 0x000419A4
		// (set) Token: 0x06001596 RID: 5526 RVA: 0x000437DE File Offset: 0x000419DE
		public virtual float? MaxExtraTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxExtraTime;
				}
				IHitTimeScaleRatio_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MaxExtraTime;
			}
			set
			{
				this.GetOrCreatePoco().MaxExtraTime = value;
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06001597 RID: 5527 RVA: 0x000437EC File Offset: 0x000419EC
		// (set) Token: 0x06001598 RID: 5528 RVA: 0x0004381B File Offset: 0x00041A1B
		public virtual float ValueRatio
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ValueRatio;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.ValueRatio;
			}
			set
			{
				this.GetOrCreatePoco().ValueRatio = value;
			}
		}

		// Token: 0x040010A3 RID: 4259
		[Nullable(2)]
		protected IHitTimeScaleRatio FbInstance;

		// Token: 0x040010A4 RID: 4260
		[Nullable(2)]
		protected IHitTimeScaleRatio_SetValue PocoInterface;
	}
}
