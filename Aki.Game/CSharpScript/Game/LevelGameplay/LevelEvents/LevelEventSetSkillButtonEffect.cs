using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.SkillButtonUi;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B7C RID: 27516
	public class LevelEventSetSkillButtonEffect : LevelEventBase
	{
		// Token: 0x0604425C RID: 279132 RVA: 0x010CA2BE File Offset: 0x010C84BE
		public LevelEventSetSkillButtonEffect(int id) : base(id)
		{
		}

		// Token: 0x0604425D RID: 279133 RVA: 0x010CA2C8 File Offset: 0x010C84C8
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if (inParams == null)
			{
				return;
			}
			SetSkillBtnEffect setSkillBtnEffect = inParams as SetSkillBtnEffect;
			ISkillBtnEffectBase skillBtnEffectData = setSkillBtnEffect.SkillBtnEffectData;
			ESkillButtonExtraEffect eskillButtonExtraEffect = ESkillButtonExtraEffect.None;
			if (skillBtnEffectData.Type == ESkillBtnEffectType.MusicBattleBtnEffect)
			{
				eskillButtonExtraEffect = ESkillButtonExtraEffect.Rhythm;
			}
			if (eskillButtonExtraEffect != ESkillButtonExtraEffect.None)
			{
				if (setSkillBtnEffect.SkillBtnType == Aki.TDConfigMgr.Action.ESkillButtonType.协奏)
				{
					BattleUiControl.Instance.PlayConcertoExtraEffect(eskillButtonExtraEffect, setSkillBtnEffect.Time);
					return;
				}
				SkillButtonUiController.Instance.PlayExtraEffect((CSharpScript.Game.Module.SkillButtonUi.ESkillButtonType)setSkillBtnEffect.SkillBtnType, eskillButtonExtraEffect, setSkillBtnEffect.Time);
			}
		}
	}
}
