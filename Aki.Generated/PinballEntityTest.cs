using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F2C RID: 3884
	public struct PinballEntityTest : IFlatbufferObject
	{
		// Token: 0x17002944 RID: 10564
		// (get) Token: 0x0600AEE0 RID: 44768 RVA: 0x002C18DC File Offset: 0x002BFADC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AEE1 RID: 44769 RVA: 0x002C18E9 File Offset: 0x002BFAE9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AEE2 RID: 44770 RVA: 0x002C18F0 File Offset: 0x002BFAF0
		public static PinballEntityTest GetRootAsPinballEntityTest(ByteBuffer _bb)
		{
			return PinballEntityTest.GetRootAsPinballEntityTest(_bb, default(PinballEntityTest));
		}

		// Token: 0x0600AEE3 RID: 44771 RVA: 0x002C190C File Offset: 0x002BFB0C
		public static PinballEntityTest GetRootAsPinballEntityTest(ByteBuffer _bb, PinballEntityTest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AEE4 RID: 44772 RVA: 0x002C1929 File Offset: 0x002BFB29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AEE5 RID: 44773 RVA: 0x002C1938 File Offset: 0x002BFB38
		public PinballEntityTest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002945 RID: 10565
		// (get) Token: 0x0600AEE6 RID: 44774 RVA: 0x002C1948 File Offset: 0x002BFB48
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

		// Token: 0x17002946 RID: 10566
		// (get) Token: 0x0600AEE7 RID: 44775 RVA: 0x002C1984 File Offset: 0x002BFB84
		public int MapId
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

		// Token: 0x17002947 RID: 10567
		// (get) Token: 0x0600AEE8 RID: 44776 RVA: 0x002C19C0 File Offset: 0x002BFBC0
		public int KscEntityId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002948 RID: 10568
		// (get) Token: 0x0600AEE9 RID: 44777 RVA: 0x002C19FC File Offset: 0x002BFBFC
		public Vector? Location
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17002949 RID: 10569
		// (get) Token: 0x0600AEEA RID: 44778 RVA: 0x002C1A5C File Offset: 0x002BFC5C
		public Vector? Rotation
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x04004FF5 RID: 20469
		private Table __p;
	}
}
