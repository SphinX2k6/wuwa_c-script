using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x020040E7 RID: 16615
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct EPhantomArenaTextId : IEquatable<EPhantomArenaTextId>
	{
		// Token: 0x0602A035 RID: 172085 RVA: 0x00BE1487 File Offset: 0x00BDF687
		private EPhantomArenaTextId(string value)
		{
			this._Value = value;
		}

		// Token: 0x0602A036 RID: 172086 RVA: 0x00BE1490 File Offset: 0x00BDF690
		public override string ToString()
		{
			return this._Value;
		}

		// Token: 0x0602A037 RID: 172087 RVA: 0x00BE1498 File Offset: 0x00BDF698
		public bool Equals(EPhantomArenaTextId other)
		{
			return this._Value == other._Value;
		}

		// Token: 0x0602A038 RID: 172088 RVA: 0x00BE14AC File Offset: 0x00BDF6AC
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is EPhantomArenaTextId)
			{
				EPhantomArenaTextId other = (EPhantomArenaTextId)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0602A039 RID: 172089 RVA: 0x00BE14D1 File Offset: 0x00BDF6D1
		public override int GetHashCode()
		{
			string value = this._Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x0602A03A RID: 172090 RVA: 0x00BE14E4 File Offset: 0x00BDF6E4
		public static bool operator ==(EPhantomArenaTextId left, EPhantomArenaTextId right)
		{
			return left.Equals(right);
		}

		// Token: 0x0602A03B RID: 172091 RVA: 0x00BE14EE File Offset: 0x00BDF6EE
		public static bool operator !=(EPhantomArenaTextId left, EPhantomArenaTextId right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04016E92 RID: 93842
		private readonly string _Value;

		// Token: 0x04016E93 RID: 93843
		public static readonly EPhantomArenaTextId TextExp = new EPhantomArenaTextId("PhantomBattle_1152");

		// Token: 0x04016E94 RID: 93844
		public static readonly EPhantomArenaTextId TextEntranceTitle = new EPhantomArenaTextId("PhantomBattle_1151");

		// Token: 0x04016E95 RID: 93845
		public static readonly EPhantomArenaTextId TextRewardProgress = new EPhantomArenaTextId("PhantomBattle_1153");

		// Token: 0x04016E96 RID: 93846
		public static readonly EPhantomArenaTextId TextFirstPassRewardTitle = new EPhantomArenaTextId("PhantomBattle_1154");

		// Token: 0x04016E97 RID: 93847
		public static readonly EPhantomArenaTextId TextReChallengeRewardTitle = new EPhantomArenaTextId("PhantomBattle_1155");

		// Token: 0x04016E98 RID: 93848
		public static readonly EPhantomArenaTextId TextChallengeProgressNormal = new EPhantomArenaTextId("PhantomBattle_1159");

		// Token: 0x04016E99 RID: 93849
		public static readonly EPhantomArenaTextId TextChallengeProgressSelect = new EPhantomArenaTextId("PhantomBattle_1160");

		// Token: 0x04016E9A RID: 93850
		public static readonly EPhantomArenaTextId TextMysteryNpcName = new EPhantomArenaTextId("PhantomBattle_1164");

		// Token: 0x04016E9B RID: 93851
		public static readonly EPhantomArenaTextId TextMysteryNpcDesc = new EPhantomArenaTextId("PhantomBattle_1165");

		// Token: 0x04016E9C RID: 93852
		public static readonly EPhantomArenaTextId TextGuideQuestTip = new EPhantomArenaTextId("PhantomBattle_1182");

		// Token: 0x04016E9D RID: 93853
		public static readonly EPhantomArenaTextId TextGotoQuest = new EPhantomArenaTextId("PhantomBattle_1183");
	}
}
