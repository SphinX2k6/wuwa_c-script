using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BB5 RID: 2997
	public struct AdvertisingTabEnemy : IFlatbufferObject
	{
		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06004A7A RID: 19066 RVA: 0x001EFB4C File Offset: 0x001EDD4C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004A7B RID: 19067 RVA: 0x001EFB59 File Offset: 0x001EDD59
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004A7C RID: 19068 RVA: 0x001EFB60 File Offset: 0x001EDD60
		public static AdvertisingTabEnemy GetRootAsAdvertisingTabEnemy(ByteBuffer _bb)
		{
			return AdvertisingTabEnemy.GetRootAsAdvertisingTabEnemy(_bb, default(AdvertisingTabEnemy));
		}

		// Token: 0x06004A7D RID: 19069 RVA: 0x001EFB7C File Offset: 0x001EDD7C
		public static AdvertisingTabEnemy GetRootAsAdvertisingTabEnemy(ByteBuffer _bb, AdvertisingTabEnemy obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004A7E RID: 19070 RVA: 0x001EFB99 File Offset: 0x001EDD99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004A7F RID: 19071 RVA: 0x001EFBA8 File Offset: 0x001EDDA8
		public AdvertisingTabEnemy __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06004A80 RID: 19072 RVA: 0x001EFBB8 File Offset: 0x001EDDB8
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

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06004A81 RID: 19073 RVA: 0x001EFBF4 File Offset: 0x001EDDF4
		public int Type
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

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06004A82 RID: 19074 RVA: 0x001EFC30 File Offset: 0x001EDE30
		public string ThumbnailText
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

		// Token: 0x06004A83 RID: 19075 RVA: 0x001EFC67 File Offset: 0x001EDE67
		public Span<byte> GetThumbnailTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004A84 RID: 19076 RVA: 0x001EFC76 File Offset: 0x001EDE76
		public byte[] GetThumbnailTextArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06004A85 RID: 19077 RVA: 0x001EFC90 File Offset: 0x001EDE90
		public string ThumbnailPic
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

		// Token: 0x06004A86 RID: 19078 RVA: 0x001EFCC8 File Offset: 0x001EDEC8
		public Span<byte> GetThumbnailPicBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004A87 RID: 19079 RVA: 0x001EFCD8 File Offset: 0x001EDED8
		public byte[] GetThumbnailPicArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06004A88 RID: 19080 RVA: 0x001EFCF0 File Offset: 0x001EDEF0
		public string Title
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

		// Token: 0x06004A89 RID: 19081 RVA: 0x001EFD28 File Offset: 0x001EDF28
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06004A8A RID: 19082 RVA: 0x001EFD38 File Offset: 0x001EDF38
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06004A8B RID: 19083 RVA: 0x001EFD50 File Offset: 0x001EDF50
		public string SubTitle
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004A8C RID: 19084 RVA: 0x001EFD88 File Offset: 0x001EDF88
		public Span<byte> GetSubTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06004A8D RID: 19085 RVA: 0x001EFD98 File Offset: 0x001EDF98
		public byte[] GetSubTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06004A8E RID: 19086 RVA: 0x001EFDB0 File Offset: 0x001EDFB0
		public string Description
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004A8F RID: 19087 RVA: 0x001EFDE8 File Offset: 0x001EDFE8
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06004A90 RID: 19088 RVA: 0x001EFDF8 File Offset: 0x001EDFF8
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06004A91 RID: 19089 RVA: 0x001EFE10 File Offset: 0x001EE010
		public string MainPic
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004A92 RID: 19090 RVA: 0x001EFE48 File Offset: 0x001EE048
		public Span<byte> GetMainPicBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06004A93 RID: 19091 RVA: 0x001EFE58 File Offset: 0x001EE058
		public byte[] GetMainPicArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06004A94 RID: 19092 RVA: 0x001EFE70 File Offset: 0x001EE070
		public string EnemyDescription
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004A95 RID: 19093 RVA: 0x001EFEA8 File Offset: 0x001EE0A8
		public Span<byte> GetEnemyDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06004A96 RID: 19094 RVA: 0x001EFEB8 File Offset: 0x001EE0B8
		public byte[] GetEnemyDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06004A97 RID: 19095 RVA: 0x001EFED0 File Offset: 0x001EE0D0
		public string VisionDescription
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004A98 RID: 19096 RVA: 0x001EFF08 File Offset: 0x001EE108
		public Span<byte> GetVisionDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06004A99 RID: 19097 RVA: 0x001EFF18 File Offset: 0x001EE118
		public byte[] GetVisionDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x06004A9A RID: 19098 RVA: 0x001EFF30 File Offset: 0x001EE130
		public int VisionFetterList(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06004A9B RID: 19099 RVA: 0x001EFF70 File Offset: 0x001EE170
		public int VisionFetterListLength
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

		// Token: 0x06004A9C RID: 19100 RVA: 0x001EFF9C File Offset: 0x001EE19C
		public Span<int> GetVisionFetterListBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x06004A9D RID: 19101 RVA: 0x001EFFAC File Offset: 0x001EE1AC
		public int[] GetVisionFetterListArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x06004A9E RID: 19102 RVA: 0x001EFFC4 File Offset: 0x001EE1C4
		public string VisionFetterColorList(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06004A9F RID: 19103 RVA: 0x001F0000 File Offset: 0x001EE200
		public int VisionFetterColorListLength
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

		// Token: 0x06004AA0 RID: 19104 RVA: 0x001F002C File Offset: 0x001EE22C
		public string VisionFetterIconList(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06004AA1 RID: 19105 RVA: 0x001F0068 File Offset: 0x001EE268
		public int VisionFetterIconListLength
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06004AA2 RID: 19106 RVA: 0x001F0094 File Offset: 0x001EE294
		public DicIntString? VisionEffectMap(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06004AA3 RID: 19107 RVA: 0x001F00F8 File Offset: 0x001EE2F8
		public int VisionEffectMapLength
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06004AA4 RID: 19108 RVA: 0x001F0124 File Offset: 0x001EE324
		public string SuitCoreSprite
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004AA5 RID: 19109 RVA: 0x001F015C File Offset: 0x001EE35C
		public Span<byte> GetSuitCoreSpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06004AA6 RID: 19110 RVA: 0x001F016C File Offset: 0x001EE36C
		public byte[] GetSuitCoreSpriteArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06004AA7 RID: 19111 RVA: 0x001F0184 File Offset: 0x001EE384
		public string SuitCoreBgSprite
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004AA8 RID: 19112 RVA: 0x001F01BC File Offset: 0x001EE3BC
		public Span<byte> GetSuitCoreBgSpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06004AA9 RID: 19113 RVA: 0x001F01CC File Offset: 0x001EE3CC
		public byte[] GetSuitCoreBgSpriteArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06004AAA RID: 19114 RVA: 0x001F01E4 File Offset: 0x001EE3E4
		public string SuitOuterBgTexture
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004AAB RID: 19115 RVA: 0x001F021C File Offset: 0x001EE41C
		public Span<byte> GetSuitOuterBgTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x06004AAC RID: 19116 RVA: 0x001F022C File Offset: 0x001EE42C
		public byte[] GetSuitOuterBgTextureArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06004AAD RID: 19117 RVA: 0x001F0244 File Offset: 0x001EE444
		public string SuitNiagaraColor
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004AAE RID: 19118 RVA: 0x001F027C File Offset: 0x001EE47C
		public Span<byte> GetSuitNiagaraColorBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x06004AAF RID: 19119 RVA: 0x001F028C File Offset: 0x001EE48C
		public byte[] GetSuitNiagaraColorArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x06004AB0 RID: 19120 RVA: 0x001F02A4 File Offset: 0x001EE4A4
		[NullableContext(1)]
		public Dictionary<int, string> VisionEffectMap()
		{
			return this.VisionEffectMapIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x06004AB1 RID: 19121 RVA: 0x001F02FA File Offset: 0x001EE4FA
		[NullableContext(1)]
		public IEnumerable<DicIntString> VisionEffectMapIter()
		{
			AdvertisingTabEnemy.<VisionEffectMapIter>d__75 <VisionEffectMapIter>d__ = new AdvertisingTabEnemy.<VisionEffectMapIter>d__75(-2);
			<VisionEffectMapIter>d__.<>3__<>4__this = this;
			return <VisionEffectMapIter>d__;
		}

		// Token: 0x06004AB2 RID: 19122 RVA: 0x001F030F File Offset: 0x001EE50F
		[NullableContext(1)]
		public string[] VisionFetterColorList()
		{
			return this.VisionFetterColorListIter().ToArray<string>();
		}

		// Token: 0x06004AB3 RID: 19123 RVA: 0x001F031C File Offset: 0x001EE51C
		[NullableContext(1)]
		public IEnumerable<string> VisionFetterColorListIter()
		{
			AdvertisingTabEnemy.<VisionFetterColorListIter>d__77 <VisionFetterColorListIter>d__ = new AdvertisingTabEnemy.<VisionFetterColorListIter>d__77(-2);
			<VisionFetterColorListIter>d__.<>3__<>4__this = this;
			return <VisionFetterColorListIter>d__;
		}

		// Token: 0x06004AB4 RID: 19124 RVA: 0x001F0331 File Offset: 0x001EE531
		[NullableContext(1)]
		public string[] VisionFetterIconList()
		{
			return this.VisionFetterIconListIter().ToArray<string>();
		}

		// Token: 0x06004AB5 RID: 19125 RVA: 0x001F033E File Offset: 0x001EE53E
		[NullableContext(1)]
		public IEnumerable<string> VisionFetterIconListIter()
		{
			AdvertisingTabEnemy.<VisionFetterIconListIter>d__79 <VisionFetterIconListIter>d__ = new AdvertisingTabEnemy.<VisionFetterIconListIter>d__79(-2);
			<VisionFetterIconListIter>d__.<>3__<>4__this = this;
			return <VisionFetterIconListIter>d__;
		}

		// Token: 0x06004AB6 RID: 19126 RVA: 0x001F0353 File Offset: 0x001EE553
		[NullableContext(1)]
		public int[] VisionFetterList()
		{
			return this.GetVisionFetterListArray();
		}

		// Token: 0x06004AB7 RID: 19127 RVA: 0x001F035B File Offset: 0x001EE55B
		[NullableContext(1)]
		public IEnumerable<int> VisionFetterListIter()
		{
			AdvertisingTabEnemy.<VisionFetterListIter>d__81 <VisionFetterListIter>d__ = new AdvertisingTabEnemy.<VisionFetterListIter>d__81(-2);
			<VisionFetterListIter>d__.<>3__<>4__this = this;
			return <VisionFetterListIter>d__;
		}

		// Token: 0x06004AB8 RID: 19128 RVA: 0x001F0370 File Offset: 0x001EE570
		[NullableContext(2)]
		public string GetVisionEffectMap(int key)
		{
			this.EnsureVisionEffectMapCacheIfNeeded();
			string result;
			if (!this.VisionEffectMapCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06004AB9 RID: 19129 RVA: 0x001F0398 File Offset: 0x001EE598
		private void EnsureVisionEffectMapCacheIfNeeded()
		{
			if (this.VisionEffectMapCache != null)
			{
				return;
			}
			this.VisionEffectMapCache = this.VisionEffectMapIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x06004ABA RID: 19130 RVA: 0x001F03FE File Offset: 0x001EE5FE
		[NullableContext(1)]
		public FrozenDictionary<int, string> GetVisionEffectMapFrozenDict()
		{
			this.EnsureVisionEffectMapCacheIfNeeded();
			return this.VisionEffectMapCache;
		}

		// Token: 0x04005094 RID: 20628
		private Table __p;

		// Token: 0x04005095 RID: 20629
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> VisionEffectMapCache;
	}
}
