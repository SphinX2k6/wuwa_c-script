using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CED RID: 3309
	[NullableContext(1)]
	[Nullable(0)]
	public class EntityBundleComponent : IComponentBase
	{
		// Token: 0x06004B95 RID: 19349 RVA: 0x000BCB20 File Offset: 0x000BAD20
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

		// Token: 0x17001778 RID: 6008
		// (get) Token: 0x06004B96 RID: 19350 RVA: 0x000BCB40 File Offset: 0x000BAD40
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

		// Token: 0x17001779 RID: 6009
		// (get) Token: 0x06004B97 RID: 19351 RVA: 0x000BCB78 File Offset: 0x000BAD78
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700177A RID: 6010
		// (get) Token: 0x06004B98 RID: 19352 RVA: 0x000BCB8E File Offset: 0x000BAD8E
		public virtual int BundleId
		{
			get
			{
				return this.Instance.BundleId;
			}
		}

		// Token: 0x1700177B RID: 6011
		// (get) Token: 0x06004B99 RID: 19353 RVA: 0x000BCB9C File Offset: 0x000BAD9C
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

		// Token: 0x04002B34 RID: 11060
		private IEntityBundleComponent Instance;

		// Token: 0x04002B35 RID: 11061
		private List<IEntityBundleChildInfo> _ChildInfosCache;

		// Token: 0x04002B36 RID: 11062
		private bool _ChildInfosInited;
	}
}
