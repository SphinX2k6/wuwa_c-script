using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D41 RID: 3393
	public struct HonamiStoryMonsterGrowth : IFlatbufferObject
	{
		// Token: 0x170017EC RID: 6124
		// (get) Token: 0x06008088 RID: 32904 RVA: 0x00258AF4 File Offset: 0x00256CF4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008089 RID: 32905 RVA: 0x00258B01 File Offset: 0x00256D01
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600808A RID: 32906 RVA: 0x00258B08 File Offset: 0x00256D08
		public static HonamiStoryMonsterGrowth GetRootAsHonamiStoryMonsterGrowth(ByteBuffer _bb)
		{
			return HonamiStoryMonsterGrowth.GetRootAsHonamiStoryMonsterGrowth(_bb, default(HonamiStoryMonsterGrowth));
		}

		// Token: 0x0600808B RID: 32907 RVA: 0x00258B24 File Offset: 0x00256D24
		public static HonamiStoryMonsterGrowth GetRootAsHonamiStoryMonsterGrowth(ByteBuffer _bb, HonamiStoryMonsterGrowth obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600808C RID: 32908 RVA: 0x00258B41 File Offset: 0x00256D41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600808D RID: 32909 RVA: 0x00258B50 File Offset: 0x00256D50
		public HonamiStoryMonsterGrowth __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170017ED RID: 6125
		// (get) Token: 0x0600808E RID: 32910 RVA: 0x00258B60 File Offset: 0x00256D60
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

		// Token: 0x170017EE RID: 6126
		// (get) Token: 0x0600808F RID: 32911 RVA: 0x00258B9C File Offset: 0x00256D9C
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

		// Token: 0x170017EF RID: 6127
		// (get) Token: 0x06008090 RID: 32912 RVA: 0x00258BD8 File Offset: 0x00256DD8
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

		// Token: 0x170017F0 RID: 6128
		// (get) Token: 0x06008091 RID: 32913 RVA: 0x00258C14 File Offset: 0x00256E14
		public int LifeMaxRatio
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

		// Token: 0x170017F1 RID: 6129
		// (get) Token: 0x06008092 RID: 32914 RVA: 0x00258C54 File Offset: 0x00256E54
		public int AtkRatio
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

		// Token: 0x04004DBC RID: 19900
		private Table __p;
	}
}
