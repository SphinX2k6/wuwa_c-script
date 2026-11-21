using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075FD RID: 30205
	public struct IRequestSystemFunction : IFlatbufferObject
	{
		// Token: 0x1700DDFD RID: 56829
		// (get) Token: 0x06035001 RID: 217089 RVA: 0x0071ED81 File Offset: 0x0071CF81
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035002 RID: 217090 RVA: 0x0071ED8E File Offset: 0x0071CF8E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035003 RID: 217091 RVA: 0x0071ED98 File Offset: 0x0071CF98
		public static IRequestSystemFunction GetRootAsIRequestSystemFunction(ByteBuffer _bb)
		{
			return IRequestSystemFunction.GetRootAsIRequestSystemFunction(_bb, default(IRequestSystemFunction));
		}

		// Token: 0x06035004 RID: 217092 RVA: 0x0071EDB4 File Offset: 0x0071CFB4
		public static IRequestSystemFunction GetRootAsIRequestSystemFunction(ByteBuffer _bb, IRequestSystemFunction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035005 RID: 217093 RVA: 0x0071EDD1 File Offset: 0x0071CFD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035006 RID: 217094 RVA: 0x0071EDE0 File Offset: 0x0071CFE0
		public IRequestSystemFunction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DDFE RID: 56830
		// (get) Token: 0x06035007 RID: 217095 RVA: 0x0071EDF0 File Offset: 0x0071CFF0
		public IBuyGoods? SystemFunction
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IBuyGoods?(default(IBuyGoods).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06035008 RID: 217096 RVA: 0x0071EE4D File Offset: 0x0071D04D
		public static Offset<IRequestSystemFunction> CreateIRequestSystemFunction(FlatBufferBuilder builder, Offset<IBuyGoods> SystemFunctionOffset = default(Offset<IBuyGoods>))
		{
			builder.StartTable(1);
			IRequestSystemFunction.AddSystemFunction(builder, SystemFunctionOffset);
			return IRequestSystemFunction.EndIRequestSystemFunction(builder);
		}

		// Token: 0x06035009 RID: 217097 RVA: 0x0071EE63 File Offset: 0x0071D063
		public static void StartIRequestSystemFunction(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603500A RID: 217098 RVA: 0x0071EE6C File Offset: 0x0071D06C
		public static void AddSystemFunction(FlatBufferBuilder builder, Offset<IBuyGoods> systemFunctionOffset)
		{
			builder.AddOffset(0, systemFunctionOffset.Value, 0);
		}

		// Token: 0x0603500B RID: 217099 RVA: 0x0071EE7C File Offset: 0x0071D07C
		public static Offset<IRequestSystemFunction> EndIRequestSystemFunction(FlatBufferBuilder builder)
		{
			return new Offset<IRequestSystemFunction>(builder.EndTable());
		}

		// Token: 0x0603500C RID: 217100 RVA: 0x0071EE8C File Offset: 0x0071D08C
		public IRequestSystemFunctionT UnPack()
		{
			IRequestSystemFunctionT requestSystemFunctionT = new IRequestSystemFunctionT();
			this.UnPackTo(requestSystemFunctionT);
			return requestSystemFunctionT;
		}

		// Token: 0x0603500D RID: 217101 RVA: 0x0071EEA8 File Offset: 0x0071D0A8
		public void UnPackTo(IRequestSystemFunctionT _o)
		{
			_o.SystemFunction = ((this.SystemFunction != null) ? this.SystemFunction.Value.UnPack() : null);
		}

		// Token: 0x0603500E RID: 217102 RVA: 0x0071EEE4 File Offset: 0x0071D0E4
		public static Offset<IRequestSystemFunction> Pack(FlatBufferBuilder builder, IRequestSystemFunctionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRequestSystemFunction>);
			}
			Offset<IBuyGoods> systemFunctionOffset = (_o.SystemFunction == null) ? default(Offset<IBuyGoods>) : IBuyGoods.Pack(builder, _o.SystemFunction);
			return IRequestSystemFunction.CreateIRequestSystemFunction(builder, systemFunctionOffset);
		}

		// Token: 0x040127EB RID: 75755
		private Table __p;
	}
}
