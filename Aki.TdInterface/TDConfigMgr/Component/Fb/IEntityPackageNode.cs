using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CC5 RID: 3269
	public class IEntityPackageNode
	{
		// Token: 0x06004AB6 RID: 19126 RVA: 0x000BBC69 File Offset: 0x000B9E69
		public static IEntityPackageNode Create(IEntityPackageNode? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityPackageNode
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001527 RID: 5415
		// (get) Token: 0x06004AB7 RID: 19127 RVA: 0x000BBC88 File Offset: 0x000B9E88
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17001528 RID: 5416
		// (get) Token: 0x06004AB8 RID: 19128 RVA: 0x000BBC98 File Offset: 0x000B9E98
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IEntityPackageNode> Children
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._ChildrenInited)
				{
					return this._ChildrenCache;
				}
				this._ChildrenInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int childrenLength = this.Instance.ChildrenLength;
				this._ChildrenCache = new List<IEntityPackageNode>(childrenLength);
				for (int i = 0; i < childrenLength; i++)
				{
					this._ChildrenCache.Add(IEntityPackageNode.Create(this.Instance.Children(i)));
				}
				return this._ChildrenCache;
			}
		}

		// Token: 0x04002A54 RID: 10836
		private IEntityPackageNode Instance;

		// Token: 0x04002A55 RID: 10837
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IEntityPackageNode> _ChildrenCache;

		// Token: 0x04002A56 RID: 10838
		private bool _ChildrenInited;
	}
}
