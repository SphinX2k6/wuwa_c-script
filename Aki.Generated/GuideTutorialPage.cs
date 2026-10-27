using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D1E RID: 3358
	public struct GuideTutorialPage : IFlatbufferObject
	{
		// Token: 0x170016B2 RID: 5810
		// (get) Token: 0x06007D74 RID: 32116 RVA: 0x00251E85 File Offset: 0x00250085
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007D75 RID: 32117 RVA: 0x00251E92 File Offset: 0x00250092
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007D76 RID: 32118 RVA: 0x00251E9C File Offset: 0x0025009C
		public static GuideTutorialPage GetRootAsGuideTutorialPage(ByteBuffer _bb)
		{
			return GuideTutorialPage.GetRootAsGuideTutorialPage(_bb, default(GuideTutorialPage));
		}

		// Token: 0x06007D77 RID: 32119 RVA: 0x00251EB8 File Offset: 0x002500B8
		public static GuideTutorialPage GetRootAsGuideTutorialPage(ByteBuffer _bb, GuideTutorialPage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007D78 RID: 32120 RVA: 0x00251ED5 File Offset: 0x002500D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007D79 RID: 32121 RVA: 0x00251EE4 File Offset: 0x002500E4
		public GuideTutorialPage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170016B3 RID: 5811
		// (get) Token: 0x06007D7A RID: 32122 RVA: 0x00251EF4 File Offset: 0x002500F4
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

		// Token: 0x170016B4 RID: 5812
		// (get) Token: 0x06007D7B RID: 32123 RVA: 0x00251F30 File Offset: 0x00250130
		public string Pic
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

		// Token: 0x06007D7C RID: 32124 RVA: 0x00251F67 File Offset: 0x00250167
		public Span<byte> GetPicBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007D7D RID: 32125 RVA: 0x00251F76 File Offset: 0x00250176
		public byte[] GetPicArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170016B5 RID: 5813
		// (get) Token: 0x06007D7E RID: 32126 RVA: 0x00251F90 File Offset: 0x00250190
		public string Title
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

		// Token: 0x06007D7F RID: 32127 RVA: 0x00251FC7 File Offset: 0x002501C7
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007D80 RID: 32128 RVA: 0x00251FD6 File Offset: 0x002501D6
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170016B6 RID: 5814
		// (get) Token: 0x06007D81 RID: 32129 RVA: 0x00251FF0 File Offset: 0x002501F0
		public string SubTitle
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

		// Token: 0x06007D82 RID: 32130 RVA: 0x00252028 File Offset: 0x00250228
		public Span<byte> GetSubTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007D83 RID: 32131 RVA: 0x00252038 File Offset: 0x00250238
		public byte[] GetSubTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170016B7 RID: 5815
		// (get) Token: 0x06007D84 RID: 32132 RVA: 0x00252050 File Offset: 0x00250250
		public string Content
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

		// Token: 0x06007D85 RID: 32133 RVA: 0x00252088 File Offset: 0x00250288
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007D86 RID: 32134 RVA: 0x00252098 File Offset: 0x00250298
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x06007D87 RID: 32135 RVA: 0x002520B0 File Offset: 0x002502B0
		public string Button(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170016B8 RID: 5816
		// (get) Token: 0x06007D88 RID: 32136 RVA: 0x002520EC File Offset: 0x002502EC
		public int ButtonLength
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

		// Token: 0x06007D89 RID: 32137 RVA: 0x00252118 File Offset: 0x00250318
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ButtonIter()或GetButtonBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Button()
		{
			return this.ButtonIter().ToArray<string>();
		}

		// Token: 0x06007D8A RID: 32138 RVA: 0x00252125 File Offset: 0x00250325
		[NullableContext(1)]
		public readonly IEnumerable<string> ButtonIter()
		{
			GuideTutorialPage.<ButtonIter>d__30 <ButtonIter>d__ = new GuideTutorialPage.<ButtonIter>d__30(-2);
			<ButtonIter>d__.<>3__<>4__this = this;
			return <ButtonIter>d__;
		}

		// Token: 0x04004D96 RID: 19862
		private Table __p;
	}
}
