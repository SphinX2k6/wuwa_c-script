using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DED RID: 3565
	public struct MapLevelExp : IFlatbufferObject
	{
		// Token: 0x17001DEE RID: 7662
		// (get) Token: 0x060090EE RID: 37102 RVA: 0x0027E065 File Offset: 0x0027C265
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060090EF RID: 37103 RVA: 0x0027E072 File Offset: 0x0027C272
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060090F0 RID: 37104 RVA: 0x0027E07C File Offset: 0x0027C27C
		public static MapLevelExp GetRootAsMapLevelExp(ByteBuffer _bb)
		{
			return MapLevelExp.GetRootAsMapLevelExp(_bb, default(MapLevelExp));
		}

		// Token: 0x060090F1 RID: 37105 RVA: 0x0027E098 File Offset: 0x0027C298
		public static MapLevelExp GetRootAsMapLevelExp(ByteBuffer _bb, MapLevelExp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060090F2 RID: 37106 RVA: 0x0027E0B5 File Offset: 0x0027C2B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060090F3 RID: 37107 RVA: 0x0027E0C4 File Offset: 0x0027C2C4
		public MapLevelExp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001DEF RID: 7663
		// (get) Token: 0x060090F4 RID: 37108 RVA: 0x0027E0D4 File Offset: 0x0027C2D4
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

		// Token: 0x17001DF0 RID: 7664
		// (get) Token: 0x060090F5 RID: 37109 RVA: 0x0027E110 File Offset: 0x0027C310
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

		// Token: 0x17001DF1 RID: 7665
		// (get) Token: 0x060090F6 RID: 37110 RVA: 0x0027E14C File Offset: 0x0027C34C
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

		// Token: 0x17001DF2 RID: 7666
		// (get) Token: 0x060090F7 RID: 37111 RVA: 0x0027E188 File Offset: 0x0027C388
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

		// Token: 0x17001DF3 RID: 7667
		// (get) Token: 0x060090F8 RID: 37112 RVA: 0x0027E1C8 File Offset: 0x0027C3C8
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

		// Token: 0x17001DF4 RID: 7668
		// (get) Token: 0x060090F9 RID: 37113 RVA: 0x0027E208 File Offset: 0x0027C408
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

		// Token: 0x060090FA RID: 37114 RVA: 0x0027E240 File Offset: 0x0027C440
		public Span<byte> GetTipsLockBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060090FB RID: 37115 RVA: 0x0027E250 File Offset: 0x0027C450
		public byte[] GetTipsLockArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001DF5 RID: 7669
		// (get) Token: 0x060090FC RID: 37116 RVA: 0x0027E268 File Offset: 0x0027C468
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

		// Token: 0x060090FD RID: 37117 RVA: 0x0027E2A0 File Offset: 0x0027C4A0
		public Span<byte> GetTipsDoneBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060090FE RID: 37118 RVA: 0x0027E2B0 File Offset: 0x0027C4B0
		public byte[] GetTipsDoneArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x04004E89 RID: 20105
		private Table __p;
	}
}
