using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042E8 RID: 17128
	public class TMechaTrackScoreDetectionTypeUnion
	{
		// Token: 0x17007952 RID: 31058
		// (get) Token: 0x06019677 RID: 104055 RVA: 0x003A4B46 File Offset: 0x003A2D46
		// (set) Token: 0x06019678 RID: 104056 RVA: 0x003A4B4E File Offset: 0x003A2D4E
		public TMechaTrackScoreDetectionType Type { get; set; }

		// Token: 0x17007953 RID: 31059
		// (get) Token: 0x06019679 RID: 104057 RVA: 0x003A4B57 File Offset: 0x003A2D57
		// (set) Token: 0x0601967A RID: 104058 RVA: 0x003A4B5F File Offset: 0x003A2D5F
		public object Value { get; set; }

		// Token: 0x0601967B RID: 104059 RVA: 0x003A4B68 File Offset: 0x003A2D68
		public TMechaTrackScoreDetectionTypeUnion()
		{
			this.Type = TMechaTrackScoreDetectionType.NONE;
			this.Value = null;
		}

		// Token: 0x0601967C RID: 104060 RVA: 0x003A4B7E File Offset: 0x003A2D7E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601967D RID: 104061 RVA: 0x003A4B90 File Offset: 0x003A2D90
		public IMechaTrackScoreMechanismStateT AsIMechaTrackScoreMechanismState()
		{
			return this.As<IMechaTrackScoreMechanismStateT>();
		}

		// Token: 0x0601967E RID: 104062 RVA: 0x003A4B98 File Offset: 0x003A2D98
		public static TMechaTrackScoreDetectionTypeUnion FromIMechaTrackScoreMechanismState(IMechaTrackScoreMechanismStateT _imechatrackscoremechanismstate)
		{
			return new TMechaTrackScoreDetectionTypeUnion
			{
				Type = TMechaTrackScoreDetectionType.IMechaTrackScoreMechanismState,
				Value = _imechatrackscoremechanismstate
			};
		}

		// Token: 0x0601967F RID: 104063 RVA: 0x003A4BAD File Offset: 0x003A2DAD
		public IMechaTrackScoreStuntActionT AsIMechaTrackScoreStuntAction()
		{
			return this.As<IMechaTrackScoreStuntActionT>();
		}

		// Token: 0x06019680 RID: 104064 RVA: 0x003A4BB5 File Offset: 0x003A2DB5
		public static TMechaTrackScoreDetectionTypeUnion FromIMechaTrackScoreStuntAction(IMechaTrackScoreStuntActionT _imechatrackscorestuntaction)
		{
			return new TMechaTrackScoreDetectionTypeUnion
			{
				Type = TMechaTrackScoreDetectionType.IMechaTrackScoreStuntAction,
				Value = _imechatrackscorestuntaction
			};
		}

		// Token: 0x06019681 RID: 104065 RVA: 0x003A4BCA File Offset: 0x003A2DCA
		public IMechaTrackScoreTagDetectionT AsIMechaTrackScoreTagDetection()
		{
			return this.As<IMechaTrackScoreTagDetectionT>();
		}

		// Token: 0x06019682 RID: 104066 RVA: 0x003A4BD2 File Offset: 0x003A2DD2
		public static TMechaTrackScoreDetectionTypeUnion FromIMechaTrackScoreTagDetection(IMechaTrackScoreTagDetectionT _imechatrackscoretagdetection)
		{
			return new TMechaTrackScoreDetectionTypeUnion
			{
				Type = TMechaTrackScoreDetectionType.IMechaTrackScoreTagDetection,
				Value = _imechatrackscoretagdetection
			};
		}

		// Token: 0x06019683 RID: 104067 RVA: 0x003A4BE8 File Offset: 0x003A2DE8
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
