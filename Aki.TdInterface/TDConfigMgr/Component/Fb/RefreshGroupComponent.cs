using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AC0 RID: 2752
	[NullableContext(1)]
	[Nullable(0)]
	public class RefreshGroupComponent : IComponentBase
	{
		// Token: 0x06003F64 RID: 16228 RVA: 0x000A1EDE File Offset: 0x000A00DE
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

		// Token: 0x17000FA1 RID: 4001
		// (get) Token: 0x06003F65 RID: 16229 RVA: 0x000A1F00 File Offset: 0x000A0100
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

		// Token: 0x17000FA2 RID: 4002
		// (get) Token: 0x06003F66 RID: 16230 RVA: 0x000A1F38 File Offset: 0x000A0138
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000FA3 RID: 4003
		// (get) Token: 0x06003F67 RID: 16231 RVA: 0x000A1F50 File Offset: 0x000A0150
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

		// Token: 0x17000FA4 RID: 4004
		// (get) Token: 0x06003F68 RID: 16232 RVA: 0x000A1FB4 File Offset: 0x000A01B4
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

		// Token: 0x17000FA5 RID: 4005
		// (get) Token: 0x06003F69 RID: 16233 RVA: 0x000A1FE3 File Offset: 0x000A01E3
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

		// Token: 0x17000FA6 RID: 4006
		// (get) Token: 0x06003F6A RID: 16234 RVA: 0x000A2012 File Offset: 0x000A0212
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

		// Token: 0x04002333 RID: 9011
		private IRefreshGroupComponent Instance;

		// Token: 0x04002334 RID: 9012
		private List<int> _EntityIdsCache;

		// Token: 0x04002335 RID: 9013
		private bool _EntityIdsInited;

		// Token: 0x04002336 RID: 9014
		private IRefreshContent _RefreshContentCache;

		// Token: 0x04002337 RID: 9015
		private bool _RefreshContentInited;

		// Token: 0x04002338 RID: 9016
		private IRefreshRule _RefreshRuleCache;

		// Token: 0x04002339 RID: 9017
		private bool _RefreshRuleInited;

		// Token: 0x0400233A RID: 9018
		[Nullable(2)]
		private IStateChangeConfig _StateChangeConfigCache;

		// Token: 0x0400233B RID: 9019
		private bool _StateChangeConfigInited;
	}
}
