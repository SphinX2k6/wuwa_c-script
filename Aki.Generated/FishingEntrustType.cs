using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C7E RID: 3198
	public struct FishingEntrustType : IFlatbufferObject
	{
		// Token: 0x1700115A RID: 4442
		// (get) Token: 0x06006F3E RID: 28478 RVA: 0x00230F0C File Offset: 0x0022F10C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006F3F RID: 28479 RVA: 0x00230F19 File Offset: 0x0022F119
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006F40 RID: 28480 RVA: 0x00230F20 File Offset: 0x0022F120
		public static FishingEntrustType GetRootAsFishingEntrustType(ByteBuffer _bb)
		{
			return FishingEntrustType.GetRootAsFishingEntrustType(_bb, default(FishingEntrustType));
		}

		// Token: 0x06006F41 RID: 28481 RVA: 0x00230F3C File Offset: 0x0022F13C
		public static FishingEntrustType GetRootAsFishingEntrustType(ByteBuffer _bb, FishingEntrustType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006F42 RID: 28482 RVA: 0x00230F59 File Offset: 0x0022F159
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006F43 RID: 28483 RVA: 0x00230F68 File Offset: 0x0022F168
		public FishingEntrustType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700115B RID: 4443
		// (get) Token: 0x06006F44 RID: 28484 RVA: 0x00230F78 File Offset: 0x0022F178
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

		// Token: 0x1700115C RID: 4444
		// (get) Token: 0x06006F45 RID: 28485 RVA: 0x00230FB4 File Offset: 0x0022F1B4
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

		// Token: 0x06006F46 RID: 28486 RVA: 0x00230FEB File Offset: 0x0022F1EB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006F47 RID: 28487 RVA: 0x00230FFA File Offset: 0x0022F1FA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700115D RID: 4445
		// (get) Token: 0x06006F48 RID: 28488 RVA: 0x00231014 File Offset: 0x0022F214
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

		// Token: 0x06006F49 RID: 28489 RVA: 0x0023104B File Offset: 0x0022F24B
		public Span<byte> GetColorBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006F4A RID: 28490 RVA: 0x0023105A File Offset: 0x0022F25A
		public byte[] GetColorArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004CCD RID: 19661
		private Table __p;
	}
}
