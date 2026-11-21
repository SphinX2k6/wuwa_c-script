using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F12 RID: 3858
	public struct Motion : IFlatbufferObject
	{
		// Token: 0x1700205E RID: 8286
		// (get) Token: 0x06009C9F RID: 40095 RVA: 0x002A852D File Offset: 0x002A672D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009CA0 RID: 40096 RVA: 0x002A853A File Offset: 0x002A673A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009CA1 RID: 40097 RVA: 0x002A8544 File Offset: 0x002A6744
		public static Motion GetRootAsMotion(ByteBuffer _bb)
		{
			return Motion.GetRootAsMotion(_bb, default(Motion));
		}

		// Token: 0x06009CA2 RID: 40098 RVA: 0x002A8560 File Offset: 0x002A6760
		public static Motion GetRootAsMotion(ByteBuffer _bb, Motion obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009CA3 RID: 40099 RVA: 0x002A857D File Offset: 0x002A677D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009CA4 RID: 40100 RVA: 0x002A858C File Offset: 0x002A678C
		public Motion __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700205F RID: 8287
		// (get) Token: 0x06009CA5 RID: 40101 RVA: 0x002A859C File Offset: 0x002A679C
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

		// Token: 0x17002060 RID: 8288
		// (get) Token: 0x06009CA6 RID: 40102 RVA: 0x002A85D8 File Offset: 0x002A67D8
		public int RoleId
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

		// Token: 0x17002061 RID: 8289
		// (get) Token: 0x06009CA7 RID: 40103 RVA: 0x002A8614 File Offset: 0x002A6814
		public int SkinId
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

		// Token: 0x17002062 RID: 8290
		// (get) Token: 0x06009CA8 RID: 40104 RVA: 0x002A8650 File Offset: 0x002A6850
		public int Type
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

		// Token: 0x17002063 RID: 8291
		// (get) Token: 0x06009CA9 RID: 40105 RVA: 0x002A8690 File Offset: 0x002A6890
		public int Sort
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

		// Token: 0x17002064 RID: 8292
		// (get) Token: 0x06009CAA RID: 40106 RVA: 0x002A86D0 File Offset: 0x002A68D0
		public string Title
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

		// Token: 0x06009CAB RID: 40107 RVA: 0x002A8708 File Offset: 0x002A6908
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06009CAC RID: 40108 RVA: 0x002A8718 File Offset: 0x002A6918
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002065 RID: 8293
		// (get) Token: 0x06009CAD RID: 40109 RVA: 0x002A8730 File Offset: 0x002A6930
		public string Content
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

		// Token: 0x06009CAE RID: 40110 RVA: 0x002A8768 File Offset: 0x002A6968
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06009CAF RID: 40111 RVA: 0x002A8778 File Offset: 0x002A6978
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002066 RID: 8294
		// (get) Token: 0x06009CB0 RID: 40112 RVA: 0x002A8790 File Offset: 0x002A6990
		public string MotionImg
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

		// Token: 0x06009CB1 RID: 40113 RVA: 0x002A87C8 File Offset: 0x002A69C8
		public Span<byte> GetMotionImgBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06009CB2 RID: 40114 RVA: 0x002A87D8 File Offset: 0x002A69D8
		public byte[] GetMotionImgArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002067 RID: 8295
		// (get) Token: 0x06009CB3 RID: 40115 RVA: 0x002A87F0 File Offset: 0x002A69F0
		public string AniBlueprint
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

		// Token: 0x06009CB4 RID: 40116 RVA: 0x002A8828 File Offset: 0x002A6A28
		public Span<byte> GetAniBlueprintBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06009CB5 RID: 40117 RVA: 0x002A8838 File Offset: 0x002A6A38
		public byte[] GetAniBlueprintArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002068 RID: 8296
		// (get) Token: 0x06009CB6 RID: 40118 RVA: 0x002A8850 File Offset: 0x002A6A50
		public string AniMontage
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

		// Token: 0x06009CB7 RID: 40119 RVA: 0x002A8888 File Offset: 0x002A6A88
		public Span<byte> GetAniMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06009CB8 RID: 40120 RVA: 0x002A8898 File Offset: 0x002A6A98
		public byte[] GetAniMontageArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002069 RID: 8297
		// (get) Token: 0x06009CB9 RID: 40121 RVA: 0x002A88B0 File Offset: 0x002A6AB0
		public int CondGroupId
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700206A RID: 8298
		// (get) Token: 0x06009CBA RID: 40122 RVA: 0x002A88F0 File Offset: 0x002A6AF0
		public int Morph
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040054B7 RID: 21687
		private Table __p;
	}
}
