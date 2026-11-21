using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x0200532C RID: 21292
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct EMowingBuffQualityHexColor : IEquatable<EMowingBuffQualityHexColor>
	{
		// Token: 0x06034FEF RID: 217071 RVA: 0x00ED22F7 File Offset: 0x00ED04F7
		private EMowingBuffQualityHexColor(string value)
		{
			this._Value = value;
		}

		// Token: 0x06034FF0 RID: 217072 RVA: 0x00ED2300 File Offset: 0x00ED0500
		public override string ToString()
		{
			return this._Value;
		}

		// Token: 0x06034FF1 RID: 217073 RVA: 0x00ED2308 File Offset: 0x00ED0508
		public bool Equals(EMowingBuffQualityHexColor other)
		{
			return this._Value == other._Value;
		}

		// Token: 0x06034FF2 RID: 217074 RVA: 0x00ED231C File Offset: 0x00ED051C
		public override bool Equals(object obj)
		{
			if (obj is EMowingBuffQualityHexColor)
			{
				EMowingBuffQualityHexColor other = (EMowingBuffQualityHexColor)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06034FF3 RID: 217075 RVA: 0x00ED2341 File Offset: 0x00ED0541
		public override int GetHashCode()
		{
			string value = this._Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x06034FF4 RID: 217076 RVA: 0x00ED2354 File Offset: 0x00ED0554
		public static bool operator ==(EMowingBuffQualityHexColor left, EMowingBuffQualityHexColor right)
		{
			return left.Equals(right);
		}

		// Token: 0x06034FF5 RID: 217077 RVA: 0x00ED235E File Offset: 0x00ED055E
		public static bool operator !=(EMowingBuffQualityHexColor left, EMowingBuffQualityHexColor right)
		{
			return !left.Equals(right);
		}

		// Token: 0x0401C018 RID: 114712
		private readonly string _Value;

		// Token: 0x0401C019 RID: 114713
		public static readonly EMowingBuffQualityHexColor Default = new EMowingBuffQualityHexColor("FFFFFFFF");

		// Token: 0x0401C01A RID: 114714
		public static readonly EMowingBuffQualityHexColor Gold = new EMowingBuffQualityHexColor("FFBD47FF");

		// Token: 0x0401C01B RID: 114715
		public static readonly EMowingBuffQualityHexColor Purple = new EMowingBuffQualityHexColor("7645A3FF");

		// Token: 0x0401C01C RID: 114716
		public static readonly EMowingBuffQualityHexColor Blue = new EMowingBuffQualityHexColor("3E9DFFFF");
	}
}
