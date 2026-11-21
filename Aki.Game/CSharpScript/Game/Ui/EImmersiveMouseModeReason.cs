using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035DD RID: 13789
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct EImmersiveMouseModeReason : IEquatable<EImmersiveMouseModeReason>
	{
		// Token: 0x060231BC RID: 143804 RVA: 0x009FAA53 File Offset: 0x009F8C53
		private EImmersiveMouseModeReason(string value)
		{
			this._Value = value;
		}

		// Token: 0x060231BD RID: 143805 RVA: 0x009FAA5C File Offset: 0x009F8C5C
		public override string ToString()
		{
			return this._Value;
		}

		// Token: 0x060231BE RID: 143806 RVA: 0x009FAA64 File Offset: 0x009F8C64
		public bool Equals(EImmersiveMouseModeReason other)
		{
			return this._Value == other._Value;
		}

		// Token: 0x060231BF RID: 143807 RVA: 0x009FAA78 File Offset: 0x009F8C78
		public override bool Equals(object obj)
		{
			if (obj is EImmersiveMouseModeReason)
			{
				EImmersiveMouseModeReason other = (EImmersiveMouseModeReason)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x060231C0 RID: 143808 RVA: 0x009FAA9D File Offset: 0x009F8C9D
		public override int GetHashCode()
		{
			string value = this._Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x060231C1 RID: 143809 RVA: 0x009FAAB0 File Offset: 0x009F8CB0
		public static bool operator ==(EImmersiveMouseModeReason left, EImmersiveMouseModeReason right)
		{
			return left.Equals(right);
		}

		// Token: 0x060231C2 RID: 143810 RVA: 0x009FAABA File Offset: 0x009F8CBA
		public static bool operator !=(EImmersiveMouseModeReason left, EImmersiveMouseModeReason right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04013D37 RID: 81207
		private readonly string _Value;

		// Token: 0x04013D38 RID: 81208
		public static readonly EImmersiveMouseModeReason Qte = new EImmersiveMouseModeReason("Qte");

		// Token: 0x04013D39 RID: 81209
		public static readonly EImmersiveMouseModeReason Qta = new EImmersiveMouseModeReason("Qta");

		// Token: 0x04013D3A RID: 81210
		public static readonly EImmersiveMouseModeReason PlotAutoSelectOptionHover = new EImmersiveMouseModeReason("PlotAutoSelectOptionHover");
	}
}
