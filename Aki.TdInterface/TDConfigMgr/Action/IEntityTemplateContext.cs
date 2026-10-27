using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A16 RID: 6678
	[NullableContext(1)]
	[Nullable(0)]
	public class IEntityTemplateContext : IVarContext
	{
		// Token: 0x06008F15 RID: 36629 RVA: 0x0014E568 File Offset: 0x0014C768
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

		// Token: 0x06008F16 RID: 36630 RVA: 0x0014E5A0 File Offset: 0x0014C7A0
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

		// Token: 0x06008F17 RID: 36631 RVA: 0x0014E5B3 File Offset: 0x0014C7B3
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

		// Token: 0x06008F18 RID: 36632 RVA: 0x0014E5C6 File Offset: 0x0014C7C6
		public new IEntityTemplateContext_SetValue ToSetValue()
		{
			return new IEntityTemplateContext_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x17002DBE RID: 11710
		// (get) Token: 0x06008F19 RID: 36633 RVA: 0x0014E5E5 File Offset: 0x0014C7E5
		// (set) Token: 0x06008F1A RID: 36634 RVA: 0x0014E610 File Offset: 0x0014C810
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

		// Token: 0x17002DBF RID: 11711
		// (get) Token: 0x06008F1B RID: 36635 RVA: 0x0014E61E File Offset: 0x0014C81E
		// (set) Token: 0x06008F1C RID: 36636 RVA: 0x0014E649 File Offset: 0x0014C849
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

		// Token: 0x04005897 RID: 22679
		[Nullable(2)]
		protected new IEntityTemplateContext FbInstance;

		// Token: 0x04005898 RID: 22680
		[Nullable(2)]
		protected new IEntityTemplateContext_SetValue PocoInterface;
	}
}
