using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.FunPlay
{
	// Token: 0x0200656D RID: 25965
	[NullableContext(1)]
	[Nullable(0)]
	internal struct EFunPlayTextKey : IEquatable<EFunPlayTextKey>
	{
		// Token: 0x0604112A RID: 266538 RVA: 0x00FC5230 File Offset: 0x00FC3430
		private EFunPlayTextKey(string value)
		{
			this._Value = value;
		}

		// Token: 0x0604112B RID: 266539 RVA: 0x00FC5239 File Offset: 0x00FC3439
		public override readonly string ToString()
		{
			return this._Value;
		}

		// Token: 0x0604112C RID: 266540 RVA: 0x00FC5241 File Offset: 0x00FC3441
		public bool Equals(EFunPlayTextKey other)
		{
			return this._Value == other._Value;
		}

		// Token: 0x0604112D RID: 266541 RVA: 0x00FC5254 File Offset: 0x00FC3454
		public override bool Equals(object obj)
		{
			if (obj is EFunPlayTextKey)
			{
				EFunPlayTextKey other = (EFunPlayTextKey)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0604112E RID: 266542 RVA: 0x00FC5279 File Offset: 0x00FC3479
		public override int GetHashCode()
		{
			string value = this._Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x0604112F RID: 266543 RVA: 0x00FC528C File Offset: 0x00FC348C
		public static bool operator ==(EFunPlayTextKey left, EFunPlayTextKey right)
		{
			return left.Equals(right);
		}

		// Token: 0x06041130 RID: 266544 RVA: 0x00FC5296 File Offset: 0x00FC3496
		public static bool operator !=(EFunPlayTextKey left, EFunPlayTextKey right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04021E93 RID: 138899
		private readonly string _Value;

		// Token: 0x04021E94 RID: 138900
		public static readonly EFunPlayTextKey GotoMain = new EFunPlayTextKey("PrefabTextItem_708485707_Text");

		// Token: 0x04021E95 RID: 138901
		public static readonly EFunPlayTextKey NoComment = new EFunPlayTextKey("Activity_105900001_Lock");

		// Token: 0x04021E96 RID: 138902
		public static readonly EFunPlayTextKey UnlockTxt = new EFunPlayTextKey("Activity_105900001_Locktime");
	}
}
