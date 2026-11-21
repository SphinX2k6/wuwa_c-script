using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004747 RID: 18247
	public class TMechaTrackScoreDetectionTypeUnion
	{
		// Token: 0x17007F85 RID: 32645
		// (get) Token: 0x0601ADF9 RID: 110073 RVA: 0x003D0476 File Offset: 0x003CE676
		// (set) Token: 0x0601ADFA RID: 110074 RVA: 0x003D047E File Offset: 0x003CE67E
		public TMechaTrackScoreDetectionType Type { get; set; }

		// Token: 0x17007F86 RID: 32646
		// (get) Token: 0x0601ADFB RID: 110075 RVA: 0x003D0487 File Offset: 0x003CE687
		// (set) Token: 0x0601ADFC RID: 110076 RVA: 0x003D048F File Offset: 0x003CE68F
		public object Value { get; set; }

		// Token: 0x0601ADFD RID: 110077 RVA: 0x003D0498 File Offset: 0x003CE698
		public TMechaTrackScoreDetectionTypeUnion()
		{
			this.Type = TMechaTrackScoreDetectionType.NONE;
			this.Value = null;
		}

		// Token: 0x0601ADFE RID: 110078 RVA: 0x003D04AE File Offset: 0x003CE6AE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601ADFF RID: 110079 RVA: 0x003D04C0 File Offset: 0x003CE6C0
		public IMechaTrackScoreMechanismStateT AsIMechaTrackScoreMechanismState()
		{
			return this.As<IMechaTrackScoreMechanismStateT>();
		}

		// Token: 0x0601AE00 RID: 110080 RVA: 0x003D04C8 File Offset: 0x003CE6C8
		public static TMechaTrackScoreDetectionTypeUnion FromIMechaTrackScoreMechanismState(IMechaTrackScoreMechanismStateT _imechatrackscoremechanismstate)
		{
			return new TMechaTrackScoreDetectionTypeUnion
			{
				Type = TMechaTrackScoreDetectionType.IMechaTrackScoreMechanismState,
				Value = _imechatrackscoremechanismstate
			};
		}

		// Token: 0x0601AE01 RID: 110081 RVA: 0x003D04DD File Offset: 0x003CE6DD
		public IMechaTrackScoreStuntActionT AsIMechaTrackScoreStuntAction()
		{
			return this.As<IMechaTrackScoreStuntActionT>();
		}

		// Token: 0x0601AE02 RID: 110082 RVA: 0x003D04E5 File Offset: 0x003CE6E5
		public static TMechaTrackScoreDetectionTypeUnion FromIMechaTrackScoreStuntAction(IMechaTrackScoreStuntActionT _imechatrackscorestuntaction)
		{
			return new TMechaTrackScoreDetectionTypeUnion
			{
				Type = TMechaTrackScoreDetectionType.IMechaTrackScoreStuntAction,
				Value = _imechatrackscorestuntaction
			};
		}

		// Token: 0x0601AE03 RID: 110083 RVA: 0x003D04FA File Offset: 0x003CE6FA
		public IMechaTrackScoreTagDetectionT AsIMechaTrackScoreTagDetection()
		{
			return this.As<IMechaTrackScoreTagDetectionT>();
		}

		// Token: 0x0601AE04 RID: 110084 RVA: 0x003D0502 File Offset: 0x003CE702
		public static TMechaTrackScoreDetectionTypeUnion FromIMechaTrackScoreTagDetection(IMechaTrackScoreTagDetectionT _imechatrackscoretagdetection)
		{
			return new TMechaTrackScoreDetectionTypeUnion
			{
				Type = TMechaTrackScoreDetectionType.IMechaTrackScoreTagDetection,
				Value = _imechatrackscoretagdetection
			};
		}

		// Token: 0x0601AE05 RID: 110085 RVA: 0x003D0518 File Offset: 0x003CE718
		public static int Pack(FlatBufferBuilder builder, TMechaTrackScoreDetectionTypeUnion _o)
		{
			switch (_o.Type)
			{
			case TMechaTrackScoreDetectionType.IMechaTrackScoreMechanismState:
				return IMechaTrackScoreMechanismState.Pack(builder, _o.AsIMechaTrackScoreMechanismState()).Value;
			case TMechaTrackScoreDetectionType.IMechaTrackScoreStuntAction:
				return IMechaTrackScoreStuntAction.Pack(builder, _o.AsIMechaTrackScoreStuntAction()).Value;
			case TMechaTrackScoreDetectionType.IMechaTrackScoreTagDetection:
				return IMechaTrackScoreTagDetection.Pack(builder, _o.AsIMechaTrackScoreTagDetection()).Value;
			default:
				return 0;
			}
		}
	}
}
