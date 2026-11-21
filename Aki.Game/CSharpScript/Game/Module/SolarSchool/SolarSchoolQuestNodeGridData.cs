using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059EC RID: 23020
	public static class SolarSchoolQuestNodeGridData
	{
		// Token: 0x06038B28 RID: 232232 RVA: 0x00FDE774 File Offset: 0x00FDC974
		[NullableContext(2)]
		public static IMultiTemplateGridData Create(int questId, Action<int> clickCallback)
		{
			SolarSchoolQuest? quest = SolarSchoolConfig.Instance.GetQuest(questId);
			if (quest == null)
			{
				return null;
			}
			if (quest.Value.ShowType == 1)
			{
				return new SolarSchoolQuestSmallGridData
				{
					Data = questId
				};
			}
			return new SolarSchoolQuestBigGridData
			{
				Data = questId,
				ClickCallback = clickCallback
			};
		}
	}
}
