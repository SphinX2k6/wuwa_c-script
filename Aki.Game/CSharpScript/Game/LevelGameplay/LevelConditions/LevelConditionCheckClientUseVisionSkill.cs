using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.Vision;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006C64 RID: 27748
	public class LevelConditionCheckClientUseVisionSkill : LevelConditionBase
	{
		// Token: 0x06044550 RID: 279888 RVA: 0x010D8530 File Offset: 0x010D6730
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, AActor inTrigger, params object[] eventArgs)
		{
			if (inConditionInfo.LimitParamsLength == 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LevelCondition;
				ELogAuthor author = ELogAuthor.TL;
				string message = "配置错误！条件的参数不应该为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("inConditionInfo.Id", inConditionInfo.Id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			string limitParams = inConditionInfo.GetLimitParams("PhantomSkillId");
			if (limitParams == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.LevelCondition;
				ELogAuthor author2 = ELogAuthor.TL;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
				defaultInterpolatedStringHandler.AppendLiteral("配置错误！条件");
				defaultInterpolatedStringHandler.AppendFormatted<int>(inConditionInfo.Id);
				defaultInterpolatedStringHandler.AppendLiteral("的参数不符合条件类型");
				defaultInterpolatedStringHandler.AppendFormatted<ELevelGeneralCondition>(ELevelGeneralCondition.CheckClientUseVisionSkill);
				defaultInterpolatedStringHandler.AppendLiteral("的定义");
				instance2.Error(module2, author2, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			if (baseCharacter == null)
			{
				return false;
			}
			Entity entityNoBlueprint = baseCharacter.GetEntityNoBlueprint();
			CharacterVisionComponent characterVisionComponent = (entityNoBlueprint != null) ? entityNoBlueprint.GetComponent<CharacterVisionComponent>() : null;
			if (characterVisionComponent == null)
			{
				return false;
			}
			Entity entityNoBlueprint2 = baseCharacter.GetEntityNoBlueprint();
			CharacterSkillComponent characterSkillComponent = (entityNoBlueprint2 != null) ? entityNoBlueprint2.GetComponent<CharacterSkillComponent>() : null;
			if (characterSkillComponent == null)
			{
				return false;
			}
			SVisionData visionData = characterVisionComponent.GetVisionData(int.Parse(limitParams));
			if (visionData == null)
			{
				return false;
			}
			global::Skill skill = characterSkillComponent.GetSkill(visionData.技能ID);
			return skill != null && skill.Active;
		}
	}
}
