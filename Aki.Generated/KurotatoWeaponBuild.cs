using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DBA RID: 3514
	public struct KurotatoWeaponBuild : IFlatbufferObject
	{
		// Token: 0x17001C69 RID: 7273
		// (get) Token: 0x06008C6E RID: 35950 RVA: 0x002744DA File Offset: 0x002726DA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008C6F RID: 35951 RVA: 0x002744E7 File Offset: 0x002726E7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008C70 RID: 35952 RVA: 0x002744F0 File Offset: 0x002726F0
		public static KurotatoWeaponBuild GetRootAsKurotatoWeaponBuild(ByteBuffer _bb)
		{
			return KurotatoWeaponBuild.GetRootAsKurotatoWeaponBuild(_bb, default(KurotatoWeaponBuild));
		}

		// Token: 0x06008C71 RID: 35953 RVA: 0x0027450C File Offset: 0x0027270C
		public static KurotatoWeaponBuild GetRootAsKurotatoWeaponBuild(ByteBuffer _bb, KurotatoWeaponBuild obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008C72 RID: 35954 RVA: 0x00274529 File Offset: 0x00272729
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008C73 RID: 35955 RVA: 0x00274538 File Offset: 0x00272738
		public KurotatoWeaponBuild __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001C6A RID: 7274
		// (get) Token: 0x06008C74 RID: 35956 RVA: 0x00274548 File Offset: 0x00272748
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

		// Token: 0x17001C6B RID: 7275
		// (get) Token: 0x06008C75 RID: 35957 RVA: 0x00274584 File Offset: 0x00272784
		public string Name
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008C76 RID: 35958 RVA: 0x002745BB File Offset: 0x002727BB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008C77 RID: 35959 RVA: 0x002745CA File Offset: 0x002727CA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C6C RID: 7276
		// (get) Token: 0x06008C78 RID: 35960 RVA: 0x002745E4 File Offset: 0x002727E4
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008C79 RID: 35961 RVA: 0x0027461B File Offset: 0x0027281B
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008C7A RID: 35962 RVA: 0x0027462A File Offset: 0x0027282A
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C6D RID: 7277
		// (get) Token: 0x06008C7B RID: 35963 RVA: 0x00274644 File Offset: 0x00272844
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008C7C RID: 35964 RVA: 0x0027467C File Offset: 0x0027287C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008C7D RID: 35965 RVA: 0x0027468C File Offset: 0x0027288C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x06008C7E RID: 35966 RVA: 0x002746A4 File Offset: 0x002728A4
		public int OneEffects(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001C6E RID: 7278
		// (get) Token: 0x06008C7F RID: 35967 RVA: 0x002746E4 File Offset: 0x002728E4
		public int OneEffectsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008C80 RID: 35968 RVA: 0x00274710 File Offset: 0x00272910
		public Span<int> GetOneEffectsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06008C81 RID: 35969 RVA: 0x00274720 File Offset: 0x00272920
		public int[] GetOneEffectsArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x06008C82 RID: 35970 RVA: 0x00274738 File Offset: 0x00272938
		public int TwoEffects(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001C6F RID: 7279
		// (get) Token: 0x06008C83 RID: 35971 RVA: 0x00274778 File Offset: 0x00272978
		public int TwoEffectsLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008C84 RID: 35972 RVA: 0x002747A4 File Offset: 0x002729A4
		public Span<int> GetTwoEffectsBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x06008C85 RID: 35973 RVA: 0x002747B4 File Offset: 0x002729B4
		public int[] GetTwoEffectsArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x06008C86 RID: 35974 RVA: 0x002747CC File Offset: 0x002729CC
		public int ThreeEffect(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001C70 RID: 7280
		// (get) Token: 0x06008C87 RID: 35975 RVA: 0x0027480C File Offset: 0x00272A0C
		public int ThreeEffectLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008C88 RID: 35976 RVA: 0x00274838 File Offset: 0x00272A38
		public Span<int> GetThreeEffectBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x06008C89 RID: 35977 RVA: 0x00274848 File Offset: 0x00272A48
		public int[] GetThreeEffectArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x06008C8A RID: 35978 RVA: 0x00274860 File Offset: 0x00272A60
		public int FourEffect(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001C71 RID: 7281
		// (get) Token: 0x06008C8B RID: 35979 RVA: 0x002748A0 File Offset: 0x00272AA0
		public int FourEffectLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008C8C RID: 35980 RVA: 0x002748CC File Offset: 0x00272ACC
		public Span<int> GetFourEffectBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x06008C8D RID: 35981 RVA: 0x002748DC File Offset: 0x00272ADC
		public int[] GetFourEffectArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x06008C8E RID: 35982 RVA: 0x002748F4 File Offset: 0x00272AF4
		public int FiveEffect(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001C72 RID: 7282
		// (get) Token: 0x06008C8F RID: 35983 RVA: 0x00274934 File Offset: 0x00272B34
		public int FiveEffectLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008C90 RID: 35984 RVA: 0x00274960 File Offset: 0x00272B60
		public Span<int> GetFiveEffectBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x06008C91 RID: 35985 RVA: 0x00274970 File Offset: 0x00272B70
		public int[] GetFiveEffectArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x06008C92 RID: 35986 RVA: 0x00274988 File Offset: 0x00272B88
		public int SixEffect(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001C73 RID: 7283
		// (get) Token: 0x06008C93 RID: 35987 RVA: 0x002749C8 File Offset: 0x00272BC8
		public int SixEffectLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008C94 RID: 35988 RVA: 0x002749F4 File Offset: 0x00272BF4
		public Span<int> GetSixEffectBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x06008C95 RID: 35989 RVA: 0x00274A04 File Offset: 0x00272C04
		public int[] GetSixEffectArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x06008C96 RID: 35990 RVA: 0x00274A1C File Offset: 0x00272C1C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FiveEffectIter()或GetFiveEffectBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] FiveEffect()
		{
			KurotatoWeaponBuild kurotatoWeaponBuild = this;
			return kurotatoWeaponBuild.GetFiveEffectArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008C97 RID: 35991 RVA: 0x00274A40 File Offset: 0x00272C40
		[NullableContext(1)]
		public readonly IEnumerable<int> FiveEffectIter()
		{
			KurotatoWeaponBuild.<FiveEffectIter>d__53 <FiveEffectIter>d__ = new KurotatoWeaponBuild.<FiveEffectIter>d__53(-2);
			<FiveEffectIter>d__.<>3__<>4__this = this;
			return <FiveEffectIter>d__;
		}

		// Token: 0x06008C98 RID: 35992 RVA: 0x00274A58 File Offset: 0x00272C58
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FourEffectIter()或GetFourEffectBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] FourEffect()
		{
			KurotatoWeaponBuild kurotatoWeaponBuild = this;
			return kurotatoWeaponBuild.GetFourEffectArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008C99 RID: 35993 RVA: 0x00274A7C File Offset: 0x00272C7C
		[NullableContext(1)]
		public readonly IEnumerable<int> FourEffectIter()
		{
			KurotatoWeaponBuild.<FourEffectIter>d__55 <FourEffectIter>d__ = new KurotatoWeaponBuild.<FourEffectIter>d__55(-2);
			<FourEffectIter>d__.<>3__<>4__this = this;
			return <FourEffectIter>d__;
		}

		// Token: 0x06008C9A RID: 35994 RVA: 0x00274A94 File Offset: 0x00272C94
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用OneEffectsIter()或GetOneEffectsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] OneEffects()
		{
			KurotatoWeaponBuild kurotatoWeaponBuild = this;
			return kurotatoWeaponBuild.GetOneEffectsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008C9B RID: 35995 RVA: 0x00274AB8 File Offset: 0x00272CB8
		[NullableContext(1)]
		public readonly IEnumerable<int> OneEffectsIter()
		{
			KurotatoWeaponBuild.<OneEffectsIter>d__57 <OneEffectsIter>d__ = new KurotatoWeaponBuild.<OneEffectsIter>d__57(-2);
			<OneEffectsIter>d__.<>3__<>4__this = this;
			return <OneEffectsIter>d__;
		}

		// Token: 0x06008C9C RID: 35996 RVA: 0x00274AD0 File Offset: 0x00272CD0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SixEffectIter()或GetSixEffectBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SixEffect()
		{
			KurotatoWeaponBuild kurotatoWeaponBuild = this;
			return kurotatoWeaponBuild.GetSixEffectArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008C9D RID: 35997 RVA: 0x00274AF4 File Offset: 0x00272CF4
		[NullableContext(1)]
		public readonly IEnumerable<int> SixEffectIter()
		{
			KurotatoWeaponBuild.<SixEffectIter>d__59 <SixEffectIter>d__ = new KurotatoWeaponBuild.<SixEffectIter>d__59(-2);
			<SixEffectIter>d__.<>3__<>4__this = this;
			return <SixEffectIter>d__;
		}

		// Token: 0x06008C9E RID: 35998 RVA: 0x00274B0C File Offset: 0x00272D0C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ThreeEffectIter()或GetThreeEffectBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ThreeEffect()
		{
			KurotatoWeaponBuild kurotatoWeaponBuild = this;
			return kurotatoWeaponBuild.GetThreeEffectArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008C9F RID: 35999 RVA: 0x00274B30 File Offset: 0x00272D30
		[NullableContext(1)]
		public readonly IEnumerable<int> ThreeEffectIter()
		{
			KurotatoWeaponBuild.<ThreeEffectIter>d__61 <ThreeEffectIter>d__ = new KurotatoWeaponBuild.<ThreeEffectIter>d__61(-2);
			<ThreeEffectIter>d__.<>3__<>4__this = this;
			return <ThreeEffectIter>d__;
		}

		// Token: 0x06008CA0 RID: 36000 RVA: 0x00274B48 File Offset: 0x00272D48
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TwoEffectsIter()或GetTwoEffectsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] TwoEffects()
		{
			KurotatoWeaponBuild kurotatoWeaponBuild = this;
			return kurotatoWeaponBuild.GetTwoEffectsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008CA1 RID: 36001 RVA: 0x00274B6C File Offset: 0x00272D6C
		[NullableContext(1)]
		public readonly IEnumerable<int> TwoEffectsIter()
		{
			KurotatoWeaponBuild.<TwoEffectsIter>d__63 <TwoEffectsIter>d__ = new KurotatoWeaponBuild.<TwoEffectsIter>d__63(-2);
			<TwoEffectsIter>d__.<>3__<>4__this = this;
			return <TwoEffectsIter>d__;
		}

		// Token: 0x04004E50 RID: 20048
		private Table __p;
	}
}
