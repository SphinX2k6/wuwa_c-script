using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AAE RID: 2734
	public struct AbyssItem : IFlatbufferObject
	{
		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060040C0 RID: 16576 RVA: 0x001C614E File Offset: 0x001C434E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060040C1 RID: 16577 RVA: 0x001C615B File Offset: 0x001C435B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060040C2 RID: 16578 RVA: 0x001C6164 File Offset: 0x001C4364
		public static AbyssItem GetRootAsAbyssItem(ByteBuffer _bb)
		{
			return AbyssItem.GetRootAsAbyssItem(_bb, default(AbyssItem));
		}

		// Token: 0x060040C3 RID: 16579 RVA: 0x001C6180 File Offset: 0x001C4380
		public static AbyssItem GetRootAsAbyssItem(ByteBuffer _bb, AbyssItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060040C4 RID: 16580 RVA: 0x001C619D File Offset: 0x001C439D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060040C5 RID: 16581 RVA: 0x001C61AC File Offset: 0x001C43AC
		public AbyssItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060040C6 RID: 16582 RVA: 0x001C61BC File Offset: 0x001C43BC
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

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060040C7 RID: 16583 RVA: 0x001C61F8 File Offset: 0x001C43F8
		public int ActivityId
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

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060040C8 RID: 16584 RVA: 0x001C6234 File Offset: 0x001C4434
		public int SlotType
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

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060040C9 RID: 16585 RVA: 0x001C6270 File Offset: 0x001C4470
		public int QualityId
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

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060040CA RID: 16586 RVA: 0x001C62B0 File Offset: 0x001C44B0
		public int BelongLittleRole
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

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060040CB RID: 16587 RVA: 0x001C62F0 File Offset: 0x001C44F0
		public string PassiveBuffShowName
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

		// Token: 0x060040CC RID: 16588 RVA: 0x001C6328 File Offset: 0x001C4528
		public Span<byte> GetPassiveBuffShowNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060040CD RID: 16589 RVA: 0x001C6338 File Offset: 0x001C4538
		public byte[] GetPassiveBuffShowNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060040CE RID: 16590 RVA: 0x001C6350 File Offset: 0x001C4550
		public string PassiveBuffShowDesc
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

		// Token: 0x060040CF RID: 16591 RVA: 0x001C6388 File Offset: 0x001C4588
		public Span<byte> GetPassiveBuffShowDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060040D0 RID: 16592 RVA: 0x001C6398 File Offset: 0x001C4598
		public byte[] GetPassiveBuffShowDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x060040D1 RID: 16593 RVA: 0x001C63B0 File Offset: 0x001C45B0
		public StringArray? LevelDescStrArray(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new StringArray?(default(StringArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060040D2 RID: 16594 RVA: 0x001C6414 File Offset: 0x001C4614
		public int LevelDescStrArrayLength
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

		// Token: 0x060040D3 RID: 16595 RVA: 0x001C6440 File Offset: 0x001C4640
		public long AbyssBuff(int j)
		{
			int num = this.__p.__offset(20);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060040D4 RID: 16596 RVA: 0x001C648C File Offset: 0x001C468C
		public int AbyssBuffLength
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

		// Token: 0x060040D5 RID: 16597 RVA: 0x001C64B8 File Offset: 0x001C46B8
		public Span<long> GetAbyssBuffBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(20, 8));
		}

		// Token: 0x060040D6 RID: 16598 RVA: 0x001C64CD File Offset: 0x001C46CD
		public long[] GetAbyssBuffArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(20) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x060040D7 RID: 16599 RVA: 0x001C650C File Offset: 0x001C470C
		public long AbyssPhantomBuff(int j)
		{
			int num = this.__p.__offset(22);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060040D8 RID: 16600 RVA: 0x001C6558 File Offset: 0x001C4758
		public int AbyssPhantomBuffLength
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

		// Token: 0x060040D9 RID: 16601 RVA: 0x001C6584 File Offset: 0x001C4784
		public Span<long> GetAbyssPhantomBuffBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(22, 8));
		}

		// Token: 0x060040DA RID: 16602 RVA: 0x001C6599 File Offset: 0x001C4799
		public long[] GetAbyssPhantomBuffArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(22) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x060040DB RID: 16603 RVA: 0x001C65D8 File Offset: 0x001C47D8
		public ConfigPropValue? Prop(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new ConfigPropValue?(default(ConfigPropValue).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060040DC RID: 16604 RVA: 0x001C663C File Offset: 0x001C483C
		public int PropLength
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

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060040DD RID: 16605 RVA: 0x001C6668 File Offset: 0x001C4868
		public string AttributesDescription
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060040DE RID: 16606 RVA: 0x001C66A0 File Offset: 0x001C48A0
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x060040DF RID: 16607 RVA: 0x001C66B0 File Offset: 0x001C48B0
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x060040E0 RID: 16608 RVA: 0x001C66C8 File Offset: 0x001C48C8
		public DicIntInt? AddTag(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060040E1 RID: 16609 RVA: 0x001C672C File Offset: 0x001C492C
		public int AddTagLength
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

		// Token: 0x060040E2 RID: 16610 RVA: 0x001C6758 File Offset: 0x001C4958
		public DicIntInt? CertainTag(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060040E3 RID: 16611 RVA: 0x001C67BC File Offset: 0x001C49BC
		public int CertainTagLength
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

		// Token: 0x060040E4 RID: 16612 RVA: 0x001C67E8 File Offset: 0x001C49E8
		public ConfigPropValue? AddProp(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return null;
			}
			return new ConfigPropValue?(default(ConfigPropValue).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060040E5 RID: 16613 RVA: 0x001C684C File Offset: 0x001C4A4C
		public int AddPropLength
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060040E6 RID: 16614 RVA: 0x001C6878 File Offset: 0x001C4A78
		public string Name
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

		// Token: 0x060040E7 RID: 16615 RVA: 0x001C68B0 File Offset: 0x001C4AB0
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x060040E8 RID: 16616 RVA: 0x001C68C0 File Offset: 0x001C4AC0
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060040E9 RID: 16617 RVA: 0x001C68D8 File Offset: 0x001C4AD8
		public string TypeDescription
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

		// Token: 0x060040EA RID: 16618 RVA: 0x001C6910 File Offset: 0x001C4B10
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x060040EB RID: 16619 RVA: 0x001C6920 File Offset: 0x001C4B20
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060040EC RID: 16620 RVA: 0x001C6938 File Offset: 0x001C4B38
		public string BgDescription
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

		// Token: 0x060040ED RID: 16621 RVA: 0x001C6970 File Offset: 0x001C4B70
		public Span<byte> GetBgDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x060040EE RID: 16622 RVA: 0x001C6980 File Offset: 0x001C4B80
		public byte[] GetBgDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060040EF RID: 16623 RVA: 0x001C6998 File Offset: 0x001C4B98
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060040F0 RID: 16624 RVA: 0x001C69D0 File Offset: 0x001C4BD0
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x060040F1 RID: 16625 RVA: 0x001C69E0 File Offset: 0x001C4BE0
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060040F2 RID: 16626 RVA: 0x001C69F8 File Offset: 0x001C4BF8
		public string IconMiddle
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060040F3 RID: 16627 RVA: 0x001C6A30 File Offset: 0x001C4C30
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x060040F4 RID: 16628 RVA: 0x001C6A40 File Offset: 0x001C4C40
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060040F5 RID: 16629 RVA: 0x001C6A58 File Offset: 0x001C4C58
		public string IconSmall
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060040F6 RID: 16630 RVA: 0x001C6A90 File Offset: 0x001C4C90
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x060040F7 RID: 16631 RVA: 0x001C6AA0 File Offset: 0x001C4CA0
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060040F8 RID: 16632 RVA: 0x001C6AB8 File Offset: 0x001C4CB8
		public string Mesh
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060040F9 RID: 16633 RVA: 0x001C6AF0 File Offset: 0x001C4CF0
		public Span<byte> GetMeshBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x060040FA RID: 16634 RVA: 0x001C6B00 File Offset: 0x001C4D00
		public byte[] GetMeshArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x060040FB RID: 16635 RVA: 0x001C6B18 File Offset: 0x001C4D18
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AbyssBuffIter()或GetAbyssBuffBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] AbyssBuff()
		{
			AbyssItem abyssItem = this;
			return abyssItem.GetAbyssBuffArray() ?? Array.Empty<long>();
		}

		// Token: 0x060040FC RID: 16636 RVA: 0x001C6B3C File Offset: 0x001C4D3C
		[NullableContext(1)]
		public readonly IEnumerable<long> AbyssBuffIter()
		{
			AbyssItem.<AbyssBuffIter>d__84 <AbyssBuffIter>d__ = new AbyssItem.<AbyssBuffIter>d__84(-2);
			<AbyssBuffIter>d__.<>3__<>4__this = this;
			return <AbyssBuffIter>d__;
		}

		// Token: 0x060040FD RID: 16637 RVA: 0x001C6B54 File Offset: 0x001C4D54
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AbyssPhantomBuffIter()或GetAbyssPhantomBuffBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] AbyssPhantomBuff()
		{
			AbyssItem abyssItem = this;
			return abyssItem.GetAbyssPhantomBuffArray() ?? Array.Empty<long>();
		}

		// Token: 0x060040FE RID: 16638 RVA: 0x001C6B78 File Offset: 0x001C4D78
		[NullableContext(1)]
		public readonly IEnumerable<long> AbyssPhantomBuffIter()
		{
			AbyssItem.<AbyssPhantomBuffIter>d__86 <AbyssPhantomBuffIter>d__ = new AbyssItem.<AbyssPhantomBuffIter>d__86(-2);
			<AbyssPhantomBuffIter>d__.<>3__<>4__this = this;
			return <AbyssPhantomBuffIter>d__;
		}

		// Token: 0x060040FF RID: 16639 RVA: 0x001C6B8D File Offset: 0x001C4D8D
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AddPropIter()或GetAddPropBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly ConfigPropValue[] AddProp()
		{
			return this.AddPropIter().ToArray<ConfigPropValue>();
		}

		// Token: 0x06004100 RID: 16640 RVA: 0x001C6B9A File Offset: 0x001C4D9A
		[NullableContext(1)]
		public readonly IEnumerable<ConfigPropValue> AddPropIter()
		{
			AbyssItem.<AddPropIter>d__88 <AddPropIter>d__ = new AbyssItem.<AddPropIter>d__88(-2);
			<AddPropIter>d__.<>3__<>4__this = this;
			return <AddPropIter>d__;
		}

		// Token: 0x06004101 RID: 16641 RVA: 0x001C6BB0 File Offset: 0x001C4DB0
		[NullableContext(1)]
		[Obsolete("已废弃，请使用AddTagFrozenDict()缓存字典，遍历请使用AddTagIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> AddTag()
		{
			return this.AddTagIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06004102 RID: 16642 RVA: 0x001C6C06 File Offset: 0x001C4E06
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> AddTagIter()
		{
			AbyssItem.<AddTagIter>d__90 <AddTagIter>d__ = new AbyssItem.<AddTagIter>d__90(-2);
			<AddTagIter>d__.<>3__<>4__this = this;
			return <AddTagIter>d__;
		}

		// Token: 0x06004103 RID: 16643 RVA: 0x001C6C1C File Offset: 0x001C4E1C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用CertainTagFrozenDict()缓存字典，遍历请使用CertainTagIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> CertainTag()
		{
			return this.CertainTagIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06004104 RID: 16644 RVA: 0x001C6C72 File Offset: 0x001C4E72
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> CertainTagIter()
		{
			AbyssItem.<CertainTagIter>d__92 <CertainTagIter>d__ = new AbyssItem.<CertainTagIter>d__92(-2);
			<CertainTagIter>d__.<>3__<>4__this = this;
			return <CertainTagIter>d__;
		}

		// Token: 0x06004105 RID: 16645 RVA: 0x001C6C87 File Offset: 0x001C4E87
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LevelDescStrArrayIter()或GetLevelDescStrArrayBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly StringArray[] LevelDescStrArray()
		{
			return this.LevelDescStrArrayIter().ToArray<StringArray>();
		}

		// Token: 0x06004106 RID: 16646 RVA: 0x001C6C94 File Offset: 0x001C4E94
		[NullableContext(1)]
		public readonly IEnumerable<StringArray> LevelDescStrArrayIter()
		{
			AbyssItem.<LevelDescStrArrayIter>d__94 <LevelDescStrArrayIter>d__ = new AbyssItem.<LevelDescStrArrayIter>d__94(-2);
			<LevelDescStrArrayIter>d__.<>3__<>4__this = this;
			return <LevelDescStrArrayIter>d__;
		}

		// Token: 0x06004107 RID: 16647 RVA: 0x001C6CA9 File Offset: 0x001C4EA9
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PropIter()或GetPropBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly ConfigPropValue[] Prop()
		{
			return this.PropIter().ToArray<ConfigPropValue>();
		}

		// Token: 0x06004108 RID: 16648 RVA: 0x001C6CB6 File Offset: 0x001C4EB6
		[NullableContext(1)]
		public readonly IEnumerable<ConfigPropValue> PropIter()
		{
			AbyssItem.<PropIter>d__96 <PropIter>d__ = new AbyssItem.<PropIter>d__96(-2);
			<PropIter>d__.<>3__<>4__this = this;
			return <PropIter>d__;
		}

		// Token: 0x06004109 RID: 16649 RVA: 0x001C6CCC File Offset: 0x001C4ECC
		public int? GetAddTag(int key)
		{
			this.EnsureAddTagCacheIfNeeded();
			int value;
			if (!this.AddTagCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600410A RID: 16650 RVA: 0x001C6D00 File Offset: 0x001C4F00
		public int? GetCertainTag(int key)
		{
			this.EnsureCertainTagCacheIfNeeded();
			int value;
			if (!this.CertainTagCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600410B RID: 16651 RVA: 0x001C6D34 File Offset: 0x001C4F34
		private void EnsureAddTagCacheIfNeeded()
		{
			if (this.AddTagCache != null)
			{
				return;
			}
			this.AddTagCache = this.AddTagIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600410C RID: 16652 RVA: 0x001C6D9C File Offset: 0x001C4F9C
		private void EnsureCertainTagCacheIfNeeded()
		{
			if (this.CertainTagCache != null)
			{
				return;
			}
			this.CertainTagCache = this.CertainTagIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600410D RID: 16653 RVA: 0x001C6E02 File Offset: 0x001C5002
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetAddTagFrozenDict(int key)
		{
			this.EnsureAddTagCacheIfNeeded();
			return this.AddTagCache;
		}

		// Token: 0x0600410E RID: 16654 RVA: 0x001C6E10 File Offset: 0x001C5010
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetCertainTagFrozenDict(int key)
		{
			this.EnsureCertainTagCacheIfNeeded();
			return this.CertainTagCache;
		}

		// Token: 0x04004A82 RID: 19074
		private Table __p;

		// Token: 0x04004A83 RID: 19075
		[Nullable(2)]
		private FrozenDictionary<int, int> AddTagCache;

		// Token: 0x04004A84 RID: 19076
		[Nullable(2)]
		private FrozenDictionary<int, int> CertainTagCache;
	}
}
