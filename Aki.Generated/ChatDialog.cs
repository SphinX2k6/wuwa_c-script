using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B6A RID: 2922
	public struct ChatDialog : IFlatbufferObject
	{
		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x0600538D RID: 21389 RVA: 0x001F1DE9 File Offset: 0x001EFFE9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600538E RID: 21390 RVA: 0x001F1DF6 File Offset: 0x001EFFF6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600538F RID: 21391 RVA: 0x001F1E00 File Offset: 0x001F0000
		public static ChatDialog GetRootAsChatDialog(ByteBuffer _bb)
		{
			return ChatDialog.GetRootAsChatDialog(_bb, default(ChatDialog));
		}

		// Token: 0x06005390 RID: 21392 RVA: 0x001F1E1C File Offset: 0x001F001C
		public static ChatDialog GetRootAsChatDialog(ByteBuffer _bb, ChatDialog obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005391 RID: 21393 RVA: 0x001F1E39 File Offset: 0x001F0039
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005392 RID: 21394 RVA: 0x001F1E48 File Offset: 0x001F0048
		public ChatDialog __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x06005393 RID: 21395 RVA: 0x001F1E58 File Offset: 0x001F0058
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

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x06005394 RID: 21396 RVA: 0x001F1E94 File Offset: 0x001F0094
		public string BgPath
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

		// Token: 0x06005395 RID: 21397 RVA: 0x001F1ECB File Offset: 0x001F00CB
		public Span<byte> GetBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005396 RID: 21398 RVA: 0x001F1EDA File Offset: 0x001F00DA
		public byte[] GetBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06005397 RID: 21399 RVA: 0x001F1EF4 File Offset: 0x001F00F4
		public string SpineItemPath
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

		// Token: 0x06005398 RID: 21400 RVA: 0x001F1F2B File Offset: 0x001F012B
		public Span<byte> GetSpineItemPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005399 RID: 21401 RVA: 0x001F1F3A File Offset: 0x001F013A
		public byte[] GetSpineItemPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x0600539A RID: 21402 RVA: 0x001F1F54 File Offset: 0x001F0154
		public string Name
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

		// Token: 0x0600539B RID: 21403 RVA: 0x001F1F8C File Offset: 0x001F018C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600539C RID: 21404 RVA: 0x001F1F9C File Offset: 0x001F019C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x0600539D RID: 21405 RVA: 0x001F1FB4 File Offset: 0x001F01B4
		public string Desc
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

		// Token: 0x0600539E RID: 21406 RVA: 0x001F1FEC File Offset: 0x001F01EC
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600539F RID: 21407 RVA: 0x001F1FFC File Offset: 0x001F01FC
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x060053A0 RID: 21408 RVA: 0x001F2014 File Offset: 0x001F0214
		public string GetWay
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

		// Token: 0x060053A1 RID: 21409 RVA: 0x001F204C File Offset: 0x001F024C
		public Span<byte> GetGetWayBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060053A2 RID: 21410 RVA: 0x001F205C File Offset: 0x001F025C
		public byte[] GetGetWayArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x060053A3 RID: 21411 RVA: 0x001F2074 File Offset: 0x001F0274
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

		// Token: 0x060053A4 RID: 21412 RVA: 0x001F20AC File Offset: 0x001F02AC
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060053A5 RID: 21413 RVA: 0x001F20BC File Offset: 0x001F02BC
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x060053A6 RID: 21414 RVA: 0x001F20D4 File Offset: 0x001F02D4
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

		// Token: 0x060053A7 RID: 21415 RVA: 0x001F210C File Offset: 0x001F030C
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060053A8 RID: 21416 RVA: 0x001F211C File Offset: 0x001F031C
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x060053A9 RID: 21417 RVA: 0x001F2134 File Offset: 0x001F0334
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

		// Token: 0x060053AA RID: 21418 RVA: 0x001F216C File Offset: 0x001F036C
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x060053AB RID: 21419 RVA: 0x001F217C File Offset: 0x001F037C
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x060053AC RID: 21420 RVA: 0x001F2194 File Offset: 0x001F0394
		public string TypeDescription
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

		// Token: 0x060053AD RID: 21421 RVA: 0x001F21CC File Offset: 0x001F03CC
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060053AE RID: 21422 RVA: 0x001F21DC File Offset: 0x001F03DC
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x060053AF RID: 21423 RVA: 0x001F21F4 File Offset: 0x001F03F4
		public string AttributesDescription
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

		// Token: 0x060053B0 RID: 21424 RVA: 0x001F222C File Offset: 0x001F042C
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060053B1 RID: 21425 RVA: 0x001F223C File Offset: 0x001F043C
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x060053B2 RID: 21426 RVA: 0x001F2254 File Offset: 0x001F0454
		public string BgDescription
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

		// Token: 0x060053B3 RID: 21427 RVA: 0x001F228C File Offset: 0x001F048C
		public Span<byte> GetBgDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x060053B4 RID: 21428 RVA: 0x001F229C File Offset: 0x001F049C
		public byte[] GetBgDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x060053B5 RID: 21429 RVA: 0x001F22B4 File Offset: 0x001F04B4
		public int ItemAccess(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x060053B6 RID: 21430 RVA: 0x001F22F4 File Offset: 0x001F04F4
		public int ItemAccessLength
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

		// Token: 0x060053B7 RID: 21431 RVA: 0x001F2320 File Offset: 0x001F0520
		public Span<int> GetItemAccessBytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x060053B8 RID: 21432 RVA: 0x001F2330 File Offset: 0x001F0530
		public int[] GetItemAccessArray()
		{
			return this.__p.__vector_as_array<int>(28) ?? Array.Empty<int>();
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x060053B9 RID: 21433 RVA: 0x001F2348 File Offset: 0x001F0548
		public int QualityId
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x060053BA RID: 21434 RVA: 0x001F2388 File Offset: 0x001F0588
		public int SortId
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x060053BB RID: 21435 RVA: 0x001F23C8 File Offset: 0x001F05C8
		public string TextColor
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

		// Token: 0x060053BC RID: 21436 RVA: 0x001F2400 File Offset: 0x001F0600
		public Span<byte> GetTextColorBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x060053BD RID: 21437 RVA: 0x001F2410 File Offset: 0x001F0610
		public byte[] GetTextColorArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x060053BE RID: 21438 RVA: 0x001F2428 File Offset: 0x001F0628
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ItemAccessIter()或GetItemAccessBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ItemAccess()
		{
			ChatDialog chatDialog = this;
			return chatDialog.GetItemAccessArray() ?? Array.Empty<int>();
		}

		// Token: 0x060053BF RID: 21439 RVA: 0x001F244C File Offset: 0x001F064C
		[NullableContext(1)]
		public readonly IEnumerable<int> ItemAccessIter()
		{
			ChatDialog.<ItemAccessIter>d__68 <ItemAccessIter>d__ = new ChatDialog.<ItemAccessIter>d__68(-2);
			<ItemAccessIter>d__.<>3__<>4__this = this;
			return <ItemAccessIter>d__;
		}

		// Token: 0x04004B6C RID: 19308
		private Table __p;
	}
}
