using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Cook
{
	// Token: 0x02005AF6 RID: 23286
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct ECookMechanismState : IEquatable<ECookMechanismState>
	{
		// Token: 0x0603AF25 RID: 241445 RVA: 0x00E0E17E File Offset: 0x00E0C37E
		private ECookMechanismState(string value)
		{
			this._Value = value;
		}

		// Token: 0x0603AF26 RID: 241446 RVA: 0x00E0E187 File Offset: 0x00E0C387
		public override string ToString()
		{
			return this._Value;
		}

		// Token: 0x0603AF27 RID: 241447 RVA: 0x00E0E18F File Offset: 0x00E0C38F
		public bool Equals(ECookMechanismState other)
		{
			return this._Value == other._Value;
		}

		// Token: 0x0603AF28 RID: 241448 RVA: 0x00E0E1A4 File Offset: 0x00E0C3A4
		public override bool Equals(object obj)
		{
			if (obj is ECookMechanismState)
			{
				ECookMechanismState other = (ECookMechanismState)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0603AF29 RID: 241449 RVA: 0x00E0E1C9 File Offset: 0x00E0C3C9
		public override int GetHashCode()
		{
			string value = this._Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x0603AF2A RID: 241450 RVA: 0x00E0E1DC File Offset: 0x00E0C3DC
		public static bool operator ==(ECookMechanismState left, ECookMechanismState right)
		{
			return left.Equals(right);
		}

		// Token: 0x0603AF2B RID: 241451 RVA: 0x00E0E1E6 File Offset: 0x00E0C3E6
		public static bool operator !=(ECookMechanismState left, ECookMechanismState right)
		{
			return !left.Equals(right);
		}

		// Token: 0x0401EC43 RID: 126019
		private readonly string _Value;

		// Token: 0x0401EC44 RID: 126020
		public static readonly ECookMechanismState CookDone = new ECookMechanismState("finishcook");

		// Token: 0x0401EC45 RID: 126021
		public static readonly ECookMechanismState CloseUi = new ECookMechanismState("endcook");

		// Token: 0x0401EC46 RID: 126022
		public static readonly ECookMechanismState EnterUi = new ECookMechanismState("opencook");
	}
}
