using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.SkillInteract
{
	// Token: 0x0200425A RID: 16986
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaSkillInteractFactory
	{
		// Token: 0x0602AF5A RID: 175962 RVA: 0x00C166F0 File Offset: 0x00C148F0
		public static PhantomArenaSkillInteractBase GetSkillInteract(int buffType)
		{
			Func<PhantomArenaSkillInteractBase> func;
			if (PhantomArenaSkillInteractFactory.SkillInteractMap.TryGetValue(buffType, out func))
			{
				return func();
			}
			return new PhantomArenaNormalSkillInteract();
		}

		// Token: 0x0602AF5B RID: 175963 RVA: 0x00C16718 File Offset: 0x00C14918
		public static bool HasSkillInteract(int buffType)
		{
			return PhantomArenaSkillInteractFactory.SkillInteractMap.ContainsKey(buffType);
		}

		// Token: 0x040173F2 RID: 95218
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
