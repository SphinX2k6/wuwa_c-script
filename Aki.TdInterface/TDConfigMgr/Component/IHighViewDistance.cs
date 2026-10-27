using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200040A RID: 1034
	[NullableContext(1)]
	[Nullable(0)]
	public class IHighViewDistance : IViewDistanceMode
	{
		// Token: 0x060014E3 RID: 5347 RVA: 0x000422D8 File Offset: 0x000404D8
		private IHighViewDistance_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHighViewDistance 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHighViewDistance_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHighViewDistance_SetValue());
			}
			return result;
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x00042310 File Offset: 0x00040510
		public static IHighViewDistance Create([Nullable(2)] IHighViewDistance instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHighViewDistance
			{
				FbInstance = instance
			};
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x00042323 File Offset: 0x00040523
		public static IHighViewDistance CreateFromSetValue([Nullable(2)] IHighViewDistance_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHighViewDistance
			{
				PocoInterface = value
			};
		}

		// Token: 0x060014E6 RID: 5350 RVA: 0x00042336 File Offset: 0x00040536
		public new IHighViewDistance_SetValue ToSetValue()
		{
			return new IHighViewDistance_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x060014E7 RID: 5351 RVA: 0x00042349 File Offset: 0x00040549
		// (set) Token: 0x060014E8 RID: 5352 RVA: 0x00042374 File Offset: 0x00040574
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

		// Token: 0x0400104F RID: 4175
		[Nullable(2)]
		protected new IHighViewDistance FbInstance;

		// Token: 0x04001050 RID: 4176
		[Nullable(2)]
		protected new IHighViewDistance_SetValue PocoInterface;
	}
}
