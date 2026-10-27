using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D98 RID: 3480
	public struct KurotatoCharacterUpgrade : IFlatbufferObject
	{
		// Token: 0x17001B3B RID: 6971
		// (get) Token: 0x06008905 RID: 35077 RVA: 0x0026CB5F File Offset: 0x0026AD5F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008906 RID: 35078 RVA: 0x0026CB6C File Offset: 0x0026AD6C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008907 RID: 35079 RVA: 0x0026CB74 File Offset: 0x0026AD74
		public static KurotatoCharacterUpgrade GetRootAsKurotatoCharacterUpgrade(ByteBuffer _bb)
		{
			return KurotatoCharacterUpgrade.GetRootAsKurotatoCharacterUpgrade(_bb, default(KurotatoCharacterUpgrade));
		}

		// Token: 0x06008908 RID: 35080 RVA: 0x0026CB90 File Offset: 0x0026AD90
		public static KurotatoCharacterUpgrade GetRootAsKurotatoCharacterUpgrade(ByteBuffer _bb, KurotatoCharacterUpgrade obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008909 RID: 35081 RVA: 0x0026CBAD File Offset: 0x0026ADAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600890A RID: 35082 RVA: 0x0026CBBC File Offset: 0x0026ADBC
		public KurotatoCharacterUpgrade __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001B3C RID: 6972
		// (get) Token: 0x0600890B RID: 35083 RVA: 0x0026CBCC File Offset: 0x0026ADCC
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

		// Token: 0x0600890C RID: 35084 RVA: 0x0026CC08 File Offset: 0x0026AE08
		public int RewardItem(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001B3D RID: 6973
		// (get) Token: 0x0600890D RID: 35085 RVA: 0x0026CC48 File Offset: 0x0026AE48
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

		// Token: 0x0600890E RID: 35086 RVA: 0x0026CC73 File Offset: 0x0026AE73
		public Span<int> GetRewardItemBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600890F RID: 35087 RVA: 0x0026CC82 File Offset: 0x0026AE82
		public int[] GetRewardItemArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06008910 RID: 35088 RVA: 0x0026CC9C File Offset: 0x0026AE9C
		public int RewardEffect(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001B3E RID: 6974
		// (get) Token: 0x06008911 RID: 35089 RVA: 0x0026CCDC File Offset: 0x0026AEDC
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

		// Token: 0x06008912 RID: 35090 RVA: 0x0026CD07 File Offset: 0x0026AF07
		public Span<int> GetRewardEffectBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06008913 RID: 35091 RVA: 0x0026CD16 File Offset: 0x0026AF16
		public int[] GetRewardEffectArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x06008914 RID: 35092 RVA: 0x0026CD30 File Offset: 0x0026AF30
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RewardEffectIter()或GetRewardEffectBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RewardEffect()
		{
			KurotatoCharacterUpgrade kurotatoCharacterUpgrade = this;
			return kurotatoCharacterUpgrade.GetRewardEffectArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008915 RID: 35093 RVA: 0x0026CD54 File Offset: 0x0026AF54
		[NullableContext(1)]
		public readonly IEnumerable<int> RewardEffectIter()
		{
			KurotatoCharacterUpgrade.<RewardEffectIter>d__21 <RewardEffectIter>d__ = new KurotatoCharacterUpgrade.<RewardEffectIter>d__21(-2);
			<RewardEffectIter>d__.<>3__<>4__this = this;
			return <RewardEffectIter>d__;
		}

		// Token: 0x06008916 RID: 35094 RVA: 0x0026CD6C File Offset: 0x0026AF6C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RewardItemIter()或GetRewardItemBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RewardItem()
		{
			KurotatoCharacterUpgrade kurotatoCharacterUpgrade = this;
			return kurotatoCharacterUpgrade.GetRewardItemArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008917 RID: 35095 RVA: 0x0026CD90 File Offset: 0x0026AF90
		[NullableContext(1)]
		public readonly IEnumerable<int> RewardItemIter()
		{
			KurotatoCharacterUpgrade.<RewardItemIter>d__23 <RewardItemIter>d__ = new KurotatoCharacterUpgrade.<RewardItemIter>d__23(-2);
			<RewardItemIter>d__.<>3__<>4__this = this;
			return <RewardItemIter>d__;
		}

		// Token: 0x04004E28 RID: 20008
		private Table __p;
	}
}
