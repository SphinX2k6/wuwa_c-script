using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B7A RID: 2938
	public struct CiacconaGalStep : IFlatbufferObject
	{
		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x0600556A RID: 21866 RVA: 0x001F5C5D File Offset: 0x001F3E5D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600556B RID: 21867 RVA: 0x001F5C6A File Offset: 0x001F3E6A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600556C RID: 21868 RVA: 0x001F5C74 File Offset: 0x001F3E74
		public static CiacconaGalStep GetRootAsCiacconaGalStep(ByteBuffer _bb)
		{
			return CiacconaGalStep.GetRootAsCiacconaGalStep(_bb, default(CiacconaGalStep));
		}

		// Token: 0x0600556D RID: 21869 RVA: 0x001F5C90 File Offset: 0x001F3E90
		public static CiacconaGalStep GetRootAsCiacconaGalStep(ByteBuffer _bb, CiacconaGalStep obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600556E RID: 21870 RVA: 0x001F5CAD File Offset: 0x001F3EAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600556F RID: 21871 RVA: 0x001F5CBC File Offset: 0x001F3EBC
		public CiacconaGalStep __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x06005570 RID: 21872 RVA: 0x001F5CCC File Offset: 0x001F3ECC
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

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x06005571 RID: 21873 RVA: 0x001F5D08 File Offset: 0x001F3F08
		public int Type
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x06005572 RID: 21874 RVA: 0x001F5D44 File Offset: 0x001F3F44
		public string Content
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

		// Token: 0x06005573 RID: 21875 RVA: 0x001F5D7B File Offset: 0x001F3F7B
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005574 RID: 21876 RVA: 0x001F5D8A File Offset: 0x001F3F8A
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x06005575 RID: 21877 RVA: 0x001F5DA4 File Offset: 0x001F3FA4
		public string Image
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

		// Token: 0x06005576 RID: 21878 RVA: 0x001F5DDC File Offset: 0x001F3FDC
		public Span<byte> GetImageBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005577 RID: 21879 RVA: 0x001F5DEC File Offset: 0x001F3FEC
		public byte[] GetImageArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x06005578 RID: 21880 RVA: 0x001F5E04 File Offset: 0x001F4004
		public string ImageMale
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005579 RID: 21881 RVA: 0x001F5E3C File Offset: 0x001F403C
		public Span<byte> GetImageMaleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600557A RID: 21882 RVA: 0x001F5E4C File Offset: 0x001F404C
		public byte[] GetImageMaleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x0600557B RID: 21883 RVA: 0x001F5E64 File Offset: 0x001F4064
		public string ImageFemale
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

		// Token: 0x0600557C RID: 21884 RVA: 0x001F5E9C File Offset: 0x001F409C
		public Span<byte> GetImageFemaleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600557D RID: 21885 RVA: 0x001F5EAC File Offset: 0x001F40AC
		public byte[] GetImageFemaleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x0600557E RID: 21886 RVA: 0x001F5EC4 File Offset: 0x001F40C4
		public string Audio
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

		// Token: 0x0600557F RID: 21887 RVA: 0x001F5EFC File Offset: 0x001F40FC
		public Span<byte> GetAudioBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06005580 RID: 21888 RVA: 0x001F5F0C File Offset: 0x001F410C
		public byte[] GetAudioArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x06005581 RID: 21889 RVA: 0x001F5F24 File Offset: 0x001F4124
		public string Music
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

		// Token: 0x06005582 RID: 21890 RVA: 0x001F5F5C File Offset: 0x001F415C
		public Span<byte> GetMusicBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06005583 RID: 21891 RVA: 0x001F5F6C File Offset: 0x001F416C
		public byte[] GetMusicArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x06005584 RID: 21892 RVA: 0x001F5F84 File Offset: 0x001F4184
		public string MusicState
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

		// Token: 0x06005585 RID: 21893 RVA: 0x001F5FBC File Offset: 0x001F41BC
		public Span<byte> GetMusicStateBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06005586 RID: 21894 RVA: 0x001F5FCC File Offset: 0x001F41CC
		public byte[] GetMusicStateArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x06005587 RID: 21895 RVA: 0x001F5FE4 File Offset: 0x001F41E4
		public string Anim
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

		// Token: 0x06005588 RID: 21896 RVA: 0x001F601C File Offset: 0x001F421C
		public Span<byte> GetAnimBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06005589 RID: 21897 RVA: 0x001F602C File Offset: 0x001F422C
		public byte[] GetAnimArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x0600558A RID: 21898 RVA: 0x001F6044 File Offset: 0x001F4244
		public int TriggerSubEnding
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600558B RID: 21899 RVA: 0x001F6084 File Offset: 0x001F4284
		public int Choices(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x0600558C RID: 21900 RVA: 0x001F60C4 File Offset: 0x001F42C4
		public int ChoicesLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600558D RID: 21901 RVA: 0x001F60F0 File Offset: 0x001F42F0
		public Span<int> GetChoicesBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x0600558E RID: 21902 RVA: 0x001F6100 File Offset: 0x001F4300
		public int[] GetChoicesArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x0600558F RID: 21903 RVA: 0x001F6118 File Offset: 0x001F4318
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ChoicesIter()或GetChoicesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Choices()
		{
			CiacconaGalStep ciacconaGalStep = this;
			return ciacconaGalStep.GetChoicesArray() ?? Array.Empty<int>();
		}

		// Token: 0x06005590 RID: 21904 RVA: 0x001F613C File Offset: 0x001F433C
		[NullableContext(1)]
		public readonly IEnumerable<int> ChoicesIter()
		{
			CiacconaGalStep.<ChoicesIter>d__52 <ChoicesIter>d__ = new CiacconaGalStep.<ChoicesIter>d__52(-2);
			<ChoicesIter>d__.<>3__<>4__this = this;
			return <ChoicesIter>d__;
		}

		// Token: 0x04004B7E RID: 19326
		private Table __p;
	}
}
