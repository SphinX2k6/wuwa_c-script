using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200469D RID: 18077
	public struct IUseItemCondition : IFlatbufferObject
	{
		// Token: 0x17007E9B RID: 32411
		// (get) Token: 0x0601A8B9 RID: 108729 RVA: 0x003C6DBD File Offset: 0x003C4FBD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A8BA RID: 108730 RVA: 0x003C6DCA File Offset: 0x003C4FCA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A8BB RID: 108731 RVA: 0x003C6DD4 File Offset: 0x003C4FD4
		public static IUseItemCondition GetRootAsIUseItemCondition(ByteBuffer _bb)
		{
			return IUseItemCondition.GetRootAsIUseItemCondition(_bb, default(IUseItemCondition));
		}

		// Token: 0x0601A8BC RID: 108732 RVA: 0x003C6DF0 File Offset: 0x003C4FF0
		public static IUseItemCondition GetRootAsIUseItemCondition(ByteBuffer _bb, IUseItemCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A8BD RID: 108733 RVA: 0x003C6E0D File Offset: 0x003C500D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A8BE RID: 108734 RVA: 0x003C6E1C File Offset: 0x003C501C
		public IUseItemCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007E9C RID: 32412
		// (get) Token: 0x0601A8BF RID: 108735 RVA: 0x003C6E2C File Offset: 0x003C502C
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

		// Token: 0x17007E9D RID: 32413
		// (get) Token: 0x0601A8C0 RID: 108736 RVA: 0x003C6E68 File Offset: 0x003C5068
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

		// Token: 0x17007E9E RID: 32414
		// (get) Token: 0x0601A8C1 RID: 108737 RVA: 0x003C6EA4 File Offset: 0x003C50A4
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

		// Token: 0x17007E9F RID: 32415
		// (get) Token: 0x0601A8C2 RID: 108738 RVA: 0x003C6EE0 File Offset: 0x003C50E0
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

		// Token: 0x0601A8C3 RID: 108739 RVA: 0x003C6F3E File Offset: 0x003C513E
		public static Offset<IUseItemCondition> CreateIUseItemCondition(FlatBufferBuilder builder, int ItemId = 0, int Count = 0, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>))
		{
			builder.StartTable(4);
			IUseItemCondition.AddPreConditions(builder, PreConditionsOffset);
			IUseItemCondition.AddCount(builder, Count);
			IUseItemCondition.AddItemId(builder, ItemId);
			IUseItemCondition.AddType(builder, Type);
			return IUseItemCondition.EndIUseItemCondition(builder);
		}

		// Token: 0x0601A8C4 RID: 108740 RVA: 0x003C6F6A File Offset: 0x003C516A
		public static void StartIUseItemCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601A8C5 RID: 108741 RVA: 0x003C6F73 File Offset: 0x003C5173
		public static void AddItemId(FlatBufferBuilder builder, int itemId)
		{
			builder.AddInt(0, itemId, 0);
		}

		// Token: 0x0601A8C6 RID: 108742 RVA: 0x003C6F7E File Offset: 0x003C517E
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(1, count, 0);
		}

		// Token: 0x0601A8C7 RID: 108743 RVA: 0x003C6F89 File Offset: 0x003C5189
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(2, (byte)type, 0);
		}

		// Token: 0x0601A8C8 RID: 108744 RVA: 0x003C6F94 File Offset: 0x003C5194
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(3, preConditionsOffset.Value, 0);
		}

		// Token: 0x0601A8C9 RID: 108745 RVA: 0x003C6FA4 File Offset: 0x003C51A4
		public static Offset<IUseItemCondition> EndIUseItemCondition(FlatBufferBuilder builder)
		{
			return new Offset<IUseItemCondition>(builder.EndTable());
		}

		// Token: 0x0601A8CA RID: 108746 RVA: 0x003C6FB4 File Offset: 0x003C51B4
		public IUseItemConditionT UnPack()
		{
			IUseItemConditionT useItemConditionT = new IUseItemConditionT();
			this.UnPackTo(useItemConditionT);
			return useItemConditionT;
		}

		// Token: 0x0601A8CB RID: 108747 RVA: 0x003C6FD0 File Offset: 0x003C51D0
		public void UnPackTo(IUseItemConditionT _o)
		{
			_o.ItemId = this.ItemId;
			_o.Count = this.Count;
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
		}

		// Token: 0x0601A8CC RID: 108748 RVA: 0x003C7030 File Offset: 0x003C5230
		public static Offset<IUseItemCondition> Pack(FlatBufferBuilder builder, IUseItemConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUseItemCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			return IUseItemCondition.CreateIUseItemCondition(builder, _o.ItemId, _o.Count, _o.Type, preConditionsOffset);
		}

		// Token: 0x0400C8D0 RID: 51408
		private Table __p;
	}
}
