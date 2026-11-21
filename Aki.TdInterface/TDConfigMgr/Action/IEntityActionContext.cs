using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B9B RID: 7067
	public class IEntityActionContext : IActionContextType
	{
		// Token: 0x06009625 RID: 38437 RVA: 0x0015D9E4 File Offset: 0x0015BBE4
		private IEntityActionContext_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEntityActionContext 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEntityActionContext_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEntityActionContext_SetValue());
			}
			return result;
		}

		// Token: 0x06009626 RID: 38438 RVA: 0x0015DA1C File Offset: 0x0015BC1C
		public static IEntityActionContext Create([Nullable(2)] IEntityActionContext instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityActionContext
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009627 RID: 38439 RVA: 0x0015DA2F File Offset: 0x0015BC2F
		public static IEntityActionContext CreateFromSetValue([Nullable(2)] IEntityActionContext_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEntityActionContext
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009628 RID: 38440 RVA: 0x0015DA42 File Offset: 0x0015BC42
		public new IEntityActionContext_SetValue ToSetValue()
		{
			return new IEntityActionContext_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002FB6 RID: 12214
		// (get) Token: 0x06009629 RID: 38441 RVA: 0x0015DA55 File Offset: 0x0015BC55
		// (set) Token: 0x0600962A RID: 38442 RVA: 0x0015DA80 File Offset: 0x0015BC80
		public new virtual string Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005CCF RID: 23759
		[Nullable(2)]
		protected new IEntityActionContext FbInstance;

		// Token: 0x04005CD0 RID: 23760
		[Nullable(2)]
		protected new IEntityActionContext_SetValue PocoInterface;
	}
}
