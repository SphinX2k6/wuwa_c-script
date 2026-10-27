using System;
using Aki.Config;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02005A25 RID: 23077
	public class FlagChallengeBuffData
	{
		// Token: 0x17008BD6 RID: 35798
		// (get) Token: 0x0603A896 RID: 239766 RVA: 0x00DEED1A File Offset: 0x00DECF1A
		// (set) Token: 0x0603A897 RID: 239767 RVA: 0x00DEED22 File Offset: 0x00DECF22
		public bool IsSelected
		{
			get
			{
				return this.IsSelectedIntl;
			}
			set
			{
				this.IsSelectedIntl = value;
			}
		}

		// Token: 0x0603A898 RID: 239768 RVA: 0x00DEED2C File Offset: 0x00DECF2C
		public FlagChallengeBuffData(int id)
		{
			this.Id = id;
			this.Config = FlagChallengeConfig.Instance.GetRoleBuffConfig(id).Value;
			this.EndLevel = this.Config.Level;
		}

		// Token: 0x0603A899 RID: 239769 RVA: 0x00DEED70 File Offset: 0x00DECF70
		public EFlagChallengeBuffStatus GetBuffStatus()
		{
			int activityId = this.Config.ActivityId;
			int level = this.Config.Level;
			int calculatedLevel = FlagChallengeModel.Instance.GetCalculatedLevel(activityId);
			if (calculatedLevel >= level)
			{
				return EFlagChallengeBuffStatus.Active;
			}
			int tempLevel = FlagChallengeModel.Instance.GetTempLevel(activityId);
			if (calculatedLevel + tempLevel >= level)
			{
				return EFlagChallengeBuffStatus.TempActive;
			}
			return EFlagChallengeBuffStatus.NotActive;
		}

		// Token: 0x0603A89A RID: 239770 RVA: 0x00DEEDC4 File Offset: 0x00DECFC4
		public bool IsNotActive()
		{
			return this.GetBuffStatus() == EFlagChallengeBuffStatus.NotActive;
		}

		// Token: 0x0603A89B RID: 239771 RVA: 0x00DEEDCF File Offset: 0x00DECFCF
		public bool IsActive()
		{
			return this.GetBuffStatus() == EFlagChallengeBuffStatus.Active;
		}

		// Token: 0x0603A89C RID: 239772 RVA: 0x00DEEDDA File Offset: 0x00DECFDA
		public bool IsTempActive()
		{
			return this.GetBuffStatus() == EFlagChallengeBuffStatus.TempActive;
		}

		// Token: 0x0603A89D RID: 239773 RVA: 0x00DEEDE5 File Offset: 0x00DECFE5
		public bool IsActiveOrTempActive()
		{
			return this.IsActive() || this.IsTempActive();
		}

		// Token: 0x0603A89E RID: 239774 RVA: 0x00DEEDF7 File Offset: 0x00DECFF7
		public void SetStartLevel(int level)
		{
			this.StartLevel = level;
		}

		// Token: 0x0603A89F RID: 239775 RVA: 0x00DEEE00 File Offset: 0x00DED000
		public int GetStartLevel()
		{
			return this.StartLevel;
		}

		// Token: 0x0603A8A0 RID: 239776 RVA: 0x00DEEE08 File Offset: 0x00DED008
		public int GetEndLevel()
		{
			return this.EndLevel;
		}

		// Token: 0x0603A8A1 RID: 239777 RVA: 0x00DEEE10 File Offset: 0x00DED010
		public void SetIndex(int index)
		{
			this.Index = index;
		}

		// Token: 0x0603A8A2 RID: 239778 RVA: 0x00DEEE19 File Offset: 0x00DED019
		public int GetIndex()
		{
			return this.Index;
		}

		// Token: 0x0401E7BF RID: 124863
		public readonly int Id;

		// Token: 0x0401E7C0 RID: 124864
		public readonly FlagChallengeRoleBuff Config;

		// Token: 0x0401E7C1 RID: 124865
		private int StartLevel;

		// Token: 0x0401E7C2 RID: 124866
		private int EndLevel;

		// Token: 0x0401E7C3 RID: 124867
		private int Index;

		// Token: 0x0401E7C4 RID: 124868
		private bool IsSelectedIntl;
	}
}
