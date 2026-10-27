using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E31 RID: 24113
	public class IPhotoTargetCaptureUiBase_UnionUnion
	{
		// Token: 0x1700B457 RID: 46167
		// (get) Token: 0x0602946C RID: 169068 RVA: 0x005A919D File Offset: 0x005A739D
		// (set) Token: 0x0602946D RID: 169069 RVA: 0x005A91A5 File Offset: 0x005A73A5
		public IPhotoTargetCaptureUiBase_Union Type { get; set; }

		// Token: 0x1700B458 RID: 46168
		// (get) Token: 0x0602946E RID: 169070 RVA: 0x005A91AE File Offset: 0x005A73AE
		// (set) Token: 0x0602946F RID: 169071 RVA: 0x005A91B6 File Offset: 0x005A73B6
		public object Value { get; set; }

		// Token: 0x06029470 RID: 169072 RVA: 0x005A91BF File Offset: 0x005A73BF
		public IPhotoTargetCaptureUiBase_UnionUnion()
		{
			this.Type = IPhotoTargetCaptureUiBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06029471 RID: 169073 RVA: 0x005A91D5 File Offset: 0x005A73D5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06029472 RID: 169074 RVA: 0x005A91E7 File Offset: 0x005A73E7
		public IPhotoTargetCaptureUiBaseT AsIPhotoTargetCaptureUiBase()
		{
			return this.As<IPhotoTargetCaptureUiBaseT>();
		}

		// Token: 0x06029473 RID: 169075 RVA: 0x005A91EF File Offset: 0x005A73EF
		public static IPhotoTargetCaptureUiBase_UnionUnion FromIPhotoTargetCaptureUiBase(IPhotoTargetCaptureUiBaseT _iphototargetcaptureuibase)
		{
			return new IPhotoTargetCaptureUiBase_UnionUnion
			{
				Type = IPhotoTargetCaptureUiBase_Union.IPhotoTargetCaptureUiBase,
				Value = _iphototargetcaptureuibase
			};
		}

		// Token: 0x06029474 RID: 169076 RVA: 0x005A9204 File Offset: 0x005A7404
		public IPhotoTargetCaptureUiRequiredPointsCenterT AsIPhotoTargetCaptureUiRequiredPointsCenter()
		{
			return this.As<IPhotoTargetCaptureUiRequiredPointsCenterT>();
		}

		// Token: 0x06029475 RID: 169077 RVA: 0x005A920C File Offset: 0x005A740C
		public static IPhotoTargetCaptureUiBase_UnionUnion FromIPhotoTargetCaptureUiRequiredPointsCenter(IPhotoTargetCaptureUiRequiredPointsCenterT _iphototargetcaptureuirequiredpointscenter)
		{
			return new IPhotoTargetCaptureUiBase_UnionUnion
			{
				Type = IPhotoTargetCaptureUiBase_Union.IPhotoTargetCaptureUiRequiredPointsCenter,
				Value = _iphototargetcaptureuirequiredpointscenter
			};
		}

		// Token: 0x06029476 RID: 169078 RVA: 0x005A9221 File Offset: 0x005A7421
		public IPhotoTargetCaptureUiEntityZeroT AsIPhotoTargetCaptureUiEntityZero()
		{
			return this.As<IPhotoTargetCaptureUiEntityZeroT>();
		}

		// Token: 0x06029477 RID: 169079 RVA: 0x005A9229 File Offset: 0x005A7429
		public static IPhotoTargetCaptureUiBase_UnionUnion FromIPhotoTargetCaptureUiEntityZero(IPhotoTargetCaptureUiEntityZeroT _iphototargetcaptureuientityzero)
		{
			return new IPhotoTargetCaptureUiBase_UnionUnion
			{
				Type = IPhotoTargetCaptureUiBase_Union.IPhotoTargetCaptureUiEntityZero,
				Value = _iphototargetcaptureuientityzero
			};
		}

		// Token: 0x06029478 RID: 169080 RVA: 0x005A923E File Offset: 0x005A743E
		public IPhotoTargetCaptureUiEachRequiredPointsT AsIPhotoTargetCaptureUiEachRequiredPoints()
		{
			return this.As<IPhotoTargetCaptureUiEachRequiredPointsT>();
		}

		// Token: 0x06029479 RID: 169081 RVA: 0x005A9246 File Offset: 0x005A7446
		public static IPhotoTargetCaptureUiBase_UnionUnion FromIPhotoTargetCaptureUiEachRequiredPoints(IPhotoTargetCaptureUiEachRequiredPointsT _iphototargetcaptureuieachrequiredpoints)
		{
			return new IPhotoTargetCaptureUiBase_UnionUnion
			{
				Type = IPhotoTargetCaptureUiBase_Union.IPhotoTargetCaptureUiEachRequiredPoints,
				Value = _iphototargetcaptureuieachrequiredpoints
			};
		}

		// Token: 0x0602947A RID: 169082 RVA: 0x005A925B File Offset: 0x005A745B
		public IPhotoTargetCaptureUiCustomPointsT AsIPhotoTargetCaptureUiCustomPoints()
		{
			return this.As<IPhotoTargetCaptureUiCustomPointsT>();
		}

		// Token: 0x0602947B RID: 169083 RVA: 0x005A9263 File Offset: 0x005A7463
		public static IPhotoTargetCaptureUiBase_UnionUnion FromIPhotoTargetCaptureUiCustomPoints(IPhotoTargetCaptureUiCustomPointsT _iphototargetcaptureuicustompoints)
		{
			return new IPhotoTargetCaptureUiBase_UnionUnion
			{
				Type = IPhotoTargetCaptureUiBase_Union.IPhotoTargetCaptureUiCustomPoints,
				Value = _iphototargetcaptureuicustompoints
			};
		}

		// Token: 0x0602947C RID: 169084 RVA: 0x005A9278 File Offset: 0x005A7478
		public static int Pack(FlatBufferBuilder builder, IPhotoTargetCaptureUiBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IPhotoTargetCaptureUiBase_Union.IPhotoTargetCaptureUiBase:
				return IPhotoTargetCaptureUiBase.Pack(builder, _o.AsIPhotoTargetCaptureUiBase()).Value;
			case IPhotoTargetCaptureUiBase_Union.IPhotoTargetCaptureUiRequiredPointsCenter:
				return IPhotoTargetCaptureUiRequiredPointsCenter.Pack(builder, _o.AsIPhotoTargetCaptureUiRequiredPointsCenter()).Value;
			case IPhotoTargetCaptureUiBase_Union.IPhotoTargetCaptureUiEntityZero:
				return IPhotoTargetCaptureUiEntityZero.Pack(builder, _o.AsIPhotoTargetCaptureUiEntityZero()).Value;
			case IPhotoTargetCaptureUiBase_Union.IPhotoTargetCaptureUiEachRequiredPoints:
				return IPhotoTargetCaptureUiEachRequiredPoints.Pack(builder, _o.AsIPhotoTargetCaptureUiEachRequiredPoints()).Value;
			case IPhotoTargetCaptureUiBase_Union.IPhotoTargetCaptureUiCustomPoints:
				return IPhotoTargetCaptureUiCustomPoints.Pack(builder, _o.AsIPhotoTargetCaptureUiCustomPoints()).Value;
			default:
				return 0;
			}
		}
	}
}
