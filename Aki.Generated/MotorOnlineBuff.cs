using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E5E RID: 3678
	public struct MotorOnlineBuff : IFlatbufferObject
	{
		// Token: 0x170021CA RID: 8650
		// (get) Token: 0x06009B09 RID: 39689 RVA: 0x00294F99 File Offset: 0x00293199
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009B0A RID: 39690 RVA: 0x00294FA6 File Offset: 0x002931A6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009B0B RID: 39691 RVA: 0x00294FB0 File Offset: 0x002931B0
		public static MotorOnlineBuff GetRootAsMotorOnlineBuff(ByteBuffer _bb)
		{
			return MotorOnlineBuff.GetRootAsMotorOnlineBuff(_bb, default(MotorOnlineBuff));
		}

		// Token: 0x06009B0C RID: 39692 RVA: 0x00294FCC File Offset: 0x002931CC
		public static MotorOnlineBuff GetRootAsMotorOnlineBuff(ByteBuffer _bb, MotorOnlineBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009B0D RID: 39693 RVA: 0x00294FE9 File Offset: 0x002931E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009B0E RID: 39694 RVA: 0x00294FF8 File Offset: 0x002931F8
		public MotorOnlineBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170021CB RID: 8651
		// (get) Token: 0x06009B0F RID: 39695 RVA: 0x00295008 File Offset: 0x00293208
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

		// Token: 0x170021CC RID: 8652
		// (get) Token: 0x06009B10 RID: 39696 RVA: 0x00295044 File Offset: 0x00293244
		public int InstId
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

		// Token: 0x170021CD RID: 8653
		// (get) Token: 0x06009B11 RID: 39697 RVA: 0x00295080 File Offset: 0x00293280
		public int TriggerRank
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

		// Token: 0x170021CE RID: 8654
		// (get) Token: 0x06009B12 RID: 39698 RVA: 0x002950BC File Offset: 0x002932BC
		public int BroadcastGroup
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

		// Token: 0x170021CF RID: 8655
		// (get) Token: 0x06009B13 RID: 39699 RVA: 0x002950FC File Offset: 0x002932FC
		public int EffectType
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

		// Token: 0x170021D0 RID: 8656
		// (get) Token: 0x06009B14 RID: 39700 RVA: 0x0029513C File Offset: 0x0029333C
		public int EffectTime
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

		// Token: 0x04004F0A RID: 20234
		private Table __p;
	}
}
