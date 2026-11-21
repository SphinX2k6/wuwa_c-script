using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C2C RID: 3116
	public class ICategoryMatchingConfig
	{
		// Token: 0x06004760 RID: 18272 RVA: 0x000B500E File Offset: 0x000B320E
		public static ICategoryMatchingConfig Create(ICategoryMatchingConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICategoryMatchingConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001303 RID: 4867
		// (get) Token: 0x06004761 RID: 18273 RVA: 0x000B502D File Offset: 0x000B322D
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

		// Token: 0x17001304 RID: 4868
		// (get) Token: 0x06004762 RID: 18274 RVA: 0x000B5061 File Offset: 0x000B3261
		public virtual ICategoryMatchingAnimation Animation
		{
			get
			{
				if (this._AnimationInited)
				{
					return this._AnimationCache;
				}
				this._AnimationInited = true;
				this._AnimationCache = ICategoryMatchingAnimation.Create(this.Instance.Animation);
				return this._AnimationCache;
			}
		}

		// Token: 0x17001305 RID: 4869
		// (get) Token: 0x06004763 RID: 18275 RVA: 0x000B5095 File Offset: 0x000B3295
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

		// Token: 0x17001306 RID: 4870
		// (get) Token: 0x06004764 RID: 18276 RVA: 0x000B50C9 File Offset: 0x000B32C9
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
				this._ItemLockingConfigCache = IItemLockingConfig.Create(this.Instance.ItemLockingConfig);
				return this._ItemLockingConfigCache;
			}
		}

		// Token: 0x04002817 RID: 10263
		private ICategoryMatchingConfig Instance;

		// Token: 0x04002818 RID: 10264
		[Nullable(2)]
		private ICategoryMatchingCondition _ConditionCache;

		// Token: 0x04002819 RID: 10265
		private bool _ConditionInited;

		// Token: 0x0400281A RID: 10266
		[Nullable(2)]
		private ICategoryMatchingAnimation _AnimationCache;

		// Token: 0x0400281B RID: 10267
		private bool _AnimationInited;

		// Token: 0x0400281C RID: 10268
		[Nullable(2)]
		private ICategoryMatchingSucceed _CallbackCache;

		// Token: 0x0400281D RID: 10269
		private bool _CallbackInited;

		// Token: 0x0400281E RID: 10270
		[Nullable(2)]
		private IItemLockingConfig _ItemLockingConfigCache;

		// Token: 0x0400281F RID: 10271
		private bool _ItemLockingConfigInited;
	}
}
