using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ActivityGamePlay.Drinks
{
	// Token: 0x02006931 RID: 26929
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct ESeqStep : IEquatable<ESeqStep>
	{
		// Token: 0x060431F6 RID: 274934 RVA: 0x0105BB70 File Offset: 0x01059D70
		private ESeqStep(string value)
		{
			this._Value = value;
		}

		// Token: 0x060431F7 RID: 274935 RVA: 0x0105BB79 File Offset: 0x01059D79
		public override string ToString()
		{
			return this._Value;
		}

		// Token: 0x060431F8 RID: 274936 RVA: 0x0105BB81 File Offset: 0x01059D81
		public bool Equals(ESeqStep other)
		{
			return this._Value == other._Value;
		}

		// Token: 0x060431F9 RID: 274937 RVA: 0x0105BB94 File Offset: 0x01059D94
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is ESeqStep)
			{
				ESeqStep other = (ESeqStep)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x060431FA RID: 274938 RVA: 0x0105BBB9 File Offset: 0x01059DB9
		public override int GetHashCode()
		{
			string value = this._Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x060431FB RID: 274939 RVA: 0x0105BBCC File Offset: 0x01059DCC
		public static bool operator ==(ESeqStep left, ESeqStep right)
		{
			return left.Equals(right);
		}

		// Token: 0x060431FC RID: 274940 RVA: 0x0105BBD6 File Offset: 0x01059DD6
		public static bool operator !=(ESeqStep left, ESeqStep right)
		{
			return !left.Equals(right);
		}

		// Token: 0x060431FD RID: 274941 RVA: 0x0105BBE3 File Offset: 0x01059DE3
		public static implicit operator string(ESeqStep step)
		{
			return step._Value;
		}

		// Token: 0x04022F09 RID: 143113
		private readonly string _Value;

		// Token: 0x04022F0A RID: 143114
		public static readonly ESeqStep Begin = new ESeqStep("A");

		// Token: 0x04022F0B RID: 143115
		public static readonly ESeqStep DrinksStart = new ESeqStep("B");

		// Token: 0x04022F0C RID: 143116
		public static readonly ESeqStep DrinkQTE1End = new ESeqStep("C");

		// Token: 0x04022F0D RID: 143117
		public static readonly ESeqStep DrinkQTE2End = new ESeqStep("D");

		// Token: 0x04022F0E RID: 143118
		public static readonly ESeqStep DrinkQTE3End = new ESeqStep("E");

		// Token: 0x04022F0F RID: 143119
		public static readonly ESeqStep BatchingEnd = new ESeqStep("F");

		// Token: 0x04022F10 RID: 143120
		public static readonly ESeqStep ShakeEnd = new ESeqStep("G");

		// Token: 0x04022F11 RID: 143121
		public static readonly ESeqStep ShowEnd = new ESeqStep("H");
	}
}
