using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x020064FD RID: 25853
	public struct ICommonBtDoOnceDecorator : IFlatbufferObject
	{
		// Token: 0x1700BE99 RID: 48793
		// (get) Token: 0x0602C001 RID: 180225 RVA: 0x005FD7CE File Offset: 0x005FB9CE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C002 RID: 180226 RVA: 0x005FD7DB File Offset: 0x005FB9DB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C003 RID: 180227 RVA: 0x005FD7E4 File Offset: 0x005FB9E4
		public static ICommonBtDoOnceDecorator GetRootAsICommonBtDoOnceDecorator(ByteBuffer _bb)
		{
			return ICommonBtDoOnceDecorator.GetRootAsICommonBtDoOnceDecorator(_bb, default(ICommonBtDoOnceDecorator));
		}

		// Token: 0x0602C004 RID: 180228 RVA: 0x005FD800 File Offset: 0x005FBA00
		public static ICommonBtDoOnceDecorator GetRootAsICommonBtDoOnceDecorator(ByteBuffer _bb, ICommonBtDoOnceDecorator obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C005 RID: 180229 RVA: 0x005FD81D File Offset: 0x005FBA1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C006 RID: 180230 RVA: 0x005FD82C File Offset: 0x005FBA2C
		public ICommonBtDoOnceDecorator __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BE9A RID: 48794
		// (get) Token: 0x0602C007 RID: 180231 RVA: 0x005FD83C File Offset: 0x005FBA3C
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

		// Token: 0x0602C008 RID: 180232 RVA: 0x005FD878 File Offset: 0x005FBA78
		public static Offset<ICommonBtDoOnceDecorator> CreateICommonBtDoOnceDecorator(FlatBufferBuilder builder, ECommonBtDecoratorType Type = ECommonBtDecoratorType.Condition)
		{
			builder.StartTable(1);
			ICommonBtDoOnceDecorator.AddType(builder, Type);
			return ICommonBtDoOnceDecorator.EndICommonBtDoOnceDecorator(builder);
		}

		// Token: 0x0602C009 RID: 180233 RVA: 0x005FD88E File Offset: 0x005FBA8E
		public static void StartICommonBtDoOnceDecorator(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602C00A RID: 180234 RVA: 0x005FD897 File Offset: 0x005FBA97
		public static void AddType(FlatBufferBuilder builder, ECommonBtDecoratorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C00B RID: 180235 RVA: 0x005FD8A2 File Offset: 0x005FBAA2
		public static Offset<ICommonBtDoOnceDecorator> EndICommonBtDoOnceDecorator(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtDoOnceDecorator>(builder.EndTable());
		}

		// Token: 0x0602C00C RID: 180236 RVA: 0x005FD8B0 File Offset: 0x005FBAB0
		public ICommonBtDoOnceDecoratorT UnPack()
		{
			ICommonBtDoOnceDecoratorT commonBtDoOnceDecoratorT = new ICommonBtDoOnceDecoratorT();
			this.UnPackTo(commonBtDoOnceDecoratorT);
			return commonBtDoOnceDecoratorT;
		}

		// Token: 0x0602C00D RID: 180237 RVA: 0x005FD8CB File Offset: 0x005FBACB
		public void UnPackTo(ICommonBtDoOnceDecoratorT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602C00E RID: 180238 RVA: 0x005FD8DC File Offset: 0x005FBADC
		public static Offset<ICommonBtDoOnceDecorator> Pack(FlatBufferBuilder builder, ICommonBtDoOnceDecoratorT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonBtDoOnceDecorator>);
			}
			return ICommonBtDoOnceDecorator.CreateICommonBtDoOnceDecorator(builder, _o.Type);
		}

		// Token: 0x04010694 RID: 67220
		private Table __p;
	}
}
