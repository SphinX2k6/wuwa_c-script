using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001147 RID: 4423
	public struct TrackMoonActivityReward : IFlatbufferObject
	{
		// Token: 0x17003B1D RID: 15133
		// (get) Token: 0x0600E0A6 RID: 57510 RVA: 0x00331E89 File Offset: 0x00330089
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E0A7 RID: 57511 RVA: 0x00331E96 File Offset: 0x00330096
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E0A8 RID: 57512 RVA: 0x00331EA0 File Offset: 0x003300A0
		public static TrackMoonActivityReward GetRootAsTrackMoonActivityReward(ByteBuffer _bb)
		{
			return TrackMoonActivityReward.GetRootAsTrackMoonActivityReward(_bb, default(TrackMoonActivityReward));
		}

		// Token: 0x0600E0A9 RID: 57513 RVA: 0x00331EBC File Offset: 0x003300BC
		public static TrackMoonActivityReward GetRootAsTrackMoonActivityReward(ByteBuffer _bb, TrackMoonActivityReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E0AA RID: 57514 RVA: 0x00331ED9 File Offset: 0x003300D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E0AB RID: 57515 RVA: 0x00331EE8 File Offset: 0x003300E8
		public TrackMoonActivityReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003B1E RID: 15134
		// (get) Token: 0x0600E0AC RID: 57516 RVA: 0x00331EF8 File Offset: 0x003300F8
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

		// Token: 0x17003B1F RID: 15135
		// (get) Token: 0x0600E0AD RID: 57517 RVA: 0x00331F34 File Offset: 0x00330134
		public string TargetName
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E0AE RID: 57518 RVA: 0x00331F6B File Offset: 0x0033016B
		public Span<byte> GetTargetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E0AF RID: 57519 RVA: 0x00331F7A File Offset: 0x0033017A
		public byte[] GetTargetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003B20 RID: 15136
		// (get) Token: 0x0600E0B0 RID: 57520 RVA: 0x00331F94 File Offset: 0x00330194
		public int TargetReward
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

		// Token: 0x17003B21 RID: 15137
		// (get) Token: 0x0600E0B1 RID: 57521 RVA: 0x00331FD0 File Offset: 0x003301D0
		public int TargetFunc
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

		// Token: 0x04005289 RID: 21129
		private Table __p;
	}
}
