using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DCA RID: 3530
	public struct GachaViewTypeInfo : IFlatbufferObject
	{
		// Token: 0x17001538 RID: 5432
		// (get) Token: 0x06007EB6 RID: 32438 RVA: 0x00265BB4 File Offset: 0x00263DB4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007EB7 RID: 32439 RVA: 0x00265BC1 File Offset: 0x00263DC1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007EB8 RID: 32440 RVA: 0x00265BC8 File Offset: 0x00263DC8
		public static GachaViewTypeInfo GetRootAsGachaViewTypeInfo(ByteBuffer _bb)
		{
			return GachaViewTypeInfo.GetRootAsGachaViewTypeInfo(_bb, default(GachaViewTypeInfo));
		}

		// Token: 0x06007EB9 RID: 32441 RVA: 0x00265BE4 File Offset: 0x00263DE4
		public static GachaViewTypeInfo GetRootAsGachaViewTypeInfo(ByteBuffer _bb, GachaViewTypeInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007EBA RID: 32442 RVA: 0x00265C01 File Offset: 0x00263E01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007EBB RID: 32443 RVA: 0x00265C10 File Offset: 0x00263E10
		public GachaViewTypeInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001539 RID: 5433
		// (get) Token: 0x06007EBC RID: 32444 RVA: 0x00265C20 File Offset: 0x00263E20
		public int Type
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

		// Token: 0x1700153A RID: 5434
		// (get) Token: 0x06007EBD RID: 32445 RVA: 0x00265C5C File Offset: 0x00263E5C
		public string TagText
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

		// Token: 0x06007EBE RID: 32446 RVA: 0x00265C93 File Offset: 0x00263E93
		public Span<byte> GetTagTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007EBF RID: 32447 RVA: 0x00265CA2 File Offset: 0x00263EA2
		public byte[] GetTagTextArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700153B RID: 5435
		// (get) Token: 0x06007EC0 RID: 32448 RVA: 0x00265CBC File Offset: 0x00263EBC
		public string TagColor
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

		// Token: 0x06007EC1 RID: 32449 RVA: 0x00265CF3 File Offset: 0x00263EF3
		public Span<byte> GetTagColorBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007EC2 RID: 32450 RVA: 0x00265D02 File Offset: 0x00263F02
		public byte[] GetTagColorArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700153C RID: 5436
		// (get) Token: 0x06007EC3 RID: 32451 RVA: 0x00265D1C File Offset: 0x00263F1C
		public string TypeText
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

		// Token: 0x06007EC4 RID: 32452 RVA: 0x00265D54 File Offset: 0x00263F54
		public Span<byte> GetTypeTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007EC5 RID: 32453 RVA: 0x00265D64 File Offset: 0x00263F64
		public byte[] GetTypeTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700153D RID: 5437
		// (get) Token: 0x06007EC6 RID: 32454 RVA: 0x00265D7C File Offset: 0x00263F7C
		public string OptionalTitle
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

		// Token: 0x06007EC7 RID: 32455 RVA: 0x00265DB4 File Offset: 0x00263FB4
		public Span<byte> GetOptionalTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007EC8 RID: 32456 RVA: 0x00265DC4 File Offset: 0x00263FC4
		public byte[] GetOptionalTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700153E RID: 5438
		// (get) Token: 0x06007EC9 RID: 32457 RVA: 0x00265DDC File Offset: 0x00263FDC
		public string OptionalDesc
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

		// Token: 0x06007ECA RID: 32458 RVA: 0x00265E14 File Offset: 0x00264014
		public Span<byte> GetOptionalDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06007ECB RID: 32459 RVA: 0x00265E24 File Offset: 0x00264024
		public byte[] GetOptionalDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700153F RID: 5439
		// (get) Token: 0x06007ECC RID: 32460 RVA: 0x00265E3C File Offset: 0x0026403C
		public string GachaButtonTip
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

		// Token: 0x06007ECD RID: 32461 RVA: 0x00265E74 File Offset: 0x00264074
		public Span<byte> GetGachaButtonTipBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06007ECE RID: 32462 RVA: 0x00265E84 File Offset: 0x00264084
		public byte[] GetGachaButtonTipArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001540 RID: 5440
		// (get) Token: 0x06007ECF RID: 32463 RVA: 0x00265E9C File Offset: 0x0026409C
		public string GachaLimitTip
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

		// Token: 0x06007ED0 RID: 32464 RVA: 0x00265ED4 File Offset: 0x002640D4
		public Span<byte> GetGachaLimitTipBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06007ED1 RID: 32465 RVA: 0x00265EE4 File Offset: 0x002640E4
		public byte[] GetGachaLimitTipArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17001541 RID: 5441
		// (get) Token: 0x06007ED2 RID: 32466 RVA: 0x00265EFC File Offset: 0x002640FC
		public bool WeaponUseGachaAnim
		{
			get
			{
				int num = this.__p.__offset(20);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0400533B RID: 21307
		private Table __p;
	}
}
