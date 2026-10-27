using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005EA5 RID: 24229
	public struct ICommonBtAlwaysTrueDecorator : IFlatbufferObject
	{
		// Token: 0x1700B50C RID: 46348
		// (get) Token: 0x06029818 RID: 170008 RVA: 0x005AFDAD File Offset: 0x005ADFAD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029819 RID: 170009 RVA: 0x005AFDBA File Offset: 0x005ADFBA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602981A RID: 170010 RVA: 0x005AFDC4 File Offset: 0x005ADFC4
		public static ICommonBtAlwaysTrueDecorator GetRootAsICommonBtAlwaysTrueDecorator(ByteBuffer _bb)
		{
			return ICommonBtAlwaysTrueDecorator.GetRootAsICommonBtAlwaysTrueDecorator(_bb, default(ICommonBtAlwaysTrueDecorator));
		}

		// Token: 0x0602981B RID: 170011 RVA: 0x005AFDE0 File Offset: 0x005ADFE0
		public static ICommonBtAlwaysTrueDecorator GetRootAsICommonBtAlwaysTrueDecorator(ByteBuffer _bb, ICommonBtAlwaysTrueDecorator obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602981C RID: 170012 RVA: 0x005AFDFD File Offset: 0x005ADFFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602981D RID: 170013 RVA: 0x005AFE0C File Offset: 0x005AE00C
		public ICommonBtAlwaysTrueDecorator __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B50D RID: 46349
		// (get) Token: 0x0602981E RID: 170014 RVA: 0x005AFE1C File Offset: 0x005AE01C
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

		// Token: 0x0602981F RID: 170015 RVA: 0x005AFE58 File Offset: 0x005AE058
		public static Offset<ICommonBtAlwaysTrueDecorator> CreateICommonBtAlwaysTrueDecorator(FlatBufferBuilder builder, ECommonBtDecoratorType Type = ECommonBtDecoratorType.Condition)
		{
			builder.StartTable(1);
			ICommonBtAlwaysTrueDecorator.AddType(builder, Type);
			return ICommonBtAlwaysTrueDecorator.EndICommonBtAlwaysTrueDecorator(builder);
		}

		// Token: 0x06029820 RID: 170016 RVA: 0x005AFE6E File Offset: 0x005AE06E
		public static void StartICommonBtAlwaysTrueDecorator(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06029821 RID: 170017 RVA: 0x005AFE77 File Offset: 0x005AE077
		public static void AddType(FlatBufferBuilder builder, ECommonBtDecoratorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029822 RID: 170018 RVA: 0x005AFE82 File Offset: 0x005AE082
		public static Offset<ICommonBtAlwaysTrueDecorator> EndICommonBtAlwaysTrueDecorator(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtAlwaysTrueDecorator>(builder.EndTable());
		}

		// Token: 0x06029823 RID: 170019 RVA: 0x005AFE90 File Offset: 0x005AE090
		public ICommonBtAlwaysTrueDecoratorT UnPack()
		{
			ICommonBtAlwaysTrueDecoratorT commonBtAlwaysTrueDecoratorT = new ICommonBtAlwaysTrueDecoratorT();
			this.UnPackTo(commonBtAlwaysTrueDecoratorT);
			return commonBtAlwaysTrueDecoratorT;
		}

		// Token: 0x06029824 RID: 170020 RVA: 0x005AFEAB File Offset: 0x005AE0AB
		public void UnPackTo(ICommonBtAlwaysTrueDecoratorT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06029825 RID: 170021 RVA: 0x005AFEBC File Offset: 0x005AE0BC
		public static Offset<ICommonBtAlwaysTrueDecorator> Pack(FlatBufferBuilder builder, ICommonBtAlwaysTrueDecoratorT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonBtAlwaysTrueDecorator>);
			}
			return ICommonBtAlwaysTrueDecorator.CreateICommonBtAlwaysTrueDecorator(builder, _o.Type);
		}

		// Token: 0x0400F914 RID: 63764
		private Table __p;
	}
}
