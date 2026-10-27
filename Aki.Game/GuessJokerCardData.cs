using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200102C RID: 4140
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerCardData
{
	// Token: 0x06006A41 RID: 27201 RVA: 0x001551B0 File Offset: 0x001533B0
	public GuessJokerCardData(int id)
	{
		this.IdInternal = id;
		JokerDeck value = GuessJokerConfig.Instance.GetJokerDeck(id).Value;
		this.TypeInternal = (EGuessJokerCardType)value.CardType;
		this.ValueInternal = value.CardNumber;
		this.TexturePathInternal = value.TexturePath;
	}

	// Token: 0x06006A42 RID: 27202 RVA: 0x00155210 File Offset: 0x00153410
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

	// Token: 0x06006A43 RID: 27203 RVA: 0x0015527C File Offset: 0x0015347C
	public bool IsChangedToJoker()
	{
		if (this.Type != EGuessJokerCardType.Blank)
		{
			return false;
		}
		JokerDeck? changeConfig = this.ChangeConfig;
		return changeConfig != null && changeConfig.Value.CardType == 1;
	}

	// Token: 0x06006A44 RID: 27204 RVA: 0x001552B8 File Offset: 0x001534B8
	public void SetBelongPlayerType(EGuessJokerPlayerType? belongPlayerType)
	{
		this.BelongType = belongPlayerType;
	}

	// Token: 0x06006A45 RID: 27205 RVA: 0x001552C1 File Offset: 0x001534C1
	public EGuessJokerPlayerType? GetBelongPlayerType()
	{
		return this.BelongType;
	}

	// Token: 0x06006A46 RID: 27206 RVA: 0x001552C9 File Offset: 0x001534C9
	public bool IsBlank()
	{
		return this.Type == EGuessJokerCardType.Blank;
	}

	// Token: 0x06006A47 RID: 27207 RVA: 0x001552D4 File Offset: 0x001534D4
	public bool IsJoker()
	{
		return this.Type == EGuessJokerCardType.Joker;
	}

	// Token: 0x06006A48 RID: 27208 RVA: 0x001552DF File Offset: 0x001534DF
	public bool HasChanged()
	{
		return this.HasChangedInternal;
	}

	// Token: 0x06006A49 RID: 27209 RVA: 0x001552E7 File Offset: 0x001534E7
	public bool GetChange()
	{
		bool isChangedInternal = this.IsChangedInternal;
		this.IsChangedInternal = false;
		return isChangedInternal;
	}

	// Token: 0x17000889 RID: 2185
	// (get) Token: 0x06006A4A RID: 27210 RVA: 0x001552F6 File Offset: 0x001534F6
	public int Id
	{
		get
		{
			return this.IdInternal;
		}
	}

	// Token: 0x1700088A RID: 2186
	// (get) Token: 0x06006A4B RID: 27211 RVA: 0x001552FE File Offset: 0x001534FE
	public EGuessJokerCardType Type
	{
		get
		{
			return this.TypeInternal;
		}
	}

	// Token: 0x1700088B RID: 2187
	// (get) Token: 0x06006A4C RID: 27212 RVA: 0x00155306 File Offset: 0x00153506
	public int Value
	{
		get
		{
			return this.ValueInternal;
		}
	}

	// Token: 0x1700088C RID: 2188
	// (get) Token: 0x06006A4D RID: 27213 RVA: 0x0015530E File Offset: 0x0015350E
	public string TexturePath
	{
		get
		{
			return this.TexturePathInternal;
		}
	}

	// Token: 0x040030F6 RID: 12534
	private readonly int IdInternal;

	// Token: 0x040030F7 RID: 12535
	private int ValueInternal;

	// Token: 0x040030F8 RID: 12536
	private string TexturePathInternal = "";

	// Token: 0x040030F9 RID: 12537
	private readonly EGuessJokerCardType TypeInternal;

	// Token: 0x040030FA RID: 12538
	private bool HasChangedInternal;

	// Token: 0x040030FB RID: 12539
	private bool IsChangedInternal;

	// Token: 0x040030FC RID: 12540
	private JokerDeck? ChangeConfig;

	// Token: 0x040030FD RID: 12541
	private EGuessJokerPlayerType? BelongType;
}
