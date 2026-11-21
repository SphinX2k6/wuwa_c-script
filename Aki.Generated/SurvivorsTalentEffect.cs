using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200123D RID: 4669
	public struct SurvivorsTalentEffect : IFlatbufferObject
	{
		// Token: 0x17003C80 RID: 15488
		// (get) Token: 0x0600E8BD RID: 59581 RVA: 0x003514ED File Offset: 0x0034F6ED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E8BE RID: 59582 RVA: 0x003514FA File Offset: 0x0034F6FA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E8BF RID: 59583 RVA: 0x00351504 File Offset: 0x0034F704
		public static SurvivorsTalentEffect GetRootAsSurvivorsTalentEffect(ByteBuffer _bb)
		{
			return SurvivorsTalentEffect.GetRootAsSurvivorsTalentEffect(_bb, default(SurvivorsTalentEffect));
		}

		// Token: 0x0600E8C0 RID: 59584 RVA: 0x00351520 File Offset: 0x0034F720
		public static SurvivorsTalentEffect GetRootAsSurvivorsTalentEffect(ByteBuffer _bb, SurvivorsTalentEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E8C1 RID: 59585 RVA: 0x0035153D File Offset: 0x0034F73D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E8C2 RID: 59586 RVA: 0x0035154C File Offset: 0x0034F74C
		public SurvivorsTalentEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003C81 RID: 15489
		// (get) Token: 0x0600E8C3 RID: 59587 RVA: 0x0035155C File Offset: 0x0034F75C
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

		// Token: 0x17003C82 RID: 15490
		// (get) Token: 0x0600E8C4 RID: 59588 RVA: 0x00351598 File Offset: 0x0034F798
		public int Effect
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

		// Token: 0x0600E8C5 RID: 59589 RVA: 0x003515D4 File Offset: 0x0034F7D4
		public DicIntInt? Consume(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003C83 RID: 15491
		// (get) Token: 0x0600E8C6 RID: 59590 RVA: 0x00351634 File Offset: 0x0034F834
		public int ConsumeLength
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

		// Token: 0x17003C84 RID: 15492
		// (get) Token: 0x0600E8C7 RID: 59591 RVA: 0x00351660 File Offset: 0x0034F860
		public int ShowType
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

		// Token: 0x0600E8C8 RID: 59592 RVA: 0x003516A0 File Offset: 0x0034F8A0
		public int UnlockItem(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003C85 RID: 15493
		// (get) Token: 0x0600E8C9 RID: 59593 RVA: 0x003516E0 File Offset: 0x0034F8E0
		public int UnlockItemLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E8CA RID: 59594 RVA: 0x0035170C File Offset: 0x0034F90C
		public Span<int> GetUnlockItemBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600E8CB RID: 59595 RVA: 0x0035171C File Offset: 0x0034F91C
		public int[] GetUnlockItemArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17003C86 RID: 15494
		// (get) Token: 0x0600E8CC RID: 59596 RVA: 0x00351734 File Offset: 0x0034F934
		public string Title
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

		// Token: 0x0600E8CD RID: 59597 RVA: 0x0035176C File Offset: 0x0034F96C
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600E8CE RID: 59598 RVA: 0x0035177C File Offset: 0x0034F97C
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003C87 RID: 15495
		// (get) Token: 0x0600E8CF RID: 59599 RVA: 0x00351794 File Offset: 0x0034F994
		public string Tag
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

		// Token: 0x0600E8D0 RID: 59600 RVA: 0x003517CC File Offset: 0x0034F9CC
		public Span<byte> GetTagBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600E8D1 RID: 59601 RVA: 0x003517DC File Offset: 0x0034F9DC
		public byte[] GetTagArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003C88 RID: 15496
		// (get) Token: 0x0600E8D2 RID: 59602 RVA: 0x003517F4 File Offset: 0x0034F9F4
		public string Desc
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

		// Token: 0x0600E8D3 RID: 59603 RVA: 0x0035182C File Offset: 0x0034FA2C
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600E8D4 RID: 59604 RVA: 0x0035183C File Offset: 0x0034FA3C
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E8D5 RID: 59605 RVA: 0x00351854 File Offset: 0x0034FA54
		public string DescParams(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003C89 RID: 15497
		// (get) Token: 0x0600E8D6 RID: 59606 RVA: 0x00351890 File Offset: 0x0034FA90
		public int DescParamsLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E8D7 RID: 59607 RVA: 0x003518BC File Offset: 0x0034FABC
		[NullableContext(1)]
		public Dictionary<int, int> Consume()
		{
			return this.ConsumeIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600E8D8 RID: 59608 RVA: 0x00351912 File Offset: 0x0034FB12
		[NullableContext(1)]
		public IEnumerable<DicIntInt> ConsumeIter()
		{
			SurvivorsTalentEffect.<ConsumeIter>d__38 <ConsumeIter>d__ = new SurvivorsTalentEffect.<ConsumeIter>d__38(-2);
			<ConsumeIter>d__.<>3__<>4__this = this;
			return <ConsumeIter>d__;
		}

		// Token: 0x0600E8D9 RID: 59609 RVA: 0x00351927 File Offset: 0x0034FB27
		[NullableContext(1)]
		public string[] DescParams()
		{
			return this.DescParamsIter().ToArray<string>();
		}

		// Token: 0x0600E8DA RID: 59610 RVA: 0x00351934 File Offset: 0x0034FB34
		[NullableContext(1)]
		public IEnumerable<string> DescParamsIter()
		{
			SurvivorsTalentEffect.<DescParamsIter>d__40 <DescParamsIter>d__ = new SurvivorsTalentEffect.<DescParamsIter>d__40(-2);
			<DescParamsIter>d__.<>3__<>4__this = this;
			return <DescParamsIter>d__;
		}

		// Token: 0x0600E8DB RID: 59611 RVA: 0x00351949 File Offset: 0x0034FB49
		[NullableContext(1)]
		public int[] UnlockItem()
		{
			return this.GetUnlockItemArray();
		}

		// Token: 0x0600E8DC RID: 59612 RVA: 0x00351951 File Offset: 0x0034FB51
		[NullableContext(1)]
		public IEnumerable<int> UnlockItemIter()
		{
			SurvivorsTalentEffect.<UnlockItemIter>d__42 <UnlockItemIter>d__ = new SurvivorsTalentEffect.<UnlockItemIter>d__42(-2);
			<UnlockItemIter>d__.<>3__<>4__this = this;
			return <UnlockItemIter>d__;
		}

		// Token: 0x0600E8DD RID: 59613 RVA: 0x00351968 File Offset: 0x0034FB68
		public int? GetConsume(int key)
		{
			this.EnsureConsumeCacheIfNeeded();
			int value;
			if (!this.ConsumeCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600E8DE RID: 59614 RVA: 0x0035199C File Offset: 0x0034FB9C
		private void EnsureConsumeCacheIfNeeded()
		{
			if (this.ConsumeCache != null)
			{
				return;
			}
			this.ConsumeCache = this.ConsumeIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600E8DF RID: 59615 RVA: 0x00351A02 File Offset: 0x0034FC02
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetConsumeFrozenDict()
		{
			this.EnsureConsumeCacheIfNeeded();
			return this.ConsumeCache;
		}

		// Token: 0x04005883 RID: 22659
		private Table __p;

		// Token: 0x04005884 RID: 22660
		[Nullable(2)]
		private FrozenDictionary<int, int> ConsumeCache;
	}
}
