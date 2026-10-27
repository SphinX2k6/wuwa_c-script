using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018D6 RID: 6358
	[NullableContext(1)]
	[Nullable(0)]
	public class ICloseAirWall : IToggleAirWallType
	{
		// Token: 0x0600885B RID: 34907 RVA: 0x001429C4 File Offset: 0x00140BC4
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

		// Token: 0x0600885C RID: 34908 RVA: 0x001429FC File Offset: 0x00140BFC
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

		// Token: 0x0600885D RID: 34909 RVA: 0x00142A0F File Offset: 0x00140C0F
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

		// Token: 0x0600885E RID: 34910 RVA: 0x00142A22 File Offset: 0x00140C22
		public new ICloseAirWall_SetValue ToSetValue()
		{
			return new ICloseAirWall_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002C41 RID: 11329
		// (get) Token: 0x0600885F RID: 34911 RVA: 0x00142A35 File Offset: 0x00140C35
		// (set) Token: 0x06008860 RID: 34912 RVA: 0x00142A60 File Offset: 0x00140C60
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

		// Token: 0x040055A6 RID: 21926
		[Nullable(2)]
		protected new ICloseAirWall FbInstance;

		// Token: 0x040055A7 RID: 21927
		[Nullable(2)]
		protected new ICloseAirWall_SetValue PocoInterface;
	}
}
