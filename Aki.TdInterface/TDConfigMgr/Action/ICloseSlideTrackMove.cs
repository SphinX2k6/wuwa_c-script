using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018E8 RID: 6376
	[NullableContext(1)]
	[Nullable(0)]
	public class ICloseSlideTrackMove : ICloseSplineMovePattern
	{
		// Token: 0x060088AF RID: 34991 RVA: 0x00143234 File Offset: 0x00141434
		private ICloseSlideTrackMove_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICloseSlideTrackMove 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICloseSlideTrackMove_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICloseSlideTrackMove_SetValue());
			}
			return result;
		}

		// Token: 0x060088B0 RID: 34992 RVA: 0x0014326C File Offset: 0x0014146C
		public static ICloseSlideTrackMove Create([Nullable(2)] ICloseSlideTrackMove instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICloseSlideTrackMove
			{
				FbInstance = instance
			};
		}

		// Token: 0x060088B1 RID: 34993 RVA: 0x0014327F File Offset: 0x0014147F
		public static ICloseSlideTrackMove CreateFromSetValue([Nullable(2)] ICloseSlideTrackMove_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICloseSlideTrackMove
			{
				PocoInterface = value
			};
		}

		// Token: 0x060088B2 RID: 34994 RVA: 0x00143292 File Offset: 0x00141492
		public new ICloseSlideTrackMove_SetValue ToSetValue()
		{
			return new ICloseSlideTrackMove_SetValue
			{
				Type = this.Type,
				GravitySwitchAngularVelocity = this.GravitySwitchAngularVelocity
			};
		}

		// Token: 0x17002C50 RID: 11344
		// (get) Token: 0x060088B3 RID: 34995 RVA: 0x001432B1 File Offset: 0x001414B1
		// (set) Token: 0x060088B4 RID: 34996 RVA: 0x001432DC File Offset: 0x001414DC
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

		// Token: 0x17002C51 RID: 11345
		// (get) Token: 0x060088B5 RID: 34997 RVA: 0x001432EC File Offset: 0x001414EC
		// (set) Token: 0x060088B6 RID: 34998 RVA: 0x00143326 File Offset: 0x00141526
		public override float? GravitySwitchAngularVelocity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GravitySwitchAngularVelocity;
				}
				ICloseSlideTrackMove_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x040055C7 RID: 21959
		[Nullable(2)]
		protected new ICloseSlideTrackMove FbInstance;

		// Token: 0x040055C8 RID: 21960
		[Nullable(2)]
		protected new ICloseSlideTrackMove_SetValue PocoInterface;
	}
}
