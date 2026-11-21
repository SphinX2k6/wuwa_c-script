using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D5D RID: 19805
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingEntrustViewShowData : IMissionItemViewShowData
	{
		// Token: 0x1700620A RID: 25098
		// (get) Token: 0x06031B2D RID: 203565 RVA: 0x00DE5DDE File Offset: 0x00DE3FDE
		public EMissionItemViewDataSource DataSource
		{
			get
			{
				return EMissionItemViewDataSource.FishingEntrust;
			}
		}

		// Token: 0x1700620B RID: 25099
		// (get) Token: 0x06031B2E RID: 203566 RVA: 0x00DE5DE1 File Offset: 0x00DE3FE1
		// (set) Token: 0x06031B2F RID: 203567 RVA: 0x00DE5DE9 File Offset: 0x00DE3FE9
		public int ShowPriority { get; private set; }

		// Token: 0x1700620C RID: 25100
		// (get) Token: 0x06031B30 RID: 203568 RVA: 0x00DE5DF2 File Offset: 0x00DE3FF2
		public long? ParentId
		{
			get
			{
				return new long?(0L);
			}
		}

		// Token: 0x1700620D RID: 25101
		// (get) Token: 0x06031B31 RID: 203569 RVA: 0x00DE5DFB File Offset: 0x00DE3FFB
		// (set) Token: 0x06031B32 RID: 203570 RVA: 0x00DE5E03 File Offset: 0x00DE4003
		public long Id { get; private set; }

		// Token: 0x1700620E RID: 25102
		// (get) Token: 0x06031B33 RID: 203571 RVA: 0x00DE5E0C File Offset: 0x00DE400C
		// (set) Token: 0x06031B34 RID: 203572 RVA: 0x00DE5E14 File Offset: 0x00DE4014
		public int TrackIconConfigId { get; private set; }

		// Token: 0x1700620F RID: 25103
		// (get) Token: 0x06031B35 RID: 203573 RVA: 0x00DE5E1D File Offset: 0x00DE401D
		// (set) Token: 0x06031B36 RID: 203574 RVA: 0x00DE5E25 File Offset: 0x00DE4025
		public string TitleTextKey { get; private set; }

		// Token: 0x17006210 RID: 25104
		// (get) Token: 0x06031B37 RID: 203575 RVA: 0x00DE5E2E File Offset: 0x00DE402E
		// (set) Token: 0x06031B38 RID: 203576 RVA: 0x00DE5E36 File Offset: 0x00DE4036
		[Nullable(2)]
		public FishingEntrustStepTextInfo MainStepInfo { [NullableContext(2)] get; [NullableContext(2)] private set; }

		// Token: 0x17006211 RID: 25105
		// (get) Token: 0x06031B39 RID: 203577 RVA: 0x00DE5E3F File Offset: 0x00DE403F
		// (set) Token: 0x06031B3A RID: 203578 RVA: 0x00DE5E47 File Offset: 0x00DE4047
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<FishingEntrustStepTextInfo> SubStepInfos { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] private set; }

		// Token: 0x17006212 RID: 25106
		// (get) Token: 0x06031B3B RID: 203579 RVA: 0x00DE5E50 File Offset: 0x00DE4050
		MissionViewStepTextInfoBase IMissionItemViewShowData.MainStepInfo
		{
			get
			{
				return this.MainStepInfo;
			}
		}

		// Token: 0x17006213 RID: 25107
		// (get) Token: 0x06031B3C RID: 203580 RVA: 0x00DE5E58 File Offset: 0x00DE4058
		IReadOnlyList<MissionViewStepTextInfoBase> IMissionItemViewShowData.SubStepInfos
		{
			get
			{
				return this.SubStepInfos;
			}
		}

		// Token: 0x06031B3D RID: 203581 RVA: 0x00DE5E60 File Offset: 0x00DE4060
		public static FishingEntrustViewShowData Create(int id, int trackIconConfigId, string titleTextKey, [Nullable(2)] FishingEntrustStepTextInfo mainStepText, [Nullable(new byte[]
		{
			2,
			1
		})] List<FishingEntrustStepTextInfo> subStepTexts)
		{
			return new FishingEntrustViewShowData
			{
				Id = (long)id,
				TrackIconConfigId = trackIconConfigId,
				TitleTextKey = titleTextKey,
				MainStepInfo = mainStepText,
				SubStepInfos = subStepTexts,
				ShowPriority = id
			};
		}
	}
}
