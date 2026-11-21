using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing
{
	// Token: 0x02005404 RID: 21508
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct EMoonChasingGuideInBusinessHelper : IEquatable<EMoonChasingGuideInBusinessHelper>
	{
		// Token: 0x0603571C RID: 218908 RVA: 0x00EEC963 File Offset: 0x00EEAB63
		private EMoonChasingGuideInBusinessHelper(string value)
		{
			this._Value = value;
		}

		// Token: 0x0603571D RID: 218909 RVA: 0x00EEC96C File Offset: 0x00EEAB6C
		public override string ToString()
		{
			return this._Value;
		}

		// Token: 0x0603571E RID: 218910 RVA: 0x00EEC974 File Offset: 0x00EEAB74
		public bool Equals(EMoonChasingGuideInBusinessHelper other)
		{
			return this._Value == other._Value;
		}

		// Token: 0x0603571F RID: 218911 RVA: 0x00EEC988 File Offset: 0x00EEAB88
		public override bool Equals(object obj)
		{
			if (obj is EMoonChasingGuideInBusinessHelper)
			{
				EMoonChasingGuideInBusinessHelper other = (EMoonChasingGuideInBusinessHelper)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06035720 RID: 218912 RVA: 0x00EEC9AD File Offset: 0x00EEABAD
		public override int GetHashCode()
		{
			string value = this._Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x06035721 RID: 218913 RVA: 0x00EEC9C0 File Offset: 0x00EEABC0
		public static bool operator ==(EMoonChasingGuideInBusinessHelper left, EMoonChasingGuideInBusinessHelper right)
		{
			return left.Equals(right);
		}

		// Token: 0x06035722 RID: 218914 RVA: 0x00EEC9CA File Offset: 0x00EEABCA
		public static bool operator !=(EMoonChasingGuideInBusinessHelper left, EMoonChasingGuideInBusinessHelper right)
		{
			return !left.Equals(right);
		}

		// Token: 0x0401C2FC RID: 115452
		private readonly string _Value;

		// Token: 0x0401C2FD RID: 115453
		public static readonly EMoonChasingGuideInBusinessHelper Helper = new EMoonChasingGuideInBusinessHelper("Helper");

		// Token: 0x0401C2FE RID: 115454
		public static readonly EMoonChasingGuideInBusinessHelper HelperFirst = new EMoonChasingGuideInBusinessHelper("HelperFirst");

		// Token: 0x0401C2FF RID: 115455
		public static readonly EMoonChasingGuideInBusinessHelper Interactive = new EMoonChasingGuideInBusinessHelper("Interactive");
	}
}
