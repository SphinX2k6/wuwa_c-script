using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200114E RID: 4430
	public struct TrailPhantomProp : IFlatbufferObject
	{
		// Token: 0x17003B4B RID: 15179
		// (get) Token: 0x0600E121 RID: 57633 RVA: 0x00333135 File Offset: 0x00331335
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E122 RID: 57634 RVA: 0x00333142 File Offset: 0x00331342
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E123 RID: 57635 RVA: 0x0033314C File Offset: 0x0033134C
		public static TrailPhantomProp GetRootAsTrailPhantomProp(ByteBuffer _bb)
		{
			return TrailPhantomProp.GetRootAsTrailPhantomProp(_bb, default(TrailPhantomProp));
		}

		// Token: 0x0600E124 RID: 57636 RVA: 0x00333168 File Offset: 0x00331368
		public static TrailPhantomProp GetRootAsTrailPhantomProp(ByteBuffer _bb, TrailPhantomProp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E125 RID: 57637 RVA: 0x00333185 File Offset: 0x00331385
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E126 RID: 57638 RVA: 0x00333194 File Offset: 0x00331394
		public TrailPhantomProp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003B4C RID: 15180
		// (get) Token: 0x0600E127 RID: 57639 RVA: 0x003331A4 File Offset: 0x003313A4
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

		// Token: 0x17003B4D RID: 15181
		// (get) Token: 0x0600E128 RID: 57640 RVA: 0x003331E0 File Offset: 0x003313E0
		public int Level
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

		// Token: 0x17003B4E RID: 15182
		// (get) Token: 0x0600E129 RID: 57641 RVA: 0x0033321C File Offset: 0x0033141C
		public ConfigPropValue? MainProp
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new ConfigPropValue?(default(ConfigPropValue).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17003B4F RID: 15183
		// (get) Token: 0x0600E12A RID: 57642 RVA: 0x0033327C File Offset: 0x0033147C
		public ConfigPropValue? BreachProp
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new ConfigPropValue?(default(ConfigPropValue).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0600E12B RID: 57643 RVA: 0x003332DC File Offset: 0x003314DC
		public ConfigPropValue? SubProp(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new ConfigPropValue?(default(ConfigPropValue).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003B50 RID: 15184
		// (get) Token: 0x0600E12C RID: 57644 RVA: 0x00333340 File Offset: 0x00331540
		public int SubPropLength
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

		// Token: 0x0600E12D RID: 57645 RVA: 0x0033336C File Offset: 0x0033156C
		public int MainProps(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003B51 RID: 15185
		// (get) Token: 0x0600E12E RID: 57646 RVA: 0x003333AC File Offset: 0x003315AC
		public int MainPropsLength
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

		// Token: 0x0600E12F RID: 57647 RVA: 0x003333D8 File Offset: 0x003315D8
		public Span<int> GetMainPropsBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600E130 RID: 57648 RVA: 0x003333E8 File Offset: 0x003315E8
		public int[] GetMainPropsArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17003B52 RID: 15186
		// (get) Token: 0x0600E131 RID: 57649 RVA: 0x00333400 File Offset: 0x00331600
		public int MainPropGrowth
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E132 RID: 57650 RVA: 0x00333440 File Offset: 0x00331640
		public IntArray? SubProps(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003B53 RID: 15187
		// (get) Token: 0x0600E133 RID: 57651 RVA: 0x003334A4 File Offset: 0x003316A4
		public int SubPropsLength
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

		// Token: 0x0600E134 RID: 57652 RVA: 0x003334D0 File Offset: 0x003316D0
		public int SubPropList(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003B54 RID: 15188
		// (get) Token: 0x0600E135 RID: 57653 RVA: 0x00333510 File Offset: 0x00331710
		public int SubPropListLength
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

		// Token: 0x0600E136 RID: 57654 RVA: 0x0033353C File Offset: 0x0033173C
		public Span<int> GetSubPropListBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600E137 RID: 57655 RVA: 0x0033354C File Offset: 0x0033174C
		public int[] GetSubPropListArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x17003B55 RID: 15189
		// (get) Token: 0x0600E138 RID: 57656 RVA: 0x00333564 File Offset: 0x00331764
		public int FetterGroupId
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003B56 RID: 15190
		// (get) Token: 0x0600E139 RID: 57657 RVA: 0x003335A4 File Offset: 0x003317A4
		public int SkinItemId
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

		// Token: 0x0600E13A RID: 57658 RVA: 0x003335E4 File Offset: 0x003317E4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MainPropsIter()或GetMainPropsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] MainProps()
		{
			TrailPhantomProp trailPhantomProp = this;
			return trailPhantomProp.GetMainPropsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E13B RID: 57659 RVA: 0x00333608 File Offset: 0x00331808
		[NullableContext(1)]
		public readonly IEnumerable<int> MainPropsIter()
		{
			TrailPhantomProp.<MainPropsIter>d__39 <MainPropsIter>d__ = new TrailPhantomProp.<MainPropsIter>d__39(-2);
			<MainPropsIter>d__.<>3__<>4__this = this;
			return <MainPropsIter>d__;
		}

		// Token: 0x0600E13C RID: 57660 RVA: 0x0033361D File Offset: 0x0033181D
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SubPropIter()或GetSubPropBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly ConfigPropValue[] SubProp()
		{
			return this.SubPropIter().ToArray<ConfigPropValue>();
		}

		// Token: 0x0600E13D RID: 57661 RVA: 0x0033362A File Offset: 0x0033182A
		[NullableContext(1)]
		public readonly IEnumerable<ConfigPropValue> SubPropIter()
		{
			TrailPhantomProp.<SubPropIter>d__41 <SubPropIter>d__ = new TrailPhantomProp.<SubPropIter>d__41(-2);
			<SubPropIter>d__.<>3__<>4__this = this;
			return <SubPropIter>d__;
		}

		// Token: 0x0600E13E RID: 57662 RVA: 0x00333640 File Offset: 0x00331840
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SubPropListIter()或GetSubPropListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SubPropList()
		{
			TrailPhantomProp trailPhantomProp = this;
			return trailPhantomProp.GetSubPropListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E13F RID: 57663 RVA: 0x00333664 File Offset: 0x00331864
		[NullableContext(1)]
		public readonly IEnumerable<int> SubPropListIter()
		{
			TrailPhantomProp.<SubPropListIter>d__43 <SubPropListIter>d__ = new TrailPhantomProp.<SubPropListIter>d__43(-2);
			<SubPropListIter>d__.<>3__<>4__this = this;
			return <SubPropListIter>d__;
		}

		// Token: 0x0600E140 RID: 57664 RVA: 0x00333679 File Offset: 0x00331879
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SubPropsIter()或GetSubPropsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly IntArray[] SubProps()
		{
			return this.SubPropsIter().ToArray<IntArray>();
		}

		// Token: 0x0600E141 RID: 57665 RVA: 0x00333686 File Offset: 0x00331886
		[NullableContext(1)]
		public readonly IEnumerable<IntArray> SubPropsIter()
		{
			TrailPhantomProp.<SubPropsIter>d__45 <SubPropsIter>d__ = new TrailPhantomProp.<SubPropsIter>d__45(-2);
			<SubPropsIter>d__.<>3__<>4__this = this;
			return <SubPropsIter>d__;
		}

		// Token: 0x04005293 RID: 21139
		private Table __p;
	}
}
