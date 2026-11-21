using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011A8 RID: 4520
	public struct ShortMessage : IFlatbufferObject
	{
		// Token: 0x170036ED RID: 14061
		// (get) Token: 0x0600D9EC RID: 55788 RVA: 0x0032EF49 File Offset: 0x0032D149
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D9ED RID: 55789 RVA: 0x0032EF56 File Offset: 0x0032D156
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D9EE RID: 55790 RVA: 0x0032EF60 File Offset: 0x0032D160
		public static ShortMessage GetRootAsShortMessage(ByteBuffer _bb)
		{
			return ShortMessage.GetRootAsShortMessage(_bb, default(ShortMessage));
		}

		// Token: 0x0600D9EF RID: 55791 RVA: 0x0032EF7C File Offset: 0x0032D17C
		public static ShortMessage GetRootAsShortMessage(ByteBuffer _bb, ShortMessage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D9F0 RID: 55792 RVA: 0x0032EF99 File Offset: 0x0032D199
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D9F1 RID: 55793 RVA: 0x0032EFA8 File Offset: 0x0032D1A8
		public ShortMessage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170036EE RID: 14062
		// (get) Token: 0x0600D9F2 RID: 55794 RVA: 0x0032EFB8 File Offset: 0x0032D1B8
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

		// Token: 0x170036EF RID: 14063
		// (get) Token: 0x0600D9F3 RID: 55795 RVA: 0x0032EFF4 File Offset: 0x0032D1F4
		public int WhichChat
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

		// Token: 0x0600D9F4 RID: 55796 RVA: 0x0032F030 File Offset: 0x0032D230
		public string FlowParam(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170036F0 RID: 14064
		// (get) Token: 0x0600D9F5 RID: 55797 RVA: 0x0032F06C File Offset: 0x0032D26C
		public int FlowParamLength
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

		// Token: 0x170036F1 RID: 14065
		// (get) Token: 0x0600D9F6 RID: 55798 RVA: 0x0032F098 File Offset: 0x0032D298
		public int TipType
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

		// Token: 0x170036F2 RID: 14066
		// (get) Token: 0x0600D9F7 RID: 55799 RVA: 0x0032F0D8 File Offset: 0x0032D2D8
		public int ListenQuestId
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

		// Token: 0x170036F3 RID: 14067
		// (get) Token: 0x0600D9F8 RID: 55800 RVA: 0x0032F118 File Offset: 0x0032D318
		public int FinallPopType
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170036F4 RID: 14068
		// (get) Token: 0x0600D9F9 RID: 55801 RVA: 0x0032F158 File Offset: 0x0032D358
		public int DropId
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

		// Token: 0x170036F5 RID: 14069
		// (get) Token: 0x0600D9FA RID: 55802 RVA: 0x0032F198 File Offset: 0x0032D398
		public int QuestId
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

		// Token: 0x170036F6 RID: 14070
		// (get) Token: 0x0600D9FB RID: 55803 RVA: 0x0032F1D8 File Offset: 0x0032D3D8
		public int ActivityId
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

		// Token: 0x170036F7 RID: 14071
		// (get) Token: 0x0600D9FC RID: 55804 RVA: 0x0032F218 File Offset: 0x0032D418
		public string ActivityIcon
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D9FD RID: 55805 RVA: 0x0032F250 File Offset: 0x0032D450
		public Span<byte> GetActivityIconBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600D9FE RID: 55806 RVA: 0x0032F260 File Offset: 0x0032D460
		public byte[] GetActivityIconArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170036F8 RID: 14072
		// (get) Token: 0x0600D9FF RID: 55807 RVA: 0x0032F278 File Offset: 0x0032D478
		public string ActivityPre
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DA00 RID: 55808 RVA: 0x0032F2B0 File Offset: 0x0032D4B0
		public Span<byte> GetActivityPreBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600DA01 RID: 55809 RVA: 0x0032F2C0 File Offset: 0x0032D4C0
		public byte[] GetActivityPreArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x0600DA02 RID: 55810 RVA: 0x0032F2D8 File Offset: 0x0032D4D8
		[NullableContext(1)]
		public string[] FlowParam()
		{
			return this.FlowParamIter().ToArray<string>();
		}

		// Token: 0x0600DA03 RID: 55811 RVA: 0x0032F2E5 File Offset: 0x0032D4E5
		[NullableContext(1)]
		public IEnumerable<string> FlowParamIter()
		{
			ShortMessage.<FlowParamIter>d__36 <FlowParamIter>d__ = new ShortMessage.<FlowParamIter>d__36(-2);
			<FlowParamIter>d__.<>3__<>4__this = this;
			return <FlowParamIter>d__;
		}

		// Token: 0x040057BF RID: 22463
		private Table __p;
	}
}
