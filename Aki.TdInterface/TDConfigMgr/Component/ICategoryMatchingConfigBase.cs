using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000248 RID: 584
	public class ICategoryMatchingConfigBase
	{
		// Token: 0x060009CE RID: 2510 RVA: 0x0002A63C File Offset: 0x0002883C
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

		// Token: 0x060009CF RID: 2511 RVA: 0x0002A674 File Offset: 0x00028874
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

		// Token: 0x060009D0 RID: 2512 RVA: 0x0002A687 File Offset: 0x00028887
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

		// Token: 0x060009D1 RID: 2513 RVA: 0x0002A69A File Offset: 0x0002889A
		public ICategoryMatchingConfigBase_SetValue ToSetValue()
		{
			return new ICategoryMatchingConfigBase_SetValue
			{
				Condition = this.Condition,
				Animation = this.Animation,
				Callback = this.Callback
			};
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x060009D2 RID: 2514 RVA: 0x0002A6C8 File Offset: 0x000288C8
		// (set) Token: 0x060009D3 RID: 2515 RVA: 0x0002A729 File Offset: 0x00028929
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

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x060009D4 RID: 2516 RVA: 0x0002A740 File Offset: 0x00028940
		// (set) Token: 0x060009D5 RID: 2517 RVA: 0x0002A7A1 File Offset: 0x000289A1
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

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x060009D6 RID: 2518 RVA: 0x0002A7B8 File Offset: 0x000289B8
		// (set) Token: 0x060009D7 RID: 2519 RVA: 0x0002A819 File Offset: 0x00028A19
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

		// Token: 0x04000A45 RID: 2629
		[Nullable(2)]
		protected ICategoryMatchingConfigBase FbInstance;

		// Token: 0x04000A46 RID: 2630
		[Nullable(2)]
		protected ICategoryMatchingConfigBase_SetValue PocoInterface;

		// Token: 0x04000A47 RID: 2631
		private ICategoryMatchingCondition _ConditionCache;

		// Token: 0x04000A48 RID: 2632
		private bool _ConditionInited;

		// Token: 0x04000A49 RID: 2633
		private ICategoryMatchingAnimationBase _AnimationCache;

		// Token: 0x04000A4A RID: 2634
		private bool _AnimationInited;

		// Token: 0x04000A4B RID: 2635
		private ICategoryMatchingSucceedBase _CallbackCache;

		// Token: 0x04000A4C RID: 2636
		private bool _CallbackInited;
	}
}
