using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B77 RID: 2935
	public struct CiacconaGalChapter : IFlatbufferObject
	{
		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x06005527 RID: 21799 RVA: 0x001F535C File Offset: 0x001F355C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005528 RID: 21800 RVA: 0x001F5369 File Offset: 0x001F3569
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005529 RID: 21801 RVA: 0x001F5370 File Offset: 0x001F3570
		public static CiacconaGalChapter GetRootAsCiacconaGalChapter(ByteBuffer _bb)
		{
			return CiacconaGalChapter.GetRootAsCiacconaGalChapter(_bb, default(CiacconaGalChapter));
		}

		// Token: 0x0600552A RID: 21802 RVA: 0x001F538C File Offset: 0x001F358C
		public static CiacconaGalChapter GetRootAsCiacconaGalChapter(ByteBuffer _bb, CiacconaGalChapter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600552B RID: 21803 RVA: 0x001F53A9 File Offset: 0x001F35A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600552C RID: 21804 RVA: 0x001F53B8 File Offset: 0x001F35B8
		public CiacconaGalChapter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x0600552D RID: 21805 RVA: 0x001F53C8 File Offset: 0x001F35C8
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

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x0600552E RID: 21806 RVA: 0x001F5404 File Offset: 0x001F3604
		public string Title
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

		// Token: 0x0600552F RID: 21807 RVA: 0x001F543B File Offset: 0x001F363B
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005530 RID: 21808 RVA: 0x001F544A File Offset: 0x001F364A
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x06005531 RID: 21809 RVA: 0x001F5464 File Offset: 0x001F3664
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

		// Token: 0x06005532 RID: 21810 RVA: 0x001F549B File Offset: 0x001F369B
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005533 RID: 21811 RVA: 0x001F54AA File Offset: 0x001F36AA
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x06005534 RID: 21812 RVA: 0x001F54C4 File Offset: 0x001F36C4
		public int Steps(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x06005535 RID: 21813 RVA: 0x001F5504 File Offset: 0x001F3704
		public int StepsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005536 RID: 21814 RVA: 0x001F5530 File Offset: 0x001F3730
		public Span<int> GetStepsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06005537 RID: 21815 RVA: 0x001F5540 File Offset: 0x001F3740
		public int[] GetStepsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x06005538 RID: 21816 RVA: 0x001F5558 File Offset: 0x001F3758
		public string ChapterImageSmall
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

		// Token: 0x06005539 RID: 21817 RVA: 0x001F5590 File Offset: 0x001F3790
		public Span<byte> GetChapterImageSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600553A RID: 21818 RVA: 0x001F55A0 File Offset: 0x001F37A0
		public byte[] GetChapterImageSmallArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x0600553B RID: 21819 RVA: 0x001F55B8 File Offset: 0x001F37B8
		public string ChapterImageLarge
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

		// Token: 0x0600553C RID: 21820 RVA: 0x001F55F0 File Offset: 0x001F37F0
		public Span<byte> GetChapterImageLargeBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600553D RID: 21821 RVA: 0x001F5600 File Offset: 0x001F3800
		public byte[] GetChapterImageLargeArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x0600553E RID: 21822 RVA: 0x001F5618 File Offset: 0x001F3818
		public string MusicEvent
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

		// Token: 0x0600553F RID: 21823 RVA: 0x001F5650 File Offset: 0x001F3850
		public Span<byte> GetMusicEventBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06005540 RID: 21824 RVA: 0x001F5660 File Offset: 0x001F3860
		public byte[] GetMusicEventArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x06005541 RID: 21825 RVA: 0x001F5678 File Offset: 0x001F3878
		public int SubEnding1
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x06005542 RID: 21826 RVA: 0x001F56B8 File Offset: 0x001F38B8
		public int SubEnding2
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x06005543 RID: 21827 RVA: 0x001F56F8 File Offset: 0x001F38F8
		public int SubEnding3
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x06005544 RID: 21828 RVA: 0x001F5738 File Offset: 0x001F3938
		public int BranchPoint
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

		// Token: 0x06005545 RID: 21829 RVA: 0x001F5778 File Offset: 0x001F3978
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用StepsIter()或GetStepsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Steps()
		{
			CiacconaGalChapter ciacconaGalChapter = this;
			return ciacconaGalChapter.GetStepsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06005546 RID: 21830 RVA: 0x001F579C File Offset: 0x001F399C
		[NullableContext(1)]
		public readonly IEnumerable<int> StepsIter()
		{
			CiacconaGalChapter.<StepsIter>d__44 <StepsIter>d__ = new CiacconaGalChapter.<StepsIter>d__44(-2);
			<StepsIter>d__.<>3__<>4__this = this;
			return <StepsIter>d__;
		}

		// Token: 0x04004B7B RID: 19323
		private Table __p;
	}
}
