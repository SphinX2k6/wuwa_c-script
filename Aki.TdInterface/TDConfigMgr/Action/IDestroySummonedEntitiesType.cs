using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B15 RID: 6933
	public class IDestroySummonedEntitiesType
	{
		// Token: 0x06009331 RID: 37681 RVA: 0x001585F4 File Offset: 0x001567F4
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

		// Token: 0x06009332 RID: 37682 RVA: 0x0015862C File Offset: 0x0015682C
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

		// Token: 0x06009333 RID: 37683 RVA: 0x0015863F File Offset: 0x0015683F
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

		// Token: 0x06009334 RID: 37684 RVA: 0x00158652 File Offset: 0x00156852
		public IDestroySummonedEntitiesType_SetValue ToSetValue()
		{
			return new IDestroySummonedEntitiesType_SetValue
			{
				Type = this.Type,
				TemplateId = this.TemplateId
			};
		}

		// Token: 0x17002F05 RID: 12037
		// (get) Token: 0x06009335 RID: 37685 RVA: 0x00158671 File Offset: 0x00156871
		// (set) Token: 0x06009336 RID: 37686 RVA: 0x0015869C File Offset: 0x0015689C
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

		// Token: 0x17002F06 RID: 12038
		// (get) Token: 0x06009337 RID: 37687 RVA: 0x001586AA File Offset: 0x001568AA
		// (set) Token: 0x06009338 RID: 37688 RVA: 0x001586D5 File Offset: 0x001568D5
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

		// Token: 0x04005B8A RID: 23434
		[Nullable(2)]
		protected IDestroySummonedEntitiesType FbInstance;

		// Token: 0x04005B8B RID: 23435
		[Nullable(2)]
		protected IDestroySummonedEntitiesType_SetValue PocoInterface;
	}
}
