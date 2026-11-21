using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038B3 RID: 14515
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct EViewHandleState : IEquatable<EViewHandleState>
	{
		// Token: 0x06025A24 RID: 154148 RVA: 0x00A97237 File Offset: 0x00A95437
		private EViewHandleState(string value)
		{
			this._Value = value;
		}

		// Token: 0x06025A25 RID: 154149 RVA: 0x00A97240 File Offset: 0x00A95440
		public override string ToString()
		{
			return this._Value;
		}

		// Token: 0x06025A26 RID: 154150 RVA: 0x00A97248 File Offset: 0x00A95448
		public bool Equals(EViewHandleState other)
		{
			return this._Value == other._Value;
		}

		// Token: 0x06025A27 RID: 154151 RVA: 0x00A9725C File Offset: 0x00A9545C
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

		// Token: 0x06025A28 RID: 154152 RVA: 0x00A97281 File Offset: 0x00A95481
		public override int GetHashCode()
		{
			string value = this._Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x06025A29 RID: 154153 RVA: 0x00A97294 File Offset: 0x00A95494
		public static bool operator ==(EViewHandleState left, EViewHandleState right)
		{
			return left.Equals(right);
		}

		// Token: 0x06025A2A RID: 154154 RVA: 0x00A9729E File Offset: 0x00A9549E
		public static bool operator !=(EViewHandleState left, EViewHandleState right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04014C60 RID: 85088
		private readonly string _Value;

		// Token: 0x04014C61 RID: 85089
		public static readonly EViewHandleState None = new EViewHandleState("None");

		// Token: 0x04014C62 RID: 85090
		public static readonly EViewHandleState NonNavigation = new EViewHandleState("NonNavigation");

		// Token: 0x04014C63 RID: 85091
		public static readonly EViewHandleState NavigateNext = new EViewHandleState("NavigateNext");

		// Token: 0x04014C64 RID: 85092
		public static readonly EViewHandleState HasNavigation = new EViewHandleState("HasNavigation");

		// Token: 0x04014C65 RID: 85093
		public static readonly EViewHandleState LoopNonNavigation = new EViewHandleState("LoopNonNavigation");

		// Token: 0x04014C66 RID: 85094
		public static readonly EViewHandleState HasNavigationButDisActive = new EViewHandleState("HasNavigationButDisActive");
	}
}
