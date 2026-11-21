using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BA9 RID: 2985
	public struct ActivityTimeShow : IFlatbufferObject
	{
		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06004958 RID: 18776 RVA: 0x001ED5B1 File Offset: 0x001EB7B1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004959 RID: 18777 RVA: 0x001ED5BE File Offset: 0x001EB7BE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600495A RID: 18778 RVA: 0x001ED5C8 File Offset: 0x001EB7C8
		public static ActivityTimeShow GetRootAsActivityTimeShow(ByteBuffer _bb)
		{
			return ActivityTimeShow.GetRootAsActivityTimeShow(_bb, default(ActivityTimeShow));
		}

		// Token: 0x0600495B RID: 18779 RVA: 0x001ED5E4 File Offset: 0x001EB7E4
		public static ActivityTimeShow GetRootAsActivityTimeShow(ByteBuffer _bb, ActivityTimeShow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600495C RID: 18780 RVA: 0x001ED601 File Offset: 0x001EB801
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600495D RID: 18781 RVA: 0x001ED610 File Offset: 0x001EB810
		public ActivityTimeShow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x0600495E RID: 18782 RVA: 0x001ED620 File Offset: 0x001EB820
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

		// Token: 0x0600495F RID: 18783 RVA: 0x001ED65C File Offset: 0x001EB85C
		public int RedInterval(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06004960 RID: 18784 RVA: 0x001ED69C File Offset: 0x001EB89C
		public int RedIntervalLength
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

		// Token: 0x06004961 RID: 18785 RVA: 0x001ED6C7 File Offset: 0x001EB8C7
		public Span<int> GetRedIntervalBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06004962 RID: 18786 RVA: 0x001ED6D6 File Offset: 0x001EB8D6
		public int[] GetRedIntervalArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06004963 RID: 18787 RVA: 0x001ED6F0 File Offset: 0x001EB8F0
		public int YellowInterval(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06004964 RID: 18788 RVA: 0x001ED730 File Offset: 0x001EB930
		public int YellowIntervalLength
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

		// Token: 0x06004965 RID: 18789 RVA: 0x001ED75B File Offset: 0x001EB95B
		public Span<int> GetYellowIntervalBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06004966 RID: 18790 RVA: 0x001ED76A File Offset: 0x001EB96A
		public int[] GetYellowIntervalArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x06004967 RID: 18791 RVA: 0x001ED784 File Offset: 0x001EB984
		public int WhiteInterval(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06004968 RID: 18792 RVA: 0x001ED7C4 File Offset: 0x001EB9C4
		public int WhiteIntervalLength
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

		// Token: 0x06004969 RID: 18793 RVA: 0x001ED7F0 File Offset: 0x001EB9F0
		public Span<int> GetWhiteIntervalBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600496A RID: 18794 RVA: 0x001ED800 File Offset: 0x001EBA00
		public int[] GetWhiteIntervalArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x0600496B RID: 18795 RVA: 0x001ED818 File Offset: 0x001EBA18
		[NullableContext(1)]
		public int[] RedInterval()
		{
			return this.GetRedIntervalArray();
		}

		// Token: 0x0600496C RID: 18796 RVA: 0x001ED820 File Offset: 0x001EBA20
		[NullableContext(1)]
		public IEnumerable<int> RedIntervalIter()
		{
			ActivityTimeShow.<RedIntervalIter>d__26 <RedIntervalIter>d__ = new ActivityTimeShow.<RedIntervalIter>d__26(-2);
			<RedIntervalIter>d__.<>3__<>4__this = this;
			return <RedIntervalIter>d__;
		}

		// Token: 0x0600496D RID: 18797 RVA: 0x001ED835 File Offset: 0x001EBA35
		[NullableContext(1)]
		public int[] WhiteInterval()
		{
			return this.GetWhiteIntervalArray();
		}

		// Token: 0x0600496E RID: 18798 RVA: 0x001ED83D File Offset: 0x001EBA3D
		[NullableContext(1)]
		public IEnumerable<int> WhiteIntervalIter()
		{
			ActivityTimeShow.<WhiteIntervalIter>d__28 <WhiteIntervalIter>d__ = new ActivityTimeShow.<WhiteIntervalIter>d__28(-2);
			<WhiteIntervalIter>d__.<>3__<>4__this = this;
			return <WhiteIntervalIter>d__;
		}

		// Token: 0x0600496F RID: 18799 RVA: 0x001ED852 File Offset: 0x001EBA52
		[NullableContext(1)]
		public int[] YellowInterval()
		{
			return this.GetYellowIntervalArray();
		}

		// Token: 0x06004970 RID: 18800 RVA: 0x001ED85A File Offset: 0x001EBA5A
		[NullableContext(1)]
		public IEnumerable<int> YellowIntervalIter()
		{
			ActivityTimeShow.<YellowIntervalIter>d__30 <YellowIntervalIter>d__ = new ActivityTimeShow.<YellowIntervalIter>d__30(-2);
			<YellowIntervalIter>d__.<>3__<>4__this = this;
			return <YellowIntervalIter>d__;
		}

		// Token: 0x04005086 RID: 20614
		private Table __p;
	}
}
