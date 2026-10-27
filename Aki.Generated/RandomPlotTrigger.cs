using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F96 RID: 3990
	public struct RandomPlotTrigger : IFlatbufferObject
	{
		// Token: 0x17002CFD RID: 11517
		// (get) Token: 0x0600B910 RID: 47376 RVA: 0x002D7725 File Offset: 0x002D5925
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B911 RID: 47377 RVA: 0x002D7732 File Offset: 0x002D5932
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B912 RID: 47378 RVA: 0x002D773C File Offset: 0x002D593C
		public static RandomPlotTrigger GetRootAsRandomPlotTrigger(ByteBuffer _bb)
		{
			return RandomPlotTrigger.GetRootAsRandomPlotTrigger(_bb, default(RandomPlotTrigger));
		}

		// Token: 0x0600B913 RID: 47379 RVA: 0x002D7758 File Offset: 0x002D5958
		public static RandomPlotTrigger GetRootAsRandomPlotTrigger(ByteBuffer _bb, RandomPlotTrigger obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B914 RID: 47380 RVA: 0x002D7775 File Offset: 0x002D5975
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B915 RID: 47381 RVA: 0x002D7784 File Offset: 0x002D5984
		public RandomPlotTrigger __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002CFE RID: 11518
		// (get) Token: 0x0600B916 RID: 47382 RVA: 0x002D7794 File Offset: 0x002D5994
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

		// Token: 0x17002CFF RID: 11519
		// (get) Token: 0x0600B917 RID: 47383 RVA: 0x002D77D0 File Offset: 0x002D59D0
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

		// Token: 0x17002D00 RID: 11520
		// (get) Token: 0x0600B918 RID: 47384 RVA: 0x002D780C File Offset: 0x002D5A0C
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

		// Token: 0x17002D01 RID: 11521
		// (get) Token: 0x0600B919 RID: 47385 RVA: 0x002D7848 File Offset: 0x002D5A48
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

		// Token: 0x17002D02 RID: 11522
		// (get) Token: 0x0600B91A RID: 47386 RVA: 0x002D7888 File Offset: 0x002D5A88
		public bool ResetCondition
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04005066 RID: 20582
		private Table __p;
	}
}
