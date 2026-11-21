using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D5E RID: 19806
	[NullableContext(1)]
	[Nullable(0)]
	public class LackResourceQuestViewShowData : IMissionItemViewShowData
	{
		// Token: 0x17006214 RID: 25108
		// (get) Token: 0x06031B3F RID: 203583 RVA: 0x00DE5E9B File Offset: 0x00DE409B
		public EMissionItemViewDataSource DataSource
		{
			get
			{
				return EMissionItemViewDataSource.LackResourceQuest;
			}
		}

		// Token: 0x17006215 RID: 25109
		// (get) Token: 0x06031B40 RID: 203584 RVA: 0x00DE5E9E File Offset: 0x00DE409E
		// (set) Token: 0x06031B41 RID: 203585 RVA: 0x00DE5EA6 File Offset: 0x00DE40A6
		public int ShowPriority { get; private set; }

		// Token: 0x17006216 RID: 25110
		// (get) Token: 0x06031B42 RID: 203586 RVA: 0x00DE5EAF File Offset: 0x00DE40AF
		public long? ParentId
		{
			get
			{
				return new long?(0L);
			}
		}

		// Token: 0x17006217 RID: 25111
		// (get) Token: 0x06031B43 RID: 203587 RVA: 0x00DE5EB8 File Offset: 0x00DE40B8
		// (set) Token: 0x06031B44 RID: 203588 RVA: 0x00DE5EC0 File Offset: 0x00DE40C0
		public long Id { get; private set; }

		// Token: 0x17006218 RID: 25112
		// (get) Token: 0x06031B45 RID: 203589 RVA: 0x00DE5EC9 File Offset: 0x00DE40C9
		// (set) Token: 0x06031B46 RID: 203590 RVA: 0x00DE5ED1 File Offset: 0x00DE40D1
		public int TrackIconConfigId { get; private set; }

		// Token: 0x17006219 RID: 25113
		// (get) Token: 0x06031B47 RID: 203591 RVA: 0x00DE5EDA File Offset: 0x00DE40DA
		// (set) Token: 0x06031B48 RID: 203592 RVA: 0x00DE5EE2 File Offset: 0x00DE40E2
		public string TitleTextKey { get; private set; }

		// Token: 0x1700621A RID: 25114
		// (get) Token: 0x06031B49 RID: 203593 RVA: 0x00DE5EEB File Offset: 0x00DE40EB
		// (set) Token: 0x06031B4A RID: 203594 RVA: 0x00DE5EF3 File Offset: 0x00DE40F3
		[Nullable(2)]
		public LackResourceQuestTextInfo MainStepInfo { [NullableContext(2)] get; [NullableContext(2)] private set; }

		// Token: 0x1700621B RID: 25115
		// (get) Token: 0x06031B4B RID: 203595 RVA: 0x00DE5EFC File Offset: 0x00DE40FC
		// (set) Token: 0x06031B4C RID: 203596 RVA: 0x00DE5F04 File Offset: 0x00DE4104
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<LackResourceQuestTextInfo> SubStepInfos { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] private set; }

		// Token: 0x1700621C RID: 25116
		// (get) Token: 0x06031B4D RID: 203597 RVA: 0x00DE5F0D File Offset: 0x00DE410D
		MissionViewStepTextInfoBase IMissionItemViewShowData.MainStepInfo
		{
			get
			{
				return this.MainStepInfo;
			}
		}

		// Token: 0x1700621D RID: 25117
		// (get) Token: 0x06031B4E RID: 203598 RVA: 0x00DE5F15 File Offset: 0x00DE4115
		IReadOnlyList<MissionViewStepTextInfoBase> IMissionItemViewShowData.SubStepInfos
		{
			get
			{
				return this.SubStepInfos;
			}
		}

		// Token: 0x06031B4F RID: 203599 RVA: 0x00DE5F1D File Offset: 0x00DE411D
		public static LackResourceQuestViewShowData Create(int id, int trackIconConfigId, string titleTextKey, [Nullable(2)] LackResourceQuestTextInfo mainStepText, [Nullable(new byte[]
		{
			2,
			1
		})] List<LackResourceQuestTextInfo> subStepTexts)
		{
			return new LackResourceQuestViewShowData
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
