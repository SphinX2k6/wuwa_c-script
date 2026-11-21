using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B17 RID: 6935
	public class IDestroySummonedVehicle : IDestroySummonedEntitiesType
	{
		// Token: 0x0600933B RID: 37691 RVA: 0x001586F4 File Offset: 0x001568F4
		private IDestroySummonedVehicle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDestroySummonedVehicle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDestroySummonedVehicle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDestroySummonedVehicle_SetValue());
			}
			return result;
		}

		// Token: 0x0600933C RID: 37692 RVA: 0x0015872C File Offset: 0x0015692C
		public static IDestroySummonedVehicle Create([Nullable(2)] IDestroySummonedVehicle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDestroySummonedVehicle
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600933D RID: 37693 RVA: 0x0015873F File Offset: 0x0015693F
		public static IDestroySummonedVehicle CreateFromSetValue([Nullable(2)] IDestroySummonedVehicle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDestroySummonedVehicle
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600933E RID: 37694 RVA: 0x00158752 File Offset: 0x00156952
		public new IDestroySummonedVehicle_SetValue ToSetValue()
		{
			return new IDestroySummonedVehicle_SetValue
			{
				Type = this.Type,
				TemplateId = this.TemplateId
			};
		}

		// Token: 0x17002F07 RID: 12039
		// (get) Token: 0x0600933F RID: 37695 RVA: 0x00158771 File Offset: 0x00156971
		// (set) Token: 0x06009340 RID: 37696 RVA: 0x0015879C File Offset: 0x0015699C
		public override ESummonEntityType Type
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

		// Token: 0x17002F08 RID: 12040
		// (get) Token: 0x06009341 RID: 37697 RVA: 0x001587AA File Offset: 0x001569AA
		// (set) Token: 0x06009342 RID: 37698 RVA: 0x001587D5 File Offset: 0x001569D5
		public override string TemplateId
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

		// Token: 0x04005B8E RID: 23438
		[Nullable(2)]
		protected new IDestroySummonedVehicle FbInstance;

		// Token: 0x04005B8F RID: 23439
		[Nullable(2)]
		protected new IDestroySummonedVehicle_SetValue PocoInterface;
	}
}
