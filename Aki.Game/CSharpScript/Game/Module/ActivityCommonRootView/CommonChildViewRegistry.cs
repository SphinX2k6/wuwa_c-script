using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.SolarSchool;

namespace CSharpScript.Game.Module.ActivityCommonRootView
{
	// Token: 0x02005A89 RID: 23177
	public static class CommonChildViewRegistry
	{
		// Token: 0x06039217 RID: 234007 RVA: 0x010005E0 File Offset: 0x00FFE7E0
		[return: Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})]
		public static ValueTuple<Func<CommonChildViewBase>, string>? TryGetCreateInfo(ECommonChildViewName viewName)
		{
			ValueTuple<Func<CommonChildViewBase>, string> value;
			if (CommonChildViewRegistry.ChildViewCreateInfo.TryGetValue(viewName, out value))
			{
				return new ValueTuple<Func<CommonChildViewBase>, string>?(value);
			}
			return null;
		}

		// Token: 0x0401E0F7 RID: 123127
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			1,
			1
		})]
		[StaticVariableRuleIgnore]
		public static readonly IReadOnlyDictionary<ECommonChildViewName, ValueTuple<Func<CommonChildViewBase>, string>> ChildViewCreateInfo = new Dictionary<ECommonChildViewName, ValueTuple<Func<CommonChildViewBase>, string>>
		{
			{
				ECommonChildViewName.SolarSchoolMain,
				new ValueTuple<Func<CommonChildViewBase>, string>(() => new SolarSchoolMainPanel(), "UiItem_SolarSchoolMain")
			},
			{
				ECommonChildViewName.SolarSchoolLocation,
				new ValueTuple<Func<CommonChildViewBase>, string>(() => new SolarSchoolLocationPanel(), "UiItem_SolarSchoolMainB")
			},
			{
				ECommonChildViewName.SolarSchoolVisualNovel,
				new ValueTuple<Func<CommonChildViewBase>, string>(() => new SolarSchoolVisualNovelView(), "UiItem_SolarSchoolDialogueSpine")
			},
			{
				ECommonChildViewName.SolarSchoolMap,
				new ValueTuple<Func<CommonChildViewBase>, string>(() => new SolarSchoolMapPanel(), "UiItem_SolarSchoolMapMain")
			},
			{
				ECommonChildViewName.SolarSchoolBehaviorExecute,
				new ValueTuple<Func<CommonChildViewBase>, string>(() => new SolarSchoolBehaviorExecutePanel(), "UiItem_SolarSchoolBehavior")
			},
			{
				ECommonChildViewName.SolarSchoolQuest,
				new ValueTuple<Func<CommonChildViewBase>, string>(() => new SolarSchoolQuestView(), "UiItem_SolarSchoolMission")
			}
		};
	}
}
