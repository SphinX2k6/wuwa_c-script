using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200127D RID: 4733
	public struct TrackMoonActivityReward : IFlatbufferObject
	{
		// Token: 0x17003E81 RID: 16001
		// (get) Token: 0x0600EE14 RID: 60948 RVA: 0x0035D2B6 File Offset: 0x0035B4B6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EE15 RID: 60949 RVA: 0x0035D2C3 File Offset: 0x0035B4C3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EE16 RID: 60950 RVA: 0x0035D2CC File Offset: 0x0035B4CC
		public static TrackMoonActivityReward GetRootAsTrackMoonActivityReward(ByteBuffer _bb)
		{
			return TrackMoonActivityReward.GetRootAsTrackMoonActivityReward(_bb, default(TrackMoonActivityReward));
		}

		// Token: 0x0600EE17 RID: 60951 RVA: 0x0035D2E8 File Offset: 0x0035B4E8
		public static TrackMoonActivityReward GetRootAsTrackMoonActivityReward(ByteBuffer _bb, TrackMoonActivityReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EE18 RID: 60952 RVA: 0x0035D305 File Offset: 0x0035B505
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EE19 RID: 60953 RVA: 0x0035D314 File Offset: 0x0035B514
		public TrackMoonActivityReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003E82 RID: 16002
		// (get) Token: 0x0600EE1A RID: 60954 RVA: 0x0035D324 File Offset: 0x0035B524
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

		// Token: 0x17003E83 RID: 16003
		// (get) Token: 0x0600EE1B RID: 60955 RVA: 0x0035D360 File Offset: 0x0035B560
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

		// Token: 0x0600EE1C RID: 60956 RVA: 0x0035D397 File Offset: 0x0035B597
		public Span<byte> GetTargetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600EE1D RID: 60957 RVA: 0x0035D3A6 File Offset: 0x0035B5A6
		public byte[] GetTargetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003E84 RID: 16004
		// (get) Token: 0x0600EE1E RID: 60958 RVA: 0x0035D3C0 File Offset: 0x0035B5C0
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

		// Token: 0x17003E85 RID: 16005
		// (get) Token: 0x0600EE1F RID: 60959 RVA: 0x0035D3FC File Offset: 0x0035B5FC
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

		// Token: 0x040058CC RID: 22732
		private Table __p;
	}
}
