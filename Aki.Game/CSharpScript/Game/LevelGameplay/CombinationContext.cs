using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02005B01 RID: 23297
	public class CombinationContext : GeneralContext
	{
		// Token: 0x06039494 RID: 234644 RVA: 0x0100A428 File Offset: 0x01008628
		public CombinationContext()
		{
			this.Type = new EGeneralContextType?(EGeneralContextType.Combination);
		}

		// Token: 0x06039495 RID: 234645 RVA: 0x0100A43D File Offset: 0x0100863D
		public override void Reset()
		{
			this.Contexts = null;
		}

		// Token: 0x06039496 RID: 234646 RVA: 0x0100A448 File Offset: 0x01008648
		[NullableContext(1)]
		public static CombinationContext Create(params GeneralContext[] contexts)
		{
			CombinationContext combinationContext = GeneralContext.GetObj(EGeneralContextType.Combination, null, () => new CombinationContext()) as CombinationContext;
			combinationContext.Contexts = new List<GeneralContext>();
			foreach (GeneralContext generalContext in contexts)
			{
				if (generalContext.Type.GetValueOrDefault() == EGeneralContextType.Combination)
				{
					if ((generalContext as CombinationContext).Contexts != null)
					{
						combinationContext.Contexts.AddRange((generalContext as CombinationContext).Contexts);
					}
				}
				else
				{
					combinationContext.Contexts.Add(generalContext);
				}
			}
			return combinationContext;
		}

		// Token: 0x06039497 RID: 234647 RVA: 0x0100A4F0 File Offset: 0x010086F0
		[return: Nullable(2)]
		public T GetContextByType<T>(EGeneralContextType type) where T : GeneralContext
		{
			if (this.Contexts == null)
			{
				return default(T);
			}
			for (int i = this.Contexts.Count - 1; i >= 0; i--)
			{
				GeneralContext generalContext = this.Contexts[i];
				EGeneralContextType? type2 = generalContext.Type;
				if (type2.GetValueOrDefault() == type & type2 != null)
				{
					return generalContext as T;
				}
			}
			return default(T);
		}

		// Token: 0x0401E2A4 RID: 123556
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<GeneralContext> Contexts;
	}
}
