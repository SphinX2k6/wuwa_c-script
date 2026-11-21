using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CA6 RID: 23718
	public class LevelEventForceLockOnSpecialTagTarget : LevelEventBase
	{
		// Token: 0x0603A26D RID: 238189 RVA: 0x01066407 File Offset: 0x01064607
		public LevelEventForceLockOnSpecialTagTarget(int id) : base(id)
		{
		}

		// Token: 0x0603A26E RID: 238190 RVA: 0x01066410 File Offset: 0x01064610
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			SetForceLock setForceLock = inParams as SetForceLock;
			if (setForceLock == null)
			{
				return;
			}
			int entityId = setForceLock.EntityId;
			CharacterLockOnComponent component = Global.BaseCharacter.CharacterActorComponent.Entity.GetComponent<CharacterLockOnComponent>();
			if (component == null || !component.Valid)
			{
				global::Log.Instance.Error(ELogModule.Level, ELogAuthor.ZQ, "LevelEventForceLockOnSpecialTagTarget 获取不到玩家lockon组件", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(setForceLock.EntityId);
			component.ForceLookAt(new LockOnInfo(null, "")
			{
				EntityHandle = entityByPbDataId
			}, setForceLock.IsLocked);
		}
	}
}
