using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x0200593A RID: 22842
	[NullableContext(2)]
	[Nullable(0)]
	public class SolarSchoolScratchTicketRoundData
	{
		// Token: 0x17006BDA RID: 27610
		// (get) Token: 0x060384AE RID: 230574 RVA: 0x00FBD741 File Offset: 0x00FBB941
		// (set) Token: 0x060384AF RID: 230575 RVA: 0x00FBD749 File Offset: 0x00FBB949
		public int CurrentRoundId { get; private set; }

		// Token: 0x17006BDB RID: 27611
		// (get) Token: 0x060384B0 RID: 230576 RVA: 0x00FBD752 File Offset: 0x00FBB952
		// (set) Token: 0x060384B1 RID: 230577 RVA: 0x00FBD75A File Offset: 0x00FBB95A
		public SolarSchoolScratchTicketData Data { get; private set; }

		// Token: 0x060384B2 RID: 230578 RVA: 0x00FBD763 File Offset: 0x00FBB963
		public SolarSchoolScratchTicketData GetCurrentData(int startRoundId = 1)
		{
			if (this.Data == null)
			{
				this.LoadRound(startRoundId);
			}
			else if (this.Data.IsFinish)
			{
				this.AdvanceToNextRound();
			}
			return this.Data;
		}

		// Token: 0x060384B3 RID: 230579 RVA: 0x00FBD794 File Offset: 0x00FBB994
		public bool AdvanceToNextRound()
		{
			if (this.Data == null)
			{
				Log.Instance.Error(ELogModule.SolarSchool, ELogAuthor.HHJ, "[SolarSchool][ScratchTicket] 推进下一轮失败：当前无进度", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			return this.LoadRound(this.CurrentRoundId + 1);
		}

		// Token: 0x060384B4 RID: 230580 RVA: 0x00FBD7D8 File Offset: 0x00FBB9D8
		public void Clear()
		{
			this.CurrentRoundId = 0;
			this.Data = null;
		}

		// Token: 0x060384B5 RID: 230581 RVA: 0x00FBD7E8 File Offset: 0x00FBB9E8
		private bool LoadRound(int roundId)
		{
			SolarSchoolScratchTicketData solarSchoolScratchTicketData = this.BuildRoundData(roundId);
			if (solarSchoolScratchTicketData == null)
			{
				return false;
			}
			this.CurrentRoundId = roundId;
			this.Data = solarSchoolScratchTicketData;
			return true;
		}

		// Token: 0x060384B6 RID: 230582 RVA: 0x00FBD814 File Offset: 0x00FBBA14
		private SolarSchoolScratchTicketData BuildRoundData(int roundId)
		{
			SolarSchoolScratchTicketCo? scratchTicket = SolarSchoolConfig.Instance.GetScratchTicket(roundId);
			if (scratchTicket == null)
			{
				return null;
			}
			IReadOnlyList<SolarSchoolScratchTicketRe> scratchTicketRewardList = SolarSchoolConfig.Instance.GetScratchTicketRewardList(roundId);
			SolarSchoolScratchTicketData solarSchoolScratchTicketData = new SolarSchoolScratchTicketData();
			if (!solarSchoolScratchTicketData.Init(scratchTicket.Value, scratchTicketRewardList))
			{
				return null;
			}
			return solarSchoolScratchTicketData;
		}
	}
}
