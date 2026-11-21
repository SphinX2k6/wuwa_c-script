using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004334 RID: 17204
	public struct ILeaveDungeonCondition : IFlatbufferObject
	{
		// Token: 0x170075BD RID: 30141
		// (get) Token: 0x0601833B RID: 99131 RVA: 0x00373420 File Offset: 0x00371620
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601833C RID: 99132 RVA: 0x0037342D File Offset: 0x0037162D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601833D RID: 99133 RVA: 0x00373434 File Offset: 0x00371634
		public static ILeaveDungeonCondition GetRootAsILeaveDungeonCondition(ByteBuffer _bb)
		{
			return ILeaveDungeonCondition.GetRootAsILeaveDungeonCondition(_bb, default(ILeaveDungeonCondition));
		}

		// Token: 0x0601833E RID: 99134 RVA: 0x00373450 File Offset: 0x00371650
		public static ILeaveDungeonCondition GetRootAsILeaveDungeonCondition(ByteBuffer _bb, ILeaveDungeonCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601833F RID: 99135 RVA: 0x0037346D File Offset: 0x0037166D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018340 RID: 99136 RVA: 0x0037347C File Offset: 0x0037167C
		public ILeaveDungeonCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170075BE RID: 30142
		// (get) Token: 0x06018341 RID: 99137 RVA: 0x0037348C File Offset: 0x0037168C
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

		// Token: 0x170075BF RID: 30143
		// (get) Token: 0x06018342 RID: 99138 RVA: 0x003734C8 File Offset: 0x003716C8
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

		// Token: 0x06018343 RID: 99139 RVA: 0x00373525 File Offset: 0x00371725
		public static Offset<ILeaveDungeonCondition> CreateILeaveDungeonCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>))
		{
			builder.StartTable(2);
			ILeaveDungeonCondition.AddPreConditions(builder, PreConditionsOffset);
			ILeaveDungeonCondition.AddType(builder, Type);
			return ILeaveDungeonCondition.EndILeaveDungeonCondition(builder);
		}

		// Token: 0x06018344 RID: 99140 RVA: 0x00373542 File Offset: 0x00371742
		public static void StartILeaveDungeonCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06018345 RID: 99141 RVA: 0x0037354B File Offset: 0x0037174B
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018346 RID: 99142 RVA: 0x00373556 File Offset: 0x00371756
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06018347 RID: 99143 RVA: 0x00373566 File Offset: 0x00371766
		public static Offset<ILeaveDungeonCondition> EndILeaveDungeonCondition(FlatBufferBuilder builder)
		{
			return new Offset<ILeaveDungeonCondition>(builder.EndTable());
		}

		// Token: 0x06018348 RID: 99144 RVA: 0x00373574 File Offset: 0x00371774
		public ILeaveDungeonConditionT UnPack()
		{
			ILeaveDungeonConditionT leaveDungeonConditionT = new ILeaveDungeonConditionT();
			this.UnPackTo(leaveDungeonConditionT);
			return leaveDungeonConditionT;
		}

		// Token: 0x06018349 RID: 99145 RVA: 0x00373590 File Offset: 0x00371790
		public void UnPackTo(ILeaveDungeonConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
		}

		// Token: 0x0601834A RID: 99146 RVA: 0x003735D8 File Offset: 0x003717D8
		public static Offset<ILeaveDungeonCondition> Pack(FlatBufferBuilder builder, ILeaveDungeonConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILeaveDungeonCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			return ILeaveDungeonCondition.CreateILeaveDungeonCondition(builder, _o.Type, preConditionsOffset);
		}

		// Token: 0x0400C2B0 RID: 49840
		private Table __p;
	}
}
