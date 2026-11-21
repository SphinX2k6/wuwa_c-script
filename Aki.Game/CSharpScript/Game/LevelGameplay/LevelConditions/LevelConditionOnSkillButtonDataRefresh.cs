using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.SkillButtonUi;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005EE5 RID: 24293
	public class LevelConditionOnSkillButtonDataRefresh : LevelConditionBase
	{
		// Token: 0x0603A8D6 RID: 239830 RVA: 0x0108CC48 File Offset: 0x0108AE48
		[NullableContext(1)]
		public override bool Check(Condition inConditionInfo, [Nullable(2)] AActor inTrigger, params object[] eventArgs)
		{
			SkillButtonUiModel instance = SkillButtonUiModel.Instance;
			string limitParams = inConditionInfo.GetLimitParams(LevelConditionOnSkillButtonDataRefresh.EArgsType.ActionType.ToEnumString());
			if (limitParams == null)
			{
				return false;
			}
			if (eventArgs.Length == 0)
			{
				return false;
			}
			int num = (int)eventArgs[0];
			if (this.LastViewId != num)
			{
				this.LastViewId = num;
				this.LastIndex = -1;
				this.LastSkillId = -1;
			}
			int num2 = int.Parse(limitParams);
			int skillButtonIndexByButton = instance.GetSkillButtonIndexByButton(num2);
			SkillButtonData skillButtonDataByButton = instance.GetSkillButtonDataByButton((ESkillButtonType)num2);
			int? num3 = (skillButtonDataByButton != null) ? new int?(skillButtonDataByButton.GetSkillId()) : null;
			if (this.LastIndex == -1 && this.LastSkillId == -1)
			{
				this.LastIndex = skillButtonIndexByButton;
				this.LastSkillId = num3.GetValueOrDefault(-1);
				return true;
			}
			if (this.LastIndex == skillButtonIndexByButton)
			{
				int lastSkillId = this.LastSkillId;
				int? num4 = num3;
				return lastSkillId == num4.GetValueOrDefault() & num4 != null;
			}
			return false;
		}

		// Token: 0x0401EC7A RID: 126074
		private int LastIndex = -1;

		// Token: 0x0401EC7B RID: 126075
		private int LastSkillId = -1;

		// Token: 0x0401EC7C RID: 126076
		private int LastViewId = -1;

		// Token: 0x0200B890 RID: 47248
		[EnumExtensions]
		public enum EArgsType
		{
			// Token: 0x04038F9E RID: 233374
			[EnumStringMember("skillId")]
			ActionType
		}
	}
}
