using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004362 RID: 17250
	public class IMechaTrackScoreDetectionType_UnionUnion
	{
		// Token: 0x17007652 RID: 30290
		// (get) Token: 0x06018588 RID: 99720 RVA: 0x00378E15 File Offset: 0x00377015
		// (set) Token: 0x06018589 RID: 99721 RVA: 0x00378E1D File Offset: 0x0037701D
		public IMechaTrackScoreDetectionType_Union Type { get; set; }

		// Token: 0x17007653 RID: 30291
		// (get) Token: 0x0601858A RID: 99722 RVA: 0x00378E26 File Offset: 0x00377026
		// (set) Token: 0x0601858B RID: 99723 RVA: 0x00378E2E File Offset: 0x0037702E
		public object Value { get; set; }

		// Token: 0x0601858C RID: 99724 RVA: 0x00378E37 File Offset: 0x00377037
		public IMechaTrackScoreDetectionType_UnionUnion()
		{
			this.Type = IMechaTrackScoreDetectionType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601858D RID: 99725 RVA: 0x00378E4D File Offset: 0x0037704D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601858E RID: 99726 RVA: 0x00378E5F File Offset: 0x0037705F
		public IMechaTrackScoreDetectionTypeT AsIMechaTrackScoreDetectionType()
		{
			return this.As<IMechaTrackScoreDetectionTypeT>();
		}

		// Token: 0x0601858F RID: 99727 RVA: 0x00378E67 File Offset: 0x00377067
		public static IMechaTrackScoreDetectionType_UnionUnion FromIMechaTrackScoreDetectionType(IMechaTrackScoreDetectionTypeT _imechatrackscoredetectiontype)
		{
			return new IMechaTrackScoreDetectionType_UnionUnion
			{
				Type = IMechaTrackScoreDetectionType_Union.IMechaTrackScoreDetectionType,
				Value = _imechatrackscoredetectiontype
			};
		}

		// Token: 0x06018590 RID: 99728 RVA: 0x00378E7C File Offset: 0x0037707C
		public IMechaTrackScoreStuntActionT AsIMechaTrackScoreStuntAction()
		{
			return this.As<IMechaTrackScoreStuntActionT>();
		}

		// Token: 0x06018591 RID: 99729 RVA: 0x00378E84 File Offset: 0x00377084
		public static IMechaTrackScoreDetectionType_UnionUnion FromIMechaTrackScoreStuntAction(IMechaTrackScoreStuntActionT _imechatrackscorestuntaction)
		{
			return new IMechaTrackScoreDetectionType_UnionUnion
			{
				Type = IMechaTrackScoreDetectionType_Union.IMechaTrackScoreStuntAction,
				Value = _imechatrackscorestuntaction
			};
		}

		// Token: 0x06018592 RID: 99730 RVA: 0x00378E99 File Offset: 0x00377099
		public IMechaTrackScoreMechanismStateT AsIMechaTrackScoreMechanismState()
		{
			return this.As<IMechaTrackScoreMechanismStateT>();
		}

		// Token: 0x06018593 RID: 99731 RVA: 0x00378EA1 File Offset: 0x003770A1
		public static IMechaTrackScoreDetectionType_UnionUnion FromIMechaTrackScoreMechanismState(IMechaTrackScoreMechanismStateT _imechatrackscoremechanismstate)
		{
			return new IMechaTrackScoreDetectionType_UnionUnion
			{
				Type = IMechaTrackScoreDetectionType_Union.IMechaTrackScoreMechanismState,
				Value = _imechatrackscoremechanismstate
			};
		}

		// Token: 0x06018594 RID: 99732 RVA: 0x00378EB6 File Offset: 0x003770B6
		public IMechaTrackScoreTagDetectionT AsIMechaTrackScoreTagDetection()
		{
			return this.As<IMechaTrackScoreTagDetectionT>();
		}

		// Token: 0x06018595 RID: 99733 RVA: 0x00378EBE File Offset: 0x003770BE
		public static IMechaTrackScoreDetectionType_UnionUnion FromIMechaTrackScoreTagDetection(IMechaTrackScoreTagDetectionT _imechatrackscoretagdetection)
		{
			return new IMechaTrackScoreDetectionType_UnionUnion
			{
				Type = IMechaTrackScoreDetectionType_Union.IMechaTrackScoreTagDetection,
				Value = _imechatrackscoretagdetection
			};
		}

		// Token: 0x06018596 RID: 99734 RVA: 0x00378ED4 File Offset: 0x003770D4
		public static int Pack(FlatBufferBuilder builder, IMechaTrackScoreDetectionType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IMechaTrackScoreDetectionType_Union.IMechaTrackScoreDetectionType:
				return IMechaTrackScoreDetectionType.Pack(builder, _o.AsIMechaTrackScoreDetectionType()).Value;
			case IMechaTrackScoreDetectionType_Union.IMechaTrackScoreStuntAction:
				return IMechaTrackScoreStuntAction.Pack(builder, _o.AsIMechaTrackScoreStuntAction()).Value;
			case IMechaTrackScoreDetectionType_Union.IMechaTrackScoreMechanismState:
				return IMechaTrackScoreMechanismState.Pack(builder, _o.AsIMechaTrackScoreMechanismState()).Value;
			case IMechaTrackScoreDetectionType_Union.IMechaTrackScoreTagDetection:
				return IMechaTrackScoreTagDetection.Pack(builder, _o.AsIMechaTrackScoreTagDetection()).Value;
			default:
				return 0;
			}
		}
	}
}
