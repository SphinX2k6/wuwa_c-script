using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006A9 RID: 1705
	public class IPointField : IConveyorBeltField
	{
		// Token: 0x06002410 RID: 9232 RVA: 0x000627F0 File Offset: 0x000609F0
		private IPointField_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPointField 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPointField_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPointField_SetValue());
			}
			return result;
		}

		// Token: 0x06002411 RID: 9233 RVA: 0x00062828 File Offset: 0x00060A28
		public static IPointField Create([Nullable(2)] IPointField instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPointField
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002412 RID: 9234 RVA: 0x0006283B File Offset: 0x00060A3B
		public static IPointField CreateFromSetValue([Nullable(2)] IPointField_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPointField
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002413 RID: 9235 RVA: 0x0006284E File Offset: 0x00060A4E
		public new IPointField_SetValue ToSetValue()
		{
			return new IPointField_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x06002414 RID: 9236 RVA: 0x00062861 File Offset: 0x00060A61
		// (set) Token: 0x06002415 RID: 9237 RVA: 0x0006288C File Offset: 0x00060A8C
		public override EConveyorBeltFieldType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EConveyorBeltFieldType.DirectionalField;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400190E RID: 6414
		[Nullable(2)]
		protected new IPointField FbInstance;

		// Token: 0x0400190F RID: 6415
		[Nullable(2)]
		protected new IPointField_SetValue PocoInterface;
	}
}
