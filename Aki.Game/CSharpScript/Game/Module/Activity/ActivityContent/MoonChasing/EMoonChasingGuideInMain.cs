using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing
{
	// Token: 0x02005405 RID: 21509
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct EMoonChasingGuideInMain : IEquatable<EMoonChasingGuideInMain>
	{
		// Token: 0x06035724 RID: 218916 RVA: 0x00EECA06 File Offset: 0x00EEAC06
		private EMoonChasingGuideInMain(string value)
		{
			this._Value = value;
		}

		// Token: 0x06035725 RID: 218917 RVA: 0x00EECA0F File Offset: 0x00EEAC0F
		public override string ToString()
		{
			return this._Value;
		}

		// Token: 0x06035726 RID: 218918 RVA: 0x00EECA17 File Offset: 0x00EEAC17
		public bool Equals(EMoonChasingGuideInMain other)
		{
			return this._Value == other._Value;
		}

		// Token: 0x06035727 RID: 218919 RVA: 0x00EECA2C File Offset: 0x00EEAC2C
		public override bool Equals(object obj)
		{
			if (obj is EMoonChasingGuideInMain)
			{
				EMoonChasingGuideInMain other = (EMoonChasingGuideInMain)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06035728 RID: 218920 RVA: 0x00EECA51 File Offset: 0x00EEAC51
		public override int GetHashCode()
		{
			string value = this._Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x06035729 RID: 218921 RVA: 0x00EECA64 File Offset: 0x00EEAC64
		public static bool operator ==(EMoonChasingGuideInMain left, EMoonChasingGuideInMain right)
		{
			return left.Equals(right);
		}

		// Token: 0x0603572A RID: 218922 RVA: 0x00EECA6E File Offset: 0x00EEAC6E
		public static bool operator !=(EMoonChasingGuideInMain left, EMoonChasingGuideInMain right)
		{
			return !left.Equals(right);
		}

		// Token: 0x0401C300 RID: 115456
		private readonly string _Value;

		// Token: 0x0401C301 RID: 115457
		public static readonly EMoonChasingGuideInMain BuildMap = new EMoonChasingGuideInMain("BuildMap");
	}
}
