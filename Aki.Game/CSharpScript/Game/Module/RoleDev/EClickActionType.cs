using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02004CD6 RID: 19670
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct EClickActionType : IEquatable<EClickActionType>
	{
		// Token: 0x06032C65 RID: 207973 RVA: 0x00BD54F8 File Offset: 0x00BD36F8
		private EClickActionType(string value)
		{
			this._Value = value;
		}

		// Token: 0x06032C66 RID: 207974 RVA: 0x00BD5501 File Offset: 0x00BD3701
		public override string ToString()
		{
			return this._Value;
		}

		// Token: 0x06032C67 RID: 207975 RVA: 0x00BD5509 File Offset: 0x00BD3709
		public bool Equals(EClickActionType other)
		{
			return this._Value == other._Value;
		}

		// Token: 0x06032C68 RID: 207976 RVA: 0x00BD551C File Offset: 0x00BD371C
		public override bool Equals(object obj)
		{
			if (obj is EClickActionType)
			{
				EClickActionType other = (EClickActionType)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06032C69 RID: 207977 RVA: 0x00BD5541 File Offset: 0x00BD3741
		public override int GetHashCode()
		{
			string value = this._Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x06032C6A RID: 207978 RVA: 0x00BD5554 File Offset: 0x00BD3754
		public static bool operator ==(EClickActionType left, EClickActionType right)
		{
			return left.Equals(right);
		}

		// Token: 0x06032C6B RID: 207979 RVA: 0x00BD555E File Offset: 0x00BD375E
		public static bool operator !=(EClickActionType left, EClickActionType right)
		{
			return !left.Equals(right);
		}

		// Token: 0x0401B090 RID: 110736
		private readonly string _Value;

		// Token: 0x0401B091 RID: 110737
		public static readonly EClickActionType ItemTips = new EClickActionType("item_tips");

		// Token: 0x0401B092 RID: 110738
		public static readonly EClickActionType MonsterDetail = new EClickActionType("monster_detail");

		// Token: 0x0401B093 RID: 110739
		public static readonly EClickActionType None = new EClickActionType("none");
	}
}
