using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Structures;
using CSharpScript.Game.Input;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalField.Input
{
	// Token: 0x02006033 RID: 24627
	[NullableContext(2)]
	[Nullable(0)]
	public class ElementalFieldInputLayer : InputLayer
	{
		// Token: 0x0603B221 RID: 242209 RVA: 0x010B8C40 File Offset: 0x010B6E40
		public override EInputLayer GetLayerType()
		{
			return EInputLayer.ElementalField;
		}

		// Token: 0x0603B222 RID: 242210 RVA: 0x010B8C44 File Offset: 0x010B6E44
		public override SInputCommand HandlePress(EInputAction action, float time)
		{
			if (this.BlockActions.Contains(action))
			{
				return InputLayer.GetSwallowCommand();
			}
			if (action != EInputAction.技能1)
			{
				return null;
			}
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			WorldEntity worldEntity = (getCurrentEntity != null) ? getCurrentEntity.Entity : null;
			CharacterSkillComponent characterSkillComponent = (worldEntity != null) ? worldEntity.GetComponent<CharacterSkillComponent>() : null;
			if (characterSkillComponent == null)
			{
				return null;
			}
			BaseTagComponent component = worldEntity.GetComponent<BaseTagComponent>();
			int skillId = (component != null && component.HasTag(ElementalCasketDefine.bossCustomElementalFieldTag)) ? 210064 : 210060;
			characterSkillComponent.BeginSkillAsync(skillId, new SkillParam
			{
				Reason = "ElementalFieldInputLayer, Toggle Skill"
			});
			return InputLayer.GetSwallowCommand();
		}

		// Token: 0x0603B223 RID: 242211 RVA: 0x010B8CE0 File Offset: 0x010B6EE0
		public override SInputCommand HandleRelease(EInputAction action, float time)
		{
			if (this.BlockActions.Contains(action) || action == EInputAction.技能1)
			{
				return InputLayer.GetSwallowCommand();
			}
			return null;
		}

		// Token: 0x0603B224 RID: 242212 RVA: 0x010B8D04 File Offset: 0x010B6F04
		public override SInputCommand HandleHold(EInputAction action, float time)
		{
			if (this.BlockActions.Contains(action) || action == EInputAction.技能1)
			{
				return InputLayer.GetSwallowCommand();
			}
			return null;
		}

		// Token: 0x0401F1AD RID: 127405
		private const int ELEMENTAL_FIELD_SKILL_ID = 210060;

		// Token: 0x0401F1AE RID: 127406
		private const int ELEMENTAL_BURST_SKILL_ID = 210064;

		// Token: 0x0401F1AF RID: 127407
		[Nullable(1)]
		private readonly HashSet<EInputAction> BlockActions = new HashSet<EInputAction>
		{
			EInputAction.幻象2,
			EInputAction.大招
		};
	}
}
