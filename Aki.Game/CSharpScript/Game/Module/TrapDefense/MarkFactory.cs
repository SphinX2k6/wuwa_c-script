using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039DB RID: 14811
	[NullableContext(1)]
	[Nullable(0)]
	public class MarkFactory
	{
		// Token: 0x060262B8 RID: 156344 RVA: 0x00AB5102 File Offset: 0x00AB3302
		public static TrapMapEntity CreateAndAssembleMark(ITrapDefenseMarkInfo param)
		{
			TrapMapEntity trapMapEntity = MarkFactory.CreateDefaultEntity(param);
			MarkFactory.AssembleMarkComponents(trapMapEntity, param);
			return trapMapEntity;
		}

		// Token: 0x060262B9 RID: 156345 RVA: 0x00AB5114 File Offset: 0x00AB3314
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

		// Token: 0x060262BA RID: 156346 RVA: 0x00AB5151 File Offset: 0x00AB3351
		private static TrapMapEntity CreateDefaultEntity(ITrapDefenseMarkInfo param)
		{
			return new TrapMapEntity();
		}
	}
}
