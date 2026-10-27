using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing
{
	// Token: 0x02006487 RID: 25735
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct EMoonChasingGuideInMain : IEquatable<EMoonChasingGuideInMain>
	{
		// Token: 0x06040A60 RID: 264800 RVA: 0x00FA59BE File Offset: 0x00FA3BBE
		private EMoonChasingGuideInMain(string value)
		{
			this._Value = value;
		}

		// Token: 0x06040A61 RID: 264801 RVA: 0x00FA59C7 File Offset: 0x00FA3BC7
		public override string ToString()
		{
			return this._Value;
		}

		// Token: 0x06040A62 RID: 264802 RVA: 0x00FA59CF File Offset: 0x00FA3BCF
		public bool Equals(EMoonChasingGuideInMain other)
		{
			return this._Value == other._Value;
		}

		// Token: 0x06040A63 RID: 264803 RVA: 0x00FA59E4 File Offset: 0x00FA3BE4
		public override bool Equals(object obj)
		{
			if (obj is EMoonChasingGuideInMain)
			{
				EMoonChasingGuideInMain other = (EMoonChasingGuideInMain)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06040A64 RID: 264804 RVA: 0x00FA5A09 File Offset: 0x00FA3C09
		public override int GetHashCode()
		{
			string value = this._Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x06040A65 RID: 264805 RVA: 0x00FA5A1C File Offset: 0x00FA3C1C
		public static bool operator ==(EMoonChasingGuideInMain left, EMoonChasingGuideInMain right)
		{
			return left.Equals(right);
		}

		// Token: 0x06040A66 RID: 264806 RVA: 0x00FA5A26 File Offset: 0x00FA3C26
		public static bool operator !=(EMoonChasingGuideInMain left, EMoonChasingGuideInMain right)
		{
			return !left.Equals(right);
		}

		// Token: 0x040219CF RID: 137679
		private readonly string _Value;

		// Token: 0x040219D0 RID: 137680
		public static readonly EMoonChasingGuideInMain BuildMap = new EMoonChasingGuideInMain("BuildMap");
	}
}
