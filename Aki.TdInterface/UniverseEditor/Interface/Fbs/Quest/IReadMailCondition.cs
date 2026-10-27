using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200406D RID: 16493
	public struct IReadMailCondition : IFlatbufferObject
	{
		// Token: 0x1700745B RID: 29787
		// (get) Token: 0x06017F7F RID: 98175 RVA: 0x0037591B File Offset: 0x00373B1B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017F80 RID: 98176 RVA: 0x00375928 File Offset: 0x00373B28
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017F81 RID: 98177 RVA: 0x00375930 File Offset: 0x00373B30
		public static IReadMailCondition GetRootAsIReadMailCondition(ByteBuffer _bb)
		{
			return IReadMailCondition.GetRootAsIReadMailCondition(_bb, default(IReadMailCondition));
		}

		// Token: 0x06017F82 RID: 98178 RVA: 0x0037594C File Offset: 0x00373B4C
		public static IReadMailCondition GetRootAsIReadMailCondition(ByteBuffer _bb, IReadMailCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017F83 RID: 98179 RVA: 0x00375969 File Offset: 0x00373B69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017F84 RID: 98180 RVA: 0x00375978 File Offset: 0x00373B78
		public IReadMailCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700745C RID: 29788
		// (get) Token: 0x06017F85 RID: 98181 RVA: 0x00375988 File Offset: 0x00373B88
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

		// Token: 0x1700745D RID: 29789
		// (get) Token: 0x06017F86 RID: 98182 RVA: 0x003759C4 File Offset: 0x00373BC4
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

		// Token: 0x1700745E RID: 29790
		// (get) Token: 0x06017F87 RID: 98183 RVA: 0x00375A24 File Offset: 0x00373C24
		public int MailId
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

		// Token: 0x06017F88 RID: 98184 RVA: 0x00375A60 File Offset: 0x00373C60
		public static Offset<IReadMailCondition> CreateIReadMailCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), int MailId = 0)
		{
			builder.StartTable(3);
			IReadMailCondition.AddMailId(builder, MailId);
			IReadMailCondition.AddPreConditions(builder, PreConditionsOffset);
			IReadMailCondition.AddType(builder, Type);
			return IReadMailCondition.EndIReadMailCondition(builder);
		}

		// Token: 0x06017F89 RID: 98185 RVA: 0x00375A84 File Offset: 0x00373C84
		public static void StartIReadMailCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06017F8A RID: 98186 RVA: 0x00375A8D File Offset: 0x00373C8D
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017F8B RID: 98187 RVA: 0x00375A98 File Offset: 0x00373C98
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06017F8C RID: 98188 RVA: 0x00375AA8 File Offset: 0x00373CA8
		public static void AddMailId(FlatBufferBuilder builder, int mailId)
		{
			builder.AddInt(2, mailId, 0);
		}

		// Token: 0x06017F8D RID: 98189 RVA: 0x00375AB3 File Offset: 0x00373CB3
		public static Offset<IReadMailCondition> EndIReadMailCondition(FlatBufferBuilder builder)
		{
			return new Offset<IReadMailCondition>(builder.EndTable());
		}

		// Token: 0x06017F8E RID: 98190 RVA: 0x00375AC0 File Offset: 0x00373CC0
		public IReadMailConditionT UnPack()
		{
			IReadMailConditionT readMailConditionT = new IReadMailConditionT();
			this.UnPackTo(readMailConditionT);
			return readMailConditionT;
		}

		// Token: 0x06017F8F RID: 98191 RVA: 0x00375ADC File Offset: 0x00373CDC
		public void UnPackTo(IReadMailConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.MailId = this.MailId;
		}

		// Token: 0x06017F90 RID: 98192 RVA: 0x00375B30 File Offset: 0x00373D30
		public static Offset<IReadMailCondition> Pack(FlatBufferBuilder builder, IReadMailConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IReadMailCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			return IReadMailCondition.CreateIReadMailCondition(builder, _o.Type, preConditionsOffset, _o.MailId);
		}

		// Token: 0x0400BBE5 RID: 48101
		private Table __p;
	}
}
