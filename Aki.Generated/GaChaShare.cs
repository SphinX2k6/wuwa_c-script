using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DC7 RID: 3527
	public struct GaChaShare : IFlatbufferObject
	{
		// Token: 0x17001514 RID: 5396
		// (get) Token: 0x06007E48 RID: 32328 RVA: 0x00264DCD File Offset: 0x00262FCD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007E49 RID: 32329 RVA: 0x00264DDA File Offset: 0x00262FDA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007E4A RID: 32330 RVA: 0x00264DE4 File Offset: 0x00262FE4
		public static GaChaShare GetRootAsGaChaShare(ByteBuffer _bb)
		{
			return GaChaShare.GetRootAsGaChaShare(_bb, default(GaChaShare));
		}

		// Token: 0x06007E4B RID: 32331 RVA: 0x00264E00 File Offset: 0x00263000
		public static GaChaShare GetRootAsGaChaShare(ByteBuffer _bb, GaChaShare obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007E4C RID: 32332 RVA: 0x00264E1D File Offset: 0x0026301D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007E4D RID: 32333 RVA: 0x00264E2C File Offset: 0x0026302C
		public GaChaShare __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001515 RID: 5397
		// (get) Token: 0x06007E4E RID: 32334 RVA: 0x00264E3C File Offset: 0x0026303C
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

		// Token: 0x17001516 RID: 5398
		// (get) Token: 0x06007E4F RID: 32335 RVA: 0x00264E78 File Offset: 0x00263078
		public int Type
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

		// Token: 0x06007E50 RID: 32336 RVA: 0x00264EB4 File Offset: 0x002630B4
		public int ShareTypes(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001517 RID: 5399
		// (get) Token: 0x06007E51 RID: 32337 RVA: 0x00264EF4 File Offset: 0x002630F4
		public int ShareTypesLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007E52 RID: 32338 RVA: 0x00264F1F File Offset: 0x0026311F
		public Span<int> GetShareTypesBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06007E53 RID: 32339 RVA: 0x00264F2E File Offset: 0x0026312E
		public int[] GetShareTypesArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17001518 RID: 5400
		// (get) Token: 0x06007E54 RID: 32340 RVA: 0x00264F48 File Offset: 0x00263148
		public string Desc
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

		// Token: 0x06007E55 RID: 32341 RVA: 0x00264F80 File Offset: 0x00263180
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007E56 RID: 32342 RVA: 0x00264F90 File Offset: 0x00263190
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001519 RID: 5401
		// (get) Token: 0x06007E57 RID: 32343 RVA: 0x00264FA8 File Offset: 0x002631A8
		public string SharePic
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

		// Token: 0x06007E58 RID: 32344 RVA: 0x00264FE0 File Offset: 0x002631E0
		public Span<byte> GetSharePicBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007E59 RID: 32345 RVA: 0x00264FF0 File Offset: 0x002631F0
		public byte[] GetSharePicArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x06007E5A RID: 32346 RVA: 0x00265008 File Offset: 0x00263208
		[NullableContext(1)]
		public int[] ShareTypes()
		{
			return this.GetShareTypesArray();
		}

		// Token: 0x06007E5B RID: 32347 RVA: 0x00265010 File Offset: 0x00263210
		[NullableContext(1)]
		public IEnumerable<int> ShareTypesIter()
		{
			GaChaShare.<ShareTypesIter>d__26 <ShareTypesIter>d__ = new GaChaShare.<ShareTypesIter>d__26(-2);
			<ShareTypesIter>d__.<>3__<>4__this = this;
			return <ShareTypesIter>d__;
		}

		// Token: 0x04005338 RID: 21304
		private Table __p;
	}
}
