using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.LinkedItem;

// Token: 0x0200189F RID: 6303
[NullableContext(1)]
[Nullable(0)]
public class PersonalInfoData
{
	// Token: 0x0600F961 RID: 63841 RVA: 0x0048E9E4 File Offset: 0x0048CBE4
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

	// Token: 0x0600F962 RID: 63842 RVA: 0x0048EA40 File Offset: 0x0048CC40
	public PersonalCardData[] GetCardList(bool needShowLockCard)
	{
		List<PersonalCardData> list = new List<PersonalCardData>(this.CardDataList);
		list.RemoveAll((PersonalCardData cardData) => LinkedItemConfig.Instance.ShouldHide(cardData.CardId, cardData.IsUnLock) || (!needShowLockCard && !cardData.IsUnLock));
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

	// Token: 0x170017F9 RID: 6137
	// (get) Token: 0x0600F963 RID: 63843 RVA: 0x0048EAA2 File Offset: 0x0048CCA2
	// (set) Token: 0x0600F964 RID: 63844 RVA: 0x0048EAAA File Offset: 0x0048CCAA
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

	// Token: 0x04008B67 RID: 35687
	public List<RoleShowEntry> RoleShowList = new List<RoleShowEntry>();

	// Token: 0x04008B68 RID: 35688
	public List<int> CardShowList = new List<int>();

	// Token: 0x04008B69 RID: 35689
	public int? CurCardId;

	// Token: 0x04008B6A RID: 35690
	private int BirthdayInternal;

	// Token: 0x04008B6B RID: 35691
	public bool IsBirthdayDisplay;

	// Token: 0x04008B6C RID: 35692
	public List<PersonalCardData> CardDataList = new List<PersonalCardData>();

	// Token: 0x04008B6D RID: 35693
	public string Signature = "";

	// Token: 0x04008B6E RID: 35694
	public int? HeadPhotoId;

	// Token: 0x04008B6F RID: 35695
	public bool IsOtherData;

	// Token: 0x04008B70 RID: 35696
	public int Level;

	// Token: 0x04008B71 RID: 35697
	public int WorldLevel;

	// Token: 0x04008B72 RID: 35698
	public string Name = "";

	// Token: 0x04008B73 RID: 35699
	public List<PersonalPlayerTitleData> PlayerTitleDataList = new List<PersonalPlayerTitleData>();

	// Token: 0x04008B74 RID: 35700
	public int? CurPlayerTitleId;

	// Token: 0x04008B75 RID: 35701
	public int? CurPlayerTitleLevel;

	// Token: 0x04008B76 RID: 35702
	public int Sex;

	// Token: 0x04008B77 RID: 35703
	public int PlayerId;

	// Token: 0x04008B78 RID: 35704
	public int LastModifyNameTime;

	// Token: 0x04008B79 RID: 35705
	public string ModifyName = "";

	// Token: 0x04008B7A RID: 35706
	[Nullable(2)]
	public string ThirdUserId;

	// Token: 0x04008B7B RID: 35707
	[Nullable(2)]
	public string ThirdOnlineId;
}
