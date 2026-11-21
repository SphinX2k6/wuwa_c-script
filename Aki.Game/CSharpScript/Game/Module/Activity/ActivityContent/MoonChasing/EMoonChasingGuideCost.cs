using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing
{
	// Token: 0x02005406 RID: 21510
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct EMoonChasingGuideCost : IEquatable<EMoonChasingGuideCost>
	{
		// Token: 0x0603572C RID: 218924 RVA: 0x00EECA8C File Offset: 0x00EEAC8C
		private EMoonChasingGuideCost(string value)
		{
			this._Value = value;
		}

		// Token: 0x0603572D RID: 218925 RVA: 0x00EECA95 File Offset: 0x00EEAC95
		public override string ToString()
		{
			return this._Value;
		}

		// Token: 0x0603572E RID: 218926 RVA: 0x00EECA9D File Offset: 0x00EEAC9D
		public bool Equals(EMoonChasingGuideCost other)
		{
			return this._Value == other._Value;
		}

		// Token: 0x0603572F RID: 218927 RVA: 0x00EECAB0 File Offset: 0x00EEACB0
		public override bool Equals(object obj)
		{
			if (obj is EMoonChasingGuideCost)
			{
				EMoonChasingGuideCost other = (EMoonChasingGuideCost)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06035730 RID: 218928 RVA: 0x00EECAD5 File Offset: 0x00EEACD5
		public override int GetHashCode()
		{
			string value = this._Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x06035731 RID: 218929 RVA: 0x00EECAE8 File Offset: 0x00EEACE8
		public static bool operator ==(EMoonChasingGuideCost left, EMoonChasingGuideCost right)
		{
			return left.Equals(right);
		}

		// Token: 0x06035732 RID: 218930 RVA: 0x00EECAF2 File Offset: 0x00EEACF2
		public static bool operator !=(EMoonChasingGuideCost left, EMoonChasingGuideCost right)
		{
			return !left.Equals(right);
		}

		// Token: 0x0401C302 RID: 115458
		private readonly string _Value;

		// Token: 0x0401C303 RID: 115459
		public static readonly EMoonChasingGuideCost Cost = new EMoonChasingGuideCost("Cost");
	}
}
