using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001175 RID: 4469
	public struct TreasureBoxDetectorMark : IFlatbufferObject
	{
		// Token: 0x17003CC2 RID: 15554
		// (get) Token: 0x0600E525 RID: 58661 RVA: 0x0033C171 File Offset: 0x0033A371
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E526 RID: 58662 RVA: 0x0033C17E File Offset: 0x0033A37E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E527 RID: 58663 RVA: 0x0033C188 File Offset: 0x0033A388
		public static TreasureBoxDetectorMark GetRootAsTreasureBoxDetectorMark(ByteBuffer _bb)
		{
			return TreasureBoxDetectorMark.GetRootAsTreasureBoxDetectorMark(_bb, default(TreasureBoxDetectorMark));
		}

		// Token: 0x0600E528 RID: 58664 RVA: 0x0033C1A4 File Offset: 0x0033A3A4
		public static TreasureBoxDetectorMark GetRootAsTreasureBoxDetectorMark(ByteBuffer _bb, TreasureBoxDetectorMark obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E529 RID: 58665 RVA: 0x0033C1C1 File Offset: 0x0033A3C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E52A RID: 58666 RVA: 0x0033C1D0 File Offset: 0x0033A3D0
		public TreasureBoxDetectorMark __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003CC3 RID: 15555
		// (get) Token: 0x0600E52B RID: 58667 RVA: 0x0033C1E0 File Offset: 0x0033A3E0
		public int MarkId
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

		// Token: 0x17003CC4 RID: 15556
		// (get) Token: 0x0600E52C RID: 58668 RVA: 0x0033C21C File Offset: 0x0033A41C
		public string MarkPic
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

		// Token: 0x0600E52D RID: 58669 RVA: 0x0033C253 File Offset: 0x0033A453
		public Span<byte> GetMarkPicBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E52E RID: 58670 RVA: 0x0033C262 File Offset: 0x0033A462
		public byte[] GetMarkPicArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003CC5 RID: 15557
		// (get) Token: 0x0600E52F RID: 58671 RVA: 0x0033C27C File Offset: 0x0033A47C
		public string MarkTitle
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

		// Token: 0x0600E530 RID: 58672 RVA: 0x0033C2B3 File Offset: 0x0033A4B3
		public Span<byte> GetMarkTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E531 RID: 58673 RVA: 0x0033C2C2 File Offset: 0x0033A4C2
		public byte[] GetMarkTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003CC6 RID: 15558
		// (get) Token: 0x0600E532 RID: 58674 RVA: 0x0033C2DC File Offset: 0x0033A4DC
		public string MarkDesc
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

		// Token: 0x0600E533 RID: 58675 RVA: 0x0033C314 File Offset: 0x0033A514
		public Span<byte> GetMarkDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600E534 RID: 58676 RVA: 0x0033C324 File Offset: 0x0033A524
		public byte[] GetMarkDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003CC7 RID: 15559
		// (get) Token: 0x0600E535 RID: 58677 RVA: 0x0033C33C File Offset: 0x0033A53C
		public int ShowPriority
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E536 RID: 58678 RVA: 0x0033C37C File Offset: 0x0033A57C
		public int ShowRange(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003CC8 RID: 15560
		// (get) Token: 0x0600E537 RID: 58679 RVA: 0x0033C3BC File Offset: 0x0033A5BC
		public int ShowRangeLength
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

		// Token: 0x0600E538 RID: 58680 RVA: 0x0033C3E8 File Offset: 0x0033A5E8
		public Span<int> GetShowRangeBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600E539 RID: 58681 RVA: 0x0033C3F8 File Offset: 0x0033A5F8
		public int[] GetShowRangeArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17003CC9 RID: 15561
		// (get) Token: 0x0600E53A RID: 58682 RVA: 0x0033C410 File Offset: 0x0033A610
		public float Scale
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003CCA RID: 15562
		// (get) Token: 0x0600E53B RID: 58683 RVA: 0x0033C454 File Offset: 0x0033A654
		public int TrackHudEnable
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

		// Token: 0x17003CCB RID: 15563
		// (get) Token: 0x0600E53C RID: 58684 RVA: 0x0033C494 File Offset: 0x0033A694
		public float TrackAutoCancelDistance
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return -1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E53D RID: 58685 RVA: 0x0033C4D8 File Offset: 0x0033A6D8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ShowRangeIter()或GetShowRangeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ShowRange()
		{
			TreasureBoxDetectorMark treasureBoxDetectorMark = this;
			return treasureBoxDetectorMark.GetShowRangeArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E53E RID: 58686 RVA: 0x0033C4FC File Offset: 0x0033A6FC
		[NullableContext(1)]
		public readonly IEnumerable<int> ShowRangeIter()
		{
			TreasureBoxDetectorMark.<ShowRangeIter>d__36 <ShowRangeIter>d__ = new TreasureBoxDetectorMark.<ShowRangeIter>d__36(-2);
			<ShowRangeIter>d__.<>3__<>4__this = this;
			return <ShowRangeIter>d__;
		}

		// Token: 0x040052BB RID: 21179
		private Table __p;
	}
}
