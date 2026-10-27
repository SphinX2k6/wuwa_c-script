using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FFF RID: 4095
	public struct RogueResEvent : IFlatbufferObject
	{
		// Token: 0x1700302B RID: 12331
		// (get) Token: 0x0600C202 RID: 49666 RVA: 0x002EB929 File Offset: 0x002E9B29
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C203 RID: 49667 RVA: 0x002EB936 File Offset: 0x002E9B36
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C204 RID: 49668 RVA: 0x002EB940 File Offset: 0x002E9B40
		public static RogueResEvent GetRootAsRogueResEvent(ByteBuffer _bb)
		{
			return RogueResEvent.GetRootAsRogueResEvent(_bb, default(RogueResEvent));
		}

		// Token: 0x0600C205 RID: 49669 RVA: 0x002EB95C File Offset: 0x002E9B5C
		public static RogueResEvent GetRootAsRogueResEvent(ByteBuffer _bb, RogueResEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C206 RID: 49670 RVA: 0x002EB979 File Offset: 0x002E9B79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C207 RID: 49671 RVA: 0x002EB988 File Offset: 0x002E9B88
		public RogueResEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700302C RID: 12332
		// (get) Token: 0x0600C208 RID: 49672 RVA: 0x002EB998 File Offset: 0x002E9B98
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

		// Token: 0x1700302D RID: 12333
		// (get) Token: 0x0600C209 RID: 49673 RVA: 0x002EB9D4 File Offset: 0x002E9BD4
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

		// Token: 0x0600C20A RID: 49674 RVA: 0x002EBA0B File Offset: 0x002E9C0B
		public Span<byte> GetTextIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C20B RID: 49675 RVA: 0x002EBA1A File Offset: 0x002E9C1A
		public byte[] GetTextIdArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700302E RID: 12334
		// (get) Token: 0x0600C20C RID: 49676 RVA: 0x002EBA34 File Offset: 0x002E9C34
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

		// Token: 0x0600C20D RID: 49677 RVA: 0x002EBA6B File Offset: 0x002E9C6B
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C20E RID: 49678 RVA: 0x002EBA7A File Offset: 0x002E9C7A
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700302F RID: 12335
		// (get) Token: 0x0600C20F RID: 49679 RVA: 0x002EBA94 File Offset: 0x002E9C94
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

		// Token: 0x17003030 RID: 12336
		// (get) Token: 0x0600C210 RID: 49680 RVA: 0x002EBAD4 File Offset: 0x002E9CD4
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

		// Token: 0x0600C211 RID: 49681 RVA: 0x002EBB14 File Offset: 0x002E9D14
		public int Args(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003031 RID: 12337
		// (get) Token: 0x0600C212 RID: 49682 RVA: 0x002EBB54 File Offset: 0x002E9D54
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

		// Token: 0x0600C213 RID: 49683 RVA: 0x002EBB80 File Offset: 0x002E9D80
		public Span<int> GetArgsBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600C214 RID: 49684 RVA: 0x002EBB90 File Offset: 0x002E9D90
		public int[] GetArgsArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17003032 RID: 12338
		// (get) Token: 0x0600C215 RID: 49685 RVA: 0x002EBBA8 File Offset: 0x002E9DA8
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

		// Token: 0x0600C216 RID: 49686 RVA: 0x002EBBE0 File Offset: 0x002E9DE0
		public Span<byte> GetFlowListNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600C217 RID: 49687 RVA: 0x002EBBF0 File Offset: 0x002E9DF0
		public byte[] GetFlowListNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003033 RID: 12339
		// (get) Token: 0x0600C218 RID: 49688 RVA: 0x002EBC08 File Offset: 0x002E9E08
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

		// Token: 0x17003034 RID: 12340
		// (get) Token: 0x0600C219 RID: 49689 RVA: 0x002EBC48 File Offset: 0x002E9E48
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

		// Token: 0x17003035 RID: 12341
		// (get) Token: 0x0600C21A RID: 49690 RVA: 0x002EBC88 File Offset: 0x002E9E88
		public bool IsCopyCamera
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600C21B RID: 49691 RVA: 0x002EBCC8 File Offset: 0x002E9EC8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ArgsIter()或GetArgsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Args()
		{
			RogueResEvent rogueResEvent = this;
			return rogueResEvent.GetArgsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C21C RID: 49692 RVA: 0x002EBCEC File Offset: 0x002E9EEC
		[NullableContext(1)]
		public readonly IEnumerable<int> ArgsIter()
		{
			RogueResEvent.<ArgsIter>d__38 <ArgsIter>d__ = new RogueResEvent.<ArgsIter>d__38(-2);
			<ArgsIter>d__.<>3__<>4__this = this;
			return <ArgsIter>d__;
		}

		// Token: 0x040050E7 RID: 20711
		private Table __p;
	}
}
