using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02008040 RID: 32832
	public class TVehicleEnteringTargetUnion
	{
		// Token: 0x1700F34D RID: 62285
		// (get) Token: 0x0603B115 RID: 241941 RVA: 0x007EDE5A File Offset: 0x007EC05A
		// (set) Token: 0x0603B116 RID: 241942 RVA: 0x007EDE62 File Offset: 0x007EC062
		public TVehicleEnteringTarget Type { get; set; }

		// Token: 0x1700F34E RID: 62286
		// (get) Token: 0x0603B117 RID: 241943 RVA: 0x007EDE6B File Offset: 0x007EC06B
		// (set) Token: 0x0603B118 RID: 241944 RVA: 0x007EDE73 File Offset: 0x007EC073
		public object Value { get; set; }

		// Token: 0x0603B119 RID: 241945 RVA: 0x007EDE7C File Offset: 0x007EC07C
		public TVehicleEnteringTargetUnion()
		{
			this.Type = TVehicleEnteringTarget.NONE;
			this.Value = null;
		}

		// Token: 0x0603B11A RID: 241946 RVA: 0x007EDE92 File Offset: 0x007EC092
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603B11B RID: 241947 RVA: 0x007EDEA4 File Offset: 0x007EC0A4
		public IVehicleEnteringNpcTargetT AsIVehicleEnteringNpcTarget()
		{
			return this.As<IVehicleEnteringNpcTargetT>();
		}

		// Token: 0x0603B11C RID: 241948 RVA: 0x007EDEAC File Offset: 0x007EC0AC
		public static TVehicleEnteringTargetUnion FromIVehicleEnteringNpcTarget(IVehicleEnteringNpcTargetT _ivehicleenteringnpctarget)
		{
			return new TVehicleEnteringTargetUnion
			{
				Type = TVehicleEnteringTarget.IVehicleEnteringNpcTarget,
				Value = _ivehicleenteringnpctarget
			};
		}

		// Token: 0x0603B11D RID: 241949 RVA: 0x007EDEC1 File Offset: 0x007EC0C1
		public IVehicleEnteringPlayerTargetT AsIVehicleEnteringPlayerTarget()
		{
			return this.As<IVehicleEnteringPlayerTargetT>();
		}

		// Token: 0x0603B11E RID: 241950 RVA: 0x007EDEC9 File Offset: 0x007EC0C9
		public static TVehicleEnteringTargetUnion FromIVehicleEnteringPlayerTarget(IVehicleEnteringPlayerTargetT _ivehicleenteringplayertarget)
		{
			return new TVehicleEnteringTargetUnion
			{
				Type = TVehicleEnteringTarget.IVehicleEnteringPlayerTarget,
				Value = _ivehicleenteringplayertarget
			};
		}

		// Token: 0x0603B11F RID: 241951 RVA: 0x007EDEE0 File Offset: 0x007EC0E0
		public static int Pack(FlatBufferBuilder builder, TVehicleEnteringTargetUnion _o)
		{
			TVehicleEnteringTarget type = _o.Type;
			if (type == TVehicleEnteringTarget.IVehicleEnteringNpcTarget)
			{
				return IVehicleEnteringNpcTarget.Pack(builder, _o.AsIVehicleEnteringNpcTarget()).Value;
			}
			if (type != TVehicleEnteringTarget.IVehicleEnteringPlayerTarget)
			{
				return 0;
			}
			return IVehicleEnteringPlayerTarget.Pack(builder, _o.AsIVehicleEnteringPlayerTarget()).Value;
		}
	}
}
