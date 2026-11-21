using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F07 RID: 3847
	public struct MoonPhaseReward : IFlatbufferObject
	{
		// Token: 0x1700201D RID: 8221
		// (get) Token: 0x06009BF1 RID: 39921 RVA: 0x002A6F54 File Offset: 0x002A5154
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009BF2 RID: 39922 RVA: 0x002A6F61 File Offset: 0x002A5161
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009BF3 RID: 39923 RVA: 0x002A6F68 File Offset: 0x002A5168
		public static MoonPhaseReward GetRootAsMoonPhaseReward(ByteBuffer _bb)
		{
			return MoonPhaseReward.GetRootAsMoonPhaseReward(_bb, default(MoonPhaseReward));
		}

		// Token: 0x06009BF4 RID: 39924 RVA: 0x002A6F84 File Offset: 0x002A5184
		public static MoonPhaseReward GetRootAsMoonPhaseReward(ByteBuffer _bb, MoonPhaseReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009BF5 RID: 39925 RVA: 0x002A6FA1 File Offset: 0x002A51A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009BF6 RID: 39926 RVA: 0x002A6FB0 File Offset: 0x002A51B0
		public MoonPhaseReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700201E RID: 8222
		// (get) Token: 0x06009BF7 RID: 39927 RVA: 0x002A6FC0 File Offset: 0x002A51C0
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

		// Token: 0x1700201F RID: 8223
		// (get) Token: 0x06009BF8 RID: 39928 RVA: 0x002A6FFC File Offset: 0x002A51FC
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

		// Token: 0x17002020 RID: 8224
		// (get) Token: 0x06009BF9 RID: 39929 RVA: 0x002A7038 File Offset: 0x002A5238
		public int Reward
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

		// Token: 0x17002021 RID: 8225
		// (get) Token: 0x06009BFA RID: 39930 RVA: 0x002A7074 File Offset: 0x002A5274
		public int NeedMoonNum
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

		// Token: 0x17002022 RID: 8226
		// (get) Token: 0x06009BFB RID: 39931 RVA: 0x002A70B4 File Offset: 0x002A52B4
		public int ItemId
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

		// Token: 0x040054AC RID: 21676
		private Table __p;
	}
}
