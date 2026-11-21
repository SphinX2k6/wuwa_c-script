using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070B8 RID: 28856
	public struct ILiftMoveTypeDefault : IFlatbufferObject
	{
		// Token: 0x1700D364 RID: 54116
		// (get) Token: 0x060321B7 RID: 205239 RVA: 0x006C8072 File Offset: 0x006C6272
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060321B8 RID: 205240 RVA: 0x006C807F File Offset: 0x006C627F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060321B9 RID: 205241 RVA: 0x006C8088 File Offset: 0x006C6288
		public static ILiftMoveTypeDefault GetRootAsILiftMoveTypeDefault(ByteBuffer _bb)
		{
			return ILiftMoveTypeDefault.GetRootAsILiftMoveTypeDefault(_bb, default(ILiftMoveTypeDefault));
		}

		// Token: 0x060321BA RID: 205242 RVA: 0x006C80A4 File Offset: 0x006C62A4
		public static ILiftMoveTypeDefault GetRootAsILiftMoveTypeDefault(ByteBuffer _bb, ILiftMoveTypeDefault obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060321BB RID: 205243 RVA: 0x006C80C1 File Offset: 0x006C62C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060321BC RID: 205244 RVA: 0x006C80D0 File Offset: 0x006C62D0
		public ILiftMoveTypeDefault __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D365 RID: 54117
		// (get) Token: 0x060321BD RID: 205245 RVA: 0x006C80E0 File Offset: 0x006C62E0
		public ELiftMoveType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELiftMoveType.Default;
				}
				return (ELiftMoveType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060321BE RID: 205246 RVA: 0x006C811C File Offset: 0x006C631C
		public static Offset<ILiftMoveTypeDefault> CreateILiftMoveTypeDefault(FlatBufferBuilder builder, ELiftMoveType Type = ELiftMoveType.Default)
		{
			builder.StartTable(1);
			ILiftMoveTypeDefault.AddType(builder, Type);
			return ILiftMoveTypeDefault.EndILiftMoveTypeDefault(builder);
		}

		// Token: 0x060321BF RID: 205247 RVA: 0x006C8132 File Offset: 0x006C6332
		public static void StartILiftMoveTypeDefault(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060321C0 RID: 205248 RVA: 0x006C813B File Offset: 0x006C633B
		public static void AddType(FlatBufferBuilder builder, ELiftMoveType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060321C1 RID: 205249 RVA: 0x006C8146 File Offset: 0x006C6346
		public static Offset<ILiftMoveTypeDefault> EndILiftMoveTypeDefault(FlatBufferBuilder builder)
		{
			return new Offset<ILiftMoveTypeDefault>(builder.EndTable());
		}

		// Token: 0x060321C2 RID: 205250 RVA: 0x006C8154 File Offset: 0x006C6354
		public ILiftMoveTypeDefaultT UnPack()
		{
			ILiftMoveTypeDefaultT liftMoveTypeDefaultT = new ILiftMoveTypeDefaultT();
			this.UnPackTo(liftMoveTypeDefaultT);
			return liftMoveTypeDefaultT;
		}

		// Token: 0x060321C3 RID: 205251 RVA: 0x006C816F File Offset: 0x006C636F
		public void UnPackTo(ILiftMoveTypeDefaultT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060321C4 RID: 205252 RVA: 0x006C8180 File Offset: 0x006C6380
		public static Offset<ILiftMoveTypeDefault> Pack(FlatBufferBuilder builder, ILiftMoveTypeDefaultT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiftMoveTypeDefault>);
			}
			return ILiftMoveTypeDefault.CreateILiftMoveTypeDefault(builder, _o.Type);
		}

		// Token: 0x04012072 RID: 73842
		private Table __p;
	}
}
