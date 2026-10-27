using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x020069A5 RID: 27045
	public class CombinationContext : GeneralContext
	{
		// Token: 0x0604345C RID: 275548 RVA: 0x010661C0 File Offset: 0x010643C0
		public CombinationContext()
		{
			this.Type = new EGeneralContextType?(EGeneralContextType.Combination);
		}

		// Token: 0x0604345D RID: 275549 RVA: 0x010661D5 File Offset: 0x010643D5
		public override void Reset()
		{
			this.Contexts = null;
		}

		// Token: 0x0604345E RID: 275550 RVA: 0x010661E0 File Offset: 0x010643E0
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

		// Token: 0x0604345F RID: 275551 RVA: 0x01066288 File Offset: 0x01064488
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

		// Token: 0x040230BA RID: 143546
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<GeneralContext> Contexts;
	}
}
