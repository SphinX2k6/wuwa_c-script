using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001ACF RID: 6863
	public class ICurrentVehicle : ITargetVehicle
	{
		// Token: 0x060091D3 RID: 37331 RVA: 0x00156088 File Offset: 0x00154288
		private ICurrentVehicle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICurrentVehicle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICurrentVehicle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICurrentVehicle_SetValue());
			}
			return result;
		}

		// Token: 0x060091D4 RID: 37332 RVA: 0x001560C0 File Offset: 0x001542C0
		public static ICurrentVehicle Create([Nullable(2)] ICurrentVehicle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICurrentVehicle
			{
				FbInstance = instance
			};
		}

		// Token: 0x060091D5 RID: 37333 RVA: 0x001560D3 File Offset: 0x001542D3
		public static ICurrentVehicle CreateFromSetValue([Nullable(2)] ICurrentVehicle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICurrentVehicle
			{
				PocoInterface = value
			};
		}

		// Token: 0x060091D6 RID: 37334 RVA: 0x001560E6 File Offset: 0x001542E6
		public new ICurrentVehicle_SetValue ToSetValue()
		{
			return new ICurrentVehicle_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002EBF RID: 11967
		// (get) Token: 0x060091D7 RID: 37335 RVA: 0x001560F9 File Offset: 0x001542F9
		// (set) Token: 0x060091D8 RID: 37336 RVA: 0x00156124 File Offset: 0x00154324
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

		// Token: 0x04005AF0 RID: 23280
		[Nullable(2)]
		protected new ICurrentVehicle FbInstance;

		// Token: 0x04005AF1 RID: 23281
		[Nullable(2)]
		protected new ICurrentVehicle_SetValue PocoInterface;
	}
}
