using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062C2 RID: 25282
	public class TProgressBarControlUnion
	{
		// Token: 0x1700BB98 RID: 48024
		// (get) Token: 0x0602AFA9 RID: 176041 RVA: 0x005DCC2A File Offset: 0x005DAE2A
		// (set) Token: 0x0602AFAA RID: 176042 RVA: 0x005DCC32 File Offset: 0x005DAE32
		public TProgressBarControl Type { get; set; }

		// Token: 0x1700BB99 RID: 48025
		// (get) Token: 0x0602AFAB RID: 176043 RVA: 0x005DCC3B File Offset: 0x005DAE3B
		// (set) Token: 0x0602AFAC RID: 176044 RVA: 0x005DCC43 File Offset: 0x005DAE43
		public object Value { get; set; }

		// Token: 0x0602AFAD RID: 176045 RVA: 0x005DCC4C File Offset: 0x005DAE4C
		public TProgressBarControlUnion()
		{
			this.Type = TProgressBarControl.NONE;
			this.Value = null;
		}

		// Token: 0x0602AFAE RID: 176046 RVA: 0x005DCC62 File Offset: 0x005DAE62
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AFAF RID: 176047 RVA: 0x005DCC74 File Offset: 0x005DAE74
		public ICaptureStrategicPointT AsICaptureStrategicPoint()
		{
			return this.As<ICaptureStrategicPointT>();
		}

		// Token: 0x0602AFB0 RID: 176048 RVA: 0x005DCC7C File Offset: 0x005DAE7C
		public static TProgressBarControlUnion FromICaptureStrategicPoint(ICaptureStrategicPointT _icapturestrategicpoint)
		{
			return new TProgressBarControlUnion
			{
				Type = TProgressBarControl.ICaptureStrategicPoint,
				Value = _icapturestrategicpoint
			};
		}

		// Token: 0x0602AFB1 RID: 176049 RVA: 0x005DCC91 File Offset: 0x005DAE91
		public ICaptureStrategicPoint2T AsICaptureStrategicPoint2()
		{
			return this.As<ICaptureStrategicPoint2T>();
		}

		// Token: 0x0602AFB2 RID: 176050 RVA: 0x005DCC99 File Offset: 0x005DAE99
		public static TProgressBarControlUnion FromICaptureStrategicPoint2(ICaptureStrategicPoint2T _icapturestrategicpoint2)
		{
			return new TProgressBarControlUnion
			{
				Type = TProgressBarControl.ICaptureStrategicPoint2,
				Value = _icapturestrategicpoint2
			};
		}

		// Token: 0x0602AFB3 RID: 176051 RVA: 0x005DCCAE File Offset: 0x005DAEAE
		public IChargingDeviceT AsIChargingDevice()
		{
			return this.As<IChargingDeviceT>();
		}

		// Token: 0x0602AFB4 RID: 176052 RVA: 0x005DCCB6 File Offset: 0x005DAEB6
		public static TProgressBarControlUnion FromIChargingDevice(IChargingDeviceT _ichargingdevice)
		{
			return new TProgressBarControlUnion
			{
				Type = TProgressBarControl.IChargingDevice,
				Value = _ichargingdevice
			};
		}

		// Token: 0x0602AFB5 RID: 176053 RVA: 0x005DCCCB File Offset: 0x005DAECB
		public IMatchTargetChargingDeviceT AsIMatchTargetChargingDevice()
		{
			return this.As<IMatchTargetChargingDeviceT>();
		}

		// Token: 0x0602AFB6 RID: 176054 RVA: 0x005DCCD3 File Offset: 0x005DAED3
		public static TProgressBarControlUnion FromIMatchTargetChargingDevice(IMatchTargetChargingDeviceT _imatchtargetchargingdevice)
		{
			return new TProgressBarControlUnion
			{
				Type = TProgressBarControl.IMatchTargetChargingDevice,
				Value = _imatchtargetchargingdevice
			};
		}

		// Token: 0x0602AFB7 RID: 176055 RVA: 0x005DCCE8 File Offset: 0x005DAEE8
		public ITimedStrikeDeviceT AsITimedStrikeDevice()
		{
			return this.As<ITimedStrikeDeviceT>();
		}

		// Token: 0x0602AFB8 RID: 176056 RVA: 0x005DCCF0 File Offset: 0x005DAEF0
		public static TProgressBarControlUnion FromITimedStrikeDevice(ITimedStrikeDeviceT _itimedstrikedevice)
		{
			return new TProgressBarControlUnion
			{
				Type = TProgressBarControl.ITimedStrikeDevice,
				Value = _itimedstrikedevice
			};
		}

		// Token: 0x0602AFB9 RID: 176057 RVA: 0x005DCD08 File Offset: 0x005DAF08
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
