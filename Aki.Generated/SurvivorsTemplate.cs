using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200110A RID: 4362
	public struct SurvivorsTemplate : IFlatbufferObject
	{
		// Token: 0x17003949 RID: 14665
		// (get) Token: 0x0600DBC1 RID: 56257 RVA: 0x00326DC5 File Offset: 0x00324FC5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DBC2 RID: 56258 RVA: 0x00326DD2 File Offset: 0x00324FD2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DBC3 RID: 56259 RVA: 0x00326DDC File Offset: 0x00324FDC
		public static SurvivorsTemplate GetRootAsSurvivorsTemplate(ByteBuffer _bb)
		{
			return SurvivorsTemplate.GetRootAsSurvivorsTemplate(_bb, default(SurvivorsTemplate));
		}

		// Token: 0x0600DBC4 RID: 56260 RVA: 0x00326DF8 File Offset: 0x00324FF8
		public static SurvivorsTemplate GetRootAsSurvivorsTemplate(ByteBuffer _bb, SurvivorsTemplate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DBC5 RID: 56261 RVA: 0x00326E15 File Offset: 0x00325015
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DBC6 RID: 56262 RVA: 0x00326E24 File Offset: 0x00325024
		public SurvivorsTemplate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700394A RID: 14666
		// (get) Token: 0x0600DBC7 RID: 56263 RVA: 0x00326E34 File Offset: 0x00325034
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

		// Token: 0x1700394B RID: 14667
		// (get) Token: 0x0600DBC8 RID: 56264 RVA: 0x00326E70 File Offset: 0x00325070
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

		// Token: 0x0600DBC9 RID: 56265 RVA: 0x00326EA7 File Offset: 0x003250A7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600DBCA RID: 56266 RVA: 0x00326EB6 File Offset: 0x003250B6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700394C RID: 14668
		// (get) Token: 0x0600DBCB RID: 56267 RVA: 0x00326ED0 File Offset: 0x003250D0
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

		// Token: 0x0600DBCC RID: 56268 RVA: 0x00326F07 File Offset: 0x00325107
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600DBCD RID: 56269 RVA: 0x00326F16 File Offset: 0x00325116
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600DBCE RID: 56270 RVA: 0x00326F30 File Offset: 0x00325130
		public string DescArgs(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700394D RID: 14669
		// (get) Token: 0x0600DBCF RID: 56271 RVA: 0x00326F6C File Offset: 0x0032516C
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

		// Token: 0x1700394E RID: 14670
		// (get) Token: 0x0600DBD0 RID: 56272 RVA: 0x00326F98 File Offset: 0x00325198
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

		// Token: 0x1700394F RID: 14671
		// (get) Token: 0x0600DBD1 RID: 56273 RVA: 0x00326FD8 File Offset: 0x003251D8
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

		// Token: 0x0600DBD2 RID: 56274 RVA: 0x00327018 File Offset: 0x00325218
		public int InitBuffs(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003950 RID: 14672
		// (get) Token: 0x0600DBD3 RID: 56275 RVA: 0x00327058 File Offset: 0x00325258
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

		// Token: 0x0600DBD4 RID: 56276 RVA: 0x00327084 File Offset: 0x00325284
		public Span<int> GetInitBuffsBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600DBD5 RID: 56277 RVA: 0x00327094 File Offset: 0x00325294
		public int[] GetInitBuffsArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x0600DBD6 RID: 56278 RVA: 0x003270AC File Offset: 0x003252AC
		public int Deathrattles(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003951 RID: 14673
		// (get) Token: 0x0600DBD7 RID: 56279 RVA: 0x003270EC File Offset: 0x003252EC
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

		// Token: 0x0600DBD8 RID: 56280 RVA: 0x00327118 File Offset: 0x00325318
		public Span<int> GetDeathrattlesBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600DBD9 RID: 56281 RVA: 0x00327128 File Offset: 0x00325328
		public int[] GetDeathrattlesArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x0600DBDA RID: 56282 RVA: 0x00327140 File Offset: 0x00325340
		public int Tag(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003952 RID: 14674
		// (get) Token: 0x0600DBDB RID: 56283 RVA: 0x00327180 File Offset: 0x00325380
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

		// Token: 0x0600DBDC RID: 56284 RVA: 0x003271AC File Offset: 0x003253AC
		public Span<int> GetTagBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600DBDD RID: 56285 RVA: 0x003271BC File Offset: 0x003253BC
		public int[] GetTagArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x0600DBDE RID: 56286 RVA: 0x003271D4 File Offset: 0x003253D4
		public int AttrShow(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003953 RID: 14675
		// (get) Token: 0x0600DBDF RID: 56287 RVA: 0x00327214 File Offset: 0x00325414
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

		// Token: 0x0600DBE0 RID: 56288 RVA: 0x00327240 File Offset: 0x00325440
		public Span<int> GetAttrShowBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600DBE1 RID: 56289 RVA: 0x00327250 File Offset: 0x00325450
		public int[] GetAttrShowArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x0600DBE2 RID: 56290 RVA: 0x00327268 File Offset: 0x00325468
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AttrShowIter()或GetAttrShowBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] AttrShow()
		{
			SurvivorsTemplate survivorsTemplate = this;
			return survivorsTemplate.GetAttrShowArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600DBE3 RID: 56291 RVA: 0x0032728C File Offset: 0x0032548C
		[NullableContext(1)]
		public readonly IEnumerable<int> AttrShowIter()
		{
			SurvivorsTemplate.<AttrShowIter>d__46 <AttrShowIter>d__ = new SurvivorsTemplate.<AttrShowIter>d__46(-2);
			<AttrShowIter>d__.<>3__<>4__this = this;
			return <AttrShowIter>d__;
		}

		// Token: 0x0600DBE4 RID: 56292 RVA: 0x003272A4 File Offset: 0x003254A4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DeathrattlesIter()或GetDeathrattlesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Deathrattles()
		{
			SurvivorsTemplate survivorsTemplate = this;
			return survivorsTemplate.GetDeathrattlesArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600DBE5 RID: 56293 RVA: 0x003272C8 File Offset: 0x003254C8
		[NullableContext(1)]
		public readonly IEnumerable<int> DeathrattlesIter()
		{
			SurvivorsTemplate.<DeathrattlesIter>d__48 <DeathrattlesIter>d__ = new SurvivorsTemplate.<DeathrattlesIter>d__48(-2);
			<DeathrattlesIter>d__.<>3__<>4__this = this;
			return <DeathrattlesIter>d__;
		}

		// Token: 0x0600DBE6 RID: 56294 RVA: 0x003272DD File Offset: 0x003254DD
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DescArgsIter()或GetDescArgsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DescArgs()
		{
			return this.DescArgsIter().ToArray<string>();
		}

		// Token: 0x0600DBE7 RID: 56295 RVA: 0x003272EA File Offset: 0x003254EA
		[NullableContext(1)]
		public readonly IEnumerable<string> DescArgsIter()
		{
			SurvivorsTemplate.<DescArgsIter>d__50 <DescArgsIter>d__ = new SurvivorsTemplate.<DescArgsIter>d__50(-2);
			<DescArgsIter>d__.<>3__<>4__this = this;
			return <DescArgsIter>d__;
		}

		// Token: 0x0600DBE8 RID: 56296 RVA: 0x00327300 File Offset: 0x00325500
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用InitBuffsIter()或GetInitBuffsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] InitBuffs()
		{
			SurvivorsTemplate survivorsTemplate = this;
			return survivorsTemplate.GetInitBuffsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600DBE9 RID: 56297 RVA: 0x00327324 File Offset: 0x00325524
		[NullableContext(1)]
		public readonly IEnumerable<int> InitBuffsIter()
		{
			SurvivorsTemplate.<InitBuffsIter>d__52 <InitBuffsIter>d__ = new SurvivorsTemplate.<InitBuffsIter>d__52(-2);
			<InitBuffsIter>d__.<>3__<>4__this = this;
			return <InitBuffsIter>d__;
		}

		// Token: 0x0600DBEA RID: 56298 RVA: 0x0032733C File Offset: 0x0032553C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TagIter()或GetTagBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Tag()
		{
			SurvivorsTemplate survivorsTemplate = this;
			return survivorsTemplate.GetTagArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600DBEB RID: 56299 RVA: 0x00327360 File Offset: 0x00325560
		[NullableContext(1)]
		public readonly IEnumerable<int> TagIter()
		{
			SurvivorsTemplate.<TagIter>d__54 <TagIter>d__ = new SurvivorsTemplate.<TagIter>d__54(-2);
			<TagIter>d__.<>3__<>4__this = this;
			return <TagIter>d__;
		}

		// Token: 0x04005244 RID: 21060
		private Table __p;
	}
}
