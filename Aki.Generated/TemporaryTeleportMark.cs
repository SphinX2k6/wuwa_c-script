using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200111F RID: 4383
	public struct TemporaryTeleportMark : IFlatbufferObject
	{
		// Token: 0x17003A03 RID: 14851
		// (get) Token: 0x0600DDA3 RID: 56739 RVA: 0x0032B2F8 File Offset: 0x003294F8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DDA4 RID: 56740 RVA: 0x0032B305 File Offset: 0x00329505
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DDA5 RID: 56741 RVA: 0x0032B30C File Offset: 0x0032950C
		public static TemporaryTeleportMark GetRootAsTemporaryTeleportMark(ByteBuffer _bb)
		{
			return TemporaryTeleportMark.GetRootAsTemporaryTeleportMark(_bb, default(TemporaryTeleportMark));
		}

		// Token: 0x0600DDA6 RID: 56742 RVA: 0x0032B328 File Offset: 0x00329528
		public static TemporaryTeleportMark GetRootAsTemporaryTeleportMark(ByteBuffer _bb, TemporaryTeleportMark obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DDA7 RID: 56743 RVA: 0x0032B345 File Offset: 0x00329545
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DDA8 RID: 56744 RVA: 0x0032B354 File Offset: 0x00329554
		public TemporaryTeleportMark __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003A04 RID: 14852
		// (get) Token: 0x0600DDA9 RID: 56745 RVA: 0x0032B364 File Offset: 0x00329564
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

		// Token: 0x17003A05 RID: 14853
		// (get) Token: 0x0600DDAA RID: 56746 RVA: 0x0032B3A0 File Offset: 0x003295A0
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

		// Token: 0x0600DDAB RID: 56747 RVA: 0x0032B3D7 File Offset: 0x003295D7
		public Span<byte> GetMarkPicBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600DDAC RID: 56748 RVA: 0x0032B3E6 File Offset: 0x003295E6
		public byte[] GetMarkPicArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A06 RID: 14854
		// (get) Token: 0x0600DDAD RID: 56749 RVA: 0x0032B400 File Offset: 0x00329600
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

		// Token: 0x0600DDAE RID: 56750 RVA: 0x0032B437 File Offset: 0x00329637
		public Span<byte> GetMarkTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600DDAF RID: 56751 RVA: 0x0032B446 File Offset: 0x00329646
		public byte[] GetMarkTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A07 RID: 14855
		// (get) Token: 0x0600DDB0 RID: 56752 RVA: 0x0032B460 File Offset: 0x00329660
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

		// Token: 0x0600DDB1 RID: 56753 RVA: 0x0032B498 File Offset: 0x00329698
		public Span<byte> GetMarkDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600DDB2 RID: 56754 RVA: 0x0032B4A8 File Offset: 0x003296A8
		public byte[] GetMarkDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A08 RID: 14856
		// (get) Token: 0x0600DDB3 RID: 56755 RVA: 0x0032B4C0 File Offset: 0x003296C0
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

		// Token: 0x0600DDB4 RID: 56756 RVA: 0x0032B500 File Offset: 0x00329700
		public int ShowRange(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003A09 RID: 14857
		// (get) Token: 0x0600DDB5 RID: 56757 RVA: 0x0032B540 File Offset: 0x00329740
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

		// Token: 0x0600DDB6 RID: 56758 RVA: 0x0032B56C File Offset: 0x0032976C
		public Span<int> GetShowRangeBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600DDB7 RID: 56759 RVA: 0x0032B57C File Offset: 0x0032977C
		public int[] GetShowRangeArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17003A0A RID: 14858
		// (get) Token: 0x0600DDB8 RID: 56760 RVA: 0x0032B594 File Offset: 0x00329794
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

		// Token: 0x17003A0B RID: 14859
		// (get) Token: 0x0600DDB9 RID: 56761 RVA: 0x0032B5D8 File Offset: 0x003297D8
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

		// Token: 0x17003A0C RID: 14860
		// (get) Token: 0x0600DDBA RID: 56762 RVA: 0x0032B618 File Offset: 0x00329818
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

		// Token: 0x0600DDBB RID: 56763 RVA: 0x0032B65C File Offset: 0x0032985C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ShowRangeIter()或GetShowRangeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ShowRange()
		{
			TemporaryTeleportMark temporaryTeleportMark = this;
			return temporaryTeleportMark.GetShowRangeArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600DDBC RID: 56764 RVA: 0x0032B680 File Offset: 0x00329880
		[NullableContext(1)]
		public readonly IEnumerable<int> ShowRangeIter()
		{
			TemporaryTeleportMark.<ShowRangeIter>d__36 <ShowRangeIter>d__ = new TemporaryTeleportMark.<ShowRangeIter>d__36(-2);
			<ShowRangeIter>d__.<>3__<>4__this = this;
			return <ShowRangeIter>d__;
		}

		// Token: 0x0400525C RID: 21084
		private Table __p;
	}
}
