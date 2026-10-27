using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200106A RID: 4202
	public struct RollBlockTemplate : IFlatbufferObject
	{
		// Token: 0x170033A7 RID: 13223
		// (get) Token: 0x0600CBF8 RID: 52216 RVA: 0x00301EC9 File Offset: 0x003000C9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CBF9 RID: 52217 RVA: 0x00301ED6 File Offset: 0x003000D6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CBFA RID: 52218 RVA: 0x00301EE0 File Offset: 0x003000E0
		public static RollBlockTemplate GetRootAsRollBlockTemplate(ByteBuffer _bb)
		{
			return RollBlockTemplate.GetRootAsRollBlockTemplate(_bb, default(RollBlockTemplate));
		}

		// Token: 0x0600CBFB RID: 52219 RVA: 0x00301EFC File Offset: 0x003000FC
		public static RollBlockTemplate GetRootAsRollBlockTemplate(ByteBuffer _bb, RollBlockTemplate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CBFC RID: 52220 RVA: 0x00301F19 File Offset: 0x00300119
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CBFD RID: 52221 RVA: 0x00301F28 File Offset: 0x00300128
		public RollBlockTemplate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170033A8 RID: 13224
		// (get) Token: 0x0600CBFE RID: 52222 RVA: 0x00301F38 File Offset: 0x00300138
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

		// Token: 0x170033A9 RID: 13225
		// (get) Token: 0x0600CBFF RID: 52223 RVA: 0x00301F74 File Offset: 0x00300174
		public string Name
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

		// Token: 0x0600CC00 RID: 52224 RVA: 0x00301FAB File Offset: 0x003001AB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600CC01 RID: 52225 RVA: 0x00301FBA File Offset: 0x003001BA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170033AA RID: 13226
		// (get) Token: 0x0600CC02 RID: 52226 RVA: 0x00301FD4 File Offset: 0x003001D4
		public float Length
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 100f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170033AB RID: 13227
		// (get) Token: 0x0600CC03 RID: 52227 RVA: 0x00302014 File Offset: 0x00300214
		public float DelayTime
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170033AC RID: 13228
		// (get) Token: 0x0600CC04 RID: 52228 RVA: 0x00302058 File Offset: 0x00300258
		public float DeadDelayTime
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170033AD RID: 13229
		// (get) Token: 0x0600CC05 RID: 52229 RVA: 0x0030209C File Offset: 0x0030029C
		public string BlockTemplate
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CC06 RID: 52230 RVA: 0x003020D4 File Offset: 0x003002D4
		public Span<byte> GetBlockTemplateBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600CC07 RID: 52231 RVA: 0x003020E4 File Offset: 0x003002E4
		public byte[] GetBlockTemplateArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170033AE RID: 13230
		// (get) Token: 0x0600CC08 RID: 52232 RVA: 0x003020FC File Offset: 0x003002FC
		public string GridTemplates
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CC09 RID: 52233 RVA: 0x00302134 File Offset: 0x00300334
		public Span<byte> GetGridTemplatesBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600CC0A RID: 52234 RVA: 0x00302144 File Offset: 0x00300344
		public byte[] GetGridTemplatesArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170033AF RID: 13231
		// (get) Token: 0x0600CC0B RID: 52235 RVA: 0x0030215C File Offset: 0x0030035C
		public string ItemTemplates
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CC0C RID: 52236 RVA: 0x00302194 File Offset: 0x00300394
		public Span<byte> GetItemTemplatesBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600CC0D RID: 52237 RVA: 0x003021A4 File Offset: 0x003003A4
		public byte[] GetItemTemplatesArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170033B0 RID: 13232
		// (get) Token: 0x0600CC0E RID: 52238 RVA: 0x003021BC File Offset: 0x003003BC
		public string TreasureTemplate
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CC0F RID: 52239 RVA: 0x003021F4 File Offset: 0x003003F4
		public Span<byte> GetTreasureTemplateBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600CC10 RID: 52240 RVA: 0x00302204 File Offset: 0x00300404
		public byte[] GetTreasureTemplateArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x0400516F RID: 20847
		private Table __p;
	}
}
