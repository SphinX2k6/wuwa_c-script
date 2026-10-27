using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007648 RID: 30280
	public class TBattleStatePerceptionBehaviorUnion
	{
		// Token: 0x1700E5C3 RID: 58819
		// (get) Token: 0x06037230 RID: 225840 RVA: 0x00779ECE File Offset: 0x007780CE
		// (set) Token: 0x06037231 RID: 225841 RVA: 0x00779ED6 File Offset: 0x007780D6
		public TBattleStatePerceptionBehavior Type { get; set; }

		// Token: 0x1700E5C4 RID: 58820
		// (get) Token: 0x06037232 RID: 225842 RVA: 0x00779EDF File Offset: 0x007780DF
		// (set) Token: 0x06037233 RID: 225843 RVA: 0x00779EE7 File Offset: 0x007780E7
		public object Value { get; set; }

		// Token: 0x06037234 RID: 225844 RVA: 0x00779EF0 File Offset: 0x007780F0
		public TBattleStatePerceptionBehaviorUnion()
		{
			this.Type = TBattleStatePerceptionBehavior.NONE;
			this.Value = null;
		}

		// Token: 0x06037235 RID: 225845 RVA: 0x00779F06 File Offset: 0x00778106
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037236 RID: 225846 RVA: 0x00779F18 File Offset: 0x00778118
		public IPerceptionNotifyGatherToEntityT AsIPerceptionNotifyGatherToEntity()
		{
			return this.As<IPerceptionNotifyGatherToEntityT>();
		}

		// Token: 0x06037237 RID: 225847 RVA: 0x00779F20 File Offset: 0x00778120
		public static TBattleStatePerceptionBehaviorUnion FromIPerceptionNotifyGatherToEntity(IPerceptionNotifyGatherToEntityT _iperceptionnotifygathertoentity)
		{
			return new TBattleStatePerceptionBehaviorUnion
			{
				Type = TBattleStatePerceptionBehavior.IPerceptionNotifyGatherToEntity,
				Value = _iperceptionnotifygathertoentity
			};
		}

		// Token: 0x06037238 RID: 225848 RVA: 0x00779F35 File Offset: 0x00778135
		public IPerceptionNotifyGatherToPlayerT AsIPerceptionNotifyGatherToPlayer()
		{
			return this.As<IPerceptionNotifyGatherToPlayerT>();
		}

		// Token: 0x06037239 RID: 225849 RVA: 0x00779F3D File Offset: 0x0077813D
		public static TBattleStatePerceptionBehaviorUnion FromIPerceptionNotifyGatherToPlayer(IPerceptionNotifyGatherToPlayerT _iperceptionnotifygathertoplayer)
		{
			return new TBattleStatePerceptionBehaviorUnion
			{
				Type = TBattleStatePerceptionBehavior.IPerceptionNotifyGatherToPlayer,
				Value = _iperceptionnotifygathertoplayer
			};
		}

		// Token: 0x0603723A RID: 225850 RVA: 0x00779F54 File Offset: 0x00778154
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
