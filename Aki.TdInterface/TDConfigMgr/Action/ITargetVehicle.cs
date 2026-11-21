using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021CB RID: 8651
	public class ITargetVehicle
	{
		// Token: 0x0600BC92 RID: 48274 RVA: 0x001B484C File Offset: 0x001B2A4C
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

		// Token: 0x0600BC93 RID: 48275 RVA: 0x001B4884 File Offset: 0x001B2A84
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

		// Token: 0x0600BC94 RID: 48276 RVA: 0x001B4897 File Offset: 0x001B2A97
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

		// Token: 0x0600BC95 RID: 48277 RVA: 0x001B48AA File Offset: 0x001B2AAA
		public ITargetVehicle_SetValue ToSetValue()
		{
			return new ITargetVehicle_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170039A8 RID: 14760
		// (get) Token: 0x0600BC96 RID: 48278 RVA: 0x001B48BD File Offset: 0x001B2ABD
		// (set) Token: 0x0600BC97 RID: 48279 RVA: 0x001B48E8 File Offset: 0x001B2AE8
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

		// Token: 0x04007155 RID: 29013
		[Nullable(2)]
		protected ITargetVehicle FbInstance;

		// Token: 0x04007156 RID: 29014
		[Nullable(2)]
		protected ITargetVehicle_SetValue PocoInterface;
	}
}
