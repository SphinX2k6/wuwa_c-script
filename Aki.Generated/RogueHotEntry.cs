using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010C9 RID: 4297
	public struct RogueHotEntry : IFlatbufferObject
	{
		// Token: 0x17002FB7 RID: 12215
		// (get) Token: 0x0600C575 RID: 50549 RVA: 0x00301761 File Offset: 0x002FF961
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C576 RID: 50550 RVA: 0x0030176E File Offset: 0x002FF96E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C577 RID: 50551 RVA: 0x00301778 File Offset: 0x002FF978
		public static RogueHotEntry GetRootAsRogueHotEntry(ByteBuffer _bb)
		{
			return RogueHotEntry.GetRootAsRogueHotEntry(_bb, default(RogueHotEntry));
		}

		// Token: 0x0600C578 RID: 50552 RVA: 0x00301794 File Offset: 0x002FF994
		public static RogueHotEntry GetRootAsRogueHotEntry(ByteBuffer _bb, RogueHotEntry obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C579 RID: 50553 RVA: 0x003017B1 File Offset: 0x002FF9B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C57A RID: 50554 RVA: 0x003017C0 File Offset: 0x002FF9C0
		public RogueHotEntry __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002FB8 RID: 12216
		// (get) Token: 0x0600C57B RID: 50555 RVA: 0x003017D0 File Offset: 0x002FF9D0
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

		// Token: 0x17002FB9 RID: 12217
		// (get) Token: 0x0600C57C RID: 50556 RVA: 0x0030180C File Offset: 0x002FFA0C
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

		// Token: 0x0600C57D RID: 50557 RVA: 0x00301843 File Offset: 0x002FFA43
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C57E RID: 50558 RVA: 0x00301852 File Offset: 0x002FFA52
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002FBA RID: 12218
		// (get) Token: 0x0600C57F RID: 50559 RVA: 0x0030186C File Offset: 0x002FFA6C
		public int EffectId
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

		// Token: 0x17002FBB RID: 12219
		// (get) Token: 0x0600C580 RID: 50560 RVA: 0x003018A8 File Offset: 0x002FFAA8
		public string Icon
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

		// Token: 0x0600C581 RID: 50561 RVA: 0x003018E0 File Offset: 0x002FFAE0
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C582 RID: 50562 RVA: 0x003018F0 File Offset: 0x002FFAF0
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002FBC RID: 12220
		// (get) Token: 0x0600C583 RID: 50563 RVA: 0x00301908 File Offset: 0x002FFB08
		public string Desc
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

		// Token: 0x0600C584 RID: 50564 RVA: 0x00301940 File Offset: 0x002FFB40
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C585 RID: 50565 RVA: 0x00301950 File Offset: 0x002FFB50
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C586 RID: 50566 RVA: 0x00301968 File Offset: 0x002FFB68
		public string DescParam(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002FBD RID: 12221
		// (get) Token: 0x0600C587 RID: 50567 RVA: 0x003019A4 File Offset: 0x002FFBA4
		public int DescParamLength
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

		// Token: 0x17002FBE RID: 12222
		// (get) Token: 0x0600C588 RID: 50568 RVA: 0x003019D0 File Offset: 0x002FFBD0
		public int OverviewId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C589 RID: 50569 RVA: 0x00301A10 File Offset: 0x002FFC10
		public int OverviewShowParam(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002FBF RID: 12223
		// (get) Token: 0x0600C58A RID: 50570 RVA: 0x00301A50 File Offset: 0x002FFC50
		public int OverviewShowParamLength
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

		// Token: 0x0600C58B RID: 50571 RVA: 0x00301A7C File Offset: 0x002FFC7C
		public Span<int> GetOverviewShowParamBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600C58C RID: 50572 RVA: 0x00301A8C File Offset: 0x002FFC8C
		public int[] GetOverviewShowParamArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x0600C58D RID: 50573 RVA: 0x00301AA4 File Offset: 0x002FFCA4
		[NullableContext(1)]
		public string[] DescParam()
		{
			return this.DescParamIter().ToArray<string>();
		}

		// Token: 0x0600C58E RID: 50574 RVA: 0x00301AB1 File Offset: 0x002FFCB1
		[NullableContext(1)]
		public IEnumerable<string> DescParamIter()
		{
			RogueHotEntry.<DescParamIter>d__35 <DescParamIter>d__ = new RogueHotEntry.<DescParamIter>d__35(-2);
			<DescParamIter>d__.<>3__<>4__this = this;
			return <DescParamIter>d__;
		}

		// Token: 0x0600C58F RID: 50575 RVA: 0x00301AC6 File Offset: 0x002FFCC6
		[NullableContext(1)]
		public int[] OverviewShowParam()
		{
			return this.GetOverviewShowParamArray();
		}

		// Token: 0x0600C590 RID: 50576 RVA: 0x00301ACE File Offset: 0x002FFCCE
		[NullableContext(1)]
		public IEnumerable<int> OverviewShowParamIter()
		{
			RogueHotEntry.<OverviewShowParamIter>d__37 <OverviewShowParamIter>d__ = new RogueHotEntry.<OverviewShowParamIter>d__37(-2);
			<OverviewShowParamIter>d__.<>3__<>4__this = this;
			return <OverviewShowParamIter>d__;
		}

		// Token: 0x040056A6 RID: 22182
		private Table __p;
	}
}
