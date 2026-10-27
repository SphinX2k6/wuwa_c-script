using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C91 RID: 23697
	public class TProgressBarControlUnion
	{
		// Token: 0x1700B23E RID: 45630
		// (get) Token: 0x06028963 RID: 166243 RVA: 0x005944F2 File Offset: 0x005926F2
		// (set) Token: 0x06028964 RID: 166244 RVA: 0x005944FA File Offset: 0x005926FA
		public TProgressBarControl Type { get; set; }

		// Token: 0x1700B23F RID: 45631
		// (get) Token: 0x06028965 RID: 166245 RVA: 0x00594503 File Offset: 0x00592703
		// (set) Token: 0x06028966 RID: 166246 RVA: 0x0059450B File Offset: 0x0059270B
		public object Value { get; set; }

		// Token: 0x06028967 RID: 166247 RVA: 0x00594514 File Offset: 0x00592714
		public TProgressBarControlUnion()
		{
			this.Type = TProgressBarControl.NONE;
			this.Value = null;
		}

		// Token: 0x06028968 RID: 166248 RVA: 0x0059452A File Offset: 0x0059272A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028969 RID: 166249 RVA: 0x0059453C File Offset: 0x0059273C
		public ICaptureStrategicPointT AsICaptureStrategicPoint()
		{
			return this.As<ICaptureStrategicPointT>();
		}

		// Token: 0x0602896A RID: 166250 RVA: 0x00594544 File Offset: 0x00592744
		public static TProgressBarControlUnion FromICaptureStrategicPoint(ICaptureStrategicPointT _icapturestrategicpoint)
		{
			return new TProgressBarControlUnion
			{
				Type = TProgressBarControl.ICaptureStrategicPoint,
				Value = _icapturestrategicpoint
			};
		}

		// Token: 0x0602896B RID: 166251 RVA: 0x00594559 File Offset: 0x00592759
		public ICaptureStrategicPoint2T AsICaptureStrategicPoint2()
		{
			return this.As<ICaptureStrategicPoint2T>();
		}

		// Token: 0x0602896C RID: 166252 RVA: 0x00594561 File Offset: 0x00592761
		public static TProgressBarControlUnion FromICaptureStrategicPoint2(ICaptureStrategicPoint2T _icapturestrategicpoint2)
		{
			return new TProgressBarControlUnion
			{
				Type = TProgressBarControl.ICaptureStrategicPoint2,
				Value = _icapturestrategicpoint2
			};
		}

		// Token: 0x0602896D RID: 166253 RVA: 0x00594576 File Offset: 0x00592776
		public IChargingDeviceT AsIChargingDevice()
		{
			return this.As<IChargingDeviceT>();
		}

		// Token: 0x0602896E RID: 166254 RVA: 0x0059457E File Offset: 0x0059277E
		public static TProgressBarControlUnion FromIChargingDevice(IChargingDeviceT _ichargingdevice)
		{
			return new TProgressBarControlUnion
			{
				Type = TProgressBarControl.IChargingDevice,
				Value = _ichargingdevice
			};
		}

		// Token: 0x0602896F RID: 166255 RVA: 0x00594593 File Offset: 0x00592793
		public IMatchTargetChargingDeviceT AsIMatchTargetChargingDevice()
		{
			return this.As<IMatchTargetChargingDeviceT>();
		}

		// Token: 0x06028970 RID: 166256 RVA: 0x0059459B File Offset: 0x0059279B
		public static TProgressBarControlUnion FromIMatchTargetChargingDevice(IMatchTargetChargingDeviceT _imatchtargetchargingdevice)
		{
			return new TProgressBarControlUnion
			{
				Type = TProgressBarControl.IMatchTargetChargingDevice,
				Value = _imatchtargetchargingdevice
			};
		}

		// Token: 0x06028971 RID: 166257 RVA: 0x005945B0 File Offset: 0x005927B0
		public ITimedStrikeDeviceT AsITimedStrikeDevice()
		{
			return this.As<ITimedStrikeDeviceT>();
		}

		// Token: 0x06028972 RID: 166258 RVA: 0x005945B8 File Offset: 0x005927B8
		public static TProgressBarControlUnion FromITimedStrikeDevice(ITimedStrikeDeviceT _itimedstrikedevice)
		{
			return new TProgressBarControlUnion
			{
				Type = TProgressBarControl.ITimedStrikeDevice,
				Value = _itimedstrikedevice
			};
		}

		// Token: 0x06028973 RID: 166259 RVA: 0x005945D0 File Offset: 0x005927D0
		public static int Pack(FlatBufferBuilder builder, TProgressBarControlUnion _o)
		{
			switch (_o.Type)
			{
			case TProgressBarControl.ICaptureStrategicPoint:
				return ICaptureStrategicPoint.Pack(builder, _o.AsICaptureStrategicPoint()).Value;
			case TProgressBarControl.ICaptureStrategicPoint2:
				return ICaptureStrategicPoint2.Pack(builder, _o.AsICaptureStrategicPoint2()).Value;
			case TProgressBarControl.IChargingDevice:
				return IChargingDevice.Pack(builder, _o.AsIChargingDevice()).Value;
			case TProgressBarControl.IMatchTargetChargingDevice:
				return IMatchTargetChargingDevice.Pack(builder, _o.AsIMatchTargetChargingDevice()).Value;
			case TProgressBarControl.ITimedStrikeDevice:
				return ITimedStrikeDevice.Pack(builder, _o.AsITimedStrikeDevice()).Value;
			default:
				return 0;
			}
		}
	}
}
