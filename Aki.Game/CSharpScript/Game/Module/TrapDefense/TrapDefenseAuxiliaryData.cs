using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039C6 RID: 14790
	public class TrapDefenseAuxiliaryData
	{
		// Token: 0x060261A5 RID: 156069 RVA: 0x00AB07A3 File Offset: 0x00AAE9A3
		[NullableContext(1)]
		public static TrapDefenseAuxiliaryData Create(int id)
		{
			TrapDefenseAuxiliaryData trapDefenseAuxiliaryData = new TrapDefenseAuxiliaryData(id);
			trapDefenseAuxiliaryData.Init();
			return trapDefenseAuxiliaryData;
		}

		// Token: 0x060261A6 RID: 156070 RVA: 0x00AB07B1 File Offset: 0x00AAE9B1
		private TrapDefenseAuxiliaryData(int id)
		{
			this.Id = id;
		}

		// Token: 0x060261A7 RID: 156071 RVA: 0x00AB07C0 File Offset: 0x00AAE9C0
		private void Init()
		{
		}

		// Token: 0x04014EB3 RID: 85683
		public int Id;
	}
}
