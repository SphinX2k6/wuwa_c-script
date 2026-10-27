using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D82 RID: 7554
	[NullableContext(1)]
	[Nullable(0)]
	public class IQuestVarContext : IVarContext
	{
		// Token: 0x0600A1E5 RID: 41445 RVA: 0x001707D0 File Offset: 0x0016E9D0
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

		// Token: 0x0600A1E6 RID: 41446 RVA: 0x00170808 File Offset: 0x0016EA08
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

		// Token: 0x0600A1E7 RID: 41447 RVA: 0x0017081B File Offset: 0x0016EA1B
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

		// Token: 0x0600A1E8 RID: 41448 RVA: 0x0017082E File Offset: 0x0016EA2E
		public new IQuestVarContext_SetValue ToSetValue()
		{
			return new IQuestVarContext_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x17003206 RID: 12806
		// (get) Token: 0x0600A1E9 RID: 41449 RVA: 0x0017084D File Offset: 0x0016EA4D
		// (set) Token: 0x0600A1EA RID: 41450 RVA: 0x00170878 File Offset: 0x0016EA78
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

		// Token: 0x17003207 RID: 12807
		// (get) Token: 0x0600A1EB RID: 41451 RVA: 0x00170886 File Offset: 0x0016EA86
		// (set) Token: 0x0600A1EC RID: 41452 RVA: 0x001708B1 File Offset: 0x0016EAB1
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

		// Token: 0x04006153 RID: 24915
		[Nullable(2)]
		protected new IQuestVarContext FbInstance;

		// Token: 0x04006154 RID: 24916
		[Nullable(2)]
		protected new IQuestVarContext_SetValue PocoInterface;
	}
}
