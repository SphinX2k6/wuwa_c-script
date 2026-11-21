using System;

// Token: 0x02001899 RID: 6297
public class PersonalCardData
{
	// Token: 0x0600F953 RID: 63827 RVA: 0x0048E7D1 File Offset: 0x0048C9D1
	public PersonalCardData(int cardId, bool isRead, bool isUnLock)
	{
		this.CardId = cardId;
		this.IsRead = isRead;
		this.IsUnLock = isUnLock;
	}

	// Token: 0x0600F954 RID: 63828 RVA: 0x0048E7EE File Offset: 0x0048C9EE
	public void RefreshData(bool isRead, bool isUnLock)
	{
		this.IsRead = isRead;
		this.IsUnLock = isUnLock;
	}

	// Token: 0x04008B42 RID: 35650
	public int CardId;

	// Token: 0x04008B43 RID: 35651
	public bool IsRead;

	// Token: 0x04008B44 RID: 35652
	public bool IsUnLock;
}
