using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A5F RID: 2655
	[NullableContext(1)]
	[Nullable(0)]
	public class IRefreshGroup : IComponentBase
	{
		// Token: 0x06003D22 RID: 15650 RVA: 0x0009D211 File Offset: 0x0009B411
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

		// Token: 0x17000E21 RID: 3617
		// (get) Token: 0x06003D23 RID: 15651 RVA: 0x0009D230 File Offset: 0x0009B430
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

		// Token: 0x17000E22 RID: 3618
		// (get) Token: 0x06003D24 RID: 15652 RVA: 0x0009D268 File Offset: 0x0009B468
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E23 RID: 3619
		// (get) Token: 0x06003D25 RID: 15653 RVA: 0x0009D27E File Offset: 0x0009B47E
		public virtual int RefreshInterval
		{
			get
			{
				return this.Instance.RefreshInterval;
			}
		}

		// Token: 0x17000E24 RID: 3620
		// (get) Token: 0x06003D26 RID: 15654 RVA: 0x0009D28B File Offset: 0x0009B48B
		public virtual bool DelayRefresh
		{
			get
			{
				return this.Instance.DelayRefresh;
			}
		}

		// Token: 0x17000E25 RID: 3621
		// (get) Token: 0x06003D27 RID: 15655 RVA: 0x0009D298 File Offset: 0x0009B498
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

		// Token: 0x17000E26 RID: 3622
		// (get) Token: 0x06003D28 RID: 15656 RVA: 0x0009D2FC File Offset: 0x0009B4FC
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

		// Token: 0x0400220E RID: 8718
		private IRefreshGroup Instance;

		// Token: 0x0400220F RID: 8719
		private List<int> _EntityIdListCache;

		// Token: 0x04002210 RID: 8720
		private bool _EntityIdListInited;

		// Token: 0x04002211 RID: 8721
		[Nullable(2)]
		private ICylinder _IsUesCylinderCache;

		// Token: 0x04002212 RID: 8722
		private bool _IsUesCylinderInited;
	}
}
