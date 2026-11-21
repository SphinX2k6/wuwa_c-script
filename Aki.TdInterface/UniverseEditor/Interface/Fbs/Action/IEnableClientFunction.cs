using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CC5 RID: 27845
	public struct IEnableClientFunction : IFlatbufferObject
	{
		// Token: 0x1700CC3D RID: 52285
		// (get) Token: 0x0602FFD8 RID: 196568 RVA: 0x00687E71 File Offset: 0x00686071
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FFD9 RID: 196569 RVA: 0x00687E7E File Offset: 0x0068607E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FFDA RID: 196570 RVA: 0x00687E88 File Offset: 0x00686088
		public static IEnableClientFunction GetRootAsIEnableClientFunction(ByteBuffer _bb)
		{
			return IEnableClientFunction.GetRootAsIEnableClientFunction(_bb, default(IEnableClientFunction));
		}

		// Token: 0x0602FFDB RID: 196571 RVA: 0x00687EA4 File Offset: 0x006860A4
		public static IEnableClientFunction GetRootAsIEnableClientFunction(ByteBuffer _bb, IEnableClientFunction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FFDC RID: 196572 RVA: 0x00687EC1 File Offset: 0x006860C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FFDD RID: 196573 RVA: 0x00687ED0 File Offset: 0x006860D0
		public IEnableClientFunction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CC3E RID: 52286
		// (get) Token: 0x0602FFDE RID: 196574 RVA: 0x00687EE0 File Offset: 0x006860E0
		public EEnableClientFunctionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEnableClientFunctionType.HealthBarDisplay;
				}
				return (EEnableClientFunctionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FFDF RID: 196575 RVA: 0x00687F1C File Offset: 0x0068611C
		public static Offset<IEnableClientFunction> CreateIEnableClientFunction(FlatBufferBuilder builder, EEnableClientFunctionType Type = EEnableClientFunctionType.HealthBarDisplay)
		{
			builder.StartTable(1);
			IEnableClientFunction.AddType(builder, Type);
			return IEnableClientFunction.EndIEnableClientFunction(builder);
		}

		// Token: 0x0602FFE0 RID: 196576 RVA: 0x00687F32 File Offset: 0x00686132
		public static void StartIEnableClientFunction(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602FFE1 RID: 196577 RVA: 0x00687F3B File Offset: 0x0068613B
		public static void AddType(FlatBufferBuilder builder, EEnableClientFunctionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FFE2 RID: 196578 RVA: 0x00687F46 File Offset: 0x00686146
		public static Offset<IEnableClientFunction> EndIEnableClientFunction(FlatBufferBuilder builder)
		{
			return new Offset<IEnableClientFunction>(builder.EndTable());
		}

		// Token: 0x0602FFE3 RID: 196579 RVA: 0x00687F54 File Offset: 0x00686154
		public IEnableClientFunctionT UnPack()
		{
			IEnableClientFunctionT enableClientFunctionT = new IEnableClientFunctionT();
			this.UnPackTo(enableClientFunctionT);
			return enableClientFunctionT;
		}

		// Token: 0x0602FFE4 RID: 196580 RVA: 0x00687F6F File Offset: 0x0068616F
		public void UnPackTo(IEnableClientFunctionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602FFE5 RID: 196581 RVA: 0x00687F80 File Offset: 0x00686180
		public static Offset<IEnableClientFunction> Pack(FlatBufferBuilder builder, IEnableClientFunctionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableClientFunction>);
			}
			return IEnableClientFunction.CreateIEnableClientFunction(builder, _o.Type);
		}

		// Token: 0x04011B0B RID: 72459
		private Table __p;
	}
}
