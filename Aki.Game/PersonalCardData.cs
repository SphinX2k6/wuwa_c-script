using System;

// Token: 0x020023B4 RID: 9140
public class PersonalCardData
{
	// Token: 0x060124A1 RID: 74913 RVA: 0x004812E9 File Offset: 0x0047F4E9
	public PersonalCardData(int cardId, bool isRead, bool isUnLock)
	{
		this.CardId = cardId;
		this.IsRead = isRead;
		this.IsUnLock = isUnLock;
	}

	// Token: 0x060124A2 RID: 74914 RVA: 0x00481306 File Offset: 0x0047F506
	public void RefreshData(bool isRead, bool isUnLock)
	{
		this.IsRead = isRead;
		this.IsUnLock = isUnLock;
	}

	// Token: 0x040089FB RID: 35323
	public int CardId;

	// Token: 0x040089FC RID: 35324
	public bool IsRead;

	// Token: 0x040089FD RID: 35325
	public bool IsUnLock;
}
