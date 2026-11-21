using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200646E RID: 25710
	public class IPhotoTargetCaptureUiBase_UnionUnion
	{
		// Token: 0x1700BDBD RID: 48573
		// (get) Token: 0x0602BAF6 RID: 178934 RVA: 0x005F1ECD File Offset: 0x005F00CD
		// (set) Token: 0x0602BAF7 RID: 178935 RVA: 0x005F1ED5 File Offset: 0x005F00D5
		public IPhotoTargetCaptureUiBase_Union Type { get; set; }

		// Token: 0x1700BDBE RID: 48574
		// (get) Token: 0x0602BAF8 RID: 178936 RVA: 0x005F1EDE File Offset: 0x005F00DE
		// (set) Token: 0x0602BAF9 RID: 178937 RVA: 0x005F1EE6 File Offset: 0x005F00E6
		public object Value { get; set; }

		// Token: 0x0602BAFA RID: 178938 RVA: 0x005F1EEF File Offset: 0x005F00EF
		public IPhotoTargetCaptureUiBase_UnionUnion()
		{
			this.Type = IPhotoTargetCaptureUiBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602BAFB RID: 178939 RVA: 0x005F1F05 File Offset: 0x005F0105
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602BAFC RID: 178940 RVA: 0x005F1F17 File Offset: 0x005F0117
		public IPhotoTargetCaptureUiBaseT AsIPhotoTargetCaptureUiBase()
		{
			return this.As<IPhotoTargetCaptureUiBaseT>();
		}

		// Token: 0x0602BAFD RID: 178941 RVA: 0x005F1F1F File Offset: 0x005F011F
		public static IPhotoTargetCaptureUiBase_UnionUnion FromIPhotoTargetCaptureUiBase(IPhotoTargetCaptureUiBaseT _iphototargetcaptureuibase)
		{
			return new IPhotoTargetCaptureUiBase_UnionUnion
			{
				Type = IPhotoTargetCaptureUiBase_Union.IPhotoTargetCaptureUiBase,
				Value = _iphototargetcaptureuibase
			};
		}

		// Token: 0x0602BAFE RID: 178942 RVA: 0x005F1F34 File Offset: 0x005F0134
		public IPhotoTargetCaptureUiRequiredPointsCenterT AsIPhotoTargetCaptureUiRequiredPointsCenter()
		{
			return this.As<IPhotoTargetCaptureUiRequiredPointsCenterT>();
		}

		// Token: 0x0602BAFF RID: 178943 RVA: 0x005F1F3C File Offset: 0x005F013C
		public static IPhotoTargetCaptureUiBase_UnionUnion FromIPhotoTargetCaptureUiRequiredPointsCenter(IPhotoTargetCaptureUiRequiredPointsCenterT _iphototargetcaptureuirequiredpointscenter)
		{
			return new IPhotoTargetCaptureUiBase_UnionUnion
			{
				Type = IPhotoTargetCaptureUiBase_Union.IPhotoTargetCaptureUiRequiredPointsCenter,
				Value = _iphototargetcaptureuirequiredpointscenter
			};
		}

		// Token: 0x0602BB00 RID: 178944 RVA: 0x005F1F51 File Offset: 0x005F0151
		public IPhotoTargetCaptureUiEntityZeroT AsIPhotoTargetCaptureUiEntityZero()
		{
			return this.As<IPhotoTargetCaptureUiEntityZeroT>();
		}

		// Token: 0x0602BB01 RID: 178945 RVA: 0x005F1F59 File Offset: 0x005F0159
		public static IPhotoTargetCaptureUiBase_UnionUnion FromIPhotoTargetCaptureUiEntityZero(IPhotoTargetCaptureUiEntityZeroT _iphototargetcaptureuientityzero)
		{
			return new IPhotoTargetCaptureUiBase_UnionUnion
			{
				Type = IPhotoTargetCaptureUiBase_Union.IPhotoTargetCaptureUiEntityZero,
				Value = _iphototargetcaptureuientityzero
			};
		}

		// Token: 0x0602BB02 RID: 178946 RVA: 0x005F1F6E File Offset: 0x005F016E
		public IPhotoTargetCaptureUiEachRequiredPointsT AsIPhotoTargetCaptureUiEachRequiredPoints()
		{
			return this.As<IPhotoTargetCaptureUiEachRequiredPointsT>();
		}

		// Token: 0x0602BB03 RID: 178947 RVA: 0x005F1F76 File Offset: 0x005F0176
		public static IPhotoTargetCaptureUiBase_UnionUnion FromIPhotoTargetCaptureUiEachRequiredPoints(IPhotoTargetCaptureUiEachRequiredPointsT _iphototargetcaptureuieachrequiredpoints)
		{
			return new IPhotoTargetCaptureUiBase_UnionUnion
			{
				Type = IPhotoTargetCaptureUiBase_Union.IPhotoTargetCaptureUiEachRequiredPoints,
				Value = _iphototargetcaptureuieachrequiredpoints
			};
		}

		// Token: 0x0602BB04 RID: 178948 RVA: 0x005F1F8B File Offset: 0x005F018B
		public IPhotoTargetCaptureUiCustomPointsT AsIPhotoTargetCaptureUiCustomPoints()
		{
			return this.As<IPhotoTargetCaptureUiCustomPointsT>();
		}

		// Token: 0x0602BB05 RID: 178949 RVA: 0x005F1F93 File Offset: 0x005F0193
		public static IPhotoTargetCaptureUiBase_UnionUnion FromIPhotoTargetCaptureUiCustomPoints(IPhotoTargetCaptureUiCustomPointsT _iphototargetcaptureuicustompoints)
		{
			return new IPhotoTargetCaptureUiBase_UnionUnion
			{
				Type = IPhotoTargetCaptureUiBase_Union.IPhotoTargetCaptureUiCustomPoints,
				Value = _iphototargetcaptureuicustompoints
			};
		}

		// Token: 0x0602BB06 RID: 178950 RVA: 0x005F1FA8 File Offset: 0x005F01A8
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
