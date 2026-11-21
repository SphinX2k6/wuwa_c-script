using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D4C RID: 3404
	public struct FightInfoDtType : IFlatbufferObject
	{
		// Token: 0x1700110A RID: 4362
		// (get) Token: 0x060073BE RID: 29630 RVA: 0x0024C64E File Offset: 0x0024A84E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060073BF RID: 29631 RVA: 0x0024C65B File Offset: 0x0024A85B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060073C0 RID: 29632 RVA: 0x0024C664 File Offset: 0x0024A864
		public static FightInfoDtType GetRootAsFightInfoDtType(ByteBuffer _bb)
		{
			return FightInfoDtType.GetRootAsFightInfoDtType(_bb, default(FightInfoDtType));
		}

		// Token: 0x060073C1 RID: 29633 RVA: 0x0024C680 File Offset: 0x0024A880
		public static FightInfoDtType GetRootAsFightInfoDtType(ByteBuffer _bb, FightInfoDtType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060073C2 RID: 29634 RVA: 0x0024C69D File Offset: 0x0024A89D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060073C3 RID: 29635 RVA: 0x0024C6AC File Offset: 0x0024A8AC
		public FightInfoDtType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700110B RID: 4363
		// (get) Token: 0x060073C4 RID: 29636 RVA: 0x0024C6BC File Offset: 0x0024A8BC
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

		// Token: 0x1700110C RID: 4364
		// (get) Token: 0x060073C5 RID: 29637 RVA: 0x0024C6F8 File Offset: 0x0024A8F8
		public string Name
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

		// Token: 0x060073C6 RID: 29638 RVA: 0x0024C72F File Offset: 0x0024A92F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060073C7 RID: 29639 RVA: 0x0024C73E File Offset: 0x0024A93E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005297 RID: 21143
		private Table __p;
	}
}
