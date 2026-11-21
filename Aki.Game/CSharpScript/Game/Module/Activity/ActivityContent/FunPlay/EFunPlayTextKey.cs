using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.FunPlay
{
	// Token: 0x020054EB RID: 21739
	[NullableContext(1)]
	[Nullable(0)]
	internal struct EFunPlayTextKey : IEquatable<EFunPlayTextKey>
	{
		// Token: 0x06035DEF RID: 220655 RVA: 0x00F0C214 File Offset: 0x00F0A414
		private EFunPlayTextKey(string value)
		{
			this._Value = value;
		}

		// Token: 0x06035DF0 RID: 220656 RVA: 0x00F0C21D File Offset: 0x00F0A41D
		public override readonly string ToString()
		{
			return this._Value;
		}

		// Token: 0x06035DF1 RID: 220657 RVA: 0x00F0C225 File Offset: 0x00F0A425
		public bool Equals(EFunPlayTextKey other)
		{
			return this._Value == other._Value;
		}

		// Token: 0x06035DF2 RID: 220658 RVA: 0x00F0C238 File Offset: 0x00F0A438
		public override bool Equals(object obj)
		{
			if (obj is EFunPlayTextKey)
			{
				EFunPlayTextKey other = (EFunPlayTextKey)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06035DF3 RID: 220659 RVA: 0x00F0C25D File Offset: 0x00F0A45D
		public override int GetHashCode()
		{
			string value = this._Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x06035DF4 RID: 220660 RVA: 0x00F0C270 File Offset: 0x00F0A470
		public static bool operator ==(EFunPlayTextKey left, EFunPlayTextKey right)
		{
			return left.Equals(right);
		}

		// Token: 0x06035DF5 RID: 220661 RVA: 0x00F0C27A File Offset: 0x00F0A47A
		public static bool operator !=(EFunPlayTextKey left, EFunPlayTextKey right)
		{
			return !left.Equals(right);
		}

		// Token: 0x0401C7C4 RID: 116676
		private readonly string _Value;

		// Token: 0x0401C7C5 RID: 116677
		public static readonly EFunPlayTextKey GotoMain = new EFunPlayTextKey("PrefabTextItem_708485707_Text");

		// Token: 0x0401C7C6 RID: 116678
		public static readonly EFunPlayTextKey NoComment = new EFunPlayTextKey("Activity_105900001_Lock");

		// Token: 0x0401C7C7 RID: 116679
		public static readonly EFunPlayTextKey UnlockTxt = new EFunPlayTextKey("Activity_105900001_Locktime");
	}
}
