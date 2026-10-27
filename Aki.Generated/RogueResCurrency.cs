using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FF8 RID: 4088
	public struct RogueResCurrency : IFlatbufferObject
	{
		// Token: 0x17002FEF RID: 12271
		// (get) Token: 0x0600C15F RID: 49503 RVA: 0x002EA475 File Offset: 0x002E8675
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C160 RID: 49504 RVA: 0x002EA482 File Offset: 0x002E8682
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C161 RID: 49505 RVA: 0x002EA48C File Offset: 0x002E868C
		public static RogueResCurrency GetRootAsRogueResCurrency(ByteBuffer _bb)
		{
			return RogueResCurrency.GetRootAsRogueResCurrency(_bb, default(RogueResCurrency));
		}

		// Token: 0x0600C162 RID: 49506 RVA: 0x002EA4A8 File Offset: 0x002E86A8
		public static RogueResCurrency GetRootAsRogueResCurrency(ByteBuffer _bb, RogueResCurrency obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C163 RID: 49507 RVA: 0x002EA4C5 File Offset: 0x002E86C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C164 RID: 49508 RVA: 0x002EA4D4 File Offset: 0x002E86D4
		public RogueResCurrency __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002FF0 RID: 12272
		// (get) Token: 0x0600C165 RID: 49509 RVA: 0x002EA4E4 File Offset: 0x002E86E4
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

		// Token: 0x17002FF1 RID: 12273
		// (get) Token: 0x0600C166 RID: 49510 RVA: 0x002EA520 File Offset: 0x002E8720
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

		// Token: 0x0600C167 RID: 49511 RVA: 0x002EA55C File Offset: 0x002E875C
		public int ItemAccess(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002FF2 RID: 12274
		// (get) Token: 0x0600C168 RID: 49512 RVA: 0x002EA59C File Offset: 0x002E879C
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

		// Token: 0x0600C169 RID: 49513 RVA: 0x002EA5C7 File Offset: 0x002E87C7
		public Span<int> GetItemAccessBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600C16A RID: 49514 RVA: 0x002EA5D6 File Offset: 0x002E87D6
		public int[] GetItemAccessArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17002FF3 RID: 12275
		// (get) Token: 0x0600C16B RID: 49515 RVA: 0x002EA5F0 File Offset: 0x002E87F0
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

		// Token: 0x17002FF4 RID: 12276
		// (get) Token: 0x0600C16C RID: 49516 RVA: 0x002EA630 File Offset: 0x002E8830
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

		// Token: 0x0600C16D RID: 49517 RVA: 0x002EA668 File Offset: 0x002E8868
		public Span<byte> GetImagePathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C16E RID: 49518 RVA: 0x002EA678 File Offset: 0x002E8878
		public byte[] GetImagePathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002FF5 RID: 12277
		// (get) Token: 0x0600C16F RID: 49519 RVA: 0x002EA690 File Offset: 0x002E8890
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

		// Token: 0x0600C170 RID: 49520 RVA: 0x002EA6C8 File Offset: 0x002E88C8
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C171 RID: 49521 RVA: 0x002EA6D8 File Offset: 0x002E88D8
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002FF6 RID: 12278
		// (get) Token: 0x0600C172 RID: 49522 RVA: 0x002EA6F0 File Offset: 0x002E88F0
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

		// Token: 0x0600C173 RID: 49523 RVA: 0x002EA728 File Offset: 0x002E8928
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600C174 RID: 49524 RVA: 0x002EA738 File Offset: 0x002E8938
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002FF7 RID: 12279
		// (get) Token: 0x0600C175 RID: 49525 RVA: 0x002EA750 File Offset: 0x002E8950
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

		// Token: 0x0600C176 RID: 49526 RVA: 0x002EA788 File Offset: 0x002E8988
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600C177 RID: 49527 RVA: 0x002EA798 File Offset: 0x002E8998
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002FF8 RID: 12280
		// (get) Token: 0x0600C178 RID: 49528 RVA: 0x002EA7B0 File Offset: 0x002E89B0
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

		// Token: 0x0600C179 RID: 49529 RVA: 0x002EA7E8 File Offset: 0x002E89E8
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600C17A RID: 49530 RVA: 0x002EA7F8 File Offset: 0x002E89F8
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002FF9 RID: 12281
		// (get) Token: 0x0600C17B RID: 49531 RVA: 0x002EA810 File Offset: 0x002E8A10
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

		// Token: 0x0600C17C RID: 49532 RVA: 0x002EA848 File Offset: 0x002E8A48
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600C17D RID: 49533 RVA: 0x002EA858 File Offset: 0x002E8A58
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002FFA RID: 12282
		// (get) Token: 0x0600C17E RID: 49534 RVA: 0x002EA870 File Offset: 0x002E8A70
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

		// Token: 0x0600C17F RID: 49535 RVA: 0x002EA8A8 File Offset: 0x002E8AA8
		public Span<byte> GetObtainedShowDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600C180 RID: 49536 RVA: 0x002EA8B8 File Offset: 0x002E8AB8
		public byte[] GetObtainedShowDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17002FFB RID: 12283
		// (get) Token: 0x0600C181 RID: 49537 RVA: 0x002EA8D0 File Offset: 0x002E8AD0
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

		// Token: 0x0600C182 RID: 49538 RVA: 0x002EA908 File Offset: 0x002E8B08
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600C183 RID: 49539 RVA: 0x002EA918 File Offset: 0x002E8B18
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17002FFC RID: 12284
		// (get) Token: 0x0600C184 RID: 49540 RVA: 0x002EA930 File Offset: 0x002E8B30
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

		// Token: 0x0600C185 RID: 49541 RVA: 0x002EA968 File Offset: 0x002E8B68
		public Span<byte> GetBgDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600C186 RID: 49542 RVA: 0x002EA978 File Offset: 0x002E8B78
		public byte[] GetBgDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17002FFD RID: 12285
		// (get) Token: 0x0600C187 RID: 49543 RVA: 0x002EA990 File Offset: 0x002E8B90
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

		// Token: 0x0600C188 RID: 49544 RVA: 0x002EA9C8 File Offset: 0x002E8BC8
		public Span<byte> GetTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600C189 RID: 49545 RVA: 0x002EA9D8 File Offset: 0x002E8BD8
		public byte[] GetTipsArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17002FFE RID: 12286
		// (get) Token: 0x0600C18A RID: 49546 RVA: 0x002EA9F0 File Offset: 0x002E8BF0
		public bool ShowInBag
		{
			get
			{
				int num = this.__p.__offset(32);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002FFF RID: 12287
		// (get) Token: 0x0600C18B RID: 49547 RVA: 0x002EAA30 File Offset: 0x002E8C30
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

		// Token: 0x0600C18C RID: 49548 RVA: 0x002EAA70 File Offset: 0x002E8C70
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ItemAccessIter()或GetItemAccessBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ItemAccess()
		{
			RogueResCurrency rogueResCurrency = this;
			return rogueResCurrency.GetItemAccessArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C18D RID: 49549 RVA: 0x002EAA94 File Offset: 0x002E8C94
		[NullableContext(1)]
		public readonly IEnumerable<int> ItemAccessIter()
		{
			RogueResCurrency.<ItemAccessIter>d__64 <ItemAccessIter>d__ = new RogueResCurrency.<ItemAccessIter>d__64(-2);
			<ItemAccessIter>d__.<>3__<>4__this = this;
			return <ItemAccessIter>d__;
		}

		// Token: 0x040050E0 RID: 20704
		private Table __p;
	}
}
