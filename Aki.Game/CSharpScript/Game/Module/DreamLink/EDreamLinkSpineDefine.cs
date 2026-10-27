using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02005A9D RID: 23197
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct EDreamLinkSpineDefine : IEquatable<EDreamLinkSpineDefine>
	{
		// Token: 0x0603AC28 RID: 240680 RVA: 0x00DFF0A0 File Offset: 0x00DFD2A0
		private EDreamLinkSpineDefine(string value)
		{
			this._Value = value;
		}

		// Token: 0x0603AC29 RID: 240681 RVA: 0x00DFF0A9 File Offset: 0x00DFD2A9
		public override string ToString()
		{
			return this._Value;
		}

		// Token: 0x0603AC2A RID: 240682 RVA: 0x00DFF0B1 File Offset: 0x00DFD2B1
		public bool Equals(EDreamLinkSpineDefine other)
		{
			return this._Value == other._Value;
		}

		// Token: 0x0603AC2B RID: 240683 RVA: 0x00DFF0C4 File Offset: 0x00DFD2C4
		public override bool Equals(object obj)
		{
			if (obj is EDreamLinkSpineDefine)
			{
				EDreamLinkSpineDefine other = (EDreamLinkSpineDefine)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0603AC2C RID: 240684 RVA: 0x00DFF0E9 File Offset: 0x00DFD2E9
		public override int GetHashCode()
		{
			string value = this._Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x0603AC2D RID: 240685 RVA: 0x00DFF0FC File Offset: 0x00DFD2FC
		public static bool operator ==(EDreamLinkSpineDefine left, EDreamLinkSpineDefine right)
		{
			return left.Equals(right);
		}

		// Token: 0x0603AC2E RID: 240686 RVA: 0x00DFF106 File Offset: 0x00DFD306
		public static bool operator !=(EDreamLinkSpineDefine left, EDreamLinkSpineDefine right)
		{
			return !left.Equals(right);
		}

		// Token: 0x0401EA9F RID: 125599
		private readonly string _Value;

		// Token: 0x0401EAA0 RID: 125600
		public static readonly EDreamLinkSpineDefine MainFemale = new EDreamLinkSpineDefine("nvzhu");

		// Token: 0x0401EAA1 RID: 125601
		public static readonly EDreamLinkSpineDefine MainMale = new EDreamLinkSpineDefine("nanzhu");

		// Token: 0x0401EAA2 RID: 125602
		public static readonly EDreamLinkSpineDefine Idle = new EDreamLinkSpineDefine("idle");

		// Token: 0x0401EAA3 RID: 125603
		public static readonly EDreamLinkSpineDefine Start = new EDreamLinkSpineDefine("start");
	}
}
