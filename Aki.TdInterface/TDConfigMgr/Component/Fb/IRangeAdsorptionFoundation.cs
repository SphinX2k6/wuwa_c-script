using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C31 RID: 3121
	[NullableContext(2)]
	[Nullable(0)]
	public class IRangeAdsorptionFoundation : IItemFoundationType
	{
		// Token: 0x06004777 RID: 18295 RVA: 0x000B52EE File Offset: 0x000B34EE
		[NullableContext(0)]
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

		// Token: 0x17001310 RID: 4880
		// (get) Token: 0x06004778 RID: 18296 RVA: 0x000B530D File Offset: 0x000B350D
		public override EItemFoundation Type
		{
			get
			{
				return (EItemFoundation)this.Instance.Type;
			}
		}

		// Token: 0x17001311 RID: 4881
		// (get) Token: 0x06004779 RID: 18297 RVA: 0x000B531A File Offset: 0x000B351A
		[Nullable(0)]
		public virtual ICategoryMatchingCondition Condition
		{
			[NullableContext(0)]
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

		// Token: 0x17001312 RID: 4882
		// (get) Token: 0x0600477A RID: 18298 RVA: 0x000B534E File Offset: 0x000B354E
		[Nullable(0)]
		public virtual IAdsorptionMatchingAnimation Animation
		{
			[NullableContext(0)]
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

		// Token: 0x17001313 RID: 4883
		// (get) Token: 0x0600477B RID: 18299 RVA: 0x000B5382 File Offset: 0x000B3582
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

		// Token: 0x17001314 RID: 4884
		// (get) Token: 0x0600477C RID: 18300 RVA: 0x000B53B6 File Offset: 0x000B35B6
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

		// Token: 0x0400282A RID: 10282
		private IRangeAdsorptionFoundation Instance;

		// Token: 0x0400282B RID: 10283
		private ICategoryMatchingCondition _ConditionCache;

		// Token: 0x0400282C RID: 10284
		private bool _ConditionInited;

		// Token: 0x0400282D RID: 10285
		private IAdsorptionMatchingAnimation _AnimationCache;

		// Token: 0x0400282E RID: 10286
		private bool _AnimationInited;

		// Token: 0x0400282F RID: 10287
		private ICategoryMatchingAnimation _CategoryAnimationCache;

		// Token: 0x04002830 RID: 10288
		private bool _CategoryAnimationInited;

		// Token: 0x04002831 RID: 10289
		private ICategoryMatchingSucceed _CallbackCache;

		// Token: 0x04002832 RID: 10290
		private bool _CallbackInited;
	}
}
