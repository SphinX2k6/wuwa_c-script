using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007957 RID: 31063
	public class ISplineMoveDriveMode_UnionUnion
	{
		// Token: 0x1700E3CF RID: 58319
		// (get) Token: 0x06036B40 RID: 224064 RVA: 0x00751BA1 File Offset: 0x0074FDA1
		// (set) Token: 0x06036B41 RID: 224065 RVA: 0x00751BA9 File Offset: 0x0074FDA9
		public ISplineMoveDriveMode_Union Type { get; set; }

		// Token: 0x1700E3D0 RID: 58320
		// (get) Token: 0x06036B42 RID: 224066 RVA: 0x00751BB2 File Offset: 0x0074FDB2
		// (set) Token: 0x06036B43 RID: 224067 RVA: 0x00751BBA File Offset: 0x0074FDBA
		public object Value { get; set; }

		// Token: 0x06036B44 RID: 224068 RVA: 0x00751BC3 File Offset: 0x0074FDC3
		public ISplineMoveDriveMode_UnionUnion()
		{
			this.Type = ISplineMoveDriveMode_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06036B45 RID: 224069 RVA: 0x00751BD9 File Offset: 0x0074FDD9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06036B46 RID: 224070 RVA: 0x00751BEB File Offset: 0x0074FDEB
		public ISplineMoveDriveModeT AsISplineMoveDriveMode()
		{
			return this.As<ISplineMoveDriveModeT>();
		}

		// Token: 0x06036B47 RID: 224071 RVA: 0x00751BF3 File Offset: 0x0074FDF3
		public static ISplineMoveDriveMode_UnionUnion FromISplineMoveDriveMode(ISplineMoveDriveModeT _isplinemovedrivemode)
		{
			return new ISplineMoveDriveMode_UnionUnion
			{
				Type = ISplineMoveDriveMode_Union.ISplineMoveDriveMode,
				Value = _isplinemovedrivemode
			};
		}

		// Token: 0x06036B48 RID: 224072 RVA: 0x00751C08 File Offset: 0x0074FE08
		public IInputDrivenMoveDriveModeT AsIInputDrivenMoveDriveMode()
		{
			return this.As<IInputDrivenMoveDriveModeT>();
		}

		// Token: 0x06036B49 RID: 224073 RVA: 0x00751C10 File Offset: 0x0074FE10
		public static ISplineMoveDriveMode_UnionUnion FromIInputDrivenMoveDriveMode(IInputDrivenMoveDriveModeT _iinputdrivenmovedrivemode)
		{
			return new ISplineMoveDriveMode_UnionUnion
			{
				Type = ISplineMoveDriveMode_Union.IInputDrivenMoveDriveMode,
				Value = _iinputdrivenmovedrivemode
			};
		}

		// Token: 0x06036B4A RID: 224074 RVA: 0x00751C25 File Offset: 0x0074FE25
		public IPositionDrivenMoveDriveModeT AsIPositionDrivenMoveDriveMode()
		{
			return this.As<IPositionDrivenMoveDriveModeT>();
		}

		// Token: 0x06036B4B RID: 224075 RVA: 0x00751C2D File Offset: 0x0074FE2D
		public static ISplineMoveDriveMode_UnionUnion FromIPositionDrivenMoveDriveMode(IPositionDrivenMoveDriveModeT _ipositiondrivenmovedrivemode)
		{
			return new ISplineMoveDriveMode_UnionUnion
			{
				Type = ISplineMoveDriveMode_Union.IPositionDrivenMoveDriveMode,
				Value = _ipositiondrivenmovedrivemode
			};
		}

		// Token: 0x06036B4C RID: 224076 RVA: 0x00751C44 File Offset: 0x0074FE44
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
