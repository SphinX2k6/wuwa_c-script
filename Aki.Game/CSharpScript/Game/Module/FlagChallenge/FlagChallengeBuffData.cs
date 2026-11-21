using System;
using Aki.Config;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02004A01 RID: 18945
	public class FlagChallengeBuffData
	{
		// Token: 0x17005FA4 RID: 24484
		// (get) Token: 0x0602F7DF RID: 194527 RVA: 0x00D3F29E File Offset: 0x00D3D49E
		// (set) Token: 0x0602F7E0 RID: 194528 RVA: 0x00D3F2A6 File Offset: 0x00D3D4A6
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

		// Token: 0x0602F7E1 RID: 194529 RVA: 0x00D3F2B0 File Offset: 0x00D3D4B0
		public FlagChallengeBuffData(int id)
		{
			this.Id = id;
			this.Config = FlagChallengeConfig.Instance.GetRoleBuffConfig(id).Value;
			this.EndLevel = this.Config.Level;
		}

		// Token: 0x0602F7E2 RID: 194530 RVA: 0x00D3F2F4 File Offset: 0x00D3D4F4
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

		// Token: 0x0602F7E3 RID: 194531 RVA: 0x00D3F348 File Offset: 0x00D3D548
		public bool IsNotActive()
		{
			return this.GetBuffStatus() == EFlagChallengeBuffStatus.NotActive;
		}

		// Token: 0x0602F7E4 RID: 194532 RVA: 0x00D3F353 File Offset: 0x00D3D553
		public bool IsActive()
		{
			return this.GetBuffStatus() == EFlagChallengeBuffStatus.Active;
		}

		// Token: 0x0602F7E5 RID: 194533 RVA: 0x00D3F35E File Offset: 0x00D3D55E
		public bool IsTempActive()
		{
			return this.GetBuffStatus() == EFlagChallengeBuffStatus.TempActive;
		}

		// Token: 0x0602F7E6 RID: 194534 RVA: 0x00D3F369 File Offset: 0x00D3D569
		public bool IsActiveOrTempActive()
		{
			return this.IsActive() || this.IsTempActive();
		}

		// Token: 0x0602F7E7 RID: 194535 RVA: 0x00D3F37B File Offset: 0x00D3D57B
		public void SetStartLevel(int level)
		{
			this.StartLevel = level;
		}

		// Token: 0x0602F7E8 RID: 194536 RVA: 0x00D3F384 File Offset: 0x00D3D584
		public int GetStartLevel()
		{
			return this.StartLevel;
		}

		// Token: 0x0602F7E9 RID: 194537 RVA: 0x00D3F38C File Offset: 0x00D3D58C
		public int GetEndLevel()
		{
			return this.EndLevel;
		}

		// Token: 0x0602F7EA RID: 194538 RVA: 0x00D3F394 File Offset: 0x00D3D594
		public void SetIndex(int index)
		{
			this.Index = index;
		}

		// Token: 0x0602F7EB RID: 194539 RVA: 0x00D3F39D File Offset: 0x00D3D59D
		public int GetIndex()
		{
			return this.Index;
		}

		// Token: 0x04019266 RID: 103014
		public readonly int Id;

		// Token: 0x04019267 RID: 103015
		public readonly FlagChallengeRoleBuff Config;

		// Token: 0x04019268 RID: 103016
		private int StartLevel;

		// Token: 0x04019269 RID: 103017
		private int EndLevel;

		// Token: 0x0401926A RID: 103018
		private int Index;

		// Token: 0x0401926B RID: 103019
		private bool IsSelectedIntl;
	}
}
