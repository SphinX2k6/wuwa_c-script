using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000ABB RID: 2747
	[NullableContext(1)]
	[Nullable(0)]
	public class RefreshComponent : IComponentBase
	{
		// Token: 0x06003F4C RID: 16204 RVA: 0x000A1BF5 File Offset: 0x0009FDF5
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

		// Token: 0x17000F93 RID: 3987
		// (get) Token: 0x06003F4D RID: 16205 RVA: 0x000A1C14 File Offset: 0x0009FE14
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

		// Token: 0x17000F94 RID: 3988
		// (get) Token: 0x06003F4E RID: 16206 RVA: 0x000A1C4C File Offset: 0x0009FE4C
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F95 RID: 3989
		// (get) Token: 0x06003F4F RID: 16207 RVA: 0x000A1C62 File Offset: 0x0009FE62
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

		// Token: 0x17000F96 RID: 3990
		// (get) Token: 0x06003F50 RID: 16208 RVA: 0x000A1C94 File Offset: 0x0009FE94
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

		// Token: 0x17000F97 RID: 3991
		// (get) Token: 0x06003F51 RID: 16209 RVA: 0x000A1CCC File Offset: 0x0009FECC
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

		// Token: 0x04002328 RID: 9000
		private IRefreshComponent Instance;

		// Token: 0x04002329 RID: 9001
		private IRefreshRule _RefreshRuleCache;

		// Token: 0x0400232A RID: 9002
		private bool _RefreshRuleInited;
	}
}
