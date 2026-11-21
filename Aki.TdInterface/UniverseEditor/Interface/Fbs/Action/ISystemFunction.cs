using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A52 RID: 31314
	public struct ISystemFunction : IFlatbufferObject
	{
		// Token: 0x1700E56D RID: 58733
		// (get) Token: 0x06037309 RID: 226057 RVA: 0x0075F540 File Offset: 0x0075D740
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603730A RID: 226058 RVA: 0x0075F54D File Offset: 0x0075D74D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603730B RID: 226059 RVA: 0x0075F554 File Offset: 0x0075D754
		public static ISystemFunction GetRootAsISystemFunction(ByteBuffer _bb)
		{
			return ISystemFunction.GetRootAsISystemFunction(_bb, default(ISystemFunction));
		}

		// Token: 0x0603730C RID: 226060 RVA: 0x0075F570 File Offset: 0x0075D770
		public static ISystemFunction GetRootAsISystemFunction(ByteBuffer _bb, ISystemFunction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603730D RID: 226061 RVA: 0x0075F58D File Offset: 0x0075D78D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603730E RID: 226062 RVA: 0x0075F59C File Offset: 0x0075D79C
		public ISystemFunction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E56E RID: 58734
		// (get) Token: 0x0603730F RID: 226063 RVA: 0x0075F5AC File Offset: 0x0075D7AC
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

		// Token: 0x06037310 RID: 226064 RVA: 0x0075F5E8 File Offset: 0x0075D7E8
		public static Offset<ISystemFunction> CreateISystemFunction(FlatBufferBuilder builder, ESystemFunction Type = ESystemFunction.BuyGoods)
		{
			builder.StartTable(1);
			ISystemFunction.AddType(builder, Type);
			return ISystemFunction.EndISystemFunction(builder);
		}

		// Token: 0x06037311 RID: 226065 RVA: 0x0075F5FE File Offset: 0x0075D7FE
		public static void StartISystemFunction(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06037312 RID: 226066 RVA: 0x0075F607 File Offset: 0x0075D807
		public static void AddType(FlatBufferBuilder builder, ESystemFunction type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06037313 RID: 226067 RVA: 0x0075F612 File Offset: 0x0075D812
		public static Offset<ISystemFunction> EndISystemFunction(FlatBufferBuilder builder)
		{
			return new Offset<ISystemFunction>(builder.EndTable());
		}

		// Token: 0x06037314 RID: 226068 RVA: 0x0075F620 File Offset: 0x0075D820
		public ISystemFunctionT UnPack()
		{
			ISystemFunctionT systemFunctionT = new ISystemFunctionT();
			this.UnPackTo(systemFunctionT);
			return systemFunctionT;
		}

		// Token: 0x06037315 RID: 226069 RVA: 0x0075F63B File Offset: 0x0075D83B
		public void UnPackTo(ISystemFunctionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06037316 RID: 226070 RVA: 0x0075F64C File Offset: 0x0075D84C
		public static Offset<ISystemFunction> Pack(FlatBufferBuilder builder, ISystemFunctionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISystemFunction>);
			}
			return ISystemFunction.CreateISystemFunction(builder, _o.Type);
		}

		// Token: 0x04012D85 RID: 77189
		private Table __p;
	}
}
