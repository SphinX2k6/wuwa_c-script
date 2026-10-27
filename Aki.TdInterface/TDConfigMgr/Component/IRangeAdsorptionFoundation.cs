using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200065A RID: 1626
	[NullableContext(1)]
	[Nullable(0)]
	public class IRangeAdsorptionFoundation : IItemFoundationType
	{
		// Token: 0x060022C8 RID: 8904 RVA: 0x0005F7F0 File Offset: 0x0005D9F0
		private IRangeAdsorptionFoundation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRangeAdsorptionFoundation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRangeAdsorptionFoundation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRangeAdsorptionFoundation_SetValue());
			}
			return result;
		}

		// Token: 0x060022C9 RID: 8905 RVA: 0x0005F828 File Offset: 0x0005DA28
		public static IRangeAdsorptionFoundation Create([Nullable(2)] IRangeAdsorptionFoundation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRangeAdsorptionFoundation
			{
				FbInstance = instance
			};
		}

		// Token: 0x060022CA RID: 8906 RVA: 0x0005F83B File Offset: 0x0005DA3B
		public static IRangeAdsorptionFoundation CreateFromSetValue([Nullable(2)] IRangeAdsorptionFoundation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRangeAdsorptionFoundation
			{
				PocoInterface = value
			};
		}

		// Token: 0x060022CB RID: 8907 RVA: 0x0005F850 File Offset: 0x0005DA50
		public new IRangeAdsorptionFoundation_SetValue ToSetValue()
		{
			return new IRangeAdsorptionFoundation_SetValue
			{
				Type = this.Type,
				Condition = this.Condition,
				Animation = this.Animation,
				CategoryAnimation = this.CategoryAnimation,
				Callback = this.Callback
			};
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x060022CC RID: 8908 RVA: 0x0005F89E File Offset: 0x0005DA9E
		// (set) Token: 0x060022CD RID: 8909 RVA: 0x0005F8C9 File Offset: 0x0005DAC9
		public override EItemFoundation Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EItemFoundation.CategoryMatching;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x060022CE RID: 8910 RVA: 0x0005F8D8 File Offset: 0x0005DAD8
		// (set) Token: 0x060022CF RID: 8911 RVA: 0x0005F939 File Offset: 0x0005DB39
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
					IRangeAdsorptionFoundation_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x060022D0 RID: 8912 RVA: 0x0005F950 File Offset: 0x0005DB50
		// (set) Token: 0x060022D1 RID: 8913 RVA: 0x0005F9B1 File Offset: 0x0005DBB1
		public virtual IAdsorptionMatchingAnimation Animation
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
					this._AnimationCache = IAdsorptionMatchingAnimation.Create(this.FbInstance.Animation);
				}
				else
				{
					IRangeAdsorptionFoundation_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x060022D2 RID: 8914 RVA: 0x0005F9C8 File Offset: 0x0005DBC8
		// (set) Token: 0x060022D3 RID: 8915 RVA: 0x0005FA29 File Offset: 0x0005DC29
		[Nullable(2)]
		public virtual ICategoryMatchingAnimation CategoryAnimation
		{
			[NullableContext(2)]
			get
			{
				if (this._CategoryAnimationInited)
				{
					return this._CategoryAnimationCache;
				}
				this._CategoryAnimationInited = true;
				if (this.FbInstance != null)
				{
					this._CategoryAnimationCache = ICategoryMatchingAnimation.Create(this.FbInstance.CategoryAnimation);
				}
				else
				{
					IRangeAdsorptionFoundation_SetValue pocoInterface = this.PocoInterface;
					this._CategoryAnimationCache = ((pocoInterface != null) ? pocoInterface.CategoryAnimation : null);
				}
				return this._CategoryAnimationCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().CategoryAnimation = value;
				this._CategoryAnimationInited = false;
			}
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x060022D4 RID: 8916 RVA: 0x0005FA40 File Offset: 0x0005DC40
		// (set) Token: 0x060022D5 RID: 8917 RVA: 0x0005FAA1 File Offset: 0x0005DCA1
		[Nullable(2)]
		public virtual ICategoryMatchingSucceed Callback
		{
			[NullableContext(2)]
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
					IRangeAdsorptionFoundation_SetValue pocoInterface = this.PocoInterface;
					this._CallbackCache = ((pocoInterface != null) ? pocoInterface.Callback : null);
				}
				return this._CallbackCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().Callback = value;
				this._CallbackInited = false;
			}
		}

		// Token: 0x04001824 RID: 6180
		[Nullable(2)]
		protected new IRangeAdsorptionFoundation FbInstance;

		// Token: 0x04001825 RID: 6181
		[Nullable(2)]
		protected new IRangeAdsorptionFoundation_SetValue PocoInterface;

		// Token: 0x04001826 RID: 6182
		private ICategoryMatchingCondition _ConditionCache;

		// Token: 0x04001827 RID: 6183
		private bool _ConditionInited;

		// Token: 0x04001828 RID: 6184
		private IAdsorptionMatchingAnimation _AnimationCache;

		// Token: 0x04001829 RID: 6185
		private bool _AnimationInited;

		// Token: 0x0400182A RID: 6186
		private ICategoryMatchingAnimation _CategoryAnimationCache;

		// Token: 0x0400182B RID: 6187
		private bool _CategoryAnimationInited;

		// Token: 0x0400182C RID: 6188
		private ICategoryMatchingSucceed _CallbackCache;

		// Token: 0x0400182D RID: 6189
		private bool _CallbackInited;
	}
}
