using System;
using System.Runtime.CompilerServices;

// Token: 0x02000C53 RID: 3155
[NullableContext(1)]
[Nullable(0)]
public class PrivateChatRoom : ChatRoom
{
	// Token: 0x06008404 RID: 33796 RVA: 0x002865CE File Offset: 0x002847CE
	public PrivateChatRoom(int targetPlayerId, int configId) : base(EChatRoomType.Private, configId)
	{
		this.TargetPlayerId = targetPlayerId;
	}

	// Token: 0x06008405 RID: 33797 RVA: 0x002865DF File Offset: 0x002847DF
	public FriendData GetFriendData()
	{
		return FriendModel.Instance.GetFriendById(this.TargetPlayerId);
	}

	// Token: 0x06008406 RID: 33798 RVA: 0x002865F1 File Offset: 0x002847F1
	public int GetTargetPlayerId()
	{
		return this.TargetPlayerId;
	}

	// Token: 0x06008407 RID: 33799 RVA: 0x002865F9 File Offset: 0x002847F9
	public override int GetUniqueId()
	{
		return this.TargetPlayerId;
	}

	// Token: 0x06008408 RID: 33800 RVA: 0x00286601 File Offset: 0x00284801
	public string GetPlayerName()
	{
		FriendData friendData = this.GetFriendData();
		return ((friendData != null) ? friendData.PlayerName : null) ?? "";
	}

	// Token: 0x06008409 RID: 33801 RVA: 0x0028661E File Offset: 0x0028481E
	public string GetPlayerRemarks()
	{
		FriendData friendData = this.GetFriendData();
		return ((friendData != null) ? friendData.FriendRemark : null) ?? "";
	}

	// Token: 0x0600840A RID: 33802 RVA: 0x0028663B File Offset: 0x0028483B
	public bool IsOnline()
	{
		FriendData friendData = this.GetFriendData();
		return friendData != null && friendData.PlayerIsOnline;
	}

	// Token: 0x0600840B RID: 33803 RVA: 0x0028664E File Offset: 0x0028484E
	public string GetThirdPartyUserId()
	{
		FriendData friendData = this.GetFriendData();
		return ((friendData != null) ? friendData.GetSdkUserId() : null) ?? "";
	}

	// Token: 0x0600840C RID: 33804 RVA: 0x0028666B File Offset: 0x0028486B
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

	// Token: 0x0600840D RID: 33805 RVA: 0x00286680 File Offset: 0x00284880
	public bool CanChat()
	{
		FriendModel instance = FriendModel.Instance;
		return !instance.HasBlockedPlayer(this.TargetPlayerId) && instance.HasFriend(this.TargetPlayerId);
	}

	// Token: 0x040050AE RID: 20654
	private readonly int TargetPlayerId;
}
