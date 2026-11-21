using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200107D RID: 4221
	public struct RandomPlotTrigger : IFlatbufferObject
	{
		// Token: 0x17002D75 RID: 11637
		// (get) Token: 0x0600BF4D RID: 48973 RVA: 0x002F3F3D File Offset: 0x002F213D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BF4E RID: 48974 RVA: 0x002F3F4A File Offset: 0x002F214A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BF4F RID: 48975 RVA: 0x002F3F54 File Offset: 0x002F2154
		public static RandomPlotTrigger GetRootAsRandomPlotTrigger(ByteBuffer _bb)
		{
			return RandomPlotTrigger.GetRootAsRandomPlotTrigger(_bb, default(RandomPlotTrigger));
		}

		// Token: 0x0600BF50 RID: 48976 RVA: 0x002F3F70 File Offset: 0x002F2170
		public static RandomPlotTrigger GetRootAsRandomPlotTrigger(ByteBuffer _bb, RandomPlotTrigger obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BF51 RID: 48977 RVA: 0x002F3F8D File Offset: 0x002F218D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BF52 RID: 48978 RVA: 0x002F3F9C File Offset: 0x002F219C
		public RandomPlotTrigger __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002D76 RID: 11638
		// (get) Token: 0x0600BF53 RID: 48979 RVA: 0x002F3FAC File Offset: 0x002F21AC
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

		// Token: 0x17002D77 RID: 11639
		// (get) Token: 0x0600BF54 RID: 48980 RVA: 0x002F3FE8 File Offset: 0x002F21E8
		public int TriggerGroupId
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

		// Token: 0x17002D78 RID: 11640
		// (get) Token: 0x0600BF55 RID: 48981 RVA: 0x002F4024 File Offset: 0x002F2224
		public int RandomPlotId
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

		// Token: 0x17002D79 RID: 11641
		// (get) Token: 0x0600BF56 RID: 48982 RVA: 0x002F4060 File Offset: 0x002F2260
		public int TriggerCondition
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

		// Token: 0x17002D7A RID: 11642
		// (get) Token: 0x0600BF57 RID: 48983 RVA: 0x002F40A0 File Offset: 0x002F22A0
		public bool ResetCondition
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0400564D RID: 22093
		private Table __p;
	}
}
