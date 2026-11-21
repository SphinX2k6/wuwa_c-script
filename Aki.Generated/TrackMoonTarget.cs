using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001282 RID: 4738
	public struct TrackMoonTarget : IFlatbufferObject
	{
		// Token: 0x17003EA6 RID: 16038
		// (get) Token: 0x0600EE78 RID: 61048 RVA: 0x0035E255 File Offset: 0x0035C455
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EE79 RID: 61049 RVA: 0x0035E262 File Offset: 0x0035C462
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EE7A RID: 61050 RVA: 0x0035E26C File Offset: 0x0035C46C
		public static TrackMoonTarget GetRootAsTrackMoonTarget(ByteBuffer _bb)
		{
			return TrackMoonTarget.GetRootAsTrackMoonTarget(_bb, default(TrackMoonTarget));
		}

		// Token: 0x0600EE7B RID: 61051 RVA: 0x0035E288 File Offset: 0x0035C488
		public static TrackMoonTarget GetRootAsTrackMoonTarget(ByteBuffer _bb, TrackMoonTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EE7C RID: 61052 RVA: 0x0035E2A5 File Offset: 0x0035C4A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EE7D RID: 61053 RVA: 0x0035E2B4 File Offset: 0x0035C4B4
		public TrackMoonTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003EA7 RID: 16039
		// (get) Token: 0x0600EE7E RID: 61054 RVA: 0x0035E2C4 File Offset: 0x0035C4C4
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

		// Token: 0x17003EA8 RID: 16040
		// (get) Token: 0x0600EE7F RID: 61055 RVA: 0x0035E300 File Offset: 0x0035C500
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

		// Token: 0x0600EE80 RID: 61056 RVA: 0x0035E337 File Offset: 0x0035C537
		public Span<byte> GetTargetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600EE81 RID: 61057 RVA: 0x0035E346 File Offset: 0x0035C546
		public byte[] GetTargetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003EA9 RID: 16041
		// (get) Token: 0x0600EE82 RID: 61058 RVA: 0x0035E360 File Offset: 0x0035C560
		public int Type
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

		// Token: 0x17003EAA RID: 16042
		// (get) Token: 0x0600EE83 RID: 61059 RVA: 0x0035E39C File Offset: 0x0035C59C
		public int TargetReward
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

		// Token: 0x17003EAB RID: 16043
		// (get) Token: 0x0600EE84 RID: 61060 RVA: 0x0035E3DC File Offset: 0x0035C5DC
		public int TargetFunc
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

		// Token: 0x040058D4 RID: 22740
		private Table __p;
	}
}
