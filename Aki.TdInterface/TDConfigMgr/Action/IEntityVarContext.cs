using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A18 RID: 6680
	[NullableContext(1)]
	[Nullable(0)]
	public class IEntityVarContext : IVarContext
	{
		// Token: 0x06008F1F RID: 36639 RVA: 0x0014E668 File Offset: 0x0014C868
		private IEntityVarContext_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEntityVarContext 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEntityVarContext_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEntityVarContext_SetValue());
			}
			return result;
		}

		// Token: 0x06008F20 RID: 36640 RVA: 0x0014E6A0 File Offset: 0x0014C8A0
		public static IEntityVarContext Create([Nullable(2)] IEntityVarContext instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityVarContext
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008F21 RID: 36641 RVA: 0x0014E6B3 File Offset: 0x0014C8B3
		public static IEntityVarContext CreateFromSetValue([Nullable(2)] IEntityVarContext_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEntityVarContext
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008F22 RID: 36642 RVA: 0x0014E6C6 File Offset: 0x0014C8C6
		public new IEntityVarContext_SetValue ToSetValue()
		{
			return new IEntityVarContext_SetValue
			{
				Type = this.Type,
				Id = this.Id,
				MatchType = this.MatchType
			};
		}

		// Token: 0x17002DC0 RID: 11712
		// (get) Token: 0x06008F23 RID: 36643 RVA: 0x0014E6F1 File Offset: 0x0014C8F1
		// (set) Token: 0x06008F24 RID: 36644 RVA: 0x0014E71C File Offset: 0x0014C91C
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

		// Token: 0x17002DC1 RID: 11713
		// (get) Token: 0x06008F25 RID: 36645 RVA: 0x0014E72A File Offset: 0x0014C92A
		// (set) Token: 0x06008F26 RID: 36646 RVA: 0x0014E755 File Offset: 0x0014C955
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

		// Token: 0x17002DC2 RID: 11714
		// (get) Token: 0x06008F27 RID: 36647 RVA: 0x0014E764 File Offset: 0x0014C964
		// (set) Token: 0x06008F28 RID: 36648 RVA: 0x0014E79E File Offset: 0x0014C99E
		public virtual EEntityVarMatchType? MatchType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MatchType;
				}
				IEntityVarContext_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MatchType;
			}
			set
			{
				this.GetOrCreatePoco().MatchType = value;
			}
		}

		// Token: 0x0400589B RID: 22683
		[Nullable(2)]
		protected new IEntityVarContext FbInstance;

		// Token: 0x0400589C RID: 22684
		[Nullable(2)]
		protected new IEntityVarContext_SetValue PocoInterface;
	}
}
