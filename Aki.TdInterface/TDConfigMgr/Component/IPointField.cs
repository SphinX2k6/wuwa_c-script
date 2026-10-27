using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200060C RID: 1548
	[NullableContext(1)]
	[Nullable(0)]
	public class IPointField : IConveyorBeltField
	{
		// Token: 0x0600210A RID: 8458 RVA: 0x0005BADC File Offset: 0x00059CDC
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

		// Token: 0x0600210B RID: 8459 RVA: 0x0005BB14 File Offset: 0x00059D14
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

		// Token: 0x0600210C RID: 8460 RVA: 0x0005BB27 File Offset: 0x00059D27
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

		// Token: 0x0600210D RID: 8461 RVA: 0x0005BB3A File Offset: 0x00059D3A
		public new IPointField_SetValue ToSetValue()
		{
			return new IPointField_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x0600210E RID: 8462 RVA: 0x0005BB4D File Offset: 0x00059D4D
		// (set) Token: 0x0600210F RID: 8463 RVA: 0x0005BB78 File Offset: 0x00059D78
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

		// Token: 0x0400171C RID: 5916
		[Nullable(2)]
		protected new IPointField FbInstance;

		// Token: 0x0400171D RID: 5917
		[Nullable(2)]
		protected new IPointField_SetValue PocoInterface;
	}
}
