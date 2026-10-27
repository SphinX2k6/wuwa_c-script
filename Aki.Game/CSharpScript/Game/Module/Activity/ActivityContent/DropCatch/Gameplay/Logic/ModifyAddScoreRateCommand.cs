using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x02006724 RID: 26404
	public class ModifyAddScoreRateCommand : IDropCatchCommand
	{
		// Token: 0x06041EA6 RID: 269990 RVA: 0x00FFCE34 File Offset: 0x00FFB034
		[NullableContext(1)]
		public void Execute(ICommandContext context, [Nullable(2)] object @params)
		{
			IModifyAddScoreRateCommandParams modifyAddScoreRateCommandParams = (IModifyAddScoreRateCommandParams)@params;
			DropCatchGameplayAttribute addScoreRateAttr = context.GetLogicContext().GetAddScoreRateAttr();
			DropCatchGameplayModifierMgr gameplayModifierMgr = context.GetLogicContext().GetGameplayModifierMgr();
			int modifierId = gameplayModifierMgr.AddModifierToAttr(addScoreRateAttr, modifyAddScoreRateCommandParams.Type, modifyAddScoreRateCommandParams.Value, modifyAddScoreRateCommandParams.Duration);
			EDropCatchCommandSource? source = modifyAddScoreRateCommandParams.Source;
			EDropCatchCommandSource edropCatchCommandSource = EDropCatchCommandSource.Skill;
			if (source.GetValueOrDefault() == edropCatchCommandSource & source != null)
			{
				gameplayModifierMgr.AddSkillModifier(addScoreRateAttr, modifierId);
			}
		}
	}
}
