using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x020063AE RID: 25518
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct EMowingBuffQualityHexColor : IEquatable<EMowingBuffQualityHexColor>
	{
		// Token: 0x0604032E RID: 262958 RVA: 0x00F8B35F File Offset: 0x00F8955F
		private EMowingBuffQualityHexColor(string value)
		{
			this._Value = value;
		}

		// Token: 0x0604032F RID: 262959 RVA: 0x00F8B368 File Offset: 0x00F89568
		public override string ToString()
		{
			return this._Value;
		}

		// Token: 0x06040330 RID: 262960 RVA: 0x00F8B370 File Offset: 0x00F89570
		public bool Equals(EMowingBuffQualityHexColor other)
		{
			return this._Value == other._Value;
		}

		// Token: 0x06040331 RID: 262961 RVA: 0x00F8B384 File Offset: 0x00F89584
		public override bool Equals(object obj)
		{
			if (obj is EMowingBuffQualityHexColor)
			{
				EMowingBuffQualityHexColor other = (EMowingBuffQualityHexColor)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06040332 RID: 262962 RVA: 0x00F8B3A9 File Offset: 0x00F895A9
		public override int GetHashCode()
		{
			string value = this._Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x06040333 RID: 262963 RVA: 0x00F8B3BC File Offset: 0x00F895BC
		public static bool operator ==(EMowingBuffQualityHexColor left, EMowingBuffQualityHexColor right)
		{
			return left.Equals(right);
		}

		// Token: 0x06040334 RID: 262964 RVA: 0x00F8B3C6 File Offset: 0x00F895C6
		public static bool operator !=(EMowingBuffQualityHexColor left, EMowingBuffQualityHexColor right)
		{
			return !left.Equals(right);
		}

		// Token: 0x040216E9 RID: 136937
		private readonly string _Value;

		// Token: 0x040216EA RID: 136938
		public static readonly EMowingBuffQualityHexColor Default = new EMowingBuffQualityHexColor("FFFFFFFF");

		// Token: 0x040216EB RID: 136939
		public static readonly EMowingBuffQualityHexColor Gold = new EMowingBuffQualityHexColor("FFBD47FF");

		// Token: 0x040216EC RID: 136940
		public static readonly EMowingBuffQualityHexColor Purple = new EMowingBuffQualityHexColor("7645A3FF");

		// Token: 0x040216ED RID: 136941
		public static readonly EMowingBuffQualityHexColor Blue = new EMowingBuffQualityHexColor("3E9DFFFF");
	}
}
