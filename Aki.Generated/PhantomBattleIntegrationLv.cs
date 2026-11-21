using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FB9 RID: 4025
	public struct PhantomBattleIntegrationLv : IFlatbufferObject
	{
		// Token: 0x170026BA RID: 9914
		// (get) Token: 0x0600AD7F RID: 44415 RVA: 0x002CD818 File Offset: 0x002CBA18
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AD80 RID: 44416 RVA: 0x002CD825 File Offset: 0x002CBA25
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AD81 RID: 44417 RVA: 0x002CD82C File Offset: 0x002CBA2C
		public static PhantomBattleIntegrationLv GetRootAsPhantomBattleIntegrationLv(ByteBuffer _bb)
		{
			return PhantomBattleIntegrationLv.GetRootAsPhantomBattleIntegrationLv(_bb, default(PhantomBattleIntegrationLv));
		}

		// Token: 0x0600AD82 RID: 44418 RVA: 0x002CD848 File Offset: 0x002CBA48
		public static PhantomBattleIntegrationLv GetRootAsPhantomBattleIntegrationLv(ByteBuffer _bb, PhantomBattleIntegrationLv obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AD83 RID: 44419 RVA: 0x002CD865 File Offset: 0x002CBA65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AD84 RID: 44420 RVA: 0x002CD874 File Offset: 0x002CBA74
		public PhantomBattleIntegrationLv __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170026BB RID: 9915
		// (get) Token: 0x0600AD85 RID: 44421 RVA: 0x002CD884 File Offset: 0x002CBA84
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

		// Token: 0x0600AD86 RID: 44422 RVA: 0x002CD8C0 File Offset: 0x002CBAC0
		public int Range(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170026BC RID: 9916
		// (get) Token: 0x0600AD87 RID: 44423 RVA: 0x002CD900 File Offset: 0x002CBB00
		public int RangeLength
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

		// Token: 0x0600AD88 RID: 44424 RVA: 0x002CD92B File Offset: 0x002CBB2B
		public Span<int> GetRangeBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600AD89 RID: 44425 RVA: 0x002CD93A File Offset: 0x002CBB3A
		public int[] GetRangeArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x170026BD RID: 9917
		// (get) Token: 0x0600AD8A RID: 44426 RVA: 0x002CD954 File Offset: 0x002CBB54
		public string Title
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

		// Token: 0x0600AD8B RID: 44427 RVA: 0x002CD98B File Offset: 0x002CBB8B
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600AD8C RID: 44428 RVA: 0x002CD99A File Offset: 0x002CBB9A
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170026BE RID: 9918
		// (get) Token: 0x0600AD8D RID: 44429 RVA: 0x002CD9B4 File Offset: 0x002CBBB4
		public int Win
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

		// Token: 0x170026BF RID: 9919
		// (get) Token: 0x0600AD8E RID: 44430 RVA: 0x002CD9F4 File Offset: 0x002CBBF4
		public int Fail
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

		// Token: 0x170026C0 RID: 9920
		// (get) Token: 0x0600AD8F RID: 44431 RVA: 0x002CDA34 File Offset: 0x002CBC34
		public int WinSecond
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

		// Token: 0x170026C1 RID: 9921
		// (get) Token: 0x0600AD90 RID: 44432 RVA: 0x002CDA74 File Offset: 0x002CBC74
		public int FailSecond
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

		// Token: 0x0600AD91 RID: 44433 RVA: 0x002CDAB1 File Offset: 0x002CBCB1
		[NullableContext(1)]
		public int[] Range()
		{
			return this.GetRangeArray();
		}

		// Token: 0x0600AD92 RID: 44434 RVA: 0x002CDAB9 File Offset: 0x002CBCB9
		[NullableContext(1)]
		public IEnumerable<int> RangeIter()
		{
			PhantomBattleIntegrationLv.<RangeIter>d__28 <RangeIter>d__ = new PhantomBattleIntegrationLv.<RangeIter>d__28(-2);
			<RangeIter>d__.<>3__<>4__this = this;
			return <RangeIter>d__;
		}

		// Token: 0x04005577 RID: 21879
		private Table __p;
	}
}
