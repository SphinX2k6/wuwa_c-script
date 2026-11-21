using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x020064EB RID: 25835
	public struct ICommonBtConditionDecorator : IFlatbufferObject
	{
		// Token: 0x1700BE7A RID: 48762
		// (get) Token: 0x0602BED2 RID: 179922 RVA: 0x005F8EC9 File Offset: 0x005F70C9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BED3 RID: 179923 RVA: 0x005F8ED6 File Offset: 0x005F70D6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BED4 RID: 179924 RVA: 0x005F8EE0 File Offset: 0x005F70E0
		public static ICommonBtConditionDecorator GetRootAsICommonBtConditionDecorator(ByteBuffer _bb)
		{
			return ICommonBtConditionDecorator.GetRootAsICommonBtConditionDecorator(_bb, default(ICommonBtConditionDecorator));
		}

		// Token: 0x0602BED5 RID: 179925 RVA: 0x005F8EFC File Offset: 0x005F70FC
		public static ICommonBtConditionDecorator GetRootAsICommonBtConditionDecorator(ByteBuffer _bb, ICommonBtConditionDecorator obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BED6 RID: 179926 RVA: 0x005F8F19 File Offset: 0x005F7119
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BED7 RID: 179927 RVA: 0x005F8F28 File Offset: 0x005F7128
		public ICommonBtConditionDecorator __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BE7B RID: 48763
		// (get) Token: 0x0602BED8 RID: 179928 RVA: 0x005F8F38 File Offset: 0x005F7138
		public ECommonBtDecoratorType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonBtDecoratorType.Condition;
				}
				return (ECommonBtDecoratorType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BE7C RID: 48764
		// (get) Token: 0x0602BED9 RID: 179929 RVA: 0x005F8F74 File Offset: 0x005F7174
		public ICommonBtConditionGroup? Condition
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ICommonBtConditionGroup?(default(ICommonBtConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700BE7D RID: 48765
		// (get) Token: 0x0602BEDA RID: 179930 RVA: 0x005F8FD4 File Offset: 0x005F71D4
		public bool Reverse
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BE7E RID: 48766
		// (get) Token: 0x0602BEDB RID: 179931 RVA: 0x005F9014 File Offset: 0x005F7214
		public ECommonBtAbortType AbortType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return ECommonBtAbortType.None;
				}
				return (ECommonBtAbortType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BE7F RID: 48767
		// (get) Token: 0x0602BEDC RID: 179932 RVA: 0x005F9054 File Offset: 0x005F7254
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

		// Token: 0x0602BEDD RID: 179933 RVA: 0x005F9091 File Offset: 0x005F7291
		public static Offset<ICommonBtConditionDecorator> CreateICommonBtConditionDecorator(FlatBufferBuilder builder, ECommonBtDecoratorType Type = ECommonBtDecoratorType.Condition, Offset<ICommonBtConditionGroup> ConditionOffset = default(Offset<ICommonBtConditionGroup>), bool Reverse = false, ECommonBtAbortType AbortType = ECommonBtAbortType.None, byte NullMask = 0)
		{
			builder.StartTable(5);
			ICommonBtConditionDecorator.AddCondition(builder, ConditionOffset);
			ICommonBtConditionDecorator.AddNullMask(builder, NullMask);
			ICommonBtConditionDecorator.AddAbortType(builder, AbortType);
			ICommonBtConditionDecorator.AddReverse(builder, Reverse);
			ICommonBtConditionDecorator.AddType(builder, Type);
			return ICommonBtConditionDecorator.EndICommonBtConditionDecorator(builder);
		}

		// Token: 0x0602BEDE RID: 179934 RVA: 0x005F90C5 File Offset: 0x005F72C5
		public static void StartICommonBtConditionDecorator(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602BEDF RID: 179935 RVA: 0x005F90CE File Offset: 0x005F72CE
		public static void AddType(FlatBufferBuilder builder, ECommonBtDecoratorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BEE0 RID: 179936 RVA: 0x005F90D9 File Offset: 0x005F72D9
		public static void AddCondition(FlatBufferBuilder builder, Offset<ICommonBtConditionGroup> conditionOffset)
		{
			builder.AddOffset(1, conditionOffset.Value, 0);
		}

		// Token: 0x0602BEE1 RID: 179937 RVA: 0x005F90E9 File Offset: 0x005F72E9
		public static void AddReverse(FlatBufferBuilder builder, bool reverse)
		{
			builder.AddBool(2, reverse, false);
		}

		// Token: 0x0602BEE2 RID: 179938 RVA: 0x005F90F4 File Offset: 0x005F72F4
		public static void AddAbortType(FlatBufferBuilder builder, ECommonBtAbortType abortType)
		{
			builder.AddByte(3, (byte)abortType, 0);
		}

		// Token: 0x0602BEE3 RID: 179939 RVA: 0x005F90FF File Offset: 0x005F72FF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602BEE4 RID: 179940 RVA: 0x005F910A File Offset: 0x005F730A
		public static Offset<ICommonBtConditionDecorator> EndICommonBtConditionDecorator(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtConditionDecorator>(builder.EndTable());
		}

		// Token: 0x0602BEE5 RID: 179941 RVA: 0x005F9118 File Offset: 0x005F7318
		public ICommonBtConditionDecoratorT UnPack()
		{
			ICommonBtConditionDecoratorT commonBtConditionDecoratorT = new ICommonBtConditionDecoratorT();
			this.UnPackTo(commonBtConditionDecoratorT);
			return commonBtConditionDecoratorT;
		}

		// Token: 0x0602BEE6 RID: 179942 RVA: 0x005F9134 File Offset: 0x005F7334
		public void UnPackTo(ICommonBtConditionDecoratorT _o)
		{
			_o.Type = this.Type;
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.Reverse = this.Reverse;
			_o.AbortType = this.AbortType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602BEE7 RID: 179943 RVA: 0x005F91A0 File Offset: 0x005F73A0
		public static Offset<ICommonBtConditionDecorator> Pack(FlatBufferBuilder builder, ICommonBtConditionDecoratorT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonBtConditionDecorator>);
			}
			Offset<ICommonBtConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<ICommonBtConditionGroup>) : ICommonBtConditionGroup.Pack(builder, _o.Condition);
			return ICommonBtConditionDecorator.CreateICommonBtConditionDecorator(builder, _o.Type, conditionOffset, _o.Reverse, _o.AbortType, _o.NullMask);
		}

		// Token: 0x04010679 RID: 67193
		private Table __p;
	}
}
