using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000221 RID: 545
	[NullableContext(1)]
	[Nullable(0)]
	public class ICategoryMatchingConfigBase
	{
		// Token: 0x0600095A RID: 2394 RVA: 0x00028E7C File Offset: 0x0002707C
		private ICategoryMatchingConfigBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICategoryMatchingConfigBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICategoryMatchingConfigBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICategoryMatchingConfigBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x00028EB4 File Offset: 0x000270B4
		public static ICategoryMatchingConfigBase Create([Nullable(2)] ICategoryMatchingConfigBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICategoryMatchingConfigBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x00028EC7 File Offset: 0x000270C7
		public static ICategoryMatchingConfigBase CreateFromSetValue([Nullable(2)] ICategoryMatchingConfigBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICategoryMatchingConfigBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x00028EDA File Offset: 0x000270DA
		public ICategoryMatchingConfigBase_SetValue ToSetValue()
		{
			return new ICategoryMatchingConfigBase_SetValue
			{
				Condition = this.Condition,
				Animation = this.Animation,
				Callback = this.Callback
			};
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x0600095E RID: 2398 RVA: 0x00028F08 File Offset: 0x00027108
		// (set) Token: 0x0600095F RID: 2399 RVA: 0x00028F69 File Offset: 0x00027169
		public virtual ICategoryMatchingCondition Condition
		{
			get
			{
				if (this._ConditionInited)
				{
					return this._ConditionCache;
				}
				this._ConditionInited = true;
				if (this.FbInstance != null)
				{
					this._ConditionCache = ICategoryMatchingCondition.Create(this.FbInstance.Condition);
				}
				else
				{
					ICategoryMatchingConfigBase_SetValue pocoInterface = this.PocoInterface;
					this._ConditionCache = ((pocoInterface != null) ? pocoInterface.Condition : null);
				}
				return this._ConditionCache;
			}
			set
			{
				this.GetOrCreatePoco().Condition = value;
				this._ConditionInited = false;
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000960 RID: 2400 RVA: 0x00028F80 File Offset: 0x00027180
		// (set) Token: 0x06000961 RID: 2401 RVA: 0x00028FE1 File Offset: 0x000271E1
		public virtual ICategoryMatchingAnimationBase Animation
		{
			get
			{
				if (this._AnimationInited)
				{
					return this._AnimationCache;
				}
				this._AnimationInited = true;
				if (this.FbInstance != null)
				{
					this._AnimationCache = ICategoryMatchingAnimationBase.Create(this.FbInstance.Animation);
				}
				else
				{
					ICategoryMatchingConfigBase_SetValue pocoInterface = this.PocoInterface;
					this._AnimationCache = ((pocoInterface != null) ? pocoInterface.Animation : null);
				}
				return this._AnimationCache;
			}
			set
			{
				this.GetOrCreatePoco().Animation = value;
				this._AnimationInited = false;
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000962 RID: 2402 RVA: 0x00028FF8 File Offset: 0x000271F8
		// (set) Token: 0x06000963 RID: 2403 RVA: 0x00029059 File Offset: 0x00027259
		public virtual ICategoryMatchingSucceedBase Callback
		{
			get
			{
				if (this._CallbackInited)
				{
					return this._CallbackCache;
				}
				this._CallbackInited = true;
				if (this.FbInstance != null)
				{
					this._CallbackCache = ICategoryMatchingSucceedBase.Create(this.FbInstance.Callback);
				}
				else
				{
					ICategoryMatchingConfigBase_SetValue pocoInterface = this.PocoInterface;
					this._CallbackCache = ((pocoInterface != null) ? pocoInterface.Callback : null);
				}
				return this._CallbackCache;
			}
			set
			{
				this.GetOrCreatePoco().Callback = value;
				this._CallbackInited = false;
			}
		}

		// Token: 0x040009BB RID: 2491
		[Nullable(2)]
		protected ICategoryMatchingConfigBase FbInstance;

		// Token: 0x040009BC RID: 2492
		[Nullable(2)]
		protected ICategoryMatchingConfigBase_SetValue PocoInterface;

		// Token: 0x040009BD RID: 2493
		private ICategoryMatchingCondition _ConditionCache;

		// Token: 0x040009BE RID: 2494
		private bool _ConditionInited;

		// Token: 0x040009BF RID: 2495
		private ICategoryMatchingAnimationBase _AnimationCache;

		// Token: 0x040009C0 RID: 2496
		private bool _AnimationInited;

		// Token: 0x040009C1 RID: 2497
		private ICategoryMatchingSucceedBase _CallbackCache;

		// Token: 0x040009C2 RID: 2498
		private bool _CallbackInited;
	}
}
