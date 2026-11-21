using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CA6 RID: 7334
	public class IHealthBarDisplayClientFunction : EnableClientFunction
	{
		// Token: 0x06009BC0 RID: 39872 RVA: 0x001678D0 File Offset: 0x00165AD0
		private IHealthBarDisplayClientFunction_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHealthBarDisplayClientFunction 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHealthBarDisplayClientFunction_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHealthBarDisplayClientFunction_SetValue());
			}
			return result;
		}

		// Token: 0x06009BC1 RID: 39873 RVA: 0x00167908 File Offset: 0x00165B08
		public static IHealthBarDisplayClientFunction Create([Nullable(2)] IHealthBarDisplayClientFunction instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHealthBarDisplayClientFunction
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009BC2 RID: 39874 RVA: 0x0016791B File Offset: 0x00165B1B
		public static IHealthBarDisplayClientFunction CreateFromSetValue([Nullable(2)] IHealthBarDisplayClientFunction_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHealthBarDisplayClientFunction
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009BC3 RID: 39875 RVA: 0x0016792E File Offset: 0x00165B2E
		public new IHealthBarDisplayClientFunction_SetValue ToSetValue()
		{
			return new IHealthBarDisplayClientFunction_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId,
				IsVisible = this.IsVisible
			};
		}

		// Token: 0x170030F4 RID: 12532
		// (get) Token: 0x06009BC4 RID: 39876 RVA: 0x00167959 File Offset: 0x00165B59
		// (set) Token: 0x06009BC5 RID: 39877 RVA: 0x00167984 File Offset: 0x00165B84
		public override EEnableClientFunctionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEnableClientFunctionType.HealthBarDisplay;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170030F5 RID: 12533
		// (get) Token: 0x06009BC6 RID: 39878 RVA: 0x00167992 File Offset: 0x00165B92
		// (set) Token: 0x06009BC7 RID: 39879 RVA: 0x001679BD File Offset: 0x00165BBD
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x170030F6 RID: 12534
		// (get) Token: 0x06009BC8 RID: 39880 RVA: 0x001679CB File Offset: 0x00165BCB
		// (set) Token: 0x06009BC9 RID: 39881 RVA: 0x001679F6 File Offset: 0x00165BF6
		public virtual bool IsVisible
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsVisible;
				}
				return this.PocoInterface != null && this.PocoInterface.IsVisible;
			}
			set
			{
				this.GetOrCreatePoco().IsVisible = value;
			}
		}

		// Token: 0x04005F5F RID: 24415
		[Nullable(2)]
		protected new IHealthBarDisplayClientFunction FbInstance;

		// Token: 0x04005F60 RID: 24416
		[Nullable(2)]
		protected new IHealthBarDisplayClientFunction_SetValue PocoInterface;
	}
}
