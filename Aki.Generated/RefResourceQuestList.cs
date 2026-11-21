using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001090 RID: 4240
	public struct RefResourceQuestList : IFlatbufferObject
	{
		// Token: 0x17002DF3 RID: 11763
		// (get) Token: 0x0600C0DB RID: 49371 RVA: 0x002F77EC File Offset: 0x002F59EC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C0DC RID: 49372 RVA: 0x002F77F9 File Offset: 0x002F59F9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C0DD RID: 49373 RVA: 0x002F7800 File Offset: 0x002F5A00
		public static RefResourceQuestList GetRootAsRefResourceQuestList(ByteBuffer _bb)
		{
			return RefResourceQuestList.GetRootAsRefResourceQuestList(_bb, default(RefResourceQuestList));
		}

		// Token: 0x0600C0DE RID: 49374 RVA: 0x002F781C File Offset: 0x002F5A1C
		public static RefResourceQuestList GetRootAsRefResourceQuestList(ByteBuffer _bb, RefResourceQuestList obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C0DF RID: 49375 RVA: 0x002F7839 File Offset: 0x002F5A39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C0E0 RID: 49376 RVA: 0x002F7848 File Offset: 0x002F5A48
		public RefResourceQuestList __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002DF4 RID: 11764
		// (get) Token: 0x0600C0E1 RID: 49377 RVA: 0x002F7858 File Offset: 0x002F5A58
		public int BitId
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

		// Token: 0x17002DF5 RID: 11765
		// (get) Token: 0x0600C0E2 RID: 49378 RVA: 0x002F7894 File Offset: 0x002F5A94
		public int QuestId
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

		// Token: 0x17002DF6 RID: 11766
		// (get) Token: 0x0600C0E3 RID: 49379 RVA: 0x002F78D0 File Offset: 0x002F5AD0
		public int HasRefResource
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

		// Token: 0x04005669 RID: 22121
		private Table __p;
	}
}
