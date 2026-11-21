using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.InstanceDungeon.Define
{
	// Token: 0x020048BC RID: 18620
	[NullableContext(1)]
	[Nullable(0)]
	public class PrewarFormationData
	{
		// Token: 0x0602EC03 RID: 191491 RVA: 0x00D0A40C File Offset: 0x00D0860C
		public int GetPlayerId()
		{
			return this.PlayerId;
		}

		// Token: 0x0602EC04 RID: 191492 RVA: 0x00D0A414 File Offset: 0x00D08614
		public void SetPlayerId(int value)
		{
			this.PlayerId = value;
		}

		// Token: 0x0602EC05 RID: 191493 RVA: 0x00D0A41D File Offset: 0x00D0861D
		public int GetConfigId()
		{
			return this.ConfigId;
		}

		// Token: 0x0602EC06 RID: 191494 RVA: 0x00D0A425 File Offset: 0x00D08625
		public void SetConfigId(int value)
		{
			this.ConfigId = value;
		}

		// Token: 0x0602EC07 RID: 191495 RVA: 0x00D0A42E File Offset: 0x00D0862E
		public int GetSkinId()
		{
			return this.SkinId;
		}

		// Token: 0x0602EC08 RID: 191496 RVA: 0x00D0A436 File Offset: 0x00D08636
		public void SetSkinId(int value)
		{
			this.SkinId = value;
		}

		// Token: 0x0602EC09 RID: 191497 RVA: 0x00D0A43F File Offset: 0x00D0863F
		public bool IsEmpty()
		{
			return this.ConfigId == 0;
		}

		// Token: 0x0602EC0A RID: 191498 RVA: 0x00D0A44C File Offset: 0x00D0864C
		public bool IsLeader()
		{
			int playerId = this.PlayerId;
			MatchTeamInfo matchTeamInfo = InstanceDungeonModel.Instance.GetMatchTeamInfo();
			int? num = (matchTeamInfo != null) ? new int?(matchTeamInfo.HostId) : null;
			return playerId == num.GetValueOrDefault() & num != null;
		}

		// Token: 0x0602EC0B RID: 191499 RVA: 0x00D0A494 File Offset: 0x00D08694
		public bool IsSelf()
		{
			return this.PlayerId == CreatureModel.Instance.GetPlayerId();
		}

		// Token: 0x0602EC0C RID: 191500 RVA: 0x00D0A4A8 File Offset: 0x00D086A8
		public int GetLevel()
		{
			return this.Level;
		}

		// Token: 0x0602EC0D RID: 191501 RVA: 0x00D0A4B0 File Offset: 0x00D086B0
		public void SetLevel(int value)
		{
			this.Level = value;
		}

		// Token: 0x0602EC0E RID: 191502 RVA: 0x00D0A4B9 File Offset: 0x00D086B9
		public bool GetIsReady()
		{
			return this.IsReady;
		}

		// Token: 0x0602EC0F RID: 191503 RVA: 0x00D0A4C1 File Offset: 0x00D086C1
		public void SetIsReady(bool value)
		{
			this.IsReady = value;
		}

		// Token: 0x0602EC10 RID: 191504 RVA: 0x00D0A4CA File Offset: 0x00D086CA
		public string GetPlayerName()
		{
			return InstanceDungeonModel.Instance.GetMatchTeamName(this.PlayerId) ?? "";
		}

		// Token: 0x0602EC11 RID: 191505 RVA: 0x00D0A4E5 File Offset: 0x00D086E5
		public string GetPlayerOnlineId()
		{
			return InstanceDungeonModel.Instance.GetMatchTeamOnlineId(this.PlayerId) ?? "";
		}

		// Token: 0x0602EC12 RID: 191506 RVA: 0x00D0A500 File Offset: 0x00D08700
		public void SetOnlineNumber(int onlineNumber)
		{
			this.OnlineNumber = onlineNumber;
		}

		// Token: 0x0602EC13 RID: 191507 RVA: 0x00D0A509 File Offset: 0x00D08709
		public int GetOnlineNumber()
		{
			return this.OnlineNumber;
		}

		// Token: 0x0602EC14 RID: 191508 RVA: 0x00D0A511 File Offset: 0x00D08711
		public int GetLife()
		{
			return this.Life;
		}

		// Token: 0x0602EC15 RID: 191509 RVA: 0x00D0A519 File Offset: 0x00D08719
		public void SetLife(int value)
		{
			this.Life = value;
		}

		// Token: 0x0602EC16 RID: 191510 RVA: 0x00D0A522 File Offset: 0x00D08722
		public int GetMaxLife()
		{
			return this.MaxLife;
		}

		// Token: 0x0602EC17 RID: 191511 RVA: 0x00D0A52A File Offset: 0x00D0872A
		public void SetMaxLife(int value)
		{
			this.MaxLife = value;
		}

		// Token: 0x0602EC18 RID: 191512 RVA: 0x00D0A533 File Offset: 0x00D08733
		public int GetIndex()
		{
			return this.Index;
		}

		// Token: 0x0602EC19 RID: 191513 RVA: 0x00D0A53B File Offset: 0x00D0873B
		public void SetIndex(int value)
		{
			this.Index = value;
		}

		// Token: 0x0602EC1A RID: 191514 RVA: 0x00D0A544 File Offset: 0x00D08744
		public int GetMultiSkillBranchId()
		{
			return this.MultiSkillBranchId;
		}

		// Token: 0x0602EC1B RID: 191515 RVA: 0x00D0A54C File Offset: 0x00D0874C
		public void SetMultiSkillBranchId(int value)
		{
			this.MultiSkillBranchId = value;
		}

		// Token: 0x04018D66 RID: 101734
		private int PlayerId;

		// Token: 0x04018D67 RID: 101735
		private int ConfigId;

		// Token: 0x04018D68 RID: 101736
		private int SkinId;

		// Token: 0x04018D69 RID: 101737
		private int Level;

		// Token: 0x04018D6A RID: 101738
		private bool IsReady;

		// Token: 0x04018D6B RID: 101739
		private int OnlineNumber = -1;

		// Token: 0x04018D6C RID: 101740
		private int Life;

		// Token: 0x04018D6D RID: 101741
		private int MaxLife = 1;

		// Token: 0x04018D6E RID: 101742
		private int Index;

		// Token: 0x04018D6F RID: 101743
		private int MultiSkillBranchId;
	}
}
