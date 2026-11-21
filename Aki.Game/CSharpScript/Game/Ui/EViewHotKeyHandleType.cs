using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035CB RID: 13771
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct EViewHotKeyHandleType : IEquatable<EViewHotKeyHandleType>
	{
		// Token: 0x06023118 RID: 143640 RVA: 0x009F95A7 File Offset: 0x009F77A7
		private EViewHotKeyHandleType(string value)
		{
			this._Value = value;
		}

		// Token: 0x06023119 RID: 143641 RVA: 0x009F95B0 File Offset: 0x009F77B0
		public override string ToString()
		{
			return this._Value;
		}

		// Token: 0x0602311A RID: 143642 RVA: 0x009F95B8 File Offset: 0x009F77B8
		public bool Equals(EViewHotKeyHandleType other)
		{
			return this._Value == other._Value;
		}

		// Token: 0x0602311B RID: 143643 RVA: 0x009F95CC File Offset: 0x009F77CC
		public override bool Equals(object obj)
		{
			if (obj is EViewHotKeyHandleType)
			{
				EViewHotKeyHandleType other = (EViewHotKeyHandleType)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0602311C RID: 143644 RVA: 0x009F95F1 File Offset: 0x009F77F1
		public override int GetHashCode()
		{
			string value = this._Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x0602311D RID: 143645 RVA: 0x009F9604 File Offset: 0x009F7804
		public static bool operator ==(EViewHotKeyHandleType left, EViewHotKeyHandleType right)
		{
			return left.Equals(right);
		}

		// Token: 0x0602311E RID: 143646 RVA: 0x009F960E File Offset: 0x009F780E
		public static bool operator !=(EViewHotKeyHandleType left, EViewHotKeyHandleType right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04013CF3 RID: 81139
		private readonly string _Value;

		// Token: 0x04013CF4 RID: 81140
		public static readonly EViewHotKeyHandleType ViewHotKeyHandle = new EViewHotKeyHandleType("ViewHotKeyHandle");

		// Token: 0x04013CF5 RID: 81141
		public static readonly EViewHotKeyHandleType ViewHotKeyHandleRoulette = new EViewHotKeyHandleType("ViewHotKeyHandleRoulette");

		// Token: 0x04013CF6 RID: 81142
		public static readonly EViewHotKeyHandleType ViewHotKeyHandleFunctionMenu = new EViewHotKeyHandleType("ViewHotKeyHandleFunctionMenu");

		// Token: 0x04013CF7 RID: 81143
		public static readonly EViewHotKeyHandleType ViewHotKeyHandleMapView = new EViewHotKeyHandleType("ViewHotKeyHandleMapView");

		// Token: 0x04013CF8 RID: 81144
		public static readonly EViewHotKeyHandleType ViewHotKeyHandleRoleRootView = new EViewHotKeyHandleType("ViewHotKeyHandleRoleRootView");

		// Token: 0x04013CF9 RID: 81145
		public static readonly EViewHotKeyHandleType ViewHotKeyHandleTrapDefenseRoulette = new EViewHotKeyHandleType("ViewHotKeyHandleTrapDefenseRoulette");

		// Token: 0x04013CFA RID: 81146
		public static readonly EViewHotKeyHandleType ViewHotKeyHandleBackpackView = new EViewHotKeyHandleType("ViewHotKeyHandleBackpackView");

		// Token: 0x04013CFB RID: 81147
		public static readonly EViewHotKeyHandleType ViewHotKeyHandleQuestView = new EViewHotKeyHandleType("ViewHotKeyHandleQuestView");

		// Token: 0x04013CFC RID: 81148
		public static readonly EViewHotKeyHandleType ViewHotKeyHandleFormation = new EViewHotKeyHandleType("ViewHotKeyHandleFormation");
	}
}
