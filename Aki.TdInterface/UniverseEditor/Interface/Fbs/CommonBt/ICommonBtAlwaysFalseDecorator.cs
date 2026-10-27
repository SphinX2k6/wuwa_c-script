using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005EA2 RID: 24226
	public struct ICommonBtAlwaysFalseDecorator : IFlatbufferObject
	{
		// Token: 0x1700B509 RID: 46345
		// (get) Token: 0x06029806 RID: 169990 RVA: 0x005AFC38 File Offset: 0x005ADE38
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029807 RID: 169991 RVA: 0x005AFC45 File Offset: 0x005ADE45
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029808 RID: 169992 RVA: 0x005AFC4C File Offset: 0x005ADE4C
		public static ICommonBtAlwaysFalseDecorator GetRootAsICommonBtAlwaysFalseDecorator(ByteBuffer _bb)
		{
			return ICommonBtAlwaysFalseDecorator.GetRootAsICommonBtAlwaysFalseDecorator(_bb, default(ICommonBtAlwaysFalseDecorator));
		}

		// Token: 0x06029809 RID: 169993 RVA: 0x005AFC68 File Offset: 0x005ADE68
		public static ICommonBtAlwaysFalseDecorator GetRootAsICommonBtAlwaysFalseDecorator(ByteBuffer _bb, ICommonBtAlwaysFalseDecorator obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602980A RID: 169994 RVA: 0x005AFC85 File Offset: 0x005ADE85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602980B RID: 169995 RVA: 0x005AFC94 File Offset: 0x005ADE94
		public ICommonBtAlwaysFalseDecorator __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B50A RID: 46346
		// (get) Token: 0x0602980C RID: 169996 RVA: 0x005AFCA4 File Offset: 0x005ADEA4
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

		// Token: 0x0602980D RID: 169997 RVA: 0x005AFCE0 File Offset: 0x005ADEE0
		public static Offset<ICommonBtAlwaysFalseDecorator> CreateICommonBtAlwaysFalseDecorator(FlatBufferBuilder builder, ECommonBtDecoratorType Type = ECommonBtDecoratorType.Condition)
		{
			builder.StartTable(1);
			ICommonBtAlwaysFalseDecorator.AddType(builder, Type);
			return ICommonBtAlwaysFalseDecorator.EndICommonBtAlwaysFalseDecorator(builder);
		}

		// Token: 0x0602980E RID: 169998 RVA: 0x005AFCF6 File Offset: 0x005ADEF6
		public static void StartICommonBtAlwaysFalseDecorator(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602980F RID: 169999 RVA: 0x005AFCFF File Offset: 0x005ADEFF
		public static void AddType(FlatBufferBuilder builder, ECommonBtDecoratorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029810 RID: 170000 RVA: 0x005AFD0A File Offset: 0x005ADF0A
		public static Offset<ICommonBtAlwaysFalseDecorator> EndICommonBtAlwaysFalseDecorator(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtAlwaysFalseDecorator>(builder.EndTable());
		}

		// Token: 0x06029811 RID: 170001 RVA: 0x005AFD18 File Offset: 0x005ADF18
		public ICommonBtAlwaysFalseDecoratorT UnPack()
		{
			ICommonBtAlwaysFalseDecoratorT commonBtAlwaysFalseDecoratorT = new ICommonBtAlwaysFalseDecoratorT();
			this.UnPackTo(commonBtAlwaysFalseDecoratorT);
			return commonBtAlwaysFalseDecoratorT;
		}

		// Token: 0x06029812 RID: 170002 RVA: 0x005AFD33 File Offset: 0x005ADF33
		public void UnPackTo(ICommonBtAlwaysFalseDecoratorT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06029813 RID: 170003 RVA: 0x005AFD44 File Offset: 0x005ADF44
		public static Offset<ICommonBtAlwaysFalseDecorator> Pack(FlatBufferBuilder builder, ICommonBtAlwaysFalseDecoratorT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonBtAlwaysFalseDecorator>);
			}
			return ICommonBtAlwaysFalseDecorator.CreateICommonBtAlwaysFalseDecorator(builder, _o.Type);
		}

		// Token: 0x0400F912 RID: 63762
		private Table __p;
	}
}
