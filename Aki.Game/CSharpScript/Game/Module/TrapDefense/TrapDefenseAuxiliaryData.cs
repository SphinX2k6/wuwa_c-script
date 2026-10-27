using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A1E RID: 18974
	public class TrapDefenseAuxiliaryData
	{
		// Token: 0x06031415 RID: 201749 RVA: 0x00B6C7A7 File Offset: 0x00B6A9A7
		[NullableContext(1)]
		public static TrapDefenseAuxiliaryData Create(int id)
		{
			TrapDefenseAuxiliaryData trapDefenseAuxiliaryData = new TrapDefenseAuxiliaryData(id);
			trapDefenseAuxiliaryData.Init();
			return trapDefenseAuxiliaryData;
		}

		// Token: 0x06031416 RID: 201750 RVA: 0x00B6C7B5 File Offset: 0x00B6A9B5
		private TrapDefenseAuxiliaryData(int id)
		{
			this.Id = id;
		}

		// Token: 0x06031417 RID: 201751 RVA: 0x00B6C7C4 File Offset: 0x00B6A9C4
		private void Init()
		{
		}

		// Token: 0x0401A55C RID: 107868
		public int Id;
	}
}
