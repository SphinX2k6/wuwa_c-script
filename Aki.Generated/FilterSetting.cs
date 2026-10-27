using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C70 RID: 3184
	public struct FilterSetting : IFlatbufferObject
	{
		// Token: 0x17001104 RID: 4356
		// (get) Token: 0x06006E68 RID: 28264 RVA: 0x0022EF79 File Offset: 0x0022D179
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006E69 RID: 28265 RVA: 0x0022EF86 File Offset: 0x0022D186
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006E6A RID: 28266 RVA: 0x0022EF90 File Offset: 0x0022D190
		public static FilterSetting GetRootAsFilterSetting(ByteBuffer _bb)
		{
			return FilterSetting.GetRootAsFilterSetting(_bb, default(FilterSetting));
		}

		// Token: 0x06006E6B RID: 28267 RVA: 0x0022EFAC File Offset: 0x0022D1AC
		public static FilterSetting GetRootAsFilterSetting(ByteBuffer _bb, FilterSetting obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006E6C RID: 28268 RVA: 0x0022EFC9 File Offset: 0x0022D1C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006E6D RID: 28269 RVA: 0x0022EFD8 File Offset: 0x0022D1D8
		public FilterSetting __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001105 RID: 4357
		// (get) Token: 0x06006E6E RID: 28270 RVA: 0x0022EFE8 File Offset: 0x0022D1E8
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

		// Token: 0x17001106 RID: 4358
		// (get) Token: 0x06006E6F RID: 28271 RVA: 0x0022F024 File Offset: 0x0022D224
		public int LogicIndex
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

		// Token: 0x17001107 RID: 4359
		// (get) Token: 0x06006E70 RID: 28272 RVA: 0x0022F060 File Offset: 0x0022D260
		public string NameTextId
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

		// Token: 0x06006E71 RID: 28273 RVA: 0x0022F097 File Offset: 0x0022D297
		public Span<byte> GetNameTextIdBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006E72 RID: 28274 RVA: 0x0022F0A6 File Offset: 0x0022D2A6
		public byte[] GetNameTextIdArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001108 RID: 4360
		// (get) Token: 0x06006E73 RID: 28275 RVA: 0x0022F0C0 File Offset: 0x0022D2C0
		public string SpritePath
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

		// Token: 0x06006E74 RID: 28276 RVA: 0x0022F0F8 File Offset: 0x0022D2F8
		public Span<byte> GetSpritePathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06006E75 RID: 28277 RVA: 0x0022F108 File Offset: 0x0022D308
		public byte[] GetSpritePathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001109 RID: 4361
		// (get) Token: 0x06006E76 RID: 28278 RVA: 0x0022F120 File Offset: 0x0022D320
		public string PadTexturePath
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

		// Token: 0x06006E77 RID: 28279 RVA: 0x0022F158 File Offset: 0x0022D358
		public Span<byte> GetPadTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06006E78 RID: 28280 RVA: 0x0022F168 File Offset: 0x0022D368
		public byte[] GetPadTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04004CBB RID: 19643
		private Table __p;
	}
}
