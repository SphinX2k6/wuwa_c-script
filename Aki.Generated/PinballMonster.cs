using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001014 RID: 4116
	public struct PinballMonster : IFlatbufferObject
	{
		// Token: 0x170029D0 RID: 10704
		// (get) Token: 0x0600B560 RID: 46432 RVA: 0x002DF1ED File Offset: 0x002DD3ED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B561 RID: 46433 RVA: 0x002DF1FA File Offset: 0x002DD3FA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B562 RID: 46434 RVA: 0x002DF204 File Offset: 0x002DD404
		public static PinballMonster GetRootAsPinballMonster(ByteBuffer _bb)
		{
			return PinballMonster.GetRootAsPinballMonster(_bb, default(PinballMonster));
		}

		// Token: 0x0600B563 RID: 46435 RVA: 0x002DF220 File Offset: 0x002DD420
		public static PinballMonster GetRootAsPinballMonster(ByteBuffer _bb, PinballMonster obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B564 RID: 46436 RVA: 0x002DF23D File Offset: 0x002DD43D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B565 RID: 46437 RVA: 0x002DF24C File Offset: 0x002DD44C
		public PinballMonster __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170029D1 RID: 10705
		// (get) Token: 0x0600B566 RID: 46438 RVA: 0x002DF25C File Offset: 0x002DD45C
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

		// Token: 0x170029D2 RID: 10706
		// (get) Token: 0x0600B567 RID: 46439 RVA: 0x002DF298 File Offset: 0x002DD498
		public int SimpleCombatSubtypeId
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

		// Token: 0x170029D3 RID: 10707
		// (get) Token: 0x0600B568 RID: 46440 RVA: 0x002DF2D4 File Offset: 0x002DD4D4
		public string Name
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

		// Token: 0x0600B569 RID: 46441 RVA: 0x002DF30B File Offset: 0x002DD50B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B56A RID: 46442 RVA: 0x002DF31A File Offset: 0x002DD51A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170029D4 RID: 10708
		// (get) Token: 0x0600B56B RID: 46443 RVA: 0x002DF334 File Offset: 0x002DD534
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B56C RID: 46444 RVA: 0x002DF36C File Offset: 0x002DD56C
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B56D RID: 46445 RVA: 0x002DF37C File Offset: 0x002DD57C
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B56E RID: 46446 RVA: 0x002DF394 File Offset: 0x002DD594
		public string DescArgs(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170029D5 RID: 10709
		// (get) Token: 0x0600B56F RID: 46447 RVA: 0x002DF3D0 File Offset: 0x002DD5D0
		public int DescArgsLength
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

		// Token: 0x170029D6 RID: 10710
		// (get) Token: 0x0600B570 RID: 46448 RVA: 0x002DF3FC File Offset: 0x002DD5FC
		public int MonsterType
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

		// Token: 0x0600B571 RID: 46449 RVA: 0x002DF43C File Offset: 0x002DD63C
		public int InitBuffs(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170029D7 RID: 10711
		// (get) Token: 0x0600B572 RID: 46450 RVA: 0x002DF47C File Offset: 0x002DD67C
		public int InitBuffsLength
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

		// Token: 0x0600B573 RID: 46451 RVA: 0x002DF4A8 File Offset: 0x002DD6A8
		public Span<int> GetInitBuffsBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600B574 RID: 46452 RVA: 0x002DF4B8 File Offset: 0x002DD6B8
		public int[] GetInitBuffsArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x170029D8 RID: 10712
		// (get) Token: 0x0600B575 RID: 46453 RVA: 0x002DF4D0 File Offset: 0x002DD6D0
		public int Deathrattle
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B576 RID: 46454 RVA: 0x002DF510 File Offset: 0x002DD710
		public int Tag(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170029D9 RID: 10713
		// (get) Token: 0x0600B577 RID: 46455 RVA: 0x002DF550 File Offset: 0x002DD750
		public int TagLength
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

		// Token: 0x0600B578 RID: 46456 RVA: 0x002DF57C File Offset: 0x002DD77C
		public Span<int> GetTagBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600B579 RID: 46457 RVA: 0x002DF58C File Offset: 0x002DD78C
		public int[] GetTagArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x0600B57A RID: 46458 RVA: 0x002DF5A4 File Offset: 0x002DD7A4
		public int AttrShow(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170029DA RID: 10714
		// (get) Token: 0x0600B57B RID: 46459 RVA: 0x002DF5E4 File Offset: 0x002DD7E4
		public int AttrShowLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600B57C RID: 46460 RVA: 0x002DF610 File Offset: 0x002DD810
		public Span<int> GetAttrShowBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600B57D RID: 46461 RVA: 0x002DF620 File Offset: 0x002DD820
		public int[] GetAttrShowArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x170029DB RID: 10715
		// (get) Token: 0x0600B57E RID: 46462 RVA: 0x002DF638 File Offset: 0x002DD838
		public int Prop
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B57F RID: 46463 RVA: 0x002DF675 File Offset: 0x002DD875
		[NullableContext(1)]
		public int[] AttrShow()
		{
			return this.GetAttrShowArray();
		}

		// Token: 0x0600B580 RID: 46464 RVA: 0x002DF67D File Offset: 0x002DD87D
		[NullableContext(1)]
		public IEnumerable<int> AttrShowIter()
		{
			PinballMonster.<AttrShowIter>d__45 <AttrShowIter>d__ = new PinballMonster.<AttrShowIter>d__45(-2);
			<AttrShowIter>d__.<>3__<>4__this = this;
			return <AttrShowIter>d__;
		}

		// Token: 0x0600B581 RID: 46465 RVA: 0x002DF692 File Offset: 0x002DD892
		[NullableContext(1)]
		public string[] DescArgs()
		{
			return this.DescArgsIter().ToArray<string>();
		}

		// Token: 0x0600B582 RID: 46466 RVA: 0x002DF69F File Offset: 0x002DD89F
		[NullableContext(1)]
		public IEnumerable<string> DescArgsIter()
		{
			PinballMonster.<DescArgsIter>d__47 <DescArgsIter>d__ = new PinballMonster.<DescArgsIter>d__47(-2);
			<DescArgsIter>d__.<>3__<>4__this = this;
			return <DescArgsIter>d__;
		}

		// Token: 0x0600B583 RID: 46467 RVA: 0x002DF6B4 File Offset: 0x002DD8B4
		[NullableContext(1)]
		public int[] InitBuffs()
		{
			return this.GetInitBuffsArray();
		}

		// Token: 0x0600B584 RID: 46468 RVA: 0x002DF6BC File Offset: 0x002DD8BC
		[NullableContext(1)]
		public IEnumerable<int> InitBuffsIter()
		{
			PinballMonster.<InitBuffsIter>d__49 <InitBuffsIter>d__ = new PinballMonster.<InitBuffsIter>d__49(-2);
			<InitBuffsIter>d__.<>3__<>4__this = this;
			return <InitBuffsIter>d__;
		}

		// Token: 0x0600B585 RID: 46469 RVA: 0x002DF6D1 File Offset: 0x002DD8D1
		[NullableContext(1)]
		public int[] Tag()
		{
			return this.GetTagArray();
		}

		// Token: 0x0600B586 RID: 46470 RVA: 0x002DF6D9 File Offset: 0x002DD8D9
		[NullableContext(1)]
		public IEnumerable<int> TagIter()
		{
			PinballMonster.<TagIter>d__51 <TagIter>d__ = new PinballMonster.<TagIter>d__51(-2);
			<TagIter>d__.<>3__<>4__this = this;
			return <TagIter>d__;
		}

		// Token: 0x040055DE RID: 21982
		private Table __p;
	}
}
