using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E02 RID: 3586
	public struct GuideTutorial : IFlatbufferObject
	{
		// Token: 0x17001703 RID: 5891
		// (get) Token: 0x0600836B RID: 33643 RVA: 0x0027020B File Offset: 0x0026E40B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600836C RID: 33644 RVA: 0x00270218 File Offset: 0x0026E418
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600836D RID: 33645 RVA: 0x00270220 File Offset: 0x0026E420
		public static GuideTutorial GetRootAsGuideTutorial(ByteBuffer _bb)
		{
			return GuideTutorial.GetRootAsGuideTutorial(_bb, default(GuideTutorial));
		}

		// Token: 0x0600836E RID: 33646 RVA: 0x0027023C File Offset: 0x0026E43C
		public static GuideTutorial GetRootAsGuideTutorial(ByteBuffer _bb, GuideTutorial obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600836F RID: 33647 RVA: 0x00270259 File Offset: 0x0026E459
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008370 RID: 33648 RVA: 0x00270268 File Offset: 0x0026E468
		public GuideTutorial __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001704 RID: 5892
		// (get) Token: 0x06008371 RID: 33649 RVA: 0x00270278 File Offset: 0x0026E478
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

		// Token: 0x17001705 RID: 5893
		// (get) Token: 0x06008372 RID: 33650 RVA: 0x002702B4 File Offset: 0x0026E4B4
		public int TutorialType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 11;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001706 RID: 5894
		// (get) Token: 0x06008373 RID: 33651 RVA: 0x002702F4 File Offset: 0x0026E4F4
		public int TutorialOrder
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

		// Token: 0x06008374 RID: 33652 RVA: 0x00270330 File Offset: 0x0026E530
		public int PageId(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001707 RID: 5895
		// (get) Token: 0x06008375 RID: 33653 RVA: 0x00270370 File Offset: 0x0026E570
		public int PageIdLength
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

		// Token: 0x06008376 RID: 33654 RVA: 0x0027039C File Offset: 0x0026E59C
		public Span<int> GetPageIdBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06008377 RID: 33655 RVA: 0x002703AC File Offset: 0x0026E5AC
		public int[] GetPageIdArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17001708 RID: 5896
		// (get) Token: 0x06008378 RID: 33656 RVA: 0x002703C4 File Offset: 0x0026E5C4
		public int PageReplaceConditionGroupId
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

		// Token: 0x06008379 RID: 33657 RVA: 0x00270404 File Offset: 0x0026E604
		public int ReplacePageId(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001709 RID: 5897
		// (get) Token: 0x0600837A RID: 33658 RVA: 0x00270444 File Offset: 0x0026E644
		public int ReplacePageIdLength
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

		// Token: 0x0600837B RID: 33659 RVA: 0x00270470 File Offset: 0x0026E670
		public Span<int> GetReplacePageIdBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600837C RID: 33660 RVA: 0x00270480 File Offset: 0x0026E680
		public int[] GetReplacePageIdArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x1700170A RID: 5898
		// (get) Token: 0x0600837D RID: 33661 RVA: 0x00270498 File Offset: 0x0026E698
		public string GroupName
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

		// Token: 0x0600837E RID: 33662 RVA: 0x002704D0 File Offset: 0x0026E6D0
		public Span<byte> GetGroupNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600837F RID: 33663 RVA: 0x002704E0 File Offset: 0x0026E6E0
		public byte[] GetGroupNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700170B RID: 5899
		// (get) Token: 0x06008380 RID: 33664 RVA: 0x002704F8 File Offset: 0x0026E6F8
		public int ExclusiveType
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700170C RID: 5900
		// (get) Token: 0x06008381 RID: 33665 RVA: 0x00270538 File Offset: 0x0026E738
		public bool TutorialTip
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700170D RID: 5901
		// (get) Token: 0x06008382 RID: 33666 RVA: 0x00270578 File Offset: 0x0026E778
		public int DropId
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 100001;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700170E RID: 5902
		// (get) Token: 0x06008383 RID: 33667 RVA: 0x002705BC File Offset: 0x0026E7BC
		public bool DisableDropReward
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700170F RID: 5903
		// (get) Token: 0x06008384 RID: 33668 RVA: 0x002705FC File Offset: 0x0026E7FC
		public bool RequireReadAll
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001710 RID: 5904
		// (get) Token: 0x06008385 RID: 33669 RVA: 0x0027063C File Offset: 0x0026E83C
		public bool ExcludeFromWiki
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001711 RID: 5905
		// (get) Token: 0x06008386 RID: 33670 RVA: 0x0027067C File Offset: 0x0026E87C
		public int CopiedFrom
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

		// Token: 0x17001712 RID: 5906
		// (get) Token: 0x06008387 RID: 33671 RVA: 0x002706BC File Offset: 0x0026E8BC
		public bool DefaultUnlock
		{
			get
			{
				int num = this.__p.__offset(32);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001713 RID: 5907
		// (get) Token: 0x06008388 RID: 33672 RVA: 0x002706FC File Offset: 0x0026E8FC
		public bool SilentUnlock
		{
			get
			{
				int num = this.__p.__offset(34);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001714 RID: 5908
		// (get) Token: 0x06008389 RID: 33673 RVA: 0x0027073C File Offset: 0x0026E93C
		public int ShowLayer
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600838A RID: 33674 RVA: 0x00270779 File Offset: 0x0026E979
		[NullableContext(1)]
		public int[] PageId()
		{
			return this.GetPageIdArray();
		}

		// Token: 0x0600838B RID: 33675 RVA: 0x00270781 File Offset: 0x0026E981
		[NullableContext(1)]
		public IEnumerable<int> PageIdIter()
		{
			GuideTutorial.<PageIdIter>d__51 <PageIdIter>d__ = new GuideTutorial.<PageIdIter>d__51(-2);
			<PageIdIter>d__.<>3__<>4__this = this;
			return <PageIdIter>d__;
		}

		// Token: 0x0600838C RID: 33676 RVA: 0x00270796 File Offset: 0x0026E996
		[NullableContext(1)]
		public int[] ReplacePageId()
		{
			return this.GetReplacePageIdArray();
		}

		// Token: 0x0600838D RID: 33677 RVA: 0x0027079E File Offset: 0x0026E99E
		[NullableContext(1)]
		public IEnumerable<int> ReplacePageIdIter()
		{
			GuideTutorial.<ReplacePageIdIter>d__53 <ReplacePageIdIter>d__ = new GuideTutorial.<ReplacePageIdIter>d__53(-2);
			<ReplacePageIdIter>d__.<>3__<>4__this = this;
			return <ReplacePageIdIter>d__;
		}

		// Token: 0x0400537A RID: 21370
		private Table __p;
	}
}
