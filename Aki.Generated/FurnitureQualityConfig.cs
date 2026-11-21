using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DBF RID: 3519
	public struct FurnitureQualityConfig : IFlatbufferObject
	{
		// Token: 0x170014E8 RID: 5352
		// (get) Token: 0x06007DE4 RID: 32228 RVA: 0x00264058 File Offset: 0x00262258
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007DE5 RID: 32229 RVA: 0x00264065 File Offset: 0x00262265
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007DE6 RID: 32230 RVA: 0x0026406C File Offset: 0x0026226C
		public static FurnitureQualityConfig GetRootAsFurnitureQualityConfig(ByteBuffer _bb)
		{
			return FurnitureQualityConfig.GetRootAsFurnitureQualityConfig(_bb, default(FurnitureQualityConfig));
		}

		// Token: 0x06007DE7 RID: 32231 RVA: 0x00264088 File Offset: 0x00262288
		public static FurnitureQualityConfig GetRootAsFurnitureQualityConfig(ByteBuffer _bb, FurnitureQualityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007DE8 RID: 32232 RVA: 0x002640A5 File Offset: 0x002622A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007DE9 RID: 32233 RVA: 0x002640B4 File Offset: 0x002622B4
		public FurnitureQualityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170014E9 RID: 5353
		// (get) Token: 0x06007DEA RID: 32234 RVA: 0x002640C4 File Offset: 0x002622C4
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

		// Token: 0x170014EA RID: 5354
		// (get) Token: 0x06007DEB RID: 32235 RVA: 0x00264100 File Offset: 0x00262300
		public string TipBgColor
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

		// Token: 0x06007DEC RID: 32236 RVA: 0x00264137 File Offset: 0x00262337
		public Span<byte> GetTipBgColorBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007DED RID: 32237 RVA: 0x00264146 File Offset: 0x00262346
		public byte[] GetTipBgColorArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170014EB RID: 5355
		// (get) Token: 0x06007DEE RID: 32238 RVA: 0x00264160 File Offset: 0x00262360
		public string TipLineColor
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

		// Token: 0x06007DEF RID: 32239 RVA: 0x00264197 File Offset: 0x00262397
		public Span<byte> GetTipLineColorBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007DF0 RID: 32240 RVA: 0x002641A6 File Offset: 0x002623A6
		public byte[] GetTipLineColorArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170014EC RID: 5356
		// (get) Token: 0x06007DF1 RID: 32241 RVA: 0x002641C0 File Offset: 0x002623C0
		public string ScrollItemColor
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

		// Token: 0x06007DF2 RID: 32242 RVA: 0x002641F8 File Offset: 0x002623F8
		public Span<byte> GetScrollItemColorBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007DF3 RID: 32243 RVA: 0x00264208 File Offset: 0x00262408
		public byte[] GetScrollItemColorArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04005330 RID: 21296
		private Table __p;
	}
}
