using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046AC RID: 18092
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct EImmersiveMouseModeReason : IEquatable<EImmersiveMouseModeReason>
	{
		// Token: 0x0602EA70 RID: 191088 RVA: 0x00ACC17F File Offset: 0x00ACA37F
		private EImmersiveMouseModeReason(string value)
		{
			this._Value = value;
		}

		// Token: 0x0602EA71 RID: 191089 RVA: 0x00ACC188 File Offset: 0x00ACA388
		public override string ToString()
		{
			return this._Value;
		}

		// Token: 0x0602EA72 RID: 191090 RVA: 0x00ACC190 File Offset: 0x00ACA390
		public bool Equals(EImmersiveMouseModeReason other)
		{
			return this._Value == other._Value;
		}

		// Token: 0x0602EA73 RID: 191091 RVA: 0x00ACC1A4 File Offset: 0x00ACA3A4
		public override bool Equals(object obj)
		{
			if (obj is EImmersiveMouseModeReason)
			{
				EImmersiveMouseModeReason other = (EImmersiveMouseModeReason)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0602EA74 RID: 191092 RVA: 0x00ACC1C9 File Offset: 0x00ACA3C9
		public override int GetHashCode()
		{
			string value = this._Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x0602EA75 RID: 191093 RVA: 0x00ACC1DC File Offset: 0x00ACA3DC
		public static bool operator ==(EImmersiveMouseModeReason left, EImmersiveMouseModeReason right)
		{
			return left.Equals(right);
		}

		// Token: 0x0602EA76 RID: 191094 RVA: 0x00ACC1E6 File Offset: 0x00ACA3E6
		public static bool operator !=(EImmersiveMouseModeReason left, EImmersiveMouseModeReason right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04019692 RID: 104082
		private readonly string _Value;

		// Token: 0x04019693 RID: 104083
		public static readonly EImmersiveMouseModeReason Qte = new EImmersiveMouseModeReason("Qte");

		// Token: 0x04019694 RID: 104084
		public static readonly EImmersiveMouseModeReason Qta = new EImmersiveMouseModeReason("Qta");

		// Token: 0x04019695 RID: 104085
		public static readonly EImmersiveMouseModeReason PlotAutoSelectOptionHover = new EImmersiveMouseModeReason("PlotAutoSelectOptionHover");
	}
}
