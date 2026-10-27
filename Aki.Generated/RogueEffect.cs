using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FDF RID: 4063
	public struct RogueEffect : IFlatbufferObject
	{
		// Token: 0x17002F24 RID: 12068
		// (get) Token: 0x0600BEE3 RID: 48867 RVA: 0x002E4845 File Offset: 0x002E2A45
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BEE4 RID: 48868 RVA: 0x002E4852 File Offset: 0x002E2A52
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BEE5 RID: 48869 RVA: 0x002E485C File Offset: 0x002E2A5C
		public static RogueEffect GetRootAsRogueEffect(ByteBuffer _bb)
		{
			return RogueEffect.GetRootAsRogueEffect(_bb, default(RogueEffect));
		}

		// Token: 0x0600BEE6 RID: 48870 RVA: 0x002E4878 File Offset: 0x002E2A78
		public static RogueEffect GetRootAsRogueEffect(ByteBuffer _bb, RogueEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BEE7 RID: 48871 RVA: 0x002E4895 File Offset: 0x002E2A95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BEE8 RID: 48872 RVA: 0x002E48A4 File Offset: 0x002E2AA4
		public RogueEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002F25 RID: 12069
		// (get) Token: 0x0600BEE9 RID: 48873 RVA: 0x002E48B4 File Offset: 0x002E2AB4
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

		// Token: 0x17002F26 RID: 12070
		// (get) Token: 0x0600BEEA RID: 48874 RVA: 0x002E48F0 File Offset: 0x002E2AF0
		public int MainEffectType
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

		// Token: 0x17002F27 RID: 12071
		// (get) Token: 0x0600BEEB RID: 48875 RVA: 0x002E492C File Offset: 0x002E2B2C
		public int Condition
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

		// Token: 0x0600BEEC RID: 48876 RVA: 0x002E4968 File Offset: 0x002E2B68
		public int ConditionArgs(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002F28 RID: 12072
		// (get) Token: 0x0600BEED RID: 48877 RVA: 0x002E49A8 File Offset: 0x002E2BA8
		public int ConditionArgsLength
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

		// Token: 0x0600BEEE RID: 48878 RVA: 0x002E49D4 File Offset: 0x002E2BD4
		public Span<int> GetConditionArgsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600BEEF RID: 48879 RVA: 0x002E49E4 File Offset: 0x002E2BE4
		public int[] GetConditionArgsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17002F29 RID: 12073
		// (get) Token: 0x0600BEF0 RID: 48880 RVA: 0x002E49FC File Offset: 0x002E2BFC
		public int Count
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

		// Token: 0x17002F2A RID: 12074
		// (get) Token: 0x0600BEF1 RID: 48881 RVA: 0x002E4A3C File Offset: 0x002E2C3C
		public int RoomCount
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

		// Token: 0x0600BEF2 RID: 48882 RVA: 0x002E4A7C File Offset: 0x002E2C7C
		public long BuffArray1(int j)
		{
			int num = this.__p.__offset(16);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17002F2B RID: 12075
		// (get) Token: 0x0600BEF3 RID: 48883 RVA: 0x002E4AC8 File Offset: 0x002E2CC8
		public int BuffArray1Length
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

		// Token: 0x0600BEF4 RID: 48884 RVA: 0x002E4AF4 File Offset: 0x002E2CF4
		public Span<long> GetBuffArray1Bytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(16, 8));
		}

		// Token: 0x0600BEF5 RID: 48885 RVA: 0x002E4B09 File Offset: 0x002E2D09
		public long[] GetBuffArray1Array()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(16) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x0600BEF6 RID: 48886 RVA: 0x002E4B48 File Offset: 0x002E2D48
		public string ExtraEffectTypeArray1(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002F2C RID: 12076
		// (get) Token: 0x0600BEF7 RID: 48887 RVA: 0x002E4B84 File Offset: 0x002E2D84
		public int ExtraEffectTypeArray1Length
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

		// Token: 0x0600BEF8 RID: 48888 RVA: 0x002E4BB0 File Offset: 0x002E2DB0
		public string ExtraEffectTypeArgsArray1(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002F2D RID: 12077
		// (get) Token: 0x0600BEF9 RID: 48889 RVA: 0x002E4BEC File Offset: 0x002E2DEC
		public int ExtraEffectTypeArgsArray1Length
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

		// Token: 0x0600BEFA RID: 48890 RVA: 0x002E4C18 File Offset: 0x002E2E18
		public long BuffArray2(int j)
		{
			int num = this.__p.__offset(22);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17002F2E RID: 12078
		// (get) Token: 0x0600BEFB RID: 48891 RVA: 0x002E4C64 File Offset: 0x002E2E64
		public int BuffArray2Length
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

		// Token: 0x0600BEFC RID: 48892 RVA: 0x002E4C90 File Offset: 0x002E2E90
		public Span<long> GetBuffArray2Bytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(22, 8));
		}

		// Token: 0x0600BEFD RID: 48893 RVA: 0x002E4CA5 File Offset: 0x002E2EA5
		public long[] GetBuffArray2Array()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(22) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x0600BEFE RID: 48894 RVA: 0x002E4CE4 File Offset: 0x002E2EE4
		public string ExtraEffectTypeArray2(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002F2F RID: 12079
		// (get) Token: 0x0600BEFF RID: 48895 RVA: 0x002E4D20 File Offset: 0x002E2F20
		public int ExtraEffectTypeArray2Length
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600BF00 RID: 48896 RVA: 0x002E4D4C File Offset: 0x002E2F4C
		public string ExtraEffectTypeArgsArray2(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002F30 RID: 12080
		// (get) Token: 0x0600BF01 RID: 48897 RVA: 0x002E4D88 File Offset: 0x002E2F88
		public int ExtraEffectTypeArgsArray2Length
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600BF02 RID: 48898 RVA: 0x002E4DB4 File Offset: 0x002E2FB4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BuffArray1Iter()或GetBuffArray1Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] BuffArray1()
		{
			RogueEffect rogueEffect = this;
			return rogueEffect.GetBuffArray1Array() ?? Array.Empty<long>();
		}

		// Token: 0x0600BF03 RID: 48899 RVA: 0x002E4DD8 File Offset: 0x002E2FD8
		[NullableContext(1)]
		public readonly IEnumerable<long> BuffArray1Iter()
		{
			RogueEffect.<BuffArray1Iter>d__46 <BuffArray1Iter>d__ = new RogueEffect.<BuffArray1Iter>d__46(-2);
			<BuffArray1Iter>d__.<>3__<>4__this = this;
			return <BuffArray1Iter>d__;
		}

		// Token: 0x0600BF04 RID: 48900 RVA: 0x002E4DF0 File Offset: 0x002E2FF0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BuffArray2Iter()或GetBuffArray2Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] BuffArray2()
		{
			RogueEffect rogueEffect = this;
			return rogueEffect.GetBuffArray2Array() ?? Array.Empty<long>();
		}

		// Token: 0x0600BF05 RID: 48901 RVA: 0x002E4E14 File Offset: 0x002E3014
		[NullableContext(1)]
		public readonly IEnumerable<long> BuffArray2Iter()
		{
			RogueEffect.<BuffArray2Iter>d__48 <BuffArray2Iter>d__ = new RogueEffect.<BuffArray2Iter>d__48(-2);
			<BuffArray2Iter>d__.<>3__<>4__this = this;
			return <BuffArray2Iter>d__;
		}

		// Token: 0x0600BF06 RID: 48902 RVA: 0x002E4E2C File Offset: 0x002E302C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ConditionArgsIter()或GetConditionArgsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ConditionArgs()
		{
			RogueEffect rogueEffect = this;
			return rogueEffect.GetConditionArgsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600BF07 RID: 48903 RVA: 0x002E4E50 File Offset: 0x002E3050
		[NullableContext(1)]
		public readonly IEnumerable<int> ConditionArgsIter()
		{
			RogueEffect.<ConditionArgsIter>d__50 <ConditionArgsIter>d__ = new RogueEffect.<ConditionArgsIter>d__50(-2);
			<ConditionArgsIter>d__.<>3__<>4__this = this;
			return <ConditionArgsIter>d__;
		}

		// Token: 0x0600BF08 RID: 48904 RVA: 0x002E4E65 File Offset: 0x002E3065
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ExtraEffectTypeArgsArray1Iter()或GetExtraEffectTypeArgsArray1Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ExtraEffectTypeArgsArray1()
		{
			return this.ExtraEffectTypeArgsArray1Iter().ToArray<string>();
		}

		// Token: 0x0600BF09 RID: 48905 RVA: 0x002E4E72 File Offset: 0x002E3072
		[NullableContext(1)]
		public readonly IEnumerable<string> ExtraEffectTypeArgsArray1Iter()
		{
			RogueEffect.<ExtraEffectTypeArgsArray1Iter>d__52 <ExtraEffectTypeArgsArray1Iter>d__ = new RogueEffect.<ExtraEffectTypeArgsArray1Iter>d__52(-2);
			<ExtraEffectTypeArgsArray1Iter>d__.<>3__<>4__this = this;
			return <ExtraEffectTypeArgsArray1Iter>d__;
		}

		// Token: 0x0600BF0A RID: 48906 RVA: 0x002E4E87 File Offset: 0x002E3087
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ExtraEffectTypeArgsArray2Iter()或GetExtraEffectTypeArgsArray2Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ExtraEffectTypeArgsArray2()
		{
			return this.ExtraEffectTypeArgsArray2Iter().ToArray<string>();
		}

		// Token: 0x0600BF0B RID: 48907 RVA: 0x002E4E94 File Offset: 0x002E3094
		[NullableContext(1)]
		public readonly IEnumerable<string> ExtraEffectTypeArgsArray2Iter()
		{
			RogueEffect.<ExtraEffectTypeArgsArray2Iter>d__54 <ExtraEffectTypeArgsArray2Iter>d__ = new RogueEffect.<ExtraEffectTypeArgsArray2Iter>d__54(-2);
			<ExtraEffectTypeArgsArray2Iter>d__.<>3__<>4__this = this;
			return <ExtraEffectTypeArgsArray2Iter>d__;
		}

		// Token: 0x0600BF0C RID: 48908 RVA: 0x002E4EA9 File Offset: 0x002E30A9
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ExtraEffectTypeArray1Iter()或GetExtraEffectTypeArray1Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ExtraEffectTypeArray1()
		{
			return this.ExtraEffectTypeArray1Iter().ToArray<string>();
		}

		// Token: 0x0600BF0D RID: 48909 RVA: 0x002E4EB6 File Offset: 0x002E30B6
		[NullableContext(1)]
		public readonly IEnumerable<string> ExtraEffectTypeArray1Iter()
		{
			RogueEffect.<ExtraEffectTypeArray1Iter>d__56 <ExtraEffectTypeArray1Iter>d__ = new RogueEffect.<ExtraEffectTypeArray1Iter>d__56(-2);
			<ExtraEffectTypeArray1Iter>d__.<>3__<>4__this = this;
			return <ExtraEffectTypeArray1Iter>d__;
		}

		// Token: 0x0600BF0E RID: 48910 RVA: 0x002E4ECB File Offset: 0x002E30CB
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ExtraEffectTypeArray2Iter()或GetExtraEffectTypeArray2Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ExtraEffectTypeArray2()
		{
			return this.ExtraEffectTypeArray2Iter().ToArray<string>();
		}

		// Token: 0x0600BF0F RID: 48911 RVA: 0x002E4ED8 File Offset: 0x002E30D8
		[NullableContext(1)]
		public readonly IEnumerable<string> ExtraEffectTypeArray2Iter()
		{
			RogueEffect.<ExtraEffectTypeArray2Iter>d__58 <ExtraEffectTypeArray2Iter>d__ = new RogueEffect.<ExtraEffectTypeArray2Iter>d__58(-2);
			<ExtraEffectTypeArray2Iter>d__.<>3__<>4__this = this;
			return <ExtraEffectTypeArray2Iter>d__;
		}

		// Token: 0x040050BC RID: 20668
		private Table __p;
	}
}
