using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x020064E8 RID: 25832
	public struct ICommonBtAlwaysTrueDecorator : IFlatbufferObject
	{
		// Token: 0x1700BE77 RID: 48759
		// (get) Token: 0x0602BEC0 RID: 179904 RVA: 0x005F8D51 File Offset: 0x005F6F51
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BEC1 RID: 179905 RVA: 0x005F8D5E File Offset: 0x005F6F5E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BEC2 RID: 179906 RVA: 0x005F8D68 File Offset: 0x005F6F68
		public static ICommonBtAlwaysTrueDecorator GetRootAsICommonBtAlwaysTrueDecorator(ByteBuffer _bb)
		{
			return ICommonBtAlwaysTrueDecorator.GetRootAsICommonBtAlwaysTrueDecorator(_bb, default(ICommonBtAlwaysTrueDecorator));
		}

		// Token: 0x0602BEC3 RID: 179907 RVA: 0x005F8D84 File Offset: 0x005F6F84
		public static ICommonBtAlwaysTrueDecorator GetRootAsICommonBtAlwaysTrueDecorator(ByteBuffer _bb, ICommonBtAlwaysTrueDecorator obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BEC4 RID: 179908 RVA: 0x005F8DA1 File Offset: 0x005F6FA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BEC5 RID: 179909 RVA: 0x005F8DB0 File Offset: 0x005F6FB0
		public ICommonBtAlwaysTrueDecorator __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BE78 RID: 48760
		// (get) Token: 0x0602BEC6 RID: 179910 RVA: 0x005F8DC0 File Offset: 0x005F6FC0
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

		// Token: 0x0602BEC7 RID: 179911 RVA: 0x005F8DFC File Offset: 0x005F6FFC
		public static Offset<ICommonBtAlwaysTrueDecorator> CreateICommonBtAlwaysTrueDecorator(FlatBufferBuilder builder, ECommonBtDecoratorType Type = ECommonBtDecoratorType.Condition)
		{
			builder.StartTable(1);
			ICommonBtAlwaysTrueDecorator.AddType(builder, Type);
			return ICommonBtAlwaysTrueDecorator.EndICommonBtAlwaysTrueDecorator(builder);
		}

		// Token: 0x0602BEC8 RID: 179912 RVA: 0x005F8E12 File Offset: 0x005F7012
		public static void StartICommonBtAlwaysTrueDecorator(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602BEC9 RID: 179913 RVA: 0x005F8E1B File Offset: 0x005F701B
		public static void AddType(FlatBufferBuilder builder, ECommonBtDecoratorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BECA RID: 179914 RVA: 0x005F8E26 File Offset: 0x005F7026
		public static Offset<ICommonBtAlwaysTrueDecorator> EndICommonBtAlwaysTrueDecorator(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtAlwaysTrueDecorator>(builder.EndTable());
		}

		// Token: 0x0602BECB RID: 179915 RVA: 0x005F8E34 File Offset: 0x005F7034
		public ICommonBtAlwaysTrueDecoratorT UnPack()
		{
			ICommonBtAlwaysTrueDecoratorT commonBtAlwaysTrueDecoratorT = new ICommonBtAlwaysTrueDecoratorT();
			this.UnPackTo(commonBtAlwaysTrueDecoratorT);
			return commonBtAlwaysTrueDecoratorT;
		}

		// Token: 0x0602BECC RID: 179916 RVA: 0x005F8E4F File Offset: 0x005F704F
		public void UnPackTo(ICommonBtAlwaysTrueDecoratorT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602BECD RID: 179917 RVA: 0x005F8E60 File Offset: 0x005F7060
		public static Offset<ICommonBtAlwaysTrueDecorator> Pack(FlatBufferBuilder builder, ICommonBtAlwaysTrueDecoratorT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonBtAlwaysTrueDecorator>);
			}
			return ICommonBtAlwaysTrueDecorator.CreateICommonBtAlwaysTrueDecorator(builder, _o.Type);
		}

		// Token: 0x04010677 RID: 67191
		private Table __p;
	}
}
