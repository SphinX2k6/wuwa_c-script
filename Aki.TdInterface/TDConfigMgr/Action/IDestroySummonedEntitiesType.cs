using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200198E RID: 6542
	[NullableContext(1)]
	[Nullable(0)]
	public class IDestroySummonedEntitiesType
	{
		// Token: 0x06008C0D RID: 35853 RVA: 0x00148DE4 File Offset: 0x00146FE4
		private IDestroySummonedEntitiesType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDestroySummonedEntitiesType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDestroySummonedEntitiesType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDestroySummonedEntitiesType_SetValue());
			}
			return result;
		}

		// Token: 0x06008C0E RID: 35854 RVA: 0x00148E1C File Offset: 0x0014701C
		public static IDestroySummonedEntitiesType Create([Nullable(2)] IDestroySummonedEntitiesType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDestroySummonedEntitiesType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008C0F RID: 35855 RVA: 0x00148E2F File Offset: 0x0014702F
		public static IDestroySummonedEntitiesType CreateFromSetValue([Nullable(2)] IDestroySummonedEntitiesType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDestroySummonedEntitiesType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008C10 RID: 35856 RVA: 0x00148E42 File Offset: 0x00147042
		public IDestroySummonedEntitiesType_SetValue ToSetValue()
		{
			return new IDestroySummonedEntitiesType_SetValue
			{
				Type = this.Type,
				TemplateId = this.TemplateId
			};
		}

		// Token: 0x17002D06 RID: 11526
		// (get) Token: 0x06008C11 RID: 35857 RVA: 0x00148E61 File Offset: 0x00147061
		// (set) Token: 0x06008C12 RID: 35858 RVA: 0x00148E8C File Offset: 0x0014708C
		public virtual ESummonEntityType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESummonEntityType.Vehicle;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002D07 RID: 11527
		// (get) Token: 0x06008C13 RID: 35859 RVA: 0x00148E9A File Offset: 0x0014709A
		// (set) Token: 0x06008C14 RID: 35860 RVA: 0x00148EC5 File Offset: 0x001470C5
		public virtual string TemplateId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TemplateId;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TemplateId;
			}
			set
			{
				this.GetOrCreatePoco().TemplateId = value;
			}
		}

		// Token: 0x04005741 RID: 22337
		[Nullable(2)]
		protected IDestroySummonedEntitiesType FbInstance;

		// Token: 0x04005742 RID: 22338
		[Nullable(2)]
		protected IDestroySummonedEntitiesType_SetValue PocoInterface;
	}
}
