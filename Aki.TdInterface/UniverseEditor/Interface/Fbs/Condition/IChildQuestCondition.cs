using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200505E RID: 20574
	public struct IChildQuestCondition : IFlatbufferObject
	{
		// Token: 0x17009344 RID: 37700
		// (get) Token: 0x060202A9 RID: 131753 RVA: 0x00475E94 File Offset: 0x00474094
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060202AA RID: 131754 RVA: 0x00475EA1 File Offset: 0x004740A1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060202AB RID: 131755 RVA: 0x00475EA8 File Offset: 0x004740A8
		public static IChildQuestCondition GetRootAsIChildQuestCondition(ByteBuffer _bb)
		{
			return IChildQuestCondition.GetRootAsIChildQuestCondition(_bb, default(IChildQuestCondition));
		}

		// Token: 0x060202AC RID: 131756 RVA: 0x00475EC4 File Offset: 0x004740C4
		public static IChildQuestCondition GetRootAsIChildQuestCondition(ByteBuffer _bb, IChildQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060202AD RID: 131757 RVA: 0x00475EE1 File Offset: 0x004740E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060202AE RID: 131758 RVA: 0x00475EF0 File Offset: 0x004740F0
		public IChildQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009345 RID: 37701
		// (get) Token: 0x060202AF RID: 131759 RVA: 0x00475F00 File Offset: 0x00474100
		public int QuestId
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

		// Token: 0x17009346 RID: 37702
		// (get) Token: 0x060202B0 RID: 131760 RVA: 0x00475F3C File Offset: 0x0047413C
		public int ChildQuestId
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

		// Token: 0x060202B1 RID: 131761 RVA: 0x00475F78 File Offset: 0x00474178
		public static Offset<IChildQuestCondition> CreateIChildQuestCondition(FlatBufferBuilder builder, int QuestId = 0, int ChildQuestId = 0)
		{
			builder.StartTable(2);
			IChildQuestCondition.AddChildQuestId(builder, ChildQuestId);
			IChildQuestCondition.AddQuestId(builder, QuestId);
			return IChildQuestCondition.EndIChildQuestCondition(builder);
		}

		// Token: 0x060202B2 RID: 131762 RVA: 0x00475F95 File Offset: 0x00474195
		public static void StartIChildQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060202B3 RID: 131763 RVA: 0x00475F9E File Offset: 0x0047419E
		public static void AddQuestId(FlatBufferBuilder builder, int questId)
		{
			builder.AddInt(0, questId, 0);
		}

		// Token: 0x060202B4 RID: 131764 RVA: 0x00475FA9 File Offset: 0x004741A9
		public static void AddChildQuestId(FlatBufferBuilder builder, int childQuestId)
		{
			builder.AddInt(1, childQuestId, 0);
		}

		// Token: 0x060202B5 RID: 131765 RVA: 0x00475FB4 File Offset: 0x004741B4
		public static Offset<IChildQuestCondition> EndIChildQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<IChildQuestCondition>(builder.EndTable());
		}

		// Token: 0x060202B6 RID: 131766 RVA: 0x00475FC4 File Offset: 0x004741C4
		public IChildQuestConditionT UnPack()
		{
			IChildQuestConditionT childQuestConditionT = new IChildQuestConditionT();
			this.UnPackTo(childQuestConditionT);
			return childQuestConditionT;
		}

		// Token: 0x060202B7 RID: 131767 RVA: 0x00475FDF File Offset: 0x004741DF
		public void UnPackTo(IChildQuestConditionT _o)
		{
			_o.QuestId = this.QuestId;
			_o.ChildQuestId = this.ChildQuestId;
		}

		// Token: 0x060202B8 RID: 131768 RVA: 0x00475FFC File Offset: 0x004741FC
		public static Offset<IChildQuestCondition> Pack(FlatBufferBuilder builder, IChildQuestConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChildQuestCondition>);
			}
			return IChildQuestCondition.CreateIChildQuestCondition(builder, _o.QuestId, _o.ChildQuestId);
		}

		// Token: 0x0400DF43 RID: 57155
		private Table __p;
	}
}
