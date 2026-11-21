using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FA8 RID: 4008
	public struct PhantomBattleCardFilter : IFlatbufferObject
	{
		// Token: 0x17002615 RID: 9749
		// (get) Token: 0x0600ABC6 RID: 43974 RVA: 0x002C9B5C File Offset: 0x002C7D5C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600ABC7 RID: 43975 RVA: 0x002C9B69 File Offset: 0x002C7D69
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600ABC8 RID: 43976 RVA: 0x002C9B70 File Offset: 0x002C7D70
		public static PhantomBattleCardFilter GetRootAsPhantomBattleCardFilter(ByteBuffer _bb)
		{
			return PhantomBattleCardFilter.GetRootAsPhantomBattleCardFilter(_bb, default(PhantomBattleCardFilter));
		}

		// Token: 0x0600ABC9 RID: 43977 RVA: 0x002C9B8C File Offset: 0x002C7D8C
		public static PhantomBattleCardFilter GetRootAsPhantomBattleCardFilter(ByteBuffer _bb, PhantomBattleCardFilter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600ABCA RID: 43978 RVA: 0x002C9BA9 File Offset: 0x002C7DA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600ABCB RID: 43979 RVA: 0x002C9BB8 File Offset: 0x002C7DB8
		public PhantomBattleCardFilter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002616 RID: 9750
		// (get) Token: 0x0600ABCC RID: 43980 RVA: 0x002C9BC8 File Offset: 0x002C7DC8
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

		// Token: 0x17002617 RID: 9751
		// (get) Token: 0x0600ABCD RID: 43981 RVA: 0x002C9C04 File Offset: 0x002C7E04
		public string Name
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

		// Token: 0x0600ABCE RID: 43982 RVA: 0x002C9C3B File Offset: 0x002C7E3B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600ABCF RID: 43983 RVA: 0x002C9C4A File Offset: 0x002C7E4A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0600ABD0 RID: 43984 RVA: 0x002C9C64 File Offset: 0x002C7E64
		public int CostList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002618 RID: 9752
		// (get) Token: 0x0600ABD1 RID: 43985 RVA: 0x002C9CA4 File Offset: 0x002C7EA4
		public int CostListLength
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

		// Token: 0x0600ABD2 RID: 43986 RVA: 0x002C9CCF File Offset: 0x002C7ECF
		public Span<int> GetCostListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600ABD3 RID: 43987 RVA: 0x002C9CDE File Offset: 0x002C7EDE
		public int[] GetCostListArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600ABD4 RID: 43988 RVA: 0x002C9CF5 File Offset: 0x002C7EF5
		[NullableContext(1)]
		public int[] CostList()
		{
			return this.GetCostListArray();
		}

		// Token: 0x0600ABD5 RID: 43989 RVA: 0x002C9CFD File Offset: 0x002C7EFD
		[NullableContext(1)]
		public IEnumerable<int> CostListIter()
		{
			PhantomBattleCardFilter.<CostListIter>d__20 <CostListIter>d__ = new PhantomBattleCardFilter.<CostListIter>d__20(-2);
			<CostListIter>d__.<>3__<>4__this = this;
			return <CostListIter>d__;
		}

		// Token: 0x04005564 RID: 21860
		private Table __p;
	}
}
