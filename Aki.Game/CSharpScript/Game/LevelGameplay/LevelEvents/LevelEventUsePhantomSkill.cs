using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005D2B RID: 23851
	public class LevelEventUsePhantomSkill : LevelEventBase
	{
		// Token: 0x0603A477 RID: 238711 RVA: 0x01078CE8 File Offset: 0x01076EE8
		public LevelEventUsePhantomSkill(int id) : base(id)
		{
		}

		// Token: 0x0603A478 RID: 238712 RVA: 0x01078CF4 File Offset: 0x01076EF4
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
