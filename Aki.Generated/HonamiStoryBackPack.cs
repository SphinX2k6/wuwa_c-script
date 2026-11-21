using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E15 RID: 3605
	public struct HonamiStoryBackPack : IFlatbufferObject
	{
		// Token: 0x170017C3 RID: 6083
		// (get) Token: 0x06008534 RID: 34100 RVA: 0x00274233 File Offset: 0x00272433
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008535 RID: 34101 RVA: 0x00274240 File Offset: 0x00272440
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008536 RID: 34102 RVA: 0x00274248 File Offset: 0x00272448
		public static HonamiStoryBackPack GetRootAsHonamiStoryBackPack(ByteBuffer _bb)
		{
			return HonamiStoryBackPack.GetRootAsHonamiStoryBackPack(_bb, default(HonamiStoryBackPack));
		}

		// Token: 0x06008537 RID: 34103 RVA: 0x00274264 File Offset: 0x00272464
		public static HonamiStoryBackPack GetRootAsHonamiStoryBackPack(ByteBuffer _bb, HonamiStoryBackPack obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008538 RID: 34104 RVA: 0x00274281 File Offset: 0x00272481
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008539 RID: 34105 RVA: 0x00274290 File Offset: 0x00272490
		public HonamiStoryBackPack __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170017C4 RID: 6084
		// (get) Token: 0x0600853A RID: 34106 RVA: 0x002742A0 File Offset: 0x002724A0
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

		// Token: 0x170017C5 RID: 6085
		// (get) Token: 0x0600853B RID: 34107 RVA: 0x002742DC File Offset: 0x002724DC
		public int Type
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170017C6 RID: 6086
		// (get) Token: 0x0600853C RID: 34108 RVA: 0x00274318 File Offset: 0x00272518
		public int ActivityId
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

		// Token: 0x170017C7 RID: 6087
		// (get) Token: 0x0600853D RID: 34109 RVA: 0x00274354 File Offset: 0x00272554
		public int Wide
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600853E RID: 34110 RVA: 0x00274394 File Offset: 0x00272594
		public int Size(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170017C8 RID: 6088
		// (get) Token: 0x0600853F RID: 34111 RVA: 0x002743D4 File Offset: 0x002725D4
		public int SizeLength
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

		// Token: 0x06008540 RID: 34112 RVA: 0x00274400 File Offset: 0x00272600
		public Span<int> GetSizeBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06008541 RID: 34113 RVA: 0x00274410 File Offset: 0x00272610
		public int[] GetSizeArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x170017C9 RID: 6089
		// (get) Token: 0x06008542 RID: 34114 RVA: 0x00274428 File Offset: 0x00272628
		public int CanOrganize
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008543 RID: 34115 RVA: 0x00274465 File Offset: 0x00272665
		[NullableContext(1)]
		public int[] Size()
		{
			return this.GetSizeArray();
		}

		// Token: 0x06008544 RID: 34116 RVA: 0x0027446D File Offset: 0x0027266D
		[NullableContext(1)]
		public IEnumerable<int> SizeIter()
		{
			HonamiStoryBackPack.<SizeIter>d__24 <SizeIter>d__ = new HonamiStoryBackPack.<SizeIter>d__24(-2);
			<SizeIter>d__.<>3__<>4__this = this;
			return <SizeIter>d__;
		}

		// Token: 0x0400538E RID: 21390
		private Table __p;
	}
}
