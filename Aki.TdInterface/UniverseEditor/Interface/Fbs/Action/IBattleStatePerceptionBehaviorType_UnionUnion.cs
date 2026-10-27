using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061FB RID: 25083
	public class IBattleStatePerceptionBehaviorType_UnionUnion
	{
		// Token: 0x1700BAF5 RID: 47861
		// (get) Token: 0x0602B3B1 RID: 177073 RVA: 0x005F4D11 File Offset: 0x005F2F11
		// (set) Token: 0x0602B3B2 RID: 177074 RVA: 0x005F4D19 File Offset: 0x005F2F19
		public IBattleStatePerceptionBehaviorType_Union Type { get; set; }

		// Token: 0x1700BAF6 RID: 47862
		// (get) Token: 0x0602B3B3 RID: 177075 RVA: 0x005F4D22 File Offset: 0x005F2F22
		// (set) Token: 0x0602B3B4 RID: 177076 RVA: 0x005F4D2A File Offset: 0x005F2F2A
		public object Value { get; set; }

		// Token: 0x0602B3B5 RID: 177077 RVA: 0x005F4D33 File Offset: 0x005F2F33
		public IBattleStatePerceptionBehaviorType_UnionUnion()
		{
			this.Type = IBattleStatePerceptionBehaviorType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602B3B6 RID: 177078 RVA: 0x005F4D49 File Offset: 0x005F2F49
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602B3B7 RID: 177079 RVA: 0x005F4D5B File Offset: 0x005F2F5B
		public IBattleStatePerceptionBehaviorTypeT AsIBattleStatePerceptionBehaviorType()
		{
			return this.As<IBattleStatePerceptionBehaviorTypeT>();
		}

		// Token: 0x0602B3B8 RID: 177080 RVA: 0x005F4D63 File Offset: 0x005F2F63
		public static IBattleStatePerceptionBehaviorType_UnionUnion FromIBattleStatePerceptionBehaviorType(IBattleStatePerceptionBehaviorTypeT _ibattlestateperceptionbehaviortype)
		{
			return new IBattleStatePerceptionBehaviorType_UnionUnion
			{
				Type = IBattleStatePerceptionBehaviorType_Union.IBattleStatePerceptionBehaviorType,
				Value = _ibattlestateperceptionbehaviortype
			};
		}

		// Token: 0x0602B3B9 RID: 177081 RVA: 0x005F4D78 File Offset: 0x005F2F78
		public IPerceptionNotifyGatherToEntityT AsIPerceptionNotifyGatherToEntity()
		{
			return this.As<IPerceptionNotifyGatherToEntityT>();
		}

		// Token: 0x0602B3BA RID: 177082 RVA: 0x005F4D80 File Offset: 0x005F2F80
		public static IBattleStatePerceptionBehaviorType_UnionUnion FromIPerceptionNotifyGatherToEntity(IPerceptionNotifyGatherToEntityT _iperceptionnotifygathertoentity)
		{
			return new IBattleStatePerceptionBehaviorType_UnionUnion
			{
				Type = IBattleStatePerceptionBehaviorType_Union.IPerceptionNotifyGatherToEntity,
				Value = _iperceptionnotifygathertoentity
			};
		}

		// Token: 0x0602B3BB RID: 177083 RVA: 0x005F4D95 File Offset: 0x005F2F95
		public IPerceptionNotifyGatherToPlayerT AsIPerceptionNotifyGatherToPlayer()
		{
			return this.As<IPerceptionNotifyGatherToPlayerT>();
		}

		// Token: 0x0602B3BC RID: 177084 RVA: 0x005F4D9D File Offset: 0x005F2F9D
		public static IBattleStatePerceptionBehaviorType_UnionUnion FromIPerceptionNotifyGatherToPlayer(IPerceptionNotifyGatherToPlayerT _iperceptionnotifygathertoplayer)
		{
			return new IBattleStatePerceptionBehaviorType_UnionUnion
			{
				Type = IBattleStatePerceptionBehaviorType_Union.IPerceptionNotifyGatherToPlayer,
				Value = _iperceptionnotifygathertoplayer
			};
		}

		// Token: 0x0602B3BD RID: 177085 RVA: 0x005F4DB4 File Offset: 0x005F2FB4
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
