using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B16 RID: 2838
	public struct AvoidBlockLevel : IFlatbufferObject
	{
		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06004A04 RID: 18948 RVA: 0x001DAFD5 File Offset: 0x001D91D5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004A05 RID: 18949 RVA: 0x001DAFE2 File Offset: 0x001D91E2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004A06 RID: 18950 RVA: 0x001DAFEC File Offset: 0x001D91EC
		public static AvoidBlockLevel GetRootAsAvoidBlockLevel(ByteBuffer _bb)
		{
			return AvoidBlockLevel.GetRootAsAvoidBlockLevel(_bb, default(AvoidBlockLevel));
		}

		// Token: 0x06004A07 RID: 18951 RVA: 0x001DB008 File Offset: 0x001D9208
		public static AvoidBlockLevel GetRootAsAvoidBlockLevel(ByteBuffer _bb, AvoidBlockLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004A08 RID: 18952 RVA: 0x001DB025 File Offset: 0x001D9225
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004A09 RID: 18953 RVA: 0x001DB034 File Offset: 0x001D9234
		public AvoidBlockLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06004A0A RID: 18954 RVA: 0x001DB044 File Offset: 0x001D9244
		public int InstId
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

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06004A0B RID: 18955 RVA: 0x001DB080 File Offset: 0x001D9280
		public int RewardGroupId
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

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06004A0C RID: 18956 RVA: 0x001DB0BC File Offset: 0x001D92BC
		public string MainTitleText
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004A0D RID: 18957 RVA: 0x001DB0F3 File Offset: 0x001D92F3
		public Span<byte> GetMainTitleTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004A0E RID: 18958 RVA: 0x001DB102 File Offset: 0x001D9302
		public byte[] GetMainTitleTextArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06004A0F RID: 18959 RVA: 0x001DB11C File Offset: 0x001D931C
		public string AchieveText
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004A10 RID: 18960 RVA: 0x001DB154 File Offset: 0x001D9354
		public Span<byte> GetAchieveTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004A11 RID: 18961 RVA: 0x001DB164 File Offset: 0x001D9364
		public byte[] GetAchieveTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06004A12 RID: 18962 RVA: 0x001DB17C File Offset: 0x001D937C
		public string RewardTitleText
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004A13 RID: 18963 RVA: 0x001DB1B4 File Offset: 0x001D93B4
		public Span<byte> GetRewardTitleTextBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06004A14 RID: 18964 RVA: 0x001DB1C4 File Offset: 0x001D93C4
		public byte[] GetRewardTitleTextArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04004AFE RID: 19198
		private Table __p;
	}
}
