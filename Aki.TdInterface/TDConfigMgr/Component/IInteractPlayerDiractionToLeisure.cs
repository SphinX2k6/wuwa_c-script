using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000483 RID: 1155
	[NullableContext(1)]
	[Nullable(0)]
	public class IInteractPlayerDiractionToLeisure : IInteractPlayerDiractionType
	{
		// Token: 0x0600173E RID: 5950 RVA: 0x00046AD8 File Offset: 0x00044CD8
		private IInteractPlayerDiractionToLeisure_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInteractPlayerDiractionToLeisure 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInteractPlayerDiractionToLeisure_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInteractPlayerDiractionToLeisure_SetValue());
			}
			return result;
		}

		// Token: 0x0600173F RID: 5951 RVA: 0x00046B10 File Offset: 0x00044D10
		public static IInteractPlayerDiractionToLeisure Create([Nullable(2)] IInteractPlayerDiractionToLeisure instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractPlayerDiractionToLeisure
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001740 RID: 5952 RVA: 0x00046B23 File Offset: 0x00044D23
		public static IInteractPlayerDiractionToLeisure CreateFromSetValue([Nullable(2)] IInteractPlayerDiractionToLeisure_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInteractPlayerDiractionToLeisure
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001741 RID: 5953 RVA: 0x00046B36 File Offset: 0x00044D36
		public new IInteractPlayerDiractionToLeisure_SetValue ToSetValue()
		{
			return new IInteractPlayerDiractionToLeisure_SetValue
			{
				Type = this.Type,
				Begin = this.Begin,
				End = this.End
			};
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06001742 RID: 5954 RVA: 0x00046B61 File Offset: 0x00044D61
		// (set) Token: 0x06001743 RID: 5955 RVA: 0x00046B8C File Offset: 0x00044D8C
		public override EInteractPlayerDiractionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInteractPlayerDiractionType.Npc;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06001744 RID: 5956 RVA: 0x00046B9A File Offset: 0x00044D9A
		// (set) Token: 0x06001745 RID: 5957 RVA: 0x00046BC5 File Offset: 0x00044DC5
		public virtual int Begin
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Begin;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Begin;
			}
			set
			{
				this.GetOrCreatePoco().Begin = value;
			}
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06001746 RID: 5958 RVA: 0x00046BD3 File Offset: 0x00044DD3
		// (set) Token: 0x06001747 RID: 5959 RVA: 0x00046BFE File Offset: 0x00044DFE
		public virtual int End
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.End;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.End;
			}
			set
			{
				this.GetOrCreatePoco().End = value;
			}
		}

		// Token: 0x0400117A RID: 4474
		[Nullable(2)]
		protected new IInteractPlayerDiractionToLeisure FbInstance;

		// Token: 0x0400117B RID: 4475
		[Nullable(2)]
		protected new IInteractPlayerDiractionToLeisure_SetValue PocoInterface;
	}
}
