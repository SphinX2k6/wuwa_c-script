using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C2A RID: 3114
	public class ICategoryMatchingConfigBase
	{
		// Token: 0x06004757 RID: 18263 RVA: 0x000B4EE0 File Offset: 0x000B30E0
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

		// Token: 0x170012FE RID: 4862
		// (get) Token: 0x06004758 RID: 18264 RVA: 0x000B4EFF File Offset: 0x000B30FF
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

		// Token: 0x170012FF RID: 4863
		// (get) Token: 0x06004759 RID: 18265 RVA: 0x000B4F33 File Offset: 0x000B3133
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

		// Token: 0x17001300 RID: 4864
		// (get) Token: 0x0600475A RID: 18266 RVA: 0x000B4F67 File Offset: 0x000B3167
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

		// Token: 0x0400280F RID: 10255
		private ICategoryMatchingConfigBase Instance;

		// Token: 0x04002810 RID: 10256
		[Nullable(2)]
		private ICategoryMatchingCondition _ConditionCache;

		// Token: 0x04002811 RID: 10257
		private bool _ConditionInited;

		// Token: 0x04002812 RID: 10258
		[Nullable(2)]
		private ICategoryMatchingAnimationBase _AnimationCache;

		// Token: 0x04002813 RID: 10259
		private bool _AnimationInited;

		// Token: 0x04002814 RID: 10260
		[Nullable(2)]
		private ICategoryMatchingSucceedBase _CallbackCache;

		// Token: 0x04002815 RID: 10261
		private bool _CallbackInited;
	}
}
