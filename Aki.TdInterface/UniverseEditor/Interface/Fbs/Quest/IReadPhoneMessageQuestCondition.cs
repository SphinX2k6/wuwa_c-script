using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004070 RID: 16496
	public struct IReadPhoneMessageQuestCondition : IFlatbufferObject
	{
		// Token: 0x17007462 RID: 29794
		// (get) Token: 0x06017F99 RID: 98201 RVA: 0x00375C33 File Offset: 0x00373E33
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017F9A RID: 98202 RVA: 0x00375C40 File Offset: 0x00373E40
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017F9B RID: 98203 RVA: 0x00375C48 File Offset: 0x00373E48
		public static IReadPhoneMessageQuestCondition GetRootAsIReadPhoneMessageQuestCondition(ByteBuffer _bb)
		{
			return IReadPhoneMessageQuestCondition.GetRootAsIReadPhoneMessageQuestCondition(_bb, default(IReadPhoneMessageQuestCondition));
		}

		// Token: 0x06017F9C RID: 98204 RVA: 0x00375C64 File Offset: 0x00373E64
		public static IReadPhoneMessageQuestCondition GetRootAsIReadPhoneMessageQuestCondition(ByteBuffer _bb, IReadPhoneMessageQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017F9D RID: 98205 RVA: 0x00375C81 File Offset: 0x00373E81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017F9E RID: 98206 RVA: 0x00375C90 File Offset: 0x00373E90
		public IReadPhoneMessageQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007463 RID: 29795
		// (get) Token: 0x06017F9F RID: 98207 RVA: 0x00375CA0 File Offset: 0x00373EA0
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

		// Token: 0x17007464 RID: 29796
		// (get) Token: 0x06017FA0 RID: 98208 RVA: 0x00375CDC File Offset: 0x00373EDC
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

		// Token: 0x17007465 RID: 29797
		// (get) Token: 0x06017FA1 RID: 98209 RVA: 0x00375D3C File Offset: 0x00373F3C
		public int PhoneMessageId
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

		// Token: 0x17007466 RID: 29798
		// (get) Token: 0x06017FA2 RID: 98210 RVA: 0x00375D78 File Offset: 0x00373F78
		public ICompleteMessageQuestCondition? ProgressType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new ICompleteMessageQuestCondition?(default(ICompleteMessageQuestCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007467 RID: 29799
		// (get) Token: 0x06017FA3 RID: 98211 RVA: 0x00375DD8 File Offset: 0x00373FD8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017FA4 RID: 98212 RVA: 0x00375E15 File Offset: 0x00374015
		public static Offset<IReadPhoneMessageQuestCondition> CreateIReadPhoneMessageQuestCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), int PhoneMessageId = 0, Offset<ICompleteMessageQuestCondition> ProgressTypeOffset = default(Offset<ICompleteMessageQuestCondition>), byte NullMask = 0)
		{
			builder.StartTable(5);
			IReadPhoneMessageQuestCondition.AddProgressType(builder, ProgressTypeOffset);
			IReadPhoneMessageQuestCondition.AddPhoneMessageId(builder, PhoneMessageId);
			IReadPhoneMessageQuestCondition.AddPreConditions(builder, PreConditionsOffset);
			IReadPhoneMessageQuestCondition.AddNullMask(builder, NullMask);
			IReadPhoneMessageQuestCondition.AddType(builder, Type);
			return IReadPhoneMessageQuestCondition.EndIReadPhoneMessageQuestCondition(builder);
		}

		// Token: 0x06017FA5 RID: 98213 RVA: 0x00375E49 File Offset: 0x00374049
		public static void StartIReadPhoneMessageQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06017FA6 RID: 98214 RVA: 0x00375E52 File Offset: 0x00374052
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017FA7 RID: 98215 RVA: 0x00375E5D File Offset: 0x0037405D
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06017FA8 RID: 98216 RVA: 0x00375E6D File Offset: 0x0037406D
		public static void AddPhoneMessageId(FlatBufferBuilder builder, int phoneMessageId)
		{
			builder.AddInt(2, phoneMessageId, 0);
		}

		// Token: 0x06017FA9 RID: 98217 RVA: 0x00375E78 File Offset: 0x00374078
		public static void AddProgressType(FlatBufferBuilder builder, Offset<ICompleteMessageQuestCondition> progressTypeOffset)
		{
			builder.AddOffset(3, progressTypeOffset.Value, 0);
		}

		// Token: 0x06017FAA RID: 98218 RVA: 0x00375E88 File Offset: 0x00374088
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06017FAB RID: 98219 RVA: 0x00375E93 File Offset: 0x00374093
		public static Offset<IReadPhoneMessageQuestCondition> EndIReadPhoneMessageQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<IReadPhoneMessageQuestCondition>(builder.EndTable());
		}

		// Token: 0x06017FAC RID: 98220 RVA: 0x00375EA0 File Offset: 0x003740A0
		public IReadPhoneMessageQuestConditionT UnPack()
		{
			IReadPhoneMessageQuestConditionT readPhoneMessageQuestConditionT = new IReadPhoneMessageQuestConditionT();
			this.UnPackTo(readPhoneMessageQuestConditionT);
			return readPhoneMessageQuestConditionT;
		}

		// Token: 0x06017FAD RID: 98221 RVA: 0x00375EBC File Offset: 0x003740BC
		public void UnPackTo(IReadPhoneMessageQuestConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.PhoneMessageId = this.PhoneMessageId;
			_o.ProgressType = ((this.ProgressType != null) ? this.ProgressType.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06017FAE RID: 98222 RVA: 0x00375F4C File Offset: 0x0037414C
		public static Offset<IReadPhoneMessageQuestCondition> Pack(FlatBufferBuilder builder, IReadPhoneMessageQuestConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IReadPhoneMessageQuestCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			Offset<ICompleteMessageQuestCondition> progressTypeOffset = (_o.ProgressType == null) ? default(Offset<ICompleteMessageQuestCondition>) : ICompleteMessageQuestCondition.Pack(builder, _o.ProgressType);
			return IReadPhoneMessageQuestCondition.CreateIReadPhoneMessageQuestCondition(builder, _o.Type, preConditionsOffset, _o.PhoneMessageId, progressTypeOffset, _o.NullMask);
		}

		// Token: 0x0400BBE9 RID: 48105
		private Table __p;
	}
}
