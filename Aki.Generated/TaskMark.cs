using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001116 RID: 4374
	public struct TaskMark : IFlatbufferObject
	{
		// Token: 0x170039B1 RID: 14769
		// (get) Token: 0x0600DCD7 RID: 56535 RVA: 0x003296CD File Offset: 0x003278CD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DCD8 RID: 56536 RVA: 0x003296DA File Offset: 0x003278DA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DCD9 RID: 56537 RVA: 0x003296E4 File Offset: 0x003278E4
		public static TaskMark GetRootAsTaskMark(ByteBuffer _bb)
		{
			return TaskMark.GetRootAsTaskMark(_bb, default(TaskMark));
		}

		// Token: 0x0600DCDA RID: 56538 RVA: 0x00329700 File Offset: 0x00327900
		public static TaskMark GetRootAsTaskMark(ByteBuffer _bb, TaskMark obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DCDB RID: 56539 RVA: 0x0032971D File Offset: 0x0032791D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DCDC RID: 56540 RVA: 0x0032972C File Offset: 0x0032792C
		public TaskMark __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170039B2 RID: 14770
		// (get) Token: 0x0600DCDD RID: 56541 RVA: 0x0032973C File Offset: 0x0032793C
		public int MarkId
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

		// Token: 0x170039B3 RID: 14771
		// (get) Token: 0x0600DCDE RID: 56542 RVA: 0x00329778 File Offset: 0x00327978
		public int QuestId
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

		// Token: 0x170039B4 RID: 14772
		// (get) Token: 0x0600DCDF RID: 56543 RVA: 0x003297B4 File Offset: 0x003279B4
		public string MarkPic
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

		// Token: 0x0600DCE0 RID: 56544 RVA: 0x003297EB File Offset: 0x003279EB
		public Span<byte> GetMarkPicBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600DCE1 RID: 56545 RVA: 0x003297FA File Offset: 0x003279FA
		public byte[] GetMarkPicArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170039B5 RID: 14773
		// (get) Token: 0x0600DCE2 RID: 56546 RVA: 0x00329814 File Offset: 0x00327A14
		public string MarkAcceptablePic
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

		// Token: 0x0600DCE3 RID: 56547 RVA: 0x0032984C File Offset: 0x00327A4C
		public Span<byte> GetMarkAcceptablePicBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600DCE4 RID: 56548 RVA: 0x0032985C File Offset: 0x00327A5C
		public byte[] GetMarkAcceptablePicArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170039B6 RID: 14774
		// (get) Token: 0x0600DCE5 RID: 56549 RVA: 0x00329874 File Offset: 0x00327A74
		public string NpcTaskIcon
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

		// Token: 0x0600DCE6 RID: 56550 RVA: 0x003298AC File Offset: 0x00327AAC
		public Span<byte> GetNpcTaskIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600DCE7 RID: 56551 RVA: 0x003298BC File Offset: 0x00327ABC
		public byte[] GetNpcTaskIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170039B7 RID: 14775
		// (get) Token: 0x0600DCE8 RID: 56552 RVA: 0x003298D4 File Offset: 0x00327AD4
		public int IconDistant
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 20000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170039B8 RID: 14776
		// (get) Token: 0x0600DCE9 RID: 56553 RVA: 0x00329918 File Offset: 0x00327B18
		public string TrackTextStartEffectColor
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

		// Token: 0x0600DCEA RID: 56554 RVA: 0x00329950 File Offset: 0x00327B50
		public Span<byte> GetTrackTextStartEffectColorBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600DCEB RID: 56555 RVA: 0x00329960 File Offset: 0x00327B60
		public byte[] GetTrackTextStartEffectColorArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0600DCEC RID: 56556 RVA: 0x00329978 File Offset: 0x00327B78
		public int ShowRange(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170039B9 RID: 14777
		// (get) Token: 0x0600DCED RID: 56557 RVA: 0x003299B8 File Offset: 0x00327BB8
		public int ShowRangeLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600DCEE RID: 56558 RVA: 0x003299E4 File Offset: 0x00327BE4
		public Span<int> GetShowRangeBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600DCEF RID: 56559 RVA: 0x003299F4 File Offset: 0x00327BF4
		public int[] GetShowRangeArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x170039BA RID: 14778
		// (get) Token: 0x0600DCF0 RID: 56560 RVA: 0x00329A0C File Offset: 0x00327C0C
		public int ShowPriority
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170039BB RID: 14779
		// (get) Token: 0x0600DCF1 RID: 56561 RVA: 0x00329A4C File Offset: 0x00327C4C
		public float Scale
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170039BC RID: 14780
		// (get) Token: 0x0600DCF2 RID: 56562 RVA: 0x00329A90 File Offset: 0x00327C90
		public float FxScale
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170039BD RID: 14781
		// (get) Token: 0x0600DCF3 RID: 56563 RVA: 0x00329AD4 File Offset: 0x00327CD4
		public string MarkRingPic
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

		// Token: 0x0600DCF4 RID: 56564 RVA: 0x00329B0C File Offset: 0x00327D0C
		public Span<byte> GetMarkRingPicBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600DCF5 RID: 56565 RVA: 0x00329B1C File Offset: 0x00327D1C
		public byte[] GetMarkRingPicArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x170039BE RID: 14782
		// (get) Token: 0x0600DCF6 RID: 56566 RVA: 0x00329B34 File Offset: 0x00327D34
		public string MarkIcon
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

		// Token: 0x0600DCF7 RID: 56567 RVA: 0x00329B6C File Offset: 0x00327D6C
		public Span<byte> GetMarkIconBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600DCF8 RID: 56568 RVA: 0x00329B7C File Offset: 0x00327D7C
		public byte[] GetMarkIconArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x170039BF RID: 14783
		// (get) Token: 0x0600DCF9 RID: 56569 RVA: 0x00329B94 File Offset: 0x00327D94
		public string RingColor
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

		// Token: 0x0600DCFA RID: 56570 RVA: 0x00329BCC File Offset: 0x00327DCC
		public Span<byte> GetRingColorBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600DCFB RID: 56571 RVA: 0x00329BDC File Offset: 0x00327DDC
		public byte[] GetRingColorArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x170039C0 RID: 14784
		// (get) Token: 0x0600DCFC RID: 56572 RVA: 0x00329BF4 File Offset: 0x00327DF4
		public string SmallHaloColor
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

		// Token: 0x0600DCFD RID: 56573 RVA: 0x00329C2C File Offset: 0x00327E2C
		public Span<byte> GetSmallHaloColorBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600DCFE RID: 56574 RVA: 0x00329C3C File Offset: 0x00327E3C
		public byte[] GetSmallHaloColorArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x170039C1 RID: 14785
		// (get) Token: 0x0600DCFF RID: 56575 RVA: 0x00329C54 File Offset: 0x00327E54
		public string LargeHaloColor
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

		// Token: 0x0600DD00 RID: 56576 RVA: 0x00329C8C File Offset: 0x00327E8C
		public Span<byte> GetLargeHaloColorBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600DD01 RID: 56577 RVA: 0x00329C9C File Offset: 0x00327E9C
		public byte[] GetLargeHaloColorArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x0600DD02 RID: 56578 RVA: 0x00329CB4 File Offset: 0x00327EB4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ShowRangeIter()或GetShowRangeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ShowRange()
		{
			TaskMark taskMark = this;
			return taskMark.GetShowRangeArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600DD03 RID: 56579 RVA: 0x00329CD8 File Offset: 0x00327ED8
		[NullableContext(1)]
		public readonly IEnumerable<int> ShowRangeIter()
		{
			TaskMark.<ShowRangeIter>d__62 <ShowRangeIter>d__ = new TaskMark.<ShowRangeIter>d__62(-2);
			<ShowRangeIter>d__.<>3__<>4__this = this;
			return <ShowRangeIter>d__;
		}

		// Token: 0x04005253 RID: 21075
		private Table __p;
	}
}
