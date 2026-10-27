using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.SkillInteract
{
	// Token: 0x0200528A RID: 21130
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaSkillInteractFactory
	{
		// Token: 0x0603605F RID: 221279 RVA: 0x00CC8FEC File Offset: 0x00CC71EC
		public static PhantomArenaSkillInteractBase GetSkillInteract(int buffType)
		{
			Func<PhantomArenaSkillInteractBase> func;
			if (PhantomArenaSkillInteractFactory.SkillInteractMap.TryGetValue(buffType, out func))
			{
				return func();
			}
			return new PhantomArenaNormalSkillInteract();
		}

		// Token: 0x06036060 RID: 221280 RVA: 0x00CC9014 File Offset: 0x00CC7214
		public static bool HasSkillInteract(int buffType)
		{
			return PhantomArenaSkillInteractFactory.SkillInteractMap.ContainsKey(buffType);
		}

		// Token: 0x0401C9BD RID: 117181
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<int, Func<PhantomArenaSkillInteractBase>> SkillInteractMap = new Dictionary<int, Func<PhantomArenaSkillInteractBase>>
		{
			{
				2,
				() => new PhantomArenaSelectSkillInteract()
			},
			{
				7,
				() => new PhantomArenaChooseCardSkillInteract()
			},
			{
				21,
				() => new PhantomArenaSelectSkillInteract()
			},
			{
				23,
				() => new PhantomArenaSelectSkillInteract()
			},
			{
				24,
				() => new PhantomArenaSelectSkillInteract()
			},
			{
				25,
				() => new PhantomArenaSelectSkillInteract()
			},
			{
				27,
				() => new PhantomArenaSelectSkillInteract()
			}
		};
	}
}
