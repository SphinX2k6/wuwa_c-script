using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010A6 RID: 4262
	public struct SheriffZone : IFlatbufferObject
	{
		// Token: 0x170035A5 RID: 13733
		// (get) Token: 0x0600D180 RID: 53632 RVA: 0x0030E2B1 File Offset: 0x0030C4B1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D181 RID: 53633 RVA: 0x0030E2BE File Offset: 0x0030C4BE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D182 RID: 53634 RVA: 0x0030E2C8 File Offset: 0x0030C4C8
		public static SheriffZone GetRootAsSheriffZone(ByteBuffer _bb)
		{
			return SheriffZone.GetRootAsSheriffZone(_bb, default(SheriffZone));
		}

		// Token: 0x0600D183 RID: 53635 RVA: 0x0030E2E4 File Offset: 0x0030C4E4
		public static SheriffZone GetRootAsSheriffZone(ByteBuffer _bb, SheriffZone obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D184 RID: 53636 RVA: 0x0030E301 File Offset: 0x0030C501
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D185 RID: 53637 RVA: 0x0030E310 File Offset: 0x0030C510
		public SheriffZone __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170035A6 RID: 13734
		// (get) Token: 0x0600D186 RID: 53638 RVA: 0x0030E320 File Offset: 0x0030C520
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

		// Token: 0x170035A7 RID: 13735
		// (get) Token: 0x0600D187 RID: 53639 RVA: 0x0030E35C File Offset: 0x0030C55C
		public int AnomalyFuncId
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

		// Token: 0x170035A8 RID: 13736
		// (get) Token: 0x0600D188 RID: 53640 RVA: 0x0030E398 File Offset: 0x0030C598
		public int QuestFuncId
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

		// Token: 0x170035A9 RID: 13737
		// (get) Token: 0x0600D189 RID: 53641 RVA: 0x0030E3D4 File Offset: 0x0030C5D4
		public int ItemId
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

		// Token: 0x170035AA RID: 13738
		// (get) Token: 0x0600D18A RID: 53642 RVA: 0x0030E414 File Offset: 0x0030C614
		public int ActivityId
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

		// Token: 0x170035AB RID: 13739
		// (get) Token: 0x0600D18B RID: 53643 RVA: 0x0030E454 File Offset: 0x0030C654
		public int MapId
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

		// Token: 0x040051B5 RID: 20917
		private Table __p;
	}
}
