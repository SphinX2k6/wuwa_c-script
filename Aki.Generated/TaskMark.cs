using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200124C RID: 4684
	public struct TaskMark : IFlatbufferObject
	{
		// Token: 0x17003D07 RID: 15623
		// (get) Token: 0x0600EA22 RID: 59938 RVA: 0x0035483D File Offset: 0x00352A3D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EA23 RID: 59939 RVA: 0x0035484A File Offset: 0x00352A4A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EA24 RID: 59940 RVA: 0x00354854 File Offset: 0x00352A54
		public static TaskMark GetRootAsTaskMark(ByteBuffer _bb)
		{
			return TaskMark.GetRootAsTaskMark(_bb, default(TaskMark));
		}

		// Token: 0x0600EA25 RID: 59941 RVA: 0x00354870 File Offset: 0x00352A70
		public static TaskMark GetRootAsTaskMark(ByteBuffer _bb, TaskMark obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EA26 RID: 59942 RVA: 0x0035488D File Offset: 0x00352A8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EA27 RID: 59943 RVA: 0x0035489C File Offset: 0x00352A9C
		public TaskMark __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003D08 RID: 15624
		// (get) Token: 0x0600EA28 RID: 59944 RVA: 0x003548AC File Offset: 0x00352AAC
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

		// Token: 0x17003D09 RID: 15625
		// (get) Token: 0x0600EA29 RID: 59945 RVA: 0x003548E8 File Offset: 0x00352AE8
		public int QuestId
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

		// Token: 0x17003D0A RID: 15626
		// (get) Token: 0x0600EA2A RID: 59946 RVA: 0x00354924 File Offset: 0x00352B24
		public string MarkPic
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

		// Token: 0x0600EA2B RID: 59947 RVA: 0x0035495B File Offset: 0x00352B5B
		public Span<byte> GetMarkPicBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600EA2C RID: 59948 RVA: 0x0035496A File Offset: 0x00352B6A
		public byte[] GetMarkPicArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D0B RID: 15627
		// (get) Token: 0x0600EA2D RID: 59949 RVA: 0x00354984 File Offset: 0x00352B84
		public string MarkAcceptablePic
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

		// Token: 0x0600EA2E RID: 59950 RVA: 0x003549BC File Offset: 0x00352BBC
		public Span<byte> GetMarkAcceptablePicBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600EA2F RID: 59951 RVA: 0x003549CC File Offset: 0x00352BCC
		public byte[] GetMarkAcceptablePicArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D0C RID: 15628
		// (get) Token: 0x0600EA30 RID: 59952 RVA: 0x003549E4 File Offset: 0x00352BE4
		public string NpcTaskIcon
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

		// Token: 0x0600EA31 RID: 59953 RVA: 0x00354A1C File Offset: 0x00352C1C
		public Span<byte> GetNpcTaskIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600EA32 RID: 59954 RVA: 0x00354A2C File Offset: 0x00352C2C
		public byte[] GetNpcTaskIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D0D RID: 15629
		// (get) Token: 0x0600EA33 RID: 59955 RVA: 0x00354A44 File Offset: 0x00352C44
		public int IconDistant
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 20000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003D0E RID: 15630
		// (get) Token: 0x0600EA34 RID: 59956 RVA: 0x00354A88 File Offset: 0x00352C88
		public string TrackTextStartEffectColor
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

		// Token: 0x0600EA35 RID: 59957 RVA: 0x00354AC0 File Offset: 0x00352CC0
		public Span<byte> GetTrackTextStartEffectColorBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600EA36 RID: 59958 RVA: 0x00354AD0 File Offset: 0x00352CD0
		public byte[] GetTrackTextStartEffectColorArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0600EA37 RID: 59959 RVA: 0x00354AE8 File Offset: 0x00352CE8
		public int ShowRange(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003D0F RID: 15631
		// (get) Token: 0x0600EA38 RID: 59960 RVA: 0x00354B28 File Offset: 0x00352D28
		public int ShowRangeLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600EA39 RID: 59961 RVA: 0x00354B54 File Offset: 0x00352D54
		public Span<int> GetShowRangeBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600EA3A RID: 59962 RVA: 0x00354B64 File Offset: 0x00352D64
		public int[] GetShowRangeArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x17003D10 RID: 15632
		// (get) Token: 0x0600EA3B RID: 59963 RVA: 0x00354B7C File Offset: 0x00352D7C
		public int ShowPriority
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

		// Token: 0x17003D11 RID: 15633
		// (get) Token: 0x0600EA3C RID: 59964 RVA: 0x00354BBC File Offset: 0x00352DBC
		public float Scale
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003D12 RID: 15634
		// (get) Token: 0x0600EA3D RID: 59965 RVA: 0x00354C00 File Offset: 0x00352E00
		public float FxScale
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003D13 RID: 15635
		// (get) Token: 0x0600EA3E RID: 59966 RVA: 0x00354C44 File Offset: 0x00352E44
		public string MarkRingPic
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600EA3F RID: 59967 RVA: 0x00354C7C File Offset: 0x00352E7C
		public Span<byte> GetMarkRingPicBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600EA40 RID: 59968 RVA: 0x00354C8C File Offset: 0x00352E8C
		public byte[] GetMarkRingPicArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D14 RID: 15636
		// (get) Token: 0x0600EA41 RID: 59969 RVA: 0x00354CA4 File Offset: 0x00352EA4
		public string MarkIcon
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600EA42 RID: 59970 RVA: 0x00354CDC File Offset: 0x00352EDC
		public Span<byte> GetMarkIconBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600EA43 RID: 59971 RVA: 0x00354CEC File Offset: 0x00352EEC
		public byte[] GetMarkIconArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D15 RID: 15637
		// (get) Token: 0x0600EA44 RID: 59972 RVA: 0x00354D04 File Offset: 0x00352F04
		public string RingColor
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600EA45 RID: 59973 RVA: 0x00354D3C File Offset: 0x00352F3C
		public Span<byte> GetRingColorBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600EA46 RID: 59974 RVA: 0x00354D4C File Offset: 0x00352F4C
		public byte[] GetRingColorArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D16 RID: 15638
		// (get) Token: 0x0600EA47 RID: 59975 RVA: 0x00354D64 File Offset: 0x00352F64
		public string SmallHaloColor
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600EA48 RID: 59976 RVA: 0x00354D9C File Offset: 0x00352F9C
		public Span<byte> GetSmallHaloColorBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600EA49 RID: 59977 RVA: 0x00354DAC File Offset: 0x00352FAC
		public byte[] GetSmallHaloColorArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D17 RID: 15639
		// (get) Token: 0x0600EA4A RID: 59978 RVA: 0x00354DC4 File Offset: 0x00352FC4
		public string LargeHaloColor
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600EA4B RID: 59979 RVA: 0x00354DFC File Offset: 0x00352FFC
		public Span<byte> GetLargeHaloColorBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600EA4C RID: 59980 RVA: 0x00354E0C File Offset: 0x0035300C
		public byte[] GetLargeHaloColorArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x0600EA4D RID: 59981 RVA: 0x00354E24 File Offset: 0x00353024
		[NullableContext(1)]
		public int[] ShowRange()
		{
			return this.GetShowRangeArray();
		}

		// Token: 0x0600EA4E RID: 59982 RVA: 0x00354E2C File Offset: 0x0035302C
		[NullableContext(1)]
		public IEnumerable<int> ShowRangeIter()
		{
			TaskMark.<ShowRangeIter>d__62 <ShowRangeIter>d__ = new TaskMark.<ShowRangeIter>d__62(-2);
			<ShowRangeIter>d__.<>3__<>4__this = this;
			return <ShowRangeIter>d__;
		}

		// Token: 0x04005896 RID: 22678
		private Table __p;
	}
}
