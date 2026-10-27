using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E91 RID: 24209
	public class TPhotoTargetCaptureUiUnion
	{
		// Token: 0x1700B4DD RID: 46301
		// (get) Token: 0x0602974E RID: 169806 RVA: 0x005AE352 File Offset: 0x005AC552
		// (set) Token: 0x0602974F RID: 169807 RVA: 0x005AE35A File Offset: 0x005AC55A
		public TPhotoTargetCaptureUi Type { get; set; }

		// Token: 0x1700B4DE RID: 46302
		// (get) Token: 0x06029750 RID: 169808 RVA: 0x005AE363 File Offset: 0x005AC563
		// (set) Token: 0x06029751 RID: 169809 RVA: 0x005AE36B File Offset: 0x005AC56B
		public object Value { get; set; }

		// Token: 0x06029752 RID: 169810 RVA: 0x005AE374 File Offset: 0x005AC574
		public TPhotoTargetCaptureUiUnion()
		{
			this.Type = TPhotoTargetCaptureUi.NONE;
			this.Value = null;
		}

		// Token: 0x06029753 RID: 169811 RVA: 0x005AE38A File Offset: 0x005AC58A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06029754 RID: 169812 RVA: 0x005AE39C File Offset: 0x005AC59C
		public IPhotoTargetCaptureUiCustomPointsT AsIPhotoTargetCaptureUiCustomPoints()
		{
			return this.As<IPhotoTargetCaptureUiCustomPointsT>();
		}

		// Token: 0x06029755 RID: 169813 RVA: 0x005AE3A4 File Offset: 0x005AC5A4
		public static TPhotoTargetCaptureUiUnion FromIPhotoTargetCaptureUiCustomPoints(IPhotoTargetCaptureUiCustomPointsT _iphototargetcaptureuicustompoints)
		{
			return new TPhotoTargetCaptureUiUnion
			{
				Type = TPhotoTargetCaptureUi.IPhotoTargetCaptureUiCustomPoints,
				Value = _iphototargetcaptureuicustompoints
			};
		}

		// Token: 0x06029756 RID: 169814 RVA: 0x005AE3B9 File Offset: 0x005AC5B9
		public IPhotoTargetCaptureUiEachRequiredPointsT AsIPhotoTargetCaptureUiEachRequiredPoints()
		{
			return this.As<IPhotoTargetCaptureUiEachRequiredPointsT>();
		}

		// Token: 0x06029757 RID: 169815 RVA: 0x005AE3C1 File Offset: 0x005AC5C1
		public static TPhotoTargetCaptureUiUnion FromIPhotoTargetCaptureUiEachRequiredPoints(IPhotoTargetCaptureUiEachRequiredPointsT _iphototargetcaptureuieachrequiredpoints)
		{
			return new TPhotoTargetCaptureUiUnion
			{
				Type = TPhotoTargetCaptureUi.IPhotoTargetCaptureUiEachRequiredPoints,
				Value = _iphototargetcaptureuieachrequiredpoints
			};
		}

		// Token: 0x06029758 RID: 169816 RVA: 0x005AE3D6 File Offset: 0x005AC5D6
		public IPhotoTargetCaptureUiEntityZeroT AsIPhotoTargetCaptureUiEntityZero()
		{
			return this.As<IPhotoTargetCaptureUiEntityZeroT>();
		}

		// Token: 0x06029759 RID: 169817 RVA: 0x005AE3DE File Offset: 0x005AC5DE
		public static TPhotoTargetCaptureUiUnion FromIPhotoTargetCaptureUiEntityZero(IPhotoTargetCaptureUiEntityZeroT _iphototargetcaptureuientityzero)
		{
			return new TPhotoTargetCaptureUiUnion
			{
				Type = TPhotoTargetCaptureUi.IPhotoTargetCaptureUiEntityZero,
				Value = _iphototargetcaptureuientityzero
			};
		}

		// Token: 0x0602975A RID: 169818 RVA: 0x005AE3F3 File Offset: 0x005AC5F3
		public IPhotoTargetCaptureUiRequiredPointsCenterT AsIPhotoTargetCaptureUiRequiredPointsCenter()
		{
			return this.As<IPhotoTargetCaptureUiRequiredPointsCenterT>();
		}

		// Token: 0x0602975B RID: 169819 RVA: 0x005AE3FB File Offset: 0x005AC5FB
		public static TPhotoTargetCaptureUiUnion FromIPhotoTargetCaptureUiRequiredPointsCenter(IPhotoTargetCaptureUiRequiredPointsCenterT _iphototargetcaptureuirequiredpointscenter)
		{
			return new TPhotoTargetCaptureUiUnion
			{
				Type = TPhotoTargetCaptureUi.IPhotoTargetCaptureUiRequiredPointsCenter,
				Value = _iphototargetcaptureuirequiredpointscenter
			};
		}

		// Token: 0x0602975C RID: 169820 RVA: 0x005AE410 File Offset: 0x005AC610
		public static int Pack(FlatBufferBuilder builder, TPhotoTargetCaptureUiUnion _o)
		{
			switch (_o.Type)
			{
			case TPhotoTargetCaptureUi.IPhotoTargetCaptureUiCustomPoints:
				return IPhotoTargetCaptureUiCustomPoints.Pack(builder, _o.AsIPhotoTargetCaptureUiCustomPoints()).Value;
			case TPhotoTargetCaptureUi.IPhotoTargetCaptureUiEachRequiredPoints:
				return IPhotoTargetCaptureUiEachRequiredPoints.Pack(builder, _o.AsIPhotoTargetCaptureUiEachRequiredPoints()).Value;
			case TPhotoTargetCaptureUi.IPhotoTargetCaptureUiEntityZero:
				return IPhotoTargetCaptureUiEntityZero.Pack(builder, _o.AsIPhotoTargetCaptureUiEntityZero()).Value;
			case TPhotoTargetCaptureUi.IPhotoTargetCaptureUiRequiredPointsCenter:
				return IPhotoTargetCaptureUiRequiredPointsCenter.Pack(builder, _o.AsIPhotoTargetCaptureUiRequiredPointsCenter()).Value;
			default:
				return 0;
			}
		}
	}
}
