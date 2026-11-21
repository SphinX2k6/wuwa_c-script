using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BAD RID: 7085
	public class IEntityVarContext : IVarContext
	{
		// Token: 0x06009689 RID: 38537 RVA: 0x0015E594 File Offset: 0x0015C794
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

		// Token: 0x0600968A RID: 38538 RVA: 0x0015E5CC File Offset: 0x0015C7CC
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

		// Token: 0x0600968B RID: 38539 RVA: 0x0015E5DF File Offset: 0x0015C7DF
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

		// Token: 0x0600968C RID: 38540 RVA: 0x0015E5F2 File Offset: 0x0015C7F2
		public new IEntityVarContext_SetValue ToSetValue()
		{
			return new IEntityVarContext_SetValue
			{
				Type = this.Type,
				Id = this.Id,
				MatchType = this.MatchType
			};
		}

		// Token: 0x17002FCD RID: 12237
		// (get) Token: 0x0600968D RID: 38541 RVA: 0x0015E61D File Offset: 0x0015C81D
		// (set) Token: 0x0600968E RID: 38542 RVA: 0x0015E648 File Offset: 0x0015C848
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

		// Token: 0x17002FCE RID: 12238
		// (get) Token: 0x0600968F RID: 38543 RVA: 0x0015E656 File Offset: 0x0015C856
		// (set) Token: 0x06009690 RID: 38544 RVA: 0x0015E681 File Offset: 0x0015C881
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

		// Token: 0x17002FCF RID: 12239
		// (get) Token: 0x06009691 RID: 38545 RVA: 0x0015E690 File Offset: 0x0015C890
		// (set) Token: 0x06009692 RID: 38546 RVA: 0x0015E6CA File Offset: 0x0015C8CA
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

		// Token: 0x04005D00 RID: 23808
		[Nullable(2)]
		protected new IEntityVarContext FbInstance;

		// Token: 0x04005D01 RID: 23809
		[Nullable(2)]
		protected new IEntityVarContext_SetValue PocoInterface;
	}
}
