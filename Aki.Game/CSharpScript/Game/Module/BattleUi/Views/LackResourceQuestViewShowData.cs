using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D7C RID: 23932
	[NullableContext(1)]
	[Nullable(0)]
	public class LackResourceQuestViewShowData : IMissionItemViewShowData
	{
		// Token: 0x17008E42 RID: 36418
		// (get) Token: 0x0603CBE3 RID: 248803 RVA: 0x00E95653 File Offset: 0x00E93853
		public EMissionItemViewDataSource DataSource
		{
			get
			{
				return EMissionItemViewDataSource.LackResourceQuest;
			}
		}

		// Token: 0x17008E43 RID: 36419
		// (get) Token: 0x0603CBE4 RID: 248804 RVA: 0x00E95656 File Offset: 0x00E93856
		// (set) Token: 0x0603CBE5 RID: 248805 RVA: 0x00E9565E File Offset: 0x00E9385E
		public int ShowPriority { get; private set; }

		// Token: 0x17008E44 RID: 36420
		// (get) Token: 0x0603CBE6 RID: 248806 RVA: 0x00E95667 File Offset: 0x00E93867
		public long? ParentId
		{
			get
			{
				return new long?(0L);
			}
		}

		// Token: 0x17008E45 RID: 36421
		// (get) Token: 0x0603CBE7 RID: 248807 RVA: 0x00E95670 File Offset: 0x00E93870
		// (set) Token: 0x0603CBE8 RID: 248808 RVA: 0x00E95678 File Offset: 0x00E93878
		public long Id { get; private set; }

		// Token: 0x17008E46 RID: 36422
		// (get) Token: 0x0603CBE9 RID: 248809 RVA: 0x00E95681 File Offset: 0x00E93881
		// (set) Token: 0x0603CBEA RID: 248810 RVA: 0x00E95689 File Offset: 0x00E93889
		public int TrackIconConfigId { get; private set; }

		// Token: 0x17008E47 RID: 36423
		// (get) Token: 0x0603CBEB RID: 248811 RVA: 0x00E95692 File Offset: 0x00E93892
		// (set) Token: 0x0603CBEC RID: 248812 RVA: 0x00E9569A File Offset: 0x00E9389A
		public string TitleTextKey { get; private set; }

		// Token: 0x17008E48 RID: 36424
		// (get) Token: 0x0603CBED RID: 248813 RVA: 0x00E956A3 File Offset: 0x00E938A3
		// (set) Token: 0x0603CBEE RID: 248814 RVA: 0x00E956AB File Offset: 0x00E938AB
		[Nullable(2)]
		public LackResourceQuestTextInfo MainStepInfo { [NullableContext(2)] get; [NullableContext(2)] private set; }

		// Token: 0x17008E49 RID: 36425
		// (get) Token: 0x0603CBEF RID: 248815 RVA: 0x00E956B4 File Offset: 0x00E938B4
		// (set) Token: 0x0603CBF0 RID: 248816 RVA: 0x00E956BC File Offset: 0x00E938BC
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

		// Token: 0x17008E4A RID: 36426
		// (get) Token: 0x0603CBF1 RID: 248817 RVA: 0x00E956C5 File Offset: 0x00E938C5
		MissionViewStepTextInfoBase IMissionItemViewShowData.MainStepInfo
		{
			get
			{
				return this.MainStepInfo;
			}
		}

		// Token: 0x17008E4B RID: 36427
		// (get) Token: 0x0603CBF2 RID: 248818 RVA: 0x00E956CD File Offset: 0x00E938CD
		IReadOnlyList<MissionViewStepTextInfoBase> IMissionItemViewShowData.SubStepInfos
		{
			get
			{
				return this.SubStepInfos;
			}
		}

		// Token: 0x0603CBF3 RID: 248819 RVA: 0x00E956D5 File Offset: 0x00E938D5
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
