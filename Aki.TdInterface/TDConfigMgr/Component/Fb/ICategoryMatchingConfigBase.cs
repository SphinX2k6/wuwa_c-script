using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B5C RID: 2908
	[NullableContext(1)]
	[Nullable(0)]
	public class ICategoryMatchingConfigBase
	{
		// Token: 0x060042FE RID: 17150 RVA: 0x000AAE1C File Offset: 0x000A901C
		public static ICategoryMatchingConfigBase Create(ICategoryMatchingConfigBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICategoryMatchingConfigBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001203 RID: 4611
		// (get) Token: 0x060042FF RID: 17151 RVA: 0x000AAE3B File Offset: 0x000A903B
		public virtual ICategoryMatchingCondition Condition
		{
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

		// Token: 0x17001204 RID: 4612
		// (get) Token: 0x06004300 RID: 17152 RVA: 0x000AAE6F File Offset: 0x000A906F
		public virtual ICategoryMatchingAnimationBase Animation
		{
			get
			{
				if (this._AnimationInited)
				{
					return this._AnimationCache;
				}
				this._AnimationInited = true;
				this._AnimationCache = ICategoryMatchingAnimationBase.Create(this.Instance.Animation);
				return this._AnimationCache;
			}
		}

		// Token: 0x17001205 RID: 4613
		// (get) Token: 0x06004301 RID: 17153 RVA: 0x000AAEA3 File Offset: 0x000A90A3
		public virtual ICategoryMatchingSucceedBase Callback
		{
			get
			{
				if (this._CallbackInited)
				{
					return this._CallbackCache;
				}
				this._CallbackInited = true;
				this._CallbackCache = ICategoryMatchingSucceedBase.Create(this.Instance.Callback);
				return this._CallbackCache;
			}
		}

		// Token: 0x040025C7 RID: 9671
		private ICategoryMatchingConfigBase Instance;

		// Token: 0x040025C8 RID: 9672
		[Nullable(2)]
		private ICategoryMatchingCondition _ConditionCache;

		// Token: 0x040025C9 RID: 9673
		private bool _ConditionInited;

		// Token: 0x040025CA RID: 9674
		[Nullable(2)]
		private ICategoryMatchingAnimationBase _AnimationCache;

		// Token: 0x040025CB RID: 9675
		private bool _AnimationInited;

		// Token: 0x040025CC RID: 9676
		[Nullable(2)]
		private ICategoryMatchingSucceedBase _CallbackCache;

		// Token: 0x040025CD RID: 9677
		private bool _CallbackInited;
	}
}
