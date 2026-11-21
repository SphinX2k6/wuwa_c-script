using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E56 RID: 32342
	public class TBattleStatePerceptionBehaviorUnion
	{
		// Token: 0x1700F201 RID: 61953
		// (get) Token: 0x0603A6D5 RID: 239317 RVA: 0x007DDFCA File Offset: 0x007DC1CA
		// (set) Token: 0x0603A6D6 RID: 239318 RVA: 0x007DDFD2 File Offset: 0x007DC1D2
		public TBattleStatePerceptionBehavior Type { get; set; }

		// Token: 0x1700F202 RID: 61954
		// (get) Token: 0x0603A6D7 RID: 239319 RVA: 0x007DDFDB File Offset: 0x007DC1DB
		// (set) Token: 0x0603A6D8 RID: 239320 RVA: 0x007DDFE3 File Offset: 0x007DC1E3
		public object Value { get; set; }

		// Token: 0x0603A6D9 RID: 239321 RVA: 0x007DDFEC File Offset: 0x007DC1EC
		public TBattleStatePerceptionBehaviorUnion()
		{
			this.Type = TBattleStatePerceptionBehavior.NONE;
			this.Value = null;
		}

		// Token: 0x0603A6DA RID: 239322 RVA: 0x007DE002 File Offset: 0x007DC202
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A6DB RID: 239323 RVA: 0x007DE014 File Offset: 0x007DC214
		public IPerceptionNotifyGatherToEntityT AsIPerceptionNotifyGatherToEntity()
		{
			return this.As<IPerceptionNotifyGatherToEntityT>();
		}

		// Token: 0x0603A6DC RID: 239324 RVA: 0x007DE01C File Offset: 0x007DC21C
		public static TBattleStatePerceptionBehaviorUnion FromIPerceptionNotifyGatherToEntity(IPerceptionNotifyGatherToEntityT _iperceptionnotifygathertoentity)
		{
			return new TBattleStatePerceptionBehaviorUnion
			{
				Type = TBattleStatePerceptionBehavior.IPerceptionNotifyGatherToEntity,
				Value = _iperceptionnotifygathertoentity
			};
		}

		// Token: 0x0603A6DD RID: 239325 RVA: 0x007DE031 File Offset: 0x007DC231
		public IPerceptionNotifyGatherToPlayerT AsIPerceptionNotifyGatherToPlayer()
		{
			return this.As<IPerceptionNotifyGatherToPlayerT>();
		}

		// Token: 0x0603A6DE RID: 239326 RVA: 0x007DE039 File Offset: 0x007DC239
		public static TBattleStatePerceptionBehaviorUnion FromIPerceptionNotifyGatherToPlayer(IPerceptionNotifyGatherToPlayerT _iperceptionnotifygathertoplayer)
		{
			return new TBattleStatePerceptionBehaviorUnion
			{
				Type = TBattleStatePerceptionBehavior.IPerceptionNotifyGatherToPlayer,
				Value = _iperceptionnotifygathertoplayer
			};
		}

		// Token: 0x0603A6DF RID: 239327 RVA: 0x007DE050 File Offset: 0x007DC250
		public static int Pack(FlatBufferBuilder builder, TBattleStatePerceptionBehaviorUnion _o)
		{
			TBattleStatePerceptionBehavior type = _o.Type;
			if (type == TBattleStatePerceptionBehavior.IPerceptionNotifyGatherToEntity)
			{
				return IPerceptionNotifyGatherToEntity.Pack(builder, _o.AsIPerceptionNotifyGatherToEntity()).Value;
			}
			if (type != TBattleStatePerceptionBehavior.IPerceptionNotifyGatherToPlayer)
			{
				return 0;
			}
			return IPerceptionNotifyGatherToPlayer.Pack(builder, _o.AsIPerceptionNotifyGatherToPlayer()).Value;
		}
	}
}
