using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006869 RID: 26729
	public class IBattleStatePerceptionBehaviorType_UnionUnion
	{
		// Token: 0x1700C478 RID: 50296
		// (get) Token: 0x0602DAF8 RID: 187128 RVA: 0x0063F785 File Offset: 0x0063D985
		// (set) Token: 0x0602DAF9 RID: 187129 RVA: 0x0063F78D File Offset: 0x0063D98D
		public IBattleStatePerceptionBehaviorType_Union Type { get; set; }

		// Token: 0x1700C479 RID: 50297
		// (get) Token: 0x0602DAFA RID: 187130 RVA: 0x0063F796 File Offset: 0x0063D996
		// (set) Token: 0x0602DAFB RID: 187131 RVA: 0x0063F79E File Offset: 0x0063D99E
		public object Value { get; set; }

		// Token: 0x0602DAFC RID: 187132 RVA: 0x0063F7A7 File Offset: 0x0063D9A7
		public IBattleStatePerceptionBehaviorType_UnionUnion()
		{
			this.Type = IBattleStatePerceptionBehaviorType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602DAFD RID: 187133 RVA: 0x0063F7BD File Offset: 0x0063D9BD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602DAFE RID: 187134 RVA: 0x0063F7CF File Offset: 0x0063D9CF
		public IBattleStatePerceptionBehaviorTypeT AsIBattleStatePerceptionBehaviorType()
		{
			return this.As<IBattleStatePerceptionBehaviorTypeT>();
		}

		// Token: 0x0602DAFF RID: 187135 RVA: 0x0063F7D7 File Offset: 0x0063D9D7
		public static IBattleStatePerceptionBehaviorType_UnionUnion FromIBattleStatePerceptionBehaviorType(IBattleStatePerceptionBehaviorTypeT _ibattlestateperceptionbehaviortype)
		{
			return new IBattleStatePerceptionBehaviorType_UnionUnion
			{
				Type = IBattleStatePerceptionBehaviorType_Union.IBattleStatePerceptionBehaviorType,
				Value = _ibattlestateperceptionbehaviortype
			};
		}

		// Token: 0x0602DB00 RID: 187136 RVA: 0x0063F7EC File Offset: 0x0063D9EC
		public IPerceptionNotifyGatherToEntityT AsIPerceptionNotifyGatherToEntity()
		{
			return this.As<IPerceptionNotifyGatherToEntityT>();
		}

		// Token: 0x0602DB01 RID: 187137 RVA: 0x0063F7F4 File Offset: 0x0063D9F4
		public static IBattleStatePerceptionBehaviorType_UnionUnion FromIPerceptionNotifyGatherToEntity(IPerceptionNotifyGatherToEntityT _iperceptionnotifygathertoentity)
		{
			return new IBattleStatePerceptionBehaviorType_UnionUnion
			{
				Type = IBattleStatePerceptionBehaviorType_Union.IPerceptionNotifyGatherToEntity,
				Value = _iperceptionnotifygathertoentity
			};
		}

		// Token: 0x0602DB02 RID: 187138 RVA: 0x0063F809 File Offset: 0x0063DA09
		public IPerceptionNotifyGatherToPlayerT AsIPerceptionNotifyGatherToPlayer()
		{
			return this.As<IPerceptionNotifyGatherToPlayerT>();
		}

		// Token: 0x0602DB03 RID: 187139 RVA: 0x0063F811 File Offset: 0x0063DA11
		public static IBattleStatePerceptionBehaviorType_UnionUnion FromIPerceptionNotifyGatherToPlayer(IPerceptionNotifyGatherToPlayerT _iperceptionnotifygathertoplayer)
		{
			return new IBattleStatePerceptionBehaviorType_UnionUnion
			{
				Type = IBattleStatePerceptionBehaviorType_Union.IPerceptionNotifyGatherToPlayer,
				Value = _iperceptionnotifygathertoplayer
			};
		}

		// Token: 0x0602DB04 RID: 187140 RVA: 0x0063F828 File Offset: 0x0063DA28
		public static int Pack(FlatBufferBuilder builder, IBattleStatePerceptionBehaviorType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IBattleStatePerceptionBehaviorType_Union.IBattleStatePerceptionBehaviorType:
				return IBattleStatePerceptionBehaviorType.Pack(builder, _o.AsIBattleStatePerceptionBehaviorType()).Value;
			case IBattleStatePerceptionBehaviorType_Union.IPerceptionNotifyGatherToEntity:
				return IPerceptionNotifyGatherToEntity.Pack(builder, _o.AsIPerceptionNotifyGatherToEntity()).Value;
			case IBattleStatePerceptionBehaviorType_Union.IPerceptionNotifyGatherToPlayer:
				return IPerceptionNotifyGatherToPlayer.Pack(builder, _o.AsIPerceptionNotifyGatherToPlayer()).Value;
			default:
				return 0;
			}
		}
	}
}
