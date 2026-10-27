using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C7F RID: 27775
	public class IPerformerAiMoveConfig_UnionUnion
	{
		// Token: 0x1700CED9 RID: 52953
		// (get) Token: 0x06030F0C RID: 200460 RVA: 0x006A52ED File Offset: 0x006A34ED
		// (set) Token: 0x06030F0D RID: 200461 RVA: 0x006A52F5 File Offset: 0x006A34F5
		public IPerformerAiMoveConfig_Union Type { get; set; }

		// Token: 0x1700CEDA RID: 52954
		// (get) Token: 0x06030F0E RID: 200462 RVA: 0x006A52FE File Offset: 0x006A34FE
		// (set) Token: 0x06030F0F RID: 200463 RVA: 0x006A5306 File Offset: 0x006A3506
		public object Value { get; set; }

		// Token: 0x06030F10 RID: 200464 RVA: 0x006A530F File Offset: 0x006A350F
		public IPerformerAiMoveConfig_UnionUnion()
		{
			this.Type = IPerformerAiMoveConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06030F11 RID: 200465 RVA: 0x006A5325 File Offset: 0x006A3525
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06030F12 RID: 200466 RVA: 0x006A5337 File Offset: 0x006A3537
		public IPerformerAiMoveConfigT AsIPerformerAiMoveConfig()
		{
			return this.As<IPerformerAiMoveConfigT>();
		}

		// Token: 0x06030F13 RID: 200467 RVA: 0x006A533F File Offset: 0x006A353F
		public static IPerformerAiMoveConfig_UnionUnion FromIPerformerAiMoveConfig(IPerformerAiMoveConfigT _iperformeraimoveconfig)
		{
			return new IPerformerAiMoveConfig_UnionUnion
			{
				Type = IPerformerAiMoveConfig_Union.IPerformerAiMoveConfig,
				Value = _iperformeraimoveconfig
			};
		}

		// Token: 0x06030F14 RID: 200468 RVA: 0x006A5354 File Offset: 0x006A3554
		public IPerformerAiMoveToPositionT AsIPerformerAiMoveToPosition()
		{
			return this.As<IPerformerAiMoveToPositionT>();
		}

		// Token: 0x06030F15 RID: 200469 RVA: 0x006A535C File Offset: 0x006A355C
		public static IPerformerAiMoveConfig_UnionUnion FromIPerformerAiMoveToPosition(IPerformerAiMoveToPositionT _iperformeraimovetoposition)
		{
			return new IPerformerAiMoveConfig_UnionUnion
			{
				Type = IPerformerAiMoveConfig_Union.IPerformerAiMoveToPosition,
				Value = _iperformeraimovetoposition
			};
		}

		// Token: 0x06030F16 RID: 200470 RVA: 0x006A5371 File Offset: 0x006A3571
		public IPerformerAiMoveToEntityT AsIPerformerAiMoveToEntity()
		{
			return this.As<IPerformerAiMoveToEntityT>();
		}

		// Token: 0x06030F17 RID: 200471 RVA: 0x006A5379 File Offset: 0x006A3579
		public static IPerformerAiMoveConfig_UnionUnion FromIPerformerAiMoveToEntity(IPerformerAiMoveToEntityT _iperformeraimovetoentity)
		{
			return new IPerformerAiMoveConfig_UnionUnion
			{
				Type = IPerformerAiMoveConfig_Union.IPerformerAiMoveToEntity,
				Value = _iperformeraimovetoentity
			};
		}

		// Token: 0x06030F18 RID: 200472 RVA: 0x006A538E File Offset: 0x006A358E
		public IPerformerAiMoveToPlayerT AsIPerformerAiMoveToPlayer()
		{
			return this.As<IPerformerAiMoveToPlayerT>();
		}

		// Token: 0x06030F19 RID: 200473 RVA: 0x006A5396 File Offset: 0x006A3596
		public static IPerformerAiMoveConfig_UnionUnion FromIPerformerAiMoveToPlayer(IPerformerAiMoveToPlayerT _iperformeraimovetoplayer)
		{
			return new IPerformerAiMoveConfig_UnionUnion
			{
				Type = IPerformerAiMoveConfig_Union.IPerformerAiMoveToPlayer,
				Value = _iperformeraimovetoplayer
			};
		}

		// Token: 0x06030F1A RID: 200474 RVA: 0x006A53AC File Offset: 0x006A35AC
		public static int Pack(FlatBufferBuilder builder, IPerformerAiMoveConfig_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IPerformerAiMoveConfig_Union.IPerformerAiMoveConfig:
				return IPerformerAiMoveConfig.Pack(builder, _o.AsIPerformerAiMoveConfig()).Value;
			case IPerformerAiMoveConfig_Union.IPerformerAiMoveToPosition:
				return IPerformerAiMoveToPosition.Pack(builder, _o.AsIPerformerAiMoveToPosition()).Value;
			case IPerformerAiMoveConfig_Union.IPerformerAiMoveToEntity:
				return IPerformerAiMoveToEntity.Pack(builder, _o.AsIPerformerAiMoveToEntity()).Value;
			case IPerformerAiMoveConfig_Union.IPerformerAiMoveToPlayer:
				return IPerformerAiMoveToPlayer.Pack(builder, _o.AsIPerformerAiMoveToPlayer()).Value;
			default:
				return 0;
			}
		}
	}
}
