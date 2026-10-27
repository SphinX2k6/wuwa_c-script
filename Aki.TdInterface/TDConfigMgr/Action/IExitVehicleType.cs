using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A2F RID: 6703
	[NullableContext(1)]
	[Nullable(0)]
	public class IExitVehicleType
	{
		// Token: 0x06008F8A RID: 36746 RVA: 0x0014F224 File Offset: 0x0014D424
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

		// Token: 0x06008F8B RID: 36747 RVA: 0x0014F25C File Offset: 0x0014D45C
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

		// Token: 0x06008F8C RID: 36748 RVA: 0x0014F26F File Offset: 0x0014D46F
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

		// Token: 0x06008F8D RID: 36749 RVA: 0x0014F282 File Offset: 0x0014D482
		public IExitVehicleType_SetValue ToSetValue()
		{
			return new IExitVehicleType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002DD4 RID: 11732
		// (get) Token: 0x06008F8E RID: 36750 RVA: 0x0014F295 File Offset: 0x0014D495
		// (set) Token: 0x06008F8F RID: 36751 RVA: 0x0014F2C0 File Offset: 0x0014D4C0
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

		// Token: 0x040058CB RID: 22731
		[Nullable(2)]
		protected IExitVehicleType FbInstance;

		// Token: 0x040058CC RID: 22732
		[Nullable(2)]
		protected IExitVehicleType_SetValue PocoInterface;
	}
}
