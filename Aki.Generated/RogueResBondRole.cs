using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010D9 RID: 4313
	public struct RogueResBondRole : IFlatbufferObject
	{
		// Token: 0x1700303A RID: 12346
		// (get) Token: 0x0600C71E RID: 50974 RVA: 0x0030547C File Offset: 0x0030367C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C71F RID: 50975 RVA: 0x00305489 File Offset: 0x00303689
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C720 RID: 50976 RVA: 0x00305490 File Offset: 0x00303690
		public static RogueResBondRole GetRootAsRogueResBondRole(ByteBuffer _bb)
		{
			return RogueResBondRole.GetRootAsRogueResBondRole(_bb, default(RogueResBondRole));
		}

		// Token: 0x0600C721 RID: 50977 RVA: 0x003054AC File Offset: 0x003036AC
		public static RogueResBondRole GetRootAsRogueResBondRole(ByteBuffer _bb, RogueResBondRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C722 RID: 50978 RVA: 0x003054C9 File Offset: 0x003036C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C723 RID: 50979 RVA: 0x003054D8 File Offset: 0x003036D8
		public RogueResBondRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700303B RID: 12347
		// (get) Token: 0x0600C724 RID: 50980 RVA: 0x003054E8 File Offset: 0x003036E8
		public int RoleId
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

		// Token: 0x0600C725 RID: 50981 RVA: 0x00305524 File Offset: 0x00303724
		public int BondIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700303C RID: 12348
		// (get) Token: 0x0600C726 RID: 50982 RVA: 0x00305564 File Offset: 0x00303764
		public int BondIdsLength
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

		// Token: 0x0600C727 RID: 50983 RVA: 0x0030558F File Offset: 0x0030378F
		public Span<int> GetBondIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600C728 RID: 50984 RVA: 0x0030559E File Offset: 0x0030379E
		public int[] GetBondIdsArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x1700303D RID: 12349
		// (get) Token: 0x0600C729 RID: 50985 RVA: 0x003055B8 File Offset: 0x003037B8
		public int TrialRoleId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C72A RID: 50986 RVA: 0x003055F4 File Offset: 0x003037F4
		[NullableContext(1)]
		public int[] BondIds()
		{
			return this.GetBondIdsArray();
		}

		// Token: 0x0600C72B RID: 50987 RVA: 0x003055FC File Offset: 0x003037FC
		[NullableContext(1)]
		public IEnumerable<int> BondIdsIter()
		{
			RogueResBondRole.<BondIdsIter>d__18 <BondIdsIter>d__ = new RogueResBondRole.<BondIdsIter>d__18(-2);
			<BondIdsIter>d__.<>3__<>4__this = this;
			return <BondIdsIter>d__;
		}

		// Token: 0x040056C0 RID: 22208
		private Table __p;
	}
}
