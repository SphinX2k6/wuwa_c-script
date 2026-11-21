using System;
using System.Runtime.CompilerServices;

// Token: 0x02000DA0 RID: 3488
[NullableContext(1)]
[Nullable(0)]
public readonly struct ETipsUiType : IEquatable<ETipsUiType>
{
	// Token: 0x06008EAE RID: 36526 RVA: 0x002AF4BB File Offset: 0x002AD6BB
	private ETipsUiType(string value)
	{
		this._Value = value;
	}

	// Token: 0x06008EAF RID: 36527 RVA: 0x002AF4C4 File Offset: 0x002AD6C4
	public override string ToString()
	{
		return this._Value;
	}

	// Token: 0x06008EB0 RID: 36528 RVA: 0x002AF4CC File Offset: 0x002AD6CC
	public bool Equals(ETipsUiType other)
	{
		return this._Value == other._Value;
	}

	// Token: 0x06008EB1 RID: 36529 RVA: 0x002AF4E0 File Offset: 0x002AD6E0
	public override bool Equals(object obj)
	{
		if (obj is ETipsUiType)
		{
			ETipsUiType other = (ETipsUiType)obj;
			return this.Equals(other);
		}
		return false;
	}

	// Token: 0x06008EB2 RID: 36530 RVA: 0x002AF505 File Offset: 0x002AD705
	public override int GetHashCode()
	{
		string value = this._Value;
		if (value == null)
		{
			return 0;
		}
		return value.GetHashCode();
	}

	// Token: 0x06008EB3 RID: 36531 RVA: 0x002AF518 File Offset: 0x002AD718
	public static bool operator ==(ETipsUiType left, ETipsUiType right)
	{
		return left.Equals(right);
	}

	// Token: 0x06008EB4 RID: 36532 RVA: 0x002AF522 File Offset: 0x002AD722
	public static bool operator !=(ETipsUiType left, ETipsUiType right)
	{
		return !left.Equals(right);
	}

	// Token: 0x0400557D RID: 21885
	private readonly string _Value;

	// Token: 0x0400557E RID: 21886
	public const string ItemTipsComponentValue = "ItemTipsComponent";

	// Token: 0x0400557F RID: 21887
	public static readonly ETipsUiType ItemTipsComponent = new ETipsUiType("ItemTipsComponent");

	// Token: 0x04005580 RID: 21888
	public const string PowerTipsItemValue = "PowerTipsItem";

	// Token: 0x04005581 RID: 21889
	public static readonly ETipsUiType PowerTipsItem = new ETipsUiType("PowerTipsItem");

	// Token: 0x04005582 RID: 21890
	public const string PersonalCardPreviewComponentValue = "PersonalCardPreviewComponent";

	// Token: 0x04005583 RID: 21891
	public static readonly ETipsUiType PersonalCardPreviewComponent = new ETipsUiType("PersonalCardPreviewComponent");

	// Token: 0x04005584 RID: 21892
	public const string PersonalHeadPreviewComponentValue = "PersonalHeadPreviewComponent";

	// Token: 0x04005585 RID: 21893
	public static readonly ETipsUiType PersonalHeadPreviewComponent = new ETipsUiType("PersonalHeadPreviewComponent");

	// Token: 0x04005586 RID: 21894
	public const string PersonalTitlePreviewComponentValue = "PersonalTitlePreviewComponent";

	// Token: 0x04005587 RID: 21895
	public static readonly ETipsUiType PersonalTitlePreviewComponent = new ETipsUiType("PersonalTitlePreviewComponent");

	// Token: 0x04005588 RID: 21896
	public const string HonamiStoryTipsItemValue = "HonamiStoryTipsItem";

	// Token: 0x04005589 RID: 21897
	public static readonly ETipsUiType HonamiStoryTipsItem = new ETipsUiType("HonamiStoryTipsItem");

	// Token: 0x0400558A RID: 21898
	public const string FurnitureTipsItemValue = "FurnitureTipsItem";

	// Token: 0x0400558B RID: 21899
	public static readonly ETipsUiType FurnitureTipsItem = new ETipsUiType("FurnitureTipsItem");

	// Token: 0x0400558C RID: 21900
	public const string PinballTipsItemValue = "PinballTipsItem";

	// Token: 0x0400558D RID: 21901
	public static readonly ETipsUiType PinballTipsItem = new ETipsUiType("PinballTipsItem");
}
