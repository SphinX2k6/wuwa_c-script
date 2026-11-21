using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F73 RID: 32627
	public class TPerformerAiMoveToConfigUnion
	{
		// Token: 0x1700F2C5 RID: 62149
		// (get) Token: 0x0603ACED RID: 240877 RVA: 0x007E795A File Offset: 0x007E5B5A
		// (set) Token: 0x0603ACEE RID: 240878 RVA: 0x007E7962 File Offset: 0x007E5B62
		public TPerformerAiMoveToConfig Type { get; set; }

		// Token: 0x1700F2C6 RID: 62150
		// (get) Token: 0x0603ACEF RID: 240879 RVA: 0x007E796B File Offset: 0x007E5B6B
		// (set) Token: 0x0603ACF0 RID: 240880 RVA: 0x007E7973 File Offset: 0x007E5B73
		public object Value { get; set; }

		// Token: 0x0603ACF1 RID: 240881 RVA: 0x007E797C File Offset: 0x007E5B7C
		public TPerformerAiMoveToConfigUnion()
		{
			this.Type = TPerformerAiMoveToConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0603ACF2 RID: 240882 RVA: 0x007E7992 File Offset: 0x007E5B92
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603ACF3 RID: 240883 RVA: 0x007E79A4 File Offset: 0x007E5BA4
		public IPerformerAiMoveToEntityT AsIPerformerAiMoveToEntity()
		{
			return this.As<IPerformerAiMoveToEntityT>();
		}

		// Token: 0x0603ACF4 RID: 240884 RVA: 0x007E79AC File Offset: 0x007E5BAC
		public static TPerformerAiMoveToConfigUnion FromIPerformerAiMoveToEntity(IPerformerAiMoveToEntityT _iperformeraimovetoentity)
		{
			return new TPerformerAiMoveToConfigUnion
			{
				Type = TPerformerAiMoveToConfig.IPerformerAiMoveToEntity,
				Value = _iperformeraimovetoentity
			};
		}

		// Token: 0x0603ACF5 RID: 240885 RVA: 0x007E79C1 File Offset: 0x007E5BC1
		public IPerformerAiMoveToPlayerT AsIPerformerAiMoveToPlayer()
		{
			return this.As<IPerformerAiMoveToPlayerT>();
		}

		// Token: 0x0603ACF6 RID: 240886 RVA: 0x007E79C9 File Offset: 0x007E5BC9
		public static TPerformerAiMoveToConfigUnion FromIPerformerAiMoveToPlayer(IPerformerAiMoveToPlayerT _iperformeraimovetoplayer)
		{
			return new TPerformerAiMoveToConfigUnion
			{
				Type = TPerformerAiMoveToConfig.IPerformerAiMoveToPlayer,
				Value = _iperformeraimovetoplayer
			};
		}

		// Token: 0x0603ACF7 RID: 240887 RVA: 0x007E79DE File Offset: 0x007E5BDE
		public IPerformerAiMoveToPositionT AsIPerformerAiMoveToPosition()
		{
			return this.As<IPerformerAiMoveToPositionT>();
		}

		// Token: 0x0603ACF8 RID: 240888 RVA: 0x007E79E6 File Offset: 0x007E5BE6
		public static TPerformerAiMoveToConfigUnion FromIPerformerAiMoveToPosition(IPerformerAiMoveToPositionT _iperformeraimovetoposition)
		{
			return new TPerformerAiMoveToConfigUnion
			{
				Type = TPerformerAiMoveToConfig.IPerformerAiMoveToPosition,
				Value = _iperformeraimovetoposition
			};
		}

		// Token: 0x0603ACF9 RID: 240889 RVA: 0x007E79FC File Offset: 0x007E5BFC
		public static int Pack(FlatBufferBuilder builder, TPerformerAiMoveToConfigUnion _o)
		{
			switch (_o.Type)
			{
			case TPerformerAiMoveToConfig.IPerformerAiMoveToEntity:
				return IPerformerAiMoveToEntity.Pack(builder, _o.AsIPerformerAiMoveToEntity()).Value;
			case TPerformerAiMoveToConfig.IPerformerAiMoveToPlayer:
				return IPerformerAiMoveToPlayer.Pack(builder, _o.AsIPerformerAiMoveToPlayer()).Value;
			case TPerformerAiMoveToConfig.IPerformerAiMoveToPosition:
				return IPerformerAiMoveToPosition.Pack(builder, _o.AsIPerformerAiMoveToPosition()).Value;
			default:
				return 0;
			}
		}
	}
}
