using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FB0 RID: 4016
	public struct PhantomBattleConditionGroup : IFlatbufferObject
	{
		// Token: 0x17002685 RID: 9861
		// (get) Token: 0x0600ACEA RID: 44266 RVA: 0x002CC5C0 File Offset: 0x002CA7C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600ACEB RID: 44267 RVA: 0x002CC5CD File Offset: 0x002CA7CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600ACEC RID: 44268 RVA: 0x002CC5D4 File Offset: 0x002CA7D4
		public static PhantomBattleConditionGroup GetRootAsPhantomBattleConditionGroup(ByteBuffer _bb)
		{
			return PhantomBattleConditionGroup.GetRootAsPhantomBattleConditionGroup(_bb, default(PhantomBattleConditionGroup));
		}

		// Token: 0x0600ACED RID: 44269 RVA: 0x002CC5F0 File Offset: 0x002CA7F0
		public static PhantomBattleConditionGroup GetRootAsPhantomBattleConditionGroup(ByteBuffer _bb, PhantomBattleConditionGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600ACEE RID: 44270 RVA: 0x002CC60D File Offset: 0x002CA80D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600ACEF RID: 44271 RVA: 0x002CC61C File Offset: 0x002CA81C
		public PhantomBattleConditionGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002686 RID: 9862
		// (get) Token: 0x0600ACF0 RID: 44272 RVA: 0x002CC62C File Offset: 0x002CA82C
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

		// Token: 0x0600ACF1 RID: 44273 RVA: 0x002CC668 File Offset: 0x002CA868
		public int PhantomBattleConditionId(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002687 RID: 9863
		// (get) Token: 0x0600ACF2 RID: 44274 RVA: 0x002CC6A8 File Offset: 0x002CA8A8
		public int PhantomBattleConditionIdLength
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

		// Token: 0x0600ACF3 RID: 44275 RVA: 0x002CC6D3 File Offset: 0x002CA8D3
		public Span<int> GetPhantomBattleConditionIdBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600ACF4 RID: 44276 RVA: 0x002CC6E2 File Offset: 0x002CA8E2
		public int[] GetPhantomBattleConditionIdArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600ACF5 RID: 44277 RVA: 0x002CC6F9 File Offset: 0x002CA8F9
		[NullableContext(1)]
		public int[] PhantomBattleConditionId()
		{
			return this.GetPhantomBattleConditionIdArray();
		}

		// Token: 0x0600ACF6 RID: 44278 RVA: 0x002CC701 File Offset: 0x002CA901
		[NullableContext(1)]
		public IEnumerable<int> PhantomBattleConditionIdIter()
		{
			PhantomBattleConditionGroup.<PhantomBattleConditionIdIter>d__16 <PhantomBattleConditionIdIter>d__ = new PhantomBattleConditionGroup.<PhantomBattleConditionIdIter>d__16(-2);
			<PhantomBattleConditionIdIter>d__.<>3__<>4__this = this;
			return <PhantomBattleConditionIdIter>d__;
		}

		// Token: 0x0400556E RID: 21870
		private Table __p;
	}
}
