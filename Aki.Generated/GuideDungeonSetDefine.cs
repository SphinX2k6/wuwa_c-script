using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DFB RID: 3579
	public struct GuideDungeonSetDefine : IFlatbufferObject
	{
		// Token: 0x170016AD RID: 5805
		// (get) Token: 0x0600828B RID: 33419 RVA: 0x0026E2AA File Offset: 0x0026C4AA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600828C RID: 33420 RVA: 0x0026E2B7 File Offset: 0x0026C4B7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600828D RID: 33421 RVA: 0x0026E2C0 File Offset: 0x0026C4C0
		public static GuideDungeonSetDefine GetRootAsGuideDungeonSetDefine(ByteBuffer _bb)
		{
			return GuideDungeonSetDefine.GetRootAsGuideDungeonSetDefine(_bb, default(GuideDungeonSetDefine));
		}

		// Token: 0x0600828E RID: 33422 RVA: 0x0026E2DC File Offset: 0x0026C4DC
		public static GuideDungeonSetDefine GetRootAsGuideDungeonSetDefine(ByteBuffer _bb, GuideDungeonSetDefine obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600828F RID: 33423 RVA: 0x0026E2F9 File Offset: 0x0026C4F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008290 RID: 33424 RVA: 0x0026E308 File Offset: 0x0026C508
		public GuideDungeonSetDefine __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170016AE RID: 5806
		// (get) Token: 0x06008291 RID: 33425 RVA: 0x0026E318 File Offset: 0x0026C518
		public string StrId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008292 RID: 33426 RVA: 0x0026E34F File Offset: 0x0026C54F
		public Span<byte> GetStrIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06008293 RID: 33427 RVA: 0x0026E35E File Offset: 0x0026C55E
		public byte[] GetStrIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x06008294 RID: 33428 RVA: 0x0026E378 File Offset: 0x0026C578
		public int DungeonIdList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170016AF RID: 5807
		// (get) Token: 0x06008295 RID: 33429 RVA: 0x0026E3B8 File Offset: 0x0026C5B8
		public int DungeonIdListLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008296 RID: 33430 RVA: 0x0026E3E3 File Offset: 0x0026C5E3
		public Span<int> GetDungeonIdListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06008297 RID: 33431 RVA: 0x0026E3F2 File Offset: 0x0026C5F2
		public int[] GetDungeonIdListArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06008298 RID: 33432 RVA: 0x0026E40C File Offset: 0x0026C60C
		public int DungeonTypeSetList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170016B0 RID: 5808
		// (get) Token: 0x06008299 RID: 33433 RVA: 0x0026E44C File Offset: 0x0026C64C
		public int DungeonTypeSetListLength
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

		// Token: 0x0600829A RID: 33434 RVA: 0x0026E477 File Offset: 0x0026C677
		public Span<int> GetDungeonTypeSetListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600829B RID: 33435 RVA: 0x0026E486 File Offset: 0x0026C686
		public int[] GetDungeonTypeSetListArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600829C RID: 33436 RVA: 0x0026E4A0 File Offset: 0x0026C6A0
		public int ExcludeIdList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170016B1 RID: 5809
		// (get) Token: 0x0600829D RID: 33437 RVA: 0x0026E4E0 File Offset: 0x0026C6E0
		public int ExcludeIdListLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600829E RID: 33438 RVA: 0x0026E50C File Offset: 0x0026C70C
		public Span<int> GetExcludeIdListBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600829F RID: 33439 RVA: 0x0026E51C File Offset: 0x0026C71C
		public int[] GetExcludeIdListArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x060082A0 RID: 33440 RVA: 0x0026E534 File Offset: 0x0026C734
		[NullableContext(1)]
		public int[] DungeonIdList()
		{
			return this.GetDungeonIdListArray();
		}

		// Token: 0x060082A1 RID: 33441 RVA: 0x0026E53C File Offset: 0x0026C73C
		[NullableContext(1)]
		public IEnumerable<int> DungeonIdListIter()
		{
			GuideDungeonSetDefine.<DungeonIdListIter>d__28 <DungeonIdListIter>d__ = new GuideDungeonSetDefine.<DungeonIdListIter>d__28(-2);
			<DungeonIdListIter>d__.<>3__<>4__this = this;
			return <DungeonIdListIter>d__;
		}

		// Token: 0x060082A2 RID: 33442 RVA: 0x0026E551 File Offset: 0x0026C751
		[NullableContext(1)]
		public int[] DungeonTypeSetList()
		{
			return this.GetDungeonTypeSetListArray();
		}

		// Token: 0x060082A3 RID: 33443 RVA: 0x0026E559 File Offset: 0x0026C759
		[NullableContext(1)]
		public IEnumerable<int> DungeonTypeSetListIter()
		{
			GuideDungeonSetDefine.<DungeonTypeSetListIter>d__30 <DungeonTypeSetListIter>d__ = new GuideDungeonSetDefine.<DungeonTypeSetListIter>d__30(-2);
			<DungeonTypeSetListIter>d__.<>3__<>4__this = this;
			return <DungeonTypeSetListIter>d__;
		}

		// Token: 0x060082A4 RID: 33444 RVA: 0x0026E56E File Offset: 0x0026C76E
		[NullableContext(1)]
		public int[] ExcludeIdList()
		{
			return this.GetExcludeIdListArray();
		}

		// Token: 0x060082A5 RID: 33445 RVA: 0x0026E576 File Offset: 0x0026C776
		[NullableContext(1)]
		public IEnumerable<int> ExcludeIdListIter()
		{
			GuideDungeonSetDefine.<ExcludeIdListIter>d__32 <ExcludeIdListIter>d__ = new GuideDungeonSetDefine.<ExcludeIdListIter>d__32(-2);
			<ExcludeIdListIter>d__.<>3__<>4__this = this;
			return <ExcludeIdListIter>d__;
		}

		// Token: 0x04005373 RID: 21363
		private Table __p;
	}
}
