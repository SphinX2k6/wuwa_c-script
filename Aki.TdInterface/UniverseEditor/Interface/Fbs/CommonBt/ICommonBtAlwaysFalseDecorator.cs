using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x020064E5 RID: 25829
	public struct ICommonBtAlwaysFalseDecorator : IFlatbufferObject
	{
		// Token: 0x1700BE74 RID: 48756
		// (get) Token: 0x0602BEAE RID: 179886 RVA: 0x005F8BDC File Offset: 0x005F6DDC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BEAF RID: 179887 RVA: 0x005F8BE9 File Offset: 0x005F6DE9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BEB0 RID: 179888 RVA: 0x005F8BF0 File Offset: 0x005F6DF0
		public static ICommonBtAlwaysFalseDecorator GetRootAsICommonBtAlwaysFalseDecorator(ByteBuffer _bb)
		{
			return ICommonBtAlwaysFalseDecorator.GetRootAsICommonBtAlwaysFalseDecorator(_bb, default(ICommonBtAlwaysFalseDecorator));
		}

		// Token: 0x0602BEB1 RID: 179889 RVA: 0x005F8C0C File Offset: 0x005F6E0C
		public static ICommonBtAlwaysFalseDecorator GetRootAsICommonBtAlwaysFalseDecorator(ByteBuffer _bb, ICommonBtAlwaysFalseDecorator obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BEB2 RID: 179890 RVA: 0x005F8C29 File Offset: 0x005F6E29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BEB3 RID: 179891 RVA: 0x005F8C38 File Offset: 0x005F6E38
		public ICommonBtAlwaysFalseDecorator __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BE75 RID: 48757
		// (get) Token: 0x0602BEB4 RID: 179892 RVA: 0x005F8C48 File Offset: 0x005F6E48
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

		// Token: 0x0602BEB5 RID: 179893 RVA: 0x005F8C84 File Offset: 0x005F6E84
		public static Offset<ICommonBtAlwaysFalseDecorator> CreateICommonBtAlwaysFalseDecorator(FlatBufferBuilder builder, ECommonBtDecoratorType Type = ECommonBtDecoratorType.Condition)
		{
			builder.StartTable(1);
			ICommonBtAlwaysFalseDecorator.AddType(builder, Type);
			return ICommonBtAlwaysFalseDecorator.EndICommonBtAlwaysFalseDecorator(builder);
		}

		// Token: 0x0602BEB6 RID: 179894 RVA: 0x005F8C9A File Offset: 0x005F6E9A
		public static void StartICommonBtAlwaysFalseDecorator(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602BEB7 RID: 179895 RVA: 0x005F8CA3 File Offset: 0x005F6EA3
		public static void AddType(FlatBufferBuilder builder, ECommonBtDecoratorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BEB8 RID: 179896 RVA: 0x005F8CAE File Offset: 0x005F6EAE
		public static Offset<ICommonBtAlwaysFalseDecorator> EndICommonBtAlwaysFalseDecorator(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtAlwaysFalseDecorator>(builder.EndTable());
		}

		// Token: 0x0602BEB9 RID: 179897 RVA: 0x005F8CBC File Offset: 0x005F6EBC
		public ICommonBtAlwaysFalseDecoratorT UnPack()
		{
			ICommonBtAlwaysFalseDecoratorT commonBtAlwaysFalseDecoratorT = new ICommonBtAlwaysFalseDecoratorT();
			this.UnPackTo(commonBtAlwaysFalseDecoratorT);
			return commonBtAlwaysFalseDecoratorT;
		}

		// Token: 0x0602BEBA RID: 179898 RVA: 0x005F8CD7 File Offset: 0x005F6ED7
		public void UnPackTo(ICommonBtAlwaysFalseDecoratorT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602BEBB RID: 179899 RVA: 0x005F8CE8 File Offset: 0x005F6EE8
		public static Offset<ICommonBtAlwaysFalseDecorator> Pack(FlatBufferBuilder builder, ICommonBtAlwaysFalseDecoratorT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonBtAlwaysFalseDecorator>);
			}
			return ICommonBtAlwaysFalseDecorator.CreateICommonBtAlwaysFalseDecorator(builder, _o.Type);
		}

		// Token: 0x04010675 RID: 67189
		private Table __p;
	}
}
