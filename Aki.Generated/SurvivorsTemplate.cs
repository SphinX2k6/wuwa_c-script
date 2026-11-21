using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001240 RID: 4672
	public struct SurvivorsTemplate : IFlatbufferObject
	{
		// Token: 0x17003C9F RID: 15519
		// (get) Token: 0x0600E90C RID: 59660 RVA: 0x00352085 File Offset: 0x00350285
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E90D RID: 59661 RVA: 0x00352092 File Offset: 0x00350292
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E90E RID: 59662 RVA: 0x0035209C File Offset: 0x0035029C
		public static SurvivorsTemplate GetRootAsSurvivorsTemplate(ByteBuffer _bb)
		{
			return SurvivorsTemplate.GetRootAsSurvivorsTemplate(_bb, default(SurvivorsTemplate));
		}

		// Token: 0x0600E90F RID: 59663 RVA: 0x003520B8 File Offset: 0x003502B8
		public static SurvivorsTemplate GetRootAsSurvivorsTemplate(ByteBuffer _bb, SurvivorsTemplate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E910 RID: 59664 RVA: 0x003520D5 File Offset: 0x003502D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E911 RID: 59665 RVA: 0x003520E4 File Offset: 0x003502E4
		public SurvivorsTemplate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003CA0 RID: 15520
		// (get) Token: 0x0600E912 RID: 59666 RVA: 0x003520F4 File Offset: 0x003502F4
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

		// Token: 0x17003CA1 RID: 15521
		// (get) Token: 0x0600E913 RID: 59667 RVA: 0x00352130 File Offset: 0x00350330
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

		// Token: 0x0600E914 RID: 59668 RVA: 0x00352167 File Offset: 0x00350367
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E915 RID: 59669 RVA: 0x00352176 File Offset: 0x00350376
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003CA2 RID: 15522
		// (get) Token: 0x0600E916 RID: 59670 RVA: 0x00352190 File Offset: 0x00350390
		public string Desc
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

		// Token: 0x0600E917 RID: 59671 RVA: 0x003521C7 File Offset: 0x003503C7
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E918 RID: 59672 RVA: 0x003521D6 File Offset: 0x003503D6
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E919 RID: 59673 RVA: 0x003521F0 File Offset: 0x003503F0
		public string DescArgs(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003CA3 RID: 15523
		// (get) Token: 0x0600E91A RID: 59674 RVA: 0x0035222C File Offset: 0x0035042C
		public int DescArgsLength
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

		// Token: 0x17003CA4 RID: 15524
		// (get) Token: 0x0600E91B RID: 59675 RVA: 0x00352258 File Offset: 0x00350458
		public int MonsterType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003CA5 RID: 15525
		// (get) Token: 0x0600E91C RID: 59676 RVA: 0x00352298 File Offset: 0x00350498
		public int SimpleCombatSubtypeId
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

		// Token: 0x0600E91D RID: 59677 RVA: 0x003522D8 File Offset: 0x003504D8
		public int InitBuffs(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003CA6 RID: 15526
		// (get) Token: 0x0600E91E RID: 59678 RVA: 0x00352318 File Offset: 0x00350518
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

		// Token: 0x0600E91F RID: 59679 RVA: 0x00352344 File Offset: 0x00350544
		public Span<int> GetInitBuffsBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600E920 RID: 59680 RVA: 0x00352354 File Offset: 0x00350554
		public int[] GetInitBuffsArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x0600E921 RID: 59681 RVA: 0x0035236C File Offset: 0x0035056C
		public int Deathrattles(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003CA7 RID: 15527
		// (get) Token: 0x0600E922 RID: 59682 RVA: 0x003523AC File Offset: 0x003505AC
		public int DeathrattlesLength
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

		// Token: 0x0600E923 RID: 59683 RVA: 0x003523D8 File Offset: 0x003505D8
		public Span<int> GetDeathrattlesBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600E924 RID: 59684 RVA: 0x003523E8 File Offset: 0x003505E8
		public int[] GetDeathrattlesArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x0600E925 RID: 59685 RVA: 0x00352400 File Offset: 0x00350600
		public int Tag(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003CA8 RID: 15528
		// (get) Token: 0x0600E926 RID: 59686 RVA: 0x00352440 File Offset: 0x00350640
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

		// Token: 0x0600E927 RID: 59687 RVA: 0x0035246C File Offset: 0x0035066C
		public Span<int> GetTagBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600E928 RID: 59688 RVA: 0x0035247C File Offset: 0x0035067C
		public int[] GetTagArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x0600E929 RID: 59689 RVA: 0x00352494 File Offset: 0x00350694
		public int AttrShow(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003CA9 RID: 15529
		// (get) Token: 0x0600E92A RID: 59690 RVA: 0x003524D4 File Offset: 0x003506D4
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

		// Token: 0x0600E92B RID: 59691 RVA: 0x00352500 File Offset: 0x00350700
		public Span<int> GetAttrShowBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600E92C RID: 59692 RVA: 0x00352510 File Offset: 0x00350710
		public int[] GetAttrShowArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x0600E92D RID: 59693 RVA: 0x00352528 File Offset: 0x00350728
		[NullableContext(1)]
		public int[] AttrShow()
		{
			return this.GetAttrShowArray();
		}

		// Token: 0x0600E92E RID: 59694 RVA: 0x00352530 File Offset: 0x00350730
		[NullableContext(1)]
		public IEnumerable<int> AttrShowIter()
		{
			SurvivorsTemplate.<AttrShowIter>d__46 <AttrShowIter>d__ = new SurvivorsTemplate.<AttrShowIter>d__46(-2);
			<AttrShowIter>d__.<>3__<>4__this = this;
			return <AttrShowIter>d__;
		}

		// Token: 0x0600E92F RID: 59695 RVA: 0x00352545 File Offset: 0x00350745
		[NullableContext(1)]
		public int[] Deathrattles()
		{
			return this.GetDeathrattlesArray();
		}

		// Token: 0x0600E930 RID: 59696 RVA: 0x0035254D File Offset: 0x0035074D
		[NullableContext(1)]
		public IEnumerable<int> DeathrattlesIter()
		{
			SurvivorsTemplate.<DeathrattlesIter>d__48 <DeathrattlesIter>d__ = new SurvivorsTemplate.<DeathrattlesIter>d__48(-2);
			<DeathrattlesIter>d__.<>3__<>4__this = this;
			return <DeathrattlesIter>d__;
		}

		// Token: 0x0600E931 RID: 59697 RVA: 0x00352562 File Offset: 0x00350762
		[NullableContext(1)]
		public string[] DescArgs()
		{
			return this.DescArgsIter().ToArray<string>();
		}

		// Token: 0x0600E932 RID: 59698 RVA: 0x0035256F File Offset: 0x0035076F
		[NullableContext(1)]
		public IEnumerable<string> DescArgsIter()
		{
			SurvivorsTemplate.<DescArgsIter>d__50 <DescArgsIter>d__ = new SurvivorsTemplate.<DescArgsIter>d__50(-2);
			<DescArgsIter>d__.<>3__<>4__this = this;
			return <DescArgsIter>d__;
		}

		// Token: 0x0600E933 RID: 59699 RVA: 0x00352584 File Offset: 0x00350784
		[NullableContext(1)]
		public int[] InitBuffs()
		{
			return this.GetInitBuffsArray();
		}

		// Token: 0x0600E934 RID: 59700 RVA: 0x0035258C File Offset: 0x0035078C
		[NullableContext(1)]
		public IEnumerable<int> InitBuffsIter()
		{
			SurvivorsTemplate.<InitBuffsIter>d__52 <InitBuffsIter>d__ = new SurvivorsTemplate.<InitBuffsIter>d__52(-2);
			<InitBuffsIter>d__.<>3__<>4__this = this;
			return <InitBuffsIter>d__;
		}

		// Token: 0x0600E935 RID: 59701 RVA: 0x003525A1 File Offset: 0x003507A1
		[NullableContext(1)]
		public int[] Tag()
		{
			return this.GetTagArray();
		}

		// Token: 0x0600E936 RID: 59702 RVA: 0x003525A9 File Offset: 0x003507A9
		[NullableContext(1)]
		public IEnumerable<int> TagIter()
		{
			SurvivorsTemplate.<TagIter>d__54 <TagIter>d__ = new SurvivorsTemplate.<TagIter>d__54(-2);
			<TagIter>d__.<>3__<>4__this = this;
			return <TagIter>d__;
		}

		// Token: 0x04005887 RID: 22663
		private Table __p;
	}
}
