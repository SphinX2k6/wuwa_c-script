using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018F8 RID: 6392
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonBtActionContext : IActionContextType
	{
		// Token: 0x060088FB RID: 35067 RVA: 0x00143A08 File Offset: 0x00141C08
		private ICommonBtActionContext_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICommonBtActionContext 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICommonBtActionContext_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICommonBtActionContext_SetValue());
			}
			return result;
		}

		// Token: 0x060088FC RID: 35068 RVA: 0x00143A40 File Offset: 0x00141C40
		public static ICommonBtActionContext Create([Nullable(2)] ICommonBtActionContext instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonBtActionContext
			{
				FbInstance = instance
			};
		}

		// Token: 0x060088FD RID: 35069 RVA: 0x00143A53 File Offset: 0x00141C53
		public static ICommonBtActionContext CreateFromSetValue([Nullable(2)] ICommonBtActionContext_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICommonBtActionContext
			{
				PocoInterface = value
			};
		}

		// Token: 0x060088FE RID: 35070 RVA: 0x00143A66 File Offset: 0x00141C66
		public new ICommonBtActionContext_SetValue ToSetValue()
		{
			return new ICommonBtActionContext_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002C5E RID: 11358
		// (get) Token: 0x060088FF RID: 35071 RVA: 0x00143A79 File Offset: 0x00141C79
		// (set) Token: 0x06008900 RID: 35072 RVA: 0x00143AA4 File Offset: 0x00141CA4
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

		// Token: 0x040055E7 RID: 21991
		[Nullable(2)]
		protected new ICommonBtActionContext FbInstance;

		// Token: 0x040055E8 RID: 21992
		[Nullable(2)]
		protected new ICommonBtActionContext_SetValue PocoInterface;
	}
}
