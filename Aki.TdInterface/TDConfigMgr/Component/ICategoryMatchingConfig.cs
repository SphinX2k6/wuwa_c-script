using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200021F RID: 543
	[NullableContext(1)]
	[Nullable(0)]
	public class ICategoryMatchingConfig
	{
		// Token: 0x0600094C RID: 2380 RVA: 0x00028BF4 File Offset: 0x00026DF4
		private ICategoryMatchingConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICategoryMatchingConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICategoryMatchingConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICategoryMatchingConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x00028C2C File Offset: 0x00026E2C
		public static ICategoryMatchingConfig Create([Nullable(2)] ICategoryMatchingConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICategoryMatchingConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x00028C3F File Offset: 0x00026E3F
		public static ICategoryMatchingConfig CreateFromSetValue([Nullable(2)] ICategoryMatchingConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICategoryMatchingConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x00028C52 File Offset: 0x00026E52
		public ICategoryMatchingConfig_SetValue ToSetValue()
		{
			return new ICategoryMatchingConfig_SetValue
			{
				Condition = this.Condition,
				Animation = this.Animation,
				Callback = this.Callback,
				ItemLockingConfig = this.ItemLockingConfig
			};
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000950 RID: 2384 RVA: 0x00028C8C File Offset: 0x00026E8C
		// (set) Token: 0x06000951 RID: 2385 RVA: 0x00028CED File Offset: 0x00026EED
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
					ICategoryMatchingConfig_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000952 RID: 2386 RVA: 0x00028D04 File Offset: 0x00026F04
		// (set) Token: 0x06000953 RID: 2387 RVA: 0x00028D65 File Offset: 0x00026F65
		public virtual ICategoryMatchingAnimation Animation
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
					this._AnimationCache = ICategoryMatchingAnimation.Create(this.FbInstance.Animation);
				}
				else
				{
					ICategoryMatchingConfig_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000954 RID: 2388 RVA: 0x00028D7C File Offset: 0x00026F7C
		// (set) Token: 0x06000955 RID: 2389 RVA: 0x00028DDD File Offset: 0x00026FDD
		public virtual ICategoryMatchingSucceed Callback
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
					this._CallbackCache = ICategoryMatchingSucceed.Create(this.FbInstance.Callback);
				}
				else
				{
					ICategoryMatchingConfig_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000956 RID: 2390 RVA: 0x00028DF4 File Offset: 0x00026FF4
		// (set) Token: 0x06000957 RID: 2391 RVA: 0x00028E55 File Offset: 0x00027055
		[Nullable(2)]
		public virtual IItemLockingConfig ItemLockingConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._ItemLockingConfigInited)
				{
					return this._ItemLockingConfigCache;
				}
				this._ItemLockingConfigInited = true;
				if (this.FbInstance != null)
				{
					this._ItemLockingConfigCache = IItemLockingConfig.Create(this.FbInstance.ItemLockingConfig);
				}
				else
				{
					ICategoryMatchingConfig_SetValue pocoInterface = this.PocoInterface;
					this._ItemLockingConfigCache = ((pocoInterface != null) ? pocoInterface.ItemLockingConfig : null);
				}
				return this._ItemLockingConfigCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().ItemLockingConfig = value;
				this._ItemLockingConfigInited = false;
			}
		}

		// Token: 0x040009AD RID: 2477
		[Nullable(2)]
		protected ICategoryMatchingConfig FbInstance;

		// Token: 0x040009AE RID: 2478
		[Nullable(2)]
		protected ICategoryMatchingConfig_SetValue PocoInterface;

		// Token: 0x040009AF RID: 2479
		private ICategoryMatchingCondition _ConditionCache;

		// Token: 0x040009B0 RID: 2480
		private bool _ConditionInited;

		// Token: 0x040009B1 RID: 2481
		private ICategoryMatchingAnimation _AnimationCache;

		// Token: 0x040009B2 RID: 2482
		private bool _AnimationInited;

		// Token: 0x040009B3 RID: 2483
		private ICategoryMatchingSucceed _CallbackCache;

		// Token: 0x040009B4 RID: 2484
		private bool _CallbackInited;

		// Token: 0x040009B5 RID: 2485
		private IItemLockingConfig _ItemLockingConfigCache;

		// Token: 0x040009B6 RID: 2486
		private bool _ItemLockingConfigInited;
	}
}
