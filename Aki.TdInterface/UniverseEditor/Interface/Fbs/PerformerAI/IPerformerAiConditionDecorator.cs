using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x0200435D RID: 17245
	public struct IPerformerAiConditionDecorator : IFlatbufferObject
	{
		// Token: 0x170079B2 RID: 31154
		// (get) Token: 0x06019924 RID: 104740 RVA: 0x003A91B9 File Offset: 0x003A73B9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019925 RID: 104741 RVA: 0x003A91C6 File Offset: 0x003A73C6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019926 RID: 104742 RVA: 0x003A91D0 File Offset: 0x003A73D0
		public static IPerformerAiConditionDecorator GetRootAsIPerformerAiConditionDecorator(ByteBuffer _bb)
		{
			return IPerformerAiConditionDecorator.GetRootAsIPerformerAiConditionDecorator(_bb, default(IPerformerAiConditionDecorator));
		}

		// Token: 0x06019927 RID: 104743 RVA: 0x003A91EC File Offset: 0x003A73EC
		public static IPerformerAiConditionDecorator GetRootAsIPerformerAiConditionDecorator(ByteBuffer _bb, IPerformerAiConditionDecorator obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019928 RID: 104744 RVA: 0x003A9209 File Offset: 0x003A7409
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019929 RID: 104745 RVA: 0x003A9218 File Offset: 0x003A7418
		public IPerformerAiConditionDecorator __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170079B3 RID: 31155
		// (get) Token: 0x0601992A RID: 104746 RVA: 0x003A9228 File Offset: 0x003A7428
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

		// Token: 0x170079B4 RID: 31156
		// (get) Token: 0x0601992B RID: 104747 RVA: 0x003A9264 File Offset: 0x003A7464
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

		// Token: 0x170079B5 RID: 31157
		// (get) Token: 0x0601992C RID: 104748 RVA: 0x003A92C4 File Offset: 0x003A74C4
		public bool Reverse
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170079B6 RID: 31158
		// (get) Token: 0x0601992D RID: 104749 RVA: 0x003A9304 File Offset: 0x003A7504
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

		// Token: 0x170079B7 RID: 31159
		// (get) Token: 0x0601992E RID: 104750 RVA: 0x003A9344 File Offset: 0x003A7544
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

		// Token: 0x0601992F RID: 104751 RVA: 0x003A9381 File Offset: 0x003A7581
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

		// Token: 0x06019930 RID: 104752 RVA: 0x003A93B5 File Offset: 0x003A75B5
		public static void StartIPerformerAiConditionDecorator(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06019931 RID: 104753 RVA: 0x003A93BE File Offset: 0x003A75BE
		public static void AddType(FlatBufferBuilder builder, EPerformerAiDecoratorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019932 RID: 104754 RVA: 0x003A93C9 File Offset: 0x003A75C9
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(1, conditionOffset.Value, 0);
		}

		// Token: 0x06019933 RID: 104755 RVA: 0x003A93D9 File Offset: 0x003A75D9
		public static void AddReverse(FlatBufferBuilder builder, bool reverse)
		{
			builder.AddBool(2, reverse, false);
		}

		// Token: 0x06019934 RID: 104756 RVA: 0x003A93E4 File Offset: 0x003A75E4
		public static void AddAbortType(FlatBufferBuilder builder, EPerformerAiAbortType abortType)
		{
			builder.AddByte(3, (byte)abortType, 0);
		}

		// Token: 0x06019935 RID: 104757 RVA: 0x003A93EF File Offset: 0x003A75EF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06019936 RID: 104758 RVA: 0x003A93FA File Offset: 0x003A75FA
		public static Offset<IPerformerAiConditionDecorator> EndIPerformerAiConditionDecorator(FlatBufferBuilder builder)
		{
			return new Offset<IPerformerAiConditionDecorator>(builder.EndTable());
		}

		// Token: 0x06019937 RID: 104759 RVA: 0x003A9408 File Offset: 0x003A7608
		public IPerformerAiConditionDecoratorT UnPack()
		{
			IPerformerAiConditionDecoratorT performerAiConditionDecoratorT = new IPerformerAiConditionDecoratorT();
			this.UnPackTo(performerAiConditionDecoratorT);
			return performerAiConditionDecoratorT;
		}

		// Token: 0x06019938 RID: 104760 RVA: 0x003A9424 File Offset: 0x003A7624
		public void UnPackTo(IPerformerAiConditionDecoratorT _o)
		{
			_o.Type = this.Type;
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.Reverse = this.Reverse;
			_o.AbortType = this.AbortType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06019939 RID: 104761 RVA: 0x003A9490 File Offset: 0x003A7690
		public static Offset<IPerformerAiConditionDecorator> Pack(FlatBufferBuilder builder, IPerformerAiConditionDecoratorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerformerAiConditionDecorator>);
			}
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			return IPerformerAiConditionDecorator.CreateIPerformerAiConditionDecorator(builder, _o.Type, conditionOffset, _o.Reverse, _o.AbortType, _o.NullMask);
		}

		// Token: 0x0400C14D RID: 49485
		private Table __p;
	}
}
