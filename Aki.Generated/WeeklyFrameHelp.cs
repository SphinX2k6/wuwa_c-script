using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012DA RID: 4826
	public struct WeeklyFrameHelp : IFlatbufferObject
	{
		// Token: 0x170041C2 RID: 16834
		// (get) Token: 0x0600F67B RID: 63099 RVA: 0x0036FFCC File Offset: 0x0036E1CC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F67C RID: 63100 RVA: 0x0036FFD9 File Offset: 0x0036E1D9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F67D RID: 63101 RVA: 0x0036FFE0 File Offset: 0x0036E1E0
		public static WeeklyFrameHelp GetRootAsWeeklyFrameHelp(ByteBuffer _bb)
		{
			return WeeklyFrameHelp.GetRootAsWeeklyFrameHelp(_bb, default(WeeklyFrameHelp));
		}

		// Token: 0x0600F67E RID: 63102 RVA: 0x0036FFFC File Offset: 0x0036E1FC
		public static WeeklyFrameHelp GetRootAsWeeklyFrameHelp(ByteBuffer _bb, WeeklyFrameHelp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F67F RID: 63103 RVA: 0x00370019 File Offset: 0x0036E219
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F680 RID: 63104 RVA: 0x00370028 File Offset: 0x0036E228
		public WeeklyFrameHelp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170041C3 RID: 16835
		// (get) Token: 0x0600F681 RID: 63105 RVA: 0x00370038 File Offset: 0x0036E238
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

		// Token: 0x170041C4 RID: 16836
		// (get) Token: 0x0600F682 RID: 63106 RVA: 0x00370074 File Offset: 0x0036E274
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

		// Token: 0x170041C5 RID: 16837
		// (get) Token: 0x0600F683 RID: 63107 RVA: 0x003700B0 File Offset: 0x0036E2B0
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

		// Token: 0x0600F684 RID: 63108 RVA: 0x003700E7 File Offset: 0x0036E2E7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600F685 RID: 63109 RVA: 0x003700F6 File Offset: 0x0036E2F6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600F686 RID: 63110 RVA: 0x00370110 File Offset: 0x0036E310
		public string Tag(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170041C6 RID: 16838
		// (get) Token: 0x0600F687 RID: 63111 RVA: 0x0037014C File Offset: 0x0036E34C
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

		// Token: 0x170041C7 RID: 16839
		// (get) Token: 0x0600F688 RID: 63112 RVA: 0x00370178 File Offset: 0x0036E378
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

		// Token: 0x0600F689 RID: 63113 RVA: 0x003701B0 File Offset: 0x0036E3B0
		public Span<byte> GetBgPicBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600F68A RID: 63114 RVA: 0x003701C0 File Offset: 0x0036E3C0
		public byte[] GetBgPicArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170041C8 RID: 16840
		// (get) Token: 0x0600F68B RID: 63115 RVA: 0x003701D8 File Offset: 0x0036E3D8
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

		// Token: 0x0600F68C RID: 63116 RVA: 0x00370210 File Offset: 0x0036E410
		public Span<byte> GetItemColorBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600F68D RID: 63117 RVA: 0x00370220 File Offset: 0x0036E420
		public byte[] GetItemColorArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170041C9 RID: 16841
		// (get) Token: 0x0600F68E RID: 63118 RVA: 0x00370238 File Offset: 0x0036E438
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

		// Token: 0x170041CA RID: 16842
		// (get) Token: 0x0600F68F RID: 63119 RVA: 0x00370278 File Offset: 0x0036E478
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

		// Token: 0x0600F690 RID: 63120 RVA: 0x003702B0 File Offset: 0x0036E4B0
		public Span<byte> GetScoreBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600F691 RID: 63121 RVA: 0x003702C0 File Offset: 0x0036E4C0
		public byte[] GetScoreArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170041CB RID: 16843
		// (get) Token: 0x0600F692 RID: 63122 RVA: 0x003702D8 File Offset: 0x0036E4D8
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

		// Token: 0x0600F693 RID: 63123 RVA: 0x00370310 File Offset: 0x0036E510
		public Span<byte> GetTimeBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600F694 RID: 63124 RVA: 0x00370320 File Offset: 0x0036E520
		public byte[] GetTimeArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170041CC RID: 16844
		// (get) Token: 0x0600F695 RID: 63125 RVA: 0x00370338 File Offset: 0x0036E538
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

		// Token: 0x170041CD RID: 16845
		// (get) Token: 0x0600F696 RID: 63126 RVA: 0x00370378 File Offset: 0x0036E578
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

		// Token: 0x170041CE RID: 16846
		// (get) Token: 0x0600F697 RID: 63127 RVA: 0x003703B8 File Offset: 0x0036E5B8
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

		// Token: 0x170041CF RID: 16847
		// (get) Token: 0x0600F698 RID: 63128 RVA: 0x003703F8 File Offset: 0x0036E5F8
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

		// Token: 0x0600F699 RID: 63129 RVA: 0x00370435 File Offset: 0x0036E635
		[NullableContext(1)]
		public string[] Tag()
		{
			return this.TagIter().ToArray<string>();
		}

		// Token: 0x0600F69A RID: 63130 RVA: 0x00370442 File Offset: 0x0036E642
		[NullableContext(1)]
		public IEnumerable<string> TagIter()
		{
			WeeklyFrameHelp.<TagIter>d__46 <TagIter>d__ = new WeeklyFrameHelp.<TagIter>d__46(-2);
			<TagIter>d__.<>3__<>4__this = this;
			return <TagIter>d__;
		}

		// Token: 0x04005933 RID: 22835
		private Table __p;
	}
}
