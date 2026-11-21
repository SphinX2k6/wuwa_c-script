using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200127F RID: 4735
	public struct TrackMoonHandbookReward : IFlatbufferObject
	{
		// Token: 0x17003E97 RID: 16023
		// (get) Token: 0x0600EE56 RID: 61014 RVA: 0x0035DDF4 File Offset: 0x0035BFF4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EE57 RID: 61015 RVA: 0x0035DE01 File Offset: 0x0035C001
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EE58 RID: 61016 RVA: 0x0035DE08 File Offset: 0x0035C008
		public static TrackMoonHandbookReward GetRootAsTrackMoonHandbookReward(ByteBuffer _bb)
		{
			return TrackMoonHandbookReward.GetRootAsTrackMoonHandbookReward(_bb, default(TrackMoonHandbookReward));
		}

		// Token: 0x0600EE59 RID: 61017 RVA: 0x0035DE24 File Offset: 0x0035C024
		public static TrackMoonHandbookReward GetRootAsTrackMoonHandbookReward(ByteBuffer _bb, TrackMoonHandbookReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EE5A RID: 61018 RVA: 0x0035DE41 File Offset: 0x0035C041
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EE5B RID: 61019 RVA: 0x0035DE50 File Offset: 0x0035C050
		public TrackMoonHandbookReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003E98 RID: 16024
		// (get) Token: 0x0600EE5C RID: 61020 RVA: 0x0035DE60 File Offset: 0x0035C060
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

		// Token: 0x17003E99 RID: 16025
		// (get) Token: 0x0600EE5D RID: 61021 RVA: 0x0035DE9C File Offset: 0x0035C09C
		public int Goal
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

		// Token: 0x17003E9A RID: 16026
		// (get) Token: 0x0600EE5E RID: 61022 RVA: 0x0035DED8 File Offset: 0x0035C0D8
		public int RewardInfo
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

		// Token: 0x040058D1 RID: 22737
		private Table __p;
	}
}
