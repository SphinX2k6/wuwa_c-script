using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BF5 RID: 3061
	public class IEntityPackageNode
	{
		// Token: 0x06004653 RID: 18003 RVA: 0x000B1A9D File Offset: 0x000AFC9D
		[NullableContext(1)]
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

		// Token: 0x17001426 RID: 5158
		// (get) Token: 0x06004654 RID: 18004 RVA: 0x000B1ABC File Offset: 0x000AFCBC
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17001427 RID: 5159
		// (get) Token: 0x06004655 RID: 18005 RVA: 0x000B1ACC File Offset: 0x000AFCCC
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IEntityPackageNode> Children
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x04002808 RID: 10248
		private IEntityPackageNode Instance;

		// Token: 0x04002809 RID: 10249
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IEntityPackageNode> _ChildrenCache;

		// Token: 0x0400280A RID: 10250
		private bool _ChildrenInited;
	}
}
