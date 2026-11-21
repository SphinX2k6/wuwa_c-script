using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F79 RID: 3961
	public struct NewTowerSeasonSAward : IFlatbufferObject
	{
		// Token: 0x170023FB RID: 9211
		// (get) Token: 0x0600A634 RID: 42548 RVA: 0x002BD3F4 File Offset: 0x002BB5F4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A635 RID: 42549 RVA: 0x002BD401 File Offset: 0x002BB601
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A636 RID: 42550 RVA: 0x002BD408 File Offset: 0x002BB608
		public static NewTowerSeasonSAward GetRootAsNewTowerSeasonSAward(ByteBuffer _bb)
		{
			return NewTowerSeasonSAward.GetRootAsNewTowerSeasonSAward(_bb, default(NewTowerSeasonSAward));
		}

		// Token: 0x0600A637 RID: 42551 RVA: 0x002BD424 File Offset: 0x002BB624
		public static NewTowerSeasonSAward GetRootAsNewTowerSeasonSAward(ByteBuffer _bb, NewTowerSeasonSAward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A638 RID: 42552 RVA: 0x002BD441 File Offset: 0x002BB641
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A639 RID: 42553 RVA: 0x002BD450 File Offset: 0x002BB650
		public NewTowerSeasonSAward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170023FC RID: 9212
		// (get) Token: 0x0600A63A RID: 42554 RVA: 0x002BD460 File Offset: 0x002BB660
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

		// Token: 0x170023FD RID: 9213
		// (get) Token: 0x0600A63B RID: 42555 RVA: 0x002BD49C File Offset: 0x002BB69C
		public int SeasonId
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

		// Token: 0x170023FE RID: 9214
		// (get) Token: 0x0600A63C RID: 42556 RVA: 0x002BD4D8 File Offset: 0x002BB6D8
		public int Index
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

		// Token: 0x170023FF RID: 9215
		// (get) Token: 0x0600A63D RID: 42557 RVA: 0x002BD514 File Offset: 0x002BB714
		public int Score
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

		// Token: 0x17002400 RID: 9216
		// (get) Token: 0x0600A63E RID: 42558 RVA: 0x002BD554 File Offset: 0x002BB754
		public int DropId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002401 RID: 9217
		// (get) Token: 0x0600A63F RID: 42559 RVA: 0x002BD594 File Offset: 0x002BB794
		public int MotorPreviewId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002402 RID: 9218
		// (get) Token: 0x0600A640 RID: 42560 RVA: 0x002BD5D4 File Offset: 0x002BB7D4
		public int WeaponPreviewId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002403 RID: 9219
		// (get) Token: 0x0600A641 RID: 42561 RVA: 0x002BD614 File Offset: 0x002BB814
		public string PreviewIcon
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

		// Token: 0x0600A642 RID: 42562 RVA: 0x002BD64C File Offset: 0x002BB84C
		public Span<byte> GetPreviewIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600A643 RID: 42563 RVA: 0x002BD65C File Offset: 0x002BB85C
		public byte[] GetPreviewIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0400552C RID: 21804
		private Table __p;
	}
}
