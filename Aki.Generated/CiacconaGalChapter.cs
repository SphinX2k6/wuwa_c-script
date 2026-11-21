using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C58 RID: 3160
	public struct CiacconaGalChapter : IFlatbufferObject
	{
		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x06005AF5 RID: 23285 RVA: 0x0021516C File Offset: 0x0021336C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005AF6 RID: 23286 RVA: 0x00215179 File Offset: 0x00213379
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005AF7 RID: 23287 RVA: 0x00215180 File Offset: 0x00213380
		public static CiacconaGalChapter GetRootAsCiacconaGalChapter(ByteBuffer _bb)
		{
			return CiacconaGalChapter.GetRootAsCiacconaGalChapter(_bb, default(CiacconaGalChapter));
		}

		// Token: 0x06005AF8 RID: 23288 RVA: 0x0021519C File Offset: 0x0021339C
		public static CiacconaGalChapter GetRootAsCiacconaGalChapter(ByteBuffer _bb, CiacconaGalChapter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005AF9 RID: 23289 RVA: 0x002151B9 File Offset: 0x002133B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005AFA RID: 23290 RVA: 0x002151C8 File Offset: 0x002133C8
		public CiacconaGalChapter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x06005AFB RID: 23291 RVA: 0x002151D8 File Offset: 0x002133D8
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

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x06005AFC RID: 23292 RVA: 0x00215214 File Offset: 0x00213414
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

		// Token: 0x06005AFD RID: 23293 RVA: 0x0021524B File Offset: 0x0021344B
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005AFE RID: 23294 RVA: 0x0021525A File Offset: 0x0021345A
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x06005AFF RID: 23295 RVA: 0x00215274 File Offset: 0x00213474
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

		// Token: 0x06005B00 RID: 23296 RVA: 0x002152AB File Offset: 0x002134AB
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005B01 RID: 23297 RVA: 0x002152BA File Offset: 0x002134BA
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x06005B02 RID: 23298 RVA: 0x002152D4 File Offset: 0x002134D4
		public int Steps(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x06005B03 RID: 23299 RVA: 0x00215314 File Offset: 0x00213514
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

		// Token: 0x06005B04 RID: 23300 RVA: 0x00215340 File Offset: 0x00213540
		public Span<int> GetStepsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06005B05 RID: 23301 RVA: 0x00215350 File Offset: 0x00213550
		public int[] GetStepsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06005B06 RID: 23302 RVA: 0x00215368 File Offset: 0x00213568
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

		// Token: 0x06005B07 RID: 23303 RVA: 0x002153A0 File Offset: 0x002135A0
		public Span<byte> GetChapterImageSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06005B08 RID: 23304 RVA: 0x002153B0 File Offset: 0x002135B0
		public byte[] GetChapterImageSmallArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x06005B09 RID: 23305 RVA: 0x002153C8 File Offset: 0x002135C8
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

		// Token: 0x06005B0A RID: 23306 RVA: 0x00215400 File Offset: 0x00213600
		public Span<byte> GetChapterImageLargeBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06005B0B RID: 23307 RVA: 0x00215410 File Offset: 0x00213610
		public byte[] GetChapterImageLargeArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x06005B0C RID: 23308 RVA: 0x00215428 File Offset: 0x00213628
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

		// Token: 0x06005B0D RID: 23309 RVA: 0x00215460 File Offset: 0x00213660
		public Span<byte> GetMusicEventBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06005B0E RID: 23310 RVA: 0x00215470 File Offset: 0x00213670
		public byte[] GetMusicEventArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x06005B0F RID: 23311 RVA: 0x00215488 File Offset: 0x00213688
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

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x06005B10 RID: 23312 RVA: 0x002154C8 File Offset: 0x002136C8
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

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06005B11 RID: 23313 RVA: 0x00215508 File Offset: 0x00213708
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

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x06005B12 RID: 23314 RVA: 0x00215548 File Offset: 0x00213748
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

		// Token: 0x06005B13 RID: 23315 RVA: 0x00215585 File Offset: 0x00213785
		[NullableContext(1)]
		public int[] Steps()
		{
			return this.GetStepsArray();
		}

		// Token: 0x06005B14 RID: 23316 RVA: 0x0021558D File Offset: 0x0021378D
		[NullableContext(1)]
		public IEnumerable<int> StepsIter()
		{
			CiacconaGalChapter.<StepsIter>d__44 <StepsIter>d__ = new CiacconaGalChapter.<StepsIter>d__44(-2);
			<StepsIter>d__.<>3__<>4__this = this;
			return <StepsIter>d__;
		}

		// Token: 0x0400515C RID: 20828
		private Table __p;
	}
}
