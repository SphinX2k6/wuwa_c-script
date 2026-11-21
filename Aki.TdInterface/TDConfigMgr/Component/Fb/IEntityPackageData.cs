using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CC6 RID: 3270
	public class IEntityPackageData
	{
		// Token: 0x06004ABA RID: 19130 RVA: 0x000BBD1A File Offset: 0x000B9F1A
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

		// Token: 0x17001529 RID: 5417
		// (get) Token: 0x06004ABB RID: 19131 RVA: 0x000BBD3C File Offset: 0x000B9F3C
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

		// Token: 0x1700152A RID: 5418
		// (get) Token: 0x06004ABC RID: 19132 RVA: 0x000BBD74 File Offset: 0x000B9F74
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

		// Token: 0x1700152B RID: 5419
		// (get) Token: 0x06004ABD RID: 19133 RVA: 0x000BBDAC File Offset: 0x000B9FAC
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IEntityPackageNode> PackageTree
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x04002A57 RID: 10839
		private IEntityPackageData Instance;

		// Token: 0x04002A58 RID: 10840
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IEntityPackageNode> _PackageTreeCache;

		// Token: 0x04002A59 RID: 10841
		private bool _PackageTreeInited;
	}
}
