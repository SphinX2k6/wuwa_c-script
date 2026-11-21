using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001165 RID: 4453
	public struct RollBlockTemplate : IFlatbufferObject
	{
		// Token: 0x170034B4 RID: 13492
		// (get) Token: 0x0600D3CB RID: 54219 RVA: 0x00321762 File Offset: 0x0031F962
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D3CC RID: 54220 RVA: 0x0032176F File Offset: 0x0031F96F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D3CD RID: 54221 RVA: 0x00321778 File Offset: 0x0031F978
		public static RollBlockTemplate GetRootAsRollBlockTemplate(ByteBuffer _bb)
		{
			return RollBlockTemplate.GetRootAsRollBlockTemplate(_bb, default(RollBlockTemplate));
		}

		// Token: 0x0600D3CE RID: 54222 RVA: 0x00321794 File Offset: 0x0031F994
		public static RollBlockTemplate GetRootAsRollBlockTemplate(ByteBuffer _bb, RollBlockTemplate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D3CF RID: 54223 RVA: 0x003217B1 File Offset: 0x0031F9B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D3D0 RID: 54224 RVA: 0x003217C0 File Offset: 0x0031F9C0
		public RollBlockTemplate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170034B5 RID: 13493
		// (get) Token: 0x0600D3D1 RID: 54225 RVA: 0x003217D0 File Offset: 0x0031F9D0
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

		// Token: 0x170034B6 RID: 13494
		// (get) Token: 0x0600D3D2 RID: 54226 RVA: 0x0032180C File Offset: 0x0031FA0C
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

		// Token: 0x0600D3D3 RID: 54227 RVA: 0x00321843 File Offset: 0x0031FA43
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D3D4 RID: 54228 RVA: 0x00321852 File Offset: 0x0031FA52
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170034B7 RID: 13495
		// (get) Token: 0x0600D3D5 RID: 54229 RVA: 0x0032186C File Offset: 0x0031FA6C
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

		// Token: 0x170034B8 RID: 13496
		// (get) Token: 0x0600D3D6 RID: 54230 RVA: 0x003218AC File Offset: 0x0031FAAC
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

		// Token: 0x170034B9 RID: 13497
		// (get) Token: 0x0600D3D7 RID: 54231 RVA: 0x003218F0 File Offset: 0x0031FAF0
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

		// Token: 0x170034BA RID: 13498
		// (get) Token: 0x0600D3D8 RID: 54232 RVA: 0x00321934 File Offset: 0x0031FB34
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

		// Token: 0x0600D3D9 RID: 54233 RVA: 0x0032196C File Offset: 0x0031FB6C
		public Span<byte> GetBlockTemplateBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600D3DA RID: 54234 RVA: 0x0032197C File Offset: 0x0031FB7C
		public byte[] GetBlockTemplateArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170034BB RID: 13499
		// (get) Token: 0x0600D3DB RID: 54235 RVA: 0x00321994 File Offset: 0x0031FB94
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

		// Token: 0x0600D3DC RID: 54236 RVA: 0x003219CC File Offset: 0x0031FBCC
		public Span<byte> GetGridTemplatesBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600D3DD RID: 54237 RVA: 0x003219DC File Offset: 0x0031FBDC
		public byte[] GetGridTemplatesArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170034BC RID: 13500
		// (get) Token: 0x0600D3DE RID: 54238 RVA: 0x003219F4 File Offset: 0x0031FBF4
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

		// Token: 0x0600D3DF RID: 54239 RVA: 0x00321A2C File Offset: 0x0031FC2C
		public Span<byte> GetItemTemplatesBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600D3E0 RID: 54240 RVA: 0x00321A3C File Offset: 0x0031FC3C
		public byte[] GetItemTemplatesArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170034BD RID: 13501
		// (get) Token: 0x0600D3E1 RID: 54241 RVA: 0x00321A54 File Offset: 0x0031FC54
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

		// Token: 0x0600D3E2 RID: 54242 RVA: 0x00321A8C File Offset: 0x0031FC8C
		public Span<byte> GetTreasureTemplateBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600D3E3 RID: 54243 RVA: 0x00321A9C File Offset: 0x0031FC9C
		public byte[] GetTreasureTemplateArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x0400576E RID: 22382
		private Table __p;
	}
}
