using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004241 RID: 16961
	public struct IUseItemCondition : IFlatbufferObject
	{
		// Token: 0x1700786A RID: 30826
		// (get) Token: 0x0601914D RID: 102733 RVA: 0x0039B6E5 File Offset: 0x003998E5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601914E RID: 102734 RVA: 0x0039B6F2 File Offset: 0x003998F2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601914F RID: 102735 RVA: 0x0039B6FC File Offset: 0x003998FC
		public static IUseItemCondition GetRootAsIUseItemCondition(ByteBuffer _bb)
		{
			return IUseItemCondition.GetRootAsIUseItemCondition(_bb, default(IUseItemCondition));
		}

		// Token: 0x06019150 RID: 102736 RVA: 0x0039B718 File Offset: 0x00399918
		public static IUseItemCondition GetRootAsIUseItemCondition(ByteBuffer _bb, IUseItemCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019151 RID: 102737 RVA: 0x0039B735 File Offset: 0x00399935
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019152 RID: 102738 RVA: 0x0039B744 File Offset: 0x00399944
		public IUseItemCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700786B RID: 30827
		// (get) Token: 0x06019153 RID: 102739 RVA: 0x0039B754 File Offset: 0x00399954
		public int ItemId
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

		// Token: 0x1700786C RID: 30828
		// (get) Token: 0x06019154 RID: 102740 RVA: 0x0039B790 File Offset: 0x00399990
		public int Count
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

		// Token: 0x1700786D RID: 30829
		// (get) Token: 0x06019155 RID: 102741 RVA: 0x0039B7CC File Offset: 0x003999CC
		public EChildQuest Type
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EChildQuest.DoInteract;
				}
				return (EChildQuest)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700786E RID: 30830
		// (get) Token: 0x06019156 RID: 102742 RVA: 0x0039B808 File Offset: 0x00399A08
		public IConditionGroup? PreConditions
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06019157 RID: 102743 RVA: 0x0039B866 File Offset: 0x00399A66
		public static Offset<IUseItemCondition> CreateIUseItemCondition(FlatBufferBuilder builder, int ItemId = 0, int Count = 0, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>))
		{
			builder.StartTable(4);
			IUseItemCondition.AddPreConditions(builder, PreConditionsOffset);
			IUseItemCondition.AddCount(builder, Count);
			IUseItemCondition.AddItemId(builder, ItemId);
			IUseItemCondition.AddType(builder, Type);
			return IUseItemCondition.EndIUseItemCondition(builder);
		}

		// Token: 0x06019158 RID: 102744 RVA: 0x0039B892 File Offset: 0x00399A92
		public static void StartIUseItemCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06019159 RID: 102745 RVA: 0x0039B89B File Offset: 0x00399A9B
		public static void AddItemId(FlatBufferBuilder builder, int itemId)
		{
			builder.AddInt(0, itemId, 0);
		}

		// Token: 0x0601915A RID: 102746 RVA: 0x0039B8A6 File Offset: 0x00399AA6
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(1, count, 0);
		}

		// Token: 0x0601915B RID: 102747 RVA: 0x0039B8B1 File Offset: 0x00399AB1
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(2, (byte)type, 0);
		}

		// Token: 0x0601915C RID: 102748 RVA: 0x0039B8BC File Offset: 0x00399ABC
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(3, preConditionsOffset.Value, 0);
		}

		// Token: 0x0601915D RID: 102749 RVA: 0x0039B8CC File Offset: 0x00399ACC
		public static Offset<IUseItemCondition> EndIUseItemCondition(FlatBufferBuilder builder)
		{
			return new Offset<IUseItemCondition>(builder.EndTable());
		}

		// Token: 0x0601915E RID: 102750 RVA: 0x0039B8DC File Offset: 0x00399ADC
		public IUseItemConditionT UnPack()
		{
			IUseItemConditionT useItemConditionT = new IUseItemConditionT();
			this.UnPackTo(useItemConditionT);
			return useItemConditionT;
		}

		// Token: 0x0601915F RID: 102751 RVA: 0x0039B8F8 File Offset: 0x00399AF8
		public void UnPackTo(IUseItemConditionT _o)
		{
			_o.ItemId = this.ItemId;
			_o.Count = this.Count;
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
		}

		// Token: 0x06019160 RID: 102752 RVA: 0x0039B958 File Offset: 0x00399B58
		public static Offset<IUseItemCondition> Pack(FlatBufferBuilder builder, IUseItemConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUseItemCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			return IUseItemCondition.CreateIUseItemCondition(builder, _o.ItemId, _o.Count, _o.Type, preConditionsOffset);
		}

		// Token: 0x0400BEC3 RID: 48835
		private Table __p;
	}
}
