using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A08 RID: 6664
	[NullableContext(1)]
	[Nullable(0)]
	public class IEntityActionContext : IActionContextType
	{
		// Token: 0x06008EC3 RID: 36547 RVA: 0x0014DB74 File Offset: 0x0014BD74
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

		// Token: 0x06008EC4 RID: 36548 RVA: 0x0014DBAC File Offset: 0x0014BDAC
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

		// Token: 0x06008EC5 RID: 36549 RVA: 0x0014DBBF File Offset: 0x0014BDBF
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

		// Token: 0x06008EC6 RID: 36550 RVA: 0x0014DBD2 File Offset: 0x0014BDD2
		public new IEntityActionContext_SetValue ToSetValue()
		{
			return new IEntityActionContext_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002DAA RID: 11690
		// (get) Token: 0x06008EC7 RID: 36551 RVA: 0x0014DBE5 File Offset: 0x0014BDE5
		// (set) Token: 0x06008EC8 RID: 36552 RVA: 0x0014DC10 File Offset: 0x0014BE10
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

		// Token: 0x0400586D RID: 22637
		[Nullable(2)]
		protected new IEntityActionContext FbInstance;

		// Token: 0x0400586E RID: 22638
		[Nullable(2)]
		protected new IEntityActionContext_SetValue PocoInterface;
	}
}
