using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DBB RID: 3515
	public struct Furniture : IFlatbufferObject
	{
		// Token: 0x170014C3 RID: 5315
		// (get) Token: 0x06007D7E RID: 32126 RVA: 0x0026328C File Offset: 0x0026148C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007D7F RID: 32127 RVA: 0x00263299 File Offset: 0x00261499
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007D80 RID: 32128 RVA: 0x002632A0 File Offset: 0x002614A0
		public static Furniture GetRootAsFurniture(ByteBuffer _bb)
		{
			return Furniture.GetRootAsFurniture(_bb, default(Furniture));
		}

		// Token: 0x06007D81 RID: 32129 RVA: 0x002632BC File Offset: 0x002614BC
		public static Furniture GetRootAsFurniture(ByteBuffer _bb, Furniture obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007D82 RID: 32130 RVA: 0x002632D9 File Offset: 0x002614D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007D83 RID: 32131 RVA: 0x002632E8 File Offset: 0x002614E8
		public Furniture __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170014C4 RID: 5316
		// (get) Token: 0x06007D84 RID: 32132 RVA: 0x002632F8 File Offset: 0x002614F8
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

		// Token: 0x170014C5 RID: 5317
		// (get) Token: 0x06007D85 RID: 32133 RVA: 0x00263334 File Offset: 0x00261534
		public int ActivityId
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

		// Token: 0x170014C6 RID: 5318
		// (get) Token: 0x06007D86 RID: 32134 RVA: 0x00263370 File Offset: 0x00261570
		public int TagId
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

		// Token: 0x170014C7 RID: 5319
		// (get) Token: 0x06007D87 RID: 32135 RVA: 0x002633AC File Offset: 0x002615AC
		public int GetWayId
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

		// Token: 0x170014C8 RID: 5320
		// (get) Token: 0x06007D88 RID: 32136 RVA: 0x002633EC File Offset: 0x002615EC
		public int SourceType
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

		// Token: 0x170014C9 RID: 5321
		// (get) Token: 0x06007D89 RID: 32137 RVA: 0x0026342C File Offset: 0x0026162C
		public bool IsEntityGroup
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170014CA RID: 5322
		// (get) Token: 0x06007D8A RID: 32138 RVA: 0x0026346C File Offset: 0x0026166C
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170014CB RID: 5323
		// (get) Token: 0x06007D8B RID: 32139 RVA: 0x002634AC File Offset: 0x002616AC
		public int Atmosphere
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170014CC RID: 5324
		// (get) Token: 0x06007D8C RID: 32140 RVA: 0x002634EC File Offset: 0x002616EC
		public string Name
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

		// Token: 0x06007D8D RID: 32141 RVA: 0x00263524 File Offset: 0x00261724
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06007D8E RID: 32142 RVA: 0x00263534 File Offset: 0x00261734
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170014CD RID: 5325
		// (get) Token: 0x06007D8F RID: 32143 RVA: 0x0026354C File Offset: 0x0026174C
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007D90 RID: 32144 RVA: 0x00263584 File Offset: 0x00261784
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06007D91 RID: 32145 RVA: 0x00263594 File Offset: 0x00261794
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170014CE RID: 5326
		// (get) Token: 0x06007D92 RID: 32146 RVA: 0x002635AC File Offset: 0x002617AC
		public string IconMiddle
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007D93 RID: 32147 RVA: 0x002635E4 File Offset: 0x002617E4
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06007D94 RID: 32148 RVA: 0x002635F4 File Offset: 0x002617F4
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x170014CF RID: 5327
		// (get) Token: 0x06007D95 RID: 32149 RVA: 0x0026360C File Offset: 0x0026180C
		public string IconBig
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007D96 RID: 32150 RVA: 0x00263644 File Offset: 0x00261844
		public Span<byte> GetIconBigBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06007D97 RID: 32151 RVA: 0x00263654 File Offset: 0x00261854
		public byte[] GetIconBigArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x170014D0 RID: 5328
		// (get) Token: 0x06007D98 RID: 32152 RVA: 0x0026366C File Offset: 0x0026186C
		public string IconPath
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007D99 RID: 32153 RVA: 0x002636A4 File Offset: 0x002618A4
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06007D9A RID: 32154 RVA: 0x002636B4 File Offset: 0x002618B4
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x170014D1 RID: 5329
		// (get) Token: 0x06007D9B RID: 32155 RVA: 0x002636CC File Offset: 0x002618CC
		public string PrefabPath
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007D9C RID: 32156 RVA: 0x00263704 File Offset: 0x00261904
		public Span<byte> GetPrefabPathBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06007D9D RID: 32157 RVA: 0x00263714 File Offset: 0x00261914
		public byte[] GetPrefabPathArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x170014D2 RID: 5330
		// (get) Token: 0x06007D9E RID: 32158 RVA: 0x0026372C File Offset: 0x0026192C
		public int QualityId
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170014D3 RID: 5331
		// (get) Token: 0x06007D9F RID: 32159 RVA: 0x0026376C File Offset: 0x0026196C
		public int LimitCount
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170014D4 RID: 5332
		// (get) Token: 0x06007DA0 RID: 32160 RVA: 0x002637AC File Offset: 0x002619AC
		public string SourceDesciption
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007DA1 RID: 32161 RVA: 0x002637E4 File Offset: 0x002619E4
		public Span<byte> GetSourceDesciptionBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x06007DA2 RID: 32162 RVA: 0x002637F4 File Offset: 0x002619F4
		public byte[] GetSourceDesciptionArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x170014D5 RID: 5333
		// (get) Token: 0x06007DA3 RID: 32163 RVA: 0x0026380C File Offset: 0x00261A0C
		public string RoleIconPath
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007DA4 RID: 32164 RVA: 0x00263844 File Offset: 0x00261A44
		public Span<byte> GetRoleIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x06007DA5 RID: 32165 RVA: 0x00263854 File Offset: 0x00261A54
		public byte[] GetRoleIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x170014D6 RID: 5334
		// (get) Token: 0x06007DA6 RID: 32166 RVA: 0x0026386C File Offset: 0x00261A6C
		public string GiftDescription
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007DA7 RID: 32167 RVA: 0x002638A4 File Offset: 0x00261AA4
		public Span<byte> GetGiftDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x06007DA8 RID: 32168 RVA: 0x002638B4 File Offset: 0x00261AB4
		public byte[] GetGiftDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x170014D7 RID: 5335
		// (get) Token: 0x06007DA9 RID: 32169 RVA: 0x002638CC File Offset: 0x00261ACC
		public string Desciption
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007DAA RID: 32170 RVA: 0x00263904 File Offset: 0x00261B04
		public Span<byte> GetDesciptionBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x06007DAB RID: 32171 RVA: 0x00263914 File Offset: 0x00261B14
		public byte[] GetDesciptionArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x170014D8 RID: 5336
		// (get) Token: 0x06007DAC RID: 32172 RVA: 0x0026392C File Offset: 0x00261B2C
		public string AttributesDescription
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007DAD RID: 32173 RVA: 0x00263964 File Offset: 0x00261B64
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x06007DAE RID: 32174 RVA: 0x00263974 File Offset: 0x00261B74
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x0400532B RID: 21291
		private Table __p;
	}
}
