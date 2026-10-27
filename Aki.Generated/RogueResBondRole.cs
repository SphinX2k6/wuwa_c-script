using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FF1 RID: 4081
	public struct RogueResBondRole : IFlatbufferObject
	{
		// Token: 0x17002FBF RID: 12223
		// (get) Token: 0x0600C0D4 RID: 49364 RVA: 0x002E9178 File Offset: 0x002E7378
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C0D5 RID: 49365 RVA: 0x002E9185 File Offset: 0x002E7385
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C0D6 RID: 49366 RVA: 0x002E918C File Offset: 0x002E738C
		public static RogueResBondRole GetRootAsRogueResBondRole(ByteBuffer _bb)
		{
			return RogueResBondRole.GetRootAsRogueResBondRole(_bb, default(RogueResBondRole));
		}

		// Token: 0x0600C0D7 RID: 49367 RVA: 0x002E91A8 File Offset: 0x002E73A8
		public static RogueResBondRole GetRootAsRogueResBondRole(ByteBuffer _bb, RogueResBondRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C0D8 RID: 49368 RVA: 0x002E91C5 File Offset: 0x002E73C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C0D9 RID: 49369 RVA: 0x002E91D4 File Offset: 0x002E73D4
		public RogueResBondRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002FC0 RID: 12224
		// (get) Token: 0x0600C0DA RID: 49370 RVA: 0x002E91E4 File Offset: 0x002E73E4
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

		// Token: 0x0600C0DB RID: 49371 RVA: 0x002E9220 File Offset: 0x002E7420
		public int BondIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002FC1 RID: 12225
		// (get) Token: 0x0600C0DC RID: 49372 RVA: 0x002E9260 File Offset: 0x002E7460
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

		// Token: 0x0600C0DD RID: 49373 RVA: 0x002E928B File Offset: 0x002E748B
		public Span<int> GetBondIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600C0DE RID: 49374 RVA: 0x002E929A File Offset: 0x002E749A
		public int[] GetBondIdsArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17002FC2 RID: 12226
		// (get) Token: 0x0600C0DF RID: 49375 RVA: 0x002E92B4 File Offset: 0x002E74B4
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

		// Token: 0x0600C0E0 RID: 49376 RVA: 0x002E92F0 File Offset: 0x002E74F0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BondIdsIter()或GetBondIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] BondIds()
		{
			RogueResBondRole rogueResBondRole = this;
			return rogueResBondRole.GetBondIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C0E1 RID: 49377 RVA: 0x002E9314 File Offset: 0x002E7514
		[NullableContext(1)]
		public readonly IEnumerable<int> BondIdsIter()
		{
			RogueResBondRole.<BondIdsIter>d__18 <BondIdsIter>d__ = new RogueResBondRole.<BondIdsIter>d__18(-2);
			<BondIdsIter>d__.<>3__<>4__this = this;
			return <BondIdsIter>d__;
		}

		// Token: 0x040050D8 RID: 20696
		private Table __p;
	}
}
