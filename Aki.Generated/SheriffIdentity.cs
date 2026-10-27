using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010A0 RID: 4256
	public struct SheriffIdentity : IFlatbufferObject
	{
		// Token: 0x1700356B RID: 13675
		// (get) Token: 0x0600D0E5 RID: 53477 RVA: 0x0030CCE5 File Offset: 0x0030AEE5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D0E6 RID: 53478 RVA: 0x0030CCF2 File Offset: 0x0030AEF2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D0E7 RID: 53479 RVA: 0x0030CCFC File Offset: 0x0030AEFC
		public static SheriffIdentity GetRootAsSheriffIdentity(ByteBuffer _bb)
		{
			return SheriffIdentity.GetRootAsSheriffIdentity(_bb, default(SheriffIdentity));
		}

		// Token: 0x0600D0E8 RID: 53480 RVA: 0x0030CD18 File Offset: 0x0030AF18
		public static SheriffIdentity GetRootAsSheriffIdentity(ByteBuffer _bb, SheriffIdentity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D0E9 RID: 53481 RVA: 0x0030CD35 File Offset: 0x0030AF35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D0EA RID: 53482 RVA: 0x0030CD44 File Offset: 0x0030AF44
		public SheriffIdentity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700356C RID: 13676
		// (get) Token: 0x0600D0EB RID: 53483 RVA: 0x0030CD54 File Offset: 0x0030AF54
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

		// Token: 0x1700356D RID: 13677
		// (get) Token: 0x0600D0EC RID: 53484 RVA: 0x0030CD90 File Offset: 0x0030AF90
		public int CriminalId
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

		// Token: 0x1700356E RID: 13678
		// (get) Token: 0x0600D0ED RID: 53485 RVA: 0x0030CDCC File Offset: 0x0030AFCC
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

		// Token: 0x0600D0EE RID: 53486 RVA: 0x0030CE03 File Offset: 0x0030B003
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D0EF RID: 53487 RVA: 0x0030CE12 File Offset: 0x0030B012
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700356F RID: 13679
		// (get) Token: 0x0600D0F0 RID: 53488 RVA: 0x0030CE2C File Offset: 0x0030B02C
		public string IconReport
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

		// Token: 0x0600D0F1 RID: 53489 RVA: 0x0030CE64 File Offset: 0x0030B064
		public Span<byte> GetIconReportBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D0F2 RID: 53490 RVA: 0x0030CE74 File Offset: 0x0030B074
		public byte[] GetIconReportArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003570 RID: 13680
		// (get) Token: 0x0600D0F3 RID: 53491 RVA: 0x0030CE8C File Offset: 0x0030B08C
		public string IconListData
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

		// Token: 0x0600D0F4 RID: 53492 RVA: 0x0030CEC4 File Offset: 0x0030B0C4
		public Span<byte> GetIconListDataBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600D0F5 RID: 53493 RVA: 0x0030CED4 File Offset: 0x0030B0D4
		public byte[] GetIconListDataArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003571 RID: 13681
		// (get) Token: 0x0600D0F6 RID: 53494 RVA: 0x0030CEEC File Offset: 0x0030B0EC
		public string IconConfirm
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

		// Token: 0x0600D0F7 RID: 53495 RVA: 0x0030CF24 File Offset: 0x0030B124
		public Span<byte> GetIconConfirmBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600D0F8 RID: 53496 RVA: 0x0030CF34 File Offset: 0x0030B134
		public byte[] GetIconConfirmArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003572 RID: 13682
		// (get) Token: 0x0600D0F9 RID: 53497 RVA: 0x0030CF4C File Offset: 0x0030B14C
		public string MarkIcon
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

		// Token: 0x0600D0FA RID: 53498 RVA: 0x0030CF84 File Offset: 0x0030B184
		public Span<byte> GetMarkIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600D0FB RID: 53499 RVA: 0x0030CF94 File Offset: 0x0030B194
		public byte[] GetMarkIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003573 RID: 13683
		// (get) Token: 0x0600D0FC RID: 53500 RVA: 0x0030CFAC File Offset: 0x0030B1AC
		public string Accusal
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

		// Token: 0x0600D0FD RID: 53501 RVA: 0x0030CFE4 File Offset: 0x0030B1E4
		public Span<byte> GetAccusalBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600D0FE RID: 53502 RVA: 0x0030CFF4 File Offset: 0x0030B1F4
		public byte[] GetAccusalArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17003574 RID: 13684
		// (get) Token: 0x0600D0FF RID: 53503 RVA: 0x0030D00C File Offset: 0x0030B20C
		public string Witness
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

		// Token: 0x0600D100 RID: 53504 RVA: 0x0030D044 File Offset: 0x0030B244
		public Span<byte> GetWitnessBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600D101 RID: 53505 RVA: 0x0030D054 File Offset: 0x0030B254
		public byte[] GetWitnessArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17003575 RID: 13685
		// (get) Token: 0x0600D102 RID: 53506 RVA: 0x0030D06C File Offset: 0x0030B26C
		public int IdentityState
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040051AE RID: 20910
		private Table __p;
	}
}
