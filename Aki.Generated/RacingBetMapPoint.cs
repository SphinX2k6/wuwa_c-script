using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200106C RID: 4204
	public struct RacingBetMapPoint : IFlatbufferObject
	{
		// Token: 0x17002CFB RID: 11515
		// (get) Token: 0x0600BE0C RID: 48652 RVA: 0x002F1386 File Offset: 0x002EF586
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BE0D RID: 48653 RVA: 0x002F1393 File Offset: 0x002EF593
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BE0E RID: 48654 RVA: 0x002F139C File Offset: 0x002EF59C
		public static RacingBetMapPoint GetRootAsRacingBetMapPoint(ByteBuffer _bb)
		{
			return RacingBetMapPoint.GetRootAsRacingBetMapPoint(_bb, default(RacingBetMapPoint));
		}

		// Token: 0x0600BE0F RID: 48655 RVA: 0x002F13B8 File Offset: 0x002EF5B8
		public static RacingBetMapPoint GetRootAsRacingBetMapPoint(ByteBuffer _bb, RacingBetMapPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BE10 RID: 48656 RVA: 0x002F13D5 File Offset: 0x002EF5D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BE11 RID: 48657 RVA: 0x002F13E4 File Offset: 0x002EF5E4
		public RacingBetMapPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002CFC RID: 11516
		// (get) Token: 0x0600BE12 RID: 48658 RVA: 0x002F13F4 File Offset: 0x002EF5F4
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

		// Token: 0x17002CFD RID: 11517
		// (get) Token: 0x0600BE13 RID: 48659 RVA: 0x002F1430 File Offset: 0x002EF630
		public int SeasonId
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

		// Token: 0x17002CFE RID: 11518
		// (get) Token: 0x0600BE14 RID: 48660 RVA: 0x002F146C File Offset: 0x002EF66C
		public int SortId
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

		// Token: 0x17002CFF RID: 11519
		// (get) Token: 0x0600BE15 RID: 48661 RVA: 0x002F14A8 File Offset: 0x002EF6A8
		public int EntityId
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

		// Token: 0x17002D00 RID: 11520
		// (get) Token: 0x0600BE16 RID: 48662 RVA: 0x002F14E8 File Offset: 0x002EF6E8
		public int BackwardEntityId
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

		// Token: 0x0400563A RID: 22074
		private Table __p;
	}
}
