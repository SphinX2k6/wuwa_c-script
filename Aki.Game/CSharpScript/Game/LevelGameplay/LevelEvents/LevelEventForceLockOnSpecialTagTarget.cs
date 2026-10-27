using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B2E RID: 27438
	public class LevelEventForceLockOnSpecialTagTarget : LevelEventBase
	{
		// Token: 0x0604411B RID: 278811 RVA: 0x010BCB7B File Offset: 0x010BAD7B
		public LevelEventForceLockOnSpecialTagTarget(int id) : base(id)
		{
		}

		// Token: 0x0604411C RID: 278812 RVA: 0x010BCB84 File Offset: 0x010BAD84
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
