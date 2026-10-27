using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E79 RID: 28281
	public struct IRequestSystemFunction : IFlatbufferObject
	{
		// Token: 0x1700D2A6 RID: 53926
		// (get) Token: 0x06031FC1 RID: 204737 RVA: 0x006C304D File Offset: 0x006C124D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031FC2 RID: 204738 RVA: 0x006C305A File Offset: 0x006C125A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031FC3 RID: 204739 RVA: 0x006C3064 File Offset: 0x006C1264
		public static IRequestSystemFunction GetRootAsIRequestSystemFunction(ByteBuffer _bb)
		{
			return IRequestSystemFunction.GetRootAsIRequestSystemFunction(_bb, default(IRequestSystemFunction));
		}

		// Token: 0x06031FC4 RID: 204740 RVA: 0x006C3080 File Offset: 0x006C1280
		public static IRequestSystemFunction GetRootAsIRequestSystemFunction(ByteBuffer _bb, IRequestSystemFunction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031FC5 RID: 204741 RVA: 0x006C309D File Offset: 0x006C129D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031FC6 RID: 204742 RVA: 0x006C30AC File Offset: 0x006C12AC
		public IRequestSystemFunction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D2A7 RID: 53927
		// (get) Token: 0x06031FC7 RID: 204743 RVA: 0x006C30BC File Offset: 0x006C12BC
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

		// Token: 0x06031FC8 RID: 204744 RVA: 0x006C3119 File Offset: 0x006C1319
		public static Offset<IRequestSystemFunction> CreateIRequestSystemFunction(FlatBufferBuilder builder, Offset<IBuyGoods> SystemFunctionOffset = default(Offset<IBuyGoods>))
		{
			builder.StartTable(1);
			IRequestSystemFunction.AddSystemFunction(builder, SystemFunctionOffset);
			return IRequestSystemFunction.EndIRequestSystemFunction(builder);
		}

		// Token: 0x06031FC9 RID: 204745 RVA: 0x006C312F File Offset: 0x006C132F
		public static void StartIRequestSystemFunction(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031FCA RID: 204746 RVA: 0x006C3138 File Offset: 0x006C1338
		public static void AddSystemFunction(FlatBufferBuilder builder, Offset<IBuyGoods> systemFunctionOffset)
		{
			builder.AddOffset(0, systemFunctionOffset.Value, 0);
		}

		// Token: 0x06031FCB RID: 204747 RVA: 0x006C3148 File Offset: 0x006C1348
		public static Offset<IRequestSystemFunction> EndIRequestSystemFunction(FlatBufferBuilder builder)
		{
			return new Offset<IRequestSystemFunction>(builder.EndTable());
		}

		// Token: 0x06031FCC RID: 204748 RVA: 0x006C3158 File Offset: 0x006C1358
		public IRequestSystemFunctionT UnPack()
		{
			IRequestSystemFunctionT requestSystemFunctionT = new IRequestSystemFunctionT();
			this.UnPackTo(requestSystemFunctionT);
			return requestSystemFunctionT;
		}

		// Token: 0x06031FCD RID: 204749 RVA: 0x006C3174 File Offset: 0x006C1374
		public void UnPackTo(IRequestSystemFunctionT _o)
		{
			_o.SystemFunction = ((this.SystemFunction != null) ? this.SystemFunction.Value.UnPack() : null);
		}

		// Token: 0x06031FCE RID: 204750 RVA: 0x006C31B0 File Offset: 0x006C13B0
		public static Offset<IRequestSystemFunction> Pack(FlatBufferBuilder builder, IRequestSystemFunctionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRequestSystemFunction>);
			}
			Offset<IBuyGoods> systemFunctionOffset = (_o.SystemFunction == null) ? default(Offset<IBuyGoods>) : IBuyGoods.Pack(builder, _o.SystemFunction);
			return IRequestSystemFunction.CreateIRequestSystemFunction(builder, systemFunctionOffset);
		}

		// Token: 0x04011866 RID: 71782
		private Table __p;
	}
}
