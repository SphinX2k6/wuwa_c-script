using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001255 RID: 4693
	public struct TemporaryTeleportMark : IFlatbufferObject
	{
		// Token: 0x17003D59 RID: 15705
		// (get) Token: 0x0600EAEE RID: 60142 RVA: 0x00356414 File Offset: 0x00354614
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EAEF RID: 60143 RVA: 0x00356421 File Offset: 0x00354621
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EAF0 RID: 60144 RVA: 0x00356428 File Offset: 0x00354628
		public static TemporaryTeleportMark GetRootAsTemporaryTeleportMark(ByteBuffer _bb)
		{
			return TemporaryTeleportMark.GetRootAsTemporaryTeleportMark(_bb, default(TemporaryTeleportMark));
		}

		// Token: 0x0600EAF1 RID: 60145 RVA: 0x00356444 File Offset: 0x00354644
		public static TemporaryTeleportMark GetRootAsTemporaryTeleportMark(ByteBuffer _bb, TemporaryTeleportMark obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EAF2 RID: 60146 RVA: 0x00356461 File Offset: 0x00354661
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EAF3 RID: 60147 RVA: 0x00356470 File Offset: 0x00354670
		public TemporaryTeleportMark __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003D5A RID: 15706
		// (get) Token: 0x0600EAF4 RID: 60148 RVA: 0x00356480 File Offset: 0x00354680
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

		// Token: 0x17003D5B RID: 15707
		// (get) Token: 0x0600EAF5 RID: 60149 RVA: 0x003564BC File Offset: 0x003546BC
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

		// Token: 0x0600EAF6 RID: 60150 RVA: 0x003564F3 File Offset: 0x003546F3
		public Span<byte> GetMarkPicBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600EAF7 RID: 60151 RVA: 0x00356502 File Offset: 0x00354702
		public byte[] GetMarkPicArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D5C RID: 15708
		// (get) Token: 0x0600EAF8 RID: 60152 RVA: 0x0035651C File Offset: 0x0035471C
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

		// Token: 0x0600EAF9 RID: 60153 RVA: 0x00356553 File Offset: 0x00354753
		public Span<byte> GetMarkTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600EAFA RID: 60154 RVA: 0x00356562 File Offset: 0x00354762
		public byte[] GetMarkTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D5D RID: 15709
		// (get) Token: 0x0600EAFB RID: 60155 RVA: 0x0035657C File Offset: 0x0035477C
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

		// Token: 0x0600EAFC RID: 60156 RVA: 0x003565B4 File Offset: 0x003547B4
		public Span<byte> GetMarkDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600EAFD RID: 60157 RVA: 0x003565C4 File Offset: 0x003547C4
		public byte[] GetMarkDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D5E RID: 15710
		// (get) Token: 0x0600EAFE RID: 60158 RVA: 0x003565DC File Offset: 0x003547DC
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

		// Token: 0x0600EAFF RID: 60159 RVA: 0x0035661C File Offset: 0x0035481C
		public int ShowRange(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003D5F RID: 15711
		// (get) Token: 0x0600EB00 RID: 60160 RVA: 0x0035665C File Offset: 0x0035485C
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

		// Token: 0x0600EB01 RID: 60161 RVA: 0x00356688 File Offset: 0x00354888
		public Span<int> GetShowRangeBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600EB02 RID: 60162 RVA: 0x00356698 File Offset: 0x00354898
		public int[] GetShowRangeArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17003D60 RID: 15712
		// (get) Token: 0x0600EB03 RID: 60163 RVA: 0x003566B0 File Offset: 0x003548B0
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

		// Token: 0x17003D61 RID: 15713
		// (get) Token: 0x0600EB04 RID: 60164 RVA: 0x003566F4 File Offset: 0x003548F4
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

		// Token: 0x17003D62 RID: 15714
		// (get) Token: 0x0600EB05 RID: 60165 RVA: 0x00356734 File Offset: 0x00354934
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

		// Token: 0x0600EB06 RID: 60166 RVA: 0x00356775 File Offset: 0x00354975
		[NullableContext(1)]
		public int[] ShowRange()
		{
			return this.GetShowRangeArray();
		}

		// Token: 0x0600EB07 RID: 60167 RVA: 0x0035677D File Offset: 0x0035497D
		[NullableContext(1)]
		public IEnumerable<int> ShowRangeIter()
		{
			TemporaryTeleportMark.<ShowRangeIter>d__36 <ShowRangeIter>d__ = new TemporaryTeleportMark.<ShowRangeIter>d__36(-2);
			<ShowRangeIter>d__.<>3__<>4__this = this;
			return <ShowRangeIter>d__;
		}

		// Token: 0x0400589F RID: 22687
		private Table __p;
	}
}
