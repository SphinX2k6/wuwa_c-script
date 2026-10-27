using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011A4 RID: 4516
	public struct WeeklyFrameHelp : IFlatbufferObject
	{
		// Token: 0x17003E5D RID: 15965
		// (get) Token: 0x0600E90A RID: 59658 RVA: 0x00345340 File Offset: 0x00343540
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E90B RID: 59659 RVA: 0x0034534D File Offset: 0x0034354D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E90C RID: 59660 RVA: 0x00345354 File Offset: 0x00343554
		public static WeeklyFrameHelp GetRootAsWeeklyFrameHelp(ByteBuffer _bb)
		{
			return WeeklyFrameHelp.GetRootAsWeeklyFrameHelp(_bb, default(WeeklyFrameHelp));
		}

		// Token: 0x0600E90D RID: 59661 RVA: 0x00345370 File Offset: 0x00343570
		public static WeeklyFrameHelp GetRootAsWeeklyFrameHelp(ByteBuffer _bb, WeeklyFrameHelp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E90E RID: 59662 RVA: 0x0034538D File Offset: 0x0034358D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E90F RID: 59663 RVA: 0x0034539C File Offset: 0x0034359C
		public WeeklyFrameHelp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003E5E RID: 15966
		// (get) Token: 0x0600E910 RID: 59664 RVA: 0x003453AC File Offset: 0x003435AC
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

		// Token: 0x17003E5F RID: 15967
		// (get) Token: 0x0600E911 RID: 59665 RVA: 0x003453E8 File Offset: 0x003435E8
		public int ActivityType
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

		// Token: 0x17003E60 RID: 15968
		// (get) Token: 0x0600E912 RID: 59666 RVA: 0x00345424 File Offset: 0x00343624
		public string Name
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

		// Token: 0x0600E913 RID: 59667 RVA: 0x0034545B File Offset: 0x0034365B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E914 RID: 59668 RVA: 0x0034546A File Offset: 0x0034366A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E915 RID: 59669 RVA: 0x00345484 File Offset: 0x00343684
		public string Tag(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003E61 RID: 15969
		// (get) Token: 0x0600E916 RID: 59670 RVA: 0x003454C0 File Offset: 0x003436C0
		public int TagLength
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

		// Token: 0x17003E62 RID: 15970
		// (get) Token: 0x0600E917 RID: 59671 RVA: 0x003454EC File Offset: 0x003436EC
		public string BgPic
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

		// Token: 0x0600E918 RID: 59672 RVA: 0x00345524 File Offset: 0x00343724
		public Span<byte> GetBgPicBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600E919 RID: 59673 RVA: 0x00345534 File Offset: 0x00343734
		public byte[] GetBgPicArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003E63 RID: 15971
		// (get) Token: 0x0600E91A RID: 59674 RVA: 0x0034554C File Offset: 0x0034374C
		public string ItemColor
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

		// Token: 0x0600E91B RID: 59675 RVA: 0x00345584 File Offset: 0x00343784
		public Span<byte> GetItemColorBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600E91C RID: 59676 RVA: 0x00345594 File Offset: 0x00343794
		public byte[] GetItemColorArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003E64 RID: 15972
		// (get) Token: 0x0600E91D RID: 59677 RVA: 0x003455AC File Offset: 0x003437AC
		public int HelpId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003E65 RID: 15973
		// (get) Token: 0x0600E91E RID: 59678 RVA: 0x003455EC File Offset: 0x003437EC
		public string Score
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

		// Token: 0x0600E91F RID: 59679 RVA: 0x00345624 File Offset: 0x00343824
		public Span<byte> GetScoreBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600E920 RID: 59680 RVA: 0x00345634 File Offset: 0x00343834
		public byte[] GetScoreArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17003E66 RID: 15974
		// (get) Token: 0x0600E921 RID: 59681 RVA: 0x0034564C File Offset: 0x0034384C
		public string Time
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

		// Token: 0x0600E922 RID: 59682 RVA: 0x00345684 File Offset: 0x00343884
		public Span<byte> GetTimeBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600E923 RID: 59683 RVA: 0x00345694 File Offset: 0x00343894
		public byte[] GetTimeArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17003E67 RID: 15975
		// (get) Token: 0x0600E924 RID: 59684 RVA: 0x003456AC File Offset: 0x003438AC
		public int Sort
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003E68 RID: 15976
		// (get) Token: 0x0600E925 RID: 59685 RVA: 0x003456EC File Offset: 0x003438EC
		public int UnlockCondition
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003E69 RID: 15977
		// (get) Token: 0x0600E926 RID: 59686 RVA: 0x0034572C File Offset: 0x0034392C
		public int GuideQuest
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003E6A RID: 15978
		// (get) Token: 0x0600E927 RID: 59687 RVA: 0x0034576C File Offset: 0x0034396C
		public int AccessPathId
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E928 RID: 59688 RVA: 0x003457A9 File Offset: 0x003439A9
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TagIter()或GetTagBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Tag()
		{
			return this.TagIter().ToArray<string>();
		}

		// Token: 0x0600E929 RID: 59689 RVA: 0x003457B6 File Offset: 0x003439B6
		[NullableContext(1)]
		public readonly IEnumerable<string> TagIter()
		{
			WeeklyFrameHelp.<TagIter>d__46 <TagIter>d__ = new WeeklyFrameHelp.<TagIter>d__46(-2);
			<TagIter>d__.<>3__<>4__this = this;
			return <TagIter>d__;
		}

		// Token: 0x040052F0 RID: 21232
		private Table __p;
	}
}
