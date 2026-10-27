using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B3F RID: 2879
	public struct BookItem : IFlatbufferObject
	{
		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06004E1C RID: 19996 RVA: 0x001E5658 File Offset: 0x001E3858
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004E1D RID: 19997 RVA: 0x001E5665 File Offset: 0x001E3865
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004E1E RID: 19998 RVA: 0x001E566C File Offset: 0x001E386C
		public static BookItem GetRootAsBookItem(ByteBuffer _bb)
		{
			return BookItem.GetRootAsBookItem(_bb, default(BookItem));
		}

		// Token: 0x06004E1F RID: 19999 RVA: 0x001E5688 File Offset: 0x001E3888
		public static BookItem GetRootAsBookItem(ByteBuffer _bb, BookItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004E20 RID: 20000 RVA: 0x001E56A5 File Offset: 0x001E38A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004E21 RID: 20001 RVA: 0x001E56B4 File Offset: 0x001E38B4
		public BookItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06004E22 RID: 20002 RVA: 0x001E56C4 File Offset: 0x001E38C4
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

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06004E23 RID: 20003 RVA: 0x001E5700 File Offset: 0x001E3900
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

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06004E24 RID: 20004 RVA: 0x001E573C File Offset: 0x001E393C
		public int ConditionGroup
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

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06004E25 RID: 20005 RVA: 0x001E5778 File Offset: 0x001E3978
		public int DroptId
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

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06004E26 RID: 20006 RVA: 0x001E57B8 File Offset: 0x001E39B8
		public int TeleportEntityId
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

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06004E27 RID: 20007 RVA: 0x001E57F8 File Offset: 0x001E39F8
		public string GuideTitle
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

		// Token: 0x06004E28 RID: 20008 RVA: 0x001E5830 File Offset: 0x001E3A30
		public Span<byte> GetGuideTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06004E29 RID: 20009 RVA: 0x001E5840 File Offset: 0x001E3A40
		public byte[] GetGuideTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06004E2A RID: 20010 RVA: 0x001E5858 File Offset: 0x001E3A58
		public string GuideText
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

		// Token: 0x06004E2B RID: 20011 RVA: 0x001E5890 File Offset: 0x001E3A90
		public Span<byte> GetGuideTextBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06004E2C RID: 20012 RVA: 0x001E58A0 File Offset: 0x001E3AA0
		public byte[] GetGuideTextArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06004E2D RID: 20013 RVA: 0x001E58B8 File Offset: 0x001E3AB8
		public string DescriptionText
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

		// Token: 0x06004E2E RID: 20014 RVA: 0x001E58F0 File Offset: 0x001E3AF0
		public Span<byte> GetDescriptionTextBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06004E2F RID: 20015 RVA: 0x001E5900 File Offset: 0x001E3B00
		public byte[] GetDescriptionTextArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06004E30 RID: 20016 RVA: 0x001E5918 File Offset: 0x001E3B18
		public string DescriptionTitle
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

		// Token: 0x06004E31 RID: 20017 RVA: 0x001E5950 File Offset: 0x001E3B50
		public Span<byte> GetDescriptionTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06004E32 RID: 20018 RVA: 0x001E5960 File Offset: 0x001E3B60
		public byte[] GetDescriptionTitleArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06004E33 RID: 20019 RVA: 0x001E5978 File Offset: 0x001E3B78
		public string LockIcon
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

		// Token: 0x06004E34 RID: 20020 RVA: 0x001E59B0 File Offset: 0x001E3BB0
		public Span<byte> GetLockIconBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06004E35 RID: 20021 RVA: 0x001E59C0 File Offset: 0x001E3BC0
		public byte[] GetLockIconArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06004E36 RID: 20022 RVA: 0x001E59D8 File Offset: 0x001E3BD8
		public string UnlockIcon
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

		// Token: 0x06004E37 RID: 20023 RVA: 0x001E5A10 File Offset: 0x001E3C10
		public Span<byte> GetUnlockIconBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06004E38 RID: 20024 RVA: 0x001E5A20 File Offset: 0x001E3C20
		public byte[] GetUnlockIconArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06004E39 RID: 20025 RVA: 0x001E5A38 File Offset: 0x001E3C38
		public string ScreenIconPath
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

		// Token: 0x06004E3A RID: 20026 RVA: 0x001E5A70 File Offset: 0x001E3C70
		public Span<byte> GetScreenIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06004E3B RID: 20027 RVA: 0x001E5A80 File Offset: 0x001E3C80
		public byte[] GetScreenIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06004E3C RID: 20028 RVA: 0x001E5A98 File Offset: 0x001E3C98
		public string ScreenIconDonePath
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

		// Token: 0x06004E3D RID: 20029 RVA: 0x001E5AD0 File Offset: 0x001E3CD0
		public Span<byte> GetScreenIconDonePathBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06004E3E RID: 20030 RVA: 0x001E5AE0 File Offset: 0x001E3CE0
		public byte[] GetScreenIconDonePathArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06004E3F RID: 20031 RVA: 0x001E5AF8 File Offset: 0x001E3CF8
		public string IllustrationPath
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

		// Token: 0x06004E40 RID: 20032 RVA: 0x001E5B30 File Offset: 0x001E3D30
		public Span<byte> GetIllustrationPathBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06004E41 RID: 20033 RVA: 0x001E5B40 File Offset: 0x001E3D40
		public byte[] GetIllustrationPathArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06004E42 RID: 20034 RVA: 0x001E5B58 File Offset: 0x001E3D58
		public string PohtoPath
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

		// Token: 0x06004E43 RID: 20035 RVA: 0x001E5B90 File Offset: 0x001E3D90
		public Span<byte> GetPohtoPathBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06004E44 RID: 20036 RVA: 0x001E5BA0 File Offset: 0x001E3DA0
		public byte[] GetPohtoPathArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06004E45 RID: 20037 RVA: 0x001E5BB8 File Offset: 0x001E3DB8
		public string GirlPohtoPath
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

		// Token: 0x06004E46 RID: 20038 RVA: 0x001E5BF0 File Offset: 0x001E3DF0
		public Span<byte> GetGirlPohtoPathBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06004E47 RID: 20039 RVA: 0x001E5C00 File Offset: 0x001E3E00
		public byte[] GetGirlPohtoPathArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x06004E48 RID: 20040 RVA: 0x001E5C18 File Offset: 0x001E3E18
		public int TeleportRotator(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06004E49 RID: 20041 RVA: 0x001E5C58 File Offset: 0x001E3E58
		public int TeleportRotatorLength
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06004E4A RID: 20042 RVA: 0x001E5C84 File Offset: 0x001E3E84
		public Span<int> GetTeleportRotatorBytes()
		{
			return this.__p.__vector_as_span<int>(36, 4);
		}

		// Token: 0x06004E4B RID: 20043 RVA: 0x001E5C94 File Offset: 0x001E3E94
		public int[] GetTeleportRotatorArray()
		{
			return this.__p.__vector_as_array<int>(36) ?? Array.Empty<int>();
		}

		// Token: 0x06004E4C RID: 20044 RVA: 0x001E5CAC File Offset: 0x001E3EAC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TeleportRotatorIter()或GetTeleportRotatorBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] TeleportRotator()
		{
			BookItem bookItem = this;
			return bookItem.GetTeleportRotatorArray() ?? Array.Empty<int>();
		}

		// Token: 0x06004E4D RID: 20045 RVA: 0x001E5CD0 File Offset: 0x001E3ED0
		[NullableContext(1)]
		public readonly IEnumerable<int> TeleportRotatorIter()
		{
			BookItem.<TeleportRotatorIter>d__68 <TeleportRotatorIter>d__ = new BookItem.<TeleportRotatorIter>d__68(-2);
			<TeleportRotatorIter>d__.<>3__<>4__this = this;
			return <TeleportRotatorIter>d__;
		}

		// Token: 0x04004B3A RID: 19258
		private Table __p;
	}
}
