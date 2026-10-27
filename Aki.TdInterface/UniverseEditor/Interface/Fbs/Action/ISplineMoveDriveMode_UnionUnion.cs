using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007188 RID: 29064
	public class ISplineMoveDriveMode_UnionUnion
	{
		// Token: 0x1700D7DD RID: 55261
		// (get) Token: 0x06033866 RID: 211046 RVA: 0x006F0C11 File Offset: 0x006EEE11
		// (set) Token: 0x06033867 RID: 211047 RVA: 0x006F0C19 File Offset: 0x006EEE19
		public ISplineMoveDriveMode_Union Type { get; set; }

		// Token: 0x1700D7DE RID: 55262
		// (get) Token: 0x06033868 RID: 211048 RVA: 0x006F0C22 File Offset: 0x006EEE22
		// (set) Token: 0x06033869 RID: 211049 RVA: 0x006F0C2A File Offset: 0x006EEE2A
		public object Value { get; set; }

		// Token: 0x0603386A RID: 211050 RVA: 0x006F0C33 File Offset: 0x006EEE33
		public ISplineMoveDriveMode_UnionUnion()
		{
			this.Type = ISplineMoveDriveMode_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0603386B RID: 211051 RVA: 0x006F0C49 File Offset: 0x006EEE49
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603386C RID: 211052 RVA: 0x006F0C5B File Offset: 0x006EEE5B
		public ISplineMoveDriveModeT AsISplineMoveDriveMode()
		{
			return this.As<ISplineMoveDriveModeT>();
		}

		// Token: 0x0603386D RID: 211053 RVA: 0x006F0C63 File Offset: 0x006EEE63
		public static ISplineMoveDriveMode_UnionUnion FromISplineMoveDriveMode(ISplineMoveDriveModeT _isplinemovedrivemode)
		{
			return new ISplineMoveDriveMode_UnionUnion
			{
				Type = ISplineMoveDriveMode_Union.ISplineMoveDriveMode,
				Value = _isplinemovedrivemode
			};
		}

		// Token: 0x0603386E RID: 211054 RVA: 0x006F0C78 File Offset: 0x006EEE78
		public IInputDrivenMoveDriveModeT AsIInputDrivenMoveDriveMode()
		{
			return this.As<IInputDrivenMoveDriveModeT>();
		}

		// Token: 0x0603386F RID: 211055 RVA: 0x006F0C80 File Offset: 0x006EEE80
		public static ISplineMoveDriveMode_UnionUnion FromIInputDrivenMoveDriveMode(IInputDrivenMoveDriveModeT _iinputdrivenmovedrivemode)
		{
			return new ISplineMoveDriveMode_UnionUnion
			{
				Type = ISplineMoveDriveMode_Union.IInputDrivenMoveDriveMode,
				Value = _iinputdrivenmovedrivemode
			};
		}

		// Token: 0x06033870 RID: 211056 RVA: 0x006F0C95 File Offset: 0x006EEE95
		public IPositionDrivenMoveDriveModeT AsIPositionDrivenMoveDriveMode()
		{
			return this.As<IPositionDrivenMoveDriveModeT>();
		}

		// Token: 0x06033871 RID: 211057 RVA: 0x006F0C9D File Offset: 0x006EEE9D
		public static ISplineMoveDriveMode_UnionUnion FromIPositionDrivenMoveDriveMode(IPositionDrivenMoveDriveModeT _ipositiondrivenmovedrivemode)
		{
			return new ISplineMoveDriveMode_UnionUnion
			{
				Type = ISplineMoveDriveMode_Union.IPositionDrivenMoveDriveMode,
				Value = _ipositiondrivenmovedrivemode
			};
		}

		// Token: 0x06033872 RID: 211058 RVA: 0x006F0CB4 File Offset: 0x006EEEB4
		public static int Pack(FlatBufferBuilder builder, ISplineMoveDriveMode_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISplineMoveDriveMode_Union.ISplineMoveDriveMode:
				return ISplineMoveDriveMode.Pack(builder, _o.AsISplineMoveDriveMode()).Value;
			case ISplineMoveDriveMode_Union.IInputDrivenMoveDriveMode:
				return IInputDrivenMoveDriveMode.Pack(builder, _o.AsIInputDrivenMoveDriveMode()).Value;
			case ISplineMoveDriveMode_Union.IPositionDrivenMoveDriveMode:
				return IPositionDrivenMoveDriveMode.Pack(builder, _o.AsIPositionDrivenMoveDriveMode()).Value;
			default:
				return 0;
			}
		}
	}
}
