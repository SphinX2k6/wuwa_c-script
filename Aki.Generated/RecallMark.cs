using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FA1 RID: 4001
	public struct RecallMark : IFlatbufferObject
	{
		// Token: 0x17002D55 RID: 11605
		// (get) Token: 0x0600B9FE RID: 47614 RVA: 0x002D9A11 File Offset: 0x002D7C11
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B9FF RID: 47615 RVA: 0x002D9A1E File Offset: 0x002D7C1E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BA00 RID: 47616 RVA: 0x002D9A28 File Offset: 0x002D7C28
		public static RecallMark GetRootAsRecallMark(ByteBuffer _bb)
		{
			return RecallMark.GetRootAsRecallMark(_bb, default(RecallMark));
		}

		// Token: 0x0600BA01 RID: 47617 RVA: 0x002D9A44 File Offset: 0x002D7C44
		public static RecallMark GetRootAsRecallMark(ByteBuffer _bb, RecallMark obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BA02 RID: 47618 RVA: 0x002D9A61 File Offset: 0x002D7C61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BA03 RID: 47619 RVA: 0x002D9A70 File Offset: 0x002D7C70
		public RecallMark __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002D56 RID: 11606
		// (get) Token: 0x0600BA04 RID: 47620 RVA: 0x002D9A80 File Offset: 0x002D7C80
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

		// Token: 0x17002D57 RID: 11607
		// (get) Token: 0x0600BA05 RID: 47621 RVA: 0x002D9ABC File Offset: 0x002D7CBC
		public int RecallId
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

		// Token: 0x17002D58 RID: 11608
		// (get) Token: 0x0600BA06 RID: 47622 RVA: 0x002D9AF8 File Offset: 0x002D7CF8
		public int MarkId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005074 RID: 20596
		private Table __p;
	}
}
