using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x0200510B RID: 20747
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct ECardSpineAnimation : IEquatable<ECardSpineAnimation>
	{
		// Token: 0x06035134 RID: 217396 RVA: 0x00C93FE0 File Offset: 0x00C921E0
		private ECardSpineAnimation(string value)
		{
			this._Value = value;
		}

		// Token: 0x06035135 RID: 217397 RVA: 0x00C93FE9 File Offset: 0x00C921E9
		public override string ToString()
		{
			return this._Value;
		}

		// Token: 0x06035136 RID: 217398 RVA: 0x00C93FF1 File Offset: 0x00C921F1
		public bool Equals(ECardSpineAnimation other)
		{
			return this._Value == other._Value;
		}

		// Token: 0x06035137 RID: 217399 RVA: 0x00C94004 File Offset: 0x00C92204
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is ECardSpineAnimation)
			{
				ECardSpineAnimation other = (ECardSpineAnimation)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06035138 RID: 217400 RVA: 0x00C94029 File Offset: 0x00C92229
		public override int GetHashCode()
		{
			string value = this._Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x06035139 RID: 217401 RVA: 0x00C9403C File Offset: 0x00C9223C
		public static bool operator ==(ECardSpineAnimation left, ECardSpineAnimation right)
		{
			return left.Equals(right);
		}

		// Token: 0x0603513A RID: 217402 RVA: 0x00C94046 File Offset: 0x00C92246
		public static bool operator !=(ECardSpineAnimation left, ECardSpineAnimation right)
		{
			return !left.Equals(right);
		}

		// Token: 0x0401C41D RID: 115741
		private readonly string _Value;

		// Token: 0x0401C41E RID: 115742
		public static readonly ECardSpineAnimation Start = new ECardSpineAnimation("start");

		// Token: 0x0401C41F RID: 115743
		public static readonly ECardSpineAnimation Idle = new ECardSpineAnimation("idle");
	}
}
