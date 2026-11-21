using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CB7 RID: 3255
	public struct DangoBroadcast : IFlatbufferObject
	{
		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x060065FF RID: 26111 RVA: 0x0022E61C File Offset: 0x0022C81C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006600 RID: 26112 RVA: 0x0022E629 File Offset: 0x0022C829
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006601 RID: 26113 RVA: 0x0022E630 File Offset: 0x0022C830
		public static DangoBroadcast GetRootAsDangoBroadcast(ByteBuffer _bb)
		{
			return DangoBroadcast.GetRootAsDangoBroadcast(_bb, default(DangoBroadcast));
		}

		// Token: 0x06006602 RID: 26114 RVA: 0x0022E64C File Offset: 0x0022C84C
		public static DangoBroadcast GetRootAsDangoBroadcast(ByteBuffer _bb, DangoBroadcast obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006603 RID: 26115 RVA: 0x0022E669 File Offset: 0x0022C869
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006604 RID: 26116 RVA: 0x0022E678 File Offset: 0x0022C878
		public DangoBroadcast __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x06006605 RID: 26117 RVA: 0x0022E688 File Offset: 0x0022C888
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

		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x06006606 RID: 26118 RVA: 0x0022E6C4 File Offset: 0x0022C8C4
		public string GroupStageCheerText1
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

		// Token: 0x06006607 RID: 26119 RVA: 0x0022E6FB File Offset: 0x0022C8FB
		public Span<byte> GetGroupStageCheerText1Bytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006608 RID: 26120 RVA: 0x0022E70A File Offset: 0x0022C90A
		public byte[] GetGroupStageCheerText1Array()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x06006609 RID: 26121 RVA: 0x0022E724 File Offset: 0x0022C924
		public string GroupStageCheerText2
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

		// Token: 0x0600660A RID: 26122 RVA: 0x0022E75B File Offset: 0x0022C95B
		public Span<byte> GetGroupStageCheerText2Bytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600660B RID: 26123 RVA: 0x0022E76A File Offset: 0x0022C96A
		public byte[] GetGroupStageCheerText2Array()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x0600660C RID: 26124 RVA: 0x0022E784 File Offset: 0x0022C984
		public string GroupStageChampText
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

		// Token: 0x0600660D RID: 26125 RVA: 0x0022E7BC File Offset: 0x0022C9BC
		public Span<byte> GetGroupStageChampTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600660E RID: 26126 RVA: 0x0022E7CC File Offset: 0x0022C9CC
		public byte[] GetGroupStageChampTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C19 RID: 3097
		// (get) Token: 0x0600660F RID: 26127 RVA: 0x0022E7E4 File Offset: 0x0022C9E4
		public string AdvanceStageCheerText1
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

		// Token: 0x06006610 RID: 26128 RVA: 0x0022E81C File Offset: 0x0022CA1C
		public Span<byte> GetAdvanceStageCheerText1Bytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06006611 RID: 26129 RVA: 0x0022E82C File Offset: 0x0022CA2C
		public byte[] GetAdvanceStageCheerText1Array()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x06006612 RID: 26130 RVA: 0x0022E844 File Offset: 0x0022CA44
		public string AdvanceStageCheerText2
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

		// Token: 0x06006613 RID: 26131 RVA: 0x0022E87C File Offset: 0x0022CA7C
		public Span<byte> GetAdvanceStageCheerText2Bytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06006614 RID: 26132 RVA: 0x0022E88C File Offset: 0x0022CA8C
		public byte[] GetAdvanceStageCheerText2Array()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x06006615 RID: 26133 RVA: 0x0022E8A4 File Offset: 0x0022CAA4
		public string AdvanceStageChampText
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

		// Token: 0x06006616 RID: 26134 RVA: 0x0022E8DC File Offset: 0x0022CADC
		public Span<byte> GetAdvanceStageChampTextBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06006617 RID: 26135 RVA: 0x0022E8EC File Offset: 0x0022CAEC
		public byte[] GetAdvanceStageChampTextArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x06006618 RID: 26136 RVA: 0x0022E904 File Offset: 0x0022CB04
		public string ShowMatchText
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

		// Token: 0x06006619 RID: 26137 RVA: 0x0022E93C File Offset: 0x0022CB3C
		public Span<byte> GetShowMatchTextBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600661A RID: 26138 RVA: 0x0022E94C File Offset: 0x0022CB4C
		public byte[] GetShowMatchTextArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x0600661B RID: 26139 RVA: 0x0022E964 File Offset: 0x0022CB64
		public string ShowMatchChampText
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600661C RID: 26140 RVA: 0x0022E99C File Offset: 0x0022CB9C
		public Span<byte> GetShowMatchChampTextBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600661D RID: 26141 RVA: 0x0022E9AC File Offset: 0x0022CBAC
		public byte[] GetShowMatchChampTextArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x0600661E RID: 26142 RVA: 0x0022E9C4 File Offset: 0x0022CBC4
		public string FinalStageCheerText1
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600661F RID: 26143 RVA: 0x0022E9FC File Offset: 0x0022CBFC
		public Span<byte> GetFinalStageCheerText1Bytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06006620 RID: 26144 RVA: 0x0022EA0C File Offset: 0x0022CC0C
		public byte[] GetFinalStageCheerText1Array()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x06006621 RID: 26145 RVA: 0x0022EA24 File Offset: 0x0022CC24
		public string FinalStageCheerText2
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006622 RID: 26146 RVA: 0x0022EA5C File Offset: 0x0022CC5C
		public Span<byte> GetFinalStageCheerText2Bytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06006623 RID: 26147 RVA: 0x0022EA6C File Offset: 0x0022CC6C
		public byte[] GetFinalStageCheerText2Array()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C20 RID: 3104
		// (get) Token: 0x06006624 RID: 26148 RVA: 0x0022EA84 File Offset: 0x0022CC84
		public string FinalStageChampText
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

		// Token: 0x06006625 RID: 26149 RVA: 0x0022EABC File Offset: 0x0022CCBC
		public Span<byte> GetFinalStageChampTextBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06006626 RID: 26150 RVA: 0x0022EACC File Offset: 0x0022CCCC
		public byte[] GetFinalStageChampTextArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x040051E4 RID: 20964
		private Table __p;
	}
}
