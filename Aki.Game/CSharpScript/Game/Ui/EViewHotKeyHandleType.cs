using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200469A RID: 18074
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct EViewHotKeyHandleType : IEquatable<EViewHotKeyHandleType>
	{
		// Token: 0x0602E9CC RID: 190924 RVA: 0x00ACACD3 File Offset: 0x00AC8ED3
		private EViewHotKeyHandleType(string value)
		{
			this._Value = value;
		}

		// Token: 0x0602E9CD RID: 190925 RVA: 0x00ACACDC File Offset: 0x00AC8EDC
		public override string ToString()
		{
			return this._Value;
		}

		// Token: 0x0602E9CE RID: 190926 RVA: 0x00ACACE4 File Offset: 0x00AC8EE4
		public bool Equals(EViewHotKeyHandleType other)
		{
			return this._Value == other._Value;
		}

		// Token: 0x0602E9CF RID: 190927 RVA: 0x00ACACF8 File Offset: 0x00AC8EF8
		public override bool Equals(object obj)
		{
			if (obj is EViewHotKeyHandleType)
			{
				EViewHotKeyHandleType other = (EViewHotKeyHandleType)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0602E9D0 RID: 190928 RVA: 0x00ACAD1D File Offset: 0x00AC8F1D
		public override int GetHashCode()
		{
			string value = this._Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x0602E9D1 RID: 190929 RVA: 0x00ACAD30 File Offset: 0x00AC8F30
		public static bool operator ==(EViewHotKeyHandleType left, EViewHotKeyHandleType right)
		{
			return left.Equals(right);
		}

		// Token: 0x0602E9D2 RID: 190930 RVA: 0x00ACAD3A File Offset: 0x00AC8F3A
		public static bool operator !=(EViewHotKeyHandleType left, EViewHotKeyHandleType right)
		{
			return !left.Equals(right);
		}

		// Token: 0x0401964E RID: 104014
		private readonly string _Value;

		// Token: 0x0401964F RID: 104015
		public static readonly EViewHotKeyHandleType ViewHotKeyHandle = new EViewHotKeyHandleType("ViewHotKeyHandle");

		// Token: 0x04019650 RID: 104016
		public static readonly EViewHotKeyHandleType ViewHotKeyHandleRoulette = new EViewHotKeyHandleType("ViewHotKeyHandleRoulette");

		// Token: 0x04019651 RID: 104017
		public static readonly EViewHotKeyHandleType ViewHotKeyHandleFunctionMenu = new EViewHotKeyHandleType("ViewHotKeyHandleFunctionMenu");

		// Token: 0x04019652 RID: 104018
		public static readonly EViewHotKeyHandleType ViewHotKeyHandleMapView = new EViewHotKeyHandleType("ViewHotKeyHandleMapView");

		// Token: 0x04019653 RID: 104019
		public static readonly EViewHotKeyHandleType ViewHotKeyHandleRoleRootView = new EViewHotKeyHandleType("ViewHotKeyHandleRoleRootView");

		// Token: 0x04019654 RID: 104020
		public static readonly EViewHotKeyHandleType ViewHotKeyHandleTrapDefenseRoulette = new EViewHotKeyHandleType("ViewHotKeyHandleTrapDefenseRoulette");

		// Token: 0x04019655 RID: 104021
		public static readonly EViewHotKeyHandleType ViewHotKeyHandleBackpackView = new EViewHotKeyHandleType("ViewHotKeyHandleBackpackView");

		// Token: 0x04019656 RID: 104022
		public static readonly EViewHotKeyHandleType ViewHotKeyHandleQuestView = new EViewHotKeyHandleType("ViewHotKeyHandleQuestView");

		// Token: 0x04019657 RID: 104023
		public static readonly EViewHotKeyHandleType ViewHotKeyHandleFormation = new EViewHotKeyHandleType("ViewHotKeyHandleFormation");
	}
}
