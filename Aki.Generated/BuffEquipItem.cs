using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B54 RID: 2900
	public struct BuffEquipItem : IFlatbufferObject
	{
		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x060050F3 RID: 20723 RVA: 0x001EBDDB File Offset: 0x001E9FDB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060050F4 RID: 20724 RVA: 0x001EBDE8 File Offset: 0x001E9FE8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060050F5 RID: 20725 RVA: 0x001EBDF0 File Offset: 0x001E9FF0
		public static BuffEquipItem GetRootAsBuffEquipItem(ByteBuffer _bb)
		{
			return BuffEquipItem.GetRootAsBuffEquipItem(_bb, default(BuffEquipItem));
		}

		// Token: 0x060050F6 RID: 20726 RVA: 0x001EBE0C File Offset: 0x001EA00C
		public static BuffEquipItem GetRootAsBuffEquipItem(ByteBuffer _bb, BuffEquipItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060050F7 RID: 20727 RVA: 0x001EBE29 File Offset: 0x001EA029
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060050F8 RID: 20728 RVA: 0x001EBE38 File Offset: 0x001EA038
		public BuffEquipItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x060050F9 RID: 20729 RVA: 0x001EBE48 File Offset: 0x001EA048
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

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x060050FA RID: 20730 RVA: 0x001EBE84 File Offset: 0x001EA084
		public int ItemId
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

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x060050FB RID: 20731 RVA: 0x001EBEC0 File Offset: 0x001EA0C0
		public int RoleId
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

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x060050FC RID: 20732 RVA: 0x001EBEFC File Offset: 0x001EA0FC
		public int WearPos
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

		// Token: 0x060050FD RID: 20733 RVA: 0x001EBF3C File Offset: 0x001EA13C
		public long Buffs(int j)
		{
			int num = this.__p.__offset(12);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x060050FE RID: 20734 RVA: 0x001EBF88 File Offset: 0x001EA188
		public int BuffsLength
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

		// Token: 0x060050FF RID: 20735 RVA: 0x001EBFB4 File Offset: 0x001EA1B4
		public Span<long> GetBuffsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(12, 8));
		}

		// Token: 0x06005100 RID: 20736 RVA: 0x001EBFC9 File Offset: 0x001EA1C9
		public long[] GetBuffsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(12) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06005101 RID: 20737 RVA: 0x001EC008 File Offset: 0x001EA208
		public string EquipTips
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

		// Token: 0x06005102 RID: 20738 RVA: 0x001EC040 File Offset: 0x001EA240
		public Span<byte> GetEquipTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06005103 RID: 20739 RVA: 0x001EC050 File Offset: 0x001EA250
		public byte[] GetEquipTipsArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06005104 RID: 20740 RVA: 0x001EC068 File Offset: 0x001EA268
		public string UnEquipTips
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

		// Token: 0x06005105 RID: 20741 RVA: 0x001EC0A0 File Offset: 0x001EA2A0
		public Span<byte> GetUnEquipTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06005106 RID: 20742 RVA: 0x001EC0B0 File Offset: 0x001EA2B0
		public byte[] GetUnEquipTipsArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06005107 RID: 20743 RVA: 0x001EC0C8 File Offset: 0x001EA2C8
		public bool EnableInUI
		{
			get
			{
				int num = this.__p.__offset(18);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06005108 RID: 20744 RVA: 0x001EC108 File Offset: 0x001EA308
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BuffsIter()或GetBuffsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] Buffs()
		{
			BuffEquipItem buffEquipItem = this;
			return buffEquipItem.GetBuffsArray() ?? Array.Empty<long>();
		}

		// Token: 0x06005109 RID: 20745 RVA: 0x001EC12C File Offset: 0x001EA32C
		[NullableContext(1)]
		public readonly IEnumerable<long> BuffsIter()
		{
			BuffEquipItem.<BuffsIter>d__32 <BuffsIter>d__ = new BuffEquipItem.<BuffsIter>d__32(-2);
			<BuffsIter>d__.<>3__<>4__this = this;
			return <BuffsIter>d__;
		}

		// Token: 0x04004B51 RID: 19281
		private Table __p;
	}
}
