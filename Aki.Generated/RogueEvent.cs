using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010C8 RID: 4296
	public struct RogueEvent : IFlatbufferObject
	{
		// Token: 0x17002FAC RID: 12204
		// (get) Token: 0x0600C55A RID: 50522 RVA: 0x003013A7 File Offset: 0x002FF5A7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C55B RID: 50523 RVA: 0x003013B4 File Offset: 0x002FF5B4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C55C RID: 50524 RVA: 0x003013BC File Offset: 0x002FF5BC
		public static RogueEvent GetRootAsRogueEvent(ByteBuffer _bb)
		{
			return RogueEvent.GetRootAsRogueEvent(_bb, default(RogueEvent));
		}

		// Token: 0x0600C55D RID: 50525 RVA: 0x003013D8 File Offset: 0x002FF5D8
		public static RogueEvent GetRootAsRogueEvent(ByteBuffer _bb, RogueEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C55E RID: 50526 RVA: 0x003013F5 File Offset: 0x002FF5F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C55F RID: 50527 RVA: 0x00301404 File Offset: 0x002FF604
		public RogueEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002FAD RID: 12205
		// (get) Token: 0x0600C560 RID: 50528 RVA: 0x00301414 File Offset: 0x002FF614
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

		// Token: 0x17002FAE RID: 12206
		// (get) Token: 0x0600C561 RID: 50529 RVA: 0x00301450 File Offset: 0x002FF650
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

		// Token: 0x0600C562 RID: 50530 RVA: 0x00301487 File Offset: 0x002FF687
		public Span<byte> GetTextIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C563 RID: 50531 RVA: 0x00301496 File Offset: 0x002FF696
		public byte[] GetTextIdArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002FAF RID: 12207
		// (get) Token: 0x0600C564 RID: 50532 RVA: 0x003014B0 File Offset: 0x002FF6B0
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

		// Token: 0x0600C565 RID: 50533 RVA: 0x003014E7 File Offset: 0x002FF6E7
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C566 RID: 50534 RVA: 0x003014F6 File Offset: 0x002FF6F6
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002FB0 RID: 12208
		// (get) Token: 0x0600C567 RID: 50535 RVA: 0x00301510 File Offset: 0x002FF710
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

		// Token: 0x17002FB1 RID: 12209
		// (get) Token: 0x0600C568 RID: 50536 RVA: 0x00301550 File Offset: 0x002FF750
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

		// Token: 0x0600C569 RID: 50537 RVA: 0x00301590 File Offset: 0x002FF790
		public int Args(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002FB2 RID: 12210
		// (get) Token: 0x0600C56A RID: 50538 RVA: 0x003015D0 File Offset: 0x002FF7D0
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

		// Token: 0x0600C56B RID: 50539 RVA: 0x003015FC File Offset: 0x002FF7FC
		public Span<int> GetArgsBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600C56C RID: 50540 RVA: 0x0030160C File Offset: 0x002FF80C
		public int[] GetArgsArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17002FB3 RID: 12211
		// (get) Token: 0x0600C56D RID: 50541 RVA: 0x00301624 File Offset: 0x002FF824
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

		// Token: 0x0600C56E RID: 50542 RVA: 0x0030165C File Offset: 0x002FF85C
		public Span<byte> GetFlowListNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600C56F RID: 50543 RVA: 0x0030166C File Offset: 0x002FF86C
		public byte[] GetFlowListNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002FB4 RID: 12212
		// (get) Token: 0x0600C570 RID: 50544 RVA: 0x00301684 File Offset: 0x002FF884
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

		// Token: 0x17002FB5 RID: 12213
		// (get) Token: 0x0600C571 RID: 50545 RVA: 0x003016C4 File Offset: 0x002FF8C4
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

		// Token: 0x17002FB6 RID: 12214
		// (get) Token: 0x0600C572 RID: 50546 RVA: 0x00301704 File Offset: 0x002FF904
		public bool IsCopyCamera
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600C573 RID: 50547 RVA: 0x00301744 File Offset: 0x002FF944
		[NullableContext(1)]
		public int[] Args()
		{
			return this.GetArgsArray();
		}

		// Token: 0x0600C574 RID: 50548 RVA: 0x0030174C File Offset: 0x002FF94C
		[NullableContext(1)]
		public IEnumerable<int> ArgsIter()
		{
			RogueEvent.<ArgsIter>d__38 <ArgsIter>d__ = new RogueEvent.<ArgsIter>d__38(-2);
			<ArgsIter>d__.<>3__<>4__this = this;
			return <ArgsIter>d__;
		}

		// Token: 0x040056A5 RID: 22181
		private Table __p;
	}
}
