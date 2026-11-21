using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001281 RID: 4737
	public struct TrackMoonPhaseActivity : IFlatbufferObject
	{
		// Token: 0x17003EA1 RID: 16033
		// (get) Token: 0x0600EE6E RID: 61038 RVA: 0x0035E0F5 File Offset: 0x0035C2F5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EE6F RID: 61039 RVA: 0x0035E102 File Offset: 0x0035C302
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EE70 RID: 61040 RVA: 0x0035E10C File Offset: 0x0035C30C
		public static TrackMoonPhaseActivity GetRootAsTrackMoonPhaseActivity(ByteBuffer _bb)
		{
			return TrackMoonPhaseActivity.GetRootAsTrackMoonPhaseActivity(_bb, default(TrackMoonPhaseActivity));
		}

		// Token: 0x0600EE71 RID: 61041 RVA: 0x0035E128 File Offset: 0x0035C328
		public static TrackMoonPhaseActivity GetRootAsTrackMoonPhaseActivity(ByteBuffer _bb, TrackMoonPhaseActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EE72 RID: 61042 RVA: 0x0035E145 File Offset: 0x0035C345
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EE73 RID: 61043 RVA: 0x0035E154 File Offset: 0x0035C354
		public TrackMoonPhaseActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003EA2 RID: 16034
		// (get) Token: 0x0600EE74 RID: 61044 RVA: 0x0035E164 File Offset: 0x0035C364
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

		// Token: 0x17003EA3 RID: 16035
		// (get) Token: 0x0600EE75 RID: 61045 RVA: 0x0035E1A0 File Offset: 0x0035C3A0
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

		// Token: 0x17003EA4 RID: 16036
		// (get) Token: 0x0600EE76 RID: 61046 RVA: 0x0035E1DC File Offset: 0x0035C3DC
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

		// Token: 0x17003EA5 RID: 16037
		// (get) Token: 0x0600EE77 RID: 61047 RVA: 0x0035E218 File Offset: 0x0035C418
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

		// Token: 0x040058D3 RID: 22739
		private Table __p;
	}
}
