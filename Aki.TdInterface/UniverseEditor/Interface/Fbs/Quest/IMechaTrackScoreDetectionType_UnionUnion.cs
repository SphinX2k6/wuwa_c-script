using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F24 RID: 16164
	public class IMechaTrackScoreDetectionType_UnionUnion
	{
		// Token: 0x17007063 RID: 28771
		// (get) Token: 0x06016F30 RID: 94000 RVA: 0x0034FBED File Offset: 0x0034DDED
		// (set) Token: 0x06016F31 RID: 94001 RVA: 0x0034FBF5 File Offset: 0x0034DDF5
		public IMechaTrackScoreDetectionType_Union Type { get; set; }

		// Token: 0x17007064 RID: 28772
		// (get) Token: 0x06016F32 RID: 94002 RVA: 0x0034FBFE File Offset: 0x0034DDFE
		// (set) Token: 0x06016F33 RID: 94003 RVA: 0x0034FC06 File Offset: 0x0034DE06
		public object Value { get; set; }

		// Token: 0x06016F34 RID: 94004 RVA: 0x0034FC0F File Offset: 0x0034DE0F
		public IMechaTrackScoreDetectionType_UnionUnion()
		{
			this.Type = IMechaTrackScoreDetectionType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06016F35 RID: 94005 RVA: 0x0034FC25 File Offset: 0x0034DE25
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06016F36 RID: 94006 RVA: 0x0034FC37 File Offset: 0x0034DE37
		public IMechaTrackScoreDetectionTypeT AsIMechaTrackScoreDetectionType()
		{
			return this.As<IMechaTrackScoreDetectionTypeT>();
		}

		// Token: 0x06016F37 RID: 94007 RVA: 0x0034FC3F File Offset: 0x0034DE3F
		public static IMechaTrackScoreDetectionType_UnionUnion FromIMechaTrackScoreDetectionType(IMechaTrackScoreDetectionTypeT _imechatrackscoredetectiontype)
		{
			return new IMechaTrackScoreDetectionType_UnionUnion
			{
				Type = IMechaTrackScoreDetectionType_Union.IMechaTrackScoreDetectionType,
				Value = _imechatrackscoredetectiontype
			};
		}

		// Token: 0x06016F38 RID: 94008 RVA: 0x0034FC54 File Offset: 0x0034DE54
		public IMechaTrackScoreStuntActionT AsIMechaTrackScoreStuntAction()
		{
			return this.As<IMechaTrackScoreStuntActionT>();
		}

		// Token: 0x06016F39 RID: 94009 RVA: 0x0034FC5C File Offset: 0x0034DE5C
		public static IMechaTrackScoreDetectionType_UnionUnion FromIMechaTrackScoreStuntAction(IMechaTrackScoreStuntActionT _imechatrackscorestuntaction)
		{
			return new IMechaTrackScoreDetectionType_UnionUnion
			{
				Type = IMechaTrackScoreDetectionType_Union.IMechaTrackScoreStuntAction,
				Value = _imechatrackscorestuntaction
			};
		}

		// Token: 0x06016F3A RID: 94010 RVA: 0x0034FC71 File Offset: 0x0034DE71
		public IMechaTrackScoreMechanismStateT AsIMechaTrackScoreMechanismState()
		{
			return this.As<IMechaTrackScoreMechanismStateT>();
		}

		// Token: 0x06016F3B RID: 94011 RVA: 0x0034FC79 File Offset: 0x0034DE79
		public static IMechaTrackScoreDetectionType_UnionUnion FromIMechaTrackScoreMechanismState(IMechaTrackScoreMechanismStateT _imechatrackscoremechanismstate)
		{
			return new IMechaTrackScoreDetectionType_UnionUnion
			{
				Type = IMechaTrackScoreDetectionType_Union.IMechaTrackScoreMechanismState,
				Value = _imechatrackscoremechanismstate
			};
		}

		// Token: 0x06016F3C RID: 94012 RVA: 0x0034FC8E File Offset: 0x0034DE8E
		public IMechaTrackScoreTagDetectionT AsIMechaTrackScoreTagDetection()
		{
			return this.As<IMechaTrackScoreTagDetectionT>();
		}

		// Token: 0x06016F3D RID: 94013 RVA: 0x0034FC96 File Offset: 0x0034DE96
		public static IMechaTrackScoreDetectionType_UnionUnion FromIMechaTrackScoreTagDetection(IMechaTrackScoreTagDetectionT _imechatrackscoretagdetection)
		{
			return new IMechaTrackScoreDetectionType_UnionUnion
			{
				Type = IMechaTrackScoreDetectionType_Union.IMechaTrackScoreTagDetection,
				Value = _imechatrackscoretagdetection
			};
		}

		// Token: 0x06016F3E RID: 94014 RVA: 0x0034FCAC File Offset: 0x0034DEAC
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
