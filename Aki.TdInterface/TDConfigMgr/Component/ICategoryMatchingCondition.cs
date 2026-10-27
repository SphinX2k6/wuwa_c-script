using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200021D RID: 541
	[NullableContext(2)]
	[Nullable(0)]
	public class ICategoryMatchingCondition
	{
		// Token: 0x06000942 RID: 2370 RVA: 0x00028AB8 File Offset: 0x00026CB8
		[NullableContext(1)]
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

		// Token: 0x06000943 RID: 2371 RVA: 0x00028AF0 File Offset: 0x00026CF0
		[NullableContext(1)]
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

		// Token: 0x06000944 RID: 2372 RVA: 0x00028B03 File Offset: 0x00026D03
		[NullableContext(1)]
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

		// Token: 0x06000945 RID: 2373 RVA: 0x00028B16 File Offset: 0x00026D16
		[NullableContext(1)]
		public ICategoryMatchingCondition_SetValue ToSetValue()
		{
			return new ICategoryMatchingCondition_SetValue
			{
				EntityMatch = this.EntityMatch,
				SelfState = this.SelfState
			};
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000946 RID: 2374 RVA: 0x00028B38 File Offset: 0x00026D38
		// (set) Token: 0x06000947 RID: 2375 RVA: 0x00028B99 File Offset: 0x00026D99
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

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000948 RID: 2376 RVA: 0x00028BAE File Offset: 0x00026DAE
		// (set) Token: 0x06000949 RID: 2377 RVA: 0x00028BD5 File Offset: 0x00026DD5
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

		// Token: 0x040009A7 RID: 2471
		protected ICategoryMatchingCondition FbInstance;

		// Token: 0x040009A8 RID: 2472
		protected ICategoryMatchingCondition_SetValue PocoInterface;

		// Token: 0x040009A9 RID: 2473
		[Nullable(1)]
		private IDynamicEntityMatch _EntityMatchCache;

		// Token: 0x040009AA RID: 2474
		private bool _EntityMatchInited;
	}
}
