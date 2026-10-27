using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018E4 RID: 6372
	[NullableContext(1)]
	[Nullable(0)]
	public class ICloseRideFlyingCar : ICloseUiGame
	{
		// Token: 0x0600889D RID: 34973 RVA: 0x0014307C File Offset: 0x0014127C
		private ICloseRideFlyingCar_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICloseRideFlyingCar 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICloseRideFlyingCar_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICloseRideFlyingCar_SetValue());
			}
			return result;
		}

		// Token: 0x0600889E RID: 34974 RVA: 0x001430B4 File Offset: 0x001412B4
		public static ICloseRideFlyingCar Create([Nullable(2)] ICloseRideFlyingCar instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICloseRideFlyingCar
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600889F RID: 34975 RVA: 0x001430C7 File Offset: 0x001412C7
		public static ICloseRideFlyingCar CreateFromSetValue([Nullable(2)] ICloseRideFlyingCar_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICloseRideFlyingCar
			{
				PocoInterface = value
			};
		}

		// Token: 0x060088A0 RID: 34976 RVA: 0x001430DA File Offset: 0x001412DA
		public new ICloseRideFlyingCar_SetValue ToSetValue()
		{
			return new ICloseRideFlyingCar_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002C4D RID: 11341
		// (get) Token: 0x060088A1 RID: 34977 RVA: 0x001430ED File Offset: 0x001412ED
		// (set) Token: 0x060088A2 RID: 34978 RVA: 0x00143118 File Offset: 0x00141318
		public override ESimpleGameplayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESimpleGameplayType.Cipher;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040055C0 RID: 21952
		[Nullable(2)]
		protected new ICloseRideFlyingCar FbInstance;

		// Token: 0x040055C1 RID: 21953
		[Nullable(2)]
		protected new ICloseRideFlyingCar_SetValue PocoInterface;
	}
}
