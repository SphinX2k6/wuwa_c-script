using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ED2 RID: 3794
	public struct MapLevelExp : IFlatbufferObject
	{
		// Token: 0x17001E52 RID: 7762
		// (get) Token: 0x0600970A RID: 38666 RVA: 0x0029C2C9 File Offset: 0x0029A4C9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600970B RID: 38667 RVA: 0x0029C2D6 File Offset: 0x0029A4D6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600970C RID: 38668 RVA: 0x0029C2E0 File Offset: 0x0029A4E0
		public static MapLevelExp GetRootAsMapLevelExp(ByteBuffer _bb)
		{
			return MapLevelExp.GetRootAsMapLevelExp(_bb, default(MapLevelExp));
		}

		// Token: 0x0600970D RID: 38669 RVA: 0x0029C2FC File Offset: 0x0029A4FC
		public static MapLevelExp GetRootAsMapLevelExp(ByteBuffer _bb, MapLevelExp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600970E RID: 38670 RVA: 0x0029C319 File Offset: 0x0029A519
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600970F RID: 38671 RVA: 0x0029C328 File Offset: 0x0029A528
		public MapLevelExp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001E53 RID: 7763
		// (get) Token: 0x06009710 RID: 38672 RVA: 0x0029C338 File Offset: 0x0029A538
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

		// Token: 0x17001E54 RID: 7764
		// (get) Token: 0x06009711 RID: 38673 RVA: 0x0029C374 File Offset: 0x0029A574
		public int ActivityId
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

		// Token: 0x17001E55 RID: 7765
		// (get) Token: 0x06009712 RID: 38674 RVA: 0x0029C3B0 File Offset: 0x0029A5B0
		public int Level
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

		// Token: 0x17001E56 RID: 7766
		// (get) Token: 0x06009713 RID: 38675 RVA: 0x0029C3EC File Offset: 0x0029A5EC
		public int NeedExp
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

		// Token: 0x17001E57 RID: 7767
		// (get) Token: 0x06009714 RID: 38676 RVA: 0x0029C42C File Offset: 0x0029A62C
		public int RewardDropId
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

		// Token: 0x17001E58 RID: 7768
		// (get) Token: 0x06009715 RID: 38677 RVA: 0x0029C46C File Offset: 0x0029A66C
		public string TipsLock
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

		// Token: 0x06009716 RID: 38678 RVA: 0x0029C4A4 File Offset: 0x0029A6A4
		public Span<byte> GetTipsLockBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06009717 RID: 38679 RVA: 0x0029C4B4 File Offset: 0x0029A6B4
		public byte[] GetTipsLockArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E59 RID: 7769
		// (get) Token: 0x06009718 RID: 38680 RVA: 0x0029C4CC File Offset: 0x0029A6CC
		public string TipsDone
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

		// Token: 0x06009719 RID: 38681 RVA: 0x0029C504 File Offset: 0x0029A704
		public Span<byte> GetTipsDoneBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600971A RID: 38682 RVA: 0x0029C514 File Offset: 0x0029A714
		public byte[] GetTipsDoneArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0400546E RID: 21614
		private Table __p;
	}
}
