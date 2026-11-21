using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DB4 RID: 3508
	public struct FuncMenuReplace : IFlatbufferObject
	{
		// Token: 0x1700148F RID: 5263
		// (get) Token: 0x06007CF3 RID: 31987 RVA: 0x002620FD File Offset: 0x002602FD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007CF4 RID: 31988 RVA: 0x0026210A File Offset: 0x0026030A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007CF5 RID: 31989 RVA: 0x00262114 File Offset: 0x00260314
		public static FuncMenuReplace GetRootAsFuncMenuReplace(ByteBuffer _bb)
		{
			return FuncMenuReplace.GetRootAsFuncMenuReplace(_bb, default(FuncMenuReplace));
		}

		// Token: 0x06007CF6 RID: 31990 RVA: 0x00262130 File Offset: 0x00260330
		public static FuncMenuReplace GetRootAsFuncMenuReplace(ByteBuffer _bb, FuncMenuReplace obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007CF7 RID: 31991 RVA: 0x0026214D File Offset: 0x0026034D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007CF8 RID: 31992 RVA: 0x0026215C File Offset: 0x0026035C
		public FuncMenuReplace __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001490 RID: 5264
		// (get) Token: 0x06007CF9 RID: 31993 RVA: 0x0026216C File Offset: 0x0026036C
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

		// Token: 0x17001491 RID: 5265
		// (get) Token: 0x06007CFA RID: 31994 RVA: 0x002621A8 File Offset: 0x002603A8
		public int InstSubType
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

		// Token: 0x06007CFB RID: 31995 RVA: 0x002621E4 File Offset: 0x002603E4
		public int InstIdList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001492 RID: 5266
		// (get) Token: 0x06007CFC RID: 31996 RVA: 0x00262224 File Offset: 0x00260424
		public int InstIdListLength
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

		// Token: 0x06007CFD RID: 31997 RVA: 0x0026224F File Offset: 0x0026044F
		public Span<int> GetInstIdListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06007CFE RID: 31998 RVA: 0x0026225E File Offset: 0x0026045E
		public int[] GetInstIdListArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x06007CFF RID: 31999 RVA: 0x00262278 File Offset: 0x00260478
		public int FuncMenuIdList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001493 RID: 5267
		// (get) Token: 0x06007D00 RID: 32000 RVA: 0x002622B8 File Offset: 0x002604B8
		public int FuncMenuIdListLength
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

		// Token: 0x06007D01 RID: 32001 RVA: 0x002622E4 File Offset: 0x002604E4
		public Span<int> GetFuncMenuIdListBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06007D02 RID: 32002 RVA: 0x002622F4 File Offset: 0x002604F4
		public int[] GetFuncMenuIdListArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x06007D03 RID: 32003 RVA: 0x0026230C File Offset: 0x0026050C
		[NullableContext(1)]
		public int[] FuncMenuIdList()
		{
			return this.GetFuncMenuIdListArray();
		}

		// Token: 0x06007D04 RID: 32004 RVA: 0x00262314 File Offset: 0x00260514
		[NullableContext(1)]
		public IEnumerable<int> FuncMenuIdListIter()
		{
			FuncMenuReplace.<FuncMenuIdListIter>d__23 <FuncMenuIdListIter>d__ = new FuncMenuReplace.<FuncMenuIdListIter>d__23(-2);
			<FuncMenuIdListIter>d__.<>3__<>4__this = this;
			return <FuncMenuIdListIter>d__;
		}

		// Token: 0x06007D05 RID: 32005 RVA: 0x00262329 File Offset: 0x00260529
		[NullableContext(1)]
		public int[] InstIdList()
		{
			return this.GetInstIdListArray();
		}

		// Token: 0x06007D06 RID: 32006 RVA: 0x00262331 File Offset: 0x00260531
		[NullableContext(1)]
		public IEnumerable<int> InstIdListIter()
		{
			FuncMenuReplace.<InstIdListIter>d__25 <InstIdListIter>d__ = new FuncMenuReplace.<InstIdListIter>d__25(-2);
			<InstIdListIter>d__.<>3__<>4__this = this;
			return <InstIdListIter>d__;
		}

		// Token: 0x04005324 RID: 21284
		private Table __p;
	}
}
