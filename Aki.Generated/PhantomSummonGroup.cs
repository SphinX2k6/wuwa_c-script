using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FE0 RID: 4064
	public struct PhantomSummonGroup : IFlatbufferObject
	{
		// Token: 0x170027D4 RID: 10196
		// (get) Token: 0x0600B09D RID: 45213 RVA: 0x002D4715 File Offset: 0x002D2915
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B09E RID: 45214 RVA: 0x002D4722 File Offset: 0x002D2922
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B09F RID: 45215 RVA: 0x002D472C File Offset: 0x002D292C
		public static PhantomSummonGroup GetRootAsPhantomSummonGroup(ByteBuffer _bb)
		{
			return PhantomSummonGroup.GetRootAsPhantomSummonGroup(_bb, default(PhantomSummonGroup));
		}

		// Token: 0x0600B0A0 RID: 45216 RVA: 0x002D4748 File Offset: 0x002D2948
		public static PhantomSummonGroup GetRootAsPhantomSummonGroup(ByteBuffer _bb, PhantomSummonGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B0A1 RID: 45217 RVA: 0x002D4765 File Offset: 0x002D2965
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B0A2 RID: 45218 RVA: 0x002D4774 File Offset: 0x002D2974
		public PhantomSummonGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170027D5 RID: 10197
		// (get) Token: 0x0600B0A3 RID: 45219 RVA: 0x002D4784 File Offset: 0x002D2984
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

		// Token: 0x0600B0A4 RID: 45220 RVA: 0x002D47C0 File Offset: 0x002D29C0
		public int GroupMonsterIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170027D6 RID: 10198
		// (get) Token: 0x0600B0A5 RID: 45221 RVA: 0x002D4800 File Offset: 0x002D2A00
		public int GroupMonsterIdsLength
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

		// Token: 0x0600B0A6 RID: 45222 RVA: 0x002D482B File Offset: 0x002D2A2B
		public Span<int> GetGroupMonsterIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600B0A7 RID: 45223 RVA: 0x002D483A File Offset: 0x002D2A3A
		public int[] GetGroupMonsterIdsArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600B0A8 RID: 45224 RVA: 0x002D4851 File Offset: 0x002D2A51
		[NullableContext(1)]
		public int[] GroupMonsterIds()
		{
			return this.GetGroupMonsterIdsArray();
		}

		// Token: 0x0600B0A9 RID: 45225 RVA: 0x002D4859 File Offset: 0x002D2A59
		[NullableContext(1)]
		public IEnumerable<int> GroupMonsterIdsIter()
		{
			PhantomSummonGroup.<GroupMonsterIdsIter>d__16 <GroupMonsterIdsIter>d__ = new PhantomSummonGroup.<GroupMonsterIdsIter>d__16(-2);
			<GroupMonsterIdsIter>d__.<>3__<>4__this = this;
			return <GroupMonsterIdsIter>d__;
		}

		// Token: 0x040055A7 RID: 21927
		private Table __p;
	}
}
