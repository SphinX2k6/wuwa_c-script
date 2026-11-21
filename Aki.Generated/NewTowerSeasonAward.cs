using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F78 RID: 3960
	public struct NewTowerSeasonAward : IFlatbufferObject
	{
		// Token: 0x170023F1 RID: 9201
		// (get) Token: 0x0600A61D RID: 42525 RVA: 0x002BD0D1 File Offset: 0x002BB2D1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A61E RID: 42526 RVA: 0x002BD0DE File Offset: 0x002BB2DE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A61F RID: 42527 RVA: 0x002BD0E8 File Offset: 0x002BB2E8
		public static NewTowerSeasonAward GetRootAsNewTowerSeasonAward(ByteBuffer _bb)
		{
			return NewTowerSeasonAward.GetRootAsNewTowerSeasonAward(_bb, default(NewTowerSeasonAward));
		}

		// Token: 0x0600A620 RID: 42528 RVA: 0x002BD104 File Offset: 0x002BB304
		public static NewTowerSeasonAward GetRootAsNewTowerSeasonAward(ByteBuffer _bb, NewTowerSeasonAward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A621 RID: 42529 RVA: 0x002BD121 File Offset: 0x002BB321
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A622 RID: 42530 RVA: 0x002BD130 File Offset: 0x002BB330
		public NewTowerSeasonAward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170023F2 RID: 9202
		// (get) Token: 0x0600A623 RID: 42531 RVA: 0x002BD140 File Offset: 0x002BB340
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

		// Token: 0x170023F3 RID: 9203
		// (get) Token: 0x0600A624 RID: 42532 RVA: 0x002BD17C File Offset: 0x002BB37C
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

		// Token: 0x170023F4 RID: 9204
		// (get) Token: 0x0600A625 RID: 42533 RVA: 0x002BD1B8 File Offset: 0x002BB3B8
		public int CycleId
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

		// Token: 0x170023F5 RID: 9205
		// (get) Token: 0x0600A626 RID: 42534 RVA: 0x002BD1F4 File Offset: 0x002BB3F4
		public int Index
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

		// Token: 0x170023F6 RID: 9206
		// (get) Token: 0x0600A627 RID: 42535 RVA: 0x002BD234 File Offset: 0x002BB434
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

		// Token: 0x170023F7 RID: 9207
		// (get) Token: 0x0600A628 RID: 42536 RVA: 0x002BD274 File Offset: 0x002BB474
		public string Name
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

		// Token: 0x0600A629 RID: 42537 RVA: 0x002BD2AC File Offset: 0x002BB4AC
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600A62A RID: 42538 RVA: 0x002BD2BC File Offset: 0x002BB4BC
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170023F8 RID: 9208
		// (get) Token: 0x0600A62B RID: 42539 RVA: 0x002BD2D4 File Offset: 0x002BB4D4
		public string Desc
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

		// Token: 0x0600A62C RID: 42540 RVA: 0x002BD30C File Offset: 0x002BB50C
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600A62D RID: 42541 RVA: 0x002BD31C File Offset: 0x002BB51C
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170023F9 RID: 9209
		// (get) Token: 0x0600A62E RID: 42542 RVA: 0x002BD334 File Offset: 0x002BB534
		public string Icon
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

		// Token: 0x0600A62F RID: 42543 RVA: 0x002BD36C File Offset: 0x002BB56C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600A630 RID: 42544 RVA: 0x002BD37C File Offset: 0x002BB57C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170023FA RID: 9210
		// (get) Token: 0x0600A631 RID: 42545 RVA: 0x002BD394 File Offset: 0x002BB594
		public string ShineIcon
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

		// Token: 0x0600A632 RID: 42546 RVA: 0x002BD3CC File Offset: 0x002BB5CC
		public Span<byte> GetShineIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600A633 RID: 42547 RVA: 0x002BD3DC File Offset: 0x002BB5DC
		public byte[] GetShineIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x0400552B RID: 21803
		private Table __p;
	}
}
