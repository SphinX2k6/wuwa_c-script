using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BAB RID: 7083
	public class IEntityTemplateContext : IVarContext
	{
		// Token: 0x0600967F RID: 38527 RVA: 0x0015E494 File Offset: 0x0015C694
		private IEntityTemplateContext_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEntityTemplateContext 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEntityTemplateContext_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEntityTemplateContext_SetValue());
			}
			return result;
		}

		// Token: 0x06009680 RID: 38528 RVA: 0x0015E4CC File Offset: 0x0015C6CC
		public static IEntityTemplateContext Create([Nullable(2)] IEntityTemplateContext instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityTemplateContext
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009681 RID: 38529 RVA: 0x0015E4DF File Offset: 0x0015C6DF
		public static IEntityTemplateContext CreateFromSetValue([Nullable(2)] IEntityTemplateContext_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEntityTemplateContext
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009682 RID: 38530 RVA: 0x0015E4F2 File Offset: 0x0015C6F2
		public new IEntityTemplateContext_SetValue ToSetValue()
		{
			return new IEntityTemplateContext_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x17002FCB RID: 12235
		// (get) Token: 0x06009683 RID: 38531 RVA: 0x0015E511 File Offset: 0x0015C711
		// (set) Token: 0x06009684 RID: 38532 RVA: 0x0015E53C File Offset: 0x0015C73C
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

		// Token: 0x17002FCC RID: 12236
		// (get) Token: 0x06009685 RID: 38533 RVA: 0x0015E54A File Offset: 0x0015C74A
		// (set) Token: 0x06009686 RID: 38534 RVA: 0x0015E575 File Offset: 0x0015C775
		public virtual string Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x04005CFC RID: 23804
		[Nullable(2)]
		protected new IEntityTemplateContext FbInstance;

		// Token: 0x04005CFD RID: 23805
		[Nullable(2)]
		protected new IEntityTemplateContext_SetValue PocoInterface;
	}
}
