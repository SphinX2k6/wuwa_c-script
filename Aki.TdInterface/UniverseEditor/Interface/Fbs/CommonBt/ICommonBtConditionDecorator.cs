using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005EA8 RID: 24232
	public struct ICommonBtConditionDecorator : IFlatbufferObject
	{
		// Token: 0x1700B50F RID: 46351
		// (get) Token: 0x0602982A RID: 170026 RVA: 0x005AFF25 File Offset: 0x005AE125
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602982B RID: 170027 RVA: 0x005AFF32 File Offset: 0x005AE132
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602982C RID: 170028 RVA: 0x005AFF3C File Offset: 0x005AE13C
		public static ICommonBtConditionDecorator GetRootAsICommonBtConditionDecorator(ByteBuffer _bb)
		{
			return ICommonBtConditionDecorator.GetRootAsICommonBtConditionDecorator(_bb, default(ICommonBtConditionDecorator));
		}

		// Token: 0x0602982D RID: 170029 RVA: 0x005AFF58 File Offset: 0x005AE158
		public static ICommonBtConditionDecorator GetRootAsICommonBtConditionDecorator(ByteBuffer _bb, ICommonBtConditionDecorator obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602982E RID: 170030 RVA: 0x005AFF75 File Offset: 0x005AE175
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602982F RID: 170031 RVA: 0x005AFF84 File Offset: 0x005AE184
		public ICommonBtConditionDecorator __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B510 RID: 46352
		// (get) Token: 0x06029830 RID: 170032 RVA: 0x005AFF94 File Offset: 0x005AE194
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

		// Token: 0x1700B511 RID: 46353
		// (get) Token: 0x06029831 RID: 170033 RVA: 0x005AFFD0 File Offset: 0x005AE1D0
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

		// Token: 0x1700B512 RID: 46354
		// (get) Token: 0x06029832 RID: 170034 RVA: 0x005B0030 File Offset: 0x005AE230
		public bool Reverse
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B513 RID: 46355
		// (get) Token: 0x06029833 RID: 170035 RVA: 0x005B0070 File Offset: 0x005AE270
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

		// Token: 0x1700B514 RID: 46356
		// (get) Token: 0x06029834 RID: 170036 RVA: 0x005B00B0 File Offset: 0x005AE2B0
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

		// Token: 0x06029835 RID: 170037 RVA: 0x005B00ED File Offset: 0x005AE2ED
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

		// Token: 0x06029836 RID: 170038 RVA: 0x005B0121 File Offset: 0x005AE321
		public static void StartICommonBtConditionDecorator(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06029837 RID: 170039 RVA: 0x005B012A File Offset: 0x005AE32A
		public static void AddType(FlatBufferBuilder builder, ECommonBtDecoratorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029838 RID: 170040 RVA: 0x005B0135 File Offset: 0x005AE335
		public static void AddCondition(FlatBufferBuilder builder, Offset<ICommonBtConditionGroup> conditionOffset)
		{
			builder.AddOffset(1, conditionOffset.Value, 0);
		}

		// Token: 0x06029839 RID: 170041 RVA: 0x005B0145 File Offset: 0x005AE345
		public static void AddReverse(FlatBufferBuilder builder, bool reverse)
		{
			builder.AddBool(2, reverse, false);
		}

		// Token: 0x0602983A RID: 170042 RVA: 0x005B0150 File Offset: 0x005AE350
		public static void AddAbortType(FlatBufferBuilder builder, ECommonBtAbortType abortType)
		{
			builder.AddByte(3, (byte)abortType, 0);
		}

		// Token: 0x0602983B RID: 170043 RVA: 0x005B015B File Offset: 0x005AE35B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602983C RID: 170044 RVA: 0x005B0166 File Offset: 0x005AE366
		public static Offset<ICommonBtConditionDecorator> EndICommonBtConditionDecorator(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtConditionDecorator>(builder.EndTable());
		}

		// Token: 0x0602983D RID: 170045 RVA: 0x005B0174 File Offset: 0x005AE374
		public ICommonBtConditionDecoratorT UnPack()
		{
			ICommonBtConditionDecoratorT commonBtConditionDecoratorT = new ICommonBtConditionDecoratorT();
			this.UnPackTo(commonBtConditionDecoratorT);
			return commonBtConditionDecoratorT;
		}

		// Token: 0x0602983E RID: 170046 RVA: 0x005B0190 File Offset: 0x005AE390
		public void UnPackTo(ICommonBtConditionDecoratorT _o)
		{
			_o.Type = this.Type;
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.Reverse = this.Reverse;
			_o.AbortType = this.AbortType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602983F RID: 170047 RVA: 0x005B01FC File Offset: 0x005AE3FC
		public static Offset<ICommonBtConditionDecorator> Pack(FlatBufferBuilder builder, ICommonBtConditionDecoratorT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonBtConditionDecorator>);
			}
			Offset<ICommonBtConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<ICommonBtConditionGroup>) : ICommonBtConditionGroup.Pack(builder, _o.Condition);
			return ICommonBtConditionDecorator.CreateICommonBtConditionDecorator(builder, _o.Type, conditionOffset, _o.Reverse, _o.AbortType, _o.NullMask);
		}

		// Token: 0x0400F916 RID: 63766
		private Table __p;
	}
}
