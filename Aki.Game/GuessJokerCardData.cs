using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020004E0 RID: 1248
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerCardData
{
	// Token: 0x06003DD6 RID: 15830 RVA: 0x0015DAD8 File Offset: 0x0015BCD8
	public GuessJokerCardData(int id)
	{
		this.IdInternal = id;
		JokerDeck value = GuessJokerConfig.Instance.GetJokerDeck(id).Value;
		this.TypeInternal = (EGuessJokerCardType)value.CardType;
		this.ValueInternal = value.CardNumber;
		this.TexturePathInternal = value.TexturePath;
	}

	// Token: 0x06003DD7 RID: 15831 RVA: 0x0015DB38 File Offset: 0x0015BD38
	public void ChangeBlankValue(int cardId)
	{
		if (this.Type != EGuessJokerCardType.Blank || cardId == this.Id || cardId == 0)
		{
			return;
		}
		JokerDeck value = GuessJokerConfig.Instance.GetJokerDeck(cardId).Value;
		this.ValueInternal = value.CardNumber;
		this.TexturePathInternal = value.TexturePath;
		this.HasChangedInternal = true;
		this.IsChangedInternal = true;
		this.ChangeConfig = new JokerDeck?(value);
	}

	// Token: 0x06003DD8 RID: 15832 RVA: 0x0015DBA4 File Offset: 0x0015BDA4
	public bool IsChangedToJoker()
	{
		if (this.Type != EGuessJokerCardType.Blank)
		{
			return false;
		}
		JokerDeck? changeConfig = this.ChangeConfig;
		return changeConfig != null && changeConfig.Value.CardType == 1;
	}

	// Token: 0x06003DD9 RID: 15833 RVA: 0x0015DBE0 File Offset: 0x0015BDE0
	public void SetBelongPlayerType(EGuessJokerPlayerType? belongPlayerType)
	{
		this.BelongType = belongPlayerType;
	}

	// Token: 0x06003DDA RID: 15834 RVA: 0x0015DBE9 File Offset: 0x0015BDE9
	public EGuessJokerPlayerType? GetBelongPlayerType()
	{
		return this.BelongType;
	}

	// Token: 0x06003DDB RID: 15835 RVA: 0x0015DBF1 File Offset: 0x0015BDF1
	public bool IsBlank()
	{
		return this.Type == EGuessJokerCardType.Blank;
	}

	// Token: 0x06003DDC RID: 15836 RVA: 0x0015DBFC File Offset: 0x0015BDFC
	public bool IsJoker()
	{
		return this.Type == EGuessJokerCardType.Joker;
	}

	// Token: 0x06003DDD RID: 15837 RVA: 0x0015DC07 File Offset: 0x0015BE07
	public bool HasChanged()
	{
		return this.HasChangedInternal;
	}

	// Token: 0x06003DDE RID: 15838 RVA: 0x0015DC0F File Offset: 0x0015BE0F
	public bool GetChange()
	{
		bool isChangedInternal = this.IsChangedInternal;
		this.IsChangedInternal = false;
		return isChangedInternal;
	}

	// Token: 0x170008A9 RID: 2217
	// (get) Token: 0x06003DDF RID: 15839 RVA: 0x0015DC1E File Offset: 0x0015BE1E
	public int Id
	{
		get
		{
			return this.IdInternal;
		}
	}

	// Token: 0x170008AA RID: 2218
	// (get) Token: 0x06003DE0 RID: 15840 RVA: 0x0015DC26 File Offset: 0x0015BE26
	public EGuessJokerCardType Type
	{
		get
		{
			return this.TypeInternal;
		}
	}

	// Token: 0x170008AB RID: 2219
	// (get) Token: 0x06003DE1 RID: 15841 RVA: 0x0015DC2E File Offset: 0x0015BE2E
	public int Value
	{
		get
		{
			return this.ValueInternal;
		}
	}

	// Token: 0x170008AC RID: 2220
	// (get) Token: 0x06003DE2 RID: 15842 RVA: 0x0015DC36 File Offset: 0x0015BE36
	public string TexturePath
	{
		get
		{
			return this.TexturePathInternal;
		}
	}

	// Token: 0x0400318F RID: 12687
	private readonly int IdInternal;

	// Token: 0x04003190 RID: 12688
	private int ValueInternal;

	// Token: 0x04003191 RID: 12689
	private string TexturePathInternal = "";

	// Token: 0x04003192 RID: 12690
	private readonly EGuessJokerCardType TypeInternal;

	// Token: 0x04003193 RID: 12691
	private bool HasChangedInternal;

	// Token: 0x04003194 RID: 12692
	private bool IsChangedInternal;

	// Token: 0x04003195 RID: 12693
	private JokerDeck? ChangeConfig;

	// Token: 0x04003196 RID: 12694
	private EGuessJokerPlayerType? BelongType;
}
