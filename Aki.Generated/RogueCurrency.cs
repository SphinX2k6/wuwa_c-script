using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010C5 RID: 4293
	public struct RogueCurrency : IFlatbufferObject
	{
		// Token: 0x17002F8A RID: 12170
		// (get) Token: 0x0600C4F0 RID: 50416 RVA: 0x003005B1 File Offset: 0x002FE7B1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C4F1 RID: 50417 RVA: 0x003005BE File Offset: 0x002FE7BE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C4F2 RID: 50418 RVA: 0x003005C8 File Offset: 0x002FE7C8
		public static RogueCurrency GetRootAsRogueCurrency(ByteBuffer _bb)
		{
			return RogueCurrency.GetRootAsRogueCurrency(_bb, default(RogueCurrency));
		}

		// Token: 0x0600C4F3 RID: 50419 RVA: 0x003005E4 File Offset: 0x002FE7E4
		public static RogueCurrency GetRootAsRogueCurrency(ByteBuffer _bb, RogueCurrency obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C4F4 RID: 50420 RVA: 0x00300601 File Offset: 0x002FE801
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C4F5 RID: 50421 RVA: 0x00300610 File Offset: 0x002FE810
		public RogueCurrency __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002F8B RID: 12171
		// (get) Token: 0x0600C4F6 RID: 50422 RVA: 0x00300620 File Offset: 0x002FE820
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

		// Token: 0x17002F8C RID: 12172
		// (get) Token: 0x0600C4F7 RID: 50423 RVA: 0x0030065C File Offset: 0x002FE85C
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

		// Token: 0x0600C4F8 RID: 50424 RVA: 0x00300698 File Offset: 0x002FE898
		public int ItemAccess(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002F8D RID: 12173
		// (get) Token: 0x0600C4F9 RID: 50425 RVA: 0x003006D8 File Offset: 0x002FE8D8
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

		// Token: 0x0600C4FA RID: 50426 RVA: 0x00300703 File Offset: 0x002FE903
		public Span<int> GetItemAccessBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600C4FB RID: 50427 RVA: 0x00300712 File Offset: 0x002FE912
		public int[] GetItemAccessArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17002F8E RID: 12174
		// (get) Token: 0x0600C4FC RID: 50428 RVA: 0x0030072C File Offset: 0x002FE92C
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

		// Token: 0x17002F8F RID: 12175
		// (get) Token: 0x0600C4FD RID: 50429 RVA: 0x0030076C File Offset: 0x002FE96C
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

		// Token: 0x0600C4FE RID: 50430 RVA: 0x003007A4 File Offset: 0x002FE9A4
		public Span<byte> GetImagePathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C4FF RID: 50431 RVA: 0x003007B4 File Offset: 0x002FE9B4
		public byte[] GetImagePathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F90 RID: 12176
		// (get) Token: 0x0600C500 RID: 50432 RVA: 0x003007CC File Offset: 0x002FE9CC
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

		// Token: 0x0600C501 RID: 50433 RVA: 0x00300804 File Offset: 0x002FEA04
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C502 RID: 50434 RVA: 0x00300814 File Offset: 0x002FEA14
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F91 RID: 12177
		// (get) Token: 0x0600C503 RID: 50435 RVA: 0x0030082C File Offset: 0x002FEA2C
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

		// Token: 0x0600C504 RID: 50436 RVA: 0x00300864 File Offset: 0x002FEA64
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600C505 RID: 50437 RVA: 0x00300874 File Offset: 0x002FEA74
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F92 RID: 12178
		// (get) Token: 0x0600C506 RID: 50438 RVA: 0x0030088C File Offset: 0x002FEA8C
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

		// Token: 0x0600C507 RID: 50439 RVA: 0x003008C4 File Offset: 0x002FEAC4
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600C508 RID: 50440 RVA: 0x003008D4 File Offset: 0x002FEAD4
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F93 RID: 12179
		// (get) Token: 0x0600C509 RID: 50441 RVA: 0x003008EC File Offset: 0x002FEAEC
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

		// Token: 0x0600C50A RID: 50442 RVA: 0x00300924 File Offset: 0x002FEB24
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600C50B RID: 50443 RVA: 0x00300934 File Offset: 0x002FEB34
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F94 RID: 12180
		// (get) Token: 0x0600C50C RID: 50444 RVA: 0x0030094C File Offset: 0x002FEB4C
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

		// Token: 0x0600C50D RID: 50445 RVA: 0x00300984 File Offset: 0x002FEB84
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600C50E RID: 50446 RVA: 0x00300994 File Offset: 0x002FEB94
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F95 RID: 12181
		// (get) Token: 0x0600C50F RID: 50447 RVA: 0x003009AC File Offset: 0x002FEBAC
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

		// Token: 0x0600C510 RID: 50448 RVA: 0x003009E4 File Offset: 0x002FEBE4
		public Span<byte> GetObtainedShowDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600C511 RID: 50449 RVA: 0x003009F4 File Offset: 0x002FEBF4
		public byte[] GetObtainedShowDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F96 RID: 12182
		// (get) Token: 0x0600C512 RID: 50450 RVA: 0x00300A0C File Offset: 0x002FEC0C
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

		// Token: 0x0600C513 RID: 50451 RVA: 0x00300A44 File Offset: 0x002FEC44
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600C514 RID: 50452 RVA: 0x00300A54 File Offset: 0x002FEC54
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F97 RID: 12183
		// (get) Token: 0x0600C515 RID: 50453 RVA: 0x00300A6C File Offset: 0x002FEC6C
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

		// Token: 0x0600C516 RID: 50454 RVA: 0x00300AA4 File Offset: 0x002FECA4
		public Span<byte> GetBgDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600C517 RID: 50455 RVA: 0x00300AB4 File Offset: 0x002FECB4
		public byte[] GetBgDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F98 RID: 12184
		// (get) Token: 0x0600C518 RID: 50456 RVA: 0x00300ACC File Offset: 0x002FECCC
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

		// Token: 0x0600C519 RID: 50457 RVA: 0x00300B04 File Offset: 0x002FED04
		public Span<byte> GetTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600C51A RID: 50458 RVA: 0x00300B14 File Offset: 0x002FED14
		public byte[] GetTipsArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F99 RID: 12185
		// (get) Token: 0x0600C51B RID: 50459 RVA: 0x00300B2C File Offset: 0x002FED2C
		public bool ShowInBag
		{
			get
			{
				int num = this.__p.__offset(32);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002F9A RID: 12186
		// (get) Token: 0x0600C51C RID: 50460 RVA: 0x00300B6C File Offset: 0x002FED6C
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

		// Token: 0x0600C51D RID: 50461 RVA: 0x00300BA9 File Offset: 0x002FEDA9
		[NullableContext(1)]
		public int[] ItemAccess()
		{
			return this.GetItemAccessArray();
		}

		// Token: 0x0600C51E RID: 50462 RVA: 0x00300BB1 File Offset: 0x002FEDB1
		[NullableContext(1)]
		public IEnumerable<int> ItemAccessIter()
		{
			RogueCurrency.<ItemAccessIter>d__64 <ItemAccessIter>d__ = new RogueCurrency.<ItemAccessIter>d__64(-2);
			<ItemAccessIter>d__.<>3__<>4__this = this;
			return <ItemAccessIter>d__;
		}

		// Token: 0x040056A2 RID: 22178
		private Table __p;
	}
}
