using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FE0 RID: 4064
	public struct RogueEvent : IFlatbufferObject
	{
		// Token: 0x17002F31 RID: 12081
		// (get) Token: 0x0600BF10 RID: 48912 RVA: 0x002E4EED File Offset: 0x002E30ED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BF11 RID: 48913 RVA: 0x002E4EFA File Offset: 0x002E30FA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BF12 RID: 48914 RVA: 0x002E4F04 File Offset: 0x002E3104
		public static RogueEvent GetRootAsRogueEvent(ByteBuffer _bb)
		{
			return RogueEvent.GetRootAsRogueEvent(_bb, default(RogueEvent));
		}

		// Token: 0x0600BF13 RID: 48915 RVA: 0x002E4F20 File Offset: 0x002E3120
		public static RogueEvent GetRootAsRogueEvent(ByteBuffer _bb, RogueEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BF14 RID: 48916 RVA: 0x002E4F3D File Offset: 0x002E313D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BF15 RID: 48917 RVA: 0x002E4F4C File Offset: 0x002E314C
		public RogueEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002F32 RID: 12082
		// (get) Token: 0x0600BF16 RID: 48918 RVA: 0x002E4F5C File Offset: 0x002E315C
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

		// Token: 0x17002F33 RID: 12083
		// (get) Token: 0x0600BF17 RID: 48919 RVA: 0x002E4F98 File Offset: 0x002E3198
		public string TextId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BF18 RID: 48920 RVA: 0x002E4FCF File Offset: 0x002E31CF
		public Span<byte> GetTextIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600BF19 RID: 48921 RVA: 0x002E4FDE File Offset: 0x002E31DE
		public byte[] GetTextIdArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F34 RID: 12084
		// (get) Token: 0x0600BF1A RID: 48922 RVA: 0x002E4FF8 File Offset: 0x002E31F8
		public string Title
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

		// Token: 0x0600BF1B RID: 48923 RVA: 0x002E502F File Offset: 0x002E322F
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600BF1C RID: 48924 RVA: 0x002E503E File Offset: 0x002E323E
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F35 RID: 12085
		// (get) Token: 0x0600BF1D RID: 48925 RVA: 0x002E5058 File Offset: 0x002E3258
		public int Condition
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

		// Token: 0x17002F36 RID: 12086
		// (get) Token: 0x0600BF1E RID: 48926 RVA: 0x002E5098 File Offset: 0x002E3298
		public int EventType
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

		// Token: 0x0600BF1F RID: 48927 RVA: 0x002E50D8 File Offset: 0x002E32D8
		public int Args(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002F37 RID: 12087
		// (get) Token: 0x0600BF20 RID: 48928 RVA: 0x002E5118 File Offset: 0x002E3318
		public int ArgsLength
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

		// Token: 0x0600BF21 RID: 48929 RVA: 0x002E5144 File Offset: 0x002E3344
		public Span<int> GetArgsBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600BF22 RID: 48930 RVA: 0x002E5154 File Offset: 0x002E3354
		public int[] GetArgsArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17002F38 RID: 12088
		// (get) Token: 0x0600BF23 RID: 48931 RVA: 0x002E516C File Offset: 0x002E336C
		public string FlowListName
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

		// Token: 0x0600BF24 RID: 48932 RVA: 0x002E51A4 File Offset: 0x002E33A4
		public Span<byte> GetFlowListNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600BF25 RID: 48933 RVA: 0x002E51B4 File Offset: 0x002E33B4
		public byte[] GetFlowListNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F39 RID: 12089
		// (get) Token: 0x0600BF26 RID: 48934 RVA: 0x002E51CC File Offset: 0x002E33CC
		public int FlowId
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

		// Token: 0x17002F3A RID: 12090
		// (get) Token: 0x0600BF27 RID: 48935 RVA: 0x002E520C File Offset: 0x002E340C
		public int StateId
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

		// Token: 0x17002F3B RID: 12091
		// (get) Token: 0x0600BF28 RID: 48936 RVA: 0x002E524C File Offset: 0x002E344C
		public bool IsCopyCamera
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600BF29 RID: 48937 RVA: 0x002E528C File Offset: 0x002E348C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ArgsIter()或GetArgsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Args()
		{
			RogueEvent rogueEvent = this;
			return rogueEvent.GetArgsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600BF2A RID: 48938 RVA: 0x002E52B0 File Offset: 0x002E34B0
		[NullableContext(1)]
		public readonly IEnumerable<int> ArgsIter()
		{
			RogueEvent.<ArgsIter>d__38 <ArgsIter>d__ = new RogueEvent.<ArgsIter>d__38(-2);
			<ArgsIter>d__.<>3__<>4__this = this;
			return <ArgsIter>d__;
		}

		// Token: 0x040050BD RID: 20669
		private Table __p;
	}
}
