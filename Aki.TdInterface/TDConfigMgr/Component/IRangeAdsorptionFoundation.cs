using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006F7 RID: 1783
	public class IRangeAdsorptionFoundation : IItemFoundationType
	{
		// Token: 0x060025CE RID: 9678 RVA: 0x00066504 File Offset: 0x00064704
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

		// Token: 0x060025CF RID: 9679 RVA: 0x0006653C File Offset: 0x0006473C
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

		// Token: 0x060025D0 RID: 9680 RVA: 0x0006654F File Offset: 0x0006474F
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

		// Token: 0x060025D1 RID: 9681 RVA: 0x00066564 File Offset: 0x00064764
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

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x060025D2 RID: 9682 RVA: 0x000665B2 File Offset: 0x000647B2
		// (set) Token: 0x060025D3 RID: 9683 RVA: 0x000665DD File Offset: 0x000647DD
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

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x060025D4 RID: 9684 RVA: 0x000665EC File Offset: 0x000647EC
		// (set) Token: 0x060025D5 RID: 9685 RVA: 0x0006664D File Offset: 0x0006484D
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

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x060025D6 RID: 9686 RVA: 0x00066664 File Offset: 0x00064864
		// (set) Token: 0x060025D7 RID: 9687 RVA: 0x000666C5 File Offset: 0x000648C5
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

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x060025D8 RID: 9688 RVA: 0x000666DC File Offset: 0x000648DC
		// (set) Token: 0x060025D9 RID: 9689 RVA: 0x0006673D File Offset: 0x0006493D
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

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x060025DA RID: 9690 RVA: 0x00066754 File Offset: 0x00064954
		// (set) Token: 0x060025DB RID: 9691 RVA: 0x000667B5 File Offset: 0x000649B5
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

		// Token: 0x04001A16 RID: 6678
		[Nullable(2)]
		protected new IRangeAdsorptionFoundation FbInstance;

		// Token: 0x04001A17 RID: 6679
		[Nullable(2)]
		protected new IRangeAdsorptionFoundation_SetValue PocoInterface;

		// Token: 0x04001A18 RID: 6680
		private ICategoryMatchingCondition _ConditionCache;

		// Token: 0x04001A19 RID: 6681
		private bool _ConditionInited;

		// Token: 0x04001A1A RID: 6682
		private IAdsorptionMatchingAnimation _AnimationCache;

		// Token: 0x04001A1B RID: 6683
		private bool _AnimationInited;

		// Token: 0x04001A1C RID: 6684
		private ICategoryMatchingAnimation _CategoryAnimationCache;

		// Token: 0x04001A1D RID: 6685
		private bool _CategoryAnimationInited;

		// Token: 0x04001A1E RID: 6686
		private ICategoryMatchingSucceed _CallbackCache;

		// Token: 0x04001A1F RID: 6687
		private bool _CallbackInited;
	}
}
