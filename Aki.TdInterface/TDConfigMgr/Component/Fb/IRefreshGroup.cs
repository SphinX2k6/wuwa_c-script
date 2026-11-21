using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B28 RID: 2856
	public class IRefreshGroup : IComponentBase
	{
		// Token: 0x06004142 RID: 16706 RVA: 0x000A6689 File Offset: 0x000A4889
		public static IRefreshGroup Create(IRefreshGroup? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRefreshGroup
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000EED RID: 3821
		// (get) Token: 0x06004143 RID: 16707 RVA: 0x000A66A8 File Offset: 0x000A48A8
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

		// Token: 0x17000EEE RID: 3822
		// (get) Token: 0x06004144 RID: 16708 RVA: 0x000A66E0 File Offset: 0x000A48E0
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000EEF RID: 3823
		// (get) Token: 0x06004145 RID: 16709 RVA: 0x000A66F6 File Offset: 0x000A48F6
		public virtual int RefreshInterval
		{
			get
			{
				return this.Instance.RefreshInterval;
			}
		}

		// Token: 0x17000EF0 RID: 3824
		// (get) Token: 0x06004146 RID: 16710 RVA: 0x000A6703 File Offset: 0x000A4903
		public virtual bool DelayRefresh
		{
			get
			{
				return this.Instance.DelayRefresh;
			}
		}

		// Token: 0x17000EF1 RID: 3825
		// (get) Token: 0x06004147 RID: 16711 RVA: 0x000A6710 File Offset: 0x000A4910
		public virtual List<int> EntityIdList
		{
			get
			{
				if (this._EntityIdListInited)
				{
					return this._EntityIdListCache;
				}
				this._EntityIdListInited = true;
				int entityIdListLength = this.Instance.EntityIdListLength;
				this._EntityIdListCache = new List<int>(entityIdListLength);
				for (int i = 0; i < entityIdListLength; i++)
				{
					this._EntityIdListCache.Add(this.Instance.EntityIdList(i));
				}
				return this._EntityIdListCache;
			}
		}

		// Token: 0x17000EF2 RID: 3826
		// (get) Token: 0x06004148 RID: 16712 RVA: 0x000A6774 File Offset: 0x000A4974
		public virtual ICylinder IsUesCylinder
		{
			get
			{
				if (this._IsUesCylinderInited)
				{
					return this._IsUesCylinderCache;
				}
				this._IsUesCylinderInited = true;
				this._IsUesCylinderCache = ICylinder.Create(this.Instance.IsUesCylinder);
				return this._IsUesCylinderCache;
			}
		}

		// Token: 0x04002425 RID: 9253
		private IRefreshGroup Instance;

		// Token: 0x04002426 RID: 9254
		private List<int> _EntityIdListCache;

		// Token: 0x04002427 RID: 9255
		private bool _EntityIdListInited;

		// Token: 0x04002428 RID: 9256
		[Nullable(2)]
		private ICylinder _IsUesCylinderCache;

		// Token: 0x04002429 RID: 9257
		private bool _IsUesCylinderInited;
	}
}
