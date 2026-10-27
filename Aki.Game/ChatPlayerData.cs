using System;
using System.Runtime.CompilerServices;

// Token: 0x02001797 RID: 6039
[NullableContext(1)]
[Nullable(0)]
public class ChatPlayerData
{
	// Token: 0x0600AFFB RID: 45051 RVA: 0x0027BB73 File Offset: 0x00279D73
	public ChatPlayerData(int playerId)
	{
		this.PlayerId = playerId;
	}

	// Token: 0x0600AFFC RID: 45052 RVA: 0x0027BB8D File Offset: 0x00279D8D
	public void SetPlayerId(int playerId)
	{
		this.PlayerId = playerId;
	}

	// Token: 0x0600AFFD RID: 45053 RVA: 0x0027BB96 File Offset: 0x00279D96
	public int GetPlayerId()
	{
		return this.PlayerId;
	}

	// Token: 0x0600AFFE RID: 45054 RVA: 0x0027BB9E File Offset: 0x00279D9E
	public void SetPlayerIcon(int? playerIcon = null)
	{
		this.PlayerIcon = playerIcon.GetValueOrDefault();
	}

	// Token: 0x0600AFFF RID: 45055 RVA: 0x0027BBAD File Offset: 0x00279DAD
	public int GetPlayerIcon()
	{
		return this.PlayerIcon;
	}

	// Token: 0x0600B000 RID: 45056 RVA: 0x0027BBB5 File Offset: 0x00279DB5
	[NullableContext(2)]
	public void SetPlayerName(string playerName = null)
	{
		this.PlayerName = (playerName ?? "");
	}

	// Token: 0x0600B001 RID: 45057 RVA: 0x0027BBC7 File Offset: 0x00279DC7
	public string GetPlayerName()
	{
		return this.PlayerName;
	}

	// Token: 0x0600B002 RID: 45058 RVA: 0x0027BBD0 File Offset: 0x00279DD0
	public void SetPlayerTitle(string playerTitleString)
	{
		if (playerTitleString.Length == 0)
		{
			return;
		}
		string[] array = playerTitleString.Split('_', StringSplitOptions.None);
		this.PlayerTitleId = int.Parse(array[0]);
		int? playerTitleStarLevel = (array.Length == 2) ? new int?(int.Parse(array[1])) : null;
		this.PlayerTitleStarLevel = playerTitleStarLevel;
	}

	// Token: 0x0600B003 RID: 45059 RVA: 0x0027BC24 File Offset: 0x00279E24
	public void SetPlayerTitleId(int? playerTitleId = null)
	{
		this.PlayerTitleId = playerTitleId.GetValueOrDefault();
	}

	// Token: 0x0600B004 RID: 45060 RVA: 0x0027BC33 File Offset: 0x00279E33
	public void SetPlayerTitleExParam(int? playerTitleExParam = null)
	{
		this.PlayerTitleStarLevel = playerTitleExParam;
	}

	// Token: 0x0600B005 RID: 45061 RVA: 0x0027BC3C File Offset: 0x00279E3C
	public int GetPlayerTitleId()
	{
		return this.PlayerTitleId;
	}

	// Token: 0x0600B006 RID: 45062 RVA: 0x0027BC44 File Offset: 0x00279E44
	public int? GetPlayerTitleStarLevel()
	{
		return this.PlayerTitleStarLevel;
	}

	// Token: 0x0600B007 RID: 45063 RVA: 0x0027BC4C File Offset: 0x00279E4C
	public void SetSex(int sex)
	{
		this.PlayerSex = sex;
	}

	// Token: 0x0600B008 RID: 45064 RVA: 0x0027BC55 File Offset: 0x00279E55
	public int GetSex()
	{
		return this.PlayerSex;
	}

	// Token: 0x04004FE9 RID: 20457
	private int PlayerId;

	// Token: 0x04004FEA RID: 20458
	private int PlayerIcon;

	// Token: 0x04004FEB RID: 20459
	private string PlayerName = "";

	// Token: 0x04004FEC RID: 20460
	private int PlayerTitleId;

	// Token: 0x04004FED RID: 20461
	private int? PlayerTitleStarLevel;

	// Token: 0x04004FEE RID: 20462
	private int PlayerSex;
}
