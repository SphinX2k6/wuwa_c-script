using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005C88 RID: 23688
	public class LevelEventDestroySelf : LevelEventBase
	{
		// Token: 0x0603A1DC RID: 238044 RVA: 0x010622FA File Offset: 0x010604FA
		public LevelEventDestroySelf(int id) : base(id)
		{
		}

		// Token: 0x0603A1DD RID: 238045 RVA: 0x01062304 File Offset: 0x01060504
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
