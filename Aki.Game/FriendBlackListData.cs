using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001C30 RID: 7216
[NullableContext(2)]
[Nullable(0)]
public class FriendBlackListData
{
	// Token: 0x0600D904 RID: 55556 RVA: 0x00324DB0 File Offset: 0x00322FB0
	[NullableContext(1)]
	public UniTask InitializeFriendBlackListData(PlayerDetails blockedPlayer)
	{
		FriendBlackListData.<InitializeFriendBlackListData>d__1 <InitializeFriendBlackListData>d__;
		<InitializeFriendBlackListData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeFriendBlackListData>d__.<>4__this = this;
		<InitializeFriendBlackListData>d__.blockedPlayer = blockedPlayer;
		<InitializeFriendBlackListData>d__.<>1__state = -1;
		<InitializeFriendBlackListData>d__.<>t__builder.Start<FriendBlackListData.<InitializeFriendBlackListData>d__1>(ref <InitializeFriendBlackListData>d__);
		return <InitializeFriendBlackListData>d__.<>t__builder.Task;
	}

	// Token: 0x170011BA RID: 4538
	// (get) Token: 0x0600D905 RID: 55557 RVA: 0x00324DFB File Offset: 0x00322FFB
	// (set) Token: 0x0600D906 RID: 55558 RVA: 0x00324E03 File Offset: 0x00323003
	public FriendData GetBlockedPlayerData
	{
		get
		{
			return this.PlayerData;
		}
		set
		{
			this.PlayerData = value;
		}
	}

	// Token: 0x040062E8 RID: 25320
	private FriendData PlayerData;
}
