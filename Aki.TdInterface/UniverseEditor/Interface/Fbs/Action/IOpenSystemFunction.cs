using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C42 RID: 27714
	public struct IOpenSystemFunction : IFlatbufferObject
	{
		// Token: 0x1700CE65 RID: 52837
		// (get) Token: 0x06030D16 RID: 199958 RVA: 0x006A1BAA File Offset: 0x0069FDAA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030D17 RID: 199959 RVA: 0x006A1BB7 File Offset: 0x0069FDB7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030D18 RID: 199960 RVA: 0x006A1BC0 File Offset: 0x0069FDC0
		public static IOpenSystemFunction GetRootAsIOpenSystemFunction(ByteBuffer _bb)
		{
			return IOpenSystemFunction.GetRootAsIOpenSystemFunction(_bb, default(IOpenSystemFunction));
		}

		// Token: 0x06030D19 RID: 199961 RVA: 0x006A1BDC File Offset: 0x0069FDDC
		public static IOpenSystemFunction GetRootAsIOpenSystemFunction(ByteBuffer _bb, IOpenSystemFunction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030D1A RID: 199962 RVA: 0x006A1BF9 File Offset: 0x0069FDF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030D1B RID: 199963 RVA: 0x006A1C08 File Offset: 0x0069FE08
		public IOpenSystemFunction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CE66 RID: 52838
		// (get) Token: 0x06030D1C RID: 199964 RVA: 0x006A1C18 File Offset: 0x0069FE18
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

		// Token: 0x06030D1D RID: 199965 RVA: 0x006A1C54 File Offset: 0x0069FE54
		public static Offset<IOpenSystemFunction> CreateIOpenSystemFunction(FlatBufferBuilder builder, int FunctionId = 0)
		{
			builder.StartTable(1);
			IOpenSystemFunction.AddFunctionId(builder, FunctionId);
			return IOpenSystemFunction.EndIOpenSystemFunction(builder);
		}

		// Token: 0x06030D1E RID: 199966 RVA: 0x006A1C6A File Offset: 0x0069FE6A
		public static void StartIOpenSystemFunction(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06030D1F RID: 199967 RVA: 0x006A1C73 File Offset: 0x0069FE73
		public static void AddFunctionId(FlatBufferBuilder builder, int functionId)
		{
			builder.AddInt(0, functionId, 0);
		}

		// Token: 0x06030D20 RID: 199968 RVA: 0x006A1C7E File Offset: 0x0069FE7E
		public static Offset<IOpenSystemFunction> EndIOpenSystemFunction(FlatBufferBuilder builder)
		{
			return new Offset<IOpenSystemFunction>(builder.EndTable());
		}

		// Token: 0x06030D21 RID: 199969 RVA: 0x006A1C8C File Offset: 0x0069FE8C
		public IOpenSystemFunctionT UnPack()
		{
			IOpenSystemFunctionT openSystemFunctionT = new IOpenSystemFunctionT();
			this.UnPackTo(openSystemFunctionT);
			return openSystemFunctionT;
		}

		// Token: 0x06030D22 RID: 199970 RVA: 0x006A1CA7 File Offset: 0x0069FEA7
		public void UnPackTo(IOpenSystemFunctionT _o)
		{
			_o.FunctionId = this.FunctionId;
		}

		// Token: 0x06030D23 RID: 199971 RVA: 0x006A1CB8 File Offset: 0x0069FEB8
		public static Offset<IOpenSystemFunction> Pack(FlatBufferBuilder builder, IOpenSystemFunctionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOpenSystemFunction>);
			}
			return IOpenSystemFunction.CreateIOpenSystemFunction(builder, _o.FunctionId);
		}

		// Token: 0x0401157F RID: 71039
		private Table __p;
	}
}
