using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200493C RID: 18748
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct EViewHandleState : IEquatable<EViewHandleState>
	{
		// Token: 0x06030EF7 RID: 200439 RVA: 0x00B5C3C7 File Offset: 0x00B5A5C7
		private EViewHandleState(string value)
		{
			this._Value = value;
		}

		// Token: 0x06030EF8 RID: 200440 RVA: 0x00B5C3D0 File Offset: 0x00B5A5D0
		public override string ToString()
		{
			return this._Value;
		}

		// Token: 0x06030EF9 RID: 200441 RVA: 0x00B5C3D8 File Offset: 0x00B5A5D8
		public bool Equals(EViewHandleState other)
		{
			return this._Value == other._Value;
		}

		// Token: 0x06030EFA RID: 200442 RVA: 0x00B5C3EC File Offset: 0x00B5A5EC
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is EViewHandleState)
			{
				EViewHandleState other = (EViewHandleState)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06030EFB RID: 200443 RVA: 0x00B5C411 File Offset: 0x00B5A611
		public override int GetHashCode()
		{
			string value = this._Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x06030EFC RID: 200444 RVA: 0x00B5C424 File Offset: 0x00B5A624
		public static bool operator ==(EViewHandleState left, EViewHandleState right)
		{
			return left.Equals(right);
		}

		// Token: 0x06030EFD RID: 200445 RVA: 0x00B5C42E File Offset: 0x00B5A62E
		public static bool operator !=(EViewHandleState left, EViewHandleState right)
		{
			return !left.Equals(right);
		}

		// Token: 0x0401A3ED RID: 107501
		private readonly string _Value;

		// Token: 0x0401A3EE RID: 107502
		public static readonly EViewHandleState None = new EViewHandleState("None");

		// Token: 0x0401A3EF RID: 107503
		public static readonly EViewHandleState NonNavigation = new EViewHandleState("NonNavigation");

		// Token: 0x0401A3F0 RID: 107504
		public static readonly EViewHandleState NavigateNext = new EViewHandleState("NavigateNext");

		// Token: 0x0401A3F1 RID: 107505
		public static readonly EViewHandleState HasNavigation = new EViewHandleState("HasNavigation");

		// Token: 0x0401A3F2 RID: 107506
		public static readonly EViewHandleState LoopNonNavigation = new EViewHandleState("LoopNonNavigation");

		// Token: 0x0401A3F3 RID: 107507
		public static readonly EViewHandleState HasNavigationButDisActive = new EViewHandleState("HasNavigationButDisActive");
	}
}
