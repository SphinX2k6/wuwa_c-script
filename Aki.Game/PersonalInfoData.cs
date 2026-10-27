using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020023BA RID: 9146
[NullableContext(1)]
[Nullable(0)]
public class PersonalInfoData
{
	// Token: 0x060124AF RID: 74927 RVA: 0x004814FC File Offset: 0x0047F6FC
	public int GetUnlockCardDataCount()
	{
		int num = 0;
		using (List<PersonalCardData>.Enumerator enumerator = this.CardDataList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.IsUnLock)
				{
					num++;
				}
			}
		}
		return num;
	}

	// Token: 0x060124B0 RID: 74928 RVA: 0x00481558 File Offset: 0x0047F758
	public PersonalCardData[] GetCardList(bool needShowLockCard)
	{
		List<PersonalCardData> list = (from cardData in this.CardDataList.ToList<PersonalCardData>()
		where needShowLockCard || cardData.IsUnLock
		select cardData).ToList<PersonalCardData>();
		list.Sort(delegate(PersonalCardData cardDataA, PersonalCardData cardDataB)
		{
			if (cardDataA.IsUnLock != cardDataB.IsUnLock)
			{
				return Convert.ToInt32(cardDataB.IsUnLock) - Convert.ToInt32(cardDataA.IsUnLock);
			}
			BackgroundCard? config = ConfigBackgroundCardById.GetConfig(cardDataA.CardId, true);
			BackgroundCard? config2 = ConfigBackgroundCardById.GetConfig(cardDataB.CardId, true);
			if (config.Value.SortIndex != config2.Value.SortIndex)
			{
				return config2.Value.SortIndex - config.Value.SortIndex;
			}
			return cardDataB.CardId - cardDataA.CardId;
		});
		return list.ToArray();
	}

	// Token: 0x170017BF RID: 6079
	// (get) Token: 0x060124B1 RID: 74929 RVA: 0x004815BD File Offset: 0x0047F7BD
	// (set) Token: 0x060124B2 RID: 74930 RVA: 0x004815C5 File Offset: 0x0047F7C5
	public int Birthday
	{
		get
		{
			return this.BirthdayInternal;
		}
		set
		{
			BirthdayModel.Instance.ResetYear = (int)Math.Floor((double)value / 10000.0);
			this.BirthdayInternal = value % 10000;
			if (value < 10000)
			{
				this.BirthdayInternal = 0;
			}
		}
	}

	// Token: 0x04008A20 RID: 35360
	public List<RoleShowEntry> RoleShowList = new List<RoleShowEntry>();

	// Token: 0x04008A21 RID: 35361
	public List<int> CardShowList = new List<int>();

	// Token: 0x04008A22 RID: 35362
	public int? CurCardId;

	// Token: 0x04008A23 RID: 35363
	private int BirthdayInternal;

	// Token: 0x04008A24 RID: 35364
	public bool IsBirthdayDisplay;

	// Token: 0x04008A25 RID: 35365
	public List<PersonalCardData> CardDataList = new List<PersonalCardData>();

	// Token: 0x04008A26 RID: 35366
	public string Signature = "";

	// Token: 0x04008A27 RID: 35367
	public int? HeadPhotoId;

	// Token: 0x04008A28 RID: 35368
	public bool IsOtherData;

	// Token: 0x04008A29 RID: 35369
	public int Level;

	// Token: 0x04008A2A RID: 35370
	public int WorldLevel;

	// Token: 0x04008A2B RID: 35371
	public string Name = "";

	// Token: 0x04008A2C RID: 35372
	public List<PersonalPlayerTitleData> PlayerTitleDataList = new List<PersonalPlayerTitleData>();

	// Token: 0x04008A2D RID: 35373
	public int? CurPlayerTitleId;

	// Token: 0x04008A2E RID: 35374
	public int? CurPlayerTitleLevel;

	// Token: 0x04008A2F RID: 35375
	public int Sex;

	// Token: 0x04008A30 RID: 35376
	public int PlayerId;

	// Token: 0x04008A31 RID: 35377
	public int LastModifyNameTime;

	// Token: 0x04008A32 RID: 35378
	public string ModifyName = "";

	// Token: 0x04008A33 RID: 35379
	[Nullable(2)]
	public string ThirdUserId;

	// Token: 0x04008A34 RID: 35380
	[Nullable(2)]
	public string ThirdOnlineId;
}
