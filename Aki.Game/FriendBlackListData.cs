using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x020010EF RID: 4335
[NullableContext(2)]
[Nullable(0)]
public class FriendBlackListData
{
	// Token: 0x0600AD1A RID: 44314 RVA: 0x003301B0 File Offset: 0x0032E3B0
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

	// Token: 0x170011E0 RID: 4576
	// (get) Token: 0x0600AD1B RID: 44315 RVA: 0x003301FB File Offset: 0x0032E3FB
	// (set) Token: 0x0600AD1C RID: 44316 RVA: 0x00330203 File Offset: 0x0032E403
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

	// Token: 0x040063BA RID: 25530
	private FriendData PlayerData;
}
