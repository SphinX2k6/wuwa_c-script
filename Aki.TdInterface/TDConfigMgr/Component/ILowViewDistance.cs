using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004D6 RID: 1238
	[NullableContext(1)]
	[Nullable(0)]
	public class ILowViewDistance : IViewDistanceMode
	{
		// Token: 0x0600191E RID: 6430 RVA: 0x0004A844 File Offset: 0x00048A44
		private ILowViewDistance_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILowViewDistance 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILowViewDistance_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILowViewDistance_SetValue());
			}
			return result;
		}

		// Token: 0x0600191F RID: 6431 RVA: 0x0004A87C File Offset: 0x00048A7C
		public static ILowViewDistance Create([Nullable(2)] ILowViewDistance instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILowViewDistance
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001920 RID: 6432 RVA: 0x0004A88F File Offset: 0x00048A8F
		public static ILowViewDistance CreateFromSetValue([Nullable(2)] ILowViewDistance_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILowViewDistance
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001921 RID: 6433 RVA: 0x0004A8A2 File Offset: 0x00048AA2
		public new ILowViewDistance_SetValue ToSetValue()
		{
			return new ILowViewDistance_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06001922 RID: 6434 RVA: 0x0004A8B5 File Offset: 0x00048AB5
		// (set) Token: 0x06001923 RID: 6435 RVA: 0x0004A8E0 File Offset: 0x00048AE0
		public override EViewDistanceType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EViewDistanceType.Low;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400127D RID: 4733
		[Nullable(2)]
		protected new ILowViewDistance FbInstance;

		// Token: 0x0400127E RID: 4734
		[Nullable(2)]
		protected new ILowViewDistance_SetValue PocoInterface;
	}
}
