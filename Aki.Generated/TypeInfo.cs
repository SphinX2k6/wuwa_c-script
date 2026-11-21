using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012B6 RID: 4790
	public struct TypeInfo : IFlatbufferObject
	{
		// Token: 0x17004076 RID: 16502
		// (get) Token: 0x0600F34A RID: 62282 RVA: 0x00368A21 File Offset: 0x00366C21
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F34B RID: 62283 RVA: 0x00368A2E File Offset: 0x00366C2E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F34C RID: 62284 RVA: 0x00368A38 File Offset: 0x00366C38
		public static TypeInfo GetRootAsTypeInfo(ByteBuffer _bb)
		{
			return TypeInfo.GetRootAsTypeInfo(_bb, default(TypeInfo));
		}

		// Token: 0x0600F34D RID: 62285 RVA: 0x00368A54 File Offset: 0x00366C54
		public static TypeInfo GetRootAsTypeInfo(ByteBuffer _bb, TypeInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F34E RID: 62286 RVA: 0x00368A71 File Offset: 0x00366C71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F34F RID: 62287 RVA: 0x00368A80 File Offset: 0x00366C80
		public TypeInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17004077 RID: 16503
		// (get) Token: 0x0600F350 RID: 62288 RVA: 0x00368A90 File Offset: 0x00366C90
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

		// Token: 0x17004078 RID: 16504
		// (get) Token: 0x0600F351 RID: 62289 RVA: 0x00368ACC File Offset: 0x00366CCC
		public string TypeDescription
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

		// Token: 0x0600F352 RID: 62290 RVA: 0x00368B03 File Offset: 0x00366D03
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600F353 RID: 62291 RVA: 0x00368B12 File Offset: 0x00366D12
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17004079 RID: 16505
		// (get) Token: 0x0600F354 RID: 62292 RVA: 0x00368B2C File Offset: 0x00366D2C
		public bool Lock
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700407A RID: 16506
		// (get) Token: 0x0600F355 RID: 62293 RVA: 0x00368B6C File Offset: 0x00366D6C
		public bool Deprecate
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700407B RID: 16507
		// (get) Token: 0x0600F356 RID: 62294 RVA: 0x00368BAC File Offset: 0x00366DAC
		public bool ShowStock
		{
			get
			{
				int num = this.__p.__offset(12);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700407C RID: 16508
		// (get) Token: 0x0600F357 RID: 62295 RVA: 0x00368BEC File Offset: 0x00366DEC
		public int SortIndex
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700407D RID: 16509
		// (get) Token: 0x0600F358 RID: 62296 RVA: 0x00368C2C File Offset: 0x00366E2C
		public int ItemInfoDisplayType
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

		// Token: 0x0400590A RID: 22794
		private Table __p;
	}
}
