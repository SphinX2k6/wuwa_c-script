using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CC3 RID: 3267
	public struct FlowState : IFlatbufferObject
	{
		// Token: 0x17001395 RID: 5013
		// (get) Token: 0x0600755D RID: 30045 RVA: 0x0023FCA9 File Offset: 0x0023DEA9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600755E RID: 30046 RVA: 0x0023FCB6 File Offset: 0x0023DEB6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600755F RID: 30047 RVA: 0x0023FCC0 File Offset: 0x0023DEC0
		public static FlowState GetRootAsFlowState(ByteBuffer _bb)
		{
			return FlowState.GetRootAsFlowState(_bb, default(FlowState));
		}

		// Token: 0x06007560 RID: 30048 RVA: 0x0023FCDC File Offset: 0x0023DEDC
		public static FlowState GetRootAsFlowState(ByteBuffer _bb, FlowState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007561 RID: 30049 RVA: 0x0023FCF9 File Offset: 0x0023DEF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007562 RID: 30050 RVA: 0x0023FD08 File Offset: 0x0023DF08
		public FlowState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001396 RID: 5014
		// (get) Token: 0x06007563 RID: 30051 RVA: 0x0023FD18 File Offset: 0x0023DF18
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

		// Token: 0x06007564 RID: 30052 RVA: 0x0023FD4F File Offset: 0x0023DF4F
		public Span<byte> GetStateKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06007565 RID: 30053 RVA: 0x0023FD5E File Offset: 0x0023DF5E
		public byte[] GetStateKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17001397 RID: 5015
		// (get) Token: 0x06007566 RID: 30054 RVA: 0x0023FD78 File Offset: 0x0023DF78
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

		// Token: 0x17001398 RID: 5016
		// (get) Token: 0x06007567 RID: 30055 RVA: 0x0023FDB4 File Offset: 0x0023DFB4
		public bool KeepBgm
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001399 RID: 5017
		// (get) Token: 0x06007568 RID: 30056 RVA: 0x0023FDF4 File Offset: 0x0023DFF4
		public bool IsPreloadFlow
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700139A RID: 5018
		// (get) Token: 0x06007569 RID: 30057 RVA: 0x0023FE34 File Offset: 0x0023E034
		public bool IsClientFlow
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700139B RID: 5019
		// (get) Token: 0x0600756A RID: 30058 RVA: 0x0023FE74 File Offset: 0x0023E074
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

		// Token: 0x0600756B RID: 30059 RVA: 0x0023FEAC File Offset: 0x0023E0AC
		public Span<byte> GetPosBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600756C RID: 30060 RVA: 0x0023FEBC File Offset: 0x0023E0BC
		public byte[] GetPosArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700139C RID: 5020
		// (get) Token: 0x0600756D RID: 30061 RVA: 0x0023FED4 File Offset: 0x0023E0D4
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

		// Token: 0x0600756E RID: 30062 RVA: 0x0023FF0C File Offset: 0x0023E10C
		public Span<byte> GetActionsBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600756F RID: 30063 RVA: 0x0023FF1C File Offset: 0x0023E11C
		public byte[] GetActionsArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700139D RID: 5021
		// (get) Token: 0x06007570 RID: 30064 RVA: 0x0023FF34 File Offset: 0x0023E134
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

		// Token: 0x06007571 RID: 30065 RVA: 0x0023FF6C File Offset: 0x0023E16C
		public Span<byte> GetProgramSpecialProcessBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06007572 RID: 30066 RVA: 0x0023FF7C File Offset: 0x0023E17C
		public byte[] GetProgramSpecialProcessArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x04004D33 RID: 19763
		private Table __p;
	}
}
