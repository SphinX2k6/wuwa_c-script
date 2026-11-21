using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A67 RID: 6759
	public class ICloseAirWall : IToggleAirWallType
	{
		// Token: 0x06008FA3 RID: 36771 RVA: 0x0015253C File Offset: 0x0015073C
		private ICloseAirWall_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICloseAirWall 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICloseAirWall_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICloseAirWall_SetValue());
			}
			return result;
		}

		// Token: 0x06008FA4 RID: 36772 RVA: 0x00152574 File Offset: 0x00150774
		public static ICloseAirWall Create([Nullable(2)] ICloseAirWall instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICloseAirWall
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008FA5 RID: 36773 RVA: 0x00152587 File Offset: 0x00150787
		public static ICloseAirWall CreateFromSetValue([Nullable(2)] ICloseAirWall_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICloseAirWall
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008FA6 RID: 36774 RVA: 0x0015259A File Offset: 0x0015079A
		public new ICloseAirWall_SetValue ToSetValue()
		{
			return new ICloseAirWall_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002E43 RID: 11843
		// (get) Token: 0x06008FA7 RID: 36775 RVA: 0x001525AD File Offset: 0x001507AD
		// (set) Token: 0x06008FA8 RID: 36776 RVA: 0x001525D8 File Offset: 0x001507D8
		public override EToggleAirWall Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EToggleAirWall.Open;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005A00 RID: 23040
		[Nullable(2)]
		protected new ICloseAirWall FbInstance;

		// Token: 0x04005A01 RID: 23041
		[Nullable(2)]
		protected new ICloseAirWall_SetValue PocoInterface;
	}
}
