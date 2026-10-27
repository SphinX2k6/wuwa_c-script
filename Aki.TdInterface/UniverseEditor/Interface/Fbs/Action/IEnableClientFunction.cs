using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006654 RID: 26196
	public struct IEnableClientFunction : IFlatbufferObject
	{
		// Token: 0x1700C29F RID: 49823
		// (get) Token: 0x0602D807 RID: 186375 RVA: 0x0063B309 File Offset: 0x00639509
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D808 RID: 186376 RVA: 0x0063B316 File Offset: 0x00639516
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D809 RID: 186377 RVA: 0x0063B320 File Offset: 0x00639520
		public static IEnableClientFunction GetRootAsIEnableClientFunction(ByteBuffer _bb)
		{
			return IEnableClientFunction.GetRootAsIEnableClientFunction(_bb, default(IEnableClientFunction));
		}

		// Token: 0x0602D80A RID: 186378 RVA: 0x0063B33C File Offset: 0x0063953C
		public static IEnableClientFunction GetRootAsIEnableClientFunction(ByteBuffer _bb, IEnableClientFunction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D80B RID: 186379 RVA: 0x0063B359 File Offset: 0x00639559
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D80C RID: 186380 RVA: 0x0063B368 File Offset: 0x00639568
		public IEnableClientFunction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C2A0 RID: 49824
		// (get) Token: 0x0602D80D RID: 186381 RVA: 0x0063B378 File Offset: 0x00639578
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

		// Token: 0x0602D80E RID: 186382 RVA: 0x0063B3B4 File Offset: 0x006395B4
		public static Offset<IEnableClientFunction> CreateIEnableClientFunction(FlatBufferBuilder builder, EEnableClientFunctionType Type = EEnableClientFunctionType.HealthBarDisplay)
		{
			builder.StartTable(1);
			IEnableClientFunction.AddType(builder, Type);
			return IEnableClientFunction.EndIEnableClientFunction(builder);
		}

		// Token: 0x0602D80F RID: 186383 RVA: 0x0063B3CA File Offset: 0x006395CA
		public static void StartIEnableClientFunction(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602D810 RID: 186384 RVA: 0x0063B3D3 File Offset: 0x006395D3
		public static void AddType(FlatBufferBuilder builder, EEnableClientFunctionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D811 RID: 186385 RVA: 0x0063B3DE File Offset: 0x006395DE
		public static Offset<IEnableClientFunction> EndIEnableClientFunction(FlatBufferBuilder builder)
		{
			return new Offset<IEnableClientFunction>(builder.EndTable());
		}

		// Token: 0x0602D812 RID: 186386 RVA: 0x0063B3EC File Offset: 0x006395EC
		public IEnableClientFunctionT UnPack()
		{
			IEnableClientFunctionT enableClientFunctionT = new IEnableClientFunctionT();
			this.UnPackTo(enableClientFunctionT);
			return enableClientFunctionT;
		}

		// Token: 0x0602D813 RID: 186387 RVA: 0x0063B407 File Offset: 0x00639607
		public void UnPackTo(IEnableClientFunctionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602D814 RID: 186388 RVA: 0x0063B418 File Offset: 0x00639618
		public static Offset<IEnableClientFunction> Pack(FlatBufferBuilder builder, IEnableClientFunctionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableClientFunction>);
			}
			return IEnableClientFunction.CreateIEnableClientFunction(builder, _o.Type);
		}

		// Token: 0x04010CF0 RID: 68848
		private Table __p;
	}
}
