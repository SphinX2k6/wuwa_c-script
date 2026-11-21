using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x0200532E RID: 21294
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct EMowingBuffIntroduceQualityIcon : IEquatable<EMowingBuffIntroduceQualityIcon>
	{
		// Token: 0x06034FFF RID: 217087 RVA: 0x00ED244E File Offset: 0x00ED064E
		private EMowingBuffIntroduceQualityIcon(string value)
		{
			this._Value = value;
		}

		// Token: 0x06035000 RID: 217088 RVA: 0x00ED2457 File Offset: 0x00ED0657
		public override string ToString()
		{
			return this._Value;
		}

		// Token: 0x06035001 RID: 217089 RVA: 0x00ED245F File Offset: 0x00ED065F
		public bool Equals(EMowingBuffIntroduceQualityIcon other)
		{
			return this._Value == other._Value;
		}

		// Token: 0x06035002 RID: 217090 RVA: 0x00ED2474 File Offset: 0x00ED0674
		public override bool Equals(object obj)
		{
			if (obj is EMowingBuffIntroduceQualityIcon)
			{
				EMowingBuffIntroduceQualityIcon other = (EMowingBuffIntroduceQualityIcon)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06035003 RID: 217091 RVA: 0x00ED2499 File Offset: 0x00ED0699
		public override int GetHashCode()
		{
			string value = this._Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x06035004 RID: 217092 RVA: 0x00ED24AC File Offset: 0x00ED06AC
		public static bool operator ==(EMowingBuffIntroduceQualityIcon left, EMowingBuffIntroduceQualityIcon right)
		{
			return left.Equals(right);
		}

		// Token: 0x06035005 RID: 217093 RVA: 0x00ED24B6 File Offset: 0x00ED06B6
		public static bool operator !=(EMowingBuffIntroduceQualityIcon left, EMowingBuffIntroduceQualityIcon right)
		{
			return !left.Equals(right);
		}

		// Token: 0x0401C021 RID: 114721
		private readonly string _Value;

		// Token: 0x0401C022 RID: 114722
		public static readonly EMowingBuffIntroduceQualityIcon Gold = new EMowingBuffIntroduceQualityIcon("SP_QualityGlodA");

		// Token: 0x0401C023 RID: 114723
		public static readonly EMowingBuffIntroduceQualityIcon Purple = new EMowingBuffIntroduceQualityIcon("SP_QualityPurpleA");

		// Token: 0x0401C024 RID: 114724
		public static readonly EMowingBuffIntroduceQualityIcon Blue = new EMowingBuffIntroduceQualityIcon("SP_QualityBlueA");
	}
}
