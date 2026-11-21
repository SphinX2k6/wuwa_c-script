using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F93 RID: 8083
	public class IQuestVarContext : IVarContext
	{
		// Token: 0x0600ABD1 RID: 43985 RVA: 0x00184BF4 File Offset: 0x00182DF4
		private IQuestVarContext_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IQuestVarContext 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IQuestVarContext_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IQuestVarContext_SetValue());
			}
			return result;
		}

		// Token: 0x0600ABD2 RID: 43986 RVA: 0x00184C2C File Offset: 0x00182E2C
		public static IQuestVarContext Create([Nullable(2)] IQuestVarContext instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestVarContext
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600ABD3 RID: 43987 RVA: 0x00184C3F File Offset: 0x00182E3F
		public static IQuestVarContext CreateFromSetValue([Nullable(2)] IQuestVarContext_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IQuestVarContext
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600ABD4 RID: 43988 RVA: 0x00184C52 File Offset: 0x00182E52
		public new IQuestVarContext_SetValue ToSetValue()
		{
			return new IQuestVarContext_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x1700349A RID: 13466
		// (get) Token: 0x0600ABD5 RID: 43989 RVA: 0x00184C71 File Offset: 0x00182E71
		// (set) Token: 0x0600ABD6 RID: 43990 RVA: 0x00184C9C File Offset: 0x00182E9C
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

		// Token: 0x1700349B RID: 13467
		// (get) Token: 0x0600ABD7 RID: 43991 RVA: 0x00184CAA File Offset: 0x00182EAA
		// (set) Token: 0x0600ABD8 RID: 43992 RVA: 0x00184CD5 File Offset: 0x00182ED5
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

		// Token: 0x040066CF RID: 26319
		[Nullable(2)]
		protected new IQuestVarContext FbInstance;

		// Token: 0x040066D0 RID: 26320
		[Nullable(2)]
		protected new IQuestVarContext_SetValue PocoInterface;
	}
}
