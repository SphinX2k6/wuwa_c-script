using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FDD RID: 4061
	public struct RogueCurrency : IFlatbufferObject
	{
		// Token: 0x17002F0F RID: 12047
		// (get) Token: 0x0600BEA6 RID: 48806 RVA: 0x002E405D File Offset: 0x002E225D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BEA7 RID: 48807 RVA: 0x002E406A File Offset: 0x002E226A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BEA8 RID: 48808 RVA: 0x002E4074 File Offset: 0x002E2274
		public static RogueCurrency GetRootAsRogueCurrency(ByteBuffer _bb)
		{
			return RogueCurrency.GetRootAsRogueCurrency(_bb, default(RogueCurrency));
		}

		// Token: 0x0600BEA9 RID: 48809 RVA: 0x002E4090 File Offset: 0x002E2290
		public static RogueCurrency GetRootAsRogueCurrency(ByteBuffer _bb, RogueCurrency obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BEAA RID: 48810 RVA: 0x002E40AD File Offset: 0x002E22AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BEAB RID: 48811 RVA: 0x002E40BC File Offset: 0x002E22BC
		public RogueCurrency __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002F10 RID: 12048
		// (get) Token: 0x0600BEAC RID: 48812 RVA: 0x002E40CC File Offset: 0x002E22CC
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

		// Token: 0x17002F11 RID: 12049
		// (get) Token: 0x0600BEAD RID: 48813 RVA: 0x002E4108 File Offset: 0x002E2308
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

		// Token: 0x0600BEAE RID: 48814 RVA: 0x002E4144 File Offset: 0x002E2344
		public int ItemAccess(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002F12 RID: 12050
		// (get) Token: 0x0600BEAF RID: 48815 RVA: 0x002E4184 File Offset: 0x002E2384
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

		// Token: 0x0600BEB0 RID: 48816 RVA: 0x002E41AF File Offset: 0x002E23AF
		public Span<int> GetItemAccessBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600BEB1 RID: 48817 RVA: 0x002E41BE File Offset: 0x002E23BE
		public int[] GetItemAccessArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17002F13 RID: 12051
		// (get) Token: 0x0600BEB2 RID: 48818 RVA: 0x002E41D8 File Offset: 0x002E23D8
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

		// Token: 0x17002F14 RID: 12052
		// (get) Token: 0x0600BEB3 RID: 48819 RVA: 0x002E4218 File Offset: 0x002E2418
		public string ImagePath
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

		// Token: 0x0600BEB4 RID: 48820 RVA: 0x002E4250 File Offset: 0x002E2450
		public Span<byte> GetImagePathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600BEB5 RID: 48821 RVA: 0x002E4260 File Offset: 0x002E2460
		public byte[] GetImagePathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F15 RID: 12053
		// (get) Token: 0x0600BEB6 RID: 48822 RVA: 0x002E4278 File Offset: 0x002E2478
		public string Icon
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

		// Token: 0x0600BEB7 RID: 48823 RVA: 0x002E42B0 File Offset: 0x002E24B0
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600BEB8 RID: 48824 RVA: 0x002E42C0 File Offset: 0x002E24C0
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F16 RID: 12054
		// (get) Token: 0x0600BEB9 RID: 48825 RVA: 0x002E42D8 File Offset: 0x002E24D8
		public string IconMiddle
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

		// Token: 0x0600BEBA RID: 48826 RVA: 0x002E4310 File Offset: 0x002E2510
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600BEBB RID: 48827 RVA: 0x002E4320 File Offset: 0x002E2520
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F17 RID: 12055
		// (get) Token: 0x0600BEBC RID: 48828 RVA: 0x002E4338 File Offset: 0x002E2538
		public string IconSmall
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

		// Token: 0x0600BEBD RID: 48829 RVA: 0x002E4370 File Offset: 0x002E2570
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600BEBE RID: 48830 RVA: 0x002E4380 File Offset: 0x002E2580
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F18 RID: 12056
		// (get) Token: 0x0600BEBF RID: 48831 RVA: 0x002E4398 File Offset: 0x002E2598
		public string Title
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

		// Token: 0x0600BEC0 RID: 48832 RVA: 0x002E43D0 File Offset: 0x002E25D0
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600BEC1 RID: 48833 RVA: 0x002E43E0 File Offset: 0x002E25E0
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F19 RID: 12057
		// (get) Token: 0x0600BEC2 RID: 48834 RVA: 0x002E43F8 File Offset: 0x002E25F8
		public string AttributesDescription
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

		// Token: 0x0600BEC3 RID: 48835 RVA: 0x002E4430 File Offset: 0x002E2630
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600BEC4 RID: 48836 RVA: 0x002E4440 File Offset: 0x002E2640
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F1A RID: 12058
		// (get) Token: 0x0600BEC5 RID: 48837 RVA: 0x002E4458 File Offset: 0x002E2658
		public string ObtainedShowDescription
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

		// Token: 0x0600BEC6 RID: 48838 RVA: 0x002E4490 File Offset: 0x002E2690
		public Span<byte> GetObtainedShowDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600BEC7 RID: 48839 RVA: 0x002E44A0 File Offset: 0x002E26A0
		public byte[] GetObtainedShowDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F1B RID: 12059
		// (get) Token: 0x0600BEC8 RID: 48840 RVA: 0x002E44B8 File Offset: 0x002E26B8
		public string TypeDescription
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

		// Token: 0x0600BEC9 RID: 48841 RVA: 0x002E44F0 File Offset: 0x002E26F0
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600BECA RID: 48842 RVA: 0x002E4500 File Offset: 0x002E2700
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F1C RID: 12060
		// (get) Token: 0x0600BECB RID: 48843 RVA: 0x002E4518 File Offset: 0x002E2718
		public string BgDescription
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

		// Token: 0x0600BECC RID: 48844 RVA: 0x002E4550 File Offset: 0x002E2750
		public Span<byte> GetBgDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600BECD RID: 48845 RVA: 0x002E4560 File Offset: 0x002E2760
		public byte[] GetBgDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F1D RID: 12061
		// (get) Token: 0x0600BECE RID: 48846 RVA: 0x002E4578 File Offset: 0x002E2778
		public string Tips
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

		// Token: 0x0600BECF RID: 48847 RVA: 0x002E45B0 File Offset: 0x002E27B0
		public Span<byte> GetTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600BED0 RID: 48848 RVA: 0x002E45C0 File Offset: 0x002E27C0
		public byte[] GetTipsArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F1E RID: 12062
		// (get) Token: 0x0600BED1 RID: 48849 RVA: 0x002E45D8 File Offset: 0x002E27D8
		public bool ShowInBag
		{
			get
			{
				int num = this.__p.__offset(32);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002F1F RID: 12063
		// (get) Token: 0x0600BED2 RID: 48850 RVA: 0x002E4618 File Offset: 0x002E2818
		public int RedDotDisableRule
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BED3 RID: 48851 RVA: 0x002E4658 File Offset: 0x002E2858
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ItemAccessIter()或GetItemAccessBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ItemAccess()
		{
			RogueCurrency rogueCurrency = this;
			return rogueCurrency.GetItemAccessArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600BED4 RID: 48852 RVA: 0x002E467C File Offset: 0x002E287C
		[NullableContext(1)]
		public readonly IEnumerable<int> ItemAccessIter()
		{
			RogueCurrency.<ItemAccessIter>d__64 <ItemAccessIter>d__ = new RogueCurrency.<ItemAccessIter>d__64(-2);
			<ItemAccessIter>d__.<>3__<>4__this = this;
			return <ItemAccessIter>d__;
		}

		// Token: 0x040050BA RID: 20666
		private Table __p;
	}
}
