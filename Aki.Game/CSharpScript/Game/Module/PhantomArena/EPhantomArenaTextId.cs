using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x02005117 RID: 20759
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct EPhantomArenaTextId : IEquatable<EPhantomArenaTextId>
	{
		// Token: 0x0603513C RID: 217404 RVA: 0x00C94073 File Offset: 0x00C92273
		private EPhantomArenaTextId(string value)
		{
			this._Value = value;
		}

		// Token: 0x0603513D RID: 217405 RVA: 0x00C9407C File Offset: 0x00C9227C
		public override string ToString()
		{
			return this._Value;
		}

		// Token: 0x0603513E RID: 217406 RVA: 0x00C94084 File Offset: 0x00C92284
		public bool Equals(EPhantomArenaTextId other)
		{
			return this._Value == other._Value;
		}

		// Token: 0x0603513F RID: 217407 RVA: 0x00C94098 File Offset: 0x00C92298
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

		// Token: 0x06035140 RID: 217408 RVA: 0x00C940BD File Offset: 0x00C922BD
		public override int GetHashCode()
		{
			string value = this._Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x06035141 RID: 217409 RVA: 0x00C940D0 File Offset: 0x00C922D0
		public static bool operator ==(EPhantomArenaTextId left, EPhantomArenaTextId right)
		{
			return left.Equals(right);
		}

		// Token: 0x06035142 RID: 217410 RVA: 0x00C940DA File Offset: 0x00C922DA
		public static bool operator !=(EPhantomArenaTextId left, EPhantomArenaTextId right)
		{
			return !left.Equals(right);
		}

		// Token: 0x0401C45D RID: 115805
		private readonly string _Value;

		// Token: 0x0401C45E RID: 115806
		public static readonly EPhantomArenaTextId TextExp = new EPhantomArenaTextId("PhantomBattle_1152");

		// Token: 0x0401C45F RID: 115807
		public static readonly EPhantomArenaTextId TextEntranceTitle = new EPhantomArenaTextId("PhantomBattle_1151");

		// Token: 0x0401C460 RID: 115808
		public static readonly EPhantomArenaTextId TextRewardProgress = new EPhantomArenaTextId("PhantomBattle_1153");

		// Token: 0x0401C461 RID: 115809
		public static readonly EPhantomArenaTextId TextFirstPassRewardTitle = new EPhantomArenaTextId("PhantomBattle_1154");

		// Token: 0x0401C462 RID: 115810
		public static readonly EPhantomArenaTextId TextReChallengeRewardTitle = new EPhantomArenaTextId("PhantomBattle_1155");

		// Token: 0x0401C463 RID: 115811
		public static readonly EPhantomArenaTextId TextChallengeProgressNormal = new EPhantomArenaTextId("PhantomBattle_1159");

		// Token: 0x0401C464 RID: 115812
		public static readonly EPhantomArenaTextId TextChallengeProgressSelect = new EPhantomArenaTextId("PhantomBattle_1160");

		// Token: 0x0401C465 RID: 115813
		public static readonly EPhantomArenaTextId TextMysteryNpcName = new EPhantomArenaTextId("PhantomBattle_1164");

		// Token: 0x0401C466 RID: 115814
		public static readonly EPhantomArenaTextId TextMysteryNpcDesc = new EPhantomArenaTextId("PhantomBattle_1165");

		// Token: 0x0401C467 RID: 115815
		public static readonly EPhantomArenaTextId TextGuideQuestTip = new EPhantomArenaTextId("PhantomBattle_1182");

		// Token: 0x0401C468 RID: 115816
		public static readonly EPhantomArenaTextId TextGotoQuest = new EPhantomArenaTextId("PhantomBattle_1183");
	}
}
