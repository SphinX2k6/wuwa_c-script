using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000244 RID: 580
	[NullableContext(2)]
	[Nullable(0)]
	public class ICategoryMatchingCondition
	{
		// Token: 0x060009B6 RID: 2486 RVA: 0x0002A278 File Offset: 0x00028478
		[NullableContext(0)]
		private ICategoryMatchingCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICategoryMatchingCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICategoryMatchingCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICategoryMatchingCondition_SetValue());
			}
			return result;
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x0002A2B0 File Offset: 0x000284B0
		[NullableContext(0)]
		public static ICategoryMatchingCondition Create([Nullable(2)] ICategoryMatchingCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICategoryMatchingCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x0002A2C3 File Offset: 0x000284C3
		[NullableContext(0)]
		public static ICategoryMatchingCondition CreateFromSetValue([Nullable(2)] ICategoryMatchingCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICategoryMatchingCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x0002A2D6 File Offset: 0x000284D6
		[NullableContext(0)]
		public ICategoryMatchingCondition_SetValue ToSetValue()
		{
			return new ICategoryMatchingCondition_SetValue
			{
				EntityMatch = this.EntityMatch,
				SelfState = this.SelfState
			};
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x060009BA RID: 2490 RVA: 0x0002A2F8 File Offset: 0x000284F8
		// (set) Token: 0x060009BB RID: 2491 RVA: 0x0002A359 File Offset: 0x00028559
		public virtual IDynamicEntityMatch EntityMatch
		{
			get
			{
				if (this._EntityMatchInited)
				{
					return this._EntityMatchCache;
				}
				this._EntityMatchInited = true;
				if (this.FbInstance != null)
				{
					this._EntityMatchCache = IDynamicEntityMatch.Create(this.FbInstance.EntityMatch);
				}
				else
				{
					ICategoryMatchingCondition_SetValue pocoInterface = this.PocoInterface;
					this._EntityMatchCache = ((pocoInterface != null) ? pocoInterface.EntityMatch : null);
				}
				return this._EntityMatchCache;
			}
			set
			{
				this.GetOrCreatePoco().EntityMatch = value;
				this._EntityMatchInited = false;
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x060009BC RID: 2492 RVA: 0x0002A36E File Offset: 0x0002856E
		// (set) Token: 0x060009BD RID: 2493 RVA: 0x0002A395 File Offset: 0x00028595
		public virtual string SelfState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SelfState;
				}
				ICategoryMatchingCondition_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SelfState;
			}
			set
			{
				this.GetOrCreatePoco().SelfState = value;
			}
		}

		// Token: 0x04000A31 RID: 2609
		protected ICategoryMatchingCondition FbInstance;

		// Token: 0x04000A32 RID: 2610
		protected ICategoryMatchingCondition_SetValue PocoInterface;

		// Token: 0x04000A33 RID: 2611
		[Nullable(0)]
		private IDynamicEntityMatch _EntityMatchCache;

		// Token: 0x04000A34 RID: 2612
		private bool _EntityMatchInited;
	}
}
