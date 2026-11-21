using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002027 RID: 8231
	public class ISelfVehicle : ITargetVehicle
	{
		// Token: 0x0600AEBF RID: 44735 RVA: 0x00189E14 File Offset: 0x00188014
		private ISelfVehicle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISelfVehicle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISelfVehicle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISelfVehicle_SetValue());
			}
			return result;
		}

		// Token: 0x0600AEC0 RID: 44736 RVA: 0x00189E4C File Offset: 0x0018804C
		public static ISelfVehicle Create([Nullable(2)] ISelfVehicle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISelfVehicle
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AEC1 RID: 44737 RVA: 0x00189E5F File Offset: 0x0018805F
		public static ISelfVehicle CreateFromSetValue([Nullable(2)] ISelfVehicle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISelfVehicle
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AEC2 RID: 44738 RVA: 0x00189E72 File Offset: 0x00188072
		public new ISelfVehicle_SetValue ToSetValue()
		{
			return new ISelfVehicle_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003533 RID: 13619
		// (get) Token: 0x0600AEC3 RID: 44739 RVA: 0x00189E85 File Offset: 0x00188085
		// (set) Token: 0x0600AEC4 RID: 44740 RVA: 0x00189EB0 File Offset: 0x001880B0
		public override ETargetVehicle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETargetVehicle.Current;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006820 RID: 26656
		[Nullable(2)]
		protected new ISelfVehicle FbInstance;

		// Token: 0x04006821 RID: 26657
		[Nullable(2)]
		protected new ISelfVehicle_SetValue PocoInterface;
	}
}
