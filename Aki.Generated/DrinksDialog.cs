using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C00 RID: 3072
	public struct DrinksDialog : IFlatbufferObject
	{
		// Token: 0x17000D28 RID: 3368
		// (get) Token: 0x060063BD RID: 25533 RVA: 0x00216EB6 File Offset: 0x002150B6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060063BE RID: 25534 RVA: 0x00216EC3 File Offset: 0x002150C3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060063BF RID: 25535 RVA: 0x00216ECC File Offset: 0x002150CC
		public static DrinksDialog GetRootAsDrinksDialog(ByteBuffer _bb)
		{
			return DrinksDialog.GetRootAsDrinksDialog(_bb, default(DrinksDialog));
		}

		// Token: 0x060063C0 RID: 25536 RVA: 0x00216EE8 File Offset: 0x002150E8
		public static DrinksDialog GetRootAsDrinksDialog(ByteBuffer _bb, DrinksDialog obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060063C1 RID: 25537 RVA: 0x00216F05 File Offset: 0x00215105
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060063C2 RID: 25538 RVA: 0x00216F14 File Offset: 0x00215114
		public DrinksDialog __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000D29 RID: 3369
		// (get) Token: 0x060063C3 RID: 25539 RVA: 0x00216F24 File Offset: 0x00215124
		public string Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060063C4 RID: 25540 RVA: 0x00216F5B File Offset: 0x0021515B
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060063C5 RID: 25541 RVA: 0x00216F6A File Offset: 0x0021516A
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D2A RID: 3370
		// (get) Token: 0x060063C6 RID: 25542 RVA: 0x00216F84 File Offset: 0x00215184
		public int RoleId
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

		// Token: 0x17000D2B RID: 3371
		// (get) Token: 0x060063C7 RID: 25543 RVA: 0x00216FC0 File Offset: 0x002151C0
		public string Text
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

		// Token: 0x060063C8 RID: 25544 RVA: 0x00216FF7 File Offset: 0x002151F7
		public Span<byte> GetTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060063C9 RID: 25545 RVA: 0x00217006 File Offset: 0x00215206
		public byte[] GetTextArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D2C RID: 3372
		// (get) Token: 0x060063CA RID: 25546 RVA: 0x00217020 File Offset: 0x00215220
		public string AudioEvent
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

		// Token: 0x060063CB RID: 25547 RVA: 0x00217058 File Offset: 0x00215258
		public Span<byte> GetAudioEventBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060063CC RID: 25548 RVA: 0x00217068 File Offset: 0x00215268
		public byte[] GetAudioEventArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D2D RID: 3373
		// (get) Token: 0x060063CD RID: 25549 RVA: 0x00217080 File Offset: 0x00215280
		public int Delay
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004C35 RID: 19509
		private Table __p;
	}
}
