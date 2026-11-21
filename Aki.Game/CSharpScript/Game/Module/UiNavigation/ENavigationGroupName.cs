using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038B2 RID: 14514
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct ENavigationGroupName : IEquatable<ENavigationGroupName>
	{
		// Token: 0x06025A1B RID: 154139 RVA: 0x00A971A3 File Offset: 0x00A953A3
		private ENavigationGroupName(string value)
		{
			this._value = value;
		}

		// Token: 0x06025A1C RID: 154140 RVA: 0x00A971AC File Offset: 0x00A953AC
		public override string ToString()
		{
			return this._value;
		}

		// Token: 0x06025A1D RID: 154141 RVA: 0x00A971B4 File Offset: 0x00A953B4
		public bool Equals(ENavigationGroupName other)
		{
			return this._value == other._value;
		}

		// Token: 0x06025A1E RID: 154142 RVA: 0x00A971C8 File Offset: 0x00A953C8
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

		// Token: 0x06025A1F RID: 154143 RVA: 0x00A971ED File Offset: 0x00A953ED
		public override int GetHashCode()
		{
			string value = this._value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x06025A20 RID: 154144 RVA: 0x00A97200 File Offset: 0x00A95400
		public static bool operator ==(ENavigationGroupName left, ENavigationGroupName right)
		{
			return left.Equals(right);
		}

		// Token: 0x06025A21 RID: 154145 RVA: 0x00A9720A File Offset: 0x00A9540A
		public static bool operator !=(ENavigationGroupName left, ENavigationGroupName right)
		{
			return !left.Equals(right);
		}

		// Token: 0x06025A22 RID: 154146 RVA: 0x00A97217 File Offset: 0x00A95417
		public static implicit operator string(ENavigationGroupName id)
		{
			return id.ToString();
		}

		// Token: 0x04014C5E RID: 85086
		private readonly string _value;

		// Token: 0x04014C5F RID: 85087
		public static readonly ENavigationGroupName NewSoundDetectItemGroup = new ENavigationGroupName("Group3");
	}
}
