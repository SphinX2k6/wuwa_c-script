using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02006FFC RID: 28668
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct EKeyboardPrimaryLangId : IEquatable<EKeyboardPrimaryLangId>
	{
		// Token: 0x06045BCB RID: 285643 RVA: 0x011561A0 File Offset: 0x011543A0
		private EKeyboardPrimaryLangId(string value)
		{
			this._value = value;
		}

		// Token: 0x06045BCC RID: 285644 RVA: 0x011561A9 File Offset: 0x011543A9
		public bool Equals(EKeyboardPrimaryLangId other)
		{
			return this._value == other._value;
		}

		// Token: 0x06045BCD RID: 285645 RVA: 0x011561BC File Offset: 0x011543BC
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

		// Token: 0x06045BCE RID: 285646 RVA: 0x011561E1 File Offset: 0x011543E1
		public override int GetHashCode()
		{
			if (this._value == null)
			{
				return 0;
			}
			return this._value.GetHashCode();
		}

		// Token: 0x06045BCF RID: 285647 RVA: 0x011561F8 File Offset: 0x011543F8
		public override string ToString()
		{
			return this._value;
		}

		// Token: 0x06045BD0 RID: 285648 RVA: 0x01156200 File Offset: 0x01154400
		public static implicit operator string(EKeyboardPrimaryLangId id)
		{
			return id.ToString();
		}

		// Token: 0x06045BD1 RID: 285649 RVA: 0x0115620F File Offset: 0x0115440F
		public static explicit operator EKeyboardPrimaryLangId(string value)
		{
			return new EKeyboardPrimaryLangId(value);
		}

		// Token: 0x06045BD2 RID: 285650 RVA: 0x01156217 File Offset: 0x01154417
		public static bool operator ==(EKeyboardPrimaryLangId left, EKeyboardPrimaryLangId right)
		{
			return left.Equals(right);
		}

		// Token: 0x06045BD3 RID: 285651 RVA: 0x01156221 File Offset: 0x01154421
		public static bool operator !=(EKeyboardPrimaryLangId left, EKeyboardPrimaryLangId right)
		{
			return !left.Equals(right);
		}

		// Token: 0x040247AB RID: 149419
		private readonly string _value;

		// Token: 0x040247AC RID: 149420
		public static readonly EKeyboardPrimaryLangId Default = new EKeyboardPrimaryLangId("Default");

		// Token: 0x040247AD RID: 149421
		public static readonly EKeyboardPrimaryLangId French = new EKeyboardPrimaryLangId("French");

		// Token: 0x040247AE RID: 149422
		public static readonly EKeyboardPrimaryLangId German = new EKeyboardPrimaryLangId("German");

		// Token: 0x040247AF RID: 149423
		public static readonly EKeyboardPrimaryLangId Italian = new EKeyboardPrimaryLangId("Italian");

		// Token: 0x040247B0 RID: 149424
		public static readonly EKeyboardPrimaryLangId Spanish = new EKeyboardPrimaryLangId("Spanish");

		// Token: 0x040247B1 RID: 149425
		public static readonly EKeyboardPrimaryLangId Swedish = new EKeyboardPrimaryLangId("Swedish");

		// Token: 0x040247B2 RID: 149426
		public static readonly EKeyboardPrimaryLangId Japanese = new EKeyboardPrimaryLangId("Japanese");

		// Token: 0x040247B3 RID: 149427
		public static readonly EKeyboardPrimaryLangId Russian = new EKeyboardPrimaryLangId("Russian");

		// Token: 0x040247B4 RID: 149428
		public static readonly EKeyboardPrimaryLangId Thai = new EKeyboardPrimaryLangId("Thai");
	}
}
