using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DAA RID: 23978
	public class IProgressBarControl_UnionUnion
	{
		// Token: 0x1700B08E RID: 45198
		// (get) Token: 0x06027F4C RID: 163660 RVA: 0x0057737D File Offset: 0x0057557D
		// (set) Token: 0x06027F4D RID: 163661 RVA: 0x00577385 File Offset: 0x00575585
		public IProgressBarControl_Union Type { get; set; }

		// Token: 0x1700B08F RID: 45199
		// (get) Token: 0x06027F4E RID: 163662 RVA: 0x0057738E File Offset: 0x0057558E
		// (set) Token: 0x06027F4F RID: 163663 RVA: 0x00577396 File Offset: 0x00575596
		public object Value { get; set; }

		// Token: 0x06027F50 RID: 163664 RVA: 0x0057739F File Offset: 0x0057559F
		public IProgressBarControl_UnionUnion()
		{
			this.Type = IProgressBarControl_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06027F51 RID: 163665 RVA: 0x005773B5 File Offset: 0x005755B5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06027F52 RID: 163666 RVA: 0x005773C7 File Offset: 0x005755C7
		public IProgressBarControlT AsIProgressBarControl()
		{
			return this.As<IProgressBarControlT>();
		}

		// Token: 0x06027F53 RID: 163667 RVA: 0x005773CF File Offset: 0x005755CF
		public static IProgressBarControl_UnionUnion FromIProgressBarControl(IProgressBarControlT _iprogressbarcontrol)
		{
			return new IProgressBarControl_UnionUnion
			{
				Type = IProgressBarControl_Union.IProgressBarControl,
				Value = _iprogressbarcontrol
			};
		}

		// Token: 0x06027F54 RID: 163668 RVA: 0x005773E4 File Offset: 0x005755E4
		public ICaptureStrategicPointT AsICaptureStrategicPoint()
		{
			return this.As<ICaptureStrategicPointT>();
		}

		// Token: 0x06027F55 RID: 163669 RVA: 0x005773EC File Offset: 0x005755EC
		public static IProgressBarControl_UnionUnion FromICaptureStrategicPoint(ICaptureStrategicPointT _icapturestrategicpoint)
		{
			return new IProgressBarControl_UnionUnion
			{
				Type = IProgressBarControl_Union.ICaptureStrategicPoint,
				Value = _icapturestrategicpoint
			};
		}

		// Token: 0x06027F56 RID: 163670 RVA: 0x00577401 File Offset: 0x00575601
		public ICaptureStrategicPoint2T AsICaptureStrategicPoint2()
		{
			return this.As<ICaptureStrategicPoint2T>();
		}

		// Token: 0x06027F57 RID: 163671 RVA: 0x00577409 File Offset: 0x00575609
		public static IProgressBarControl_UnionUnion FromICaptureStrategicPoint2(ICaptureStrategicPoint2T _icapturestrategicpoint2)
		{
			return new IProgressBarControl_UnionUnion
			{
				Type = IProgressBarControl_Union.ICaptureStrategicPoint2,
				Value = _icapturestrategicpoint2
			};
		}

		// Token: 0x06027F58 RID: 163672 RVA: 0x0057741E File Offset: 0x0057561E
		public IChargingDeviceT AsIChargingDevice()
		{
			return this.As<IChargingDeviceT>();
		}

		// Token: 0x06027F59 RID: 163673 RVA: 0x00577426 File Offset: 0x00575626
		public static IProgressBarControl_UnionUnion FromIChargingDevice(IChargingDeviceT _ichargingdevice)
		{
			return new IProgressBarControl_UnionUnion
			{
				Type = IProgressBarControl_Union.IChargingDevice,
				Value = _ichargingdevice
			};
		}

		// Token: 0x06027F5A RID: 163674 RVA: 0x0057743B File Offset: 0x0057563B
		public ITimedStrikeDeviceT AsITimedStrikeDevice()
		{
			return this.As<ITimedStrikeDeviceT>();
		}

		// Token: 0x06027F5B RID: 163675 RVA: 0x00577443 File Offset: 0x00575643
		public static IProgressBarControl_UnionUnion FromITimedStrikeDevice(ITimedStrikeDeviceT _itimedstrikedevice)
		{
			return new IProgressBarControl_UnionUnion
			{
				Type = IProgressBarControl_Union.ITimedStrikeDevice,
				Value = _itimedstrikedevice
			};
		}

		// Token: 0x06027F5C RID: 163676 RVA: 0x00577458 File Offset: 0x00575658
		public IMatchTargetChargingDeviceT AsIMatchTargetChargingDevice()
		{
			return this.As<IMatchTargetChargingDeviceT>();
		}

		// Token: 0x06027F5D RID: 163677 RVA: 0x00577460 File Offset: 0x00575660
		public static IProgressBarControl_UnionUnion FromIMatchTargetChargingDevice(IMatchTargetChargingDeviceT _imatchtargetchargingdevice)
		{
			return new IProgressBarControl_UnionUnion
			{
				Type = IProgressBarControl_Union.IMatchTargetChargingDevice,
				Value = _imatchtargetchargingdevice
			};
		}

		// Token: 0x06027F5E RID: 163678 RVA: 0x00577478 File Offset: 0x00575678
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
