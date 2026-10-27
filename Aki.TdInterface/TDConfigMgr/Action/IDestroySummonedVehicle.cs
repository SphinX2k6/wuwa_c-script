using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001990 RID: 6544
	[NullableContext(1)]
	[Nullable(0)]
	public class IDestroySummonedVehicle : IDestroySummonedEntitiesType
	{
		// Token: 0x06008C17 RID: 35863 RVA: 0x00148EE4 File Offset: 0x001470E4
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

		// Token: 0x06008C18 RID: 35864 RVA: 0x00148F1C File Offset: 0x0014711C
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

		// Token: 0x06008C19 RID: 35865 RVA: 0x00148F2F File Offset: 0x0014712F
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

		// Token: 0x06008C1A RID: 35866 RVA: 0x00148F42 File Offset: 0x00147142
		public new IDestroySummonedVehicle_SetValue ToSetValue()
		{
			return new IDestroySummonedVehicle_SetValue
			{
				Type = this.Type,
				TemplateId = this.TemplateId
			};
		}

		// Token: 0x17002D08 RID: 11528
		// (get) Token: 0x06008C1B RID: 35867 RVA: 0x00148F61 File Offset: 0x00147161
		// (set) Token: 0x06008C1C RID: 35868 RVA: 0x00148F8C File Offset: 0x0014718C
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

		// Token: 0x17002D09 RID: 11529
		// (get) Token: 0x06008C1D RID: 35869 RVA: 0x00148F9A File Offset: 0x0014719A
		// (set) Token: 0x06008C1E RID: 35870 RVA: 0x00148FC5 File Offset: 0x001471C5
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

		// Token: 0x04005745 RID: 22341
		[Nullable(2)]
		protected new IDestroySummonedVehicle FbInstance;

		// Token: 0x04005746 RID: 22342
		[Nullable(2)]
		protected new IDestroySummonedVehicle_SetValue PocoInterface;
	}
}
