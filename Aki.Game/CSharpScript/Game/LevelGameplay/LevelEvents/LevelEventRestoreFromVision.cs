using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B64 RID: 27492
	public class LevelEventRestoreFromVision : LevelEventBase
	{
		// Token: 0x060441F9 RID: 279033 RVA: 0x010C4F82 File Offset: 0x010C3182
		public LevelEventRestoreFromVision(int id) : base(id)
		{
		}

		// Token: 0x060441FA RID: 279034 RVA: 0x010C4F8C File Offset: 0x010C318C
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if (!(inParams is RestorePhantom))
			{
				return;
			}
			Entity entity = Global.BaseCharacter.CharacterActorComponent.Entity;
			CharacterSkillComponent characterSkillComponent = (entity != null) ? entity.GetComponent<CharacterSkillComponent>() : null;
			if (characterSkillComponent == null || entity == null)
			{
				return;
			}
			CharacterFollowComponent component = entity.GetComponent<CharacterFollowComponent>();
			List<int> list = (component != null) ? component.AttributeSharerIds : null;
			if (list == null)
			{
				return;
			}
			foreach (int id in list)
			{
				Entity entity2 = EntitySystem.Instance.Get(id);
				if (entity2 != null)
				{
					BaseTagComponent component2 = entity2.GetComponent<BaseTagComponent>();
					if (component2 == null)
					{
						return;
					}
					component2.AddTag(new int?(GameplayTagDefine.EGameplayTagId["幻象.变身.正常结束"]));
					return;
				}
			}
			characterSkillComponent.EndOwnerAndFollowSkills();
		}
	}
}
