using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02008043 RID: 32835
	public class TVehicleSetSpeedImmediatelyUnion
	{
		// Token: 0x1700F34F RID: 62287
		// (get) Token: 0x0603B121 RID: 241953 RVA: 0x007EDF56 File Offset: 0x007EC156
		// (set) Token: 0x0603B122 RID: 241954 RVA: 0x007EDF5E File Offset: 0x007EC15E
		public TVehicleSetSpeedImmediately Type { get; set; }

		// Token: 0x1700F350 RID: 62288
		// (get) Token: 0x0603B123 RID: 241955 RVA: 0x007EDF67 File Offset: 0x007EC167
		// (set) Token: 0x0603B124 RID: 241956 RVA: 0x007EDF6F File Offset: 0x007EC16F
		public object Value { get; set; }

		// Token: 0x0603B125 RID: 241957 RVA: 0x007EDF78 File Offset: 0x007EC178
		public TVehicleSetSpeedImmediatelyUnion()
		{
			this.Type = TVehicleSetSpeedImmediately.NONE;
			this.Value = null;
		}

		// Token: 0x0603B126 RID: 241958 RVA: 0x007EDF8E File Offset: 0x007EC18E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603B127 RID: 241959 RVA: 0x007EDFA0 File Offset: 0x007EC1A0
		public ISetHorizontalVerticalSpeedImmediatelyT AsISetHorizontalVerticalSpeedImmediately()
		{
			return this.As<ISetHorizontalVerticalSpeedImmediatelyT>();
		}

		// Token: 0x0603B128 RID: 241960 RVA: 0x007EDFA8 File Offset: 0x007EC1A8
		public static TVehicleSetSpeedImmediatelyUnion FromISetHorizontalVerticalSpeedImmediately(ISetHorizontalVerticalSpeedImmediatelyT _isethorizontalverticalspeedimmediately)
		{
			return new TVehicleSetSpeedImmediatelyUnion
			{
				Type = TVehicleSetSpeedImmediately.ISetHorizontalVerticalSpeedImmediately,
				Value = _isethorizontalverticalspeedimmediately
			};
		}

		// Token: 0x0603B129 RID: 241961 RVA: 0x007EDFBD File Offset: 0x007EC1BD
		public ISetTotalVehicleSpeedImmediatelyT AsISetTotalVehicleSpeedImmediately()
		{
			return this.As<ISetTotalVehicleSpeedImmediatelyT>();
		}

		// Token: 0x0603B12A RID: 241962 RVA: 0x007EDFC5 File Offset: 0x007EC1C5
		public static TVehicleSetSpeedImmediatelyUnion FromISetTotalVehicleSpeedImmediately(ISetTotalVehicleSpeedImmediatelyT _isettotalvehiclespeedimmediately)
		{
			return new TVehicleSetSpeedImmediatelyUnion
			{
				Type = TVehicleSetSpeedImmediately.ISetTotalVehicleSpeedImmediately,
				Value = _isettotalvehiclespeedimmediately
			};
		}

		// Token: 0x0603B12B RID: 241963 RVA: 0x007EDFDC File Offset: 0x007EC1DC
		public static int Pack(FlatBufferBuilder builder, TVehicleSetSpeedImmediatelyUnion _o)
		{
			TVehicleSetSpeedImmediately type = _o.Type;
			if (type == TVehicleSetSpeedImmediately.ISetHorizontalVerticalSpeedImmediately)
			{
				return ISetHorizontalVerticalSpeedImmediately.Pack(builder, _o.AsISetHorizontalVerticalSpeedImmediately()).Value;
			}
			if (type != TVehicleSetSpeedImmediately.ISetTotalVehicleSpeedImmediately)
			{
				return 0;
			}
			return ISetTotalVehicleSpeedImmediately.Pack(builder, _o.AsISetTotalVehicleSpeedImmediately()).Value;
		}
	}
}
