using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DC8 RID: 3528
	public struct GachaTextureInfo : IFlatbufferObject
	{
		// Token: 0x1700151A RID: 5402
		// (get) Token: 0x06007E5C RID: 32348 RVA: 0x00265025 File Offset: 0x00263225
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007E5D RID: 32349 RVA: 0x00265032 File Offset: 0x00263232
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007E5E RID: 32350 RVA: 0x0026503C File Offset: 0x0026323C
		public static GachaTextureInfo GetRootAsGachaTextureInfo(ByteBuffer _bb)
		{
			return GachaTextureInfo.GetRootAsGachaTextureInfo(_bb, default(GachaTextureInfo));
		}

		// Token: 0x06007E5F RID: 32351 RVA: 0x00265058 File Offset: 0x00263258
		public static GachaTextureInfo GetRootAsGachaTextureInfo(ByteBuffer _bb, GachaTextureInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007E60 RID: 32352 RVA: 0x00265075 File Offset: 0x00263275
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007E61 RID: 32353 RVA: 0x00265084 File Offset: 0x00263284
		public GachaTextureInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700151B RID: 5403
		// (get) Token: 0x06007E62 RID: 32354 RVA: 0x00265094 File Offset: 0x00263294
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

		// Token: 0x1700151C RID: 5404
		// (get) Token: 0x06007E63 RID: 32355 RVA: 0x002650D0 File Offset: 0x002632D0
		public string GachaMainViewTexture
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

		// Token: 0x06007E64 RID: 32356 RVA: 0x00265107 File Offset: 0x00263307
		public Span<byte> GetGachaMainViewTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007E65 RID: 32357 RVA: 0x00265116 File Offset: 0x00263316
		public byte[] GetGachaMainViewTextureArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700151D RID: 5405
		// (get) Token: 0x06007E66 RID: 32358 RVA: 0x00265130 File Offset: 0x00263330
		public string GachaResultViewTexture
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

		// Token: 0x06007E67 RID: 32359 RVA: 0x00265167 File Offset: 0x00263367
		public Span<byte> GetGachaResultViewTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007E68 RID: 32360 RVA: 0x00265176 File Offset: 0x00263376
		public byte[] GetGachaResultViewTextureArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700151E RID: 5406
		// (get) Token: 0x06007E69 RID: 32361 RVA: 0x00265190 File Offset: 0x00263390
		public int ShowSequence
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

		// Token: 0x1700151F RID: 5407
		// (get) Token: 0x06007E6A RID: 32362 RVA: 0x002651D0 File Offset: 0x002633D0
		public string BindPoint
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

		// Token: 0x06007E6B RID: 32363 RVA: 0x00265208 File Offset: 0x00263408
		public Span<byte> GetBindPointBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007E6C RID: 32364 RVA: 0x00265218 File Offset: 0x00263418
		public byte[] GetBindPointArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x06007E6D RID: 32365 RVA: 0x00265230 File Offset: 0x00263430
		public int IdArray(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001520 RID: 5408
		// (get) Token: 0x06007E6E RID: 32366 RVA: 0x00265270 File Offset: 0x00263470
		public int IdArrayLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007E6F RID: 32367 RVA: 0x0026529C File Offset: 0x0026349C
		public Span<int> GetIdArrayBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x06007E70 RID: 32368 RVA: 0x002652AC File Offset: 0x002634AC
		public int[] GetIdArrayArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17001521 RID: 5409
		// (get) Token: 0x06007E71 RID: 32369 RVA: 0x002652C4 File Offset: 0x002634C4
		public int TrialId
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

		// Token: 0x06007E72 RID: 32370 RVA: 0x00265301 File Offset: 0x00263501
		[NullableContext(1)]
		public int[] IdArray()
		{
			return this.GetIdArrayArray();
		}

		// Token: 0x06007E73 RID: 32371 RVA: 0x00265309 File Offset: 0x00263509
		[NullableContext(1)]
		public IEnumerable<int> IdArrayIter()
		{
			GachaTextureInfo.<IdArrayIter>d__32 <IdArrayIter>d__ = new GachaTextureInfo.<IdArrayIter>d__32(-2);
			<IdArrayIter>d__.<>3__<>4__this = this;
			return <IdArrayIter>d__;
		}

		// Token: 0x04005339 RID: 21305
		private Table __p;
	}
}
