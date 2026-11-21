using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C00 RID: 3072
	public struct BabelTowerDeTermMutex : IFlatbufferObject
	{
		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x0600509F RID: 20639 RVA: 0x001FD714 File Offset: 0x001FB914
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060050A0 RID: 20640 RVA: 0x001FD721 File Offset: 0x001FB921
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060050A1 RID: 20641 RVA: 0x001FD728 File Offset: 0x001FB928
		public static BabelTowerDeTermMutex GetRootAsBabelTowerDeTermMutex(ByteBuffer _bb)
		{
			return BabelTowerDeTermMutex.GetRootAsBabelTowerDeTermMutex(_bb, default(BabelTowerDeTermMutex));
		}

		// Token: 0x060050A2 RID: 20642 RVA: 0x001FD744 File Offset: 0x001FB944
		public static BabelTowerDeTermMutex GetRootAsBabelTowerDeTermMutex(ByteBuffer _bb, BabelTowerDeTermMutex obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060050A3 RID: 20643 RVA: 0x001FD761 File Offset: 0x001FB961
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060050A4 RID: 20644 RVA: 0x001FD770 File Offset: 0x001FB970
		public BabelTowerDeTermMutex __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x060050A5 RID: 20645 RVA: 0x001FD780 File Offset: 0x001FB980
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

		// Token: 0x060050A6 RID: 20646 RVA: 0x001FD7BC File Offset: 0x001FB9BC
		public int MutexDeTermGroup(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x060050A7 RID: 20647 RVA: 0x001FD7FC File Offset: 0x001FB9FC
		public int MutexDeTermGroupLength
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

		// Token: 0x060050A8 RID: 20648 RVA: 0x001FD827 File Offset: 0x001FBA27
		public Span<int> GetMutexDeTermGroupBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060050A9 RID: 20649 RVA: 0x001FD836 File Offset: 0x001FBA36
		public int[] GetMutexDeTermGroupArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x060050AA RID: 20650 RVA: 0x001FD84D File Offset: 0x001FBA4D
		[NullableContext(1)]
		public int[] MutexDeTermGroup()
		{
			return this.GetMutexDeTermGroupArray();
		}

		// Token: 0x060050AB RID: 20651 RVA: 0x001FD855 File Offset: 0x001FBA55
		[NullableContext(1)]
		public IEnumerable<int> MutexDeTermGroupIter()
		{
			BabelTowerDeTermMutex.<MutexDeTermGroupIter>d__16 <MutexDeTermGroupIter>d__ = new BabelTowerDeTermMutex.<MutexDeTermGroupIter>d__16(-2);
			<MutexDeTermGroupIter>d__.<>3__<>4__this = this;
			return <MutexDeTermGroupIter>d__;
		}

		// Token: 0x040050F1 RID: 20721
		private Table __p;
	}
}
