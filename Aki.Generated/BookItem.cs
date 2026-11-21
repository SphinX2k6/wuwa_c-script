using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C1F RID: 3103
	public struct BookItem : IFlatbufferObject
	{
		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x060053DE RID: 21470 RVA: 0x00205980 File Offset: 0x00203B80
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060053DF RID: 21471 RVA: 0x0020598D File Offset: 0x00203B8D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060053E0 RID: 21472 RVA: 0x00205994 File Offset: 0x00203B94
		public static BookItem GetRootAsBookItem(ByteBuffer _bb)
		{
			return BookItem.GetRootAsBookItem(_bb, default(BookItem));
		}

		// Token: 0x060053E1 RID: 21473 RVA: 0x002059B0 File Offset: 0x00203BB0
		public static BookItem GetRootAsBookItem(ByteBuffer _bb, BookItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060053E2 RID: 21474 RVA: 0x002059CD File Offset: 0x00203BCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060053E3 RID: 21475 RVA: 0x002059DC File Offset: 0x00203BDC
		public BookItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x060053E4 RID: 21476 RVA: 0x002059EC File Offset: 0x00203BEC
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

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x060053E5 RID: 21477 RVA: 0x00205A28 File Offset: 0x00203C28
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

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x060053E6 RID: 21478 RVA: 0x00205A64 File Offset: 0x00203C64
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

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x060053E7 RID: 21479 RVA: 0x00205AA0 File Offset: 0x00203CA0
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

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x060053E8 RID: 21480 RVA: 0x00205AE0 File Offset: 0x00203CE0
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

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x060053E9 RID: 21481 RVA: 0x00205B20 File Offset: 0x00203D20
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

		// Token: 0x060053EA RID: 21482 RVA: 0x00205B58 File Offset: 0x00203D58
		public Span<byte> GetGuideTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060053EB RID: 21483 RVA: 0x00205B68 File Offset: 0x00203D68
		public byte[] GetGuideTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x060053EC RID: 21484 RVA: 0x00205B80 File Offset: 0x00203D80
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

		// Token: 0x060053ED RID: 21485 RVA: 0x00205BB8 File Offset: 0x00203DB8
		public Span<byte> GetGuideTextBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060053EE RID: 21486 RVA: 0x00205BC8 File Offset: 0x00203DC8
		public byte[] GetGuideTextArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x060053EF RID: 21487 RVA: 0x00205BE0 File Offset: 0x00203DE0
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

		// Token: 0x060053F0 RID: 21488 RVA: 0x00205C18 File Offset: 0x00203E18
		public Span<byte> GetDescriptionTextBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060053F1 RID: 21489 RVA: 0x00205C28 File Offset: 0x00203E28
		public byte[] GetDescriptionTextArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x060053F2 RID: 21490 RVA: 0x00205C40 File Offset: 0x00203E40
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

		// Token: 0x060053F3 RID: 21491 RVA: 0x00205C78 File Offset: 0x00203E78
		public Span<byte> GetDescriptionTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x060053F4 RID: 21492 RVA: 0x00205C88 File Offset: 0x00203E88
		public byte[] GetDescriptionTitleArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x060053F5 RID: 21493 RVA: 0x00205CA0 File Offset: 0x00203EA0
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

		// Token: 0x060053F6 RID: 21494 RVA: 0x00205CD8 File Offset: 0x00203ED8
		public Span<byte> GetLockIconBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060053F7 RID: 21495 RVA: 0x00205CE8 File Offset: 0x00203EE8
		public byte[] GetLockIconArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x060053F8 RID: 21496 RVA: 0x00205D00 File Offset: 0x00203F00
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

		// Token: 0x060053F9 RID: 21497 RVA: 0x00205D38 File Offset: 0x00203F38
		public Span<byte> GetUnlockIconBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060053FA RID: 21498 RVA: 0x00205D48 File Offset: 0x00203F48
		public byte[] GetUnlockIconArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x060053FB RID: 21499 RVA: 0x00205D60 File Offset: 0x00203F60
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

		// Token: 0x060053FC RID: 21500 RVA: 0x00205D98 File Offset: 0x00203F98
		public Span<byte> GetScreenIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x060053FD RID: 21501 RVA: 0x00205DA8 File Offset: 0x00203FA8
		public byte[] GetScreenIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x060053FE RID: 21502 RVA: 0x00205DC0 File Offset: 0x00203FC0
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

		// Token: 0x060053FF RID: 21503 RVA: 0x00205DF8 File Offset: 0x00203FF8
		public Span<byte> GetScreenIconDonePathBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06005400 RID: 21504 RVA: 0x00205E08 File Offset: 0x00204008
		public byte[] GetScreenIconDonePathArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06005401 RID: 21505 RVA: 0x00205E20 File Offset: 0x00204020
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

		// Token: 0x06005402 RID: 21506 RVA: 0x00205E58 File Offset: 0x00204058
		public Span<byte> GetIllustrationPathBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06005403 RID: 21507 RVA: 0x00205E68 File Offset: 0x00204068
		public byte[] GetIllustrationPathArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06005404 RID: 21508 RVA: 0x00205E80 File Offset: 0x00204080
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

		// Token: 0x06005405 RID: 21509 RVA: 0x00205EB8 File Offset: 0x002040B8
		public Span<byte> GetPohtoPathBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06005406 RID: 21510 RVA: 0x00205EC8 File Offset: 0x002040C8
		public byte[] GetPohtoPathArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06005407 RID: 21511 RVA: 0x00205EE0 File Offset: 0x002040E0
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

		// Token: 0x06005408 RID: 21512 RVA: 0x00205F18 File Offset: 0x00204118
		public Span<byte> GetGirlPohtoPathBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06005409 RID: 21513 RVA: 0x00205F28 File Offset: 0x00204128
		public byte[] GetGirlPohtoPathArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x0600540A RID: 21514 RVA: 0x00205F40 File Offset: 0x00204140
		public int TeleportRotator(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x0600540B RID: 21515 RVA: 0x00205F80 File Offset: 0x00204180
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

		// Token: 0x0600540C RID: 21516 RVA: 0x00205FAC File Offset: 0x002041AC
		public Span<int> GetTeleportRotatorBytes()
		{
			return this.__p.__vector_as_span<int>(36, 4);
		}

		// Token: 0x0600540D RID: 21517 RVA: 0x00205FBC File Offset: 0x002041BC
		public int[] GetTeleportRotatorArray()
		{
			return this.__p.__vector_as_array<int>(36) ?? Array.Empty<int>();
		}

		// Token: 0x0600540E RID: 21518 RVA: 0x00205FD4 File Offset: 0x002041D4
		[NullableContext(1)]
		public int[] TeleportRotator()
		{
			return this.GetTeleportRotatorArray();
		}

		// Token: 0x0600540F RID: 21519 RVA: 0x00205FDC File Offset: 0x002041DC
		[NullableContext(1)]
		public IEnumerable<int> TeleportRotatorIter()
		{
			BookItem.<TeleportRotatorIter>d__68 <TeleportRotatorIter>d__ = new BookItem.<TeleportRotatorIter>d__68(-2);
			<TeleportRotatorIter>d__.<>3__<>4__this = this;
			return <TeleportRotatorIter>d__;
		}

		// Token: 0x0400511A RID: 20762
		private Table __p;
	}
}
