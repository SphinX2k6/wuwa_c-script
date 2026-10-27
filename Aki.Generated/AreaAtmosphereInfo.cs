using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B02 RID: 2818
	public struct AreaAtmosphereInfo : IFlatbufferObject
	{
		// Token: 0x17000330 RID: 816
		// (get) Token: 0x0600487E RID: 18558 RVA: 0x001D7A22 File Offset: 0x001D5C22
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600487F RID: 18559 RVA: 0x001D7A2F File Offset: 0x001D5C2F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004880 RID: 18560 RVA: 0x001D7A38 File Offset: 0x001D5C38
		public static AreaAtmosphereInfo GetRootAsAreaAtmosphereInfo(ByteBuffer _bb)
		{
			return AreaAtmosphereInfo.GetRootAsAreaAtmosphereInfo(_bb, default(AreaAtmosphereInfo));
		}

		// Token: 0x06004881 RID: 18561 RVA: 0x001D7A54 File Offset: 0x001D5C54
		public static AreaAtmosphereInfo GetRootAsAreaAtmosphereInfo(ByteBuffer _bb, AreaAtmosphereInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004882 RID: 18562 RVA: 0x001D7A71 File Offset: 0x001D5C71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004883 RID: 18563 RVA: 0x001D7A80 File Offset: 0x001D5C80
		public AreaAtmosphereInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06004884 RID: 18564 RVA: 0x001D7A90 File Offset: 0x001D5C90
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

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06004885 RID: 18565 RVA: 0x001D7ACC File Offset: 0x001D5CCC
		public string DAPath
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

		// Token: 0x06004886 RID: 18566 RVA: 0x001D7B03 File Offset: 0x001D5D03
		public Span<byte> GetDAPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004887 RID: 18567 RVA: 0x001D7B12 File Offset: 0x001D5D12
		public byte[] GetDAPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06004888 RID: 18568 RVA: 0x001D7B2C File Offset: 0x001D5D2C
		public bool IsTOD
		{
			get
			{
				int num = this.__p.__offset(8);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06004889 RID: 18569 RVA: 0x001D7B6C File Offset: 0x001D5D6C
		public int Priority
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

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x0600488A RID: 18570 RVA: 0x001D7BAC File Offset: 0x001D5DAC
		public int FadeTime
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 3;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004AE7 RID: 19175
		private Table __p;
	}
}
