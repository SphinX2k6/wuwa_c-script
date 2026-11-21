using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002061 RID: 8289
	public class ISetMotorSpeedType
	{
		// Token: 0x0600AFEF RID: 45039 RVA: 0x0018C18C File Offset: 0x0018A38C
		private ISetMotorSpeedType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetMotorSpeedType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetMotorSpeedType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetMotorSpeedType_SetValue());
			}
			return result;
		}

		// Token: 0x0600AFF0 RID: 45040 RVA: 0x0018C1C4 File Offset: 0x0018A3C4
		public static ISetMotorSpeedType Create([Nullable(2)] ISetMotorSpeedType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetMotorSpeedType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AFF1 RID: 45041 RVA: 0x0018C1D7 File Offset: 0x0018A3D7
		public static ISetMotorSpeedType CreateFromSetValue([Nullable(2)] ISetMotorSpeedType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetMotorSpeedType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AFF2 RID: 45042 RVA: 0x0018C1EA File Offset: 0x0018A3EA
		public ISetMotorSpeedType_SetValue ToSetValue()
		{
			return new ISetMotorSpeedType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003574 RID: 13684
		// (get) Token: 0x0600AFF3 RID: 45043 RVA: 0x0018C1FD File Offset: 0x0018A3FD
		// (set) Token: 0x0600AFF4 RID: 45044 RVA: 0x0018C228 File Offset: 0x0018A428
		public virtual EMotorSpeedType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMotorSpeedType.TargetSpeed;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040068AF RID: 26799
		[Nullable(2)]
		protected ISetMotorSpeedType FbInstance;

		// Token: 0x040068B0 RID: 26800
		[Nullable(2)]
		protected ISetMotorSpeedType_SetValue PocoInterface;
	}
}
