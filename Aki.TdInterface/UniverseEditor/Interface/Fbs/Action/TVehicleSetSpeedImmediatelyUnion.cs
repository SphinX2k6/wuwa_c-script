using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007805 RID: 30725
	public class TVehicleSetSpeedImmediatelyUnion
	{
		// Token: 0x1700E6F1 RID: 59121
		// (get) Token: 0x06037B7C RID: 228220 RVA: 0x007885DE File Offset: 0x007867DE
		// (set) Token: 0x06037B7D RID: 228221 RVA: 0x007885E6 File Offset: 0x007867E6
		public TVehicleSetSpeedImmediately Type { get; set; }

		// Token: 0x1700E6F2 RID: 59122
		// (get) Token: 0x06037B7E RID: 228222 RVA: 0x007885EF File Offset: 0x007867EF
		// (set) Token: 0x06037B7F RID: 228223 RVA: 0x007885F7 File Offset: 0x007867F7
		public object Value { get; set; }

		// Token: 0x06037B80 RID: 228224 RVA: 0x00788600 File Offset: 0x00786800
		public TVehicleSetSpeedImmediatelyUnion()
		{
			this.Type = TVehicleSetSpeedImmediately.NONE;
			this.Value = null;
		}

		// Token: 0x06037B81 RID: 228225 RVA: 0x00788616 File Offset: 0x00786816
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037B82 RID: 228226 RVA: 0x00788628 File Offset: 0x00786828
		public ISetHorizontalVerticalSpeedImmediatelyT AsISetHorizontalVerticalSpeedImmediately()
		{
			return this.As<ISetHorizontalVerticalSpeedImmediatelyT>();
		}

		// Token: 0x06037B83 RID: 228227 RVA: 0x00788630 File Offset: 0x00786830
		public static TVehicleSetSpeedImmediatelyUnion FromISetHorizontalVerticalSpeedImmediately(ISetHorizontalVerticalSpeedImmediatelyT _isethorizontalverticalspeedimmediately)
		{
			return new TVehicleSetSpeedImmediatelyUnion
			{
				Type = TVehicleSetSpeedImmediately.ISetHorizontalVerticalSpeedImmediately,
				Value = _isethorizontalverticalspeedimmediately
			};
		}

		// Token: 0x06037B84 RID: 228228 RVA: 0x00788645 File Offset: 0x00786845
		public ISetTotalVehicleSpeedImmediatelyT AsISetTotalVehicleSpeedImmediately()
		{
			return this.As<ISetTotalVehicleSpeedImmediatelyT>();
		}

		// Token: 0x06037B85 RID: 228229 RVA: 0x0078864D File Offset: 0x0078684D
		public static TVehicleSetSpeedImmediatelyUnion FromISetTotalVehicleSpeedImmediately(ISetTotalVehicleSpeedImmediatelyT _isettotalvehiclespeedimmediately)
		{
			return new TVehicleSetSpeedImmediatelyUnion
			{
				Type = TVehicleSetSpeedImmediately.ISetTotalVehicleSpeedImmediately,
				Value = _isettotalvehiclespeedimmediately
			};
		}

		// Token: 0x06037B86 RID: 228230 RVA: 0x00788664 File Offset: 0x00786864
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
