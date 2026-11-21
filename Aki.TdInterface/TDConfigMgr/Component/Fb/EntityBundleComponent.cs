using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DE5 RID: 3557
	public class EntityBundleComponent : IComponentBase
	{
		// Token: 0x060050A3 RID: 20643 RVA: 0x000C804E File Offset: 0x000C624E
		public static EntityBundleComponent Create(IEntityBundleComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EntityBundleComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170018D4 RID: 6356
		// (get) Token: 0x060050A4 RID: 20644 RVA: 0x000C8070 File Offset: 0x000C6270
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

		// Token: 0x170018D5 RID: 6357
		// (get) Token: 0x060050A5 RID: 20645 RVA: 0x000C80A8 File Offset: 0x000C62A8
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170018D6 RID: 6358
		// (get) Token: 0x060050A6 RID: 20646 RVA: 0x000C80BE File Offset: 0x000C62BE
		public virtual int BundleId
		{
			get
			{
				return this.Instance.BundleId;
			}
		}

		// Token: 0x170018D7 RID: 6359
		// (get) Token: 0x060050A7 RID: 20647 RVA: 0x000C80CC File Offset: 0x000C62CC
		public virtual List<IEntityBundleChildInfo> ChildInfos
		{
			get
			{
				if (this._ChildInfosInited)
				{
					return this._ChildInfosCache;
				}
				this._ChildInfosInited = true;
				int childInfosLength = this.Instance.ChildInfosLength;
				this._ChildInfosCache = new List<IEntityBundleChildInfo>(childInfosLength);
				for (int i = 0; i < childInfosLength; i++)
				{
					this._ChildInfosCache.Add(IEntityBundleChildInfo.Create(this.Instance.ChildInfos(i)));
				}
				return this._ChildInfosCache;
			}
		}

		// Token: 0x04002DEE RID: 11758
		private IEntityBundleComponent Instance;

		// Token: 0x04002DEF RID: 11759
		private List<IEntityBundleChildInfo> _ChildInfosCache;

		// Token: 0x04002DF0 RID: 11760
		private bool _ChildInfosInited;
	}
}
