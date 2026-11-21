using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000246 RID: 582
	public class ICategoryMatchingConfig
	{
		// Token: 0x060009C0 RID: 2496 RVA: 0x0002A3B4 File Offset: 0x000285B4
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

		// Token: 0x060009C1 RID: 2497 RVA: 0x0002A3EC File Offset: 0x000285EC
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

		// Token: 0x060009C2 RID: 2498 RVA: 0x0002A3FF File Offset: 0x000285FF
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

		// Token: 0x060009C3 RID: 2499 RVA: 0x0002A412 File Offset: 0x00028612
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

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x060009C4 RID: 2500 RVA: 0x0002A44C File Offset: 0x0002864C
		// (set) Token: 0x060009C5 RID: 2501 RVA: 0x0002A4AD File Offset: 0x000286AD
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

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x060009C6 RID: 2502 RVA: 0x0002A4C4 File Offset: 0x000286C4
		// (set) Token: 0x060009C7 RID: 2503 RVA: 0x0002A525 File Offset: 0x00028725
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

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x060009C8 RID: 2504 RVA: 0x0002A53C File Offset: 0x0002873C
		// (set) Token: 0x060009C9 RID: 2505 RVA: 0x0002A59D File Offset: 0x0002879D
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

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x060009CA RID: 2506 RVA: 0x0002A5B4 File Offset: 0x000287B4
		// (set) Token: 0x060009CB RID: 2507 RVA: 0x0002A615 File Offset: 0x00028815
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

		// Token: 0x04000A37 RID: 2615
		[Nullable(2)]
		protected ICategoryMatchingConfig FbInstance;

		// Token: 0x04000A38 RID: 2616
		[Nullable(2)]
		protected ICategoryMatchingConfig_SetValue PocoInterface;

		// Token: 0x04000A39 RID: 2617
		private ICategoryMatchingCondition _ConditionCache;

		// Token: 0x04000A3A RID: 2618
		private bool _ConditionInited;

		// Token: 0x04000A3B RID: 2619
		private ICategoryMatchingAnimation _AnimationCache;

		// Token: 0x04000A3C RID: 2620
		private bool _AnimationInited;

		// Token: 0x04000A3D RID: 2621
		private ICategoryMatchingSucceed _CallbackCache;

		// Token: 0x04000A3E RID: 2622
		private bool _CallbackInited;

		// Token: 0x04000A3F RID: 2623
		private IItemLockingConfig _ItemLockingConfigCache;

		// Token: 0x04000A40 RID: 2624
		private bool _ItemLockingConfigInited;
	}
}
