using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044B1 RID: 17585
	public struct IReadPhoneMessageQuestCondition : IFlatbufferObject
	{
		// Token: 0x17007A64 RID: 31332
		// (get) Token: 0x06019632 RID: 103986 RVA: 0x0039FA6B File Offset: 0x0039DC6B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019633 RID: 103987 RVA: 0x0039FA78 File Offset: 0x0039DC78
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019634 RID: 103988 RVA: 0x0039FA80 File Offset: 0x0039DC80
		public static IReadPhoneMessageQuestCondition GetRootAsIReadPhoneMessageQuestCondition(ByteBuffer _bb)
		{
			return IReadPhoneMessageQuestCondition.GetRootAsIReadPhoneMessageQuestCondition(_bb, default(IReadPhoneMessageQuestCondition));
		}

		// Token: 0x06019635 RID: 103989 RVA: 0x0039FA9C File Offset: 0x0039DC9C
		public static IReadPhoneMessageQuestCondition GetRootAsIReadPhoneMessageQuestCondition(ByteBuffer _bb, IReadPhoneMessageQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019636 RID: 103990 RVA: 0x0039FAB9 File Offset: 0x0039DCB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019637 RID: 103991 RVA: 0x0039FAC8 File Offset: 0x0039DCC8
		public IReadPhoneMessageQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007A65 RID: 31333
		// (get) Token: 0x06019638 RID: 103992 RVA: 0x0039FAD8 File Offset: 0x0039DCD8
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

		// Token: 0x17007A66 RID: 31334
		// (get) Token: 0x06019639 RID: 103993 RVA: 0x0039FB14 File Offset: 0x0039DD14
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

		// Token: 0x17007A67 RID: 31335
		// (get) Token: 0x0601963A RID: 103994 RVA: 0x0039FB74 File Offset: 0x0039DD74
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

		// Token: 0x17007A68 RID: 31336
		// (get) Token: 0x0601963B RID: 103995 RVA: 0x0039FBB0 File Offset: 0x0039DDB0
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

		// Token: 0x17007A69 RID: 31337
		// (get) Token: 0x0601963C RID: 103996 RVA: 0x0039FC10 File Offset: 0x0039DE10
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

		// Token: 0x0601963D RID: 103997 RVA: 0x0039FC4D File Offset: 0x0039DE4D
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

		// Token: 0x0601963E RID: 103998 RVA: 0x0039FC81 File Offset: 0x0039DE81
		public static void StartIReadPhoneMessageQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601963F RID: 103999 RVA: 0x0039FC8A File Offset: 0x0039DE8A
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019640 RID: 104000 RVA: 0x0039FC95 File Offset: 0x0039DE95
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06019641 RID: 104001 RVA: 0x0039FCA5 File Offset: 0x0039DEA5
		public static void AddPhoneMessageId(FlatBufferBuilder builder, int phoneMessageId)
		{
			builder.AddInt(2, phoneMessageId, 0);
		}

		// Token: 0x06019642 RID: 104002 RVA: 0x0039FCB0 File Offset: 0x0039DEB0
		public static void AddProgressType(FlatBufferBuilder builder, Offset<ICompleteMessageQuestCondition> progressTypeOffset)
		{
			builder.AddOffset(3, progressTypeOffset.Value, 0);
		}

		// Token: 0x06019643 RID: 104003 RVA: 0x0039FCC0 File Offset: 0x0039DEC0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06019644 RID: 104004 RVA: 0x0039FCCB File Offset: 0x0039DECB
		public static Offset<IReadPhoneMessageQuestCondition> EndIReadPhoneMessageQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<IReadPhoneMessageQuestCondition>(builder.EndTable());
		}

		// Token: 0x06019645 RID: 104005 RVA: 0x0039FCD8 File Offset: 0x0039DED8
		public IReadPhoneMessageQuestConditionT UnPack()
		{
			IReadPhoneMessageQuestConditionT readPhoneMessageQuestConditionT = new IReadPhoneMessageQuestConditionT();
			this.UnPackTo(readPhoneMessageQuestConditionT);
			return readPhoneMessageQuestConditionT;
		}

		// Token: 0x06019646 RID: 104006 RVA: 0x0039FCF4 File Offset: 0x0039DEF4
		public void UnPackTo(IReadPhoneMessageQuestConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.PhoneMessageId = this.PhoneMessageId;
			_o.ProgressType = ((this.ProgressType != null) ? this.ProgressType.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06019647 RID: 104007 RVA: 0x0039FD84 File Offset: 0x0039DF84
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

		// Token: 0x0400C5D0 RID: 50640
		private Table __p;
	}
}
