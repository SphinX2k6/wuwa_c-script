using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006BB2 RID: 27570
	public class LevelEventUsePhantomSkill : LevelEventBase
	{
		// Token: 0x0604431F RID: 279327 RVA: 0x010CEDD4 File Offset: 0x010CCFD4
		public LevelEventUsePhantomSkill(int id) : base(id)
		{
		}

		// Token: 0x06044320 RID: 279328 RVA: 0x010CEDE0 File Offset: 0x010CCFE0
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			UsePhantomSkill usePhantomSkill = inParams as UsePhantomSkill;
			if (usePhantomSkill == null)
			{
				return;
			}
			if (!SceneTeamModel.Instance.IsPhantomTeam)
			{
				return;
			}
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			if (usePhantomSkill.BlackboardPos != null)
			{
				BlackboardController.Instance.SetVectorValueByEntity(getCurrentEntity.Entity.Id, usePhantomSkill.BlackboardPos.Key, (double)usePhantomSkill.BlackboardPos.Value.X.GetValueOrDefault(), (double)usePhantomSkill.BlackboardPos.Value.Y.GetValueOrDefault(), (double)usePhantomSkill.BlackboardPos.Value.Z.GetValueOrDefault());
			}
			if (usePhantomSkill.BlackboardRot != null)
			{
				if (Global.BaseCharacter == null)
				{
					return;
				}
				BlackboardController.Instance.SetRotatorValueByEntity(getCurrentEntity.Entity.Id, usePhantomSkill.BlackboardRot.Key, usePhantomSkill.BlackboardRot.Value.Y.GetValueOrDefault(), usePhantomSkill.BlackboardRot.Value.X.GetValueOrDefault(), usePhantomSkill.BlackboardRot.Value.Z.GetValueOrDefault());
			}
			getCurrentEntity.Entity.GetComponent<BaseTagComponent>().AddTag(new int?(GameplayTagUtils.GetTagIdByName(usePhantomSkill.SkillType.ToEnumString())));
		}
	}
}
