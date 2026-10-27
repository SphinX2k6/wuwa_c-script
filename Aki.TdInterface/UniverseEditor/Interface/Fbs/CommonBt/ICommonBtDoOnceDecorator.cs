using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005EBA RID: 24250
	public struct ICommonBtDoOnceDecorator : IFlatbufferObject
	{
		// Token: 0x1700B52E RID: 46382
		// (get) Token: 0x0602994D RID: 170317 RVA: 0x005B42EA File Offset: 0x005B24EA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602994E RID: 170318 RVA: 0x005B42F7 File Offset: 0x005B24F7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602994F RID: 170319 RVA: 0x005B4300 File Offset: 0x005B2500
		public static ICommonBtDoOnceDecorator GetRootAsICommonBtDoOnceDecorator(ByteBuffer _bb)
		{
			return ICommonBtDoOnceDecorator.GetRootAsICommonBtDoOnceDecorator(_bb, default(ICommonBtDoOnceDecorator));
		}

		// Token: 0x06029950 RID: 170320 RVA: 0x005B431C File Offset: 0x005B251C
		public static ICommonBtDoOnceDecorator GetRootAsICommonBtDoOnceDecorator(ByteBuffer _bb, ICommonBtDoOnceDecorator obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029951 RID: 170321 RVA: 0x005B4339 File Offset: 0x005B2539
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029952 RID: 170322 RVA: 0x005B4348 File Offset: 0x005B2548
		public ICommonBtDoOnceDecorator __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B52F RID: 46383
		// (get) Token: 0x06029953 RID: 170323 RVA: 0x005B4358 File Offset: 0x005B2558
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

		// Token: 0x06029954 RID: 170324 RVA: 0x005B4394 File Offset: 0x005B2594
		public static Offset<ICommonBtDoOnceDecorator> CreateICommonBtDoOnceDecorator(FlatBufferBuilder builder, ECommonBtDecoratorType Type = ECommonBtDecoratorType.Condition)
		{
			builder.StartTable(1);
			ICommonBtDoOnceDecorator.AddType(builder, Type);
			return ICommonBtDoOnceDecorator.EndICommonBtDoOnceDecorator(builder);
		}

		// Token: 0x06029955 RID: 170325 RVA: 0x005B43AA File Offset: 0x005B25AA
		public static void StartICommonBtDoOnceDecorator(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06029956 RID: 170326 RVA: 0x005B43B3 File Offset: 0x005B25B3
		public static void AddType(FlatBufferBuilder builder, ECommonBtDecoratorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029957 RID: 170327 RVA: 0x005B43BE File Offset: 0x005B25BE
		public static Offset<ICommonBtDoOnceDecorator> EndICommonBtDoOnceDecorator(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtDoOnceDecorator>(builder.EndTable());
		}

		// Token: 0x06029958 RID: 170328 RVA: 0x005B43CC File Offset: 0x005B25CC
		public ICommonBtDoOnceDecoratorT UnPack()
		{
			ICommonBtDoOnceDecoratorT commonBtDoOnceDecoratorT = new ICommonBtDoOnceDecoratorT();
			this.UnPackTo(commonBtDoOnceDecoratorT);
			return commonBtDoOnceDecoratorT;
		}

		// Token: 0x06029959 RID: 170329 RVA: 0x005B43E7 File Offset: 0x005B25E7
		public void UnPackTo(ICommonBtDoOnceDecoratorT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602995A RID: 170330 RVA: 0x005B43F8 File Offset: 0x005B25F8
		public static Offset<ICommonBtDoOnceDecorator> Pack(FlatBufferBuilder builder, ICommonBtDoOnceDecoratorT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonBtDoOnceDecorator>);
			}
			return ICommonBtDoOnceDecorator.CreateICommonBtDoOnceDecorator(builder, _o.Type);
		}

		// Token: 0x0400F931 RID: 63793
		private Table __p;
	}
}
