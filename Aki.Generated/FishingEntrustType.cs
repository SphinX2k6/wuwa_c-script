using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D62 RID: 3426
	public struct FishingEntrustType : IFlatbufferObject
	{
		// Token: 0x170011B7 RID: 4535
		// (get) Token: 0x06007549 RID: 30025 RVA: 0x002500D8 File Offset: 0x0024E2D8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600754A RID: 30026 RVA: 0x002500E5 File Offset: 0x0024E2E5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600754B RID: 30027 RVA: 0x002500EC File Offset: 0x0024E2EC
		public static FishingEntrustType GetRootAsFishingEntrustType(ByteBuffer _bb)
		{
			return FishingEntrustType.GetRootAsFishingEntrustType(_bb, default(FishingEntrustType));
		}

		// Token: 0x0600754C RID: 30028 RVA: 0x00250108 File Offset: 0x0024E308
		public static FishingEntrustType GetRootAsFishingEntrustType(ByteBuffer _bb, FishingEntrustType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600754D RID: 30029 RVA: 0x00250125 File Offset: 0x0024E325
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600754E RID: 30030 RVA: 0x00250134 File Offset: 0x0024E334
		public FishingEntrustType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170011B8 RID: 4536
		// (get) Token: 0x0600754F RID: 30031 RVA: 0x00250144 File Offset: 0x0024E344
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

		// Token: 0x170011B9 RID: 4537
		// (get) Token: 0x06007550 RID: 30032 RVA: 0x00250180 File Offset: 0x0024E380
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

		// Token: 0x06007551 RID: 30033 RVA: 0x002501B7 File Offset: 0x0024E3B7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007552 RID: 30034 RVA: 0x002501C6 File Offset: 0x0024E3C6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170011BA RID: 4538
		// (get) Token: 0x06007553 RID: 30035 RVA: 0x002501E0 File Offset: 0x0024E3E0
		public string Color
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

		// Token: 0x06007554 RID: 30036 RVA: 0x00250217 File Offset: 0x0024E417
		public Span<byte> GetColorBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007555 RID: 30037 RVA: 0x00250226 File Offset: 0x0024E426
		public byte[] GetColorArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x040052B1 RID: 21169
		private Table __p;
	}
}
