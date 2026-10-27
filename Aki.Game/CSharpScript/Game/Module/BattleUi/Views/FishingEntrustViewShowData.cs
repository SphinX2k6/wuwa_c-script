using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D7B RID: 23931
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingEntrustViewShowData : IMissionItemViewShowData
	{
		// Token: 0x17008E38 RID: 36408
		// (get) Token: 0x0603CBD1 RID: 248785 RVA: 0x00E95596 File Offset: 0x00E93796
		public EMissionItemViewDataSource DataSource
		{
			get
			{
				return EMissionItemViewDataSource.FishingEntrust;
			}
		}

		// Token: 0x17008E39 RID: 36409
		// (get) Token: 0x0603CBD2 RID: 248786 RVA: 0x00E95599 File Offset: 0x00E93799
		// (set) Token: 0x0603CBD3 RID: 248787 RVA: 0x00E955A1 File Offset: 0x00E937A1
		public int ShowPriority { get; private set; }

		// Token: 0x17008E3A RID: 36410
		// (get) Token: 0x0603CBD4 RID: 248788 RVA: 0x00E955AA File Offset: 0x00E937AA
		public long? ParentId
		{
			get
			{
				return new long?(0L);
			}
		}

		// Token: 0x17008E3B RID: 36411
		// (get) Token: 0x0603CBD5 RID: 248789 RVA: 0x00E955B3 File Offset: 0x00E937B3
		// (set) Token: 0x0603CBD6 RID: 248790 RVA: 0x00E955BB File Offset: 0x00E937BB
		public long Id { get; private set; }

		// Token: 0x17008E3C RID: 36412
		// (get) Token: 0x0603CBD7 RID: 248791 RVA: 0x00E955C4 File Offset: 0x00E937C4
		// (set) Token: 0x0603CBD8 RID: 248792 RVA: 0x00E955CC File Offset: 0x00E937CC
		public int TrackIconConfigId { get; private set; }

		// Token: 0x17008E3D RID: 36413
		// (get) Token: 0x0603CBD9 RID: 248793 RVA: 0x00E955D5 File Offset: 0x00E937D5
		// (set) Token: 0x0603CBDA RID: 248794 RVA: 0x00E955DD File Offset: 0x00E937DD
		public string TitleTextKey { get; private set; }

		// Token: 0x17008E3E RID: 36414
		// (get) Token: 0x0603CBDB RID: 248795 RVA: 0x00E955E6 File Offset: 0x00E937E6
		// (set) Token: 0x0603CBDC RID: 248796 RVA: 0x00E955EE File Offset: 0x00E937EE
		[Nullable(2)]
		public FishingEntrustStepTextInfo MainStepInfo { [NullableContext(2)] get; [NullableContext(2)] private set; }

		// Token: 0x17008E3F RID: 36415
		// (get) Token: 0x0603CBDD RID: 248797 RVA: 0x00E955F7 File Offset: 0x00E937F7
		// (set) Token: 0x0603CBDE RID: 248798 RVA: 0x00E955FF File Offset: 0x00E937FF
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

		// Token: 0x17008E40 RID: 36416
		// (get) Token: 0x0603CBDF RID: 248799 RVA: 0x00E95608 File Offset: 0x00E93808
		MissionViewStepTextInfoBase IMissionItemViewShowData.MainStepInfo
		{
			get
			{
				return this.MainStepInfo;
			}
		}

		// Token: 0x17008E41 RID: 36417
		// (get) Token: 0x0603CBE0 RID: 248800 RVA: 0x00E95610 File Offset: 0x00E93810
		IReadOnlyList<MissionViewStepTextInfoBase> IMissionItemViewShowData.SubStepInfos
		{
			get
			{
				return this.SubStepInfos;
			}
		}

		// Token: 0x0603CBE1 RID: 248801 RVA: 0x00E95618 File Offset: 0x00E93818
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
