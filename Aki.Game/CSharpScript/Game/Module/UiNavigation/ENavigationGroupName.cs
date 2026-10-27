using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200493B RID: 18747
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct ENavigationGroupName : IEquatable<ENavigationGroupName>
	{
		// Token: 0x06030EEE RID: 200430 RVA: 0x00B5C333 File Offset: 0x00B5A533
		private ENavigationGroupName(string value)
		{
			this._value = value;
		}

		// Token: 0x06030EEF RID: 200431 RVA: 0x00B5C33C File Offset: 0x00B5A53C
		public override string ToString()
		{
			return this._value;
		}

		// Token: 0x06030EF0 RID: 200432 RVA: 0x00B5C344 File Offset: 0x00B5A544
		public bool Equals(ENavigationGroupName other)
		{
			return this._value == other._value;
		}

		// Token: 0x06030EF1 RID: 200433 RVA: 0x00B5C358 File Offset: 0x00B5A558
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is ENavigationGroupName)
			{
				ENavigationGroupName other = (ENavigationGroupName)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06030EF2 RID: 200434 RVA: 0x00B5C37D File Offset: 0x00B5A57D
		public override int GetHashCode()
		{
			string value = this._value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x06030EF3 RID: 200435 RVA: 0x00B5C390 File Offset: 0x00B5A590
		public static bool operator ==(ENavigationGroupName left, ENavigationGroupName right)
		{
			return left.Equals(right);
		}

		// Token: 0x06030EF4 RID: 200436 RVA: 0x00B5C39A File Offset: 0x00B5A59A
		public static bool operator !=(ENavigationGroupName left, ENavigationGroupName right)
		{
			return !left.Equals(right);
		}

		// Token: 0x06030EF5 RID: 200437 RVA: 0x00B5C3A7 File Offset: 0x00B5A5A7
		public static implicit operator string(ENavigationGroupName id)
		{
			return id.ToString();
		}

		// Token: 0x0401A3EB RID: 107499
		private readonly string _value;

		// Token: 0x0401A3EC RID: 107500
		public static readonly ENavigationGroupName NewSoundDetectItemGroup = new ENavigationGroupName("Group3");
	}
}
