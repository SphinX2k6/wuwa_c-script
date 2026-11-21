using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D4B RID: 3403
	public struct FightFormation : IFlatbufferObject
	{
		// Token: 0x17001100 RID: 4352
		// (get) Token: 0x0600738F RID: 29583 RVA: 0x0024C0E0 File Offset: 0x0024A2E0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007390 RID: 29584 RVA: 0x0024C0ED File Offset: 0x0024A2ED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007391 RID: 29585 RVA: 0x0024C0F4 File Offset: 0x0024A2F4
		public static FightFormation GetRootAsFightFormation(ByteBuffer _bb)
		{
			return FightFormation.GetRootAsFightFormation(_bb, default(FightFormation));
		}

		// Token: 0x06007392 RID: 29586 RVA: 0x0024C110 File Offset: 0x0024A310
		public static FightFormation GetRootAsFightFormation(ByteBuffer _bb, FightFormation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007393 RID: 29587 RVA: 0x0024C12D File Offset: 0x0024A32D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007394 RID: 29588 RVA: 0x0024C13C File Offset: 0x0024A33C
		public FightFormation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001101 RID: 4353
		// (get) Token: 0x06007395 RID: 29589 RVA: 0x0024C14C File Offset: 0x0024A34C
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

		// Token: 0x06007396 RID: 29590 RVA: 0x0024C188 File Offset: 0x0024A388
		public int LimitRole(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001102 RID: 4354
		// (get) Token: 0x06007397 RID: 29591 RVA: 0x0024C1C8 File Offset: 0x0024A3C8
		public int LimitRoleLength
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

		// Token: 0x06007398 RID: 29592 RVA: 0x0024C1F3 File Offset: 0x0024A3F3
		public Span<int> GetLimitRoleBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06007399 RID: 29593 RVA: 0x0024C202 File Offset: 0x0024A402
		public int[] GetLimitRoleArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600739A RID: 29594 RVA: 0x0024C21C File Offset: 0x0024A41C
		public int LimitCount(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001103 RID: 4355
		// (get) Token: 0x0600739B RID: 29595 RVA: 0x0024C25C File Offset: 0x0024A45C
		public int LimitCountLength
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

		// Token: 0x0600739C RID: 29596 RVA: 0x0024C287 File Offset: 0x0024A487
		public Span<int> GetLimitCountBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600739D RID: 29597 RVA: 0x0024C296 File Offset: 0x0024A496
		public int[] GetLimitCountArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600739E RID: 29598 RVA: 0x0024C2B0 File Offset: 0x0024A4B0
		public int LitmitElement(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001104 RID: 4356
		// (get) Token: 0x0600739F RID: 29599 RVA: 0x0024C2F0 File Offset: 0x0024A4F0
		public int LitmitElementLength
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

		// Token: 0x060073A0 RID: 29600 RVA: 0x0024C31C File Offset: 0x0024A51C
		public Span<int> GetLitmitElementBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x060073A1 RID: 29601 RVA: 0x0024C32C File Offset: 0x0024A52C
		public int[] GetLitmitElementArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17001105 RID: 4357
		// (get) Token: 0x060073A2 RID: 29602 RVA: 0x0024C344 File Offset: 0x0024A544
		public string Content
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

		// Token: 0x060073A3 RID: 29603 RVA: 0x0024C37C File Offset: 0x0024A57C
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060073A4 RID: 29604 RVA: 0x0024C38C File Offset: 0x0024A58C
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x060073A5 RID: 29605 RVA: 0x0024C3A4 File Offset: 0x0024A5A4
		public int RecommendFormation(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001106 RID: 4358
		// (get) Token: 0x060073A6 RID: 29606 RVA: 0x0024C3E4 File Offset: 0x0024A5E4
		public int RecommendFormationLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060073A7 RID: 29607 RVA: 0x0024C410 File Offset: 0x0024A610
		public Span<int> GetRecommendFormationBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x060073A8 RID: 29608 RVA: 0x0024C420 File Offset: 0x0024A620
		public int[] GetRecommendFormationArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x060073A9 RID: 29609 RVA: 0x0024C438 File Offset: 0x0024A638
		public int TrialRole(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001107 RID: 4359
		// (get) Token: 0x060073AA RID: 29610 RVA: 0x0024C478 File Offset: 0x0024A678
		public int TrialRoleLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060073AB RID: 29611 RVA: 0x0024C4A4 File Offset: 0x0024A6A4
		public Span<int> GetTrialRoleBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x060073AC RID: 29612 RVA: 0x0024C4B4 File Offset: 0x0024A6B4
		public int[] GetTrialRoleArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x060073AD RID: 29613 RVA: 0x0024C4CC File Offset: 0x0024A6CC
		public int AutoRole(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001108 RID: 4360
		// (get) Token: 0x060073AE RID: 29614 RVA: 0x0024C50C File Offset: 0x0024A70C
		public int AutoRoleLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060073AF RID: 29615 RVA: 0x0024C538 File Offset: 0x0024A738
		public Span<int> GetAutoRoleBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x060073B0 RID: 29616 RVA: 0x0024C548 File Offset: 0x0024A748
		public int[] GetAutoRoleArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x17001109 RID: 4361
		// (get) Token: 0x060073B1 RID: 29617 RVA: 0x0024C560 File Offset: 0x0024A760
		public bool ChooseRole
		{
			get
			{
				int num = this.__p.__offset(20);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060073B2 RID: 29618 RVA: 0x0024C5A0 File Offset: 0x0024A7A0
		[NullableContext(1)]
		public int[] AutoRole()
		{
			return this.GetAutoRoleArray();
		}

		// Token: 0x060073B3 RID: 29619 RVA: 0x0024C5A8 File Offset: 0x0024A7A8
		[NullableContext(1)]
		public IEnumerable<int> AutoRoleIter()
		{
			FightFormation.<AutoRoleIter>d__47 <AutoRoleIter>d__ = new FightFormation.<AutoRoleIter>d__47(-2);
			<AutoRoleIter>d__.<>3__<>4__this = this;
			return <AutoRoleIter>d__;
		}

		// Token: 0x060073B4 RID: 29620 RVA: 0x0024C5BD File Offset: 0x0024A7BD
		[NullableContext(1)]
		public int[] LimitCount()
		{
			return this.GetLimitCountArray();
		}

		// Token: 0x060073B5 RID: 29621 RVA: 0x0024C5C5 File Offset: 0x0024A7C5
		[NullableContext(1)]
		public IEnumerable<int> LimitCountIter()
		{
			FightFormation.<LimitCountIter>d__49 <LimitCountIter>d__ = new FightFormation.<LimitCountIter>d__49(-2);
			<LimitCountIter>d__.<>3__<>4__this = this;
			return <LimitCountIter>d__;
		}

		// Token: 0x060073B6 RID: 29622 RVA: 0x0024C5DA File Offset: 0x0024A7DA
		[NullableContext(1)]
		public int[] LimitRole()
		{
			return this.GetLimitRoleArray();
		}

		// Token: 0x060073B7 RID: 29623 RVA: 0x0024C5E2 File Offset: 0x0024A7E2
		[NullableContext(1)]
		public IEnumerable<int> LimitRoleIter()
		{
			FightFormation.<LimitRoleIter>d__51 <LimitRoleIter>d__ = new FightFormation.<LimitRoleIter>d__51(-2);
			<LimitRoleIter>d__.<>3__<>4__this = this;
			return <LimitRoleIter>d__;
		}

		// Token: 0x060073B8 RID: 29624 RVA: 0x0024C5F7 File Offset: 0x0024A7F7
		[NullableContext(1)]
		public int[] LitmitElement()
		{
			return this.GetLitmitElementArray();
		}

		// Token: 0x060073B9 RID: 29625 RVA: 0x0024C5FF File Offset: 0x0024A7FF
		[NullableContext(1)]
		public IEnumerable<int> LitmitElementIter()
		{
			FightFormation.<LitmitElementIter>d__53 <LitmitElementIter>d__ = new FightFormation.<LitmitElementIter>d__53(-2);
			<LitmitElementIter>d__.<>3__<>4__this = this;
			return <LitmitElementIter>d__;
		}

		// Token: 0x060073BA RID: 29626 RVA: 0x0024C614 File Offset: 0x0024A814
		[NullableContext(1)]
		public int[] RecommendFormation()
		{
			return this.GetRecommendFormationArray();
		}

		// Token: 0x060073BB RID: 29627 RVA: 0x0024C61C File Offset: 0x0024A81C
		[NullableContext(1)]
		public IEnumerable<int> RecommendFormationIter()
		{
			FightFormation.<RecommendFormationIter>d__55 <RecommendFormationIter>d__ = new FightFormation.<RecommendFormationIter>d__55(-2);
			<RecommendFormationIter>d__.<>3__<>4__this = this;
			return <RecommendFormationIter>d__;
		}

		// Token: 0x060073BC RID: 29628 RVA: 0x0024C631 File Offset: 0x0024A831
		[NullableContext(1)]
		public int[] TrialRole()
		{
			return this.GetTrialRoleArray();
		}

		// Token: 0x060073BD RID: 29629 RVA: 0x0024C639 File Offset: 0x0024A839
		[NullableContext(1)]
		public IEnumerable<int> TrialRoleIter()
		{
			FightFormation.<TrialRoleIter>d__57 <TrialRoleIter>d__ = new FightFormation.<TrialRoleIter>d__57(-2);
			<TrialRoleIter>d__.<>3__<>4__this = this;
			return <TrialRoleIter>d__;
		}

		// Token: 0x04005296 RID: 21142
		private Table __p;
	}
}
