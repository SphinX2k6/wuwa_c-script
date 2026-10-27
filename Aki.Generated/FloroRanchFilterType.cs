using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CAA RID: 3242
	public struct FloroRanchFilterType : IFlatbufferObject
	{
		// Token: 0x170012F0 RID: 4848
		// (get) Token: 0x0600735F RID: 29535 RVA: 0x0023B2C2 File Offset: 0x002394C2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007360 RID: 29536 RVA: 0x0023B2CF File Offset: 0x002394CF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007361 RID: 29537 RVA: 0x0023B2D8 File Offset: 0x002394D8
		public static FloroRanchFilterType GetRootAsFloroRanchFilterType(ByteBuffer _bb)
		{
			return FloroRanchFilterType.GetRootAsFloroRanchFilterType(_bb, default(FloroRanchFilterType));
		}

		// Token: 0x06007362 RID: 29538 RVA: 0x0023B2F4 File Offset: 0x002394F4
		public static FloroRanchFilterType GetRootAsFloroRanchFilterType(ByteBuffer _bb, FloroRanchFilterType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007363 RID: 29539 RVA: 0x0023B311 File Offset: 0x00239511
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007364 RID: 29540 RVA: 0x0023B320 File Offset: 0x00239520
		public FloroRanchFilterType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170012F1 RID: 4849
		// (get) Token: 0x06007365 RID: 29541 RVA: 0x0023B330 File Offset: 0x00239530
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

		// Token: 0x170012F2 RID: 4850
		// (get) Token: 0x06007366 RID: 29542 RVA: 0x0023B36C File Offset: 0x0023956C
		public int FilterTypeId
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

		// Token: 0x170012F3 RID: 4851
		// (get) Token: 0x06007367 RID: 29543 RVA: 0x0023B3A8 File Offset: 0x002395A8
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

		// Token: 0x06007368 RID: 29544 RVA: 0x0023B3DF File Offset: 0x002395DF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007369 RID: 29545 RVA: 0x0023B3EE File Offset: 0x002395EE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004D0E RID: 19726
		private Table __p;
	}
}
