using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D7A RID: 3450
	public struct FlagChallengeRoleBuff : IFlatbufferObject
	{
		// Token: 0x17001286 RID: 4742
		// (get) Token: 0x0600776B RID: 30571 RVA: 0x00255099 File Offset: 0x00253299
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600776C RID: 30572 RVA: 0x002550A6 File Offset: 0x002532A6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600776D RID: 30573 RVA: 0x002550B0 File Offset: 0x002532B0
		public static FlagChallengeRoleBuff GetRootAsFlagChallengeRoleBuff(ByteBuffer _bb)
		{
			return FlagChallengeRoleBuff.GetRootAsFlagChallengeRoleBuff(_bb, default(FlagChallengeRoleBuff));
		}

		// Token: 0x0600776E RID: 30574 RVA: 0x002550CC File Offset: 0x002532CC
		public static FlagChallengeRoleBuff GetRootAsFlagChallengeRoleBuff(ByteBuffer _bb, FlagChallengeRoleBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600776F RID: 30575 RVA: 0x002550E9 File Offset: 0x002532E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007770 RID: 30576 RVA: 0x002550F8 File Offset: 0x002532F8
		public FlagChallengeRoleBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001287 RID: 4743
		// (get) Token: 0x06007771 RID: 30577 RVA: 0x00255108 File Offset: 0x00253308
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

		// Token: 0x17001288 RID: 4744
		// (get) Token: 0x06007772 RID: 30578 RVA: 0x00255144 File Offset: 0x00253344
		public int ActivityId
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

		// Token: 0x17001289 RID: 4745
		// (get) Token: 0x06007773 RID: 30579 RVA: 0x00255180 File Offset: 0x00253380
		public int Level
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

		// Token: 0x06007774 RID: 30580 RVA: 0x002551BC File Offset: 0x002533BC
		public long BuffIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x1700128A RID: 4746
		// (get) Token: 0x06007775 RID: 30581 RVA: 0x00255200 File Offset: 0x00253400
		public int BuffIdsLength
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

		// Token: 0x06007776 RID: 30582 RVA: 0x0025522C File Offset: 0x0025342C
		public Span<long> GetBuffIdsBytes()
		{
			return this.__p.__vector_as_span<long>(10, 8);
		}

		// Token: 0x06007777 RID: 30583 RVA: 0x0025523C File Offset: 0x0025343C
		public long[] GetBuffIdsArray()
		{
			return this.__p.__vector_as_array<long>(10) ?? Array.Empty<long>();
		}

		// Token: 0x1700128B RID: 4747
		// (get) Token: 0x06007778 RID: 30584 RVA: 0x00255254 File Offset: 0x00253454
		public string IconPathNormal
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

		// Token: 0x06007779 RID: 30585 RVA: 0x0025528C File Offset: 0x0025348C
		public Span<byte> GetIconPathNormalBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600777A RID: 30586 RVA: 0x0025529C File Offset: 0x0025349C
		public byte[] GetIconPathNormalArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700128C RID: 4748
		// (get) Token: 0x0600777B RID: 30587 RVA: 0x002552B4 File Offset: 0x002534B4
		public string IconPathActive
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600777C RID: 30588 RVA: 0x002552EC File Offset: 0x002534EC
		public Span<byte> GetIconPathActiveBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600777D RID: 30589 RVA: 0x002552FC File Offset: 0x002534FC
		public byte[] GetIconPathActiveArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700128D RID: 4749
		// (get) Token: 0x0600777E RID: 30590 RVA: 0x00255314 File Offset: 0x00253514
		public string BuffName
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600777F RID: 30591 RVA: 0x0025534C File Offset: 0x0025354C
		public Span<byte> GetBuffNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06007780 RID: 30592 RVA: 0x0025535C File Offset: 0x0025355C
		public byte[] GetBuffNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700128E RID: 4750
		// (get) Token: 0x06007781 RID: 30593 RVA: 0x00255374 File Offset: 0x00253574
		public string BuffDesc
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007782 RID: 30594 RVA: 0x002553AC File Offset: 0x002535AC
		public Span<byte> GetBuffDescBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06007783 RID: 30595 RVA: 0x002553BC File Offset: 0x002535BC
		public byte[] GetBuffDescArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700128F RID: 4751
		// (get) Token: 0x06007784 RID: 30596 RVA: 0x002553D4 File Offset: 0x002535D4
		public string BuffDescDetail
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007785 RID: 30597 RVA: 0x0025540C File Offset: 0x0025360C
		public Span<byte> GetBuffDescDetailBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06007786 RID: 30598 RVA: 0x0025541C File Offset: 0x0025361C
		public byte[] GetBuffDescDetailArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x06007787 RID: 30599 RVA: 0x00255434 File Offset: 0x00253634
		[NullableContext(1)]
		public long[] BuffIds()
		{
			return this.GetBuffIdsArray();
		}

		// Token: 0x06007788 RID: 30600 RVA: 0x0025543C File Offset: 0x0025363C
		[NullableContext(1)]
		public IEnumerable<long> BuffIdsIter()
		{
			FlagChallengeRoleBuff.<BuffIdsIter>d__40 <BuffIdsIter>d__ = new FlagChallengeRoleBuff.<BuffIdsIter>d__40(-2);
			<BuffIdsIter>d__.<>3__<>4__this = this;
			return <BuffIdsIter>d__;
		}

		// Token: 0x040052D1 RID: 21201
		private Table __p;
	}
}
