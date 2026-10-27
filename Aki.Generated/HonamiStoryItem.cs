using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D37 RID: 3383
	public struct HonamiStoryItem : IFlatbufferObject
	{
		// Token: 0x1700178E RID: 6030
		// (get) Token: 0x06007F8B RID: 32651 RVA: 0x00256A05 File Offset: 0x00254C05
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007F8C RID: 32652 RVA: 0x00256A12 File Offset: 0x00254C12
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007F8D RID: 32653 RVA: 0x00256A1C File Offset: 0x00254C1C
		public static HonamiStoryItem GetRootAsHonamiStoryItem(ByteBuffer _bb)
		{
			return HonamiStoryItem.GetRootAsHonamiStoryItem(_bb, default(HonamiStoryItem));
		}

		// Token: 0x06007F8E RID: 32654 RVA: 0x00256A38 File Offset: 0x00254C38
		public static HonamiStoryItem GetRootAsHonamiStoryItem(ByteBuffer _bb, HonamiStoryItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007F8F RID: 32655 RVA: 0x00256A55 File Offset: 0x00254C55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007F90 RID: 32656 RVA: 0x00256A64 File Offset: 0x00254C64
		public HonamiStoryItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700178F RID: 6031
		// (get) Token: 0x06007F91 RID: 32657 RVA: 0x00256A74 File Offset: 0x00254C74
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

		// Token: 0x17001790 RID: 6032
		// (get) Token: 0x06007F92 RID: 32658 RVA: 0x00256AB0 File Offset: 0x00254CB0
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

		// Token: 0x17001791 RID: 6033
		// (get) Token: 0x06007F93 RID: 32659 RVA: 0x00256AEC File Offset: 0x00254CEC
		public int ItemType
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

		// Token: 0x17001792 RID: 6034
		// (get) Token: 0x06007F94 RID: 32660 RVA: 0x00256B28 File Offset: 0x00254D28
		public int SubType
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

		// Token: 0x17001793 RID: 6035
		// (get) Token: 0x06007F95 RID: 32661 RVA: 0x00256B68 File Offset: 0x00254D68
		public string Name
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

		// Token: 0x06007F96 RID: 32662 RVA: 0x00256BA0 File Offset: 0x00254DA0
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007F97 RID: 32663 RVA: 0x00256BB0 File Offset: 0x00254DB0
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001794 RID: 6036
		// (get) Token: 0x06007F98 RID: 32664 RVA: 0x00256BC8 File Offset: 0x00254DC8
		public string IconBackpack
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

		// Token: 0x06007F99 RID: 32665 RVA: 0x00256C00 File Offset: 0x00254E00
		public Span<byte> GetIconBackpackBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06007F9A RID: 32666 RVA: 0x00256C10 File Offset: 0x00254E10
		public byte[] GetIconBackpackArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001795 RID: 6037
		// (get) Token: 0x06007F9B RID: 32667 RVA: 0x00256C28 File Offset: 0x00254E28
		public string Icon
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

		// Token: 0x06007F9C RID: 32668 RVA: 0x00256C60 File Offset: 0x00254E60
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06007F9D RID: 32669 RVA: 0x00256C70 File Offset: 0x00254E70
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001796 RID: 6038
		// (get) Token: 0x06007F9E RID: 32670 RVA: 0x00256C88 File Offset: 0x00254E88
		public string IconMiddle
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

		// Token: 0x06007F9F RID: 32671 RVA: 0x00256CC0 File Offset: 0x00254EC0
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06007FA0 RID: 32672 RVA: 0x00256CD0 File Offset: 0x00254ED0
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17001797 RID: 6039
		// (get) Token: 0x06007FA1 RID: 32673 RVA: 0x00256CE8 File Offset: 0x00254EE8
		public string IconSmall
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

		// Token: 0x06007FA2 RID: 32674 RVA: 0x00256D20 File Offset: 0x00254F20
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06007FA3 RID: 32675 RVA: 0x00256D30 File Offset: 0x00254F30
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x06007FA4 RID: 32676 RVA: 0x00256D48 File Offset: 0x00254F48
		public int GridOccupy(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001798 RID: 6040
		// (get) Token: 0x06007FA5 RID: 32677 RVA: 0x00256D88 File Offset: 0x00254F88
		public int GridOccupyLength
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

		// Token: 0x06007FA6 RID: 32678 RVA: 0x00256DB4 File Offset: 0x00254FB4
		public Span<int> GetGridOccupyBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x06007FA7 RID: 32679 RVA: 0x00256DC4 File Offset: 0x00254FC4
		public int[] GetGridOccupyArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x17001799 RID: 6041
		// (get) Token: 0x06007FA8 RID: 32680 RVA: 0x00256DDC File Offset: 0x00254FDC
		public int QualityId
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

		// Token: 0x1700179A RID: 6042
		// (get) Token: 0x06007FA9 RID: 32681 RVA: 0x00256E1C File Offset: 0x0025501C
		public int SellPrice
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700179B RID: 6043
		// (get) Token: 0x06007FAA RID: 32682 RVA: 0x00256E5C File Offset: 0x0025505C
		public string AttributesDescription
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007FAB RID: 32683 RVA: 0x00256E94 File Offset: 0x00255094
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06007FAC RID: 32684 RVA: 0x00256EA4 File Offset: 0x002550A4
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x1700179C RID: 6044
		// (get) Token: 0x06007FAD RID: 32685 RVA: 0x00256EBC File Offset: 0x002550BC
		public int DropShowPlan
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700179D RID: 6045
		// (get) Token: 0x06007FAE RID: 32686 RVA: 0x00256EFC File Offset: 0x002550FC
		public int DropPlan
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700179E RID: 6046
		// (get) Token: 0x06007FAF RID: 32687 RVA: 0x00256F3C File Offset: 0x0025513C
		public string TypeDescription
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

		// Token: 0x06007FB0 RID: 32688 RVA: 0x00256F74 File Offset: 0x00255174
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06007FB1 RID: 32689 RVA: 0x00256F84 File Offset: 0x00255184
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x1700179F RID: 6047
		// (get) Token: 0x06007FB2 RID: 32690 RVA: 0x00256F9C File Offset: 0x0025519C
		public string BgDescription
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

		// Token: 0x06007FB3 RID: 32691 RVA: 0x00256FD4 File Offset: 0x002551D4
		public Span<byte> GetBgDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x06007FB4 RID: 32692 RVA: 0x00256FE4 File Offset: 0x002551E4
		public byte[] GetBgDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x170017A0 RID: 6048
		// (get) Token: 0x06007FB5 RID: 32693 RVA: 0x00256FFC File Offset: 0x002551FC
		public string Mesh
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

		// Token: 0x06007FB6 RID: 32694 RVA: 0x00257034 File Offset: 0x00255234
		public Span<byte> GetMeshBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x06007FB7 RID: 32695 RVA: 0x00257044 File Offset: 0x00255244
		public byte[] GetMeshArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x06007FB8 RID: 32696 RVA: 0x0025705C File Offset: 0x0025525C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用GridOccupyIter()或GetGridOccupyBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] GridOccupy()
		{
			HonamiStoryItem honamiStoryItem = this;
			return honamiStoryItem.GetGridOccupyArray() ?? Array.Empty<int>();
		}

		// Token: 0x06007FB9 RID: 32697 RVA: 0x00257080 File Offset: 0x00255280
		[NullableContext(1)]
		public readonly IEnumerable<int> GridOccupyIter()
		{
			HonamiStoryItem.<GridOccupyIter>d__66 <GridOccupyIter>d__ = new HonamiStoryItem.<GridOccupyIter>d__66(-2);
			<GridOccupyIter>d__.<>3__<>4__this = this;
			return <GridOccupyIter>d__;
		}

		// Token: 0x04004DB1 RID: 19889
		private Table __p;
	}
}
