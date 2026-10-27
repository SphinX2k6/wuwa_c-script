using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F8E RID: 8078
	[NullableContext(1)]
	[Nullable(0)]
	public class ITargetVehicle
	{
		// Token: 0x0600B1AE RID: 45486 RVA: 0x0019E7B8 File Offset: 0x0019C9B8
		private ITargetVehicle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITargetVehicle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITargetVehicle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITargetVehicle_SetValue());
			}
			return result;
		}

		// Token: 0x0600B1AF RID: 45487 RVA: 0x0019E7F0 File Offset: 0x0019C9F0
		public static ITargetVehicle Create([Nullable(2)] ITargetVehicle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITargetVehicle
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B1B0 RID: 45488 RVA: 0x0019E803 File Offset: 0x0019CA03
		public static ITargetVehicle CreateFromSetValue([Nullable(2)] ITargetVehicle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITargetVehicle
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B1B1 RID: 45489 RVA: 0x0019E816 File Offset: 0x0019CA16
		public ITargetVehicle_SetValue ToSetValue()
		{
			return new ITargetVehicle_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170036DA RID: 14042
		// (get) Token: 0x0600B1B2 RID: 45490 RVA: 0x0019E829 File Offset: 0x0019CA29
		// (set) Token: 0x0600B1B3 RID: 45491 RVA: 0x0019E854 File Offset: 0x0019CA54
		public virtual ETargetVehicle Type
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

		// Token: 0x04006B67 RID: 27495
		[Nullable(2)]
		protected ITargetVehicle FbInstance;

		// Token: 0x04006B68 RID: 27496
		[Nullable(2)]
		protected ITargetVehicle_SetValue PocoInterface;
	}
}
