using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044E1 RID: 17633
	public struct IReceiveTelecomChildQuestCondition : IFlatbufferObject
	{
		// Token: 0x17007ABB RID: 31419
		// (get) Token: 0x060197EC RID: 104428 RVA: 0x003A2BFA File Offset: 0x003A0DFA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060197ED RID: 104429 RVA: 0x003A2C07 File Offset: 0x003A0E07
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060197EE RID: 104430 RVA: 0x003A2C10 File Offset: 0x003A0E10
		public static IReceiveTelecomChildQuestCondition GetRootAsIReceiveTelecomChildQuestCondition(ByteBuffer _bb)
		{
			return IReceiveTelecomChildQuestCondition.GetRootAsIReceiveTelecomChildQuestCondition(_bb, default(IReceiveTelecomChildQuestCondition));
		}

		// Token: 0x060197EF RID: 104431 RVA: 0x003A2C2C File Offset: 0x003A0E2C
		public static IReceiveTelecomChildQuestCondition GetRootAsIReceiveTelecomChildQuestCondition(ByteBuffer _bb, IReceiveTelecomChildQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060197F0 RID: 104432 RVA: 0x003A2C49 File Offset: 0x003A0E49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060197F1 RID: 104433 RVA: 0x003A2C58 File Offset: 0x003A0E58
		public IReceiveTelecomChildQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007ABC RID: 31420
		// (get) Token: 0x060197F2 RID: 104434 RVA: 0x003A2C68 File Offset: 0x003A0E68
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

		// Token: 0x17007ABD RID: 31421
		// (get) Token: 0x060197F3 RID: 104435 RVA: 0x003A2CA4 File Offset: 0x003A0EA4
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

		// Token: 0x17007ABE RID: 31422
		// (get) Token: 0x060197F4 RID: 104436 RVA: 0x003A2D04 File Offset: 0x003A0F04
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

		// Token: 0x17007ABF RID: 31423
		// (get) Token: 0x060197F5 RID: 104437 RVA: 0x003A2D40 File Offset: 0x003A0F40
		public bool IsAutoAnswer
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007AC0 RID: 31424
		// (get) Token: 0x060197F6 RID: 104438 RVA: 0x003A2D80 File Offset: 0x003A0F80
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

		// Token: 0x060197F7 RID: 104439 RVA: 0x003A2DBD File Offset: 0x003A0FBD
		public static Offset<IReceiveTelecomChildQuestCondition> CreateIReceiveTelecomChildQuestCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), int TelecomId = 0, bool IsAutoAnswer = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			IReceiveTelecomChildQuestCondition.AddTelecomId(builder, TelecomId);
			IReceiveTelecomChildQuestCondition.AddPreConditions(builder, PreConditionsOffset);
			IReceiveTelecomChildQuestCondition.AddNullMask(builder, NullMask);
			IReceiveTelecomChildQuestCondition.AddIsAutoAnswer(builder, IsAutoAnswer);
			IReceiveTelecomChildQuestCondition.AddType(builder, Type);
			return IReceiveTelecomChildQuestCondition.EndIReceiveTelecomChildQuestCondition(builder);
		}

		// Token: 0x060197F8 RID: 104440 RVA: 0x003A2DF1 File Offset: 0x003A0FF1
		public static void StartIReceiveTelecomChildQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060197F9 RID: 104441 RVA: 0x003A2DFA File Offset: 0x003A0FFA
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060197FA RID: 104442 RVA: 0x003A2E05 File Offset: 0x003A1005
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x060197FB RID: 104443 RVA: 0x003A2E15 File Offset: 0x003A1015
		public static void AddTelecomId(FlatBufferBuilder builder, int telecomId)
		{
			builder.AddInt(2, telecomId, 0);
		}

		// Token: 0x060197FC RID: 104444 RVA: 0x003A2E20 File Offset: 0x003A1020
		public static void AddIsAutoAnswer(FlatBufferBuilder builder, bool isAutoAnswer)
		{
			builder.AddBool(3, isAutoAnswer, false);
		}

		// Token: 0x060197FD RID: 104445 RVA: 0x003A2E2B File Offset: 0x003A102B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060197FE RID: 104446 RVA: 0x003A2E36 File Offset: 0x003A1036
		public static Offset<IReceiveTelecomChildQuestCondition> EndIReceiveTelecomChildQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<IReceiveTelecomChildQuestCondition>(builder.EndTable());
		}

		// Token: 0x060197FF RID: 104447 RVA: 0x003A2E44 File Offset: 0x003A1044
		public IReceiveTelecomChildQuestConditionT UnPack()
		{
			IReceiveTelecomChildQuestConditionT receiveTelecomChildQuestConditionT = new IReceiveTelecomChildQuestConditionT();
			this.UnPackTo(receiveTelecomChildQuestConditionT);
			return receiveTelecomChildQuestConditionT;
		}

		// Token: 0x06019800 RID: 104448 RVA: 0x003A2E60 File Offset: 0x003A1060
		public void UnPackTo(IReceiveTelecomChildQuestConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.TelecomId = this.TelecomId;
			_o.IsAutoAnswer = this.IsAutoAnswer;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06019801 RID: 104449 RVA: 0x003A2ECC File Offset: 0x003A10CC
		public static Offset<IReceiveTelecomChildQuestCondition> Pack(FlatBufferBuilder builder, IReceiveTelecomChildQuestConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IReceiveTelecomChildQuestCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			return IReceiveTelecomChildQuestCondition.CreateIReceiveTelecomChildQuestCondition(builder, _o.Type, preConditionsOffset, _o.TelecomId, _o.IsAutoAnswer, _o.NullMask);
		}

		// Token: 0x0400C614 RID: 50708
		private Table __p;
	}
}
