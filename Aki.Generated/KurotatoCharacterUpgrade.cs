using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E7D RID: 3709
	public struct KurotatoCharacterUpgrade : IFlatbufferObject
	{
		// Token: 0x17001B9F RID: 7071
		// (get) Token: 0x06008F21 RID: 36641 RVA: 0x0028B791 File Offset: 0x00289991
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008F22 RID: 36642 RVA: 0x0028B79E File Offset: 0x0028999E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008F23 RID: 36643 RVA: 0x0028B7A8 File Offset: 0x002899A8
		public static KurotatoCharacterUpgrade GetRootAsKurotatoCharacterUpgrade(ByteBuffer _bb)
		{
			return KurotatoCharacterUpgrade.GetRootAsKurotatoCharacterUpgrade(_bb, default(KurotatoCharacterUpgrade));
		}

		// Token: 0x06008F24 RID: 36644 RVA: 0x0028B7C4 File Offset: 0x002899C4
		public static KurotatoCharacterUpgrade GetRootAsKurotatoCharacterUpgrade(ByteBuffer _bb, KurotatoCharacterUpgrade obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008F25 RID: 36645 RVA: 0x0028B7E1 File Offset: 0x002899E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008F26 RID: 36646 RVA: 0x0028B7F0 File Offset: 0x002899F0
		public KurotatoCharacterUpgrade __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001BA0 RID: 7072
		// (get) Token: 0x06008F27 RID: 36647 RVA: 0x0028B800 File Offset: 0x00289A00
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008F28 RID: 36648 RVA: 0x0028B83C File Offset: 0x00289A3C
		public int RewardItem(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001BA1 RID: 7073
		// (get) Token: 0x06008F29 RID: 36649 RVA: 0x0028B87C File Offset: 0x00289A7C
		public int RewardItemLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008F2A RID: 36650 RVA: 0x0028B8A7 File Offset: 0x00289AA7
		public Span<int> GetRewardItemBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06008F2B RID: 36651 RVA: 0x0028B8B6 File Offset: 0x00289AB6
		public int[] GetRewardItemArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06008F2C RID: 36652 RVA: 0x0028B8D0 File Offset: 0x00289AD0
		public int RewardEffect(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001BA2 RID: 7074
		// (get) Token: 0x06008F2D RID: 36653 RVA: 0x0028B910 File Offset: 0x00289B10
		public int RewardEffectLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008F2E RID: 36654 RVA: 0x0028B93B File Offset: 0x00289B3B
		public Span<int> GetRewardEffectBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06008F2F RID: 36655 RVA: 0x0028B94A File Offset: 0x00289B4A
		public int[] GetRewardEffectArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x06008F30 RID: 36656 RVA: 0x0028B961 File Offset: 0x00289B61
		[NullableContext(1)]
		public int[] RewardEffect()
		{
			return this.GetRewardEffectArray();
		}

		// Token: 0x06008F31 RID: 36657 RVA: 0x0028B969 File Offset: 0x00289B69
		[NullableContext(1)]
		public IEnumerable<int> RewardEffectIter()
		{
			KurotatoCharacterUpgrade.<RewardEffectIter>d__21 <RewardEffectIter>d__ = new KurotatoCharacterUpgrade.<RewardEffectIter>d__21(-2);
			<RewardEffectIter>d__.<>3__<>4__this = this;
			return <RewardEffectIter>d__;
		}

		// Token: 0x06008F32 RID: 36658 RVA: 0x0028B97E File Offset: 0x00289B7E
		[NullableContext(1)]
		public int[] RewardItem()
		{
			return this.GetRewardItemArray();
		}

		// Token: 0x06008F33 RID: 36659 RVA: 0x0028B986 File Offset: 0x00289B86
		[NullableContext(1)]
		public IEnumerable<int> RewardItemIter()
		{
			KurotatoCharacterUpgrade.<RewardItemIter>d__23 <RewardItemIter>d__ = new KurotatoCharacterUpgrade.<RewardItemIter>d__23(-2);
			<RewardItemIter>d__.<>3__<>4__this = this;
			return <RewardItemIter>d__;
		}

		// Token: 0x0400540D RID: 21517
		private Table __p;
	}
}
