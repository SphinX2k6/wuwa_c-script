using System;
using System.Runtime.CompilerServices;

// Token: 0x0200179A RID: 6042
[NullableContext(1)]
[Nullable(0)]
public class PrivateChatRoom : ChatRoom
{
	// Token: 0x0600B01C RID: 45084 RVA: 0x0027C0B2 File Offset: 0x0027A2B2
	public PrivateChatRoom(int targetPlayerId, int configId) : base(EChatRoomType.Private, configId)
	{
		this.TargetPlayerId = targetPlayerId;
	}

	// Token: 0x0600B01D RID: 45085 RVA: 0x0027C0C3 File Offset: 0x0027A2C3
	public FriendData GetFriendData()
	{
		return FriendModel.Instance.GetFriendById(this.TargetPlayerId);
	}

	// Token: 0x0600B01E RID: 45086 RVA: 0x0027C0D5 File Offset: 0x0027A2D5
	public int GetTargetPlayerId()
	{
		return this.TargetPlayerId;
	}

	// Token: 0x0600B01F RID: 45087 RVA: 0x0027C0DD File Offset: 0x0027A2DD
	public override int GetUniqueId()
	{
		return this.TargetPlayerId;
	}

	// Token: 0x0600B020 RID: 45088 RVA: 0x0027C0E5 File Offset: 0x0027A2E5
	public string GetPlayerName()
	{
		FriendData friendData = this.GetFriendData();
		return ((friendData != null) ? friendData.PlayerName : null) ?? "";
	}

	// Token: 0x0600B021 RID: 45089 RVA: 0x0027C102 File Offset: 0x0027A302
	public string GetPlayerRemarks()
	{
		FriendData friendData = this.GetFriendData();
		return ((friendData != null) ? friendData.FriendRemark : null) ?? "";
	}

	// Token: 0x0600B022 RID: 45090 RVA: 0x0027C11F File Offset: 0x0027A31F
	public bool IsOnline()
	{
		FriendData friendData = this.GetFriendData();
		return friendData != null && friendData.PlayerIsOnline;
	}

	// Token: 0x0600B023 RID: 45091 RVA: 0x0027C132 File Offset: 0x0027A332
	public string GetThirdPartyUserId()
	{
		FriendData friendData = this.GetFriendData();
		return ((friendData != null) ? friendData.GetSdkUserId() : null) ?? "";
	}

	// Token: 0x0600B024 RID: 45092 RVA: 0x0027C14F File Offset: 0x0027A34F
	[NullableContext(2)]
	public string GetThirdPartyOnlineId()
	{
		FriendData friendData = this.GetFriendData();
		if (friendData == null)
		{
			return null;
		}
		return friendData.GetSdkOnlineId();
	}

	// Token: 0x0600B025 RID: 45093 RVA: 0x0027C164 File Offset: 0x0027A364
	public bool CanChat()
	{
		FriendModel instance = FriendModel.Instance;
		return !instance.HasBlockedPlayer(this.TargetPlayerId) && instance.HasFriend(this.TargetPlayerId);
	}

	// Token: 0x04005004 RID: 20484
	private readonly int TargetPlayerId;
}
