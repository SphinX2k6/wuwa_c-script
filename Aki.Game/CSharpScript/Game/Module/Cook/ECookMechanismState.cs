using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Cook
{
	// Token: 0x02004AD7 RID: 19159
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct ECookMechanismState : IEquatable<ECookMechanismState>
	{
		// Token: 0x0602FE97 RID: 196247 RVA: 0x00D5EE72 File Offset: 0x00D5D072
		private ECookMechanismState(string value)
		{
			this._Value = value;
		}

		// Token: 0x0602FE98 RID: 196248 RVA: 0x00D5EE7B File Offset: 0x00D5D07B
		public override string ToString()
		{
			return this._Value;
		}

		// Token: 0x0602FE99 RID: 196249 RVA: 0x00D5EE83 File Offset: 0x00D5D083
		public bool Equals(ECookMechanismState other)
		{
			return this._Value == other._Value;
		}

		// Token: 0x0602FE9A RID: 196250 RVA: 0x00D5EE98 File Offset: 0x00D5D098
		public override bool Equals(object obj)
		{
			if (obj is ECookMechanismState)
			{
				ECookMechanismState other = (ECookMechanismState)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0602FE9B RID: 196251 RVA: 0x00D5EEBD File Offset: 0x00D5D0BD
		public override int GetHashCode()
		{
			string value = this._Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x0602FE9C RID: 196252 RVA: 0x00D5EED0 File Offset: 0x00D5D0D0
		public static bool operator ==(ECookMechanismState left, ECookMechanismState right)
		{
			return left.Equals(right);
		}

		// Token: 0x0602FE9D RID: 196253 RVA: 0x00D5EEDA File Offset: 0x00D5D0DA
		public static bool operator !=(ECookMechanismState left, ECookMechanismState right)
		{
			return !left.Equals(right);
		}

		// Token: 0x040196FF RID: 104191
		private readonly string _Value;

		// Token: 0x04019700 RID: 104192
		public static readonly ECookMechanismState CookDone = new ECookMechanismState("finishcook");

		// Token: 0x04019701 RID: 104193
		public static readonly ECookMechanismState CloseUi = new ECookMechanismState("endcook");

		// Token: 0x04019702 RID: 104194
		public static readonly ECookMechanismState EnterUi = new ECookMechanismState("opencook");
	}
}
