using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D82 RID: 3458
	public struct ItemMainType : IFlatbufferObject
	{
		// Token: 0x17001A2D RID: 6701
		// (get) Token: 0x060086D5 RID: 34517 RVA: 0x002671A8 File Offset: 0x002653A8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060086D6 RID: 34518 RVA: 0x002671B5 File Offset: 0x002653B5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060086D7 RID: 34519 RVA: 0x002671BC File Offset: 0x002653BC
		public static ItemMainType GetRootAsItemMainType(ByteBuffer _bb)
		{
			return ItemMainType.GetRootAsItemMainType(_bb, default(ItemMainType));
		}

		// Token: 0x060086D8 RID: 34520 RVA: 0x002671D8 File Offset: 0x002653D8
		public static ItemMainType GetRootAsItemMainType(ByteBuffer _bb, ItemMainType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060086D9 RID: 34521 RVA: 0x002671F5 File Offset: 0x002653F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060086DA RID: 34522 RVA: 0x00267204 File Offset: 0x00265404
		public ItemMainType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001A2E RID: 6702
		// (get) Token: 0x060086DB RID: 34523 RVA: 0x00267214 File Offset: 0x00265414
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

		// Token: 0x17001A2F RID: 6703
		// (get) Token: 0x060086DC RID: 34524 RVA: 0x00267250 File Offset: 0x00265450
		public bool BShowInRecallInstance
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001A30 RID: 6704
		// (get) Token: 0x060086DD RID: 34525 RVA: 0x00267290 File Offset: 0x00265490
		public bool BShowInInventoryView
		{
			get
			{
				int num = this.__p.__offset(8);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001A31 RID: 6705
		// (get) Token: 0x060086DE RID: 34526 RVA: 0x002672D0 File Offset: 0x002654D0
		public string Name
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

		// Token: 0x060086DF RID: 34527 RVA: 0x00267308 File Offset: 0x00265508
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060086E0 RID: 34528 RVA: 0x00267318 File Offset: 0x00265518
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A32 RID: 6706
		// (get) Token: 0x060086E1 RID: 34529 RVA: 0x00267330 File Offset: 0x00265530
		public string Icon
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

		// Token: 0x060086E2 RID: 34530 RVA: 0x00267368 File Offset: 0x00265568
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060086E3 RID: 34531 RVA: 0x00267378 File Offset: 0x00265578
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A33 RID: 6707
		// (get) Token: 0x060086E4 RID: 34532 RVA: 0x00267390 File Offset: 0x00265590
		public string IconFirstAchieve
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

		// Token: 0x060086E5 RID: 34533 RVA: 0x002673C8 File Offset: 0x002655C8
		public Span<byte> GetIconFirstAchieveBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060086E6 RID: 34534 RVA: 0x002673D8 File Offset: 0x002655D8
		public byte[] GetIconFirstAchieveArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A34 RID: 6708
		// (get) Token: 0x060086E7 RID: 34535 RVA: 0x002673F0 File Offset: 0x002655F0
		public int PackageId
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

		// Token: 0x17001A35 RID: 6709
		// (get) Token: 0x060086E8 RID: 34536 RVA: 0x00267430 File Offset: 0x00265630
		public bool BShowDescompose
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001A36 RID: 6710
		// (get) Token: 0x060086E9 RID: 34537 RVA: 0x00267470 File Offset: 0x00265670
		public int SequenceId
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001A37 RID: 6711
		// (get) Token: 0x060086EA RID: 34538 RVA: 0x002674B0 File Offset: 0x002656B0
		public int UseWayId
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001A38 RID: 6712
		// (get) Token: 0x060086EB RID: 34539 RVA: 0x002674F0 File Offset: 0x002656F0
		public int DestroyUseWayId
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001A39 RID: 6713
		// (get) Token: 0x060086EC RID: 34540 RVA: 0x00267530 File Offset: 0x00265730
		public bool BFilterSortVisible
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04004E0E RID: 19982
		private Table __p;
	}
}
