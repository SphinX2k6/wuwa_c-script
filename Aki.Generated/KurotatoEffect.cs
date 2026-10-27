using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D9C RID: 3484
	public struct KurotatoEffect : IFlatbufferObject
	{
		// Token: 0x17001B50 RID: 6992
		// (get) Token: 0x06008949 RID: 35145 RVA: 0x0026D425 File Offset: 0x0026B625
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600894A RID: 35146 RVA: 0x0026D432 File Offset: 0x0026B632
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600894B RID: 35147 RVA: 0x0026D43C File Offset: 0x0026B63C
		public static KurotatoEffect GetRootAsKurotatoEffect(ByteBuffer _bb)
		{
			return KurotatoEffect.GetRootAsKurotatoEffect(_bb, default(KurotatoEffect));
		}

		// Token: 0x0600894C RID: 35148 RVA: 0x0026D458 File Offset: 0x0026B658
		public static KurotatoEffect GetRootAsKurotatoEffect(ByteBuffer _bb, KurotatoEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600894D RID: 35149 RVA: 0x0026D475 File Offset: 0x0026B675
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600894E RID: 35150 RVA: 0x0026D484 File Offset: 0x0026B684
		public KurotatoEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001B51 RID: 6993
		// (get) Token: 0x0600894F RID: 35151 RVA: 0x0026D494 File Offset: 0x0026B694
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

		// Token: 0x17001B52 RID: 6994
		// (get) Token: 0x06008950 RID: 35152 RVA: 0x0026D4D0 File Offset: 0x0026B6D0
		public string Type
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

		// Token: 0x06008951 RID: 35153 RVA: 0x0026D507 File Offset: 0x0026B707
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008952 RID: 35154 RVA: 0x0026D516 File Offset: 0x0026B716
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001B53 RID: 6995
		// (get) Token: 0x06008953 RID: 35155 RVA: 0x0026D530 File Offset: 0x0026B730
		public int DisableShow
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001B54 RID: 6996
		// (get) Token: 0x06008954 RID: 35156 RVA: 0x0026D56C File Offset: 0x0026B76C
		public string Desc
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

		// Token: 0x06008955 RID: 35157 RVA: 0x0026D5A4 File Offset: 0x0026B7A4
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008956 RID: 35158 RVA: 0x0026D5B4 File Offset: 0x0026B7B4
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x06008957 RID: 35159 RVA: 0x0026D5CC File Offset: 0x0026B7CC
		public int DescArgs(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001B55 RID: 6997
		// (get) Token: 0x06008958 RID: 35160 RVA: 0x0026D60C File Offset: 0x0026B80C
		public int DescArgsLength
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

		// Token: 0x06008959 RID: 35161 RVA: 0x0026D638 File Offset: 0x0026B838
		public Span<int> GetDescArgsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600895A RID: 35162 RVA: 0x0026D648 File Offset: 0x0026B848
		public int[] GetDescArgsArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17001B56 RID: 6998
		// (get) Token: 0x0600895B RID: 35163 RVA: 0x0026D660 File Offset: 0x0026B860
		public string Param1
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600895C RID: 35164 RVA: 0x0026D698 File Offset: 0x0026B898
		public Span<byte> GetParam1Bytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600895D RID: 35165 RVA: 0x0026D6A8 File Offset: 0x0026B8A8
		public byte[] GetParam1Array()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001B57 RID: 6999
		// (get) Token: 0x0600895E RID: 35166 RVA: 0x0026D6C0 File Offset: 0x0026B8C0
		public string Param2
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600895F RID: 35167 RVA: 0x0026D6F8 File Offset: 0x0026B8F8
		public Span<byte> GetParam2Bytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06008960 RID: 35168 RVA: 0x0026D708 File Offset: 0x0026B908
		public byte[] GetParam2Array()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001B58 RID: 7000
		// (get) Token: 0x06008961 RID: 35169 RVA: 0x0026D720 File Offset: 0x0026B920
		public string Param3
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008962 RID: 35170 RVA: 0x0026D758 File Offset: 0x0026B958
		public Span<byte> GetParam3Bytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06008963 RID: 35171 RVA: 0x0026D768 File Offset: 0x0026B968
		public byte[] GetParam3Array()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17001B59 RID: 7001
		// (get) Token: 0x06008964 RID: 35172 RVA: 0x0026D780 File Offset: 0x0026B980
		public string Param4
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008965 RID: 35173 RVA: 0x0026D7B8 File Offset: 0x0026B9B8
		public Span<byte> GetParam4Bytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06008966 RID: 35174 RVA: 0x0026D7C8 File Offset: 0x0026B9C8
		public byte[] GetParam4Array()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17001B5A RID: 7002
		// (get) Token: 0x06008967 RID: 35175 RVA: 0x0026D7E0 File Offset: 0x0026B9E0
		public string Param5
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008968 RID: 35176 RVA: 0x0026D818 File Offset: 0x0026BA18
		public Span<byte> GetParam5Bytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06008969 RID: 35177 RVA: 0x0026D828 File Offset: 0x0026BA28
		public byte[] GetParam5Array()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x0600896A RID: 35178 RVA: 0x0026D840 File Offset: 0x0026BA40
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DescArgsIter()或GetDescArgsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] DescArgs()
		{
			KurotatoEffect kurotatoEffect = this;
			return kurotatoEffect.GetDescArgsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600896B RID: 35179 RVA: 0x0026D864 File Offset: 0x0026BA64
		[NullableContext(1)]
		public readonly IEnumerable<int> DescArgsIter()
		{
			KurotatoEffect.<DescArgsIter>d__46 <DescArgsIter>d__ = new KurotatoEffect.<DescArgsIter>d__46(-2);
			<DescArgsIter>d__.<>3__<>4__this = this;
			return <DescArgsIter>d__;
		}

		// Token: 0x04004E2C RID: 20012
		private Table __p;
	}
}
