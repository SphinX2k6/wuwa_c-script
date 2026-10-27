using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A33 RID: 18995
	[NullableContext(1)]
	[Nullable(0)]
	public class MarkFactory
	{
		// Token: 0x06031528 RID: 202024 RVA: 0x00B7118E File Offset: 0x00B6F38E
		public static TrapMapEntity CreateAndAssembleMark(ITrapDefenseMarkInfo param)
		{
			TrapMapEntity trapMapEntity = MarkFactory.CreateDefaultEntity(param);
			MarkFactory.AssembleMarkComponents(trapMapEntity, param);
			return trapMapEntity;
		}

		// Token: 0x06031529 RID: 202025 RVA: 0x00B711A0 File Offset: 0x00B6F3A0
		private static void AssembleMarkComponents(TrapMapEntity entity, ITrapDefenseMarkInfo param)
		{
			ETrapDefenseMapComponent[] array;
			if (TrapDefenseDefine.markAssembleRegisterMap.TryGetValue(param.MarkType, out array))
			{
				foreach (ETrapDefenseMapComponent componentType in array)
				{
					entity.AddComponent<TrapMapComponentBase>(componentType);
				}
			}
		}

		// Token: 0x0603152A RID: 202026 RVA: 0x00B711DD File Offset: 0x00B6F3DD
		private static TrapMapEntity CreateDefaultEntity(ITrapDefenseMarkInfo param)
		{
			return new TrapMapEntity();
		}
	}
}
