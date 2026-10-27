using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FCE RID: 16334
	public struct IQuestCondition : IFlatbufferObject
	{
		// Token: 0x1700726C RID: 29292
		// (get) Token: 0x060176F5 RID: 95989 RVA: 0x00361393 File Offset: 0x0035F593
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060176F6 RID: 95990 RVA: 0x003613A0 File Offset: 0x0035F5A0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060176F7 RID: 95991 RVA: 0x003613A8 File Offset: 0x0035F5A8
		public static IQuestCondition GetRootAsIQuestCondition(ByteBuffer _bb)
		{
			return IQuestCondition.GetRootAsIQuestCondition(_bb, default(IQuestCondition));
		}

		// Token: 0x060176F8 RID: 95992 RVA: 0x003613C4 File Offset: 0x0035F5C4
		public static IQuestCondition GetRootAsIQuestCondition(ByteBuffer _bb, IQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060176F9 RID: 95993 RVA: 0x003613E1 File Offset: 0x0035F5E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060176FA RID: 95994 RVA: 0x003613F0 File Offset: 0x0035F5F0
		public IQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700726D RID: 29293
		// (get) Token: 0x060176FB RID: 95995 RVA: 0x00361400 File Offset: 0x0035F600
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

		// Token: 0x1700726E RID: 29294
		// (get) Token: 0x060176FC RID: 95996 RVA: 0x0036143C File Offset: 0x0035F63C
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

		// Token: 0x060176FD RID: 95997 RVA: 0x00361499 File Offset: 0x0035F699
		public static Offset<IQuestCondition> CreateIQuestCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>))
		{
			builder.StartTable(2);
			IQuestCondition.AddPreConditions(builder, PreConditionsOffset);
			IQuestCondition.AddType(builder, Type);
			return IQuestCondition.EndIQuestCondition(builder);
		}

		// Token: 0x060176FE RID: 95998 RVA: 0x003614B6 File Offset: 0x0035F6B6
		public static void StartIQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060176FF RID: 95999 RVA: 0x003614BF File Offset: 0x0035F6BF
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017700 RID: 96000 RVA: 0x003614CA File Offset: 0x0035F6CA
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06017701 RID: 96001 RVA: 0x003614DA File Offset: 0x0035F6DA
		public static Offset<IQuestCondition> EndIQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<IQuestCondition>(builder.EndTable());
		}

		// Token: 0x06017702 RID: 96002 RVA: 0x003614E8 File Offset: 0x0035F6E8
		public IQuestConditionT UnPack()
		{
			IQuestConditionT questConditionT = new IQuestConditionT();
			this.UnPackTo(questConditionT);
			return questConditionT;
		}

		// Token: 0x06017703 RID: 96003 RVA: 0x00361504 File Offset: 0x0035F704
		public void UnPackTo(IQuestConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
		}

		// Token: 0x06017704 RID: 96004 RVA: 0x0036154C File Offset: 0x0035F74C
		public static Offset<IQuestCondition> Pack(FlatBufferBuilder builder, IQuestConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			return IQuestCondition.CreateIQuestCondition(builder, _o.Type, preConditionsOffset);
		}

		// Token: 0x0400BA6E RID: 47726
		private Table __p;
	}
}
