using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C05 RID: 3077
	public struct BackgroundCard : IFlatbufferObject
	{
		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06005128 RID: 20776 RVA: 0x001FE97C File Offset: 0x001FCB7C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005129 RID: 20777 RVA: 0x001FE989 File Offset: 0x001FCB89
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600512A RID: 20778 RVA: 0x001FE990 File Offset: 0x001FCB90
		public static BackgroundCard GetRootAsBackgroundCard(ByteBuffer _bb)
		{
			return BackgroundCard.GetRootAsBackgroundCard(_bb, default(BackgroundCard));
		}

		// Token: 0x0600512B RID: 20779 RVA: 0x001FE9AC File Offset: 0x001FCBAC
		public static BackgroundCard GetRootAsBackgroundCard(ByteBuffer _bb, BackgroundCard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600512C RID: 20780 RVA: 0x001FE9C9 File Offset: 0x001FCBC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600512D RID: 20781 RVA: 0x001FE9D8 File Offset: 0x001FCBD8
		public BackgroundCard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x0600512E RID: 20782 RVA: 0x001FE9E8 File Offset: 0x001FCBE8
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

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x0600512F RID: 20783 RVA: 0x001FEA24 File Offset: 0x001FCC24
		public int QualityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005130 RID: 20784 RVA: 0x001FEA60 File Offset: 0x001FCC60
		public int ItemAccess(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06005131 RID: 20785 RVA: 0x001FEAA0 File Offset: 0x001FCCA0
		public int ItemAccessLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005132 RID: 20786 RVA: 0x001FEACB File Offset: 0x001FCCCB
		public Span<int> GetItemAccessBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06005133 RID: 20787 RVA: 0x001FEADA File Offset: 0x001FCCDA
		public int[] GetItemAccessArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06005134 RID: 20788 RVA: 0x001FEAF4 File Offset: 0x001FCCF4
		public int SortIndex
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

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06005135 RID: 20789 RVA: 0x001FEB34 File Offset: 0x001FCD34
		public string LongCardPath
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

		// Token: 0x06005136 RID: 20790 RVA: 0x001FEB6C File Offset: 0x001FCD6C
		public Span<byte> GetLongCardPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06005137 RID: 20791 RVA: 0x001FEB7C File Offset: 0x001FCD7C
		public byte[] GetLongCardPathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06005138 RID: 20792 RVA: 0x001FEB94 File Offset: 0x001FCD94
		public string CardPath
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

		// Token: 0x06005139 RID: 20793 RVA: 0x001FEBCC File Offset: 0x001FCDCC
		public Span<byte> GetCardPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600513A RID: 20794 RVA: 0x001FEBDC File Offset: 0x001FCDDC
		public byte[] GetCardPathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x0600513B RID: 20795 RVA: 0x001FEBF4 File Offset: 0x001FCDF4
		public string FunctionViewCardPath
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

		// Token: 0x0600513C RID: 20796 RVA: 0x001FEC2C File Offset: 0x001FCE2C
		public Span<byte> GetFunctionViewCardPathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600513D RID: 20797 RVA: 0x001FEC3C File Offset: 0x001FCE3C
		public byte[] GetFunctionViewCardPathArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x0600513E RID: 20798 RVA: 0x001FEC54 File Offset: 0x001FCE54
		public string Icon
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

		// Token: 0x0600513F RID: 20799 RVA: 0x001FEC8C File Offset: 0x001FCE8C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06005140 RID: 20800 RVA: 0x001FEC9C File Offset: 0x001FCE9C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06005141 RID: 20801 RVA: 0x001FECB4 File Offset: 0x001FCEB4
		public string IconMiddle
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

		// Token: 0x06005142 RID: 20802 RVA: 0x001FECEC File Offset: 0x001FCEEC
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06005143 RID: 20803 RVA: 0x001FECFC File Offset: 0x001FCEFC
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06005144 RID: 20804 RVA: 0x001FED14 File Offset: 0x001FCF14
		public string IconSmall
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

		// Token: 0x06005145 RID: 20805 RVA: 0x001FED4C File Offset: 0x001FCF4C
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06005146 RID: 20806 RVA: 0x001FED5C File Offset: 0x001FCF5C
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06005147 RID: 20807 RVA: 0x001FED74 File Offset: 0x001FCF74
		public string Title
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005148 RID: 20808 RVA: 0x001FEDAC File Offset: 0x001FCFAC
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06005149 RID: 20809 RVA: 0x001FEDBC File Offset: 0x001FCFBC
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x0600514A RID: 20810 RVA: 0x001FEDD4 File Offset: 0x001FCFD4
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

		// Token: 0x0600514B RID: 20811 RVA: 0x001FEE0C File Offset: 0x001FD00C
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600514C RID: 20812 RVA: 0x001FEE1C File Offset: 0x001FD01C
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x0600514D RID: 20813 RVA: 0x001FEE34 File Offset: 0x001FD034
		public string ObtainedShowDescription
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

		// Token: 0x0600514E RID: 20814 RVA: 0x001FEE6C File Offset: 0x001FD06C
		public Span<byte> GetObtainedShowDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600514F RID: 20815 RVA: 0x001FEE7C File Offset: 0x001FD07C
		public byte[] GetObtainedShowDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06005150 RID: 20816 RVA: 0x001FEE94 File Offset: 0x001FD094
		public string TypeDescription
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005151 RID: 20817 RVA: 0x001FEECC File Offset: 0x001FD0CC
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06005152 RID: 20818 RVA: 0x001FEEDC File Offset: 0x001FD0DC
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06005153 RID: 20819 RVA: 0x001FEEF4 File Offset: 0x001FD0F4
		public string BgDescription
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

		// Token: 0x06005154 RID: 20820 RVA: 0x001FEF2C File Offset: 0x001FD12C
		public Span<byte> GetBgDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06005155 RID: 20821 RVA: 0x001FEF3C File Offset: 0x001FD13C
		public byte[] GetBgDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06005156 RID: 20822 RVA: 0x001FEF54 File Offset: 0x001FD154
		public string Tips
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

		// Token: 0x06005157 RID: 20823 RVA: 0x001FEF8C File Offset: 0x001FD18C
		public Span<byte> GetTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06005158 RID: 20824 RVA: 0x001FEF9C File Offset: 0x001FD19C
		public byte[] GetTipsArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06005159 RID: 20825 RVA: 0x001FEFB4 File Offset: 0x001FD1B4
		public bool ShowInBag
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x0600515A RID: 20826 RVA: 0x001FEFF4 File Offset: 0x001FD1F4
		public int RedDotDisableRule
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x0600515B RID: 20827 RVA: 0x001FF034 File Offset: 0x001FD234
		public string FunctionSpineAtlasPath
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

		// Token: 0x0600515C RID: 20828 RVA: 0x001FF06C File Offset: 0x001FD26C
		public Span<byte> GetFunctionSpineAtlasPathBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600515D RID: 20829 RVA: 0x001FF07C File Offset: 0x001FD27C
		public byte[] GetFunctionSpineAtlasPathArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x0600515E RID: 20830 RVA: 0x001FF094 File Offset: 0x001FD294
		public string FunctionSpineDataPath
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

		// Token: 0x0600515F RID: 20831 RVA: 0x001FF0CC File Offset: 0x001FD2CC
		public Span<byte> GetFunctionSpineDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x06005160 RID: 20832 RVA: 0x001FF0DC File Offset: 0x001FD2DC
		public byte[] GetFunctionSpineDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06005161 RID: 20833 RVA: 0x001FF0F4 File Offset: 0x001FD2F4
		public string LongSpineAtlasPath
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

		// Token: 0x06005162 RID: 20834 RVA: 0x001FF12C File Offset: 0x001FD32C
		public Span<byte> GetLongSpineAtlasPathBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x06005163 RID: 20835 RVA: 0x001FF13C File Offset: 0x001FD33C
		public byte[] GetLongSpineAtlasPathArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06005164 RID: 20836 RVA: 0x001FF154 File Offset: 0x001FD354
		public string LongSpineDataPath
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

		// Token: 0x06005165 RID: 20837 RVA: 0x001FF18C File Offset: 0x001FD38C
		public Span<byte> GetLongSpineDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x06005166 RID: 20838 RVA: 0x001FF19C File Offset: 0x001FD39C
		public byte[] GetLongSpineDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06005167 RID: 20839 RVA: 0x001FF1B4 File Offset: 0x001FD3B4
		public string NormalSpineAtlasPath
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005168 RID: 20840 RVA: 0x001FF1EC File Offset: 0x001FD3EC
		public Span<byte> GetNormalSpineAtlasPathBytes()
		{
			return this.__p.__vector_as_span<byte>(48, 1);
		}

		// Token: 0x06005169 RID: 20841 RVA: 0x001FF1FC File Offset: 0x001FD3FC
		public byte[] GetNormalSpineAtlasPathArray()
		{
			return this.__p.__vector_as_array<byte>(48) ?? Array.Empty<byte>();
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x0600516A RID: 20842 RVA: 0x001FF214 File Offset: 0x001FD414
		public string NormalSpineDataPath
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600516B RID: 20843 RVA: 0x001FF24C File Offset: 0x001FD44C
		public Span<byte> GetNormalSpineDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x0600516C RID: 20844 RVA: 0x001FF25C File Offset: 0x001FD45C
		public byte[] GetNormalSpineDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x0600516D RID: 20845 RVA: 0x001FF274 File Offset: 0x001FD474
		[NullableContext(1)]
		public int[] ItemAccess()
		{
			return this.GetItemAccessArray();
		}

		// Token: 0x0600516E RID: 20846 RVA: 0x001FF27C File Offset: 0x001FD47C
		[NullableContext(1)]
		public IEnumerable<int> ItemAccessIter()
		{
			BackgroundCard.<ItemAccessIter>d__96 <ItemAccessIter>d__ = new BackgroundCard.<ItemAccessIter>d__96(-2);
			<ItemAccessIter>d__.<>3__<>4__this = this;
			return <ItemAccessIter>d__;
		}

		// Token: 0x040050F7 RID: 20727
		private Table __p;
	}
}
