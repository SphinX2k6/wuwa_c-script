using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x020047BF RID: 18367
	public struct IPerformerAiConditionDecorator : IFlatbufferObject
	{
		// Token: 0x17007FE7 RID: 32743
		// (get) Token: 0x0601B0B2 RID: 110770 RVA: 0x003D4BE1 File Offset: 0x003D2DE1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B0B3 RID: 110771 RVA: 0x003D4BEE File Offset: 0x003D2DEE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B0B4 RID: 110772 RVA: 0x003D4BF8 File Offset: 0x003D2DF8
		public static IPerformerAiConditionDecorator GetRootAsIPerformerAiConditionDecorator(ByteBuffer _bb)
		{
			return IPerformerAiConditionDecorator.GetRootAsIPerformerAiConditionDecorator(_bb, default(IPerformerAiConditionDecorator));
		}

		// Token: 0x0601B0B5 RID: 110773 RVA: 0x003D4C14 File Offset: 0x003D2E14
		public static IPerformerAiConditionDecorator GetRootAsIPerformerAiConditionDecorator(ByteBuffer _bb, IPerformerAiConditionDecorator obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B0B6 RID: 110774 RVA: 0x003D4C31 File Offset: 0x003D2E31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B0B7 RID: 110775 RVA: 0x003D4C40 File Offset: 0x003D2E40
		public IPerformerAiConditionDecorator __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007FE8 RID: 32744
		// (get) Token: 0x0601B0B8 RID: 110776 RVA: 0x003D4C50 File Offset: 0x003D2E50
		public EPerformerAiDecoratorType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPerformerAiDecoratorType.Condition;
				}
				return (EPerformerAiDecoratorType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007FE9 RID: 32745
		// (get) Token: 0x0601B0B9 RID: 110777 RVA: 0x003D4C8C File Offset: 0x003D2E8C
		public IConditionGroup? Condition
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

		// Token: 0x17007FEA RID: 32746
		// (get) Token: 0x0601B0BA RID: 110778 RVA: 0x003D4CEC File Offset: 0x003D2EEC
		public bool Reverse
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007FEB RID: 32747
		// (get) Token: 0x0601B0BB RID: 110779 RVA: 0x003D4D2C File Offset: 0x003D2F2C
		public EPerformerAiAbortType AbortType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return EPerformerAiAbortType.None;
				}
				return (EPerformerAiAbortType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007FEC RID: 32748
		// (get) Token: 0x0601B0BC RID: 110780 RVA: 0x003D4D6C File Offset: 0x003D2F6C
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

		// Token: 0x0601B0BD RID: 110781 RVA: 0x003D4DA9 File Offset: 0x003D2FA9
		public static Offset<IPerformerAiConditionDecorator> CreateIPerformerAiConditionDecorator(FlatBufferBuilder builder, EPerformerAiDecoratorType Type = EPerformerAiDecoratorType.Condition, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), bool Reverse = false, EPerformerAiAbortType AbortType = EPerformerAiAbortType.None, byte NullMask = 0)
		{
			builder.StartTable(5);
			IPerformerAiConditionDecorator.AddCondition(builder, ConditionOffset);
			IPerformerAiConditionDecorator.AddNullMask(builder, NullMask);
			IPerformerAiConditionDecorator.AddAbortType(builder, AbortType);
			IPerformerAiConditionDecorator.AddReverse(builder, Reverse);
			IPerformerAiConditionDecorator.AddType(builder, Type);
			return IPerformerAiConditionDecorator.EndIPerformerAiConditionDecorator(builder);
		}

		// Token: 0x0601B0BE RID: 110782 RVA: 0x003D4DDD File Offset: 0x003D2FDD
		public static void StartIPerformerAiConditionDecorator(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601B0BF RID: 110783 RVA: 0x003D4DE6 File Offset: 0x003D2FE6
		public static void AddType(FlatBufferBuilder builder, EPerformerAiDecoratorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B0C0 RID: 110784 RVA: 0x003D4DF1 File Offset: 0x003D2FF1
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(1, conditionOffset.Value, 0);
		}

		// Token: 0x0601B0C1 RID: 110785 RVA: 0x003D4E01 File Offset: 0x003D3001
		public static void AddReverse(FlatBufferBuilder builder, bool reverse)
		{
			builder.AddBool(2, reverse, false);
		}

		// Token: 0x0601B0C2 RID: 110786 RVA: 0x003D4E0C File Offset: 0x003D300C
		public static void AddAbortType(FlatBufferBuilder builder, EPerformerAiAbortType abortType)
		{
			builder.AddByte(3, (byte)abortType, 0);
		}

		// Token: 0x0601B0C3 RID: 110787 RVA: 0x003D4E17 File Offset: 0x003D3017
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601B0C4 RID: 110788 RVA: 0x003D4E22 File Offset: 0x003D3022
		public static Offset<IPerformerAiConditionDecorator> EndIPerformerAiConditionDecorator(FlatBufferBuilder builder)
		{
			return new Offset<IPerformerAiConditionDecorator>(builder.EndTable());
		}

		// Token: 0x0601B0C5 RID: 110789 RVA: 0x003D4E30 File Offset: 0x003D3030
		public IPerformerAiConditionDecoratorT UnPack()
		{
			IPerformerAiConditionDecoratorT performerAiConditionDecoratorT = new IPerformerAiConditionDecoratorT();
			this.UnPackTo(performerAiConditionDecoratorT);
			return performerAiConditionDecoratorT;
		}

		// Token: 0x0601B0C6 RID: 110790 RVA: 0x003D4E4C File Offset: 0x003D304C
		public void UnPackTo(IPerformerAiConditionDecoratorT _o)
		{
			_o.Type = this.Type;
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.Reverse = this.Reverse;
			_o.AbortType = this.AbortType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601B0C7 RID: 110791 RVA: 0x003D4EB8 File Offset: 0x003D30B8
		public static Offset<IPerformerAiConditionDecorator> Pack(FlatBufferBuilder builder, IPerformerAiConditionDecoratorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerformerAiConditionDecorator>);
			}
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			return IPerformerAiConditionDecorator.CreateIPerformerAiConditionDecorator(builder, _o.Type, conditionOffset, _o.Reverse, _o.AbortType, _o.NullMask);
		}

		// Token: 0x0400CB6B RID: 52075
		private Table __p;
	}
}
