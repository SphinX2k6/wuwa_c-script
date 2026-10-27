using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018D4 RID: 6356
	[NullableContext(1)]
	[Nullable(0)]
	public class ICloseAirPassageMove : ICloseSplineMovePattern
	{
		// Token: 0x06008851 RID: 34897 RVA: 0x001428B4 File Offset: 0x00140AB4
		private ICloseAirPassageMove_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICloseAirPassageMove 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICloseAirPassageMove_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICloseAirPassageMove_SetValue());
			}
			return result;
		}

		// Token: 0x06008852 RID: 34898 RVA: 0x001428EC File Offset: 0x00140AEC
		public static ICloseAirPassageMove Create([Nullable(2)] ICloseAirPassageMove instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICloseAirPassageMove
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008853 RID: 34899 RVA: 0x001428FF File Offset: 0x00140AFF
		public static ICloseAirPassageMove CreateFromSetValue([Nullable(2)] ICloseAirPassageMove_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICloseAirPassageMove
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008854 RID: 34900 RVA: 0x00142912 File Offset: 0x00140B12
		public new ICloseAirPassageMove_SetValue ToSetValue()
		{
			return new ICloseAirPassageMove_SetValue
			{
				Type = this.Type,
				GravitySwitchAngularVelocity = this.GravitySwitchAngularVelocity
			};
		}

		// Token: 0x17002C3F RID: 11327
		// (get) Token: 0x06008855 RID: 34901 RVA: 0x00142931 File Offset: 0x00140B31
		// (set) Token: 0x06008856 RID: 34902 RVA: 0x0014295C File Offset: 0x00140B5C
		public override ESplineMovePattern Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESplineMovePattern.PathLine;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002C40 RID: 11328
		// (get) Token: 0x06008857 RID: 34903 RVA: 0x0014296C File Offset: 0x00140B6C
		// (set) Token: 0x06008858 RID: 34904 RVA: 0x001429A6 File Offset: 0x00140BA6
		public override float? GravitySwitchAngularVelocity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GravitySwitchAngularVelocity;
				}
				ICloseAirPassageMove_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.GravitySwitchAngularVelocity;
			}
			set
			{
				this.GetOrCreatePoco().GravitySwitchAngularVelocity = value;
			}
		}

		// Token: 0x040055A2 RID: 21922
		[Nullable(2)]
		protected new ICloseAirPassageMove FbInstance;

		// Token: 0x040055A3 RID: 21923
		[Nullable(2)]
		protected new ICloseAirPassageMove_SetValue PocoInterface;
	}
}
