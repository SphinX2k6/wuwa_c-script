using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F0F RID: 3855
	public struct MoraleMonsterGrowth : IFlatbufferObject
	{
		// Token: 0x1700204F RID: 8271
		// (get) Token: 0x06009C7C RID: 40060 RVA: 0x002A8098 File Offset: 0x002A6298
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009C7D RID: 40061 RVA: 0x002A80A5 File Offset: 0x002A62A5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009C7E RID: 40062 RVA: 0x002A80AC File Offset: 0x002A62AC
		public static MoraleMonsterGrowth GetRootAsMoraleMonsterGrowth(ByteBuffer _bb)
		{
			return MoraleMonsterGrowth.GetRootAsMoraleMonsterGrowth(_bb, default(MoraleMonsterGrowth));
		}

		// Token: 0x06009C7F RID: 40063 RVA: 0x002A80C8 File Offset: 0x002A62C8
		public static MoraleMonsterGrowth GetRootAsMoraleMonsterGrowth(ByteBuffer _bb, MoraleMonsterGrowth obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009C80 RID: 40064 RVA: 0x002A80E5 File Offset: 0x002A62E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009C81 RID: 40065 RVA: 0x002A80F4 File Offset: 0x002A62F4
		public MoraleMonsterGrowth __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002050 RID: 8272
		// (get) Token: 0x06009C82 RID: 40066 RVA: 0x002A8104 File Offset: 0x002A6304
		public int Level
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

		// Token: 0x17002051 RID: 8273
		// (get) Token: 0x06009C83 RID: 40067 RVA: 0x002A8140 File Offset: 0x002A6340
		public int LifeMaxRatio
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

		// Token: 0x17002052 RID: 8274
		// (get) Token: 0x06009C84 RID: 40068 RVA: 0x002A817C File Offset: 0x002A637C
		public int AtkRatio
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

		// Token: 0x17002053 RID: 8275
		// (get) Token: 0x06009C85 RID: 40069 RVA: 0x002A81B8 File Offset: 0x002A63B8
		public int DefRatio
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

		// Token: 0x17002054 RID: 8276
		// (get) Token: 0x06009C86 RID: 40070 RVA: 0x002A81F8 File Offset: 0x002A63F8
		public int ExpRatio
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 10000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040054B4 RID: 21684
		private Table __p;
	}
}
