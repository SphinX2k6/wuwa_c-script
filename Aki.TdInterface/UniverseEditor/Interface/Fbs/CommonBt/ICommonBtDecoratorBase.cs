using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x020064F7 RID: 25847
	public struct ICommonBtDecoratorBase : IFlatbufferObject
	{
		// Token: 0x1700BE94 RID: 48788
		// (get) Token: 0x0602BFDB RID: 180187 RVA: 0x005FD446 File Offset: 0x005FB646
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BFDC RID: 180188 RVA: 0x005FD453 File Offset: 0x005FB653
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BFDD RID: 180189 RVA: 0x005FD45C File Offset: 0x005FB65C
		public static ICommonBtDecoratorBase GetRootAsICommonBtDecoratorBase(ByteBuffer _bb)
		{
			return ICommonBtDecoratorBase.GetRootAsICommonBtDecoratorBase(_bb, default(ICommonBtDecoratorBase));
		}

		// Token: 0x0602BFDE RID: 180190 RVA: 0x005FD478 File Offset: 0x005FB678
		public static ICommonBtDecoratorBase GetRootAsICommonBtDecoratorBase(ByteBuffer _bb, ICommonBtDecoratorBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BFDF RID: 180191 RVA: 0x005FD495 File Offset: 0x005FB695
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BFE0 RID: 180192 RVA: 0x005FD4A4 File Offset: 0x005FB6A4
		public ICommonBtDecoratorBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BE95 RID: 48789
		// (get) Token: 0x0602BFE1 RID: 180193 RVA: 0x005FD4B4 File Offset: 0x005FB6B4
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

		// Token: 0x0602BFE2 RID: 180194 RVA: 0x005FD4F0 File Offset: 0x005FB6F0
		public static Offset<ICommonBtDecoratorBase> CreateICommonBtDecoratorBase(FlatBufferBuilder builder, ECommonBtDecoratorType Type = ECommonBtDecoratorType.Condition)
		{
			builder.StartTable(1);
			ICommonBtDecoratorBase.AddType(builder, Type);
			return ICommonBtDecoratorBase.EndICommonBtDecoratorBase(builder);
		}

		// Token: 0x0602BFE3 RID: 180195 RVA: 0x005FD506 File Offset: 0x005FB706
		public static void StartICommonBtDecoratorBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602BFE4 RID: 180196 RVA: 0x005FD50F File Offset: 0x005FB70F
		public static void AddType(FlatBufferBuilder builder, ECommonBtDecoratorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BFE5 RID: 180197 RVA: 0x005FD51A File Offset: 0x005FB71A
		public static Offset<ICommonBtDecoratorBase> EndICommonBtDecoratorBase(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtDecoratorBase>(builder.EndTable());
		}

		// Token: 0x0602BFE6 RID: 180198 RVA: 0x005FD528 File Offset: 0x005FB728
		public ICommonBtDecoratorBaseT UnPack()
		{
			ICommonBtDecoratorBaseT commonBtDecoratorBaseT = new ICommonBtDecoratorBaseT();
			this.UnPackTo(commonBtDecoratorBaseT);
			return commonBtDecoratorBaseT;
		}

		// Token: 0x0602BFE7 RID: 180199 RVA: 0x005FD543 File Offset: 0x005FB743
		public void UnPackTo(ICommonBtDecoratorBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602BFE8 RID: 180200 RVA: 0x005FD554 File Offset: 0x005FB754
		public static Offset<ICommonBtDecoratorBase> Pack(FlatBufferBuilder builder, ICommonBtDecoratorBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonBtDecoratorBase>);
			}
			return ICommonBtDecoratorBase.CreateICommonBtDecoratorBase(builder, _o.Type);
		}

		// Token: 0x04010688 RID: 67208
		private Table __p;
	}
}
