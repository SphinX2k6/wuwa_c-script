using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B8A RID: 2954
	public class RefreshGroupComponent : IComponentBase
	{
		// Token: 0x0600438E RID: 17294 RVA: 0x000AB4D2 File Offset: 0x000A96D2
		public static RefreshGroupComponent Create(IRefreshGroupComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RefreshGroupComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001075 RID: 4213
		// (get) Token: 0x0600438F RID: 17295 RVA: 0x000AB4F4 File Offset: 0x000A96F4
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

		// Token: 0x17001076 RID: 4214
		// (get) Token: 0x06004390 RID: 17296 RVA: 0x000AB52C File Offset: 0x000A972C
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001077 RID: 4215
		// (get) Token: 0x06004391 RID: 17297 RVA: 0x000AB544 File Offset: 0x000A9744
		public virtual List<int> EntityIds
		{
			get
			{
				if (this._EntityIdsInited)
				{
					return this._EntityIdsCache;
				}
				this._EntityIdsInited = true;
				int entityIdsLength = this.Instance.EntityIdsLength;
				this._EntityIdsCache = new List<int>(entityIdsLength);
				for (int i = 0; i < entityIdsLength; i++)
				{
					this._EntityIdsCache.Add(this.Instance.EntityIds(i));
				}
				return this._EntityIdsCache;
			}
		}

		// Token: 0x17001078 RID: 4216
		// (get) Token: 0x06004392 RID: 17298 RVA: 0x000AB5A8 File Offset: 0x000A97A8
		public virtual IRefreshContent RefreshContent
		{
			get
			{
				if (this._RefreshContentInited)
				{
					return this._RefreshContentCache;
				}
				this._RefreshContentInited = true;
				this._RefreshContentCache = ComponentReadHelper.ReadRefreshGroupComponent_RefreshContent(this.Instance);
				return this._RefreshContentCache;
			}
		}

		// Token: 0x17001079 RID: 4217
		// (get) Token: 0x06004393 RID: 17299 RVA: 0x000AB5D7 File Offset: 0x000A97D7
		public virtual IRefreshRule RefreshRule
		{
			get
			{
				if (this._RefreshRuleInited)
				{
					return this._RefreshRuleCache;
				}
				this._RefreshRuleInited = true;
				this._RefreshRuleCache = ComponentReadHelper.ReadRefreshGroupComponent_RefreshRule(this.Instance);
				return this._RefreshRuleCache;
			}
		}

		// Token: 0x1700107A RID: 4218
		// (get) Token: 0x06004394 RID: 17300 RVA: 0x000AB606 File Offset: 0x000A9806
		[Nullable(2)]
		public virtual IStateChangeConfig StateChangeConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._StateChangeConfigInited)
				{
					return this._StateChangeConfigCache;
				}
				this._StateChangeConfigInited = true;
				this._StateChangeConfigCache = IStateChangeConfig.Create(this.Instance.StateChangeConfig);
				return this._StateChangeConfigCache;
			}
		}

		// Token: 0x0400254F RID: 9551
		private IRefreshGroupComponent Instance;

		// Token: 0x04002550 RID: 9552
		private List<int> _EntityIdsCache;

		// Token: 0x04002551 RID: 9553
		private bool _EntityIdsInited;

		// Token: 0x04002552 RID: 9554
		private IRefreshContent _RefreshContentCache;

		// Token: 0x04002553 RID: 9555
		private bool _RefreshContentInited;

		// Token: 0x04002554 RID: 9556
		private IRefreshRule _RefreshRuleCache;

		// Token: 0x04002555 RID: 9557
		private bool _RefreshRuleInited;

		// Token: 0x04002556 RID: 9558
		[Nullable(2)]
		private IStateChangeConfig _StateChangeConfigCache;

		// Token: 0x04002557 RID: 9559
		private bool _StateChangeConfigInited;
	}
}
