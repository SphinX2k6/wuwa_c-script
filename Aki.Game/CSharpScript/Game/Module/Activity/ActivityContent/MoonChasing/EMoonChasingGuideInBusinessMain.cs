using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing
{
	// Token: 0x02005400 RID: 21504
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct EMoonChasingGuideInBusinessMain : IEquatable<EMoonChasingGuideInBusinessMain>
	{
		// Token: 0x0603570C RID: 218892 RVA: 0x00EEC801 File Offset: 0x00EEAA01
		private EMoonChasingGuideInBusinessMain(string value)
		{
			this._Value = value;
		}

		// Token: 0x0603570D RID: 218893 RVA: 0x00EEC80A File Offset: 0x00EEAA0A
		public override string ToString()
		{
			return this._Value;
		}

		// Token: 0x0603570E RID: 218894 RVA: 0x00EEC812 File Offset: 0x00EEAA12
		public bool Equals(EMoonChasingGuideInBusinessMain other)
		{
			return this._Value == other._Value;
		}

		// Token: 0x0603570F RID: 218895 RVA: 0x00EEC828 File Offset: 0x00EEAA28
		public override bool Equals(object obj)
		{
			if (obj is EMoonChasingGuideInBusinessMain)
			{
				EMoonChasingGuideInBusinessMain other = (EMoonChasingGuideInBusinessMain)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06035710 RID: 218896 RVA: 0x00EEC84D File Offset: 0x00EEAA4D
		public override int GetHashCode()
		{
			string value = this._Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x06035711 RID: 218897 RVA: 0x00EEC860 File Offset: 0x00EEAA60
		public static bool operator ==(EMoonChasingGuideInBusinessMain left, EMoonChasingGuideInBusinessMain right)
		{
			return left.Equals(right);
		}

		// Token: 0x06035712 RID: 218898 RVA: 0x00EEC86A File Offset: 0x00EEAA6A
		public static bool operator !=(EMoonChasingGuideInBusinessMain left, EMoonChasingGuideInBusinessMain right)
		{
			return !left.Equals(right);
		}

		// Token: 0x0401C2EC RID: 115436
		private readonly string _Value;

		// Token: 0x0401C2ED RID: 115437
		public static readonly EMoonChasingGuideInBusinessMain Delegation = new EMoonChasingGuideInBusinessMain("Delegation");
	}
}
