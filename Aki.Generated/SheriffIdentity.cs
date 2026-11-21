using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200119B RID: 4507
	public struct SheriffIdentity : IFlatbufferObject
	{
		// Token: 0x17003679 RID: 13945
		// (get) Token: 0x0600D8BB RID: 55483 RVA: 0x0032C269 File Offset: 0x0032A469
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D8BC RID: 55484 RVA: 0x0032C276 File Offset: 0x0032A476
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D8BD RID: 55485 RVA: 0x0032C280 File Offset: 0x0032A480
		public static SheriffIdentity GetRootAsSheriffIdentity(ByteBuffer _bb)
		{
			return SheriffIdentity.GetRootAsSheriffIdentity(_bb, default(SheriffIdentity));
		}

		// Token: 0x0600D8BE RID: 55486 RVA: 0x0032C29C File Offset: 0x0032A49C
		public static SheriffIdentity GetRootAsSheriffIdentity(ByteBuffer _bb, SheriffIdentity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D8BF RID: 55487 RVA: 0x0032C2B9 File Offset: 0x0032A4B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D8C0 RID: 55488 RVA: 0x0032C2C8 File Offset: 0x0032A4C8
		public SheriffIdentity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700367A RID: 13946
		// (get) Token: 0x0600D8C1 RID: 55489 RVA: 0x0032C2D8 File Offset: 0x0032A4D8
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

		// Token: 0x1700367B RID: 13947
		// (get) Token: 0x0600D8C2 RID: 55490 RVA: 0x0032C314 File Offset: 0x0032A514
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

		// Token: 0x1700367C RID: 13948
		// (get) Token: 0x0600D8C3 RID: 55491 RVA: 0x0032C350 File Offset: 0x0032A550
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

		// Token: 0x0600D8C4 RID: 55492 RVA: 0x0032C387 File Offset: 0x0032A587
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D8C5 RID: 55493 RVA: 0x0032C396 File Offset: 0x0032A596
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700367D RID: 13949
		// (get) Token: 0x0600D8C6 RID: 55494 RVA: 0x0032C3B0 File Offset: 0x0032A5B0
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

		// Token: 0x0600D8C7 RID: 55495 RVA: 0x0032C3E8 File Offset: 0x0032A5E8
		public Span<byte> GetIconReportBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D8C8 RID: 55496 RVA: 0x0032C3F8 File Offset: 0x0032A5F8
		public byte[] GetIconReportArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700367E RID: 13950
		// (get) Token: 0x0600D8C9 RID: 55497 RVA: 0x0032C410 File Offset: 0x0032A610
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

		// Token: 0x0600D8CA RID: 55498 RVA: 0x0032C448 File Offset: 0x0032A648
		public Span<byte> GetIconListDataBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600D8CB RID: 55499 RVA: 0x0032C458 File Offset: 0x0032A658
		public byte[] GetIconListDataArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700367F RID: 13951
		// (get) Token: 0x0600D8CC RID: 55500 RVA: 0x0032C470 File Offset: 0x0032A670
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

		// Token: 0x0600D8CD RID: 55501 RVA: 0x0032C4A8 File Offset: 0x0032A6A8
		public Span<byte> GetIconConfirmBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600D8CE RID: 55502 RVA: 0x0032C4B8 File Offset: 0x0032A6B8
		public byte[] GetIconConfirmArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003680 RID: 13952
		// (get) Token: 0x0600D8CF RID: 55503 RVA: 0x0032C4D0 File Offset: 0x0032A6D0
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

		// Token: 0x0600D8D0 RID: 55504 RVA: 0x0032C508 File Offset: 0x0032A708
		public Span<byte> GetMarkIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600D8D1 RID: 55505 RVA: 0x0032C518 File Offset: 0x0032A718
		public byte[] GetMarkIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003681 RID: 13953
		// (get) Token: 0x0600D8D2 RID: 55506 RVA: 0x0032C530 File Offset: 0x0032A730
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

		// Token: 0x0600D8D3 RID: 55507 RVA: 0x0032C568 File Offset: 0x0032A768
		public Span<byte> GetAccusalBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600D8D4 RID: 55508 RVA: 0x0032C578 File Offset: 0x0032A778
		public byte[] GetAccusalArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17003682 RID: 13954
		// (get) Token: 0x0600D8D5 RID: 55509 RVA: 0x0032C590 File Offset: 0x0032A790
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

		// Token: 0x0600D8D6 RID: 55510 RVA: 0x0032C5C8 File Offset: 0x0032A7C8
		public Span<byte> GetWitnessBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600D8D7 RID: 55511 RVA: 0x0032C5D8 File Offset: 0x0032A7D8
		public byte[] GetWitnessArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17003683 RID: 13955
		// (get) Token: 0x0600D8D8 RID: 55512 RVA: 0x0032C5F0 File Offset: 0x0032A7F0
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

		// Token: 0x040057AD RID: 22445
		private Table __p;
	}
}
