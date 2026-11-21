using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002126 RID: 8486
	public class ISummonVehicle : ISummonEntityType
	{
		// Token: 0x0600B428 RID: 46120 RVA: 0x00193DF4 File Offset: 0x00191FF4
		private ISummonVehicle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISummonVehicle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISummonVehicle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISummonVehicle_SetValue());
			}
			return result;
		}

		// Token: 0x0600B429 RID: 46121 RVA: 0x00193E2C File Offset: 0x0019202C
		public static ISummonVehicle Create([Nullable(2)] ISummonVehicle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISummonVehicle
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B42A RID: 46122 RVA: 0x00193E3F File Offset: 0x0019203F
		public static ISummonVehicle CreateFromSetValue([Nullable(2)] ISummonVehicle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISummonVehicle
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B42B RID: 46123 RVA: 0x00193E52 File Offset: 0x00192052
		public new ISummonVehicle_SetValue ToSetValue()
		{
			return new ISummonVehicle_SetValue
			{
				Type = this.Type,
				TemplateId = this.TemplateId,
				PositionEntityId = this.PositionEntityId
			};
		}

		// Token: 0x1700366A RID: 13930
		// (get) Token: 0x0600B42C RID: 46124 RVA: 0x00193E7D File Offset: 0x0019207D
		// (set) Token: 0x0600B42D RID: 46125 RVA: 0x00193EA8 File Offset: 0x001920A8
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

		// Token: 0x1700366B RID: 13931
		// (get) Token: 0x0600B42E RID: 46126 RVA: 0x00193EB6 File Offset: 0x001920B6
		// (set) Token: 0x0600B42F RID: 46127 RVA: 0x00193EE1 File Offset: 0x001920E1
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

		// Token: 0x1700366C RID: 13932
		// (get) Token: 0x0600B430 RID: 46128 RVA: 0x00193EEF File Offset: 0x001920EF
		// (set) Token: 0x0600B431 RID: 46129 RVA: 0x00193F1A File Offset: 0x0019211A
		public virtual int PositionEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PositionEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.PositionEntityId;
			}
			set
			{
				this.GetOrCreatePoco().PositionEntityId = value;
			}
		}

		// Token: 0x04006AB1 RID: 27313
		[Nullable(2)]
		protected new ISummonVehicle FbInstance;

		// Token: 0x04006AB2 RID: 27314
		[Nullable(2)]
		protected new ISummonVehicle_SetValue PocoInterface;
	}
}
