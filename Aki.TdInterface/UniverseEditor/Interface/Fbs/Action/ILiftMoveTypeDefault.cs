using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A08 RID: 27144
	public struct ILiftMoveTypeDefault : IFlatbufferObject
	{
		// Token: 0x1700C964 RID: 51556
		// (get) Token: 0x0602F7F7 RID: 194551 RVA: 0x00677D1A File Offset: 0x00675F1A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F7F8 RID: 194552 RVA: 0x00677D27 File Offset: 0x00675F27
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F7F9 RID: 194553 RVA: 0x00677D30 File Offset: 0x00675F30
		public static ILiftMoveTypeDefault GetRootAsILiftMoveTypeDefault(ByteBuffer _bb)
		{
			return ILiftMoveTypeDefault.GetRootAsILiftMoveTypeDefault(_bb, default(ILiftMoveTypeDefault));
		}

		// Token: 0x0602F7FA RID: 194554 RVA: 0x00677D4C File Offset: 0x00675F4C
		public static ILiftMoveTypeDefault GetRootAsILiftMoveTypeDefault(ByteBuffer _bb, ILiftMoveTypeDefault obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F7FB RID: 194555 RVA: 0x00677D69 File Offset: 0x00675F69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F7FC RID: 194556 RVA: 0x00677D78 File Offset: 0x00675F78
		public ILiftMoveTypeDefault __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C965 RID: 51557
		// (get) Token: 0x0602F7FD RID: 194557 RVA: 0x00677D88 File Offset: 0x00675F88
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

		// Token: 0x0602F7FE RID: 194558 RVA: 0x00677DC4 File Offset: 0x00675FC4
		public static Offset<ILiftMoveTypeDefault> CreateILiftMoveTypeDefault(FlatBufferBuilder builder, ELiftMoveType Type = ELiftMoveType.Default)
		{
			builder.StartTable(1);
			ILiftMoveTypeDefault.AddType(builder, Type);
			return ILiftMoveTypeDefault.EndILiftMoveTypeDefault(builder);
		}

		// Token: 0x0602F7FF RID: 194559 RVA: 0x00677DDA File Offset: 0x00675FDA
		public static void StartILiftMoveTypeDefault(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F800 RID: 194560 RVA: 0x00677DE3 File Offset: 0x00675FE3
		public static void AddType(FlatBufferBuilder builder, ELiftMoveType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F801 RID: 194561 RVA: 0x00677DEE File Offset: 0x00675FEE
		public static Offset<ILiftMoveTypeDefault> EndILiftMoveTypeDefault(FlatBufferBuilder builder)
		{
			return new Offset<ILiftMoveTypeDefault>(builder.EndTable());
		}

		// Token: 0x0602F802 RID: 194562 RVA: 0x00677DFC File Offset: 0x00675FFC
		public ILiftMoveTypeDefaultT UnPack()
		{
			ILiftMoveTypeDefaultT liftMoveTypeDefaultT = new ILiftMoveTypeDefaultT();
			this.UnPackTo(liftMoveTypeDefaultT);
			return liftMoveTypeDefaultT;
		}

		// Token: 0x0602F803 RID: 194563 RVA: 0x00677E17 File Offset: 0x00676017
		public void UnPackTo(ILiftMoveTypeDefaultT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602F804 RID: 194564 RVA: 0x00677E28 File Offset: 0x00676028
		public static Offset<ILiftMoveTypeDefault> Pack(FlatBufferBuilder builder, ILiftMoveTypeDefaultT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiftMoveTypeDefault>);
			}
			return ILiftMoveTypeDefault.CreateILiftMoveTypeDefault(builder, _o.Type);
		}

		// Token: 0x04011208 RID: 70152
		private Table __p;
	}
}
