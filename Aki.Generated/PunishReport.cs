using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F60 RID: 3936
	public struct PunishReport : IFlatbufferObject
	{
		// Token: 0x17002B22 RID: 11042
		// (get) Token: 0x0600B3D9 RID: 46041 RVA: 0x002CC5FD File Offset: 0x002CA7FD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B3DA RID: 46042 RVA: 0x002CC60A File Offset: 0x002CA80A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B3DB RID: 46043 RVA: 0x002CC614 File Offset: 0x002CA814
		public static PunishReport GetRootAsPunishReport(ByteBuffer _bb)
		{
			return PunishReport.GetRootAsPunishReport(_bb, default(PunishReport));
		}

		// Token: 0x0600B3DC RID: 46044 RVA: 0x002CC630 File Offset: 0x002CA830
		public static PunishReport GetRootAsPunishReport(ByteBuffer _bb, PunishReport obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B3DD RID: 46045 RVA: 0x002CC64D File Offset: 0x002CA84D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B3DE RID: 46046 RVA: 0x002CC65C File Offset: 0x002CA85C
		public PunishReport __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002B23 RID: 11043
		// (get) Token: 0x0600B3DF RID: 46047 RVA: 0x002CC66C File Offset: 0x002CA86C
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

		// Token: 0x17002B24 RID: 11044
		// (get) Token: 0x0600B3E0 RID: 46048 RVA: 0x002CC6A8 File Offset: 0x002CA8A8
		public string CondDescription1
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

		// Token: 0x0600B3E1 RID: 46049 RVA: 0x002CC6DF File Offset: 0x002CA8DF
		public Span<byte> GetCondDescription1Bytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B3E2 RID: 46050 RVA: 0x002CC6EE File Offset: 0x002CA8EE
		public byte[] GetCondDescription1Array()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B25 RID: 11045
		// (get) Token: 0x0600B3E3 RID: 46051 RVA: 0x002CC708 File Offset: 0x002CA908
		public string CondDescription2
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

		// Token: 0x0600B3E4 RID: 46052 RVA: 0x002CC73F File Offset: 0x002CA93F
		public Span<byte> GetCondDescription2Bytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B3E5 RID: 46053 RVA: 0x002CC74E File Offset: 0x002CA94E
		public byte[] GetCondDescription2Array()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B26 RID: 11046
		// (get) Token: 0x0600B3E6 RID: 46054 RVA: 0x002CC768 File Offset: 0x002CA968
		public string CondDescription3
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

		// Token: 0x0600B3E7 RID: 46055 RVA: 0x002CC7A0 File Offset: 0x002CA9A0
		public Span<byte> GetCondDescription3Bytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B3E8 RID: 46056 RVA: 0x002CC7B0 File Offset: 0x002CA9B0
		public byte[] GetCondDescription3Array()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B27 RID: 11047
		// (get) Token: 0x0600B3E9 RID: 46057 RVA: 0x002CC7C8 File Offset: 0x002CA9C8
		public string Cond1Key
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

		// Token: 0x0600B3EA RID: 46058 RVA: 0x002CC800 File Offset: 0x002CAA00
		public Span<byte> GetCond1KeyBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B3EB RID: 46059 RVA: 0x002CC810 File Offset: 0x002CAA10
		public byte[] GetCond1KeyArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B28 RID: 11048
		// (get) Token: 0x0600B3EC RID: 46060 RVA: 0x002CC828 File Offset: 0x002CAA28
		public string Cond2ey
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

		// Token: 0x0600B3ED RID: 46061 RVA: 0x002CC860 File Offset: 0x002CAA60
		public Span<byte> GetCond2eyBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B3EE RID: 46062 RVA: 0x002CC870 File Offset: 0x002CAA70
		public byte[] GetCond2eyArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B29 RID: 11049
		// (get) Token: 0x0600B3EF RID: 46063 RVA: 0x002CC888 File Offset: 0x002CAA88
		public string Cond3Key
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

		// Token: 0x0600B3F0 RID: 46064 RVA: 0x002CC8C0 File Offset: 0x002CAAC0
		public Span<byte> GetCond3KeyBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600B3F1 RID: 46065 RVA: 0x002CC8D0 File Offset: 0x002CAAD0
		public byte[] GetCond3KeyArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B2A RID: 11050
		// (get) Token: 0x0600B3F2 RID: 46066 RVA: 0x002CC8E8 File Offset: 0x002CAAE8
		public string GetBoxKey
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

		// Token: 0x0600B3F3 RID: 46067 RVA: 0x002CC920 File Offset: 0x002CAB20
		public Span<byte> GetGetBoxKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600B3F4 RID: 46068 RVA: 0x002CC930 File Offset: 0x002CAB30
		public byte[] GetGetBoxKeyArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0400502E RID: 20526
		private Table __p;
	}
}
