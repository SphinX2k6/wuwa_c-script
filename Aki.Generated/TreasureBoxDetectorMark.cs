using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012AB RID: 4779
	public struct TreasureBoxDetectorMark : IFlatbufferObject
	{
		// Token: 0x17004026 RID: 16422
		// (get) Token: 0x0600F293 RID: 62099 RVA: 0x00366FC9 File Offset: 0x003651C9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F294 RID: 62100 RVA: 0x00366FD6 File Offset: 0x003651D6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F295 RID: 62101 RVA: 0x00366FE0 File Offset: 0x003651E0
		public static TreasureBoxDetectorMark GetRootAsTreasureBoxDetectorMark(ByteBuffer _bb)
		{
			return TreasureBoxDetectorMark.GetRootAsTreasureBoxDetectorMark(_bb, default(TreasureBoxDetectorMark));
		}

		// Token: 0x0600F296 RID: 62102 RVA: 0x00366FFC File Offset: 0x003651FC
		public static TreasureBoxDetectorMark GetRootAsTreasureBoxDetectorMark(ByteBuffer _bb, TreasureBoxDetectorMark obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F297 RID: 62103 RVA: 0x00367019 File Offset: 0x00365219
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F298 RID: 62104 RVA: 0x00367028 File Offset: 0x00365228
		public TreasureBoxDetectorMark __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17004027 RID: 16423
		// (get) Token: 0x0600F299 RID: 62105 RVA: 0x00367038 File Offset: 0x00365238
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

		// Token: 0x17004028 RID: 16424
		// (get) Token: 0x0600F29A RID: 62106 RVA: 0x00367074 File Offset: 0x00365274
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

		// Token: 0x0600F29B RID: 62107 RVA: 0x003670AB File Offset: 0x003652AB
		public Span<byte> GetMarkPicBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600F29C RID: 62108 RVA: 0x003670BA File Offset: 0x003652BA
		public byte[] GetMarkPicArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17004029 RID: 16425
		// (get) Token: 0x0600F29D RID: 62109 RVA: 0x003670D4 File Offset: 0x003652D4
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

		// Token: 0x0600F29E RID: 62110 RVA: 0x0036710B File Offset: 0x0036530B
		public Span<byte> GetMarkTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600F29F RID: 62111 RVA: 0x0036711A File Offset: 0x0036531A
		public byte[] GetMarkTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700402A RID: 16426
		// (get) Token: 0x0600F2A0 RID: 62112 RVA: 0x00367134 File Offset: 0x00365334
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

		// Token: 0x0600F2A1 RID: 62113 RVA: 0x0036716C File Offset: 0x0036536C
		public Span<byte> GetMarkDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600F2A2 RID: 62114 RVA: 0x0036717C File Offset: 0x0036537C
		public byte[] GetMarkDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700402B RID: 16427
		// (get) Token: 0x0600F2A3 RID: 62115 RVA: 0x00367194 File Offset: 0x00365394
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

		// Token: 0x0600F2A4 RID: 62116 RVA: 0x003671D4 File Offset: 0x003653D4
		public int ShowRange(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700402C RID: 16428
		// (get) Token: 0x0600F2A5 RID: 62117 RVA: 0x00367214 File Offset: 0x00365414
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

		// Token: 0x0600F2A6 RID: 62118 RVA: 0x00367240 File Offset: 0x00365440
		public Span<int> GetShowRangeBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600F2A7 RID: 62119 RVA: 0x00367250 File Offset: 0x00365450
		public int[] GetShowRangeArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x1700402D RID: 16429
		// (get) Token: 0x0600F2A8 RID: 62120 RVA: 0x00367268 File Offset: 0x00365468
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

		// Token: 0x1700402E RID: 16430
		// (get) Token: 0x0600F2A9 RID: 62121 RVA: 0x003672AC File Offset: 0x003654AC
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

		// Token: 0x1700402F RID: 16431
		// (get) Token: 0x0600F2AA RID: 62122 RVA: 0x003672EC File Offset: 0x003654EC
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

		// Token: 0x0600F2AB RID: 62123 RVA: 0x0036732D File Offset: 0x0036552D
		[NullableContext(1)]
		public int[] ShowRange()
		{
			return this.GetShowRangeArray();
		}

		// Token: 0x0600F2AC RID: 62124 RVA: 0x00367335 File Offset: 0x00365535
		[NullableContext(1)]
		public IEnumerable<int> ShowRangeIter()
		{
			TreasureBoxDetectorMark.<ShowRangeIter>d__36 <ShowRangeIter>d__ = new TreasureBoxDetectorMark.<ShowRangeIter>d__36(-2);
			<ShowRangeIter>d__.<>3__<>4__this = this;
			return <ShowRangeIter>d__;
		}

		// Token: 0x040058FE RID: 22782
		private Table __p;
	}
}
