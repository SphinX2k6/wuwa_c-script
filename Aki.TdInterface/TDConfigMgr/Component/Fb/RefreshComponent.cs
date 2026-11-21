using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B85 RID: 2949
	public class RefreshComponent : IComponentBase
	{
		// Token: 0x06004376 RID: 17270 RVA: 0x000AB1E9 File Offset: 0x000A93E9
		public static RefreshComponent Create(IRefreshComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RefreshComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001067 RID: 4199
		// (get) Token: 0x06004377 RID: 17271 RVA: 0x000AB208 File Offset: 0x000A9408
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17001068 RID: 4200
		// (get) Token: 0x06004378 RID: 17272 RVA: 0x000AB240 File Offset: 0x000A9440
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001069 RID: 4201
		// (get) Token: 0x06004379 RID: 17273 RVA: 0x000AB256 File Offset: 0x000A9456
		public virtual IRefreshRule RefreshRule
		{
			get
			{
				if (this._RefreshRuleInited)
				{
					return this._RefreshRuleCache;
				}
				this._RefreshRuleInited = true;
				this._RefreshRuleCache = ComponentReadHelper.ReadRefreshComponent_RefreshRule(this.Instance);
				return this._RefreshRuleCache;
			}
		}

		// Token: 0x1700106A RID: 4202
		// (get) Token: 0x0600437A RID: 17274 RVA: 0x000AB288 File Offset: 0x000A9488
		public virtual bool? IsDisableRefreshAfterDroppingReward
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsDisableRefreshAfterDroppingReward);
			}
		}

		// Token: 0x1700106B RID: 4203
		// (get) Token: 0x0600437B RID: 17275 RVA: 0x000AB2C0 File Offset: 0x000A94C0
		public virtual bool? IsResetOnDungeonRestart
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsResetOnDungeonRestart);
			}
		}

		// Token: 0x04002544 RID: 9540
		private IRefreshComponent Instance;

		// Token: 0x04002545 RID: 9541
		private IRefreshRule _RefreshRuleCache;

		// Token: 0x04002546 RID: 9542
		private bool _RefreshRuleInited;
	}
}
