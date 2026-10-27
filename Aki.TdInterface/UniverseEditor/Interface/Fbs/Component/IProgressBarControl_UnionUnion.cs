using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057A3 RID: 22435
	public class IProgressBarControl_UnionUnion
	{
		// Token: 0x1700A76A RID: 42858
		// (get) Token: 0x06025A2C RID: 154156 RVA: 0x005311F1 File Offset: 0x0052F3F1
		// (set) Token: 0x06025A2D RID: 154157 RVA: 0x005311F9 File Offset: 0x0052F3F9
		public IProgressBarControl_Union Type { get; set; }

		// Token: 0x1700A76B RID: 42859
		// (get) Token: 0x06025A2E RID: 154158 RVA: 0x00531202 File Offset: 0x0052F402
		// (set) Token: 0x06025A2F RID: 154159 RVA: 0x0053120A File Offset: 0x0052F40A
		public object Value { get; set; }

		// Token: 0x06025A30 RID: 154160 RVA: 0x00531213 File Offset: 0x0052F413
		public IProgressBarControl_UnionUnion()
		{
			this.Type = IProgressBarControl_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06025A31 RID: 154161 RVA: 0x00531229 File Offset: 0x0052F429
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06025A32 RID: 154162 RVA: 0x0053123B File Offset: 0x0052F43B
		public IProgressBarControlT AsIProgressBarControl()
		{
			return this.As<IProgressBarControlT>();
		}

		// Token: 0x06025A33 RID: 154163 RVA: 0x00531243 File Offset: 0x0052F443
		public static IProgressBarControl_UnionUnion FromIProgressBarControl(IProgressBarControlT _iprogressbarcontrol)
		{
			return new IProgressBarControl_UnionUnion
			{
				Type = IProgressBarControl_Union.IProgressBarControl,
				Value = _iprogressbarcontrol
			};
		}

		// Token: 0x06025A34 RID: 154164 RVA: 0x00531258 File Offset: 0x0052F458
		public ICaptureStrategicPointT AsICaptureStrategicPoint()
		{
			return this.As<ICaptureStrategicPointT>();
		}

		// Token: 0x06025A35 RID: 154165 RVA: 0x00531260 File Offset: 0x0052F460
		public static IProgressBarControl_UnionUnion FromICaptureStrategicPoint(ICaptureStrategicPointT _icapturestrategicpoint)
		{
			return new IProgressBarControl_UnionUnion
			{
				Type = IProgressBarControl_Union.ICaptureStrategicPoint,
				Value = _icapturestrategicpoint
			};
		}

		// Token: 0x06025A36 RID: 154166 RVA: 0x00531275 File Offset: 0x0052F475
		public ICaptureStrategicPoint2T AsICaptureStrategicPoint2()
		{
			return this.As<ICaptureStrategicPoint2T>();
		}

		// Token: 0x06025A37 RID: 154167 RVA: 0x0053127D File Offset: 0x0052F47D
		public static IProgressBarControl_UnionUnion FromICaptureStrategicPoint2(ICaptureStrategicPoint2T _icapturestrategicpoint2)
		{
			return new IProgressBarControl_UnionUnion
			{
				Type = IProgressBarControl_Union.ICaptureStrategicPoint2,
				Value = _icapturestrategicpoint2
			};
		}

		// Token: 0x06025A38 RID: 154168 RVA: 0x00531292 File Offset: 0x0052F492
		public IChargingDeviceT AsIChargingDevice()
		{
			return this.As<IChargingDeviceT>();
		}

		// Token: 0x06025A39 RID: 154169 RVA: 0x0053129A File Offset: 0x0052F49A
		public static IProgressBarControl_UnionUnion FromIChargingDevice(IChargingDeviceT _ichargingdevice)
		{
			return new IProgressBarControl_UnionUnion
			{
				Type = IProgressBarControl_Union.IChargingDevice,
				Value = _ichargingdevice
			};
		}

		// Token: 0x06025A3A RID: 154170 RVA: 0x005312AF File Offset: 0x0052F4AF
		public ITimedStrikeDeviceT AsITimedStrikeDevice()
		{
			return this.As<ITimedStrikeDeviceT>();
		}

		// Token: 0x06025A3B RID: 154171 RVA: 0x005312B7 File Offset: 0x0052F4B7
		public static IProgressBarControl_UnionUnion FromITimedStrikeDevice(ITimedStrikeDeviceT _itimedstrikedevice)
		{
			return new IProgressBarControl_UnionUnion
			{
				Type = IProgressBarControl_Union.ITimedStrikeDevice,
				Value = _itimedstrikedevice
			};
		}

		// Token: 0x06025A3C RID: 154172 RVA: 0x005312CC File Offset: 0x0052F4CC
		public IMatchTargetChargingDeviceT AsIMatchTargetChargingDevice()
		{
			return this.As<IMatchTargetChargingDeviceT>();
		}

		// Token: 0x06025A3D RID: 154173 RVA: 0x005312D4 File Offset: 0x0052F4D4
		public static IProgressBarControl_UnionUnion FromIMatchTargetChargingDevice(IMatchTargetChargingDeviceT _imatchtargetchargingdevice)
		{
			return new IProgressBarControl_UnionUnion
			{
				Type = IProgressBarControl_Union.IMatchTargetChargingDevice,
				Value = _imatchtargetchargingdevice
			};
		}

		// Token: 0x06025A3E RID: 154174 RVA: 0x005312EC File Offset: 0x0052F4EC
		public static int Pack(FlatBufferBuilder builder, IProgressBarControl_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IProgressBarControl_Union.IProgressBarControl:
				return IProgressBarControl.Pack(builder, _o.AsIProgressBarControl()).Value;
			case IProgressBarControl_Union.ICaptureStrategicPoint:
				return ICaptureStrategicPoint.Pack(builder, _o.AsICaptureStrategicPoint()).Value;
			case IProgressBarControl_Union.ICaptureStrategicPoint2:
				return ICaptureStrategicPoint2.Pack(builder, _o.AsICaptureStrategicPoint2()).Value;
			case IProgressBarControl_Union.IChargingDevice:
				return IChargingDevice.Pack(builder, _o.AsIChargingDevice()).Value;
			case IProgressBarControl_Union.ITimedStrikeDevice:
				return ITimedStrikeDevice.Pack(builder, _o.AsITimedStrikeDevice()).Value;
			case IProgressBarControl_Union.IMatchTargetChargingDevice:
				return IMatchTargetChargingDevice.Pack(builder, _o.AsIMatchTargetChargingDevice()).Value;
			default:
				return 0;
			}
		}
	}
}
