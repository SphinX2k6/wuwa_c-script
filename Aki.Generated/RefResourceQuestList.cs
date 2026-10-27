using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FA8 RID: 4008
	public struct RefResourceQuestList : IFlatbufferObject
	{
		// Token: 0x17002D78 RID: 11640
		// (get) Token: 0x0600BA91 RID: 47761 RVA: 0x002DB040 File Offset: 0x002D9240
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BA92 RID: 47762 RVA: 0x002DB04D File Offset: 0x002D924D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BA93 RID: 47763 RVA: 0x002DB054 File Offset: 0x002D9254
		public static RefResourceQuestList GetRootAsRefResourceQuestList(ByteBuffer _bb)
		{
			return RefResourceQuestList.GetRootAsRefResourceQuestList(_bb, default(RefResourceQuestList));
		}

		// Token: 0x0600BA94 RID: 47764 RVA: 0x002DB070 File Offset: 0x002D9270
		public static RefResourceQuestList GetRootAsRefResourceQuestList(ByteBuffer _bb, RefResourceQuestList obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BA95 RID: 47765 RVA: 0x002DB08D File Offset: 0x002D928D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BA96 RID: 47766 RVA: 0x002DB09C File Offset: 0x002D929C
		public RefResourceQuestList __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002D79 RID: 11641
		// (get) Token: 0x0600BA97 RID: 47767 RVA: 0x002DB0AC File Offset: 0x002D92AC
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

		// Token: 0x17002D7A RID: 11642
		// (get) Token: 0x0600BA98 RID: 47768 RVA: 0x002DB0E8 File Offset: 0x002D92E8
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

		// Token: 0x17002D7B RID: 11643
		// (get) Token: 0x0600BA99 RID: 47769 RVA: 0x002DB124 File Offset: 0x002D9324
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

		// Token: 0x04005081 RID: 20609
		private Table __p;
	}
}
