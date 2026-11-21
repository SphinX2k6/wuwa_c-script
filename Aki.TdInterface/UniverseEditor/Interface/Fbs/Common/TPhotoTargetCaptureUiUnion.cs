using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020064D4 RID: 25812
	public class TPhotoTargetCaptureUiUnion
	{
		// Token: 0x1700BE48 RID: 48712
		// (get) Token: 0x0602BDF6 RID: 179702 RVA: 0x005F72F6 File Offset: 0x005F54F6
		// (set) Token: 0x0602BDF7 RID: 179703 RVA: 0x005F72FE File Offset: 0x005F54FE
		public TPhotoTargetCaptureUi Type { get; set; }

		// Token: 0x1700BE49 RID: 48713
		// (get) Token: 0x0602BDF8 RID: 179704 RVA: 0x005F7307 File Offset: 0x005F5507
		// (set) Token: 0x0602BDF9 RID: 179705 RVA: 0x005F730F File Offset: 0x005F550F
		public object Value { get; set; }

		// Token: 0x0602BDFA RID: 179706 RVA: 0x005F7318 File Offset: 0x005F5518
		public TPhotoTargetCaptureUiUnion()
		{
			this.Type = TPhotoTargetCaptureUi.NONE;
			this.Value = null;
		}

		// Token: 0x0602BDFB RID: 179707 RVA: 0x005F732E File Offset: 0x005F552E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602BDFC RID: 179708 RVA: 0x005F7340 File Offset: 0x005F5540
		public IPhotoTargetCaptureUiCustomPointsT AsIPhotoTargetCaptureUiCustomPoints()
		{
			return this.As<IPhotoTargetCaptureUiCustomPointsT>();
		}

		// Token: 0x0602BDFD RID: 179709 RVA: 0x005F7348 File Offset: 0x005F5548
		public static TPhotoTargetCaptureUiUnion FromIPhotoTargetCaptureUiCustomPoints(IPhotoTargetCaptureUiCustomPointsT _iphototargetcaptureuicustompoints)
		{
			return new TPhotoTargetCaptureUiUnion
			{
				Type = TPhotoTargetCaptureUi.IPhotoTargetCaptureUiCustomPoints,
				Value = _iphototargetcaptureuicustompoints
			};
		}

		// Token: 0x0602BDFE RID: 179710 RVA: 0x005F735D File Offset: 0x005F555D
		public IPhotoTargetCaptureUiEachRequiredPointsT AsIPhotoTargetCaptureUiEachRequiredPoints()
		{
			return this.As<IPhotoTargetCaptureUiEachRequiredPointsT>();
		}

		// Token: 0x0602BDFF RID: 179711 RVA: 0x005F7365 File Offset: 0x005F5565
		public static TPhotoTargetCaptureUiUnion FromIPhotoTargetCaptureUiEachRequiredPoints(IPhotoTargetCaptureUiEachRequiredPointsT _iphototargetcaptureuieachrequiredpoints)
		{
			return new TPhotoTargetCaptureUiUnion
			{
				Type = TPhotoTargetCaptureUi.IPhotoTargetCaptureUiEachRequiredPoints,
				Value = _iphototargetcaptureuieachrequiredpoints
			};
		}

		// Token: 0x0602BE00 RID: 179712 RVA: 0x005F737A File Offset: 0x005F557A
		public IPhotoTargetCaptureUiEntityZeroT AsIPhotoTargetCaptureUiEntityZero()
		{
			return this.As<IPhotoTargetCaptureUiEntityZeroT>();
		}

		// Token: 0x0602BE01 RID: 179713 RVA: 0x005F7382 File Offset: 0x005F5582
		public static TPhotoTargetCaptureUiUnion FromIPhotoTargetCaptureUiEntityZero(IPhotoTargetCaptureUiEntityZeroT _iphototargetcaptureuientityzero)
		{
			return new TPhotoTargetCaptureUiUnion
			{
				Type = TPhotoTargetCaptureUi.IPhotoTargetCaptureUiEntityZero,
				Value = _iphototargetcaptureuientityzero
			};
		}

		// Token: 0x0602BE02 RID: 179714 RVA: 0x005F7397 File Offset: 0x005F5597
		public IPhotoTargetCaptureUiRequiredPointsCenterT AsIPhotoTargetCaptureUiRequiredPointsCenter()
		{
			return this.As<IPhotoTargetCaptureUiRequiredPointsCenterT>();
		}

		// Token: 0x0602BE03 RID: 179715 RVA: 0x005F739F File Offset: 0x005F559F
		public static TPhotoTargetCaptureUiUnion FromIPhotoTargetCaptureUiRequiredPointsCenter(IPhotoTargetCaptureUiRequiredPointsCenterT _iphototargetcaptureuirequiredpointscenter)
		{
			return new TPhotoTargetCaptureUiUnion
			{
				Type = TPhotoTargetCaptureUi.IPhotoTargetCaptureUiRequiredPointsCenter,
				Value = _iphototargetcaptureuirequiredpointscenter
			};
		}

		// Token: 0x0602BE04 RID: 179716 RVA: 0x005F73B4 File Offset: 0x005F55B4
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
