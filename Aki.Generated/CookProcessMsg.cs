using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C84 RID: 3204
	public struct CookProcessMsg : IFlatbufferObject
	{
		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x06005F6E RID: 24430 RVA: 0x0021FF60 File Offset: 0x0021E160
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005F6F RID: 24431 RVA: 0x0021FF6D File Offset: 0x0021E16D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005F70 RID: 24432 RVA: 0x0021FF74 File Offset: 0x0021E174
		public static CookProcessMsg GetRootAsCookProcessMsg(ByteBuffer _bb)
		{
			return CookProcessMsg.GetRootAsCookProcessMsg(_bb, default(CookProcessMsg));
		}

		// Token: 0x06005F71 RID: 24433 RVA: 0x0021FF90 File Offset: 0x0021E190
		public static CookProcessMsg GetRootAsCookProcessMsg(ByteBuffer _bb, CookProcessMsg obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005F72 RID: 24434 RVA: 0x0021FFAD File Offset: 0x0021E1AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005F73 RID: 24435 RVA: 0x0021FFBC File Offset: 0x0021E1BC
		public CookProcessMsg __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x06005F74 RID: 24436 RVA: 0x0021FFCC File Offset: 0x0021E1CC
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

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x06005F75 RID: 24437 RVA: 0x00220008 File Offset: 0x0021E208
		public string Description
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

		// Token: 0x06005F76 RID: 24438 RVA: 0x0022003F File Offset: 0x0021E23F
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005F77 RID: 24439 RVA: 0x0022004E File Offset: 0x0021E24E
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x06005F78 RID: 24440 RVA: 0x00220068 File Offset: 0x0021E268
		public string Introduce
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

		// Token: 0x06005F79 RID: 24441 RVA: 0x0022009F File Offset: 0x0021E29F
		public Span<byte> GetIntroduceBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005F7A RID: 24442 RVA: 0x002200AE File Offset: 0x0021E2AE
		public byte[] GetIntroduceArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x040051A7 RID: 20903
		private Table __p;
	}
}
