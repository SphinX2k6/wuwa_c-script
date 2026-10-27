using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D8E RID: 3470
	public struct KingShipBuff : IFlatbufferObject
	{
		// Token: 0x17001A8A RID: 6794
		// (get) Token: 0x060087BE RID: 34750 RVA: 0x002690D0 File Offset: 0x002672D0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060087BF RID: 34751 RVA: 0x002690DD File Offset: 0x002672DD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060087C0 RID: 34752 RVA: 0x002690E4 File Offset: 0x002672E4
		public static KingShipBuff GetRootAsKingShipBuff(ByteBuffer _bb)
		{
			return KingShipBuff.GetRootAsKingShipBuff(_bb, default(KingShipBuff));
		}

		// Token: 0x060087C1 RID: 34753 RVA: 0x00269100 File Offset: 0x00267300
		public static KingShipBuff GetRootAsKingShipBuff(ByteBuffer _bb, KingShipBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060087C2 RID: 34754 RVA: 0x0026911D File Offset: 0x0026731D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060087C3 RID: 34755 RVA: 0x0026912C File Offset: 0x0026732C
		public KingShipBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001A8B RID: 6795
		// (get) Token: 0x060087C4 RID: 34756 RVA: 0x0026913C File Offset: 0x0026733C
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

		// Token: 0x17001A8C RID: 6796
		// (get) Token: 0x060087C5 RID: 34757 RVA: 0x00269178 File Offset: 0x00267378
		public string Icon
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

		// Token: 0x060087C6 RID: 34758 RVA: 0x002691AF File Offset: 0x002673AF
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060087C7 RID: 34759 RVA: 0x002691BE File Offset: 0x002673BE
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A8D RID: 6797
		// (get) Token: 0x060087C8 RID: 34760 RVA: 0x002691D8 File Offset: 0x002673D8
		public string NameText
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

		// Token: 0x060087C9 RID: 34761 RVA: 0x0026920F File Offset: 0x0026740F
		public Span<byte> GetNameTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060087CA RID: 34762 RVA: 0x0026921E File Offset: 0x0026741E
		public byte[] GetNameTextArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A8E RID: 6798
		// (get) Token: 0x060087CB RID: 34763 RVA: 0x00269238 File Offset: 0x00267438
		public string DesText
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

		// Token: 0x060087CC RID: 34764 RVA: 0x00269270 File Offset: 0x00267470
		public Span<byte> GetDesTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060087CD RID: 34765 RVA: 0x00269280 File Offset: 0x00267480
		public byte[] GetDesTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A8F RID: 6799
		// (get) Token: 0x060087CE RID: 34766 RVA: 0x00269298 File Offset: 0x00267498
		public int Type
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

		// Token: 0x060087CF RID: 34767 RVA: 0x002692D8 File Offset: 0x002674D8
		public int Param(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001A90 RID: 6800
		// (get) Token: 0x060087D0 RID: 34768 RVA: 0x00269318 File Offset: 0x00267518
		public int ParamLength
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

		// Token: 0x060087D1 RID: 34769 RVA: 0x00269344 File Offset: 0x00267544
		public Span<int> GetParamBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x060087D2 RID: 34770 RVA: 0x00269354 File Offset: 0x00267554
		public int[] GetParamArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x060087D3 RID: 34771 RVA: 0x0026936C File Offset: 0x0026756C
		public DicIntInt? ParamMap(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001A91 RID: 6801
		// (get) Token: 0x060087D4 RID: 34772 RVA: 0x002693D0 File Offset: 0x002675D0
		public int ParamMapLength
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

		// Token: 0x17001A92 RID: 6802
		// (get) Token: 0x060087D5 RID: 34773 RVA: 0x002693FC File Offset: 0x002675FC
		public int Rrounds
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

		// Token: 0x060087D6 RID: 34774 RVA: 0x0026943C File Offset: 0x0026763C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ParamIter()或GetParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Param()
		{
			KingShipBuff kingShipBuff = this;
			return kingShipBuff.GetParamArray() ?? Array.Empty<int>();
		}

		// Token: 0x060087D7 RID: 34775 RVA: 0x00269460 File Offset: 0x00267660
		[NullableContext(1)]
		public readonly IEnumerable<int> ParamIter()
		{
			KingShipBuff.<ParamIter>d__35 <ParamIter>d__ = new KingShipBuff.<ParamIter>d__35(-2);
			<ParamIter>d__.<>3__<>4__this = this;
			return <ParamIter>d__;
		}

		// Token: 0x060087D8 RID: 34776 RVA: 0x00269478 File Offset: 0x00267678
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ParamMapFrozenDict()缓存字典，遍历请使用ParamMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> ParamMap()
		{
			return this.ParamMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060087D9 RID: 34777 RVA: 0x002694CE File Offset: 0x002676CE
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> ParamMapIter()
		{
			KingShipBuff.<ParamMapIter>d__37 <ParamMapIter>d__ = new KingShipBuff.<ParamMapIter>d__37(-2);
			<ParamMapIter>d__.<>3__<>4__this = this;
			return <ParamMapIter>d__;
		}

		// Token: 0x060087DA RID: 34778 RVA: 0x002694E4 File Offset: 0x002676E4
		public int? GetParamMap(int key)
		{
			this.EnsureParamMapCacheIfNeeded();
			int value;
			if (!this.ParamMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060087DB RID: 34779 RVA: 0x00269518 File Offset: 0x00267718
		private void EnsureParamMapCacheIfNeeded()
		{
			if (this.ParamMapCache != null)
			{
				return;
			}
			this.ParamMapCache = this.ParamMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060087DC RID: 34780 RVA: 0x0026957E File Offset: 0x0026777E
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetParamMapFrozenDict(int key)
		{
			this.EnsureParamMapCacheIfNeeded();
			return this.ParamMapCache;
		}

		// Token: 0x04004E1A RID: 19994
		private Table __p;

		// Token: 0x04004E1B RID: 19995
		[Nullable(2)]
		private FrozenDictionary<int, int> ParamMapCache;
	}
}
