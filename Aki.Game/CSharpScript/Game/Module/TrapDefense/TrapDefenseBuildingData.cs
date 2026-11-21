using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039CA RID: 14794
	public class TrapDefenseBuildingData
	{
		// Token: 0x060261F3 RID: 156147 RVA: 0x00AB172A File Offset: 0x00AAF92A
		[NullableContext(1)]
		public static TrapDefenseBuildingData Create(int id)
		{
			TrapDefenseBuildingData trapDefenseBuildingData = new TrapDefenseBuildingData(id);
			trapDefenseBuildingData.Init();
			return trapDefenseBuildingData;
		}

		// Token: 0x060261F4 RID: 156148 RVA: 0x00AB1738 File Offset: 0x00AAF938
		private TrapDefenseBuildingData(int id)
		{
			this.Id = id;
		}

		// Token: 0x060261F5 RID: 156149 RVA: 0x00AB1747 File Offset: 0x00AAF947
		private void Init()
		{
		}

		// Token: 0x04014ECC RID: 85708
		public int Id;
	}
}
