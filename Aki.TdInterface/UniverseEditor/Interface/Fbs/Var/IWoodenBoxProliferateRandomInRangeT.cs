using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F35 RID: 16181
	public class IWoodenBoxProliferateRandomInRangeT
	{
		// Token: 0x17006D9D RID: 28061
		// (get) Token: 0x06016015 RID: 90133 RVA: 0x0032961E File Offset: 0x0032781E
		// (set) Token: 0x06016016 RID: 90134 RVA: 0x00329626 File Offset: 0x00327826
		public EWoodenBoxProliferateSpawnType Type { get; set; }

		// Token: 0x17006D9E RID: 28062
		// (get) Token: 0x06016017 RID: 90135 RVA: 0x0032962F File Offset: 0x0032782F
		// (set) Token: 0x06016018 RID: 90136 RVA: 0x00329637 File Offset: 0x00327837
		public float RangeRadius { get; set; }

		// Token: 0x17006D9F RID: 28063
		// (get) Token: 0x06016019 RID: 90137 RVA: 0x00329640 File Offset: 0x00327840
		// (set) Token: 0x0601601A RID: 90138 RVA: 0x00329648 File Offset: 0x00327848
		public int Count { get; set; }

		// Token: 0x0601601B RID: 90139 RVA: 0x00329651 File Offset: 0x00327851
		public IWoodenBoxProliferateRandomInRangeT()
		{
			this.Type = EWoodenBoxProliferateSpawnType.RandomInRange;
			this.RangeRadius = 0f;
			this.Count = 0;
		}
	}
}
