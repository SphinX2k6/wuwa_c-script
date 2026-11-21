using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001225 RID: 4645
	public struct SpringResource : IFlatbufferObject
	{
		// Token: 0x17003BA4 RID: 15268
		// (get) Token: 0x0600E667 RID: 58983 RVA: 0x0034C16D File Offset: 0x0034A36D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E668 RID: 58984 RVA: 0x0034C17A File Offset: 0x0034A37A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E669 RID: 58985 RVA: 0x0034C184 File Offset: 0x0034A384
		public static SpringResource GetRootAsSpringResource(ByteBuffer _bb)
		{
			return SpringResource.GetRootAsSpringResource(_bb, default(SpringResource));
		}

		// Token: 0x0600E66A RID: 58986 RVA: 0x0034C1A0 File Offset: 0x0034A3A0
		public static SpringResource GetRootAsSpringResource(ByteBuffer _bb, SpringResource obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E66B RID: 58987 RVA: 0x0034C1BD File Offset: 0x0034A3BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E66C RID: 58988 RVA: 0x0034C1CC File Offset: 0x0034A3CC
		public SpringResource __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003BA5 RID: 15269
		// (get) Token: 0x0600E66D RID: 58989 RVA: 0x0034C1DC File Offset: 0x0034A3DC
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

		// Token: 0x17003BA6 RID: 15270
		// (get) Token: 0x0600E66E RID: 58990 RVA: 0x0034C218 File Offset: 0x0034A418
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

		// Token: 0x17003BA7 RID: 15271
		// (get) Token: 0x0600E66F RID: 58991 RVA: 0x0034C254 File Offset: 0x0034A454
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

		// Token: 0x17003BA8 RID: 15272
		// (get) Token: 0x0600E670 RID: 58992 RVA: 0x0034C290 File Offset: 0x0034A490
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

		// Token: 0x0600E671 RID: 58993 RVA: 0x0034C2C8 File Offset: 0x0034A4C8
		public Span<byte> GetRoleNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600E672 RID: 58994 RVA: 0x0034C2D8 File Offset: 0x0034A4D8
		public byte[] GetRoleNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003BA9 RID: 15273
		// (get) Token: 0x0600E673 RID: 58995 RVA: 0x0034C2F0 File Offset: 0x0034A4F0
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

		// Token: 0x0600E674 RID: 58996 RVA: 0x0034C330 File Offset: 0x0034A530
		public int DialogDataList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003BAA RID: 15274
		// (get) Token: 0x0600E675 RID: 58997 RVA: 0x0034C370 File Offset: 0x0034A570
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

		// Token: 0x0600E676 RID: 58998 RVA: 0x0034C39C File Offset: 0x0034A59C
		public Span<int> GetDialogDataListBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600E677 RID: 58999 RVA: 0x0034C3AC File Offset: 0x0034A5AC
		public int[] GetDialogDataListArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17003BAB RID: 15275
		// (get) Token: 0x0600E678 RID: 59000 RVA: 0x0034C3C4 File Offset: 0x0034A5C4
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

		// Token: 0x0600E679 RID: 59001 RVA: 0x0034C3FC File Offset: 0x0034A5FC
		public Span<byte> GetMailIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600E67A RID: 59002 RVA: 0x0034C40C File Offset: 0x0034A60C
		public byte[] GetMailIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003BAC RID: 15276
		// (get) Token: 0x0600E67B RID: 59003 RVA: 0x0034C424 File Offset: 0x0034A624
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

		// Token: 0x0600E67C RID: 59004 RVA: 0x0034C45C File Offset: 0x0034A65C
		public Span<byte> GetLetterContentBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600E67D RID: 59005 RVA: 0x0034C46C File Offset: 0x0034A66C
		public byte[] GetLetterContentArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17003BAD RID: 15277
		// (get) Token: 0x0600E67E RID: 59006 RVA: 0x0034C484 File Offset: 0x0034A684
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

		// Token: 0x0600E67F RID: 59007 RVA: 0x0034C4BC File Offset: 0x0034A6BC
		public Span<byte> GetLetterTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600E680 RID: 59008 RVA: 0x0034C4CC File Offset: 0x0034A6CC
		public byte[] GetLetterTitleArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17003BAE RID: 15278
		// (get) Token: 0x0600E681 RID: 59009 RVA: 0x0034C4E4 File Offset: 0x0034A6E4
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

		// Token: 0x0600E682 RID: 59010 RVA: 0x0034C51C File Offset: 0x0034A71C
		public Span<byte> GetLetterTabBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600E683 RID: 59011 RVA: 0x0034C52C File Offset: 0x0034A72C
		public byte[] GetLetterTabArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17003BAF RID: 15279
		// (get) Token: 0x0600E684 RID: 59012 RVA: 0x0034C544 File Offset: 0x0034A744
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

		// Token: 0x0600E685 RID: 59013 RVA: 0x0034C57C File Offset: 0x0034A77C
		public Span<byte> GetLeftSpineAtlasBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600E686 RID: 59014 RVA: 0x0034C58C File Offset: 0x0034A78C
		public byte[] GetLeftSpineAtlasArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17003BB0 RID: 15280
		// (get) Token: 0x0600E687 RID: 59015 RVA: 0x0034C5A4 File Offset: 0x0034A7A4
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

		// Token: 0x0600E688 RID: 59016 RVA: 0x0034C5DC File Offset: 0x0034A7DC
		public Span<byte> GetLeftSpineSkeletonDataBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600E689 RID: 59017 RVA: 0x0034C5EC File Offset: 0x0034A7EC
		public byte[] GetLeftSpineSkeletonDataArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17003BB1 RID: 15281
		// (get) Token: 0x0600E68A RID: 59018 RVA: 0x0034C604 File Offset: 0x0034A804
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

		// Token: 0x0600E68B RID: 59019 RVA: 0x0034C63C File Offset: 0x0034A83C
		public Span<byte> GetRightSpineAtlasBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600E68C RID: 59020 RVA: 0x0034C64C File Offset: 0x0034A84C
		public byte[] GetRightSpineAtlasArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17003BB2 RID: 15282
		// (get) Token: 0x0600E68D RID: 59021 RVA: 0x0034C664 File Offset: 0x0034A864
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

		// Token: 0x0600E68E RID: 59022 RVA: 0x0034C69C File Offset: 0x0034A89C
		public Span<byte> GetRightSpineSkeletonDataBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600E68F RID: 59023 RVA: 0x0034C6AC File Offset: 0x0034A8AC
		public byte[] GetRightSpineSkeletonDataArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17003BB3 RID: 15283
		// (get) Token: 0x0600E690 RID: 59024 RVA: 0x0034C6C4 File Offset: 0x0034A8C4
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

		// Token: 0x0600E691 RID: 59025 RVA: 0x0034C6FC File Offset: 0x0034A8FC
		public Span<byte> GetLeftDialogBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600E692 RID: 59026 RVA: 0x0034C70C File Offset: 0x0034A90C
		public byte[] GetLeftDialogArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17003BB4 RID: 15284
		// (get) Token: 0x0600E693 RID: 59027 RVA: 0x0034C724 File Offset: 0x0034A924
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

		// Token: 0x0600E694 RID: 59028 RVA: 0x0034C75C File Offset: 0x0034A95C
		public Span<byte> GetRightDialogBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600E695 RID: 59029 RVA: 0x0034C76C File Offset: 0x0034A96C
		public byte[] GetRightDialogArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E696 RID: 59030 RVA: 0x0034C784 File Offset: 0x0034A984
		[NullableContext(1)]
		public int[] DialogDataList()
		{
			return this.GetDialogDataListArray();
		}

		// Token: 0x0600E697 RID: 59031 RVA: 0x0034C78C File Offset: 0x0034A98C
		[NullableContext(1)]
		public IEnumerable<int> DialogDataListIter()
		{
			SpringResource.<DialogDataListIter>d__66 <DialogDataListIter>d__ = new SpringResource.<DialogDataListIter>d__66(-2);
			<DialogDataListIter>d__.<>3__<>4__this = this;
			return <DialogDataListIter>d__;
		}

		// Token: 0x04005866 RID: 22630
		private Table __p;
	}
}
