using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02004A79 RID: 19065
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct EDreamLinkSpineDefine : IEquatable<EDreamLinkSpineDefine>
	{
		// Token: 0x0602FB71 RID: 195441 RVA: 0x00D4F608 File Offset: 0x00D4D808
		private EDreamLinkSpineDefine(string value)
		{
			this._Value = value;
		}

		// Token: 0x0602FB72 RID: 195442 RVA: 0x00D4F611 File Offset: 0x00D4D811
		public override string ToString()
		{
			return this._Value;
		}

		// Token: 0x0602FB73 RID: 195443 RVA: 0x00D4F619 File Offset: 0x00D4D819
		public bool Equals(EDreamLinkSpineDefine other)
		{
			return this._Value == other._Value;
		}

		// Token: 0x0602FB74 RID: 195444 RVA: 0x00D4F62C File Offset: 0x00D4D82C
		public override bool Equals(object obj)
		{
			if (obj is EDreamLinkSpineDefine)
			{
				EDreamLinkSpineDefine other = (EDreamLinkSpineDefine)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0602FB75 RID: 195445 RVA: 0x00D4F651 File Offset: 0x00D4D851
		public override int GetHashCode()
		{
			string value = this._Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x0602FB76 RID: 195446 RVA: 0x00D4F664 File Offset: 0x00D4D864
		public static bool operator ==(EDreamLinkSpineDefine left, EDreamLinkSpineDefine right)
		{
			return left.Equals(right);
		}

		// Token: 0x0602FB77 RID: 195447 RVA: 0x00D4F66E File Offset: 0x00D4D86E
		public static bool operator !=(EDreamLinkSpineDefine left, EDreamLinkSpineDefine right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04019546 RID: 103750
		private readonly string _Value;

		// Token: 0x04019547 RID: 103751
		public static readonly EDreamLinkSpineDefine MainFemale = new EDreamLinkSpineDefine("nvzhu");

		// Token: 0x04019548 RID: 103752
		public static readonly EDreamLinkSpineDefine MainMale = new EDreamLinkSpineDefine("nanzhu");

		// Token: 0x04019549 RID: 103753
		public static readonly EDreamLinkSpineDefine Idle = new EDreamLinkSpineDefine("idle");

		// Token: 0x0401954A RID: 103754
		public static readonly EDreamLinkSpineDefine Start = new EDreamLinkSpineDefine("start");
	}
}
