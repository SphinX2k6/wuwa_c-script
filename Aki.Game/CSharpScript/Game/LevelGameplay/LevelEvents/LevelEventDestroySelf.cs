using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B10 RID: 27408
	public class LevelEventDestroySelf : LevelEventBase
	{
		// Token: 0x0604408A RID: 278666 RVA: 0x010B8A6E File Offset: 0x010B6C6E
		public LevelEventDestroySelf(int id) : base(id)
		{
		}

		// Token: 0x0604408B RID: 278667 RVA: 0x010B8A78 File Offset: 0x010B6C78
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			TriggerContext triggerContext = context as TriggerContext;
			if (triggerContext == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.JLY, "此LevelEvent只能配置在Trigger中", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			EntityHandle entityById = CreatureModel.Instance.GetEntityById(triggerContext.TriggerEntityId.Value);
			if (entityById == null)
			{
				return;
			}
			LevelGeneralCommons.ChangeToDestroyState(CreatureModel.Instance.GetPbDataIdByEntity(entityById));
		}
	}
}
