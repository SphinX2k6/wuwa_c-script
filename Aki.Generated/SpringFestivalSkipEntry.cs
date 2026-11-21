using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001222 RID: 4642
	public struct SpringFestivalSkipEntry : IFlatbufferObject
	{
		// Token: 0x17003B91 RID: 15249
		// (get) Token: 0x0600E63C RID: 58940 RVA: 0x0034BB95 File Offset: 0x00349D95
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E63D RID: 58941 RVA: 0x0034BBA2 File Offset: 0x00349DA2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E63E RID: 58942 RVA: 0x0034BBAC File Offset: 0x00349DAC
		public static SpringFestivalSkipEntry GetRootAsSpringFestivalSkipEntry(ByteBuffer _bb)
		{
			return SpringFestivalSkipEntry.GetRootAsSpringFestivalSkipEntry(_bb, default(SpringFestivalSkipEntry));
		}

		// Token: 0x0600E63F RID: 58943 RVA: 0x0034BBC8 File Offset: 0x00349DC8
		public static SpringFestivalSkipEntry GetRootAsSpringFestivalSkipEntry(ByteBuffer _bb, SpringFestivalSkipEntry obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E640 RID: 58944 RVA: 0x0034BBE5 File Offset: 0x00349DE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E641 RID: 58945 RVA: 0x0034BBF4 File Offset: 0x00349DF4
		public SpringFestivalSkipEntry __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003B92 RID: 15250
		// (get) Token: 0x0600E642 RID: 58946 RVA: 0x0034BC04 File Offset: 0x00349E04
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

		// Token: 0x17003B93 RID: 15251
		// (get) Token: 0x0600E643 RID: 58947 RVA: 0x0034BC40 File Offset: 0x00349E40
		public int Activity
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

		// Token: 0x17003B94 RID: 15252
		// (get) Token: 0x0600E644 RID: 58948 RVA: 0x0034BC7C File Offset: 0x00349E7C
		public string Name
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

		// Token: 0x0600E645 RID: 58949 RVA: 0x0034BCB3 File Offset: 0x00349EB3
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E646 RID: 58950 RVA: 0x0034BCC2 File Offset: 0x00349EC2
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003B95 RID: 15253
		// (get) Token: 0x0600E647 RID: 58951 RVA: 0x0034BCDC File Offset: 0x00349EDC
		public int JumpId
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

		// Token: 0x17003B96 RID: 15254
		// (get) Token: 0x0600E648 RID: 58952 RVA: 0x0034BD1C File Offset: 0x00349F1C
		public int FinishCondition
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

		// Token: 0x17003B97 RID: 15255
		// (get) Token: 0x0600E649 RID: 58953 RVA: 0x0034BD5C File Offset: 0x00349F5C
		public int UnlockCondition
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

		// Token: 0x0600E64A RID: 58954 RVA: 0x0034BD9C File Offset: 0x00349F9C
		public int TrackPosition(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003B98 RID: 15256
		// (get) Token: 0x0600E64B RID: 58955 RVA: 0x0034BDDC File Offset: 0x00349FDC
		public int TrackPositionLength
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

		// Token: 0x0600E64C RID: 58956 RVA: 0x0034BE08 File Offset: 0x0034A008
		public Span<int> GetTrackPositionBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600E64D RID: 58957 RVA: 0x0034BE18 File Offset: 0x0034A018
		public int[] GetTrackPositionArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x17003B99 RID: 15257
		// (get) Token: 0x0600E64E RID: 58958 RVA: 0x0034BE30 File Offset: 0x0034A030
		public string TrackIconPath
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

		// Token: 0x0600E64F RID: 58959 RVA: 0x0034BE68 File Offset: 0x0034A068
		public Span<byte> GetTrackIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600E650 RID: 58960 RVA: 0x0034BE78 File Offset: 0x0034A078
		public byte[] GetTrackIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17003B9A RID: 15258
		// (get) Token: 0x0600E651 RID: 58961 RVA: 0x0034BE90 File Offset: 0x0034A090
		public bool IsTeleport
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600E652 RID: 58962 RVA: 0x0034BED0 File Offset: 0x0034A0D0
		[NullableContext(1)]
		public int[] TrackPosition()
		{
			return this.GetTrackPositionArray();
		}

		// Token: 0x0600E653 RID: 58963 RVA: 0x0034BED8 File Offset: 0x0034A0D8
		[NullableContext(1)]
		public IEnumerable<int> TrackPositionIter()
		{
			SpringFestivalSkipEntry.<TrackPositionIter>d__34 <TrackPositionIter>d__ = new SpringFestivalSkipEntry.<TrackPositionIter>d__34(-2);
			<TrackPositionIter>d__.<>3__<>4__this = this;
			return <TrackPositionIter>d__;
		}

		// Token: 0x04005863 RID: 22627
		private Table __p;
	}
}
