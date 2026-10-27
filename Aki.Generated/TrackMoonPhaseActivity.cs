using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200114B RID: 4427
	public struct TrackMoonPhaseActivity : IFlatbufferObject
	{
		// Token: 0x17003B3D RID: 15165
		// (get) Token: 0x0600E100 RID: 57600 RVA: 0x00332D09 File Offset: 0x00330F09
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E101 RID: 57601 RVA: 0x00332D16 File Offset: 0x00330F16
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E102 RID: 57602 RVA: 0x00332D20 File Offset: 0x00330F20
		public static TrackMoonPhaseActivity GetRootAsTrackMoonPhaseActivity(ByteBuffer _bb)
		{
			return TrackMoonPhaseActivity.GetRootAsTrackMoonPhaseActivity(_bb, default(TrackMoonPhaseActivity));
		}

		// Token: 0x0600E103 RID: 57603 RVA: 0x00332D3C File Offset: 0x00330F3C
		public static TrackMoonPhaseActivity GetRootAsTrackMoonPhaseActivity(ByteBuffer _bb, TrackMoonPhaseActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E104 RID: 57604 RVA: 0x00332D59 File Offset: 0x00330F59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E105 RID: 57605 RVA: 0x00332D68 File Offset: 0x00330F68
		public TrackMoonPhaseActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003B3E RID: 15166
		// (get) Token: 0x0600E106 RID: 57606 RVA: 0x00332D78 File Offset: 0x00330F78
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

		// Token: 0x17003B3F RID: 15167
		// (get) Token: 0x0600E107 RID: 57607 RVA: 0x00332DB4 File Offset: 0x00330FB4
		public int RoleTrialId
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

		// Token: 0x17003B40 RID: 15168
		// (get) Token: 0x0600E108 RID: 57608 RVA: 0x00332DF0 File Offset: 0x00330FF0
		public int DropId
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

		// Token: 0x17003B41 RID: 15169
		// (get) Token: 0x0600E109 RID: 57609 RVA: 0x00332E2C File Offset: 0x0033102C
		public int PopularityNeed
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

		// Token: 0x04005290 RID: 21136
		private Table __p;
	}
}
