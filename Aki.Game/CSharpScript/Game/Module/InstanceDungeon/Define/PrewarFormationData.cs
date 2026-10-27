using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.InstanceDungeon.Define
{
	// Token: 0x020058E4 RID: 22756
	[NullableContext(1)]
	[Nullable(0)]
	public class PrewarFormationData
	{
		// Token: 0x06039CE0 RID: 236768 RVA: 0x00DBB4B4 File Offset: 0x00DB96B4
		public int GetPlayerId()
		{
			return this.PlayerId;
		}

		// Token: 0x06039CE1 RID: 236769 RVA: 0x00DBB4BC File Offset: 0x00DB96BC
		public void SetPlayerId(int value)
		{
			this.PlayerId = value;
		}

		// Token: 0x06039CE2 RID: 236770 RVA: 0x00DBB4C5 File Offset: 0x00DB96C5
		public int GetConfigId()
		{
			return this.ConfigId;
		}

		// Token: 0x06039CE3 RID: 236771 RVA: 0x00DBB4CD File Offset: 0x00DB96CD
		public void SetConfigId(int value)
		{
			this.ConfigId = value;
		}

		// Token: 0x06039CE4 RID: 236772 RVA: 0x00DBB4D6 File Offset: 0x00DB96D6
		public int GetSkinId()
		{
			return this.SkinId;
		}

		// Token: 0x06039CE5 RID: 236773 RVA: 0x00DBB4DE File Offset: 0x00DB96DE
		public void SetSkinId(int value)
		{
			this.SkinId = value;
		}

		// Token: 0x06039CE6 RID: 236774 RVA: 0x00DBB4E7 File Offset: 0x00DB96E7
		public bool IsEmpty()
		{
			return this.ConfigId == 0;
		}

		// Token: 0x06039CE7 RID: 236775 RVA: 0x00DBB4F4 File Offset: 0x00DB96F4
		public bool IsLeader()
		{
			int playerId = this.PlayerId;
			MatchTeamInfo matchTeamInfo = InstanceDungeonModel.Instance.GetMatchTeamInfo();
			int? num = (matchTeamInfo != null) ? new int?(matchTeamInfo.HostId) : null;
			return playerId == num.GetValueOrDefault() & num != null;
		}

		// Token: 0x06039CE8 RID: 236776 RVA: 0x00DBB53C File Offset: 0x00DB973C
		public bool IsSelf()
		{
			return this.PlayerId == CreatureModel.Instance.GetPlayerId();
		}

		// Token: 0x06039CE9 RID: 236777 RVA: 0x00DBB550 File Offset: 0x00DB9750
		public int GetLevel()
		{
			return this.Level;
		}

		// Token: 0x06039CEA RID: 236778 RVA: 0x00DBB558 File Offset: 0x00DB9758
		public void SetLevel(int value)
		{
			this.Level = value;
		}

		// Token: 0x06039CEB RID: 236779 RVA: 0x00DBB561 File Offset: 0x00DB9761
		public bool GetIsReady()
		{
			return this.IsReady;
		}

		// Token: 0x06039CEC RID: 236780 RVA: 0x00DBB569 File Offset: 0x00DB9769
		public void SetIsReady(bool value)
		{
			this.IsReady = value;
		}

		// Token: 0x06039CED RID: 236781 RVA: 0x00DBB572 File Offset: 0x00DB9772
		public string GetPlayerName()
		{
			return InstanceDungeonModel.Instance.GetMatchTeamName(this.PlayerId) ?? "";
		}

		// Token: 0x06039CEE RID: 236782 RVA: 0x00DBB58D File Offset: 0x00DB978D
		public string GetPlayerOnlineId()
		{
			return InstanceDungeonModel.Instance.GetMatchTeamOnlineId(this.PlayerId) ?? "";
		}

		// Token: 0x06039CEF RID: 236783 RVA: 0x00DBB5A8 File Offset: 0x00DB97A8
		public void SetOnlineNumber(int onlineNumber)
		{
			this.OnlineNumber = onlineNumber;
		}

		// Token: 0x06039CF0 RID: 236784 RVA: 0x00DBB5B1 File Offset: 0x00DB97B1
		public int GetOnlineNumber()
		{
			return this.OnlineNumber;
		}

		// Token: 0x06039CF1 RID: 236785 RVA: 0x00DBB5B9 File Offset: 0x00DB97B9
		public int GetLife()
		{
			return this.Life;
		}

		// Token: 0x06039CF2 RID: 236786 RVA: 0x00DBB5C1 File Offset: 0x00DB97C1
		public void SetLife(int value)
		{
			this.Life = value;
		}

		// Token: 0x06039CF3 RID: 236787 RVA: 0x00DBB5CA File Offset: 0x00DB97CA
		public int GetMaxLife()
		{
			return this.MaxLife;
		}

		// Token: 0x06039CF4 RID: 236788 RVA: 0x00DBB5D2 File Offset: 0x00DB97D2
		public void SetMaxLife(int value)
		{
			this.MaxLife = value;
		}

		// Token: 0x06039CF5 RID: 236789 RVA: 0x00DBB5DB File Offset: 0x00DB97DB
		public int GetIndex()
		{
			return this.Index;
		}

		// Token: 0x06039CF6 RID: 236790 RVA: 0x00DBB5E3 File Offset: 0x00DB97E3
		public void SetIndex(int value)
		{
			this.Index = value;
		}

		// Token: 0x06039CF7 RID: 236791 RVA: 0x00DBB5EC File Offset: 0x00DB97EC
		public int GetMultiSkillBranchId()
		{
			return this.MultiSkillBranchId;
		}

		// Token: 0x06039CF8 RID: 236792 RVA: 0x00DBB5F4 File Offset: 0x00DB97F4
		public void SetMultiSkillBranchId(int value)
		{
			this.MultiSkillBranchId = value;
		}

		// Token: 0x0401E2C9 RID: 123593
		private int PlayerId;

		// Token: 0x0401E2CA RID: 123594
		private int ConfigId;

		// Token: 0x0401E2CB RID: 123595
		private int SkinId;

		// Token: 0x0401E2CC RID: 123596
		private int Level;

		// Token: 0x0401E2CD RID: 123597
		private bool IsReady;

		// Token: 0x0401E2CE RID: 123598
		private int OnlineNumber = -1;

		// Token: 0x0401E2CF RID: 123599
		private int Life;

		// Token: 0x0401E2D0 RID: 123600
		private int MaxLife = 1;

		// Token: 0x0401E2D1 RID: 123601
		private int Index;

		// Token: 0x0401E2D2 RID: 123602
		private int MultiSkillBranchId;
	}
}
