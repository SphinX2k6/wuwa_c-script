using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018FC RID: 6396
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonBtContext : IVarContext
	{
		// Token: 0x0600890D RID: 35085 RVA: 0x00143BC4 File Offset: 0x00141DC4
		private ICommonBtContext_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICommonBtContext 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICommonBtContext_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICommonBtContext_SetValue());
			}
			return result;
		}

		// Token: 0x0600890E RID: 35086 RVA: 0x00143BFC File Offset: 0x00141DFC
		public static ICommonBtContext Create([Nullable(2)] ICommonBtContext instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonBtContext
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600890F RID: 35087 RVA: 0x00143C0F File Offset: 0x00141E0F
		public static ICommonBtContext CreateFromSetValue([Nullable(2)] ICommonBtContext_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICommonBtContext
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008910 RID: 35088 RVA: 0x00143C22 File Offset: 0x00141E22
		public new ICommonBtContext_SetValue ToSetValue()
		{
			return new ICommonBtContext_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x17002C61 RID: 11361
		// (get) Token: 0x06008911 RID: 35089 RVA: 0x00143C41 File Offset: 0x00141E41
		// (set) Token: 0x06008912 RID: 35090 RVA: 0x00143C6C File Offset: 0x00141E6C
		public override EVarContext Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return (EVarContext)0;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002C62 RID: 11362
		// (get) Token: 0x06008913 RID: 35091 RVA: 0x00143C7A File Offset: 0x00141E7A
		// (set) Token: 0x06008914 RID: 35092 RVA: 0x00143CA5 File Offset: 0x00141EA5
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x040055EE RID: 21998
		[Nullable(2)]
		protected new ICommonBtContext FbInstance;

		// Token: 0x040055EF RID: 21999
		[Nullable(2)]
		protected new ICommonBtContext_SetValue PocoInterface;
	}
}
