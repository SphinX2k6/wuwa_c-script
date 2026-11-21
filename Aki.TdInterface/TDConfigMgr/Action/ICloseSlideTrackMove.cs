using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A73 RID: 6771
	public class ICloseSlideTrackMove : ICloseSplineMovePattern
	{
		// Token: 0x06008FDD RID: 36829 RVA: 0x00152B34 File Offset: 0x00150D34
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

		// Token: 0x06008FDE RID: 36830 RVA: 0x00152B6C File Offset: 0x00150D6C
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

		// Token: 0x06008FDF RID: 36831 RVA: 0x00152B7F File Offset: 0x00150D7F
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

		// Token: 0x06008FE0 RID: 36832 RVA: 0x00152B92 File Offset: 0x00150D92
		public new ICloseSlideTrackMove_SetValue ToSetValue()
		{
			return new ICloseSlideTrackMove_SetValue
			{
				Type = this.Type,
				GravitySwitchAngularVelocity = this.GravitySwitchAngularVelocity
			};
		}

		// Token: 0x17002E4E RID: 11854
		// (get) Token: 0x06008FE1 RID: 36833 RVA: 0x00152BB1 File Offset: 0x00150DB1
		// (set) Token: 0x06008FE2 RID: 36834 RVA: 0x00152BDC File Offset: 0x00150DDC
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

		// Token: 0x17002E4F RID: 11855
		// (get) Token: 0x06008FE3 RID: 36835 RVA: 0x00152BEC File Offset: 0x00150DEC
		// (set) Token: 0x06008FE4 RID: 36836 RVA: 0x00152C26 File Offset: 0x00150E26
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

		// Token: 0x04005A17 RID: 23063
		[Nullable(2)]
		protected new ICloseSlideTrackMove FbInstance;

		// Token: 0x04005A18 RID: 23064
		[Nullable(2)]
		protected new ICloseSlideTrackMove_SetValue PocoInterface;
	}
}
