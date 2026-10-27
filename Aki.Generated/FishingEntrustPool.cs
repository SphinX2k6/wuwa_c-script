using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C7D RID: 3197
	public struct FishingEntrustPool : IFlatbufferObject
	{
		// Token: 0x17001153 RID: 4435
		// (get) Token: 0x06006F2E RID: 28462 RVA: 0x00230CEC File Offset: 0x0022EEEC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006F2F RID: 28463 RVA: 0x00230CF9 File Offset: 0x0022EEF9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006F30 RID: 28464 RVA: 0x00230D00 File Offset: 0x0022EF00
		public static FishingEntrustPool GetRootAsFishingEntrustPool(ByteBuffer _bb)
		{
			return FishingEntrustPool.GetRootAsFishingEntrustPool(_bb, default(FishingEntrustPool));
		}

		// Token: 0x06006F31 RID: 28465 RVA: 0x00230D1C File Offset: 0x0022EF1C
		public static FishingEntrustPool GetRootAsFishingEntrustPool(ByteBuffer _bb, FishingEntrustPool obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006F32 RID: 28466 RVA: 0x00230D39 File Offset: 0x0022EF39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006F33 RID: 28467 RVA: 0x00230D48 File Offset: 0x0022EF48
		public FishingEntrustPool __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001154 RID: 4436
		// (get) Token: 0x06006F34 RID: 28468 RVA: 0x00230D58 File Offset: 0x0022EF58
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

		// Token: 0x17001155 RID: 4437
		// (get) Token: 0x06006F35 RID: 28469 RVA: 0x00230D94 File Offset: 0x0022EF94
		public int Priority
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

		// Token: 0x17001156 RID: 4438
		// (get) Token: 0x06006F36 RID: 28470 RVA: 0x00230DD0 File Offset: 0x0022EFD0
		public int NumLimit
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

		// Token: 0x17001157 RID: 4439
		// (get) Token: 0x06006F37 RID: 28471 RVA: 0x00230E0C File Offset: 0x0022F00C
		public int TotalCount
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001158 RID: 4440
		// (get) Token: 0x06006F38 RID: 28472 RVA: 0x00230E4C File Offset: 0x0022F04C
		public string TitleName
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

		// Token: 0x06006F39 RID: 28473 RVA: 0x00230E84 File Offset: 0x0022F084
		public Span<byte> GetTitleNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06006F3A RID: 28474 RVA: 0x00230E94 File Offset: 0x0022F094
		public byte[] GetTitleNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001159 RID: 4441
		// (get) Token: 0x06006F3B RID: 28475 RVA: 0x00230EAC File Offset: 0x0022F0AC
		public string TitleSprite
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

		// Token: 0x06006F3C RID: 28476 RVA: 0x00230EE4 File Offset: 0x0022F0E4
		public Span<byte> GetTitleSpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06006F3D RID: 28477 RVA: 0x00230EF4 File Offset: 0x0022F0F4
		public byte[] GetTitleSpriteArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04004CCC RID: 19660
		private Table __p;
	}
}
