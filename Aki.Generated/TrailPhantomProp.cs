using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001284 RID: 4740
	public struct TrailPhantomProp : IFlatbufferObject
	{
		// Token: 0x17003EAF RID: 16047
		// (get) Token: 0x0600EE8F RID: 61071 RVA: 0x0035E521 File Offset: 0x0035C721
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EE90 RID: 61072 RVA: 0x0035E52E File Offset: 0x0035C72E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EE91 RID: 61073 RVA: 0x0035E538 File Offset: 0x0035C738
		public static TrailPhantomProp GetRootAsTrailPhantomProp(ByteBuffer _bb)
		{
			return TrailPhantomProp.GetRootAsTrailPhantomProp(_bb, default(TrailPhantomProp));
		}

		// Token: 0x0600EE92 RID: 61074 RVA: 0x0035E554 File Offset: 0x0035C754
		public static TrailPhantomProp GetRootAsTrailPhantomProp(ByteBuffer _bb, TrailPhantomProp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EE93 RID: 61075 RVA: 0x0035E571 File Offset: 0x0035C771
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EE94 RID: 61076 RVA: 0x0035E580 File Offset: 0x0035C780
		public TrailPhantomProp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003EB0 RID: 16048
		// (get) Token: 0x0600EE95 RID: 61077 RVA: 0x0035E590 File Offset: 0x0035C790
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

		// Token: 0x17003EB1 RID: 16049
		// (get) Token: 0x0600EE96 RID: 61078 RVA: 0x0035E5CC File Offset: 0x0035C7CC
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

		// Token: 0x17003EB2 RID: 16050
		// (get) Token: 0x0600EE97 RID: 61079 RVA: 0x0035E608 File Offset: 0x0035C808
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

		// Token: 0x17003EB3 RID: 16051
		// (get) Token: 0x0600EE98 RID: 61080 RVA: 0x0035E668 File Offset: 0x0035C868
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

		// Token: 0x0600EE99 RID: 61081 RVA: 0x0035E6C8 File Offset: 0x0035C8C8
		public ConfigPropValue? SubProp(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new ConfigPropValue?(default(ConfigPropValue).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003EB4 RID: 16052
		// (get) Token: 0x0600EE9A RID: 61082 RVA: 0x0035E72C File Offset: 0x0035C92C
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

		// Token: 0x0600EE9B RID: 61083 RVA: 0x0035E758 File Offset: 0x0035C958
		public int MainProps(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003EB5 RID: 16053
		// (get) Token: 0x0600EE9C RID: 61084 RVA: 0x0035E798 File Offset: 0x0035C998
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

		// Token: 0x0600EE9D RID: 61085 RVA: 0x0035E7C4 File Offset: 0x0035C9C4
		public Span<int> GetMainPropsBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600EE9E RID: 61086 RVA: 0x0035E7D4 File Offset: 0x0035C9D4
		public int[] GetMainPropsArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17003EB6 RID: 16054
		// (get) Token: 0x0600EE9F RID: 61087 RVA: 0x0035E7EC File Offset: 0x0035C9EC
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

		// Token: 0x0600EEA0 RID: 61088 RVA: 0x0035E82C File Offset: 0x0035CA2C
		public IntArray? SubProps(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003EB7 RID: 16055
		// (get) Token: 0x0600EEA1 RID: 61089 RVA: 0x0035E890 File Offset: 0x0035CA90
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

		// Token: 0x0600EEA2 RID: 61090 RVA: 0x0035E8BC File Offset: 0x0035CABC
		public int SubPropList(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003EB8 RID: 16056
		// (get) Token: 0x0600EEA3 RID: 61091 RVA: 0x0035E8FC File Offset: 0x0035CAFC
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

		// Token: 0x0600EEA4 RID: 61092 RVA: 0x0035E928 File Offset: 0x0035CB28
		public Span<int> GetSubPropListBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600EEA5 RID: 61093 RVA: 0x0035E938 File Offset: 0x0035CB38
		public int[] GetSubPropListArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x17003EB9 RID: 16057
		// (get) Token: 0x0600EEA6 RID: 61094 RVA: 0x0035E950 File Offset: 0x0035CB50
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

		// Token: 0x17003EBA RID: 16058
		// (get) Token: 0x0600EEA7 RID: 61095 RVA: 0x0035E990 File Offset: 0x0035CB90
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

		// Token: 0x0600EEA8 RID: 61096 RVA: 0x0035E9CD File Offset: 0x0035CBCD
		[NullableContext(1)]
		public int[] MainProps()
		{
			return this.GetMainPropsArray();
		}

		// Token: 0x0600EEA9 RID: 61097 RVA: 0x0035E9D5 File Offset: 0x0035CBD5
		[NullableContext(1)]
		public IEnumerable<int> MainPropsIter()
		{
			TrailPhantomProp.<MainPropsIter>d__39 <MainPropsIter>d__ = new TrailPhantomProp.<MainPropsIter>d__39(-2);
			<MainPropsIter>d__.<>3__<>4__this = this;
			return <MainPropsIter>d__;
		}

		// Token: 0x0600EEAA RID: 61098 RVA: 0x0035E9EA File Offset: 0x0035CBEA
		[NullableContext(1)]
		public ConfigPropValue[] SubProp()
		{
			return this.SubPropIter().ToArray<ConfigPropValue>();
		}

		// Token: 0x0600EEAB RID: 61099 RVA: 0x0035E9F7 File Offset: 0x0035CBF7
		[NullableContext(1)]
		public IEnumerable<ConfigPropValue> SubPropIter()
		{
			TrailPhantomProp.<SubPropIter>d__41 <SubPropIter>d__ = new TrailPhantomProp.<SubPropIter>d__41(-2);
			<SubPropIter>d__.<>3__<>4__this = this;
			return <SubPropIter>d__;
		}

		// Token: 0x0600EEAC RID: 61100 RVA: 0x0035EA0C File Offset: 0x0035CC0C
		[NullableContext(1)]
		public int[] SubPropList()
		{
			return this.GetSubPropListArray();
		}

		// Token: 0x0600EEAD RID: 61101 RVA: 0x0035EA14 File Offset: 0x0035CC14
		[NullableContext(1)]
		public IEnumerable<int> SubPropListIter()
		{
			TrailPhantomProp.<SubPropListIter>d__43 <SubPropListIter>d__ = new TrailPhantomProp.<SubPropListIter>d__43(-2);
			<SubPropListIter>d__.<>3__<>4__this = this;
			return <SubPropListIter>d__;
		}

		// Token: 0x0600EEAE RID: 61102 RVA: 0x0035EA29 File Offset: 0x0035CC29
		[NullableContext(1)]
		public IntArray[] SubProps()
		{
			return this.SubPropsIter().ToArray<IntArray>();
		}

		// Token: 0x0600EEAF RID: 61103 RVA: 0x0035EA36 File Offset: 0x0035CC36
		[NullableContext(1)]
		public IEnumerable<IntArray> SubPropsIter()
		{
			TrailPhantomProp.<SubPropsIter>d__45 <SubPropsIter>d__ = new TrailPhantomProp.<SubPropsIter>d__45(-2);
			<SubPropsIter>d__.<>3__<>4__this = this;
			return <SubPropsIter>d__;
		}

		// Token: 0x040058D6 RID: 22742
		private Table __p;
	}
}
