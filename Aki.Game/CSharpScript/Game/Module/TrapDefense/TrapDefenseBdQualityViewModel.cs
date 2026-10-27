using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A83 RID: 19075
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseBdQualityViewModel
	{
		// Token: 0x06031709 RID: 202505 RVA: 0x00B74A2F File Offset: 0x00B72C2F
		public static TrapDefenseBdQualityViewModel Create(TrapDefenseModel model)
		{
			return new TrapDefenseBdQualityViewModel
			{
				Model = model
			};
		}

		// Token: 0x0603170A RID: 202506 RVA: 0x00B74A3D File Offset: 0x00B72C3D
		private TrapDefenseBdQualityViewModel()
		{
		}

		// Token: 0x0603170B RID: 202507 RVA: 0x00B74A4C File Offset: 0x00B72C4C
		public void SetCurSelectBdData(TrapDefenseBdData bdData)
		{
			this.CurSelectBdData = bdData;
		}

		// Token: 0x0603170C RID: 202508 RVA: 0x00B74A55 File Offset: 0x00B72C55
		[NullableContext(2)]
		public void SetCurSelectBdBuffData(TrapDefenseBdBuffData bdBuffData)
		{
			this.CurSelectBdBuffData = bdBuffData;
		}

		// Token: 0x0603170D RID: 202509 RVA: 0x00B74A5E File Offset: 0x00B72C5E
		public void SetNewQualityMode(bool isNewQualityMode)
		{
			this.IsNewQualityMode = isNewQualityMode;
		}

		// Token: 0x0603170E RID: 202510 RVA: 0x00B74A68 File Offset: 0x00B72C68
		public void SetShowQuality(ETrapDefenseBdBuffQuality? quality)
		{
			this.ShowQuality = (quality ?? this.ShowQuality);
		}

		// Token: 0x0603170F RID: 202511 RVA: 0x00B74A95 File Offset: 0x00B72C95
		public void OnViewClose()
		{
			this.CurSelectBdData = null;
			this.CurSelectBdBuffData = null;
		}

		// Token: 0x0401A709 RID: 108297
		public TrapDefenseModel Model;

		// Token: 0x0401A70A RID: 108298
		[Nullable(2)]
		public TrapDefenseBdData CurSelectBdData;

		// Token: 0x0401A70B RID: 108299
		[Nullable(2)]
		public TrapDefenseBdBuffData CurSelectBdBuffData;

		// Token: 0x0401A70C RID: 108300
		public bool IsNewQualityMode;

		// Token: 0x0401A70D RID: 108301
		public ETrapDefenseBdBuffQuality ShowQuality = ETrapDefenseBdBuffQuality.Gold;
	}
}
