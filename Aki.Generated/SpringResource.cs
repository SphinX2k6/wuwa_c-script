using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010EF RID: 4335
	public struct SpringResource : IFlatbufferObject
	{
		// Token: 0x1700384E RID: 14414
		// (get) Token: 0x0600D91C RID: 55580 RVA: 0x00320BE9 File Offset: 0x0031EDE9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D91D RID: 55581 RVA: 0x00320BF6 File Offset: 0x0031EDF6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D91E RID: 55582 RVA: 0x00320C00 File Offset: 0x0031EE00
		public static SpringResource GetRootAsSpringResource(ByteBuffer _bb)
		{
			return SpringResource.GetRootAsSpringResource(_bb, default(SpringResource));
		}

		// Token: 0x0600D91F RID: 55583 RVA: 0x00320C1C File Offset: 0x0031EE1C
		public static SpringResource GetRootAsSpringResource(ByteBuffer _bb, SpringResource obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D920 RID: 55584 RVA: 0x00320C39 File Offset: 0x0031EE39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D921 RID: 55585 RVA: 0x00320C48 File Offset: 0x0031EE48
		public SpringResource __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700384F RID: 14415
		// (get) Token: 0x0600D922 RID: 55586 RVA: 0x00320C58 File Offset: 0x0031EE58
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

		// Token: 0x17003850 RID: 14416
		// (get) Token: 0x0600D923 RID: 55587 RVA: 0x00320C94 File Offset: 0x0031EE94
		public int RoleType
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

		// Token: 0x17003851 RID: 14417
		// (get) Token: 0x0600D924 RID: 55588 RVA: 0x00320CD0 File Offset: 0x0031EED0
		public int IsClientOnly
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

		// Token: 0x17003852 RID: 14418
		// (get) Token: 0x0600D925 RID: 55589 RVA: 0x00320D0C File Offset: 0x0031EF0C
		public string RoleName
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

		// Token: 0x0600D926 RID: 55590 RVA: 0x00320D44 File Offset: 0x0031EF44
		public Span<byte> GetRoleNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D927 RID: 55591 RVA: 0x00320D54 File Offset: 0x0031EF54
		public byte[] GetRoleNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003853 RID: 14419
		// (get) Token: 0x0600D928 RID: 55592 RVA: 0x00320D6C File Offset: 0x0031EF6C
		public int DialogData
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

		// Token: 0x0600D929 RID: 55593 RVA: 0x00320DAC File Offset: 0x0031EFAC
		public int DialogDataList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003854 RID: 14420
		// (get) Token: 0x0600D92A RID: 55594 RVA: 0x00320DEC File Offset: 0x0031EFEC
		public int DialogDataListLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D92B RID: 55595 RVA: 0x00320E18 File Offset: 0x0031F018
		public Span<int> GetDialogDataListBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600D92C RID: 55596 RVA: 0x00320E28 File Offset: 0x0031F028
		public int[] GetDialogDataListArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17003855 RID: 14421
		// (get) Token: 0x0600D92D RID: 55597 RVA: 0x00320E40 File Offset: 0x0031F040
		public string MailIcon
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

		// Token: 0x0600D92E RID: 55598 RVA: 0x00320E78 File Offset: 0x0031F078
		public Span<byte> GetMailIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600D92F RID: 55599 RVA: 0x00320E88 File Offset: 0x0031F088
		public byte[] GetMailIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003856 RID: 14422
		// (get) Token: 0x0600D930 RID: 55600 RVA: 0x00320EA0 File Offset: 0x0031F0A0
		public string LetterContent
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

		// Token: 0x0600D931 RID: 55601 RVA: 0x00320ED8 File Offset: 0x0031F0D8
		public Span<byte> GetLetterContentBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600D932 RID: 55602 RVA: 0x00320EE8 File Offset: 0x0031F0E8
		public byte[] GetLetterContentArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17003857 RID: 14423
		// (get) Token: 0x0600D933 RID: 55603 RVA: 0x00320F00 File Offset: 0x0031F100
		public string LetterTitle
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

		// Token: 0x0600D934 RID: 55604 RVA: 0x00320F38 File Offset: 0x0031F138
		public Span<byte> GetLetterTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600D935 RID: 55605 RVA: 0x00320F48 File Offset: 0x0031F148
		public byte[] GetLetterTitleArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17003858 RID: 14424
		// (get) Token: 0x0600D936 RID: 55606 RVA: 0x00320F60 File Offset: 0x0031F160
		public string LetterTab
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

		// Token: 0x0600D937 RID: 55607 RVA: 0x00320F98 File Offset: 0x0031F198
		public Span<byte> GetLetterTabBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600D938 RID: 55608 RVA: 0x00320FA8 File Offset: 0x0031F1A8
		public byte[] GetLetterTabArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17003859 RID: 14425
		// (get) Token: 0x0600D939 RID: 55609 RVA: 0x00320FC0 File Offset: 0x0031F1C0
		public string LeftSpineAtlas
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

		// Token: 0x0600D93A RID: 55610 RVA: 0x00320FF8 File Offset: 0x0031F1F8
		public Span<byte> GetLeftSpineAtlasBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600D93B RID: 55611 RVA: 0x00321008 File Offset: 0x0031F208
		public byte[] GetLeftSpineAtlasArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x1700385A RID: 14426
		// (get) Token: 0x0600D93C RID: 55612 RVA: 0x00321020 File Offset: 0x0031F220
		public string LeftSpineSkeletonData
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

		// Token: 0x0600D93D RID: 55613 RVA: 0x00321058 File Offset: 0x0031F258
		public Span<byte> GetLeftSpineSkeletonDataBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600D93E RID: 55614 RVA: 0x00321068 File Offset: 0x0031F268
		public byte[] GetLeftSpineSkeletonDataArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x1700385B RID: 14427
		// (get) Token: 0x0600D93F RID: 55615 RVA: 0x00321080 File Offset: 0x0031F280
		public string RightSpineAtlas
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

		// Token: 0x0600D940 RID: 55616 RVA: 0x003210B8 File Offset: 0x0031F2B8
		public Span<byte> GetRightSpineAtlasBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600D941 RID: 55617 RVA: 0x003210C8 File Offset: 0x0031F2C8
		public byte[] GetRightSpineAtlasArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x1700385C RID: 14428
		// (get) Token: 0x0600D942 RID: 55618 RVA: 0x003210E0 File Offset: 0x0031F2E0
		public string RightSpineSkeletonData
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

		// Token: 0x0600D943 RID: 55619 RVA: 0x00321118 File Offset: 0x0031F318
		public Span<byte> GetRightSpineSkeletonDataBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600D944 RID: 55620 RVA: 0x00321128 File Offset: 0x0031F328
		public byte[] GetRightSpineSkeletonDataArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x1700385D RID: 14429
		// (get) Token: 0x0600D945 RID: 55621 RVA: 0x00321140 File Offset: 0x0031F340
		public string LeftDialog
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

		// Token: 0x0600D946 RID: 55622 RVA: 0x00321178 File Offset: 0x0031F378
		public Span<byte> GetLeftDialogBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600D947 RID: 55623 RVA: 0x00321188 File Offset: 0x0031F388
		public byte[] GetLeftDialogArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x1700385E RID: 14430
		// (get) Token: 0x0600D948 RID: 55624 RVA: 0x003211A0 File Offset: 0x0031F3A0
		public string RightDialog
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

		// Token: 0x0600D949 RID: 55625 RVA: 0x003211D8 File Offset: 0x0031F3D8
		public Span<byte> GetRightDialogBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600D94A RID: 55626 RVA: 0x003211E8 File Offset: 0x0031F3E8
		public byte[] GetRightDialogArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D94B RID: 55627 RVA: 0x00321200 File Offset: 0x0031F400
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DialogDataListIter()或GetDialogDataListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] DialogDataList()
		{
			SpringResource springResource = this;
			return springResource.GetDialogDataListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D94C RID: 55628 RVA: 0x00321224 File Offset: 0x0031F424
		[NullableContext(1)]
		public readonly IEnumerable<int> DialogDataListIter()
		{
			SpringResource.<DialogDataListIter>d__66 <DialogDataListIter>d__ = new SpringResource.<DialogDataListIter>d__66(-2);
			<DialogDataListIter>d__.<>3__<>4__this = this;
			return <DialogDataListIter>d__;
		}

		// Token: 0x04005223 RID: 21027
		private Table __p;
	}
}
