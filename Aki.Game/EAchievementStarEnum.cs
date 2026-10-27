using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F17 RID: 3863
[NullableContext(1)]
[Nullable(0)]
public readonly struct EAchievementStarEnum : IEquatable<EAchievementStarEnum>
{
	// Token: 0x0600618F RID: 24975 RVA: 0x001304C4 File Offset: 0x0012E6C4
	private EAchievementStarEnum(string value)
	{
		this._Value = value;
	}

	// Token: 0x06006190 RID: 24976 RVA: 0x001304CD File Offset: 0x0012E6CD
	public override string ToString()
	{
		return this._Value;
	}

	// Token: 0x06006191 RID: 24977 RVA: 0x001304D5 File Offset: 0x0012E6D5
	public bool Equals(EAchievementStarEnum other)
	{
		return this._Value == other._Value;
	}

	// Token: 0x06006192 RID: 24978 RVA: 0x001304E8 File Offset: 0x0012E6E8
	public override bool Equals(object obj)
	{
		if (obj is EAchievementStarEnum)
		{
			EAchievementStarEnum other = (EAchievementStarEnum)obj;
			return this.Equals(other);
		}
		return false;
	}

	// Token: 0x06006193 RID: 24979 RVA: 0x0013050D File Offset: 0x0012E70D
	public override int GetHashCode()
	{
		string value = this._Value;
		if (value == null)
		{
			return 0;
		}
		return value.GetHashCode();
	}

	// Token: 0x06006194 RID: 24980 RVA: 0x00130520 File Offset: 0x0012E720
	public static bool operator ==(EAchievementStarEnum left, EAchievementStarEnum right)
	{
		return left.Equals(right);
	}

	// Token: 0x06006195 RID: 24981 RVA: 0x0013052A File Offset: 0x0012E72A
	public static bool operator !=(EAchievementStarEnum left, EAchievementStarEnum right)
	{
		return !left.Equals(right);
	}

	// Token: 0x04002C5C RID: 11356
	private readonly string _Value;

	// Token: 0x04002C5D RID: 11357
	public static readonly EAchievementStarEnum SingleStar = new EAchievementStarEnum("UiItem_AchvStarA");

	// Token: 0x04002C5E RID: 11358
	public static readonly EAchievementStarEnum DoubleStar = new EAchievementStarEnum("UiItem_AchvStarB");

	// Token: 0x04002C5F RID: 11359
	public static readonly EAchievementStarEnum TripleStar = new EAchievementStarEnum("UiItem_AchvStarC");
}
