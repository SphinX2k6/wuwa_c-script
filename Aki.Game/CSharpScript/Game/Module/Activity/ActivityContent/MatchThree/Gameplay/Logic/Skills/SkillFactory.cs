using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic.Skills
{
	// Token: 0x02005483 RID: 21635
	public static class SkillFactory
	{
		// Token: 0x06035B5E RID: 219998 RVA: 0x00F024DC File Offset: 0x00F006DC
		[NullableContext(2)]
		public static ISkill Create(in MatchThreeSkill cfg)
		{
			MatchThreeSkill matchThreeSkill = cfg;
			switch (matchThreeSkill.Type)
			{
			case 1:
				return new AllureSmallSkill(cfg);
			case 2:
				return new AllureBigSkill(cfg);
			case 3:
			case 4:
				return new ChainSkill(cfg);
			default:
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MatchThree;
				ELogAuthor author = ELogAuthor.CB;
				string message = "未知技能类型";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
				string item = "Type";
				matchThreeSkill = cfg;
				ptr = new ValueTuple<string, object>(item, matchThreeSkill.Type);
				ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
				string item2 = "Id";
				matchThreeSkill = cfg;
				ptr2 = new ValueTuple<string, object>(item2, matchThreeSkill.Id);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return null;
			}
			}
		}
	}
}
