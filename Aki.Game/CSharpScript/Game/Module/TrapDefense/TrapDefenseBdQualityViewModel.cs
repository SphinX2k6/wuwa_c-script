using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A2B RID: 14891
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseBdQualityViewModel
	{
		// Token: 0x06026499 RID: 156825 RVA: 0x00AB89B3 File Offset: 0x00AB6BB3
		public static TrapDefenseBdQualityViewModel Create(TrapDefenseModel model)
		{
			return new TrapDefenseBdQualityViewModel
			{
				Model = model
			};
		}

		// Token: 0x0602649A RID: 156826 RVA: 0x00AB89C1 File Offset: 0x00AB6BC1
		private TrapDefenseBdQualityViewModel()
		{
		}

		// Token: 0x0602649B RID: 156827 RVA: 0x00AB89D0 File Offset: 0x00AB6BD0
		public void SetCurSelectBdData(TrapDefenseBdData bdData)
		{
			this.CurSelectBdData = bdData;
		}

		// Token: 0x0602649C RID: 156828 RVA: 0x00AB89D9 File Offset: 0x00AB6BD9
		[NullableContext(2)]
		public void SetCurSelectBdBuffData(TrapDefenseBdBuffData bdBuffData)
		{
			this.CurSelectBdBuffData = bdBuffData;
		}

		// Token: 0x0602649D RID: 156829 RVA: 0x00AB89E2 File Offset: 0x00AB6BE2
		public void SetNewQualityMode(bool isNewQualityMode)
		{
			this.IsNewQualityMode = isNewQualityMode;
		}

		// Token: 0x0602649E RID: 156830 RVA: 0x00AB89EC File Offset: 0x00AB6BEC
		public void SetShowQuality(ETrapDefenseBdBuffQuality? quality)
		{
			this.ShowQuality = (quality ?? this.ShowQuality);
		}

		// Token: 0x0602649F RID: 156831 RVA: 0x00AB8A19 File Offset: 0x00AB6C19
		public void OnViewClose()
		{
			this.CurSelectBdData = null;
			this.CurSelectBdBuffData = null;
		}

		// Token: 0x0401505B RID: 86107
		public TrapDefenseModel Model;

		// Token: 0x0401505C RID: 86108
		[Nullable(2)]
		public TrapDefenseBdData CurSelectBdData;

		// Token: 0x0401505D RID: 86109
		[Nullable(2)]
		public TrapDefenseBdBuffData CurSelectBdBuffData;

		// Token: 0x0401505E RID: 86110
		public bool IsNewQualityMode;

		// Token: 0x0401505F RID: 86111
		public ETrapDefenseBdBuffQuality ShowQuality = ETrapDefenseBdBuffQuality.Gold;
	}
}
