using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A6F RID: 6767
	public class ICloseRacingTrackMove : ICloseSplineMovePattern
	{
		// Token: 0x06008FC9 RID: 36809 RVA: 0x00152928 File Offset: 0x00150B28
		private ICloseRacingTrackMove_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICloseRacingTrackMove 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICloseRacingTrackMove_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICloseRacingTrackMove_SetValue());
			}
			return result;
		}

		// Token: 0x06008FCA RID: 36810 RVA: 0x00152960 File Offset: 0x00150B60
		public static ICloseRacingTrackMove Create([Nullable(2)] ICloseRacingTrackMove instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICloseRacingTrackMove
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008FCB RID: 36811 RVA: 0x00152973 File Offset: 0x00150B73
		public static ICloseRacingTrackMove CreateFromSetValue([Nullable(2)] ICloseRacingTrackMove_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICloseRacingTrackMove
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008FCC RID: 36812 RVA: 0x00152986 File Offset: 0x00150B86
		public new ICloseRacingTrackMove_SetValue ToSetValue()
		{
			return new ICloseRacingTrackMove_SetValue
			{
				Type = this.Type,
				GravitySwitchAngularVelocity = this.GravitySwitchAngularVelocity
			};
		}

		// Token: 0x17002E4A RID: 11850
		// (get) Token: 0x06008FCD RID: 36813 RVA: 0x001529A5 File Offset: 0x00150BA5
		// (set) Token: 0x06008FCE RID: 36814 RVA: 0x001529D0 File Offset: 0x00150BD0
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

		// Token: 0x17002E4B RID: 11851
		// (get) Token: 0x06008FCF RID: 36815 RVA: 0x001529E0 File Offset: 0x00150BE0
		// (set) Token: 0x06008FD0 RID: 36816 RVA: 0x00152A1A File Offset: 0x00150C1A
		public override float? GravitySwitchAngularVelocity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GravitySwitchAngularVelocity;
				}
				ICloseRacingTrackMove_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04005A0F RID: 23055
		[Nullable(2)]
		protected new ICloseRacingTrackMove FbInstance;

		// Token: 0x04005A10 RID: 23056
		[Nullable(2)]
		protected new ICloseRacingTrackMove_SetValue PocoInterface;
	}
}
