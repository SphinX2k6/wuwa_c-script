using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073E6 RID: 29670
	public class IPerformerAiMoveConfig_UnionUnion
	{
		// Token: 0x1700D9F4 RID: 55796
		// (get) Token: 0x06033E67 RID: 212583 RVA: 0x006FF7ED File Offset: 0x006FD9ED
		// (set) Token: 0x06033E68 RID: 212584 RVA: 0x006FF7F5 File Offset: 0x006FD9F5
		public IPerformerAiMoveConfig_Union Type { get; set; }

		// Token: 0x1700D9F5 RID: 55797
		// (get) Token: 0x06033E69 RID: 212585 RVA: 0x006FF7FE File Offset: 0x006FD9FE
		// (set) Token: 0x06033E6A RID: 212586 RVA: 0x006FF806 File Offset: 0x006FDA06
		public object Value { get; set; }

		// Token: 0x06033E6B RID: 212587 RVA: 0x006FF80F File Offset: 0x006FDA0F
		public IPerformerAiMoveConfig_UnionUnion()
		{
			this.Type = IPerformerAiMoveConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06033E6C RID: 212588 RVA: 0x006FF825 File Offset: 0x006FDA25
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06033E6D RID: 212589 RVA: 0x006FF837 File Offset: 0x006FDA37
		public IPerformerAiMoveConfigT AsIPerformerAiMoveConfig()
		{
			return this.As<IPerformerAiMoveConfigT>();
		}

		// Token: 0x06033E6E RID: 212590 RVA: 0x006FF83F File Offset: 0x006FDA3F
		public static IPerformerAiMoveConfig_UnionUnion FromIPerformerAiMoveConfig(IPerformerAiMoveConfigT _iperformeraimoveconfig)
		{
			return new IPerformerAiMoveConfig_UnionUnion
			{
				Type = IPerformerAiMoveConfig_Union.IPerformerAiMoveConfig,
				Value = _iperformeraimoveconfig
			};
		}

		// Token: 0x06033E6F RID: 212591 RVA: 0x006FF854 File Offset: 0x006FDA54
		public IPerformerAiMoveToPositionT AsIPerformerAiMoveToPosition()
		{
			return this.As<IPerformerAiMoveToPositionT>();
		}

		// Token: 0x06033E70 RID: 212592 RVA: 0x006FF85C File Offset: 0x006FDA5C
		public static IPerformerAiMoveConfig_UnionUnion FromIPerformerAiMoveToPosition(IPerformerAiMoveToPositionT _iperformeraimovetoposition)
		{
			return new IPerformerAiMoveConfig_UnionUnion
			{
				Type = IPerformerAiMoveConfig_Union.IPerformerAiMoveToPosition,
				Value = _iperformeraimovetoposition
			};
		}

		// Token: 0x06033E71 RID: 212593 RVA: 0x006FF871 File Offset: 0x006FDA71
		public IPerformerAiMoveToEntityT AsIPerformerAiMoveToEntity()
		{
			return this.As<IPerformerAiMoveToEntityT>();
		}

		// Token: 0x06033E72 RID: 212594 RVA: 0x006FF879 File Offset: 0x006FDA79
		public static IPerformerAiMoveConfig_UnionUnion FromIPerformerAiMoveToEntity(IPerformerAiMoveToEntityT _iperformeraimovetoentity)
		{
			return new IPerformerAiMoveConfig_UnionUnion
			{
				Type = IPerformerAiMoveConfig_Union.IPerformerAiMoveToEntity,
				Value = _iperformeraimovetoentity
			};
		}

		// Token: 0x06033E73 RID: 212595 RVA: 0x006FF88E File Offset: 0x006FDA8E
		public IPerformerAiMoveToPlayerT AsIPerformerAiMoveToPlayer()
		{
			return this.As<IPerformerAiMoveToPlayerT>();
		}

		// Token: 0x06033E74 RID: 212596 RVA: 0x006FF896 File Offset: 0x006FDA96
		public static IPerformerAiMoveConfig_UnionUnion FromIPerformerAiMoveToPlayer(IPerformerAiMoveToPlayerT _iperformeraimovetoplayer)
		{
			return new IPerformerAiMoveConfig_UnionUnion
			{
				Type = IPerformerAiMoveConfig_Union.IPerformerAiMoveToPlayer,
				Value = _iperformeraimovetoplayer
			};
		}

		// Token: 0x06033E75 RID: 212597 RVA: 0x006FF8AC File Offset: 0x006FDAAC
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
