using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DA7 RID: 3495
	public struct FlowState : IFlatbufferObject
	{
		// Token: 0x170013F2 RID: 5106
		// (get) Token: 0x06007B68 RID: 31592 RVA: 0x0025E9B6 File Offset: 0x0025CBB6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007B69 RID: 31593 RVA: 0x0025E9C3 File Offset: 0x0025CBC3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007B6A RID: 31594 RVA: 0x0025E9CC File Offset: 0x0025CBCC
		public static FlowState GetRootAsFlowState(ByteBuffer _bb)
		{
			return FlowState.GetRootAsFlowState(_bb, default(FlowState));
		}

		// Token: 0x06007B6B RID: 31595 RVA: 0x0025E9E8 File Offset: 0x0025CBE8
		public static FlowState GetRootAsFlowState(ByteBuffer _bb, FlowState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007B6C RID: 31596 RVA: 0x0025EA05 File Offset: 0x0025CC05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007B6D RID: 31597 RVA: 0x0025EA14 File Offset: 0x0025CC14
		public FlowState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170013F3 RID: 5107
		// (get) Token: 0x06007B6E RID: 31598 RVA: 0x0025EA24 File Offset: 0x0025CC24
		public string StateKey
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007B6F RID: 31599 RVA: 0x0025EA5B File Offset: 0x0025CC5B
		public Span<byte> GetStateKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06007B70 RID: 31600 RVA: 0x0025EA6A File Offset: 0x0025CC6A
		public byte[] GetStateKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x170013F4 RID: 5108
		// (get) Token: 0x06007B71 RID: 31601 RVA: 0x0025EA84 File Offset: 0x0025CC84
		public int Id
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

		// Token: 0x170013F5 RID: 5109
		// (get) Token: 0x06007B72 RID: 31602 RVA: 0x0025EAC0 File Offset: 0x0025CCC0
		public bool KeepBgm
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170013F6 RID: 5110
		// (get) Token: 0x06007B73 RID: 31603 RVA: 0x0025EB00 File Offset: 0x0025CD00
		public bool IsPreloadFlow
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170013F7 RID: 5111
		// (get) Token: 0x06007B74 RID: 31604 RVA: 0x0025EB40 File Offset: 0x0025CD40
		public bool IsClientFlow
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170013F8 RID: 5112
		// (get) Token: 0x06007B75 RID: 31605 RVA: 0x0025EB80 File Offset: 0x0025CD80
		public string Pos
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

		// Token: 0x06007B76 RID: 31606 RVA: 0x0025EBB8 File Offset: 0x0025CDB8
		public Span<byte> GetPosBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06007B77 RID: 31607 RVA: 0x0025EBC8 File Offset: 0x0025CDC8
		public byte[] GetPosArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170013F9 RID: 5113
		// (get) Token: 0x06007B78 RID: 31608 RVA: 0x0025EBE0 File Offset: 0x0025CDE0
		public string Actions
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

		// Token: 0x06007B79 RID: 31609 RVA: 0x0025EC18 File Offset: 0x0025CE18
		public Span<byte> GetActionsBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06007B7A RID: 31610 RVA: 0x0025EC28 File Offset: 0x0025CE28
		public byte[] GetActionsArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170013FA RID: 5114
		// (get) Token: 0x06007B7B RID: 31611 RVA: 0x0025EC40 File Offset: 0x0025CE40
		public string ProgramSpecialProcess
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

		// Token: 0x06007B7C RID: 31612 RVA: 0x0025EC78 File Offset: 0x0025CE78
		public Span<byte> GetProgramSpecialProcessBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06007B7D RID: 31613 RVA: 0x0025EC88 File Offset: 0x0025CE88
		public byte[] GetProgramSpecialProcessArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x04005317 RID: 21271
		private Table __p;
	}
}
