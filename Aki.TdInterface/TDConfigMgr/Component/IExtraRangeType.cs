using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003AF RID: 943
	public class IExtraRangeType
	{
		// Token: 0x0600128B RID: 4747 RVA: 0x0003DDF4 File Offset: 0x0003BFF4
		private IExtraRangeType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IExtraRangeType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IExtraRangeType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IExtraRangeType_SetValue());
			}
			return result;
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x0003DE2C File Offset: 0x0003C02C
		public static IExtraRangeType Create([Nullable(2)] IExtraRangeType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExtraRangeType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x0003DE3F File Offset: 0x0003C03F
		public static IExtraRangeType CreateFromSetValue([Nullable(2)] IExtraRangeType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IExtraRangeType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x0003DE52 File Offset: 0x0003C052
		public IExtraRangeType_SetValue ToSetValue()
		{
			return new IExtraRangeType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x0600128F RID: 4751 RVA: 0x0003DE65 File Offset: 0x0003C065
		// (set) Token: 0x06001290 RID: 4752 RVA: 0x0003DE90 File Offset: 0x0003C090
		public virtual EExtraRangeType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EExtraRangeType.SunSpiritBlock;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000F3C RID: 3900
		[Nullable(2)]
		protected IExtraRangeType FbInstance;

		// Token: 0x04000F3D RID: 3901
		[Nullable(2)]
		protected IExtraRangeType_SetValue PocoInterface;
	}
}
