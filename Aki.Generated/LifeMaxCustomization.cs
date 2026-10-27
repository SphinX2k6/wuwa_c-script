using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DC4 RID: 3524
	public struct LifeMaxCustomization : IFlatbufferObject
	{
		// Token: 0x17001CC0 RID: 7360
		// (get) Token: 0x06008D98 RID: 36248 RVA: 0x00276AD1 File Offset: 0x00274CD1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008D99 RID: 36249 RVA: 0x00276ADE File Offset: 0x00274CDE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008D9A RID: 36250 RVA: 0x00276AE8 File Offset: 0x00274CE8
		public static LifeMaxCustomization GetRootAsLifeMaxCustomization(ByteBuffer _bb)
		{
			return LifeMaxCustomization.GetRootAsLifeMaxCustomization(_bb, default(LifeMaxCustomization));
		}

		// Token: 0x06008D9B RID: 36251 RVA: 0x00276B04 File Offset: 0x00274D04
		public static LifeMaxCustomization GetRootAsLifeMaxCustomization(ByteBuffer _bb, LifeMaxCustomization obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008D9C RID: 36252 RVA: 0x00276B21 File Offset: 0x00274D21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008D9D RID: 36253 RVA: 0x00276B30 File Offset: 0x00274D30
		public LifeMaxCustomization __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001CC1 RID: 7361
		// (get) Token: 0x06008D9E RID: 36254 RVA: 0x00276B40 File Offset: 0x00274D40
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

		// Token: 0x17001CC2 RID: 7362
		// (get) Token: 0x06008D9F RID: 36255 RVA: 0x00276B7C File Offset: 0x00274D7C
		public int LifeCustomType
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

		// Token: 0x17001CC3 RID: 7363
		// (get) Token: 0x06008DA0 RID: 36256 RVA: 0x00276BB8 File Offset: 0x00274DB8
		public int SingleTubeLife
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

		// Token: 0x17001CC4 RID: 7364
		// (get) Token: 0x06008DA1 RID: 36257 RVA: 0x00276BF4 File Offset: 0x00274DF4
		public int LifeCount
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

		// Token: 0x17001CC5 RID: 7365
		// (get) Token: 0x06008DA2 RID: 36258 RVA: 0x00276C34 File Offset: 0x00274E34
		public int RageMaxCustom
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

		// Token: 0x17001CC6 RID: 7366
		// (get) Token: 0x06008DA3 RID: 36259 RVA: 0x00276C74 File Offset: 0x00274E74
		public int InitLifeCount
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

		// Token: 0x06008DA4 RID: 36260 RVA: 0x00276CB4 File Offset: 0x00274EB4
		public int SingleTubeLifeArr(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001CC7 RID: 7367
		// (get) Token: 0x06008DA5 RID: 36261 RVA: 0x00276CF4 File Offset: 0x00274EF4
		public int SingleTubeLifeArrLength
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

		// Token: 0x06008DA6 RID: 36262 RVA: 0x00276D20 File Offset: 0x00274F20
		public Span<int> GetSingleTubeLifeArrBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x06008DA7 RID: 36263 RVA: 0x00276D30 File Offset: 0x00274F30
		public int[] GetSingleTubeLifeArrArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x06008DA8 RID: 36264 RVA: 0x00276D48 File Offset: 0x00274F48
		public int LifeCountAttr(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001CC8 RID: 7368
		// (get) Token: 0x06008DA9 RID: 36265 RVA: 0x00276D88 File Offset: 0x00274F88
		public int LifeCountAttrLength
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

		// Token: 0x06008DAA RID: 36266 RVA: 0x00276DB4 File Offset: 0x00274FB4
		public Span<int> GetLifeCountAttrBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x06008DAB RID: 36267 RVA: 0x00276DC4 File Offset: 0x00274FC4
		public int[] GetLifeCountAttrArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x06008DAC RID: 36268 RVA: 0x00276DDC File Offset: 0x00274FDC
		public int RageMaxCustomArr(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001CC9 RID: 7369
		// (get) Token: 0x06008DAD RID: 36269 RVA: 0x00276E1C File Offset: 0x0027501C
		public int RageMaxCustomArrLength
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

		// Token: 0x06008DAE RID: 36270 RVA: 0x00276E48 File Offset: 0x00275048
		public Span<int> GetRageMaxCustomArrBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x06008DAF RID: 36271 RVA: 0x00276E58 File Offset: 0x00275058
		public int[] GetRageMaxCustomArrArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x06008DB0 RID: 36272 RVA: 0x00276E70 File Offset: 0x00275070
		public int InitLifeCountAttr(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001CCA RID: 7370
		// (get) Token: 0x06008DB1 RID: 36273 RVA: 0x00276EB0 File Offset: 0x002750B0
		public int InitLifeCountAttrLength
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

		// Token: 0x06008DB2 RID: 36274 RVA: 0x00276EDC File Offset: 0x002750DC
		public Span<int> GetInitLifeCountAttrBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x06008DB3 RID: 36275 RVA: 0x00276EEC File Offset: 0x002750EC
		public int[] GetInitLifeCountAttrArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x06008DB4 RID: 36276 RVA: 0x00276F04 File Offset: 0x00275104
		public string CustomColorSet(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001CCB RID: 7371
		// (get) Token: 0x06008DB5 RID: 36277 RVA: 0x00276F40 File Offset: 0x00275140
		public int CustomColorSetLength
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

		// Token: 0x06008DB6 RID: 36278 RVA: 0x00276F6C File Offset: 0x0027516C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CustomColorSetIter()或GetCustomColorSetBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] CustomColorSet()
		{
			return this.CustomColorSetIter().ToArray<string>();
		}

		// Token: 0x06008DB7 RID: 36279 RVA: 0x00276F79 File Offset: 0x00275179
		[NullableContext(1)]
		public readonly IEnumerable<string> CustomColorSetIter()
		{
			LifeMaxCustomization.<CustomColorSetIter>d__44 <CustomColorSetIter>d__ = new LifeMaxCustomization.<CustomColorSetIter>d__44(-2);
			<CustomColorSetIter>d__.<>3__<>4__this = this;
			return <CustomColorSetIter>d__;
		}

		// Token: 0x06008DB8 RID: 36280 RVA: 0x00276F90 File Offset: 0x00275190
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用InitLifeCountAttrIter()或GetInitLifeCountAttrBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] InitLifeCountAttr()
		{
			LifeMaxCustomization lifeMaxCustomization = this;
			return lifeMaxCustomization.GetInitLifeCountAttrArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008DB9 RID: 36281 RVA: 0x00276FB4 File Offset: 0x002751B4
		[NullableContext(1)]
		public readonly IEnumerable<int> InitLifeCountAttrIter()
		{
			LifeMaxCustomization.<InitLifeCountAttrIter>d__46 <InitLifeCountAttrIter>d__ = new LifeMaxCustomization.<InitLifeCountAttrIter>d__46(-2);
			<InitLifeCountAttrIter>d__.<>3__<>4__this = this;
			return <InitLifeCountAttrIter>d__;
		}

		// Token: 0x06008DBA RID: 36282 RVA: 0x00276FCC File Offset: 0x002751CC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LifeCountAttrIter()或GetLifeCountAttrBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] LifeCountAttr()
		{
			LifeMaxCustomization lifeMaxCustomization = this;
			return lifeMaxCustomization.GetLifeCountAttrArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008DBB RID: 36283 RVA: 0x00276FF0 File Offset: 0x002751F0
		[NullableContext(1)]
		public readonly IEnumerable<int> LifeCountAttrIter()
		{
			LifeMaxCustomization.<LifeCountAttrIter>d__48 <LifeCountAttrIter>d__ = new LifeMaxCustomization.<LifeCountAttrIter>d__48(-2);
			<LifeCountAttrIter>d__.<>3__<>4__this = this;
			return <LifeCountAttrIter>d__;
		}

		// Token: 0x06008DBC RID: 36284 RVA: 0x00277008 File Offset: 0x00275208
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RageMaxCustomArrIter()或GetRageMaxCustomArrBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RageMaxCustomArr()
		{
			LifeMaxCustomization lifeMaxCustomization = this;
			return lifeMaxCustomization.GetRageMaxCustomArrArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008DBD RID: 36285 RVA: 0x0027702C File Offset: 0x0027522C
		[NullableContext(1)]
		public readonly IEnumerable<int> RageMaxCustomArrIter()
		{
			LifeMaxCustomization.<RageMaxCustomArrIter>d__50 <RageMaxCustomArrIter>d__ = new LifeMaxCustomization.<RageMaxCustomArrIter>d__50(-2);
			<RageMaxCustomArrIter>d__.<>3__<>4__this = this;
			return <RageMaxCustomArrIter>d__;
		}

		// Token: 0x06008DBE RID: 36286 RVA: 0x00277044 File Offset: 0x00275244
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SingleTubeLifeArrIter()或GetSingleTubeLifeArrBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SingleTubeLifeArr()
		{
			LifeMaxCustomization lifeMaxCustomization = this;
			return lifeMaxCustomization.GetSingleTubeLifeArrArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008DBF RID: 36287 RVA: 0x00277068 File Offset: 0x00275268
		[NullableContext(1)]
		public readonly IEnumerable<int> SingleTubeLifeArrIter()
		{
			LifeMaxCustomization.<SingleTubeLifeArrIter>d__52 <SingleTubeLifeArrIter>d__ = new LifeMaxCustomization.<SingleTubeLifeArrIter>d__52(-2);
			<SingleTubeLifeArrIter>d__.<>3__<>4__this = this;
			return <SingleTubeLifeArrIter>d__;
		}

		// Token: 0x04004E5A RID: 20058
		private Table __p;
	}
}
