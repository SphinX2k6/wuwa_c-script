using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200727D RID: 29309
	public struct ISystemFunction : IFlatbufferObject
	{
		// Token: 0x1700D974 RID: 55668
		// (get) Token: 0x06034007 RID: 212999 RVA: 0x006FE1E0 File Offset: 0x006FC3E0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034008 RID: 213000 RVA: 0x006FE1ED File Offset: 0x006FC3ED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034009 RID: 213001 RVA: 0x006FE1F4 File Offset: 0x006FC3F4
		public static ISystemFunction GetRootAsISystemFunction(ByteBuffer _bb)
		{
			return ISystemFunction.GetRootAsISystemFunction(_bb, default(ISystemFunction));
		}

		// Token: 0x0603400A RID: 213002 RVA: 0x006FE210 File Offset: 0x006FC410
		public static ISystemFunction GetRootAsISystemFunction(ByteBuffer _bb, ISystemFunction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603400B RID: 213003 RVA: 0x006FE22D File Offset: 0x006FC42D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603400C RID: 213004 RVA: 0x006FE23C File Offset: 0x006FC43C
		public ISystemFunction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D975 RID: 55669
		// (get) Token: 0x0603400D RID: 213005 RVA: 0x006FE24C File Offset: 0x006FC44C
		public ESystemFunction Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESystemFunction.BuyGoods;
				}
				return (ESystemFunction)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603400E RID: 213006 RVA: 0x006FE288 File Offset: 0x006FC488
		public static Offset<ISystemFunction> CreateISystemFunction(FlatBufferBuilder builder, ESystemFunction Type = ESystemFunction.BuyGoods)
		{
			builder.StartTable(1);
			ISystemFunction.AddType(builder, Type);
			return ISystemFunction.EndISystemFunction(builder);
		}

		// Token: 0x0603400F RID: 213007 RVA: 0x006FE29E File Offset: 0x006FC49E
		public static void StartISystemFunction(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06034010 RID: 213008 RVA: 0x006FE2A7 File Offset: 0x006FC4A7
		public static void AddType(FlatBufferBuilder builder, ESystemFunction type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034011 RID: 213009 RVA: 0x006FE2B2 File Offset: 0x006FC4B2
		public static Offset<ISystemFunction> EndISystemFunction(FlatBufferBuilder builder)
		{
			return new Offset<ISystemFunction>(builder.EndTable());
		}

		// Token: 0x06034012 RID: 213010 RVA: 0x006FE2C0 File Offset: 0x006FC4C0
		public ISystemFunctionT UnPack()
		{
			ISystemFunctionT systemFunctionT = new ISystemFunctionT();
			this.UnPackTo(systemFunctionT);
			return systemFunctionT;
		}

		// Token: 0x06034013 RID: 213011 RVA: 0x006FE2DB File Offset: 0x006FC4DB
		public void UnPackTo(ISystemFunctionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06034014 RID: 213012 RVA: 0x006FE2EC File Offset: 0x006FC4EC
		public static Offset<ISystemFunction> Pack(FlatBufferBuilder builder, ISystemFunctionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISystemFunction>);
			}
			return ISystemFunction.CreateISystemFunction(builder, _o.Type);
		}

		// Token: 0x04011D83 RID: 73091
		private Table __p;
	}
}
