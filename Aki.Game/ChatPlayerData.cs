using System;
using System.Runtime.CompilerServices;

// Token: 0x02000C50 RID: 3152
[NullableContext(1)]
[Nullable(0)]
public class ChatPlayerData
{
	// Token: 0x060083E3 RID: 33763 RVA: 0x00286013 File Offset: 0x00284213
	public ChatPlayerData(int playerId)
	{
		this.PlayerId = playerId;
	}

	// Token: 0x060083E4 RID: 33764 RVA: 0x0028602D File Offset: 0x0028422D
	public void SetPlayerId(int playerId)
	{
		this.PlayerId = playerId;
	}

	// Token: 0x060083E5 RID: 33765 RVA: 0x00286036 File Offset: 0x00284236
	public int GetPlayerId()
	{
		return this.PlayerId;
	}

	// Token: 0x060083E6 RID: 33766 RVA: 0x0028603E File Offset: 0x0028423E
	public void SetPlayerIcon(int? playerIcon = null)
	{
		this.PlayerIcon = playerIcon.GetValueOrDefault();
	}

	// Token: 0x060083E7 RID: 33767 RVA: 0x0028604D File Offset: 0x0028424D
	public int GetPlayerIcon()
	{
		return this.PlayerIcon;
	}

	// Token: 0x060083E8 RID: 33768 RVA: 0x00286055 File Offset: 0x00284255
	[NullableContext(2)]
	public void SetPlayerName(string playerName = null)
	{
		this.PlayerName = (playerName ?? "");
	}

	// Token: 0x060083E9 RID: 33769 RVA: 0x00286067 File Offset: 0x00284267
	public string GetPlayerName()
	{
		return this.PlayerName;
	}

	// Token: 0x060083EA RID: 33770 RVA: 0x00286070 File Offset: 0x00284270
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

	// Token: 0x060083EB RID: 33771 RVA: 0x002860C4 File Offset: 0x002842C4
	public void SetPlayerTitleId(int? playerTitleId = null)
	{
		this.PlayerTitleId = playerTitleId.GetValueOrDefault();
	}

	// Token: 0x060083EC RID: 33772 RVA: 0x002860D3 File Offset: 0x002842D3
	public void SetPlayerTitleExParam(int? playerTitleExParam = null)
	{
		this.PlayerTitleStarLevel = playerTitleExParam;
	}

	// Token: 0x060083ED RID: 33773 RVA: 0x002860DC File Offset: 0x002842DC
	public int GetPlayerTitleId()
	{
		return this.PlayerTitleId;
	}

	// Token: 0x060083EE RID: 33774 RVA: 0x002860E4 File Offset: 0x002842E4
	public int? GetPlayerTitleStarLevel()
	{
		return this.PlayerTitleStarLevel;
	}

	// Token: 0x060083EF RID: 33775 RVA: 0x002860EC File Offset: 0x002842EC
	public void SetSex(int sex)
	{
		this.PlayerSex = sex;
	}

	// Token: 0x060083F0 RID: 33776 RVA: 0x002860F5 File Offset: 0x002842F5
	public int GetSex()
	{
		return this.PlayerSex;
	}

	// Token: 0x04005093 RID: 20627
	private int PlayerId;

	// Token: 0x04005094 RID: 20628
	private int PlayerIcon;

	// Token: 0x04005095 RID: 20629
	private string PlayerName = "";

	// Token: 0x04005096 RID: 20630
	private int PlayerTitleId;

	// Token: 0x04005097 RID: 20631
	private int? PlayerTitleStarLevel;

	// Token: 0x04005098 RID: 20632
	private int PlayerSex;
}
