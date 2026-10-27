using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BD5 RID: 3029
	public struct DangoBroadcast : IFlatbufferObject
	{
		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x06006026 RID: 24614 RVA: 0x0020EF98 File Offset: 0x0020D198
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006027 RID: 24615 RVA: 0x0020EFA5 File Offset: 0x0020D1A5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006028 RID: 24616 RVA: 0x0020EFAC File Offset: 0x0020D1AC
		public static DangoBroadcast GetRootAsDangoBroadcast(ByteBuffer _bb)
		{
			return DangoBroadcast.GetRootAsDangoBroadcast(_bb, default(DangoBroadcast));
		}

		// Token: 0x06006029 RID: 24617 RVA: 0x0020EFC8 File Offset: 0x0020D1C8
		public static DangoBroadcast GetRootAsDangoBroadcast(ByteBuffer _bb, DangoBroadcast obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600602A RID: 24618 RVA: 0x0020EFE5 File Offset: 0x0020D1E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600602B RID: 24619 RVA: 0x0020EFF4 File Offset: 0x0020D1F4
		public DangoBroadcast __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x0600602C RID: 24620 RVA: 0x0020F004 File Offset: 0x0020D204
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

		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x0600602D RID: 24621 RVA: 0x0020F040 File Offset: 0x0020D240
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

		// Token: 0x0600602E RID: 24622 RVA: 0x0020F077 File Offset: 0x0020D277
		public Span<byte> GetGroupStageCheerText1Bytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600602F RID: 24623 RVA: 0x0020F086 File Offset: 0x0020D286
		public byte[] GetGroupStageCheerText1Array()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x06006030 RID: 24624 RVA: 0x0020F0A0 File Offset: 0x0020D2A0
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

		// Token: 0x06006031 RID: 24625 RVA: 0x0020F0D7 File Offset: 0x0020D2D7
		public Span<byte> GetGroupStageCheerText2Bytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006032 RID: 24626 RVA: 0x0020F0E6 File Offset: 0x0020D2E6
		public byte[] GetGroupStageCheerText2Array()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x06006033 RID: 24627 RVA: 0x0020F100 File Offset: 0x0020D300
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

		// Token: 0x06006034 RID: 24628 RVA: 0x0020F138 File Offset: 0x0020D338
		public Span<byte> GetGroupStageChampTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06006035 RID: 24629 RVA: 0x0020F148 File Offset: 0x0020D348
		public byte[] GetGroupStageChampTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x06006036 RID: 24630 RVA: 0x0020F160 File Offset: 0x0020D360
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

		// Token: 0x06006037 RID: 24631 RVA: 0x0020F198 File Offset: 0x0020D398
		public Span<byte> GetAdvanceStageCheerText1Bytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06006038 RID: 24632 RVA: 0x0020F1A8 File Offset: 0x0020D3A8
		public byte[] GetAdvanceStageCheerText1Array()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x06006039 RID: 24633 RVA: 0x0020F1C0 File Offset: 0x0020D3C0
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

		// Token: 0x0600603A RID: 24634 RVA: 0x0020F1F8 File Offset: 0x0020D3F8
		public Span<byte> GetAdvanceStageCheerText2Bytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600603B RID: 24635 RVA: 0x0020F208 File Offset: 0x0020D408
		public byte[] GetAdvanceStageCheerText2Array()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x0600603C RID: 24636 RVA: 0x0020F220 File Offset: 0x0020D420
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

		// Token: 0x0600603D RID: 24637 RVA: 0x0020F258 File Offset: 0x0020D458
		public Span<byte> GetAdvanceStageChampTextBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600603E RID: 24638 RVA: 0x0020F268 File Offset: 0x0020D468
		public byte[] GetAdvanceStageChampTextArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BD6 RID: 3030
		// (get) Token: 0x0600603F RID: 24639 RVA: 0x0020F280 File Offset: 0x0020D480
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

		// Token: 0x06006040 RID: 24640 RVA: 0x0020F2B8 File Offset: 0x0020D4B8
		public Span<byte> GetShowMatchTextBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06006041 RID: 24641 RVA: 0x0020F2C8 File Offset: 0x0020D4C8
		public byte[] GetShowMatchTextArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x06006042 RID: 24642 RVA: 0x0020F2E0 File Offset: 0x0020D4E0
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

		// Token: 0x06006043 RID: 24643 RVA: 0x0020F318 File Offset: 0x0020D518
		public Span<byte> GetShowMatchChampTextBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06006044 RID: 24644 RVA: 0x0020F328 File Offset: 0x0020D528
		public byte[] GetShowMatchChampTextArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x06006045 RID: 24645 RVA: 0x0020F340 File Offset: 0x0020D540
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

		// Token: 0x06006046 RID: 24646 RVA: 0x0020F378 File Offset: 0x0020D578
		public Span<byte> GetFinalStageCheerText1Bytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06006047 RID: 24647 RVA: 0x0020F388 File Offset: 0x0020D588
		public byte[] GetFinalStageCheerText1Array()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x06006048 RID: 24648 RVA: 0x0020F3A0 File Offset: 0x0020D5A0
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

		// Token: 0x06006049 RID: 24649 RVA: 0x0020F3D8 File Offset: 0x0020D5D8
		public Span<byte> GetFinalStageCheerText2Bytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600604A RID: 24650 RVA: 0x0020F3E8 File Offset: 0x0020D5E8
		public byte[] GetFinalStageCheerText2Array()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x0600604B RID: 24651 RVA: 0x0020F400 File Offset: 0x0020D600
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

		// Token: 0x0600604C RID: 24652 RVA: 0x0020F438 File Offset: 0x0020D638
		public Span<byte> GetFinalStageChampTextBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600604D RID: 24653 RVA: 0x0020F448 File Offset: 0x0020D648
		public byte[] GetFinalStageChampTextArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x04004C02 RID: 19458
		private Table __p;
	}
}
