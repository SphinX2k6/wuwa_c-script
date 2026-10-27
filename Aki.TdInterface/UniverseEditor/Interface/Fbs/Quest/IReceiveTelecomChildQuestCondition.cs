using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040A0 RID: 16544
	public struct IReceiveTelecomChildQuestCondition : IFlatbufferObject
	{
		// Token: 0x170074B9 RID: 29881
		// (get) Token: 0x06018153 RID: 98643 RVA: 0x00378DC2 File Offset: 0x00376FC2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018154 RID: 98644 RVA: 0x00378DCF File Offset: 0x00376FCF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018155 RID: 98645 RVA: 0x00378DD8 File Offset: 0x00376FD8
		public static IReceiveTelecomChildQuestCondition GetRootAsIReceiveTelecomChildQuestCondition(ByteBuffer _bb)
		{
			return IReceiveTelecomChildQuestCondition.GetRootAsIReceiveTelecomChildQuestCondition(_bb, default(IReceiveTelecomChildQuestCondition));
		}

		// Token: 0x06018156 RID: 98646 RVA: 0x00378DF4 File Offset: 0x00376FF4
		public static IReceiveTelecomChildQuestCondition GetRootAsIReceiveTelecomChildQuestCondition(ByteBuffer _bb, IReceiveTelecomChildQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018157 RID: 98647 RVA: 0x00378E11 File Offset: 0x00377011
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018158 RID: 98648 RVA: 0x00378E20 File Offset: 0x00377020
		public IReceiveTelecomChildQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170074BA RID: 29882
		// (get) Token: 0x06018159 RID: 98649 RVA: 0x00378E30 File Offset: 0x00377030
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

		// Token: 0x170074BB RID: 29883
		// (get) Token: 0x0601815A RID: 98650 RVA: 0x00378E6C File Offset: 0x0037706C
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

		// Token: 0x170074BC RID: 29884
		// (get) Token: 0x0601815B RID: 98651 RVA: 0x00378ECC File Offset: 0x003770CC
		public int TelecomId
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

		// Token: 0x0601815C RID: 98652 RVA: 0x00378F08 File Offset: 0x00377108
		public static Offset<IReceiveTelecomChildQuestCondition> CreateIReceiveTelecomChildQuestCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), int TelecomId = 0)
		{
			builder.StartTable(3);
			IReceiveTelecomChildQuestCondition.AddTelecomId(builder, TelecomId);
			IReceiveTelecomChildQuestCondition.AddPreConditions(builder, PreConditionsOffset);
			IReceiveTelecomChildQuestCondition.AddType(builder, Type);
			return IReceiveTelecomChildQuestCondition.EndIReceiveTelecomChildQuestCondition(builder);
		}

		// Token: 0x0601815D RID: 98653 RVA: 0x00378F2C File Offset: 0x0037712C
		public static void StartIReceiveTelecomChildQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601815E RID: 98654 RVA: 0x00378F35 File Offset: 0x00377135
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601815F RID: 98655 RVA: 0x00378F40 File Offset: 0x00377140
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06018160 RID: 98656 RVA: 0x00378F50 File Offset: 0x00377150
		public static void AddTelecomId(FlatBufferBuilder builder, int telecomId)
		{
			builder.AddInt(2, telecomId, 0);
		}

		// Token: 0x06018161 RID: 98657 RVA: 0x00378F5B File Offset: 0x0037715B
		public static Offset<IReceiveTelecomChildQuestCondition> EndIReceiveTelecomChildQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<IReceiveTelecomChildQuestCondition>(builder.EndTable());
		}

		// Token: 0x06018162 RID: 98658 RVA: 0x00378F68 File Offset: 0x00377168
		public IReceiveTelecomChildQuestConditionT UnPack()
		{
			IReceiveTelecomChildQuestConditionT receiveTelecomChildQuestConditionT = new IReceiveTelecomChildQuestConditionT();
			this.UnPackTo(receiveTelecomChildQuestConditionT);
			return receiveTelecomChildQuestConditionT;
		}

		// Token: 0x06018163 RID: 98659 RVA: 0x00378F84 File Offset: 0x00377184
		public void UnPackTo(IReceiveTelecomChildQuestConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.TelecomId = this.TelecomId;
		}

		// Token: 0x06018164 RID: 98660 RVA: 0x00378FD8 File Offset: 0x003771D8
		public static Offset<IReceiveTelecomChildQuestCondition> Pack(FlatBufferBuilder builder, IReceiveTelecomChildQuestConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IReceiveTelecomChildQuestCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			return IReceiveTelecomChildQuestCondition.CreateIReceiveTelecomChildQuestCondition(builder, _o.Type, preConditionsOffset, _o.TelecomId);
		}

		// Token: 0x0400BC2D RID: 48173
		private Table __p;
	}
}
