using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000378 RID: 888
	public class IEntityPackageNode
	{
		// Token: 0x06001146 RID: 4422 RVA: 0x0003B0C8 File Offset: 0x000392C8
		private IEntityPackageNode_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEntityPackageNode 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEntityPackageNode_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEntityPackageNode_SetValue());
			}
			return result;
		}

		// Token: 0x06001147 RID: 4423 RVA: 0x0003B100 File Offset: 0x00039300
		public static IEntityPackageNode Create([Nullable(2)] IEntityPackageNode instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityPackageNode
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001148 RID: 4424 RVA: 0x0003B113 File Offset: 0x00039313
		public static IEntityPackageNode CreateFromSetValue([Nullable(2)] IEntityPackageNode_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEntityPackageNode
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001149 RID: 4425 RVA: 0x0003B126 File Offset: 0x00039326
		public IEntityPackageNode_SetValue ToSetValue()
		{
			return new IEntityPackageNode_SetValue
			{
				EntityId = this.EntityId,
				Children = this.Children
			};
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x0600114A RID: 4426 RVA: 0x0003B145 File Offset: 0x00039345
		// (set) Token: 0x0600114B RID: 4427 RVA: 0x0003B170 File Offset: 0x00039370
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x0600114C RID: 4428 RVA: 0x0003B180 File Offset: 0x00039380
		// (set) Token: 0x0600114D RID: 4429 RVA: 0x0003B213 File Offset: 0x00039413
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
				if (this.FbInstance != null)
				{
					List<IEntityPackageNode> children = this.FbInstance.Children;
					if (children != null)
					{
						this._ChildrenCache = new List<IEntityPackageNode>(children.Count);
						for (int i = 0; i < children.Count; i++)
						{
							this._ChildrenCache.Add(IEntityPackageNode.Create(children[i]));
						}
					}
				}
				else
				{
					IEntityPackageNode_SetValue pocoInterface = this.PocoInterface;
					this._ChildrenCache = ((pocoInterface != null) ? pocoInterface.Children : null);
				}
				return this._ChildrenCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().Children = value;
				this._ChildrenInited = false;
			}
		}

		// Token: 0x04000E7F RID: 3711
		[Nullable(2)]
		protected IEntityPackageNode FbInstance;

		// Token: 0x04000E80 RID: 3712
		[Nullable(2)]
		protected IEntityPackageNode_SetValue PocoInterface;

		// Token: 0x04000E81 RID: 3713
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IEntityPackageNode> _ChildrenCache;

		// Token: 0x04000E82 RID: 3714
		private bool _ChildrenInited;
	}
}
