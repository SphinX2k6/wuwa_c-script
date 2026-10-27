using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B5E RID: 2910
	[NullableContext(1)]
	[Nullable(0)]
	public class ICategoryMatchingConfig
	{
		// Token: 0x06004307 RID: 17159 RVA: 0x000AAF4A File Offset: 0x000A914A
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

		// Token: 0x17001208 RID: 4616
		// (get) Token: 0x06004308 RID: 17160 RVA: 0x000AAF69 File Offset: 0x000A9169
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

		// Token: 0x17001209 RID: 4617
		// (get) Token: 0x06004309 RID: 17161 RVA: 0x000AAF9D File Offset: 0x000A919D
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

		// Token: 0x1700120A RID: 4618
		// (get) Token: 0x0600430A RID: 17162 RVA: 0x000AAFD1 File Offset: 0x000A91D1
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

		// Token: 0x1700120B RID: 4619
		// (get) Token: 0x0600430B RID: 17163 RVA: 0x000AB005 File Offset: 0x000A9205
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

		// Token: 0x040025CF RID: 9679
		private ICategoryMatchingConfig Instance;

		// Token: 0x040025D0 RID: 9680
		[Nullable(2)]
		private ICategoryMatchingCondition _ConditionCache;

		// Token: 0x040025D1 RID: 9681
		private bool _ConditionInited;

		// Token: 0x040025D2 RID: 9682
		[Nullable(2)]
		private ICategoryMatchingAnimation _AnimationCache;

		// Token: 0x040025D3 RID: 9683
		private bool _AnimationInited;

		// Token: 0x040025D4 RID: 9684
		[Nullable(2)]
		private ICategoryMatchingSucceed _CallbackCache;

		// Token: 0x040025D5 RID: 9685
		private bool _CallbackInited;

		// Token: 0x040025D6 RID: 9686
		[Nullable(2)]
		private IItemLockingConfig _ItemLockingConfigCache;

		// Token: 0x040025D7 RID: 9687
		private bool _ItemLockingConfigInited;
	}
}
