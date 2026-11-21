using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CAA RID: 3242
	public struct DangoBrawlOccupation : IFlatbufferObject
	{
		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x06006420 RID: 25632 RVA: 0x0022A5A4 File Offset: 0x002287A4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006421 RID: 25633 RVA: 0x0022A5B1 File Offset: 0x002287B1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006422 RID: 25634 RVA: 0x0022A5B8 File Offset: 0x002287B8
		public static DangoBrawlOccupation GetRootAsDangoBrawlOccupation(ByteBuffer _bb)
		{
			return DangoBrawlOccupation.GetRootAsDangoBrawlOccupation(_bb, default(DangoBrawlOccupation));
		}

		// Token: 0x06006423 RID: 25635 RVA: 0x0022A5D4 File Offset: 0x002287D4
		public static DangoBrawlOccupation GetRootAsDangoBrawlOccupation(ByteBuffer _bb, DangoBrawlOccupation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006424 RID: 25636 RVA: 0x0022A5F1 File Offset: 0x002287F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006425 RID: 25637 RVA: 0x0022A600 File Offset: 0x00228800
		public DangoBrawlOccupation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x06006426 RID: 25638 RVA: 0x0022A610 File Offset: 0x00228810
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

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x06006427 RID: 25639 RVA: 0x0022A64C File Offset: 0x0022884C
		public int WobblePlateId
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

		// Token: 0x06006428 RID: 25640 RVA: 0x0022A688 File Offset: 0x00228888
		public DicIntInt? AccumulatePro(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x06006429 RID: 25641 RVA: 0x0022A6E8 File Offset: 0x002288E8
		public int AccumulateProLength
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

		// Token: 0x0600642A RID: 25642 RVA: 0x0022A714 File Offset: 0x00228914
		public int CoreItemAttr(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x0600642B RID: 25643 RVA: 0x0022A754 File Offset: 0x00228954
		public int CoreItemAttrLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600642C RID: 25644 RVA: 0x0022A780 File Offset: 0x00228980
		public Span<int> GetCoreItemAttrBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600642D RID: 25645 RVA: 0x0022A790 File Offset: 0x00228990
		public int[] GetCoreItemAttrArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x0600642E RID: 25646 RVA: 0x0022A7A8 File Offset: 0x002289A8
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

		// Token: 0x0600642F RID: 25647 RVA: 0x0022A7E0 File Offset: 0x002289E0
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06006430 RID: 25648 RVA: 0x0022A7F0 File Offset: 0x002289F0
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x06006431 RID: 25649 RVA: 0x0022A808 File Offset: 0x00228A08
		public string RoleName
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

		// Token: 0x06006432 RID: 25650 RVA: 0x0022A840 File Offset: 0x00228A40
		public Span<byte> GetRoleNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06006433 RID: 25651 RVA: 0x0022A850 File Offset: 0x00228A50
		public byte[] GetRoleNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x06006434 RID: 25652 RVA: 0x0022A868 File Offset: 0x00228A68
		public string Color
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

		// Token: 0x06006435 RID: 25653 RVA: 0x0022A8A0 File Offset: 0x00228AA0
		public Span<byte> GetColorBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06006436 RID: 25654 RVA: 0x0022A8B0 File Offset: 0x00228AB0
		public byte[] GetColorArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x06006437 RID: 25655 RVA: 0x0022A8C8 File Offset: 0x00228AC8
		public string ColorBackpack
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

		// Token: 0x06006438 RID: 25656 RVA: 0x0022A900 File Offset: 0x00228B00
		public Span<byte> GetColorBackpackBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06006439 RID: 25657 RVA: 0x0022A910 File Offset: 0x00228B10
		public byte[] GetColorBackpackArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600643A RID: 25658 RVA: 0x0022A928 File Offset: 0x00228B28
		public string SpineAtlasPaths(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x0600643B RID: 25659 RVA: 0x0022A964 File Offset: 0x00228B64
		public int SpineAtlasPathsLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600643C RID: 25660 RVA: 0x0022A990 File Offset: 0x00228B90
		public string SpineSkeletonDataPaths(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x0600643D RID: 25661 RVA: 0x0022A9CC File Offset: 0x00228BCC
		public int SpineSkeletonDataPathsLength
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

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x0600643E RID: 25662 RVA: 0x0022A9F8 File Offset: 0x00228BF8
		public string SpineAnim
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

		// Token: 0x0600643F RID: 25663 RVA: 0x0022AA30 File Offset: 0x00228C30
		public Span<byte> GetSpineAnimBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06006440 RID: 25664 RVA: 0x0022AA40 File Offset: 0x00228C40
		public byte[] GetSpineAnimArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x06006441 RID: 25665 RVA: 0x0022AA58 File Offset: 0x00228C58
		public string Icon
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

		// Token: 0x06006442 RID: 25666 RVA: 0x0022AA90 File Offset: 0x00228C90
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06006443 RID: 25667 RVA: 0x0022AAA0 File Offset: 0x00228CA0
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x06006444 RID: 25668 RVA: 0x0022AAB8 File Offset: 0x00228CB8
		public string IconTitle(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x06006445 RID: 25669 RVA: 0x0022AAF4 File Offset: 0x00228CF4
		public int IconTitleLength
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

		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x06006446 RID: 25670 RVA: 0x0022AB20 File Offset: 0x00228D20
		public string IconSmall
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

		// Token: 0x06006447 RID: 25671 RVA: 0x0022AB58 File Offset: 0x00228D58
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06006448 RID: 25672 RVA: 0x0022AB68 File Offset: 0x00228D68
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x06006449 RID: 25673 RVA: 0x0022AB80 File Offset: 0x00228D80
		public string IconTransparent
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

		// Token: 0x0600644A RID: 25674 RVA: 0x0022ABB8 File Offset: 0x00228DB8
		public Span<byte> GetIconTransparentBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600644B RID: 25675 RVA: 0x0022ABC8 File Offset: 0x00228DC8
		public byte[] GetIconTransparentArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x0600644C RID: 25676 RVA: 0x0022ABE0 File Offset: 0x00228DE0
		public string IconRound
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

		// Token: 0x0600644D RID: 25677 RVA: 0x0022AC18 File Offset: 0x00228E18
		public Span<byte> GetIconRoundBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600644E RID: 25678 RVA: 0x0022AC28 File Offset: 0x00228E28
		public byte[] GetIconRoundArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x0600644F RID: 25679 RVA: 0x0022AC40 File Offset: 0x00228E40
		public string Desc
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

		// Token: 0x06006450 RID: 25680 RVA: 0x0022AC78 File Offset: 0x00228E78
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x06006451 RID: 25681 RVA: 0x0022AC88 File Offset: 0x00228E88
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x06006452 RID: 25682 RVA: 0x0022ACA0 File Offset: 0x00228EA0
		public string RoleDesc
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

		// Token: 0x06006453 RID: 25683 RVA: 0x0022ACD8 File Offset: 0x00228ED8
		public Span<byte> GetRoleDescBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x06006454 RID: 25684 RVA: 0x0022ACE8 File Offset: 0x00228EE8
		public byte[] GetRoleDescArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x06006455 RID: 25685 RVA: 0x0022AD00 File Offset: 0x00228F00
		public int TagIdList(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x06006456 RID: 25686 RVA: 0x0022AD40 File Offset: 0x00228F40
		public int TagIdListLength
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006457 RID: 25687 RVA: 0x0022AD6C File Offset: 0x00228F6C
		public Span<int> GetTagIdListBytes()
		{
			return this.__p.__vector_as_span<int>(40, 4);
		}

		// Token: 0x06006458 RID: 25688 RVA: 0x0022AD7C File Offset: 0x00228F7C
		public int[] GetTagIdListArray()
		{
			return this.__p.__vector_as_array<int>(40) ?? Array.Empty<int>();
		}

		// Token: 0x06006459 RID: 25689 RVA: 0x0022AD94 File Offset: 0x00228F94
		public string IconSubTitle(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x0600645A RID: 25690 RVA: 0x0022ADD0 File Offset: 0x00228FD0
		public int IconSubTitleLength
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x0600645B RID: 25691 RVA: 0x0022ADFC File Offset: 0x00228FFC
		public string SpeIcon
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

		// Token: 0x0600645C RID: 25692 RVA: 0x0022AE34 File Offset: 0x00229034
		public Span<byte> GetSpeIconBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x0600645D RID: 25693 RVA: 0x0022AE44 File Offset: 0x00229044
		public byte[] GetSpeIconArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x0600645E RID: 25694 RVA: 0x0022AE5C File Offset: 0x0022905C
		[NullableContext(1)]
		public Dictionary<int, int> AccumulatePro()
		{
			return this.AccumulateProIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600645F RID: 25695 RVA: 0x0022AEB2 File Offset: 0x002290B2
		[NullableContext(1)]
		public IEnumerable<DicIntInt> AccumulateProIter()
		{
			DangoBrawlOccupation.<AccumulateProIter>d__86 <AccumulateProIter>d__ = new DangoBrawlOccupation.<AccumulateProIter>d__86(-2);
			<AccumulateProIter>d__.<>3__<>4__this = this;
			return <AccumulateProIter>d__;
		}

		// Token: 0x06006460 RID: 25696 RVA: 0x0022AEC7 File Offset: 0x002290C7
		[NullableContext(1)]
		public int[] CoreItemAttr()
		{
			return this.GetCoreItemAttrArray();
		}

		// Token: 0x06006461 RID: 25697 RVA: 0x0022AECF File Offset: 0x002290CF
		[NullableContext(1)]
		public IEnumerable<int> CoreItemAttrIter()
		{
			DangoBrawlOccupation.<CoreItemAttrIter>d__88 <CoreItemAttrIter>d__ = new DangoBrawlOccupation.<CoreItemAttrIter>d__88(-2);
			<CoreItemAttrIter>d__.<>3__<>4__this = this;
			return <CoreItemAttrIter>d__;
		}

		// Token: 0x06006462 RID: 25698 RVA: 0x0022AEE4 File Offset: 0x002290E4
		[NullableContext(1)]
		public string[] IconSubTitle()
		{
			return this.IconSubTitleIter().ToArray<string>();
		}

		// Token: 0x06006463 RID: 25699 RVA: 0x0022AEF1 File Offset: 0x002290F1
		[NullableContext(1)]
		public IEnumerable<string> IconSubTitleIter()
		{
			DangoBrawlOccupation.<IconSubTitleIter>d__90 <IconSubTitleIter>d__ = new DangoBrawlOccupation.<IconSubTitleIter>d__90(-2);
			<IconSubTitleIter>d__.<>3__<>4__this = this;
			return <IconSubTitleIter>d__;
		}

		// Token: 0x06006464 RID: 25700 RVA: 0x0022AF06 File Offset: 0x00229106
		[NullableContext(1)]
		public string[] IconTitle()
		{
			return this.IconTitleIter().ToArray<string>();
		}

		// Token: 0x06006465 RID: 25701 RVA: 0x0022AF13 File Offset: 0x00229113
		[NullableContext(1)]
		public IEnumerable<string> IconTitleIter()
		{
			DangoBrawlOccupation.<IconTitleIter>d__92 <IconTitleIter>d__ = new DangoBrawlOccupation.<IconTitleIter>d__92(-2);
			<IconTitleIter>d__.<>3__<>4__this = this;
			return <IconTitleIter>d__;
		}

		// Token: 0x06006466 RID: 25702 RVA: 0x0022AF28 File Offset: 0x00229128
		[NullableContext(1)]
		public string[] SpineAtlasPaths()
		{
			return this.SpineAtlasPathsIter().ToArray<string>();
		}

		// Token: 0x06006467 RID: 25703 RVA: 0x0022AF35 File Offset: 0x00229135
		[NullableContext(1)]
		public IEnumerable<string> SpineAtlasPathsIter()
		{
			DangoBrawlOccupation.<SpineAtlasPathsIter>d__94 <SpineAtlasPathsIter>d__ = new DangoBrawlOccupation.<SpineAtlasPathsIter>d__94(-2);
			<SpineAtlasPathsIter>d__.<>3__<>4__this = this;
			return <SpineAtlasPathsIter>d__;
		}

		// Token: 0x06006468 RID: 25704 RVA: 0x0022AF4A File Offset: 0x0022914A
		[NullableContext(1)]
		public string[] SpineSkeletonDataPaths()
		{
			return this.SpineSkeletonDataPathsIter().ToArray<string>();
		}

		// Token: 0x06006469 RID: 25705 RVA: 0x0022AF57 File Offset: 0x00229157
		[NullableContext(1)]
		public IEnumerable<string> SpineSkeletonDataPathsIter()
		{
			DangoBrawlOccupation.<SpineSkeletonDataPathsIter>d__96 <SpineSkeletonDataPathsIter>d__ = new DangoBrawlOccupation.<SpineSkeletonDataPathsIter>d__96(-2);
			<SpineSkeletonDataPathsIter>d__.<>3__<>4__this = this;
			return <SpineSkeletonDataPathsIter>d__;
		}

		// Token: 0x0600646A RID: 25706 RVA: 0x0022AF6C File Offset: 0x0022916C
		[NullableContext(1)]
		public int[] TagIdList()
		{
			return this.GetTagIdListArray();
		}

		// Token: 0x0600646B RID: 25707 RVA: 0x0022AF74 File Offset: 0x00229174
		[NullableContext(1)]
		public IEnumerable<int> TagIdListIter()
		{
			DangoBrawlOccupation.<TagIdListIter>d__98 <TagIdListIter>d__ = new DangoBrawlOccupation.<TagIdListIter>d__98(-2);
			<TagIdListIter>d__.<>3__<>4__this = this;
			return <TagIdListIter>d__;
		}

		// Token: 0x0600646C RID: 25708 RVA: 0x0022AF8C File Offset: 0x0022918C
		public int? GetAccumulatePro(int key)
		{
			this.EnsureAccumulateProCacheIfNeeded();
			int value;
			if (!this.AccumulateProCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600646D RID: 25709 RVA: 0x0022AFC0 File Offset: 0x002291C0
		private void EnsureAccumulateProCacheIfNeeded()
		{
			if (this.AccumulateProCache != null)
			{
				return;
			}
			this.AccumulateProCache = this.AccumulateProIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600646E RID: 25710 RVA: 0x0022B026 File Offset: 0x00229226
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetAccumulateProFrozenDict()
		{
			this.EnsureAccumulateProCacheIfNeeded();
			return this.AccumulateProCache;
		}

		// Token: 0x040051D3 RID: 20947
		private Table __p;

		// Token: 0x040051D4 RID: 20948
		[Nullable(2)]
		private FrozenDictionary<int, int> AccumulateProCache;
	}
}
