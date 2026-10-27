using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B00 RID: 27392
	public class LevelEventChangeToVision : LevelEventBase
	{
		// Token: 0x06044040 RID: 278592 RVA: 0x010B5CA8 File Offset: 0x010B3EA8
		public LevelEventChangeToVision(int id) : base(id)
		{
		}

		// Token: 0x06044041 RID: 278593 RVA: 0x010B5CB4 File Offset: 0x010B3EB4
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			ChangePhantom changePhantom = inParams as ChangePhantom;
			if (changePhantom == null)
			{
				return;
			}
			Entity entity = Global.BaseCharacter.CharacterActorComponent.Entity;
			entity.GetComponent<CharacterActorComponent>().ClearInput(false, true);
			BaseTagComponent component = entity.GetComponent<BaseTagComponent>();
			if (component != null)
			{
				component.AddTag(new int?(GameplayTagDefine.EGameplayTagId["角色.Common.BUFF通用标识.不能切人"]));
			}
			CharacterSkillComponent component2 = entity.GetComponent<CharacterSkillComponent>();
			if (component2 == null)
			{
				return;
			}
			component2.EndOwnerAndFollowSkills();
			component2.BeginSkillAsync(changePhantom.Id, new SkillParam
			{
				Reason = "LevelEventChangeToVision.ExecuteNew"
			});
		}
	}
}
