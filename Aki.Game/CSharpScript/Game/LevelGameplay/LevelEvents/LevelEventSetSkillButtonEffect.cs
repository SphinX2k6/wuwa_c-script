using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.SkillButtonUi;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CF4 RID: 23796
	public class LevelEventSetSkillButtonEffect : LevelEventBase
	{
		// Token: 0x0603A3AE RID: 238510 RVA: 0x01073F32 File Offset: 0x01072132
		public LevelEventSetSkillButtonEffect(int id) : base(id)
		{
		}

		// Token: 0x0603A3AF RID: 238511 RVA: 0x01073F3C File Offset: 0x0107213C
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
