using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073A9 RID: 29609
	public struct IOpenSystemFunction : IFlatbufferObject
	{
		// Token: 0x1700D980 RID: 55680
		// (get) Token: 0x06033C71 RID: 212081 RVA: 0x006FC0AC File Offset: 0x006FA2AC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033C72 RID: 212082 RVA: 0x006FC0B9 File Offset: 0x006FA2B9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033C73 RID: 212083 RVA: 0x006FC0C0 File Offset: 0x006FA2C0
		public static IOpenSystemFunction GetRootAsIOpenSystemFunction(ByteBuffer _bb)
		{
			return IOpenSystemFunction.GetRootAsIOpenSystemFunction(_bb, default(IOpenSystemFunction));
		}

		// Token: 0x06033C74 RID: 212084 RVA: 0x006FC0DC File Offset: 0x006FA2DC
		public static IOpenSystemFunction GetRootAsIOpenSystemFunction(ByteBuffer _bb, IOpenSystemFunction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033C75 RID: 212085 RVA: 0x006FC0F9 File Offset: 0x006FA2F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033C76 RID: 212086 RVA: 0x006FC108 File Offset: 0x006FA308
		public IOpenSystemFunction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D981 RID: 55681
		// (get) Token: 0x06033C77 RID: 212087 RVA: 0x006FC118 File Offset: 0x006FA318
		public int FunctionId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033C78 RID: 212088 RVA: 0x006FC154 File Offset: 0x006FA354
		public static Offset<IOpenSystemFunction> CreateIOpenSystemFunction(FlatBufferBuilder builder, int FunctionId = 0)
		{
			builder.StartTable(1);
			IOpenSystemFunction.AddFunctionId(builder, FunctionId);
			return IOpenSystemFunction.EndIOpenSystemFunction(builder);
		}

		// Token: 0x06033C79 RID: 212089 RVA: 0x006FC16A File Offset: 0x006FA36A
		public static void StartIOpenSystemFunction(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033C7A RID: 212090 RVA: 0x006FC173 File Offset: 0x006FA373
		public static void AddFunctionId(FlatBufferBuilder builder, int functionId)
		{
			builder.AddInt(0, functionId, 0);
		}

		// Token: 0x06033C7B RID: 212091 RVA: 0x006FC17E File Offset: 0x006FA37E
		public static Offset<IOpenSystemFunction> EndIOpenSystemFunction(FlatBufferBuilder builder)
		{
			return new Offset<IOpenSystemFunction>(builder.EndTable());
		}

		// Token: 0x06033C7C RID: 212092 RVA: 0x006FC18C File Offset: 0x006FA38C
		public IOpenSystemFunctionT UnPack()
		{
			IOpenSystemFunctionT openSystemFunctionT = new IOpenSystemFunctionT();
			this.UnPackTo(openSystemFunctionT);
			return openSystemFunctionT;
		}

		// Token: 0x06033C7D RID: 212093 RVA: 0x006FC1A7 File Offset: 0x006FA3A7
		public void UnPackTo(IOpenSystemFunctionT _o)
		{
			_o.FunctionId = this.FunctionId;
		}

		// Token: 0x06033C7E RID: 212094 RVA: 0x006FC1B8 File Offset: 0x006FA3B8
		public static Offset<IOpenSystemFunction> Pack(FlatBufferBuilder builder, IOpenSystemFunctionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOpenSystemFunction>);
			}
			return IOpenSystemFunction.CreateIOpenSystemFunction(builder, _o.FunctionId);
		}

		// Token: 0x040124D7 RID: 74967
		private Table __p;
	}
}
