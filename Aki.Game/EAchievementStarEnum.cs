using System;
using System.Runtime.CompilerServices;

// Token: 0x020003CC RID: 972
[NullableContext(1)]
[Nullable(0)]
public readonly struct EAchievementStarEnum : IEquatable<EAchievementStarEnum>
{
	// Token: 0x06003527 RID: 13607 RVA: 0x00138DE8 File Offset: 0x00136FE8
	private EAchievementStarEnum(string value)
	{
		this._Value = value;
	}

	// Token: 0x06003528 RID: 13608 RVA: 0x00138DF1 File Offset: 0x00136FF1
	public override string ToString()
	{
		return this._Value;
	}

	// Token: 0x06003529 RID: 13609 RVA: 0x00138DF9 File Offset: 0x00136FF9
	public bool Equals(EAchievementStarEnum other)
	{
		return this._Value == other._Value;
	}

	// Token: 0x0600352A RID: 13610 RVA: 0x00138E0C File Offset: 0x0013700C
	public override bool Equals(object obj)
	{
		if (obj is EAchievementStarEnum)
		{
			EAchievementStarEnum other = (EAchievementStarEnum)obj;
			return this.Equals(other);
		}
		return false;
	}

	// Token: 0x0600352B RID: 13611 RVA: 0x00138E31 File Offset: 0x00137031
	public override int GetHashCode()
	{
		string value = this._Value;
		if (value == null)
		{
			return 0;
		}
		return value.GetHashCode();
	}

	// Token: 0x0600352C RID: 13612 RVA: 0x00138E44 File Offset: 0x00137044
	public static bool operator ==(EAchievementStarEnum left, EAchievementStarEnum right)
	{
		return left.Equals(right);
	}

	// Token: 0x0600352D RID: 13613 RVA: 0x00138E4E File Offset: 0x0013704E
	public static bool operator !=(EAchievementStarEnum left, EAchievementStarEnum right)
	{
		return !left.Equals(right);
	}

	// Token: 0x04002CF5 RID: 11509
	private readonly string _Value;

	// Token: 0x04002CF6 RID: 11510
	public static readonly EAchievementStarEnum SingleStar = new EAchievementStarEnum("UiItem_AchvStarA");

	// Token: 0x04002CF7 RID: 11511
	public static readonly EAchievementStarEnum DoubleStar = new EAchievementStarEnum("UiItem_AchvStarB");

	// Token: 0x04002CF8 RID: 11512
	public static readonly EAchievementStarEnum TripleStar = new EAchievementStarEnum("UiItem_AchvStarC");
}
