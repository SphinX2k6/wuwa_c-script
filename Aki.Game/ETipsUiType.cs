using System;
using System.Runtime.CompilerServices;

// Token: 0x020018E7 RID: 6375
[NullableContext(1)]
[Nullable(0)]
public readonly struct ETipsUiType : IEquatable<ETipsUiType>
{
	// Token: 0x0600BAC5 RID: 47813 RVA: 0x002A4D5A File Offset: 0x002A2F5A
	private ETipsUiType(string value)
	{
		this._Value = value;
	}

	// Token: 0x0600BAC6 RID: 47814 RVA: 0x002A4D63 File Offset: 0x002A2F63
	public override string ToString()
	{
		return this._Value;
	}

	// Token: 0x0600BAC7 RID: 47815 RVA: 0x002A4D6B File Offset: 0x002A2F6B
	public bool Equals(ETipsUiType other)
	{
		return this._Value == other._Value;
	}

	// Token: 0x0600BAC8 RID: 47816 RVA: 0x002A4D80 File Offset: 0x002A2F80
	public override bool Equals(object obj)
	{
		if (obj is ETipsUiType)
		{
			ETipsUiType other = (ETipsUiType)obj;
			return this.Equals(other);
		}
		return false;
	}

	// Token: 0x0600BAC9 RID: 47817 RVA: 0x002A4DA5 File Offset: 0x002A2FA5
	public override int GetHashCode()
	{
		string value = this._Value;
		if (value == null)
		{
			return 0;
		}
		return value.GetHashCode();
	}

	// Token: 0x0600BACA RID: 47818 RVA: 0x002A4DB8 File Offset: 0x002A2FB8
	public static bool operator ==(ETipsUiType left, ETipsUiType right)
	{
		return left.Equals(right);
	}

	// Token: 0x0600BACB RID: 47819 RVA: 0x002A4DC2 File Offset: 0x002A2FC2
	public static bool operator !=(ETipsUiType left, ETipsUiType right)
	{
		return !left.Equals(right);
	}

	// Token: 0x040054D2 RID: 21714
	private readonly string _Value;

	// Token: 0x040054D3 RID: 21715
	public const string ItemTipsComponentValue = "ItemTipsComponent";

	// Token: 0x040054D4 RID: 21716
	public static readonly ETipsUiType ItemTipsComponent = new ETipsUiType("ItemTipsComponent");

	// Token: 0x040054D5 RID: 21717
	public const string PowerTipsItemValue = "PowerTipsItem";

	// Token: 0x040054D6 RID: 21718
	public static readonly ETipsUiType PowerTipsItem = new ETipsUiType("PowerTipsItem");

	// Token: 0x040054D7 RID: 21719
	public const string PersonalCardPreviewComponentValue = "PersonalCardPreviewComponent";

	// Token: 0x040054D8 RID: 21720
	public static readonly ETipsUiType PersonalCardPreviewComponent = new ETipsUiType("PersonalCardPreviewComponent");

	// Token: 0x040054D9 RID: 21721
	public const string PersonalHeadPreviewComponentValue = "PersonalHeadPreviewComponent";

	// Token: 0x040054DA RID: 21722
	public static readonly ETipsUiType PersonalHeadPreviewComponent = new ETipsUiType("PersonalHeadPreviewComponent");

	// Token: 0x040054DB RID: 21723
	public const string PersonalTitlePreviewComponentValue = "PersonalTitlePreviewComponent";

	// Token: 0x040054DC RID: 21724
	public static readonly ETipsUiType PersonalTitlePreviewComponent = new ETipsUiType("PersonalTitlePreviewComponent");

	// Token: 0x040054DD RID: 21725
	public const string HonamiStoryTipsItemValue = "HonamiStoryTipsItem";

	// Token: 0x040054DE RID: 21726
	public static readonly ETipsUiType HonamiStoryTipsItem = new ETipsUiType("HonamiStoryTipsItem");

	// Token: 0x040054DF RID: 21727
	public const string FurnitureTipsItemValue = "FurnitureTipsItem";

	// Token: 0x040054E0 RID: 21728
	public static readonly ETipsUiType FurnitureTipsItem = new ETipsUiType("FurnitureTipsItem");

	// Token: 0x040054E1 RID: 21729
	public const string PinballTipsItemValue = "PinballTipsItem";

	// Token: 0x040054E2 RID: 21730
	public static readonly ETipsUiType PinballTipsItem = new ETipsUiType("PinballTipsItem");
}
