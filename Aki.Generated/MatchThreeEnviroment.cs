using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EE1 RID: 3809
	public struct MatchThreeEnviroment : IFlatbufferObject
	{
		// Token: 0x17001EE5 RID: 7909
		// (get) Token: 0x060098A1 RID: 39073 RVA: 0x0029FC76 File Offset: 0x0029DE76
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060098A2 RID: 39074 RVA: 0x0029FC83 File Offset: 0x0029DE83
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060098A3 RID: 39075 RVA: 0x0029FC8C File Offset: 0x0029DE8C
		public static MatchThreeEnviroment GetRootAsMatchThreeEnviroment(ByteBuffer _bb)
		{
			return MatchThreeEnviroment.GetRootAsMatchThreeEnviroment(_bb, default(MatchThreeEnviroment));
		}

		// Token: 0x060098A4 RID: 39076 RVA: 0x0029FCA8 File Offset: 0x0029DEA8
		public static MatchThreeEnviroment GetRootAsMatchThreeEnviroment(ByteBuffer _bb, MatchThreeEnviroment obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060098A5 RID: 39077 RVA: 0x0029FCC5 File Offset: 0x0029DEC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060098A6 RID: 39078 RVA: 0x0029FCD4 File Offset: 0x0029DED4
		public MatchThreeEnviroment __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001EE6 RID: 7910
		// (get) Token: 0x060098A7 RID: 39079 RVA: 0x0029FCE4 File Offset: 0x0029DEE4
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

		// Token: 0x17001EE7 RID: 7911
		// (get) Token: 0x060098A8 RID: 39080 RVA: 0x0029FD20 File Offset: 0x0029DF20
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

		// Token: 0x060098A9 RID: 39081 RVA: 0x0029FD5C File Offset: 0x0029DF5C
		public int Params(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001EE8 RID: 7912
		// (get) Token: 0x060098AA RID: 39082 RVA: 0x0029FD9C File Offset: 0x0029DF9C
		public int ParamsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060098AB RID: 39083 RVA: 0x0029FDC7 File Offset: 0x0029DFC7
		public Span<int> GetParamsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x060098AC RID: 39084 RVA: 0x0029FDD6 File Offset: 0x0029DFD6
		public int[] GetParamsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17001EE9 RID: 7913
		// (get) Token: 0x060098AD RID: 39085 RVA: 0x0029FDF0 File Offset: 0x0029DFF0
		public string Tip
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

		// Token: 0x060098AE RID: 39086 RVA: 0x0029FE28 File Offset: 0x0029E028
		public Span<byte> GetTipBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060098AF RID: 39087 RVA: 0x0029FE38 File Offset: 0x0029E038
		public byte[] GetTipArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001EEA RID: 7914
		// (get) Token: 0x060098B0 RID: 39088 RVA: 0x0029FE50 File Offset: 0x0029E050
		public string Name
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

		// Token: 0x060098B1 RID: 39089 RVA: 0x0029FE88 File Offset: 0x0029E088
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060098B2 RID: 39090 RVA: 0x0029FE98 File Offset: 0x0029E098
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001EEB RID: 7915
		// (get) Token: 0x060098B3 RID: 39091 RVA: 0x0029FEB0 File Offset: 0x0029E0B0
		public string Description
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

		// Token: 0x060098B4 RID: 39092 RVA: 0x0029FEE8 File Offset: 0x0029E0E8
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060098B5 RID: 39093 RVA: 0x0029FEF8 File Offset: 0x0029E0F8
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001EEC RID: 7916
		// (get) Token: 0x060098B6 RID: 39094 RVA: 0x0029FF10 File Offset: 0x0029E110
		public string Comment
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

		// Token: 0x060098B7 RID: 39095 RVA: 0x0029FF48 File Offset: 0x0029E148
		public Span<byte> GetCommentBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060098B8 RID: 39096 RVA: 0x0029FF58 File Offset: 0x0029E158
		public byte[] GetCommentArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001EED RID: 7917
		// (get) Token: 0x060098B9 RID: 39097 RVA: 0x0029FF70 File Offset: 0x0029E170
		public int SortId
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

		// Token: 0x060098BA RID: 39098 RVA: 0x0029FFAD File Offset: 0x0029E1AD
		[NullableContext(1)]
		public int[] Params()
		{
			return this.GetParamsArray();
		}

		// Token: 0x060098BB RID: 39099 RVA: 0x0029FFB5 File Offset: 0x0029E1B5
		[NullableContext(1)]
		public IEnumerable<int> ParamsIter()
		{
			MatchThreeEnviroment.<ParamsIter>d__36 <ParamsIter>d__ = new MatchThreeEnviroment.<ParamsIter>d__36(-2);
			<ParamsIter>d__.<>3__<>4__this = this;
			return <ParamsIter>d__;
		}

		// Token: 0x04005481 RID: 21633
		private Table __p;
	}
}
