using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B63 RID: 2915
	[NullableContext(2)]
	[Nullable(0)]
	public class IRangeAdsorptionFoundation : IItemFoundationType
	{
		// Token: 0x0600431E RID: 17182 RVA: 0x000AB22A File Offset: 0x000A942A
		[NullableContext(1)]
		public static IRangeAdsorptionFoundation Create(IRangeAdsorptionFoundation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRangeAdsorptionFoundation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001215 RID: 4629
		// (get) Token: 0x0600431F RID: 17183 RVA: 0x000AB249 File Offset: 0x000A9449
		public override EItemFoundation Type
		{
			get
			{
				return (EItemFoundation)this.Instance.Type;
			}
		}

		// Token: 0x17001216 RID: 4630
		// (get) Token: 0x06004320 RID: 17184 RVA: 0x000AB256 File Offset: 0x000A9456
		[Nullable(1)]
		public virtual ICategoryMatchingCondition Condition
		{
			[NullableContext(1)]
			get
			{
				if (this._ConditionInited)
				{
					return this._ConditionCache;
				}
				this._ConditionInited = true;
				this._ConditionCache = ICategoryMatchingCondition.Create(this.Instance.Condition);
				return this._ConditionCache;
			}
		}

		// Token: 0x17001217 RID: 4631
		// (get) Token: 0x06004321 RID: 17185 RVA: 0x000AB28A File Offset: 0x000A948A
		[Nullable(1)]
		public virtual IAdsorptionMatchingAnimation Animation
		{
			[NullableContext(1)]
			get
			{
				if (this._AnimationInited)
				{
					return this._AnimationCache;
				}
				this._AnimationInited = true;
				this._AnimationCache = IAdsorptionMatchingAnimation.Create(this.Instance.Animation);
				return this._AnimationCache;
			}
		}

		// Token: 0x17001218 RID: 4632
		// (get) Token: 0x06004322 RID: 17186 RVA: 0x000AB2BE File Offset: 0x000A94BE
		public virtual ICategoryMatchingAnimation CategoryAnimation
		{
			get
			{
				if (this._CategoryAnimationInited)
				{
					return this._CategoryAnimationCache;
				}
				this._CategoryAnimationInited = true;
				this._CategoryAnimationCache = ICategoryMatchingAnimation.Create(this.Instance.CategoryAnimation);
				return this._CategoryAnimationCache;
			}
		}

		// Token: 0x17001219 RID: 4633
		// (get) Token: 0x06004323 RID: 17187 RVA: 0x000AB2F2 File Offset: 0x000A94F2
		public virtual ICategoryMatchingSucceed Callback
		{
			get
			{
				if (this._CallbackInited)
				{
					return this._CallbackCache;
				}
				this._CallbackInited = true;
				this._CallbackCache = ICategoryMatchingSucceed.Create(this.Instance.Callback);
				return this._CallbackCache;
			}
		}

		// Token: 0x040025E2 RID: 9698
		private IRangeAdsorptionFoundation Instance;

		// Token: 0x040025E3 RID: 9699
		private ICategoryMatchingCondition _ConditionCache;

		// Token: 0x040025E4 RID: 9700
		private bool _ConditionInited;

		// Token: 0x040025E5 RID: 9701
		private IAdsorptionMatchingAnimation _AnimationCache;

		// Token: 0x040025E6 RID: 9702
		private bool _AnimationInited;

		// Token: 0x040025E7 RID: 9703
		private ICategoryMatchingAnimation _CategoryAnimationCache;

		// Token: 0x040025E8 RID: 9704
		private bool _CategoryAnimationInited;

		// Token: 0x040025E9 RID: 9705
		private ICategoryMatchingSucceed _CallbackCache;

		// Token: 0x040025EA RID: 9706
		private bool _CallbackInited;
	}
}
