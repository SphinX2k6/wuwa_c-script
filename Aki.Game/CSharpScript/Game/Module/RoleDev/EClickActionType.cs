using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02003C87 RID: 15495
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct EClickActionType : IEquatable<EClickActionType>
	{
		// Token: 0x06027A19 RID: 162329 RVA: 0x00B1A290 File Offset: 0x00B18490
		private EClickActionType(string value)
		{
			this._Value = value;
		}

		// Token: 0x06027A1A RID: 162330 RVA: 0x00B1A299 File Offset: 0x00B18499
		public override string ToString()
		{
			return this._Value;
		}

		// Token: 0x06027A1B RID: 162331 RVA: 0x00B1A2A1 File Offset: 0x00B184A1
		public bool Equals(EClickActionType other)
		{
			return this._Value == other._Value;
		}

		// Token: 0x06027A1C RID: 162332 RVA: 0x00B1A2B4 File Offset: 0x00B184B4
		public override bool Equals(object obj)
		{
			if (obj is EClickActionType)
			{
				EClickActionType other = (EClickActionType)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06027A1D RID: 162333 RVA: 0x00B1A2D9 File Offset: 0x00B184D9
		public override int GetHashCode()
		{
			string value = this._Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x06027A1E RID: 162334 RVA: 0x00B1A2EC File Offset: 0x00B184EC
		public static bool operator ==(EClickActionType left, EClickActionType right)
		{
			return left.Equals(right);
		}

		// Token: 0x06027A1F RID: 162335 RVA: 0x00B1A2F6 File Offset: 0x00B184F6
		public static bool operator !=(EClickActionType left, EClickActionType right)
		{
			return !left.Equals(right);
		}

		// Token: 0x040159F1 RID: 88561
		private readonly string _Value;

		// Token: 0x040159F2 RID: 88562
		public static readonly EClickActionType ItemTips = new EClickActionType("item_tips");

		// Token: 0x040159F3 RID: 88563
		public static readonly EClickActionType MonsterDetail = new EClickActionType("monster_detail");

		// Token: 0x040159F4 RID: 88564
		public static readonly EClickActionType None = new EClickActionType("none");
	}
}
