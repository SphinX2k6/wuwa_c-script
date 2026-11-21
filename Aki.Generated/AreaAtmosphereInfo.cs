using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BDC RID: 3036
	public struct AreaAtmosphereInfo : IFlatbufferObject
	{
		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06004DC5 RID: 19909 RVA: 0x001F726E File Offset: 0x001F546E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004DC6 RID: 19910 RVA: 0x001F727B File Offset: 0x001F547B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004DC7 RID: 19911 RVA: 0x001F7284 File Offset: 0x001F5484
		public static AreaAtmosphereInfo GetRootAsAreaAtmosphereInfo(ByteBuffer _bb)
		{
			return AreaAtmosphereInfo.GetRootAsAreaAtmosphereInfo(_bb, default(AreaAtmosphereInfo));
		}

		// Token: 0x06004DC8 RID: 19912 RVA: 0x001F72A0 File Offset: 0x001F54A0
		public static AreaAtmosphereInfo GetRootAsAreaAtmosphereInfo(ByteBuffer _bb, AreaAtmosphereInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004DC9 RID: 19913 RVA: 0x001F72BD File Offset: 0x001F54BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004DCA RID: 19914 RVA: 0x001F72CC File Offset: 0x001F54CC
		public AreaAtmosphereInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06004DCB RID: 19915 RVA: 0x001F72DC File Offset: 0x001F54DC
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

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06004DCC RID: 19916 RVA: 0x001F7318 File Offset: 0x001F5518
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

		// Token: 0x06004DCD RID: 19917 RVA: 0x001F734F File Offset: 0x001F554F
		public Span<byte> GetDAPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004DCE RID: 19918 RVA: 0x001F735E File Offset: 0x001F555E
		public byte[] GetDAPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06004DCF RID: 19919 RVA: 0x001F7378 File Offset: 0x001F5578
		public bool IsTOD
		{
			get
			{
				int num = this.__p.__offset(8);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06004DD0 RID: 19920 RVA: 0x001F73B8 File Offset: 0x001F55B8
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

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06004DD1 RID: 19921 RVA: 0x001F73F8 File Offset: 0x001F55F8
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

		// Token: 0x040050C1 RID: 20673
		private Table __p;
	}
}
