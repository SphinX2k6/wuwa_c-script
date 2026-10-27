using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Structures;
using CSharpScript.Game.Input;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalField.Input
{
	// Token: 0x02006EB3 RID: 28339
	[NullableContext(2)]
	[Nullable(0)]
	public class ElementalFieldInputLayer : InputLayer
	{
		// Token: 0x06045080 RID: 282752 RVA: 0x0110EB64 File Offset: 0x0110CD64
		public override EInputLayer GetLayerType()
		{
			return EInputLayer.ElementalField;
		}

		// Token: 0x06045081 RID: 282753 RVA: 0x0110EB68 File Offset: 0x0110CD68
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

		// Token: 0x06045082 RID: 282754 RVA: 0x0110EC04 File Offset: 0x0110CE04
		public override SInputCommand HandleRelease(EInputAction action, float time)
		{
			if (this.BlockActions.Contains(action) || action == EInputAction.技能1)
			{
				return InputLayer.GetSwallowCommand();
			}
			return null;
		}

		// Token: 0x06045083 RID: 282755 RVA: 0x0110EC28 File Offset: 0x0110CE28
		public override SInputCommand HandleHold(EInputAction action, float time)
		{
			if (this.BlockActions.Contains(action) || action == EInputAction.技能1)
			{
				return InputLayer.GetSwallowCommand();
			}
			return null;
		}

		// Token: 0x04023EFA RID: 147194
		private const int ELEMENTAL_FIELD_SKILL_ID = 210060;

		// Token: 0x04023EFB RID: 147195
		private const int ELEMENTAL_BURST_SKILL_ID = 210064;

		// Token: 0x04023EFC RID: 147196
		[Nullable(1)]
		private readonly HashSet<EInputAction> BlockActions = new HashSet<EInputAction>
		{
			EInputAction.幻象2,
			EInputAction.大招
		};
	}
}
