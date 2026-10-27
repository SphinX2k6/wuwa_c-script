using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000331 RID: 817
	[NullableContext(1)]
	[Nullable(0)]
	public class IEntityPackageNode
	{
		// Token: 0x06001014 RID: 4116 RVA: 0x000380FC File Offset: 0x000362FC
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

		// Token: 0x06001015 RID: 4117 RVA: 0x00038134 File Offset: 0x00036334
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

		// Token: 0x06001016 RID: 4118 RVA: 0x00038147 File Offset: 0x00036347
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

		// Token: 0x06001017 RID: 4119 RVA: 0x0003815A File Offset: 0x0003635A
		public IEntityPackageNode_SetValue ToSetValue()
		{
			return new IEntityPackageNode_SetValue
			{
				EntityId = this.EntityId,
				Children = this.Children
			};
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06001018 RID: 4120 RVA: 0x00038179 File Offset: 0x00036379
		// (set) Token: 0x06001019 RID: 4121 RVA: 0x000381A4 File Offset: 0x000363A4
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

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x0600101A RID: 4122 RVA: 0x000381B4 File Offset: 0x000363B4
		// (set) Token: 0x0600101B RID: 4123 RVA: 0x00038247 File Offset: 0x00036447
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().Children = value;
				this._ChildrenInited = false;
			}
		}

		// Token: 0x04000D94 RID: 3476
		[Nullable(2)]
		protected IEntityPackageNode FbInstance;

		// Token: 0x04000D95 RID: 3477
		[Nullable(2)]
		protected IEntityPackageNode_SetValue PocoInterface;

		// Token: 0x04000D96 RID: 3478
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IEntityPackageNode> _ChildrenCache;

		// Token: 0x04000D97 RID: 3479
		private bool _ChildrenInited;
	}
}
