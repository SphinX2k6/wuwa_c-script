using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BF6 RID: 3062
	public class IEntityPackageData
	{
		// Token: 0x06004657 RID: 18007 RVA: 0x000B1B4E File Offset: 0x000AFD4E
		[NullableContext(1)]
		public static IEntityPackageData Create(IEntityPackageData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityPackageData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001428 RID: 5160
		// (get) Token: 0x06004658 RID: 18008 RVA: 0x000B1B70 File Offset: 0x000AFD70
		public virtual int? PackagedLevelId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.PackagedLevelId);
			}
		}

		// Token: 0x17001429 RID: 5161
		// (get) Token: 0x06004659 RID: 18009 RVA: 0x000B1BA8 File Offset: 0x000AFDA8
		public virtual int? PackageEntityId
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.PackageEntityId);
			}
		}

		// Token: 0x1700142A RID: 5162
		// (get) Token: 0x0600465A RID: 18010 RVA: 0x000B1BE0 File Offset: 0x000AFDE0
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IEntityPackageNode> PackageTree
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._PackageTreeInited)
				{
					return this._PackageTreeCache;
				}
				this._PackageTreeInited = true;
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				int packageTreeLength = this.Instance.PackageTreeLength;
				this._PackageTreeCache = new List<IEntityPackageNode>(packageTreeLength);
				for (int i = 0; i < packageTreeLength; i++)
				{
					this._PackageTreeCache.Add(IEntityPackageNode.Create(this.Instance.PackageTree(i)));
				}
				return this._PackageTreeCache;
			}
		}

		// Token: 0x0400280B RID: 10251
		private IEntityPackageData Instance;

		// Token: 0x0400280C RID: 10252
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IEntityPackageNode> _PackageTreeCache;

		// Token: 0x0400280D RID: 10253
		private bool _PackageTreeInited;
	}
}
