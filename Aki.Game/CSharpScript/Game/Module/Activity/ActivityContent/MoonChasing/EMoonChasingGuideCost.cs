using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing
{
	// Token: 0x02006488 RID: 25736
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct EMoonChasingGuideCost : IEquatable<EMoonChasingGuideCost>
	{
		// Token: 0x06040A68 RID: 264808 RVA: 0x00FA5A44 File Offset: 0x00FA3C44
		private EMoonChasingGuideCost(string value)
		{
			this._Value = value;
		}

		// Token: 0x06040A69 RID: 264809 RVA: 0x00FA5A4D File Offset: 0x00FA3C4D
		public override string ToString()
		{
			return this._Value;
		}

		// Token: 0x06040A6A RID: 264810 RVA: 0x00FA5A55 File Offset: 0x00FA3C55
		public bool Equals(EMoonChasingGuideCost other)
		{
			return this._Value == other._Value;
		}

		// Token: 0x06040A6B RID: 264811 RVA: 0x00FA5A68 File Offset: 0x00FA3C68
		public override bool Equals(object obj)
		{
			if (obj is EMoonChasingGuideCost)
			{
				EMoonChasingGuideCost other = (EMoonChasingGuideCost)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06040A6C RID: 264812 RVA: 0x00FA5A8D File Offset: 0x00FA3C8D
		public override int GetHashCode()
		{
			string value = this._Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x06040A6D RID: 264813 RVA: 0x00FA5AA0 File Offset: 0x00FA3CA0
		public static bool operator ==(EMoonChasingGuideCost left, EMoonChasingGuideCost right)
		{
			return left.Equals(right);
		}

		// Token: 0x06040A6E RID: 264814 RVA: 0x00FA5AAA File Offset: 0x00FA3CAA
		public static bool operator !=(EMoonChasingGuideCost left, EMoonChasingGuideCost right)
		{
			return !left.Equals(right);
		}

		// Token: 0x040219D1 RID: 137681
		private readonly string _Value;

		// Token: 0x040219D2 RID: 137682
		public static readonly EMoonChasingGuideCost Cost = new EMoonChasingGuideCost("Cost");
	}
}
