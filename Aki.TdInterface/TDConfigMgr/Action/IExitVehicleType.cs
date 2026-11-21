using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BC4 RID: 7108
	public class IExitVehicleType
	{
		// Token: 0x060096F4 RID: 38644 RVA: 0x0015F150 File Offset: 0x0015D350
		private IExitVehicleType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IExitVehicleType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IExitVehicleType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IExitVehicleType_SetValue());
			}
			return result;
		}

		// Token: 0x060096F5 RID: 38645 RVA: 0x0015F188 File Offset: 0x0015D388
		public static IExitVehicleType Create([Nullable(2)] IExitVehicleType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExitVehicleType
			{
				FbInstance = instance
			};
		}

		// Token: 0x060096F6 RID: 38646 RVA: 0x0015F19B File Offset: 0x0015D39B
		public static IExitVehicleType CreateFromSetValue([Nullable(2)] IExitVehicleType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IExitVehicleType
			{
				PocoInterface = value
			};
		}

		// Token: 0x060096F7 RID: 38647 RVA: 0x0015F1AE File Offset: 0x0015D3AE
		public IExitVehicleType_SetValue ToSetValue()
		{
			return new IExitVehicleType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002FE1 RID: 12257
		// (get) Token: 0x060096F8 RID: 38648 RVA: 0x0015F1C1 File Offset: 0x0015D3C1
		// (set) Token: 0x060096F9 RID: 38649 RVA: 0x0015F1EC File Offset: 0x0015D3EC
		public virtual EExitVehicleType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EExitVehicleType.Launch;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005D30 RID: 23856
		[Nullable(2)]
		protected IExitVehicleType FbInstance;

		// Token: 0x04005D31 RID: 23857
		[Nullable(2)]
		protected IExitVehicleType_SetValue PocoInterface;
	}
}
