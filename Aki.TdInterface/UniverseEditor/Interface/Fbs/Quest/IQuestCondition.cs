using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200440F RID: 17423
	public struct IQuestCondition : IFlatbufferObject
	{
		// Token: 0x1700786C RID: 30828
		// (get) Token: 0x06018D88 RID: 101768 RVA: 0x0038B0BB File Offset: 0x003892BB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018D89 RID: 101769 RVA: 0x0038B0C8 File Offset: 0x003892C8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018D8A RID: 101770 RVA: 0x0038B0D0 File Offset: 0x003892D0
		public static IQuestCondition GetRootAsIQuestCondition(ByteBuffer _bb)
		{
			return IQuestCondition.GetRootAsIQuestCondition(_bb, default(IQuestCondition));
		}

		// Token: 0x06018D8B RID: 101771 RVA: 0x0038B0EC File Offset: 0x003892EC
		public static IQuestCondition GetRootAsIQuestCondition(ByteBuffer _bb, IQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018D8C RID: 101772 RVA: 0x0038B109 File Offset: 0x00389309
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018D8D RID: 101773 RVA: 0x0038B118 File Offset: 0x00389318
		public IQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700786D RID: 30829
		// (get) Token: 0x06018D8E RID: 101774 RVA: 0x0038B128 File Offset: 0x00389328
		public EChildQuest Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChildQuest.DoInteract;
				}
				return (EChildQuest)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700786E RID: 30830
		// (get) Token: 0x06018D8F RID: 101775 RVA: 0x0038B164 File Offset: 0x00389364
		public IConditionGroup? PreConditions
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06018D90 RID: 101776 RVA: 0x0038B1C1 File Offset: 0x003893C1
		public static Offset<IQuestCondition> CreateIQuestCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>))
		{
			builder.StartTable(2);
			IQuestCondition.AddPreConditions(builder, PreConditionsOffset);
			IQuestCondition.AddType(builder, Type);
			return IQuestCondition.EndIQuestCondition(builder);
		}

		// Token: 0x06018D91 RID: 101777 RVA: 0x0038B1DE File Offset: 0x003893DE
		public static void StartIQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06018D92 RID: 101778 RVA: 0x0038B1E7 File Offset: 0x003893E7
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018D93 RID: 101779 RVA: 0x0038B1F2 File Offset: 0x003893F2
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06018D94 RID: 101780 RVA: 0x0038B202 File Offset: 0x00389402
		public static Offset<IQuestCondition> EndIQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<IQuestCondition>(builder.EndTable());
		}

		// Token: 0x06018D95 RID: 101781 RVA: 0x0038B210 File Offset: 0x00389410
		public IQuestConditionT UnPack()
		{
			IQuestConditionT questConditionT = new IQuestConditionT();
			this.UnPackTo(questConditionT);
			return questConditionT;
		}

		// Token: 0x06018D96 RID: 101782 RVA: 0x0038B22C File Offset: 0x0038942C
		public void UnPackTo(IQuestConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
		}

		// Token: 0x06018D97 RID: 101783 RVA: 0x0038B274 File Offset: 0x00389474
		public static Offset<IQuestCondition> Pack(FlatBufferBuilder builder, IQuestConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			return IQuestCondition.CreateIQuestCondition(builder, _o.Type, preConditionsOffset);
		}

		// Token: 0x0400C454 RID: 50260
		private Table __p;
	}
}
