using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CEB RID: 3307
	public struct DrinksRoleLikeDrink : IFlatbufferObject
	{
		// Token: 0x17000DDC RID: 3548
		// (get) Token: 0x06006AD8 RID: 27352 RVA: 0x00239407 File Offset: 0x00237607
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006AD9 RID: 27353 RVA: 0x00239414 File Offset: 0x00237614
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006ADA RID: 27354 RVA: 0x0023941C File Offset: 0x0023761C
		public static DrinksRoleLikeDrink GetRootAsDrinksRoleLikeDrink(ByteBuffer _bb)
		{
			return DrinksRoleLikeDrink.GetRootAsDrinksRoleLikeDrink(_bb, default(DrinksRoleLikeDrink));
		}

		// Token: 0x06006ADB RID: 27355 RVA: 0x00239438 File Offset: 0x00237638
		public static DrinksRoleLikeDrink GetRootAsDrinksRoleLikeDrink(ByteBuffer _bb, DrinksRoleLikeDrink obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006ADC RID: 27356 RVA: 0x00239455 File Offset: 0x00237655
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006ADD RID: 27357 RVA: 0x00239464 File Offset: 0x00237664
		public DrinksRoleLikeDrink __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000DDD RID: 3549
		// (get) Token: 0x06006ADE RID: 27358 RVA: 0x00239474 File Offset: 0x00237674
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

		// Token: 0x17000DDE RID: 3550
		// (get) Token: 0x06006ADF RID: 27359 RVA: 0x002394B0 File Offset: 0x002376B0
		public bool LikeStatus
		{
			get
			{
				int num = this.__p.__offset(6);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06006AE0 RID: 27360 RVA: 0x002394F0 File Offset: 0x002376F0
		public int LinkDrinkBase(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000DDF RID: 3551
		// (get) Token: 0x06006AE1 RID: 27361 RVA: 0x00239530 File Offset: 0x00237730
		public int LinkDrinkBaseLength
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

		// Token: 0x06006AE2 RID: 27362 RVA: 0x0023955B File Offset: 0x0023775B
		public Span<int> GetLinkDrinkBaseBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06006AE3 RID: 27363 RVA: 0x0023956A File Offset: 0x0023776A
		public int[] GetLinkDrinkBaseArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17000DE0 RID: 3552
		// (get) Token: 0x06006AE4 RID: 27364 RVA: 0x00239584 File Offset: 0x00237784
		public int DrinkLikePoint
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

		// Token: 0x06006AE5 RID: 27365 RVA: 0x002395C4 File Offset: 0x002377C4
		public int LinkOrnament(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000DE1 RID: 3553
		// (get) Token: 0x06006AE6 RID: 27366 RVA: 0x00239604 File Offset: 0x00237804
		public int LinkOrnamentLength
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

		// Token: 0x06006AE7 RID: 27367 RVA: 0x00239630 File Offset: 0x00237830
		public Span<int> GetLinkOrnamentBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06006AE8 RID: 27368 RVA: 0x00239640 File Offset: 0x00237840
		public int[] GetLinkOrnamentArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17000DE2 RID: 3554
		// (get) Token: 0x06006AE9 RID: 27369 RVA: 0x00239658 File Offset: 0x00237858
		public int OrnamentLikePoint
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

		// Token: 0x17000DE3 RID: 3555
		// (get) Token: 0x06006AEA RID: 27370 RVA: 0x00239698 File Offset: 0x00237898
		public string OrnamentHintId
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

		// Token: 0x06006AEB RID: 27371 RVA: 0x002396D0 File Offset: 0x002378D0
		public Span<byte> GetOrnamentHintIdBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06006AEC RID: 27372 RVA: 0x002396E0 File Offset: 0x002378E0
		public byte[] GetOrnamentHintIdArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x06006AED RID: 27373 RVA: 0x002396F8 File Offset: 0x002378F8
		public int LinkBatching(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000DE4 RID: 3556
		// (get) Token: 0x06006AEE RID: 27374 RVA: 0x00239738 File Offset: 0x00237938
		public int LinkBatchingLength
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

		// Token: 0x06006AEF RID: 27375 RVA: 0x00239764 File Offset: 0x00237964
		public Span<int> GetLinkBatchingBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x06006AF0 RID: 27376 RVA: 0x00239774 File Offset: 0x00237974
		public int[] GetLinkBatchingArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x17000DE5 RID: 3557
		// (get) Token: 0x06006AF1 RID: 27377 RVA: 0x0023978C File Offset: 0x0023798C
		public int BatchingLikePoint
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006AF2 RID: 27378 RVA: 0x002397C9 File Offset: 0x002379C9
		[NullableContext(1)]
		public int[] LinkBatching()
		{
			return this.GetLinkBatchingArray();
		}

		// Token: 0x06006AF3 RID: 27379 RVA: 0x002397D1 File Offset: 0x002379D1
		[NullableContext(1)]
		public IEnumerable<int> LinkBatchingIter()
		{
			DrinksRoleLikeDrink.<LinkBatchingIter>d__38 <LinkBatchingIter>d__ = new DrinksRoleLikeDrink.<LinkBatchingIter>d__38(-2);
			<LinkBatchingIter>d__.<>3__<>4__this = this;
			return <LinkBatchingIter>d__;
		}

		// Token: 0x06006AF4 RID: 27380 RVA: 0x002397E6 File Offset: 0x002379E6
		[NullableContext(1)]
		public int[] LinkDrinkBase()
		{
			return this.GetLinkDrinkBaseArray();
		}

		// Token: 0x06006AF5 RID: 27381 RVA: 0x002397EE File Offset: 0x002379EE
		[NullableContext(1)]
		public IEnumerable<int> LinkDrinkBaseIter()
		{
			DrinksRoleLikeDrink.<LinkDrinkBaseIter>d__40 <LinkDrinkBaseIter>d__ = new DrinksRoleLikeDrink.<LinkDrinkBaseIter>d__40(-2);
			<LinkDrinkBaseIter>d__.<>3__<>4__this = this;
			return <LinkDrinkBaseIter>d__;
		}

		// Token: 0x06006AF6 RID: 27382 RVA: 0x00239803 File Offset: 0x00237A03
		[NullableContext(1)]
		public int[] LinkOrnament()
		{
			return this.GetLinkOrnamentArray();
		}

		// Token: 0x06006AF7 RID: 27383 RVA: 0x0023980B File Offset: 0x00237A0B
		[NullableContext(1)]
		public IEnumerable<int> LinkOrnamentIter()
		{
			DrinksRoleLikeDrink.<LinkOrnamentIter>d__42 <LinkOrnamentIter>d__ = new DrinksRoleLikeDrink.<LinkOrnamentIter>d__42(-2);
			<LinkOrnamentIter>d__.<>3__<>4__this = this;
			return <LinkOrnamentIter>d__;
		}

		// Token: 0x04005227 RID: 21031
		private Table __p;
	}
}
