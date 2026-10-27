using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.SkillButtonUi;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006D67 RID: 28007
	public class LevelConditionOnSkillButtonDataRefresh : LevelConditionBase
	{
		// Token: 0x06044774 RID: 280436 RVA: 0x010E2A90 File Offset: 0x010E0C90
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

		// Token: 0x040239D8 RID: 145880
		private int LastIndex = -1;

		// Token: 0x040239D9 RID: 145881
		private int LastSkillId = -1;

		// Token: 0x040239DA RID: 145882
		private int LastViewId = -1;

		// Token: 0x0200CCA0 RID: 52384
		[EnumExtensions]
		public enum EArgsType
		{
			// Token: 0x0403DB7C RID: 252796
			[EnumStringMember("skillId")]
			ActionType
		}
	}
}
