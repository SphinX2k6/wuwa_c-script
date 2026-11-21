using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001046 RID: 4166
	public struct PsFeedback : IFlatbufferObject
	{
		// Token: 0x17002B93 RID: 11155
		// (get) Token: 0x0600BA02 RID: 47618 RVA: 0x002E9048 File Offset: 0x002E7248
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BA03 RID: 47619 RVA: 0x002E9055 File Offset: 0x002E7255
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BA04 RID: 47620 RVA: 0x002E905C File Offset: 0x002E725C
		public static PsFeedback GetRootAsPsFeedback(ByteBuffer _bb)
		{
			return PsFeedback.GetRootAsPsFeedback(_bb, default(PsFeedback));
		}

		// Token: 0x0600BA05 RID: 47621 RVA: 0x002E9078 File Offset: 0x002E7278
		public static PsFeedback GetRootAsPsFeedback(ByteBuffer _bb, PsFeedback obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BA06 RID: 47622 RVA: 0x002E9095 File Offset: 0x002E7295
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BA07 RID: 47623 RVA: 0x002E90A4 File Offset: 0x002E72A4
		public PsFeedback __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002B94 RID: 11156
		// (get) Token: 0x0600BA08 RID: 47624 RVA: 0x002E90B4 File Offset: 0x002E72B4
		public string Id
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

		// Token: 0x0600BA09 RID: 47625 RVA: 0x002E90EB File Offset: 0x002E72EB
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600BA0A RID: 47626 RVA: 0x002E90FA File Offset: 0x002E72FA
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B95 RID: 11157
		// (get) Token: 0x0600BA0B RID: 47627 RVA: 0x002E9114 File Offset: 0x002E7314
		public string ActionName
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

		// Token: 0x0600BA0C RID: 47628 RVA: 0x002E914B File Offset: 0x002E734B
		public Span<byte> GetActionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600BA0D RID: 47629 RVA: 0x002E915A File Offset: 0x002E735A
		public byte[] GetActionNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B96 RID: 11158
		// (get) Token: 0x0600BA0E RID: 47630 RVA: 0x002E9174 File Offset: 0x002E7374
		public bool IsAxis
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002B97 RID: 11159
		// (get) Token: 0x0600BA0F RID: 47631 RVA: 0x002E91B4 File Offset: 0x002E73B4
		public string FeedbackPath
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

		// Token: 0x0600BA10 RID: 47632 RVA: 0x002E91EC File Offset: 0x002E73EC
		public Span<byte> GetFeedbackPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600BA11 RID: 47633 RVA: 0x002E91FC File Offset: 0x002E73FC
		public byte[] GetFeedbackPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B98 RID: 11160
		// (get) Token: 0x0600BA12 RID: 47634 RVA: 0x002E9214 File Offset: 0x002E7414
		public string ListenTag
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

		// Token: 0x0600BA13 RID: 47635 RVA: 0x002E924C File Offset: 0x002E744C
		public Span<byte> GetListenTagBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600BA14 RID: 47636 RVA: 0x002E925C File Offset: 0x002E745C
		public byte[] GetListenTagArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B99 RID: 11161
		// (get) Token: 0x0600BA15 RID: 47637 RVA: 0x002E9274 File Offset: 0x002E7474
		public int Priority
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

		// Token: 0x04005614 RID: 22036
		private Table __p;
	}
}
