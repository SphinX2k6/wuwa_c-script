using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A22 RID: 18978
	public class TrapDefenseBuildingData
	{
		// Token: 0x06031463 RID: 201827 RVA: 0x00B6D72E File Offset: 0x00B6B92E
		[NullableContext(1)]
		public static TrapDefenseBuildingData Create(int id)
		{
			TrapDefenseBuildingData trapDefenseBuildingData = new TrapDefenseBuildingData(id);
			trapDefenseBuildingData.Init();
			return trapDefenseBuildingData;
		}

		// Token: 0x06031464 RID: 201828 RVA: 0x00B6D73C File Offset: 0x00B6B93C
		private TrapDefenseBuildingData(int id)
		{
			this.Id = id;
		}

		// Token: 0x06031465 RID: 201829 RVA: 0x00B6D74B File Offset: 0x00B6B94B
		private void Init()
		{
		}

		// Token: 0x0401A575 RID: 107893
		public int Id;
	}
}
