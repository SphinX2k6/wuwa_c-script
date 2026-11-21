using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x0200617D RID: 24957
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct EKeyboardPrimaryLangId : IEquatable<EKeyboardPrimaryLangId>
	{
		// Token: 0x0603BD81 RID: 245121 RVA: 0x01100508 File Offset: 0x010FE708
		private EKeyboardPrimaryLangId(string value)
		{
			this._value = value;
		}

		// Token: 0x0603BD82 RID: 245122 RVA: 0x01100511 File Offset: 0x010FE711
		public bool Equals(EKeyboardPrimaryLangId other)
		{
			return this._value == other._value;
		}

		// Token: 0x0603BD83 RID: 245123 RVA: 0x01100524 File Offset: 0x010FE724
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is EKeyboardPrimaryLangId)
			{
				EKeyboardPrimaryLangId other = (EKeyboardPrimaryLangId)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0603BD84 RID: 245124 RVA: 0x01100549 File Offset: 0x010FE749
		public override int GetHashCode()
		{
			if (this._value == null)
			{
				return 0;
			}
			return this._value.GetHashCode();
		}

		// Token: 0x0603BD85 RID: 245125 RVA: 0x01100560 File Offset: 0x010FE760
		public override string ToString()
		{
			return this._value;
		}

		// Token: 0x0603BD86 RID: 245126 RVA: 0x01100568 File Offset: 0x010FE768
		public static implicit operator string(EKeyboardPrimaryLangId id)
		{
			return id.ToString();
		}

		// Token: 0x0603BD87 RID: 245127 RVA: 0x01100577 File Offset: 0x010FE777
		public static explicit operator EKeyboardPrimaryLangId(string value)
		{
			return new EKeyboardPrimaryLangId(value);
		}

		// Token: 0x0603BD88 RID: 245128 RVA: 0x0110057F File Offset: 0x010FE77F
		public static bool operator ==(EKeyboardPrimaryLangId left, EKeyboardPrimaryLangId right)
		{
			return left.Equals(right);
		}

		// Token: 0x0603BD89 RID: 245129 RVA: 0x01100589 File Offset: 0x010FE789
		public static bool operator !=(EKeyboardPrimaryLangId left, EKeyboardPrimaryLangId right)
		{
			return !left.Equals(right);
		}

		// Token: 0x0401FA61 RID: 129633
		private readonly string _value;

		// Token: 0x0401FA62 RID: 129634
		public static readonly EKeyboardPrimaryLangId Default = new EKeyboardPrimaryLangId("Default");

		// Token: 0x0401FA63 RID: 129635
		public static readonly EKeyboardPrimaryLangId French = new EKeyboardPrimaryLangId("French");

		// Token: 0x0401FA64 RID: 129636
		public static readonly EKeyboardPrimaryLangId German = new EKeyboardPrimaryLangId("German");

		// Token: 0x0401FA65 RID: 129637
		public static readonly EKeyboardPrimaryLangId Italian = new EKeyboardPrimaryLangId("Italian");

		// Token: 0x0401FA66 RID: 129638
		public static readonly EKeyboardPrimaryLangId Spanish = new EKeyboardPrimaryLangId("Spanish");

		// Token: 0x0401FA67 RID: 129639
		public static readonly EKeyboardPrimaryLangId Swedish = new EKeyboardPrimaryLangId("Swedish");

		// Token: 0x0401FA68 RID: 129640
		public static readonly EKeyboardPrimaryLangId Japanese = new EKeyboardPrimaryLangId("Japanese");

		// Token: 0x0401FA69 RID: 129641
		public static readonly EKeyboardPrimaryLangId Russian = new EKeyboardPrimaryLangId("Russian");

		// Token: 0x0401FA6A RID: 129642
		public static readonly EKeyboardPrimaryLangId Thai = new EKeyboardPrimaryLangId("Thai");
	}
}
