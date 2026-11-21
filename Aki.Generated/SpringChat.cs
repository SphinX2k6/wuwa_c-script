using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200121A RID: 4634
	public struct SpringChat : IFlatbufferObject
	{
		// Token: 0x17003B43 RID: 15171
		// (get) Token: 0x0600E57A RID: 58746 RVA: 0x00349F81 File Offset: 0x00348181
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E57B RID: 58747 RVA: 0x00349F8E File Offset: 0x0034818E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E57C RID: 58748 RVA: 0x00349F98 File Offset: 0x00348198
		public static SpringChat GetRootAsSpringChat(ByteBuffer _bb)
		{
			return SpringChat.GetRootAsSpringChat(_bb, default(SpringChat));
		}

		// Token: 0x0600E57D RID: 58749 RVA: 0x00349FB4 File Offset: 0x003481B4
		public static SpringChat GetRootAsSpringChat(ByteBuffer _bb, SpringChat obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E57E RID: 58750 RVA: 0x00349FD1 File Offset: 0x003481D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E57F RID: 58751 RVA: 0x00349FE0 File Offset: 0x003481E0
		public SpringChat __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003B44 RID: 15172
		// (get) Token: 0x0600E580 RID: 58752 RVA: 0x00349FF0 File Offset: 0x003481F0
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

		// Token: 0x0600E581 RID: 58753 RVA: 0x0034A02C File Offset: 0x0034822C
		public string ContentList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003B45 RID: 15173
		// (get) Token: 0x0600E582 RID: 58754 RVA: 0x0034A068 File Offset: 0x00348268
		public int ContentListLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E583 RID: 58755 RVA: 0x0034A094 File Offset: 0x00348294
		public int PosList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003B46 RID: 15174
		// (get) Token: 0x0600E584 RID: 58756 RVA: 0x0034A0D4 File Offset: 0x003482D4
		public int PosListLength
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

		// Token: 0x0600E585 RID: 58757 RVA: 0x0034A0FF File Offset: 0x003482FF
		public Span<int> GetPosListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600E586 RID: 58758 RVA: 0x0034A10E File Offset: 0x0034830E
		public int[] GetPosListArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600E587 RID: 58759 RVA: 0x0034A128 File Offset: 0x00348328
		public string AnimNameList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003B47 RID: 15175
		// (get) Token: 0x0600E588 RID: 58760 RVA: 0x0034A164 File Offset: 0x00348364
		public int AnimNameListLength
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

		// Token: 0x17003B48 RID: 15176
		// (get) Token: 0x0600E589 RID: 58761 RVA: 0x0034A190 File Offset: 0x00348390
		public string LeftSpineAtlas
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

		// Token: 0x0600E58A RID: 58762 RVA: 0x0034A1C8 File Offset: 0x003483C8
		public Span<byte> GetLeftSpineAtlasBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600E58B RID: 58763 RVA: 0x0034A1D8 File Offset: 0x003483D8
		public byte[] GetLeftSpineAtlasArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003B49 RID: 15177
		// (get) Token: 0x0600E58C RID: 58764 RVA: 0x0034A1F0 File Offset: 0x003483F0
		public string LeftSpineSkeletonData
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

		// Token: 0x0600E58D RID: 58765 RVA: 0x0034A228 File Offset: 0x00348428
		public Span<byte> GetLeftSpineSkeletonDataBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600E58E RID: 58766 RVA: 0x0034A238 File Offset: 0x00348438
		public byte[] GetLeftSpineSkeletonDataArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003B4A RID: 15178
		// (get) Token: 0x0600E58F RID: 58767 RVA: 0x0034A250 File Offset: 0x00348450
		public string RightSpineAtlas
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

		// Token: 0x0600E590 RID: 58768 RVA: 0x0034A288 File Offset: 0x00348488
		public Span<byte> GetRightSpineAtlasBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600E591 RID: 58769 RVA: 0x0034A298 File Offset: 0x00348498
		public byte[] GetRightSpineAtlasArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003B4B RID: 15179
		// (get) Token: 0x0600E592 RID: 58770 RVA: 0x0034A2B0 File Offset: 0x003484B0
		public string RightSpineSkeletonData
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

		// Token: 0x0600E593 RID: 58771 RVA: 0x0034A2E8 File Offset: 0x003484E8
		public Span<byte> GetRightSpineSkeletonDataBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600E594 RID: 58772 RVA: 0x0034A2F8 File Offset: 0x003484F8
		public byte[] GetRightSpineSkeletonDataArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E595 RID: 58773 RVA: 0x0034A310 File Offset: 0x00348510
		[NullableContext(1)]
		public string[] AnimNameList()
		{
			return this.AnimNameListIter().ToArray<string>();
		}

		// Token: 0x0600E596 RID: 58774 RVA: 0x0034A31D File Offset: 0x0034851D
		[NullableContext(1)]
		public IEnumerable<string> AnimNameListIter()
		{
			SpringChat.<AnimNameListIter>d__38 <AnimNameListIter>d__ = new SpringChat.<AnimNameListIter>d__38(-2);
			<AnimNameListIter>d__.<>3__<>4__this = this;
			return <AnimNameListIter>d__;
		}

		// Token: 0x0600E597 RID: 58775 RVA: 0x0034A332 File Offset: 0x00348532
		[NullableContext(1)]
		public string[] ContentList()
		{
			return this.ContentListIter().ToArray<string>();
		}

		// Token: 0x0600E598 RID: 58776 RVA: 0x0034A33F File Offset: 0x0034853F
		[NullableContext(1)]
		public IEnumerable<string> ContentListIter()
		{
			SpringChat.<ContentListIter>d__40 <ContentListIter>d__ = new SpringChat.<ContentListIter>d__40(-2);
			<ContentListIter>d__.<>3__<>4__this = this;
			return <ContentListIter>d__;
		}

		// Token: 0x0600E599 RID: 58777 RVA: 0x0034A354 File Offset: 0x00348554
		[NullableContext(1)]
		public int[] PosList()
		{
			return this.GetPosListArray();
		}

		// Token: 0x0600E59A RID: 58778 RVA: 0x0034A35C File Offset: 0x0034855C
		[NullableContext(1)]
		public IEnumerable<int> PosListIter()
		{
			SpringChat.<PosListIter>d__42 <PosListIter>d__ = new SpringChat.<PosListIter>d__42(-2);
			<PosListIter>d__.<>3__<>4__this = this;
			return <PosListIter>d__;
		}

		// Token: 0x0400585A RID: 22618
		private Table __p;
	}
}
